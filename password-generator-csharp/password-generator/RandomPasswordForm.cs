using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace password_generator
{
    public partial class RandomPasswordForm : Form
    {
        public RandomPasswordForm()
        {
            InitializeComponent();
        }

        //on create button click, creates a random password of the length specified by the trackbar using the createRandomChar method
        private void btn_RandomCreate_Click(object sender, EventArgs e)
        {
            int howmanychar = trackBar1.Value;
            string newpassword = "";

            for(int i = 0;i < howmanychar; i++)
            {
                newpassword += createRandomChar();
            }

            txtbox_RandomPassword.Text = newpassword;
        }

        //creates and returns a random uppercase char, lowercase char, number, or symbol
        public char createRandomChar()
        {
            char[] upperCase = { 'A', 'B', 'C', 'D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z' };
            char[] lowerCase = new char[upperCase.Length];
            for(int i = 0; i < upperCase.Length; i++)
            {
                lowerCase[i] = Convert.ToChar(upperCase[i].ToString().ToLower());
            }
            char[] numbers = { '1', '2', '3', '4','5', '6', '7', '8', '9', '0' };
            char[] symbols = { '!', '@', '#', '$', '%', '^', '&', '*', '-', '_' };

            Random random = new Random();

            int selection = random.Next(0, 4);
            int randLetters = random.Next(0, 26);
            int randNumbersSymbols = random.Next(0, 9);

            if(selection == 0)
            {
                return upperCase[randLetters];
            }
            else if(selection == 1)
            {
                return lowerCase[randLetters];
            }
            else if(selection == 2)
            {
                return numbers[randNumbersSymbols];
            }
            else if(selection == 3)
            {
                return symbols[randNumbersSymbols];
            }
            return '0';

        }

      private void label1_Click(object sender, EventArgs e)
        {

        }

        //on trackbar scroll, lbl slider value gets updated and shows user which number they selected
        private void trackbar1_scroll(object sender, EventArgs e)
        {
            lbl_SliderValue.Text = trackBar1.Value.ToString();
        }
    }
}
