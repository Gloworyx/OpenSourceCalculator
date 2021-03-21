using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALC
{
    public partial class Form1 : Form
    {
        // Made by Glow.     These are the variables, dont touch it.
        // READ ALL THE CODE FIRST AND UNDERSTAND IT BC IM TOO LAZY TO EXPLAIIN ANYTHING XD
        double first;
        double second;
        public string operator1;

        public Form1()
        {
            InitializeComponent();
        }

        Classes.ClassPlus obj = new Classes.ClassPlus();
        Classes.ClassMinusSubstraction obj2 = new Classes.ClassMinusSubstraction();
        Classes.ClassForMultiplyBy obj3 = new Classes.ClassForMultiplyBy();
        Classes.ClassDivideBy obj4 = new Classes.ClassDivideBy();


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Program launched");
            Console.WriteLine("Official project (Development:) Glow.");
            Console.WriteLine("Modified by: Insert your GitHub name here.");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operator1 = "+";
            first = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operator1 = "-";
            first = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operator1 = "*";
            first = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            operator1 = "/";
            first = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            second = double.Parse(textBox1.Text);

            double Plus;
            double Divison;
            double By;
            double Minus;

            // Here ill use a "switch" command for not overusing the "if" instruction.

            switch(operator1)
                {
                case "+":
                    Plus = obj.Plus((first), (second));
                    textBox1.Text = Plus.ToString();
                    break;
                case "*":
                    By = obj3.Multiply((first), (second));
                    textBox1.Text = By.ToString();
                    break;
                case "-":
                    Minus = obj2.Minus((first), (second));
                    textBox1.Text = Minus.ToString();
                    break;
                case "/":
                    Divison = obj4.Divide((first), (second));
                    textBox1.Text = Divison.ToString();
                    break;
            }
        }
    }
}
