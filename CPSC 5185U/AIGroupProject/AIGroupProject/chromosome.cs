using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIGroupProject
{
    class chromosome
    {
        int[] dna;
        int id;
        double fitness;
        Random rnd = new Random();

        public chromosome(int dnaLength)
        {
            rnd = new Random();
            dna = new int[dnaLength];
            id = 0;
            fitness = 0;
        }

        public int[] returnDNA()
        {
            return dna;
        }

        public void setDNA(int[] newDNA)
        {
            dna = newDNA;
        }

        public int returnID()
        {
            return id;
        }

        public void setFitness(double newFitness)
        {
            fitness = newFitness;
        }

        public double returnFitness()
        {
            return fitness;
        }

        public void generateDNA()
        {
            for(int i = 0; i < dna.Length; i++)
            {
                dna[i] = rnd.Next(4);
            }
        }

        public void generateID()
        {
            id = rnd.Next(1000);
        }
    }
}
