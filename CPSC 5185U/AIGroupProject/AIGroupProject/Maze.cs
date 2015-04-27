using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIGroupProject
{
    public partial class Maze : Form
    {
        public Maze()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int[] testChromosome = { 2, 2, 0, 2, 0, 0, 0, 2 };
            generation testGeneration = new generation();
            reproducer testReproducer = new reproducer();
            evaluator testEvaluator = new evaluator(testChromosome);
            int[] solution = new int[testChromosome.Length];

            for (int i = 0; i < 10; i++)
            {
                testGeneration.populate(testChromosome.Length, i);
            }

            int count = 0;
            bool test = false;
            while (test == false)
            {
                Dictionary<int, chromosome> tempPop = testGeneration.returnPopulation();
                int[] tempKeys = testGeneration.returnPopKeys();

                for (int i = 0; i < tempPop.Count; i++)
                {
                    chromosome temp = new chromosome(0);
                    tempPop.TryGetValue(tempKeys[i], out temp);
                    temp = testEvaluator.evaluateChromo(temp);
                    tempPop[tempKeys[i]] = temp;
                }

                testGeneration.adjustPopulation(tempPop);
                testGeneration = testEvaluator.evaluateGen(testGeneration);
                if (testGeneration.returnTotalPopulation() == 0)
                {
                    generation tempGen = new generation();
                    testGeneration = tempGen;
                    for (int i = 0; i < 10; i++)
                    {
                        testGeneration.populate(testChromosome.Length, i);
                    }
                }
                for (int x = (10 - testGeneration.returnTotalPopulation()); x > 0; x = (10 - testGeneration.returnTotalPopulation()))
                {
                    Random rand = new Random();
                    int roll = rand.Next(1, 101);

                    if (roll <= 30)
                    {
                        testGeneration.mutateChromo();
                    }

                    else if (roll >= 31 && roll <= 100)
                    {
                        testGeneration.crossoverChromo();
                    }

                }
                solution = testEvaluator.CheckFitLevels(testGeneration);
                if(solution.Length > 0)
                {
                    test = true;
                }
                count++;

                if (count == 5000)
                {
                    testGeneration = new generation();
                    for (int i = 0; i < 10; i++)
                    {
                        testGeneration.populate(testChromosome.Length, i);
                    }
                    count = 0;
                }
            }
            int a = 0;
            int b = 0;
            for(int i = 0; i < solution.Length; i++)
            {
                PictureBox[,] mazeArray = new PictureBox[5, 5] { {pbC1R1, pbC2R1, pbC3R1, pbC4R1, pbC5R1},
                                                             {pbC1R2, pbC2R2, pbC3R2, pbC4R2, pbC5R2},
                                                             {pbC1R3, pbC2R3, pbC3R3, pbC4R3, pbC5R3},
                                                             {pbC1R4, pbC2R4, pbC3R4, pbC4R4, pbC5R4},
                                                             {pbC1R5, pbC2R5, pbC3R4, pbC4R5, pbC5R5} };

                
                int sol = solution[i];

                if (sol == 0)
                {
                    a += 1;
                }

                else if (sol == 1)
                {
                    a -= 1;
                }

                else if (sol == 2)
                {
                    b += 1;
                }

                else if (sol == 3)
                {
                    b -= 1;
                }

                mazeArray[a, b].BackColor = Color.Black;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
             int[] testChromosome = { 0, 2, 0, 0, 0, 0, 2, 2 };
            generation testGeneration = new generation();
            reproducer testReproducer = new reproducer();
            evaluator testEvaluator = new evaluator(testChromosome);
            int[] solution = new int[testChromosome.Length];

            for (int i = 0; i < 10; i++)
            {
                testGeneration.populate(testChromosome.Length, i);
            }

            int count = 0;
            bool test = false;
            while (test == false)
            {
                Dictionary<int, chromosome> tempPop = testGeneration.returnPopulation();
                int[] tempKeys = testGeneration.returnPopKeys();

                for (int i = 0; i < tempPop.Count; i++)
                {
                    chromosome temp = new chromosome(0);
                    tempPop.TryGetValue(tempKeys[i], out temp);
                    temp = testEvaluator.evaluateChromo(temp);
                    tempPop[tempKeys[i]] = temp;
                }

                testGeneration.adjustPopulation(tempPop);
                testGeneration = testEvaluator.evaluateGen(testGeneration);
                if (testGeneration.returnTotalPopulation() == 0)
                {
                    generation tempGen = new generation();
                    testGeneration = tempGen;
                    for (int i = 0; i < 10; i++)
                    {
                        testGeneration.populate(testChromosome.Length, i);
                    }
                }
                for (int x = (10 - testGeneration.returnTotalPopulation()); x > 0; x = (10 - testGeneration.returnTotalPopulation()))
                {
                    Random rand = new Random();
                    int roll = rand.Next(1, 101);

                    if (roll <= 30)
                    {
                        testGeneration.mutateChromo();
                    }

                    else if (roll >= 31 && roll <= 100)
                    {
                        testGeneration.crossoverChromo();
                    }

                }
                solution = testEvaluator.CheckFitLevels(testGeneration);
                if(solution.Length > 0)
                {
                    test = true;
                }
                count++;

                if (count == 5000)
                {
                    testGeneration = new generation();
                    for (int i = 0; i < 10; i++)
                    {
                        testGeneration.populate(testChromosome.Length, i);
                    }
                    count = 0;
                }
            }
            int a = 0;
            int b = 0;
            for(int i = 0; i < solution.Length; i++)
            {
                PictureBox[,] mazeArray = new PictureBox[5, 5] { {pb2C1R1, pb2C2R1, pb2C3R1, pb2C4R1, pb2C5R1},
                                                             {pb2C1R2, pb2C2R2, pb2C3R2, pb2C4R2, pb2C5R2},
                                                             {pb2C1R3, pb2C2R3, pb2C3R3, pb2C4R3, pb2C5R3},
                                                             {pb2C1R4, pb2C2R4, pb2C3R4, pb2C4R4, pb2C5R4},
                                                             {pb2C1R5, pb2C2R5, pb2C3R4, pb2C4R5, pb2C5R5} };

                
                int sol = solution[i];

                if (sol == 0)
                {
                    a += 1;
                }

                else if (sol == 1)
                {
                    a -= 1;
                }

                else if (sol == 2)
                {
                    b += 1;
                }

                else if (sol == 3)
                {
                    b -= 1;
                }

                mazeArray[a, b].BackColor = Color.Black;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
             int[] testChromosome = { 2, 0, 2, 2, 0, 2, 0, 0};
            generation testGeneration = new generation();
            reproducer testReproducer = new reproducer();
            evaluator testEvaluator = new evaluator(testChromosome);
            int[] solution = new int[testChromosome.Length];

            for (int i = 0; i < 10; i++)
            {
                testGeneration.populate(testChromosome.Length, i);
            }

            int count = 0;
            bool test = false;
            while (test == false)
            {
                Dictionary<int, chromosome> tempPop = testGeneration.returnPopulation();
                int[] tempKeys = testGeneration.returnPopKeys();

                for (int i = 0; i < tempPop.Count; i++)
                {
                    chromosome temp = new chromosome(0);
                    tempPop.TryGetValue(tempKeys[i], out temp);
                    temp = testEvaluator.evaluateChromo(temp);
                    tempPop[tempKeys[i]] = temp;
                }

                testGeneration.adjustPopulation(tempPop);
                testGeneration = testEvaluator.evaluateGen(testGeneration);
                if (testGeneration.returnTotalPopulation() == 0)
                {
                    generation tempGen = new generation();
                    testGeneration = tempGen;
                    for (int i = 0; i < 10; i++)
                    {
                        testGeneration.populate(testChromosome.Length, i);
                    }
                }
                for (int x = (10 - testGeneration.returnTotalPopulation()); x > 0; x = (10 - testGeneration.returnTotalPopulation()))
                {
                    Random rand = new Random();
                    int roll = rand.Next(1, 101);

                    if (roll <= 30)
                    {
                        testGeneration.mutateChromo();
                    }

                    else if (roll >= 31 && roll <= 100)
                    {
                        testGeneration.crossoverChromo();
                    }

                }
                solution = testEvaluator.CheckFitLevels(testGeneration);
                if(solution.Length > 0)
                {
                    test = true;
                }
                count++;

                if (count == 5000)
                {
                    testGeneration = new generation();
                    for (int i = 0; i < 10; i++)
                    {
                        testGeneration.populate(testChromosome.Length, i);
                    }
                    count = 0;
                }
            }
            int a = 0;
            int b = 0;
            for(int i = 0; i < solution.Length; i++)
            {
                PictureBox[,] mazeArray = new PictureBox[5, 5] { {pb3C1R1, pb3C2R1, pb3C3R1, pb3C4R1, pb3C5R1},
                                                             {pb3C1R2, pb3C2R2, pb3C3R2, pb3C4R2, pb3C5R2},
                                                             {pb3C1R3, pb3C2R3, pb3C3R3, pb3C4R3, pb3C5R3},
                                                             {pb3C1R4, pb3C2R4, pb3C3R4, pb3C4R4, pb3C5R4},
                                                             {pb3C1R5, pb3C2R5, pb3C3R4, pb3C4R5, pb3C5R5} };

                
                int sol = solution[i];

                if (sol == 0)
                {
                    a += 1;
                }

                else if (sol == 1)
                {
                    a -= 1;
                }

                else if (sol == 2)
                {
                    b += 1;
                }

                else if (sol == 3)
                {
                    b -= 1;
                }

                mazeArray[a, b].BackColor = Color.Black;
            }
            
        }
    }
}
