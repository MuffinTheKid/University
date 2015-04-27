using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*Authors: Taylor Ehrhart, Ryan Fernandes, Adam Hickman, Nicolas Polhamus
 *Program Name: Codebreaker: Beat the Mastermind
 *Program Objective:
 * 
 * 
 *Last Revision Date: 4/8/2014 3:12 PM
 */ 

namespace guiProject
{
    public partial class Form1 : Form
    {
        //Variables and such will go after this line
        Color selectedColor;
        //String mode; to be implemented
        int lineCounter = 1; 

        public Form1()
        {
            InitializeComponent();
            randomizeCode();
        }

        private void lineSixNode1_Click(object sender, EventArgs e)
        {
            lineSixNode1.FillColor = selectedColor;
        }

        //checkLineSixNode2
        private void ovalShape12_Click(object sender, EventArgs e)
        {
            this.ForeColor = selectedColor;
        }

        //checkLineSixNode1
        private void ovalShape11_Click(object sender, EventArgs e)
        {
            this.ForeColor = selectedColor;
        }

        private void codeNode1_Click(object sender, EventArgs e)
        {

        }

        private void codeNode2_Click(object sender, EventArgs e)
        {

        }

        private void codeNode3_Click(object sender, EventArgs e)
        {

        }

        private void codeNode4_Click(object sender, EventArgs e)
        {

        }

        private void lineOneNode1_Click(object sender, EventArgs e)
        {
            lineOneNode1.FillColor = selectedColor;
        }

        private void lineOneNode2_Click(object sender, EventArgs e)
        {
            lineOneNode2.FillColor = selectedColor;
        }

        private void lineOneNode3_Click(object sender, EventArgs e)
        {
            lineOneNode3.FillColor = selectedColor;
        }

        private void lineOneNode4_Click(object sender, EventArgs e)
        {
            lineOneNode4.FillColor = selectedColor;
        }

        private void lineTwoNode1_Click(object sender, EventArgs e)
        {
            lineTwoNode1.FillColor = selectedColor;
        }

        private void lineTwoNode2_Click(object sender, EventArgs e)
        {
            lineTwoNode2.FillColor = selectedColor;
        }

        private void lineTwoNode3_Click(object sender, EventArgs e)
        {
            lineTwoNode3.FillColor = selectedColor;
        }

        private void lineTwoNode4_Click(object sender, EventArgs e)
        {
            lineTwoNode4.FillColor = selectedColor;
        }

        private void lineThreeNode1_Click(object sender, EventArgs e)
        {
            lineThreeNode1.FillColor = selectedColor;
        }

        private void lineThreeNode2_Click(object sender, EventArgs e)
        {
            lineThreeNode2.FillColor = selectedColor;
        }

        private void lineThreeNode3_Click(object sender, EventArgs e)
        {
            lineThreeNode3.FillColor = selectedColor;
        }

        private void lineThreeNode4_Click(object sender, EventArgs e)
        {
            lineThreeNode4.FillColor = selectedColor;
        }

        private void lineFourNode1_Click(object sender, EventArgs e)
        {
            lineFourNode1.FillColor = selectedColor;
        }

        private void lineFourNode2_Click(object sender, EventArgs e)
        {
            lineFourNode2.FillColor = selectedColor;
        }

        private void lineFourNode3_Click(object sender, EventArgs e)
        {
            lineFourNode3.FillColor = selectedColor;
        }

        private void lineFourNode4_Click(object sender, EventArgs e)
        {
            lineFourNode4.FillColor = selectedColor;
        }

        private void lineFiveNode1_Click(object sender, EventArgs e)
        {
            lineFiveNode1.FillColor = selectedColor;
        }

        private void lineFiveNode2_Click(object sender, EventArgs e)
        {
            lineFiveNode2.FillColor = selectedColor;
        }

        private void lineFiveNode3_Click(object sender, EventArgs e)
        {
            lineFiveNode3.FillColor = selectedColor;
        }

        private void lineFiveNode4_Click(object sender, EventArgs e)
        {
            lineFiveNode4.FillColor = selectedColor;
        }

        private void lineSixNode2_Click(object sender, EventArgs e)
        {
            lineSixNode2.FillColor = selectedColor;
        }

        private void lineSixNode3_Click(object sender, EventArgs e)
        {
            lineSixNode3.FillColor = selectedColor;
        }

        private void lineSixNode4_Click(object sender, EventArgs e)
        {
            lineSixNode4.FillColor = selectedColor;
        }

        private void lineSevenNode1_Click(object sender, EventArgs e)
        {
            lineSevenNode1.FillColor = selectedColor;
        }

        private void lineSevenNode2_Click(object sender, EventArgs e)
        {
            lineSevenNode2.FillColor = selectedColor;
        }

        private void lineSevenNode3_Click(object sender, EventArgs e)
        {
            lineSevenNode3.FillColor = selectedColor;
        }

        private void lineSevenNode4_Click(object sender, EventArgs e)
        {
            lineSevenNode4.FillColor = selectedColor;
        }

        private void lineEightNode1_Click(object sender, EventArgs e)
        {
            lineEightNode1.FillColor = selectedColor;
        }

