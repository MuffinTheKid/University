using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIGroupProject
{
    class evaluator
    {
        int[] testChromo;
        double fitIncrement;
        bool testR = false;
        int correctnessCheck = 0;

        public evaluator(int[] test)
        {
            testChromo = test;
            fitIncrement = 0;
            testR = false;
            correctnessCheck = (100 / testChromo.Length) * testChromo.Length;
        }

        public chromosome evaluateChromo(chromosome temp)
        {
            chromosome tempC = temp;
            int[] tempDNA = tempC.returnDNA();
            fitIncrement = (100 / testChromo.Length);
            double fitness = fitIncrement;
            for(int i = 0; i < tempDNA.Length; i++)
            {
                if (tempDNA[i] == testChromo[i])
                {
                    tempC.setFitness(fitness);
                    fitness += fitIncrement;
                }
            }

            return tempC;
        }

        public generation evaluateGen(generation temp)
        {
            generation tempGen = temp;
            chromosome[] mostFit = new chromosome[2];
            Dictionary<int, chromosome> tempPop = tempGen.returnPopulation();
            int[] tempKeys = tempGen.returnPopKeys();

            for (int i = 0; i < tempPop.Count; i++)
            {
                chromosome tempChromo = new chromosome(0);
                int tKey = tempKeys[i];
                tempPop.TryGetValue(tKey, out tempChromo);
                if(mostFit[0] == null)
                {
                    mostFit[0] = tempChromo;
                }
                else
                {
                    if(mostFit[0].returnFitness() < tempChromo.returnFitness())
                    {
                        chromosome tempChromo2 = mostFit[0];
                        mostFit[0] = tempChromo;

                        if(mostFit[1] == null)
                        {
                            mostFit[1] = tempChromo2;
                        }
                        else
                        {
                            if(mostFit[1].returnFitness() < tempChromo2.returnFitness())
                            {
                                mostFit[1] = tempChromo2;
                            }
                        }
                    }
                    else if(mostFit[1] == null)
                    {
                        mostFit[1] = tempChromo;
                    }
                    else if(mostFit[1].returnFitness() < tempChromo.returnFitness())
                    {
                        mostFit[1] = tempChromo;
                    }
                }
            }
            tempGen.removeChromo(mostFit[0], mostFit[1]);
            return tempGen;
        }

        public int[] CheckFitLevels(generation temp)
        {
            Dictionary<int, chromosome> tempPop = temp.returnPopulation();
            int[] tempKeys = temp.returnPopKeys();
            chromosome tempChromo = new chromosome(0);
            int[] solution = new int[0];

            for(int i = 0; i < tempPop.Count(); i++)
            {
                tempPop.TryGetValue(tempKeys[i], out tempChromo);
                
                if (tempChromo.returnFitness() >= correctnessCheck)
                {
                    Console.Out.Write("100%" + "\n");
                    solution = tempChromo.returnDNA();
                    string dnaString = "";
                    foreach (int strand in solution)
                    {
                        dnaString += strand;
                    }
                    Console.Out.Write(dnaString + "\n");
                    testR = true;
                }
            }

            if(testR == false)
            {
                Console.Out.Write("No solution generated yet.\n" + "Current Generation: \n");
                for (int x = 0; x < tempPop.Count; x++)
                {
                    chromosome tempC = new chromosome(0);
                    tempPop.TryGetValue(tempKeys[x], out tempC);
                    int[] dna = tempC.returnDNA();
                    string dnaString = "";
                    foreach (int strand in dna)
                    {
                        dnaString += strand;
                    }
                    Console.Out.Write(dnaString + "\n");
                }
            }

            return solution;
        }
    }
}
