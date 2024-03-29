﻿using System;
using System.Windows.Forms;

namespace SomeBinaryStuff
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            toComboBox.SelectedIndex = 2;
            fromComboBox.SelectedIndex = 0;
        }


        Random rnd = new Random();
        int rndNum = 0;

        int countRight = 0;
        int countFail = 0;



        private void startButton_Click(object sender, EventArgs e)
        {
            countRight = 0;
            countFail = 0;

            startButton.Visible = false;
            stopButton.Visible = true;
            inputTextBox.Visible = true;

            checkLabel.Text = "";
            correctLabel.Text = "";
            incorrectLabel.Text = "";

            try
            {
                BinaryStuffLabel.Text = Convert.ToString(genNext(), Convert.ToInt32(fromComboBox.Text));
            }
            catch
            {
                MessageBox.Show("Something was missing!");
            }

        }

        private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                lastBinaryLabel.Text = BinaryStuffLabel.Text;

                checkNum();
                e.SuppressKeyPress = true;
            }
            
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            startButton.Visible = true;

            correctLabel.Text = $"Correct answers:  {countRight}";
            incorrectLabel.Text = $"Incorrect answers:  {countFail}";
            BinaryStuffLabel.Text = "BinaryStuff";

            checkLabel.Text = "";
            lastBinaryLabel.Text = "";
            stopButton.Visible = false;
            inputTextBox.Visible = false;

        }

        public int genNext()
        {
            rndNum = rnd.Next(256);
            return rndNum;
        }


        public void checkNum()
        {

            var check = Convert.ToString(rndNum, Convert.ToInt32(toComboBox.Text));

            if (check == inputTextBox.Text)
            {
                checkLabel.Text = "Right";
                countRight++;
            }
            else
            {
                checkLabel.Text = $"Wrong! {check}";
                countFail++;
            }
            inputTextBox.Text = "";

            BinaryStuffLabel.Text = Convert.ToString(genNext(), Convert.ToInt32(fromComboBox.Text));

        }
    }
}