        private void lineEightNode2_Click(object sender, EventArgs e)
        {
            lineEightNode2.FillColor = selectedColor;
        }

        private void lineEightNode3_Click(object sender, EventArgs e)
        {
            lineEightNode3.FillColor = selectedColor;
        }

        private void lineEightNode4_Click(object sender, EventArgs e)
        {
            lineEightNode4.FillColor = selectedColor;
        }

        private void checkLineOneNode1_Click(object sender, EventArgs e)
        {

        }

        private void checkLineOneNode2_Click(object sender, EventArgs e)
        {

        }

        private void checkLineOneNode3_Click(object sender, EventArgs e)
        {

        }

        private void checkLineOneNode4_Click(object sender, EventArgs e)
        {

        }

        private void checkLineTwoNode1_Click(object sender, EventArgs e)
        {

        }

        private void checkLineTwoNode2_Click(object sender, EventArgs e)
        {

        }

        private void checkLineTwoNode3_Click(object sender, EventArgs e)
        {

        }

        private void checkLineTwoNode4_Click(object sender, EventArgs e)
        {

        }

        private void checkLineThreeNode1_Click(object sender, EventArgs e)
        {

        }

        private void checkLineThreeNode2_Click(object sender, EventArgs e)
        {

        }

        private void checkLineThreeNode3_Click(object sender, EventArgs e)
        {

        }

        private void checkLineThreeNode4_Click(object sender, EventArgs e)
        {

        }

        private void checkLineFourNode1_Click(object sender, EventArgs e)
        {

        }

        private void checkLineFourNode2_Click(object sender, EventArgs e)
        {

        }

        private void checkLineFourNode3_Click(object sender, EventArgs e)
        {

        }

        private void checkLineFourNode4_Click(object sender, EventArgs e)
        {

        }

        private void checkLineFiveNode1_Click(object sender, EventArgs e)
        {

        }

        private void checkLineFiveNode2_Click(object sender, EventArgs e)
        {

        }

        private void checkLineFiveNode3_Click(object sender, EventArgs e)
        {

        }

        private void checkLineFiveNode4_Click(object sender, EventArgs e)
        {

        }

        private void checkLineSixNode3_Click(object sender, EventArgs e)
        {

        }

        private void checkLineSixNode4_Click(object sender, EventArgs e)
        {

        }

        private void checkLineSevenNode1_Click(object sender, EventArgs e)
        {

        }

        private void checkLineSevenNode2_Click(object sender, EventArgs e)
        {

        }

        private void checkLineSevenNode3_Click(object sender, EventArgs e)
        {

        }

        private void checkLineSevenNode4_Click(object sender, EventArgs e)
        {

        }

        private void checkLineEightNode1_Click(object sender, EventArgs e)
        {

        }

        private void checkLineEightNode2_Click(object sender, EventArgs e)
        {

        }

        private void checkLineEightNode3_Click(object sender, EventArgs e)
        {

        }

        private void checkLineEightNode4_Click(object sender, EventArgs e)
        {

        }

        private void colorChoice1_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Red;
        }

