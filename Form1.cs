using System;
using System.Windows.Forms;

namespace SomeBinaryStuff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Random rnd = new Random();

        int countRight = 0;
        int countFail = 0;
        private void startButton_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                BinaryStuffLabel.Text = genNext16();
            }
            else
            {
                BinaryStuffLabel.Text = genNext2();
            }
            countRight = 0;
            countFail = 0;

            startButton.Visible = false;
            stopButton.Visible = true;
            inputTextBox.Visible = true;
            checkBox1.Visible = false;

            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
        }

        private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                label4.Text = BinaryStuffLabel.Text;
              
                checkNum();
                if (checkBox1.Checked)
                {
                    BinaryStuffLabel.Text = genNext16();
                }
                else
                {
                    BinaryStuffLabel.Text = genNext2();
                }
             
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            startButton.Visible = true;

            label2.Text = $"Правильных ответов:     {countRight}";
            label3.Text = $"Неправильных ответов: {countFail}";
            BinaryStuffLabel.Text = "BinaryStuff";

            label1.Text = "";
            label4.Text = "";
            stopButton.Visible = false;
            inputTextBox.Visible = false;
            checkBox1.Visible = true;
        }


        public string genNext16()
        {
            int integer = Convert.ToInt32(genNext2(), 2);
            var tmp = Convert.ToString(integer, 16).ToUpper();

            if (tmp.Length < 2)
                tmp = "0" + tmp;
            return tmp;
        }
        public string genNext2()
        {
            var str = rnd.Next(2).ToString() + rnd.Next(2).ToString() + rnd.Next(2).ToString() + rnd.Next(2).ToString()+
                      rnd.Next(2).ToString() + rnd.Next(2).ToString() + rnd.Next(2).ToString() + rnd.Next(2).ToString(); 

            return str;
        }

        public void printAns(string s)
        {
            if (inputTextBox.Text.ToUpper() == s.ToUpper())
            {
                label1.Text = $"Верно.";
                inputTextBox.Text = "";
                countRight++;
            }
            else
            {
                label1.Text = $"Ошибка! {s}";
                inputTextBox.Text = "";
                countFail++;
            }
        }

        public void checkNum()
        {
            var binary = BinaryStuffLabel.Text;
            
            

            if (checkBox1.Checked)
            {
          
                int integer = Convert.ToInt32(binary, 16);
                var check16 = Convert.ToString(integer, 2);
                while(check16.Length < 8)
                {
                    check16 = "0" + check16;
                }

                printAns(check16);
            }
          
            else
            {
                int integer = Convert.ToInt32(binary, 2);

                var check2 = Convert.ToString(integer, 16);

                printAns(check2);
            }

        }

       
    }
}
