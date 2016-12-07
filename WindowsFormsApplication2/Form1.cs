using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form

    {
        int[] randomNumbers = new int[24];
        int[,] randomNumbersRect = new int[4,6];
        public Form1()
        {
            InitializeComponent();
            this.Text = "Assignment 3";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void newNumbers_Click(object sender, EventArgs e)
        {
            //1D Array of random numbers
            Random random = new Random();
            randomNumbers[0] = random.Next(10);
            randomNumbers[1] = random.Next(10);
            randomNumbers[2] = random.Next(10);
            randomNumbers[3] = random.Next(10);
            randomNumbers[4] = random.Next(10);
            randomNumbers[5] = random.Next(10);
            randomNumbers[6] = random.Next(10);
            randomNumbers[7] = random.Next(10);
            randomNumbers[8] = random.Next(10);
            randomNumbers[9] = random.Next(10);
            randomNumbers[10] = random.Next(10);
            randomNumbers[11] = random.Next(10);
            randomNumbers[12] = random.Next(10);
            randomNumbers[13] = random.Next(10);
            randomNumbers[14] = random.Next(10);
            randomNumbers[15] = random.Next(10);
            randomNumbers[16] = random.Next(10);
            randomNumbers[17] = random.Next(10);
            randomNumbers[18] = random.Next(10);
            randomNumbers[19] = random.Next(10);
            randomNumbers[20] = random.Next(10);
            randomNumbers[21] = random.Next(10);
            randomNumbers[22] = random.Next(10);
            randomNumbers[23] = random.Next(10);
            //Displaying numbers in bar
            numbersBar.Text = "";
            for(int i = 0; i < randomNumbers.Length; i++)
            {
                numbersBar.Text = String.Join(" ", numbersBar.Text, randomNumbers[i]);
            }
            
            //Rectangular array storing same numbers as 1D array
            randomNumbersRect[0,0]= randomNumbers[0];
            randomNumbersRect[0, 1] = randomNumbers[1];
            randomNumbersRect[0, 2] = randomNumbers[2];
            randomNumbersRect[0, 3] = randomNumbers[3];
            randomNumbersRect[0, 4] = randomNumbers[4];
            randomNumbersRect[0, 5] = randomNumbers[5];
            randomNumbersRect[1, 0] = randomNumbers[6];
            randomNumbersRect[1, 1] = randomNumbers[7];
            randomNumbersRect[1, 2] = randomNumbers[8];
            randomNumbersRect[1, 3] = randomNumbers[9];
            randomNumbersRect[1, 4] = randomNumbers[10];
            randomNumbersRect[1, 5] = randomNumbers[11];
            randomNumbersRect[2, 0] = randomNumbers[12];
            randomNumbersRect[2, 1] = randomNumbers[13];
            randomNumbersRect[2, 2] = randomNumbers[14];
            randomNumbersRect[2, 3] = randomNumbers[15];
            randomNumbersRect[2, 4] = randomNumbers[16];
            randomNumbersRect[2, 5] = randomNumbers[17];
            randomNumbersRect[3, 0] = randomNumbers[18];
            randomNumbersRect[3, 1] = randomNumbers[19];
            randomNumbersRect[3, 2] = randomNumbers[20];
            randomNumbersRect[3, 3] = randomNumbers[21];
            randomNumbersRect[3, 4] = randomNumbers[22];
            randomNumbersRect[3, 5] = randomNumbers[23];
            //Displaying numbers in box
            numbersBox.Text = "";
            for(int i = 0; i < randomNumbersRect.GetLength(0); i++)
            {
                for(int j = 0; j < randomNumbersRect.GetLength(1); j++)
                {
                    numbersBox.Text = String.Join(" ", numbersBox.Text, randomNumbersRect[i, j]);
                }
                //Setting new line in textbox
                numbersBox.Text = numbersBox.Text+"\r\n" ;

            }


            index1.Text = "";
            index2.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void display_Click(object sender, EventArgs e)
        {

            //Trying to parse the text in the display box before using it to determine what number to show
            int indexToShow1 = 0;
            int indexToShow2 = 0;
            bool isInt1 = Int32.TryParse(index1.Text,out indexToShow1);
            bool isInt2 = Int32.TryParse(index2.Text,out indexToShow2);
            messageBox.Text = "";
            if (isInt1 == false || isInt2 == false)
            {
                messageBox.Text = "Enter only integers.";
            }
            else
            {
                messageBox.Text = "The number selected is:" + randomNumbersRect[(indexToShow2 - 1), (indexToShow1 - 1)];
            }
        }

        private void messageBox_Click(object sender, EventArgs e)
        {

        }

        private void filter_Click(object sender, EventArgs e)
        {
            int filter = 0; 
            //Trying to parse the text in the cutoff box to an int before filtering
             bool isIntFilter=   Int32.TryParse(cutoff.Text,out filter);
            if (isIntFilter == false)
            {
                numbersBar.Text = "Enter only integers";
            }
            else
            {
                var filtered =
                    from item in randomNumbers
                    where item > filter
                    select item;
                numbersBar.Text = String.Join(" ", filtered);
            }
            
            
        }
        

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void numbersBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