        private void colorChoice2_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Blue;
        }

        private void colorChoice3_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Green;
        }

        private void colorChoice4_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Yellow;
        }

        private void colorChoice5_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Brown;
        }

        private void colorChoice6_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Pink;
        }

        private void colorChoice7_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Purple;
        }

        private void colorChoice8_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Orange;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if(lineCounter == 1)
            {
                checkLineOne();
                bool solved = checkIfSolved();
                if(solved == true)
                {
                    MessageBox.Show("Congratulations! You have beaten the game! To play again, close this window and click the restart button.", 
                        "You won!", MessageBoxButtons.OK);
                }

                else
                {
                    lineCounter++;
                    makeLineVisible(lineCounter);
                }
                
            }

            else if (lineCounter == 2)
            {
                checkLineTwo();
                bool solved = checkIfSolved();
                if (solved == true)
                {
                    MessageBox.Show("Congratulations! You have beaten the game! To play again, close this window and click the restart button.", 
                        "You won!", MessageBoxButtons.OK);
                }

                else
                {
                    lineCounter++;
                    makeLineVisible(lineCounter);
                }
            }

            else if (lineCounter == 3)
            {
                checkLineThree();
                bool solved = checkIfSolved();
                if (solved == true)
                {
                    MessageBox.Show("Congratulations! You have beaten the game! To play again, close this window and click the restart button.", 
                        "You won!", MessageBoxButtons.OK);
                }

                else
                {
                    lineCounter++;
                    makeLineVisible(lineCounter);
                }
            }

            else if (lineCounter == 4)
            {
                checkLineFour();
                bool solved = checkIfSolved();
                if (solved == true)
                {
                    MessageBox.Show("Congratulations! You have beaten the game! To play again, close this window and click the restart button.", 
                        "You won!", MessageBoxButtons.OK);
                }

                else
                {
                    lineCounter++;
                    makeLineVisible(lineCounter);
                }
            }

            else if (lineCounter == 5)
            {
                checkLineFive();
                bool solved = checkIfSolved();
                if (solved == true)
                {
                    MessageBox.Show("Congratulations! You have beaten the game! To play again, close this window and click the restart button.", 
                        "You won!", MessageBoxButtons.OK);
                }

                else
                {
                    lineCounter++;
                    makeLineVisible(lineCounter);
                }
            }

            else if (lineCounter == 6)
            {
                checkLineSix();
                bool solved = checkIfSolved();
                if (solved == true)
                {
                    MessageBox.Show("Congratulations! You have beaten the game! To play again, close this window and click the restart button.", 
                        "You won!", MessageBoxButtons.OK);
                }

                else
                {
                    lineCounter++;
                    makeLineVisible(lineCounter);
                }
            }

            else if (lineCounter == 7)
            {
                checkLineSeven();
                bool solved = checkIfSolved();
                if (solved == true)
                {
                    MessageBox.Show("Congratulations! You have beaten the game! To play again, close this window and click the restart button.", 
                        "You won!", MessageBoxButtons.OK);
                }
                
                else
                {
                    lineCounter++;
                    makeLineVisible(lineCounter);
                }
            }

            else if (lineCounter == 8)
            {
                checkLineEight();
                bool solved = checkIfSolved();
                if (solved == true)
                {
                    MessageBox.Show("Congratulations! You have beaten the game! To play again, close this window and click the restart button.", 
                        "You won!", MessageBoxButtons.OK);
                }

                else
                {
                    codeNode1.Visible = true;
                    codeNode2.Visible = true;
                    codeNode3.Visible = true;
                    codeNode4.Visible = true;
                    MessageBox.Show("Sorry, but you have lost! That is ok though, you can try breaking a new code! Just click the restart button.",
                        "You lost.", MessageBoxButtons.OK);
                }
            }
        }

        private void randomizeCode()
        {
            Color[] colorList = { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Brown, Color.Pink, Color.Purple, Color.Orange };

            Random randomIndex = new Random();
            int index = randomIndex.Next(colorList.Length);

            codeNode1.FillColor = colorList.ElementAt(index);
            index = randomIndex.Next(colorList.Length);
            codeNode2.FillColor = colorList.ElementAt(index);
            index = randomIndex.Next(colorList.Length);
            codeNode3.FillColor = colorList.ElementAt(index);
            index = randomIndex.Next(colorList.Length);
            codeNode4.FillColor = colorList.ElementAt(index);
        }

        private void makeLineInvisible()
        {
           
                lineTwoNode1.Visible = false;
                lineTwoNode2.Visible = false;
                lineTwoNode3.Visible = false;
                lineTwoNode4.Visible = false;
                checkLineTwoNode1.Visible = false;
                checkLineTwoNode2.Visible = false;
                checkLineTwoNode3.Visible = false;
                checkLineTwoNode4.Visible = false;

                lineThreeNode1.Visible = false;
                lineThreeNode2.Visible = false;
                lineThreeNode3.Visible = false;
                lineThreeNode4.Visible = false;
                checkLineThreeNode1.Visible = false;
                checkLineThreeNode2.Visible = false;
                checkLineThreeNode3.Visible = false;
                checkLineThreeNode4.Visible = false;

                lineFourNode1.Visible = false;
                lineFourNode2.Visible = false;
                lineFourNode3.Visible = false;
                lineFourNode4.Visible = false;
                checkLineFourNode1.Visible = false;
                checkLineFourNode2.Visible = false;
                checkLineFourNode3.Visible = false;
                checkLineFourNode4.Visible = false;

                lineFiveNode1.Visible = false;
                lineFiveNode2.Visible = false;
                lineFiveNode3.Visible = false;
                lineFiveNode4.Visible = false;
                checkLineFiveNode1.Visible = false;
                checkLineFiveNode2.Visible = false;
                checkLineFiveNode3.Visible = false;
                checkLineFiveNode4.Visible = false;

                lineSixNode1.Visible = false;
                lineSixNode2.Visible = false;
                lineSixNode3.Visible = false;
                lineSixNode4.Visible = false;
                checkLineSixNode1.Visible = false;
                checkLineSixNode2.Visible = false;
                checkLineSixNode3.Visible = false;
                checkLineSixNode4.Visible = false;

                lineSevenNode1.Visible = false;
                lineSevenNode2.Visible = false;
                lineSevenNode3.Visible = false;
                lineSevenNode4.Visible = false;
                checkLineSevenNode1.Visible = false;
                checkLineSevenNode2.Visible = false;
                checkLineSevenNode3.Visible = false;
                checkLineSevenNode4.Visible = false;

                lineEightNode1.Visible = false;
                lineEightNode2.Visible = false;
                lineEightNode3.Visible = false;
                lineEightNode4.Visible = false;
                checkLineEightNode1.Visible = false;
                checkLineEightNode2.Visible = false;
                checkLineEightNode3.Visible = false;
                checkLineEightNode4.Visible = false;

                codeNode1.Visible = false;
                codeNode2.Visible = false;
                codeNode3.Visible = false;
                codeNode4.Visible = false;
            
        }

        private void makeLineVisible(int line)
        {
            if (line == 2)
            {
                lineTwoNode1.Visible = true;
                lineTwoNode2.Visible = true;
                lineTwoNode3.Visible = true;
                lineTwoNode4.Visible = true;
                checkLineTwoNode1.Visible = true;
                checkLineTwoNode2.Visible = true;
                checkLineTwoNode3.Visible = true;
                checkLineTwoNode4.Visible = true;
            }

            else if (line == 3)
            {
                lineThreeNode1.Visible = true;
                lineThreeNode2.Visible = true;
                lineThreeNode3.Visible = true;
                lineThreeNode4.Visible = true;
                checkLineThreeNode1.Visible = true;
                checkLineThreeNode2.Visible = true;
                checkLineThreeNode3.Visible = true;
                checkLineThreeNode4.Visible = true;
            }

            else if (line == 4)
            {
                lineFourNode1.Visible = true;
                lineFourNode2.Visible = true;
                lineFourNode3.Visible = true;
                lineFourNode4.Visible = true;
                checkLineFourNode1.Visible = true;
                checkLineFourNode2.Visible = true;
                checkLineFourNode3.Visible = true;
                checkLineFourNode4.Visible = true;
            }

            else if (line == 5)
            {
                lineFiveNode1.Visible = true;
                lineFiveNode2.Visible = true;
                lineFiveNode3.Visible = true;
                lineFiveNode4.Visible = true;
                checkLineFiveNode1.Visible = true;
                checkLineFiveNode2.Visible = true;
                checkLineFiveNode3.Visible = true;
                checkLineFiveNode4.Visible = true;
            }

            else if (line == 6)
            {
                lineSixNode1.Visible = true;
                lineSixNode2.Visible = true;
                lineSixNode3.Visible = true;
                lineSixNode4.Visible = true;
                checkLineSixNode1.Visible = true;
                checkLineSixNode2.Visible = true;
                checkLineSixNode3.Visible = true;
                checkLineSixNode4.Visible = true;
            }

            else if (line == 7)
            {
                lineSevenNode1.Visible = true;
                lineSevenNode2.Visible = true;
                lineSevenNode3.Visible = true;
                lineSevenNode4.Visible = true;
                checkLineSevenNode1.Visible = true;
                checkLineSevenNode2.Visible = true;
                checkLineSevenNode3.Visible = true;
                checkLineSevenNode4.Visible = true;
            }

            else if (line == 8)
            {
                lineEightNode1.Visible = true;
                lineEightNode2.Visible = true;
                lineEightNode3.Visible = true;
                lineEightNode4.Visible = true;
                checkLineEightNode1.Visible = true;
                checkLineEightNode2.Visible = true;
                checkLineEightNode3.Visible = true;
                checkLineEightNode4.Visible = true;
            }
        }

        private void checkLineOne()
        {

                if(lineOneNode1.FillColor != codeNode1.FillColor)
                {
                    if(lineOneNode1.FillColor == codeNode2.FillColor || lineOneNode1.FillColor == codeNode3.FillColor || 
                        lineOneNode1.FillColor == codeNode4.FillColor)
                    {
                        checkLineOneNode1.FillColor = Color.White;
                    }
                }

                else
                {
                    checkLineOneNode1.FillColor = Color.Black;
                }

                if (lineOneNode2.FillColor != codeNode2.FillColor)
                {
                    if (lineOneNode2.FillColor == codeNode1.FillColor || lineOneNode2.FillColor == codeNode3.FillColor ||
                        lineOneNode2.FillColor == codeNode4.FillColor)
                    {
                        checkLineOneNode2.FillColor = Color.White;
                    }
                }

                else
                {
                    checkLineOneNode2.FillColor = Color.Black;
                }

                if (lineOneNode3.FillColor != codeNode3.FillColor)
                {
                    if (lineOneNode3.FillColor == codeNode1.FillColor || lineOneNode3.FillColor == codeNode2.FillColor ||
                        lineOneNode3.FillColor == codeNode4.FillColor)
                    {
                        checkLineOneNode3.FillColor = Color.White;
                    }
                }

                else
                {
                    checkLineOneNode3.FillColor = Color.Black;
                }

                if (lineOneNode4.FillColor != codeNode4.FillColor)
                {
                    if (lineOneNode4.FillColor == codeNode1.FillColor || lineOneNode4.FillColor == codeNode2.FillColor ||
                        lineOneNode4.FillColor == codeNode3.FillColor)
                    {
                        checkLineOneNode4.FillColor = Color.White;
                    }
                }

                else
                {
                    checkLineOneNode4.FillColor = Color.Black;
                }
            }

            private void checkLineTwo()
            {

                if(lineTwoNode1.FillColor != codeNode1.FillColor)
                {
                    if(lineTwoNode1.FillColor == codeNode2.FillColor || lineTwoNode1.FillColor == codeNode3.FillColor || 
                        lineTwoNode1.FillColor == codeNode4.FillColor)
                    {
                        checkLineTwoNode1.FillColor = Color.White;
                    }
                }

                else
                {
                    checkLineTwoNode1.FillColor = Color.Black;
                }

                if (lineTwoNode2.FillColor != codeNode2.FillColor)
                {
                    if (lineTwoNode2.FillColor == codeNode1.FillColor || lineTwoNode2.FillColor == codeNode3.FillColor ||
                        lineTwoNode2.FillColor == codeNode4.FillColor)
                    {
                        checkLineTwoNode2.FillColor = Color.White;
                    }
                }

                else
                {
                    checkLineTwoNode2.FillColor = Color.Black;
                }

                if (lineTwoNode3.FillColor != codeNode3.FillColor)
                {
                    if (lineTwoNode3.FillColor == codeNode1.FillColor || lineTwoNode3.FillColor == codeNode2.FillColor ||
                        lineTwoNode3.FillColor == codeNode4.FillColor)
                    {
                        checkLineTwoNode3.FillColor = Color.White;
                    }
                }

                else
                {
                    checkLineTwoNode3.FillColor = Color.Black;
                }

                if (lineTwoNode4.FillColor != codeNode4.FillColor)
                {
                    if (lineTwoNode4.FillColor == codeNode1.FillColor || lineTwoNode4.FillColor == codeNode2.FillColor ||
                        lineTwoNode4.FillColor == codeNode3.FillColor)
                    {
                        checkLineTwoNode4.FillColor = Color.White;
                    }
                }

                else
                {
                    checkLineTwoNode4.FillColor = Color.Black;
                }
            
        }

        private void checkLineThree()
            {

                if(lineThreeNode1.FillColor != codeNode1.FillColor)
                {
                    if(lineThreeNode1.FillColor == codeNode2.FillColor || lineThreeNode1.FillColor == codeNode3.FillColor || 
                        lineThreeNode1.FillColor == codeNode4.FillColor)
                    {
                        checkLineThreeNode1.FillColor = Color.White;
                    }
                }

                else
                {
                    checkLineThreeNode1.FillColor = Color.Black;
                }

                if (lineThreeNode2.FillColor != codeNode2.FillColor)
                {
                    if (lineThreeNode2.FillColor == codeNode1.FillColor || lineThreeNode2.FillColor == codeNode3.FillColor ||
                        lineThreeNode2.FillColor == codeNode4.FillColor)
                    {
                        checkLineThreeNode2.FillColor = Color.White;
                    }
                }

                else
                {
                    checkLineThreeNode2.FillColor = Color.Black;
                }

                if (lineThreeNode3.FillColor != codeNode3.FillColor)
                {
                    if (lineThreeNode3.FillColor == codeNode1.FillColor || lineThreeNode3.FillColor == codeNode2.FillColor ||
                        lineThreeNode3.FillColor == codeNode4.FillColor)
                    {
                        checkLineThreeNode3.FillColor = Color.White;
                    }
                }

                else
                {
                    checkLineThreeNode3.FillColor = Color.Black;
                }

                if (lineThreeNode4.FillColor != codeNode4.FillColor)
                {
                    if (lineThreeNode4.FillColor == codeNode1.FillColor || lineThreeNode4.FillColor == codeNode2.FillColor ||
                        lineThreeNode4.FillColor == codeNode3.FillColor)
                    {
                        checkLineThreeNode4.FillColor = Color.White;
                    }
                }

                else
                {
                    checkLineThreeNode4.FillColor = Color.Black;
                }
            
        }

        private void checkLineFour()
            {

                if(lineFourNode1.FillColor != codeNode1.FillColor)
                {
                    if(lineFourNode1.FillColor == codeNode2.FillColor || lineFourNode1.FillColor == codeNode3.FillColor || 
                        lineFourNode1.FillColor == codeNode4.FillColor)
                    {
                        checkLineFourNode1.FillColor = Color.White;
                    }
                }

                else
                {
                    checkLineFourNode1.FillColor = Color.Black;
                }

                if (lineFourNode2.FillColor != codeNode2.FillColor)
                {
                    if (lineFourNode2.FillColor == codeNode1.FillColor || lineFourNode2.FillColor == codeNode3.FillColor ||
                        lineFourNode2.FillColor == codeNode4.FillColor)
                    {
                        checkLineFourNode2.FillColor = Color.White;
                    }
                }

                else
                {
                    checkLineFourNode2.FillColor = Color.Black;
                }

                if (lineFourNode3.FillColor != codeNode3.FillColor)
                {
                    if (lineFourNode3.FillColor == codeNode1.FillColor || lineFourNode3.FillColor == codeNode2.FillColor ||
                        lineFourNode3.FillColor == codeNode4.FillColor)
                    {
                        checkLineFourNode3.FillColor = Color.White;
                    }
                }

                else
                {
                    checkLineFourNode3.FillColor = Color.Black;
                }

                if (lineFourNode4.FillColor != codeNode4.FillColor)
                {
                    if (lineFourNode4.FillColor == codeNode1.FillColor || lineFourNode4.FillColor == codeNode2.FillColor ||
                        lineFourNode4.FillColor == codeNode3.FillColor)
                    {
                        checkLineFourNode4.FillColor = Color.White;
                    }
                }

                else
                {
                    checkLineFourNode4.FillColor = Color.Black;
                }
            
        }

        private void checkLineFive()
            {

                if(lineFiveNode1.FillColor != codeNode1.FillColor)
                {
                    if(lineFiveNode1.FillColor == codeNode2.FillColor || lineFiveNode1.FillColor == codeNode3.FillColor || 
                        lineFiveNode1.FillColor == codeNode4.FillColor)
                    {
                        checkLineFiveNode1.FillColor = Color.White;
                    }
                }

                else
                {
                    checkLineFiveNode1.FillColor = Color.Black;
                }

                if (lineFiveNode2.FillColor != codeNode2.FillColor)
                {
                    if (lineFiveNode2.FillColor == codeNode1.FillColor || lineFiveNode2.FillColor == codeNode3.FillColor ||
                        lineFiveNode2.FillColor == codeNode4.FillColor)
                    {
                        checkLineFiveNode2.FillColor = Color.White;
                    }
                }

                else
                {
                    checkLineFiveNode2.FillColor = Color.Black;
                }

                if (lineFiveNode3.FillColor != codeNode3.FillColor)
                {
                    if (lineFiveNode3.FillColor == codeNode1.FillColor || lineFiveNode3.FillColor == codeNode2.FillColor ||
                        lineFiveNode3.FillColor == codeNode4.FillColor)
                    {
                        checkLineFiveNode3.FillColor = Color.White;
                    }
                }

                else
                {
                    checkLineFiveNode3.FillColor = Color.Black;
                }

                if (lineFiveNode4.FillColor != codeNode4.FillColor)
                {
                    if (lineFiveNode4.FillColor == codeNode1.FillColor || lineFiveNode4.FillColor == codeNode2.FillColor ||
                        lineFiveNode4.FillColor == codeNode3.FillColor)
                    {
                        checkLineFiveNode4.FillColor = Color.White;
                    }
                }

                else
                {
                    checkLineFiveNode4.FillColor = Color.Black;
                }
            
        }

        private void checkLineSix()
            {

                if(lineSixNode1.FillColor != codeNode1.FillColor)
                {
                    if(lineSixNode1.FillColor == codeNode2.FillColor || lineSixNode1.FillColor == codeNode3.FillColor || 
                        lineSixNode1.FillColor == codeNode4.FillColor)
                    {
                        checkLineSixNode1.FillColor = Color.White;
                    }
                }

                else
                {
                    checkLineSixNode1.FillColor = Color.Black;
                }

                if (lineSixNode2.FillColor != codeNode2.FillColor)
                {
                    if (lineSixNode2.FillColor == codeNode1.FillColor || lineSixNode2.FillColor == codeNode3.FillColor ||
                        lineSixNode2.FillColor == codeNode4.FillColor)
                    {
                        checkLineSixNode2.FillColor = Color.White;
                    }
                }

                else
                {
                    checkLineSixNode2.FillColor = Color.Black;
                }

                if (lineSixNode3.FillColor != codeNode3.FillColor)
                {
                    if (lineSixNode3.FillColor == codeNode1.FillColor || lineSixNode3.FillColor == codeNode2.FillColor ||
                        lineSixNode3.FillColor == codeNode4.FillColor)
                    {
                        checkLineSixNode3.FillColor = Color.White;
                    }
                }

                else
                {
                    checkLineSixNode3.FillColor = Color.Black;
                }

                if (lineSixNode4.FillColor != codeNode4.FillColor)
                {
                    if (lineSixNode4.FillColor == codeNode1.FillColor || lineSixNode4.FillColor == codeNode2.FillColor ||
                        lineSixNode4.FillColor == codeNode3.FillColor)
                    {
                        checkLineSixNode4.FillColor = Color.White;
                    }
                }

                else
                {
                    checkLineSixNode4.FillColor = Color.Black;
                }
            
        }

        private void checkLineSeven()
            {

                if(lineSevenNode1.FillColor != codeNode1.FillColor)
                {
                    if(lineSevenNode1.FillColor == codeNode2.FillColor || lineSevenNode1.FillColor == codeNode3.FillColor || 
                        lineSevenNode1.FillColor == codeNode4.FillColor)
                    {
                        checkLineSevenNode1.FillColor = Color.White;
                    }
                }

                else
                {
                    checkLineSevenNode1.FillColor = Color.Black;
                }

                if (lineSevenNode2.FillColor != codeNode2.FillColor)
                {
                    if (lineSevenNode2.FillColor == codeNode1.FillColor || lineSevenNode2.FillColor == codeNode3.FillColor ||
                        lineSevenNode2.FillColor == codeNode4.FillColor)
                    {
                        checkLineSevenNode2.FillColor = Color.White;
                    }
                }

                else
                {
                    checkLineSevenNode2.FillColor = Color.Black;
                }

                if (lineSevenNode3.FillColor != codeNode3.FillColor)
                {
                    if (lineSevenNode3.FillColor == codeNode1.FillColor || lineSevenNode3.FillColor == codeNode2.FillColor ||
                        lineSevenNode3.FillColor == codeNode4.FillColor)
                    {
                        checkLineSevenNode3.FillColor = Color.White;
                    }
                }

                else
                {
                    checkLineSevenNode3.FillColor = Color.Black;
                }

                if (lineSevenNode4.FillColor != codeNode4.FillColor)
                {
                    if (lineSevenNode4.FillColor == codeNode1.FillColor || lineSevenNode4.FillColor == codeNode2.FillColor ||
                        lineSevenNode4.FillColor == codeNode3.FillColor)
                    {
                        checkLineSevenNode4.FillColor = Color.White;
                    }
                }

                else
                {
                    checkLineSevenNode4.FillColor = Color.Black;
                }
            
        }

        private void checkLineEight()
            {

                if(lineEightNode1.FillColor != codeNode1.FillColor)
                {
                    if(lineEightNode1.FillColor == codeNode2.FillColor || lineEightNode1.FillColor == codeNode3.FillColor || 
                        lineEightNode1.FillColor == codeNode4.FillColor)
                    {
                        checkLineEightNode1.FillColor = Color.White;
                    }
                }

                else
                {
                    checkLineEightNode1.FillColor = Color.Black;
                }

                if (lineEightNode2.FillColor != codeNode2.FillColor)
                {
                    if (lineEightNode2.FillColor == codeNode1.FillColor || lineEightNode2.FillColor == codeNode3.FillColor ||
                        lineEightNode2.FillColor == codeNode4.FillColor)
                    {
                        checkLineEightNode2.FillColor = Color.White;
                    }
                }

                else
                {
                    checkLineEightNode2.FillColor = Color.Black;
                }

                if (lineEightNode3.FillColor != codeNode3.FillColor)
                {
                    if (lineEightNode3.FillColor == codeNode1.FillColor || lineEightNode3.FillColor == codeNode2.FillColor ||
                        lineEightNode3.FillColor == codeNode4.FillColor)
                    {
                        checkLineEightNode3.FillColor = Color.White;
                    }
                }

                else
                {
                    checkLineEightNode3.FillColor = Color.Black;
                }

                if (lineEightNode4.FillColor != codeNode4.FillColor)
                {
                    if (lineEightNode4.FillColor == codeNode1.FillColor || lineEightNode4.FillColor == codeNode2.FillColor ||
                        lineEightNode4.FillColor == codeNode3.FillColor)
                    {
                        checkLineEightNode4.FillColor = Color.White;
                    }
                }

                else
                {
                    checkLineEightNode4.FillColor = Color.Black;
                }
            
        }

        private bool checkIfSolved()
        {
            if(lineCounter == 1)
            {
                if(checkLineOneNode1.FillColor == Color.Black)
                {
                    if (checkLineOneNode2.FillColor == Color.Black)
                    {
                        if (checkLineOneNode3.FillColor == Color.Black)
                        {
                            if (checkLineOneNode4.FillColor == Color.Black)
                            {
                                return true;
                            }

                            else
                            {
                                return false;
                            }
                        }

                        else
                        {
                             return false;
                        }
                    }

                    else
                    {
                       return false;
                    }
                }

                else
                {
                   return false;
                }

            }

            else if(lineCounter == 2)
            {
                if (checkLineTwoNode1.FillColor == Color.Black)
                {
                    if (checkLineTwoNode2.FillColor == Color.Black)
                    {
                        if (checkLineTwoNode3.FillColor == Color.Black)
                        {
                            if (checkLineTwoNode4.FillColor == Color.Black)
                            {
                                return true;
                            }

                            else
                            {
                                return false;
                            }
                        }

                        else
                        {
                             return false;
                        }
                    }

                    else
                    {
                       return false;
                    }
                }

                else
                {
                   return false;
                }

            }
            
            else if(lineCounter == 3)
            {
                if (checkLineThreeNode1.FillColor == Color.Black)
                {
                    if (checkLineThreeNode2.FillColor == Color.Black)
                    {
                        if (checkLineThreeNode3.FillColor == Color.Black)
                        {
                            if (checkLineThreeNode4.FillColor == Color.Black)
                            {
                                return true;
                            }

                            else
                            {
                                return false;
                            }
                        }

                        else
                        {
                             return false;
                        }
                    }

                    else
                    {
                       return false;
                    }
                }

                else
                {
                   return false;
                }

            }

            else if(lineCounter == 4)
            {
                if (checkLineFourNode1.FillColor == Color.Black)
                {
                    if (checkLineFourNode2.FillColor == Color.Black)
                    {
                        if (checkLineFourNode3.FillColor == Color.Black)
                        {
                            if (checkLineFourNode4.FillColor == Color.Black)
                            {
                                return true;
                            }

                            else
                            {
                                return false;
                            }
                        }

                        else
                        {
                             return false;
                        }
                    }

                    else
                    {
                       return false;
                    }
                }

                else
                {
                   return false;
                }

            }

            else if(lineCounter == 5)
            {
                if (checkLineFiveNode1.FillColor == Color.Black)
                {
                    if (checkLineFiveNode2.FillColor == Color.Black)
                    {
                        if (checkLineFiveNode3.FillColor == Color.Black)
                        {
                            if (checkLineFiveNode4.FillColor == Color.Black)
                            {
                                return true;
                            }

                            else
                            {
                                return false;
                            }
                        }

                        else
                        {
                             return false;
                        }
                    }

                    else
                    {
                       return false;
                    }
                }

                else
                {
                   return false;
                }

            }

            else if(lineCounter == 6)
            {
                if (checkLineSixNode1.FillColor == Color.Black)
                {
                    if (checkLineSixNode2.FillColor == Color.Black)
                    {
                        if (checkLineSixNode3.FillColor == Color.Black)
                        {
                            if (checkLineSixNode4.FillColor == Color.Black)
                            {
                                return true;
                            }

                            else
                            {
                                return false;
                            }
                        }

                        else
                        {
                             return false;
                        }
                    }

                    else
                    {
                       return false;
                    }
                }

                else
                {
                   return false;
                }

            }

            else if(lineCounter == 7)
            {
                if (checkLineSevenNode1.FillColor == Color.Black)
                {
                    if (checkLineSevenNode2.FillColor == Color.Black)
                    {
                        if (checkLineSevenNode3.FillColor == Color.Black)
                        {
                            if (checkLineSevenNode4.FillColor == Color.Black)
                            {
                                return true;
                            }

                            else
                            {
                                return false;
                            }
                        }

                        else
                        {
                             return false;
                        }
                    }

                    else
                    {
                       return false;
                    }
                }

                else
                {
                   return false;
                }

            }

            else if(lineCounter == 8)
            {
                if (checkLineEightNode1.FillColor == Color.Black)
                {
                    if (checkLineEightNode2.FillColor == Color.Black)
                    {
                        if (checkLineEightNode3.FillColor == Color.Black)
                        {
                            if (checkLineEightNode4.FillColor == Color.Black)
                            {
                                return true;
                            }

                            else
                            {
                                return false;
                            }
                        }

                        else
                        {
                             return false;
                        }
                    }

                    else
                    {
                       return false;
                    }
                }

                else
                {
                   return false;
                }

            }

            else
            {
               return false;
            }
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            lineCounter = 1;
            makeLineInvisible();
            codeShield.Visible = true;
            randomizeCode();
            lineOneNode1.FillColor = Color.Gray;
            lineOneNode2.FillColor = Color.Gray;
            lineOneNode3.FillColor = Color.Gray;
            lineOneNode4.FillColor = Color.Gray;
            lineTwoNode1.FillColor = Color.Gray;
            lineTwoNode2.FillColor = Color.Gray;
            lineTwoNode3.FillColor = Color.Gray;
            lineTwoNode4.FillColor = Color.Gray;
            lineThreeNode1.FillColor = Color.Gray;
            lineThreeNode2.FillColor = Color.Gray;
            lineThreeNode3.FillColor = Color.Gray;
            lineThreeNode4.FillColor = Color.Gray;
            lineFourNode1.FillColor = Color.Gray;
            lineFourNode2.FillColor = Color.Gray;
            lineFourNode3.FillColor = Color.Gray;
            lineFourNode4.FillColor = Color.Gray;
            lineFiveNode1.FillColor = Color.Gray;
            lineFiveNode2.FillColor = Color.Gray;
            lineFiveNode3.FillColor = Color.Gray;
            lineFiveNode4.FillColor = Color.Gray;
            lineSixNode1.FillColor = Color.Gray;
            lineSixNode2.FillColor = Color.Gray;
            lineSixNode3.FillColor = Color.Gray;
            lineSixNode4.FillColor = Color.Gray;
            lineSevenNode1.FillColor = Color.Gray;
            lineSevenNode2.FillColor = Color.Gray;
            lineSevenNode3.FillColor = Color.Gray;
            lineSevenNode4.FillColor = Color.Gray;
            lineEightNode1.FillColor = Color.Gray;
            lineEightNode2.FillColor = Color.Gray;
            lineEightNode3.FillColor = Color.Gray;
            lineEightNode4.FillColor = Color.Gray;
            checkLineOneNode1.FillColor = Color.Gray;
            checkLineOneNode2.FillColor = Color.Gray;
            checkLineOneNode3.FillColor = Color.Gray;
            checkLineOneNode4.FillColor = Color.Gray;
            checkLineTwoNode1.FillColor = Color.Gray;
            checkLineTwoNode2.FillColor = Color.Gray;
            checkLineTwoNode3.FillColor = Color.Gray;
            checkLineTwoNode4.FillColor = Color.Gray;
            checkLineThreeNode1.FillColor = Color.Gray;
            checkLineThreeNode2.FillColor = Color.Gray;
            checkLineThreeNode3.FillColor = Color.Gray;
            checkLineThreeNode4.FillColor = Color.Gray;
            checkLineFourNode1.FillColor = Color.Gray;
            checkLineFourNode2.FillColor = Color.Gray;
            checkLineFourNode3.FillColor = Color.Gray;
            checkLineFourNode4.FillColor = Color.Gray;
            checkLineFiveNode1.FillColor = Color.Gray;
            checkLineFiveNode2.FillColor = Color.Gray;
            checkLineFiveNode3.FillColor = Color.Gray;
            checkLineFiveNode4.FillColor = Color.Gray;
            checkLineSixNode1.FillColor = Color.Gray;
            checkLineSixNode2.FillColor = Color.Gray;
            checkLineSixNode3.FillColor = Color.Gray;
            checkLineSixNode4.FillColor = Color.Gray;
            checkLineSevenNode1.FillColor = Color.Gray;
            checkLineSevenNode2.FillColor = Color.Gray;
            checkLineSevenNode3.FillColor = Color.Gray;
            checkLineSevenNode4.FillColor = Color.Gray;
            checkLineEightNode1.FillColor = Color.Gray;
            checkLineEightNode2.FillColor = Color.Gray;
            checkLineEightNode3.FillColor = Color.Gray;
            checkLineEightNode4.FillColor = Color.Gray;
        }
    }
}
