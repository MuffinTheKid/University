using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIGroupProject
{
    class generation
    {
        Dictionary<int, chromosome> population = new Dictionary<int, chromosome>();
        int[] popKeys;
        Random rnd = new Random();
        int popTotal;
        reproducer repo = new reproducer();
        chromosome chromo = new chromosome(0);
        chromosome father = new chromosome(0);
        chromosome mother = new chromosome(0);
        chromosome child = new chromosome(0);


        public generation()
        {
            population = new Dictionary<int, chromosome>();
            popKeys = new int[10];
            rnd = new Random();
            popTotal = 10;
            chromo = new chromosome(0);
        }

        public void populate(int chromoLength, int position)
        {
            chromo = new chromosome(chromoLength);
            int keyID;
            chromo.generateID();
            keyID = chromo.returnID();
            if (popKeys.ElementAt(0) == keyID)
            {
                while (popKeys.Contains(keyID) == true)
                {
                    chromo.generateID();
                    keyID = chromo.returnID();
                }
            }

            else
            {
                while (popKeys.Contains(keyID) == true)
                {
                    chromo.generateID();
                    keyID = chromo.returnID();
                }
            }
            chromo.generateDNA();
            population.Add(keyID, chromo);
            popKeys[position] = keyID;
        }

        public void mutateChromo()
        {
            Random rnd = new Random();
            int percent = rnd.Next(0, 100);
            int index = rnd.Next(0, popKeys.Length);
            chromosome temp = new chromosome(0);
            int tempKey = popKeys[index];
            population.TryGetValue(tempKey, out temp);
            temp.setDNA(repo.mutate(temp.returnDNA()));
            population[tempKey] = temp;
            popTotal = population.Count;
        }

        public void crossoverChromo()
        {
            Random rnd = new Random();

               int fIndex = rnd.Next(0, popKeys.Length);
               int mIndex = rnd.Next(0, popKeys.Length);
                if (mIndex == fIndex)
                {
                    bool bOut = false;
                    while (bOut == false)
                    {
                        mIndex = rnd.Next(0, popKeys.Length);
                        if (mIndex != fIndex)
                        {
                            bOut = true;
                        }
                    }
                }
          
            int fKey = popKeys[fIndex];
            int mKey = popKeys[mIndex];
            father = new chromosome(0);
            mother = new chromosome(0);
            population.TryGetValue(fKey, out father);
            population.TryGetValue(mKey, out mother);
            child = new chromosome(father.returnDNA().Length);
            bool breakout = false;
            if (popKeys.ElementAt(0) != 0)
            {
                while (breakout == false)
                {
                    child.generateID();                    
                    if (!popKeys.Contains(child.returnID()))
                    {
                        breakout = true;
                    }
                }
            }
            int newKey = child.returnID();
            child.setDNA(repo.crossover(father.returnDNA(), mother.returnDNA()));
            population.Add(newKey, child);
            popTotal = population.Count;
            popKeys = population.Keys.ToArray();
        }

        public void removeChromo(chromosome chromo1, chromosome chromo2)
        {
            
            for(int i = 0; i < popTotal; i++)
            {
                int key = popKeys[i];
                chromosome tempChromo = new chromosome(0);
                population.TryGetValue(key, out tempChromo);

                if(tempChromo != chromo1)
                {
                    if(tempChromo != chromo2)
                    {
                        population.Remove(key);
                    }
                }
            }
            popTotal = population.Count;
            popKeys = new int[popTotal];
            popKeys = population.Keys.ToArray();
        }

        public Dictionary<int, chromosome> returnPopulation()
        {
            return population;
        }

        public void adjustPopulation(Dictionary<int, chromosome> adjust)
        {
            population = adjust;
        }

        public int returnTotalPopulation()
        {
            return popTotal;
        }

        public int[] returnPopKeys()
        {
            return popKeys;
        }
    }
}
