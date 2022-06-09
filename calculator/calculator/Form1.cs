using System;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public string Value = " ";
        public double SecondValue;
        public double ThirdValiue;
        public string Sing;
        public double Result;

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button19_Click(object sender, EventArgs e)
        {
            Value = Value + "1";
            textBox1.Text = Value;
        }

        public void button14_Click(object sender, EventArgs e)
        {
            Value = Value + "2";
            textBox1.Text = Value;
        }

        public void button9_Click(object sender, EventArgs e)
        {
            Value = Value + "3";
            textBox1.Text = Value;
        }

        public void button18_Click(object sender, EventArgs e)
        {
            Value = Value + "4";
            textBox1.Text = Value;
        }

        public void button13_Click(object sender, EventArgs e)
        {
            Value = Value + "5";
            textBox1.Text = Value;
        }

        public void button8_Click(object sender, EventArgs e)
        {
            Value = Value + "6";
            textBox1.Text = Value;
        }

        public void button17_Click(object sender, EventArgs e)
        {
            Value = Value + "7";
            textBox1.Text = Value;
        }

        public void button12_Click(object sender, EventArgs e)
        {
            Value = Value + "8";
            textBox1.Text = Value;
        }

        public void button7_Click(object sender, EventArgs e)
        {
            Value = Value + "9";
            textBox1.Text = Value;
        }

        public void button15_Click(object sender, EventArgs e)
        {
            Value = Value + "0";
            textBox1.Text = Value;
        }

        public void button16_Click(object sender, EventArgs e)
        {
            Value = " ";
            Sing = "";

            SecondValue = 0;
            ThirdValiue = 0;
            Result = 0;
            textBox1.Text = Value;
        }

        public void button11_Click(object sender, EventArgs e)
        {
            if (Value.StartsWith("-"))
            {
                Value = Value.Replace("-", " ");
                textBox1.Text = Value;
            }
            else
            {
                Value = Value.Replace(" ", "-");
                textBox1.Text = Value;
            }
        }

        public void button10_Click(object sender, EventArgs e) //button - ","
        {
            int index = Value.Length;
            if (Value.Contains(".") == false)
            {
                Value = Value.Insert(index, ",");
            }
        }

        public void button6_Click(object sender, EventArgs e)
        {
            SecondValue = Convert.ToDouble(Value);

            Value = " ";
            Sing = "%";
        }

        public void button4_Click(object sender, EventArgs e)
        {
            SecondValue = Convert.ToDouble(Value);

            Value = " ";
            Sing = "+";
        }

        public void button3_Click(object sender, EventArgs e)
        {
            SecondValue = Convert.ToDouble(Value);

            Value = " ";
            Sing = "-";
        }

        public void button2_Click(object sender, EventArgs e)
        {
            SecondValue = Convert.ToDouble(Value);

            Value = " ";
            Sing = "*";
        }

        public void button1_Click(object sender, EventArgs e)
        {
            SecondValue = Convert.ToDouble(Value);

            Value = " ";
            Sing = "/";
        }

        public void button5_Click(object sender, EventArgs e)
        {
            ThirdValiue = Convert.ToDouble(Value);

            if (Sing == "+")
            {
                Result = ThirdValiue + SecondValue;
                Value = Convert.ToString(Result);

                textBox1.Text = Value;

                ThirdValiue = 0;
                SecondValue = 0;
                Result = 0;
            }
            else if(Sing == "-")
            {
                Result = SecondValue - ThirdValiue;
                Value = Convert.ToString(Result);

                textBox1.Text = Value;

                ThirdValiue = 0;
                SecondValue = 0;
                Result = 0;
            }
            else if (Sing == "*")
            {
                Result = ThirdValiue * SecondValue;
                Value = Convert.ToString(Result);

                textBox1.Text = Value;

                ThirdValiue = 0;
                SecondValue = 0;
                Result = 0;
            }
            else if (Sing == "/")
            {
                Result = SecondValue / ThirdValiue;
                Value = Convert.ToString(Result);

                textBox1.Text = Value;

                ThirdValiue = 0;
                SecondValue = 0;
                Result = 0;
            }
            else if(Sing == "%")
            {
                Result = SecondValue * (ThirdValiue / 100);
                Value = Convert.ToString(Result);

                textBox1.Text = Value;

                ThirdValiue = 0;
                SecondValue = 0;
                Result = 0;
            }
        }

    }
}
