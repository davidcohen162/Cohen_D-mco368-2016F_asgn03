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
            for(int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = random.Next(10);
            }
            
           
            
            //Displaying numbers in bar
            numbersBar.Text = "";
            for(int i = 0; i < randomNumbers.Length; i++)
            {
                numbersBar.Text = String.Join(" ", numbersBar.Text, randomNumbers[i]);
            }

            //Rectangular array storing same numbers as 1D array
            int counter = 0;
            for (int i = 0; i < randomNumbersRect.GetLength(0); i++)
            {
                for (int j = 0; j < randomNumbersRect.GetLength(1); j++)
                {
                    randomNumbersRect[i, j] = randomNumbers[counter];
                    counter++;
                }
                //Setting new line in textbox
                

            }

            
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
                messageBox.Text = "The number selected is:" + randomNumbersRect[(indexToShow1 - 1), (indexToShow2 - 1)];
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
