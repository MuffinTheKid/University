using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIGroupProject
{
    class reproducer
    {
        

        public reproducer()
        {

        }

        public int[] crossover(int[] father, int[] mother)
        {
            Random rand = new Random();
            int[] child1 = new int[father.Length];
            int[] child2 = new int[father.Length];
            int[] finalChild = new int[father.Length];
            int crossPoint = rand.Next(0, ((father.Length/3) + 1));
            int crossPoint2 = rand.Next(((father.Length / 3) + 1), ((father.Length / 3) + (father.Length /3) + 1));
            int crossPoint3 = rand.Next(((father.Length / 3) + (father.Length / 3) + 1), (father.Length + 1));
            int dnaAmount = rand.Next(0, father.Length);

            for (int i = 0; i < father.Length; i++)
            {
                if (i <= crossPoint)
                {
                    child1[i] = father[i];
                }

                else if(i >= crossPoint2 && i < crossPoint3)
                {
                    child1[i] = mother[i];
                }

                else if(i >= crossPoint3)
                {
                    child1[i] = father[i];
                }

                else
                {
                    child1[i] = mother[i];
                }
            }
            /*for (int i = 0; i < dnaAmount; i++)
            {
                int index = rand.Next(0, father.Length);
                child1[index] = father[index];
            }

            for (int i = 0; i < child1.Length; i++)
            {
                if(child1[i] == null)
                {
                    child1[i] = mother[i];
                }
            }

            for (int i = 0; i < dnaAmount; i++)
            {
                int index = rand.Next(0, father.Length);
                child2[index] = father[index];
            }

            for (int i = 0; i < child2.Length; i++)
            {
                if (child2[i] == null)
                {
                    child2[i] = mother[i];
                }
            }



                for (int i = 0; i < father.Length; i++)
                {
                    if (i <= crossPoint)
                    {
                        finalChild[i] = child1[i];
                    }

                    else
                    {
                        finalChild[i] = child2[i];
                    }
                }*/

                return child1;
        }

        public int[] mutate(int[] child)
        {
            Random rand = new Random();
            int mutatePoint = rand.Next(child.Length);

            for(int i = 0; i < child.Length; i++)
            {
                if(i == mutatePoint)
                {
                    child[i] = rand.Next(4);
                    break;
                }
            }
            return child;
        }
    }
}
