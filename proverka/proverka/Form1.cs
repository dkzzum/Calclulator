using System;
using System.Windows.Forms;

namespace proverka
{
    public partial class Form1 : Form
    {
        public string Value = " ";
        public double SecondValue = 0;
        public double ThirdValiue = 0;
        public string Sing;
        public double Result;
        int Clear = 0, numbers = 0, i = 0, count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button15_Click(object sender, EventArgs e)
        {
            if (Value.Length <= 9)
            {
                Value = Value + "0";
                textBox1.Text = Value;
                Clear = 0;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (Value.Length <= 9)
            {
                Value = Value + "1";
                textBox1.Text = Value;
                Clear = 0;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (Value.Length <= 9)
            {
                Value = Value + "2";
                textBox1.Text = Value;
                Clear = 0;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Value.Length <= 9)
            {
                Value = Value + "3";
                textBox1.Text = Value;
                Clear = 0;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (Value.Length <= 9)
            {
                Value = Value + "4";
                textBox1.Text = Value;
                Clear = 0;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (Value.Length <= 9)
            {
                Value = Value + "5";
                textBox1.Text = Value;
                Clear = 0;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Value.Length <= 9)
            {
                Value = Value + "6";
                textBox1.Text = Value;
                Clear = 0;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (Value.Length <= 9)
            {
                Value = Value + "7";
                textBox1.Text = Value;
                Clear = 0;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Value.Length <= 9)
            {
                Value = Value + "8";
                textBox1.Text = Value;
                Clear = 0;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Value.Length <= 9)
            {
                Value = Value + "9";
                textBox1.Text = Value;
                Clear = 0;
            }
        }

        private void button11_Click(object sender, EventArgs e) //    +/-
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

        private void button10_Click(object sender, EventArgs e) // ","
        {
            if (!string.IsNullOrWhiteSpace(Value))
            {
                int index = Value.Length;
                if (Value.Contains(",") == false)
                {
                    Value = Value.Insert(index, ",");
                    textBox1.Text = Value;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e) // "%"
        {
            if (!string.IsNullOrWhiteSpace(Value))
            {
                SecondValue = Convert.ToDouble(Value);

                Result = SecondValue / 100;
                Value = Convert.ToString(Result);
                textBox1.Text = Value;
            }
        }



        private void button16_Click(object sender, EventArgs e) //  Clear
        {
            if (Clear == 0)
            {
                Value = " ";
                Clear++;
                textBox1.Text = Value;
            }
            else if (Result != 0)
            {
                SecondValue = 0;
                ThirdValiue = 0;
                Result = 0;
                Value = " ";
                textBox1.Text = Value;
                Clear = 0;
                Sing = "";
                numbers = 0;
                i = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e) // +
        {
            if (!string.IsNullOrWhiteSpace(Value))
            {

                if (numbers == 0)
                {
                    SecondValue = Convert.ToDouble(Value);
                    numbers = 1;
                }

                if (i >= 1 && string.IsNullOrWhiteSpace(Value) == false)
                {
                    if (ThirdValiue == 0)
                    {
                        ThirdValiue = Convert.ToDouble(Value);
                        if (Sing == "-")
                        {
                            Result = SecondValue - ThirdValiue;
                            Value = " " + Convert.ToString(Result);

                            textBox1.Text = Value;
                        }
                        else if (Sing == "*")
                        {
                            Result = ThirdValiue * SecondValue;
                            Value = " " + Convert.ToString(Result);

                            textBox1.Text = Value;
                        }
                        else if (Sing == "/")
                        {
                            Result = SecondValue / ThirdValiue;
                            Value = " " + Convert.ToString(Result);

                            textBox1.Text = Value;
                        }
                        else if (Sing == "+")
                        {
                            ThirdValiue = Convert.ToDouble(Value);
                            Result = ThirdValiue + SecondValue;
                            Value = " " + Convert.ToString(Result);

                            textBox1.Text = Value;
                        }
                    }
                    else
                    {
                        SecondValue = Convert.ToDouble(Value);
                        if (Sing == "-")
                        {

                            Result = Result - ThirdValiue;
                            Value = " " + Convert.ToString(Result);

                            textBox1.Text = Value;
                        }
                        else if (Sing == "*")
                        {
                            Result = Result * SecondValue;
                            Value = " " + Convert.ToString(Result);

                            textBox1.Text = Value;
                        }
                        else if (Sing == "/")
                        {
                            Result = Result / SecondValue;
                            Value = " " + Convert.ToString(Result);

                            textBox1.Text = Value;
                        }
                        else if (Sing == "+")
                        {
                            SecondValue = Convert.ToDouble(Value);
                            Result += SecondValue;
                            Value = " " + Convert.ToString(Result);

                            textBox1.Text = Value;
                        }
                    }
                }
            }
            i++;
            Sing = "+";
            Value = " ";
        }

        private void button3_Click(object sender, EventArgs e) // -
        {
            if (!string.IsNullOrWhiteSpace(Value))
            {

                if (numbers == 0)
                {
                    SecondValue = Convert.ToDouble(Value);
                    numbers = 1;
                }

                if (i >= 1 && string.IsNullOrWhiteSpace(Value) == false)
                {
                    if (ThirdValiue == 0)
                    {
                        ThirdValiue = Convert.ToDouble(Value);
                        if (Sing == "+")
                        {
                            Result = SecondValue + ThirdValiue;
                            Value = " " + Convert.ToString(Result);

                            textBox1.Text = Value;
                        }
                        else if (Sing == "*")
                        {
                            Result = ThirdValiue * SecondValue;
                            Value = " " + Convert.ToString(Result);

                            textBox1.Text = Value;
                        }
                        else if (Sing == "/")
                        {
                            Result = SecondValue / ThirdValiue;
                            Value = " " + Convert.ToString(Result);

                            textBox1.Text = Value;
                        }
                        else if (Sing == "-")
                        {
                            Result = ThirdValiue - SecondValue;
                            Value = " " + Convert.ToString(Result);

                            textBox1.Text = Value;
                        }
                    }
                    else
                    {
                        SecondValue = Convert.ToDouble(Value);
                        if (Sing == "+")
                        {
                            Result = Result + ThirdValiue;
                            Value = " " + Convert.ToString(Result);

                            textBox1.Text = Value;
                        }
                        else if (Sing == "*")
                        {
                            Result = Result * SecondValue;
                            Value = " " + Convert.ToString(Result);

                            textBox1.Text = Value;
                        }
                        else if (Sing == "/")
                        {
                            Result = Result / SecondValue;
                            Value = " " + Convert.ToString(Result);

                            textBox1.Text = Value;
                        }
                        else if (Sing == "-")
                        {
                            SecondValue = Convert.ToDouble(Value);
                            Result = Result - SecondValue;
                            Value = " " + Convert.ToString(Result);

                            textBox1.Text = Value;
                        }
                    }
                }
            }
            Sing = "-";
            Value = " ";
            i++;
        }

        private void button2_Click(object sender, EventArgs e) // *
        {
            if (!string.IsNullOrWhiteSpace(Value))
            {

                if (numbers == 0)
                {
                    SecondValue = Convert.ToDouble(Value);
                    numbers = 1;
                }

                if (i >= 1 && string.IsNullOrWhiteSpace(Value) == false)
                {
                    if (ThirdValiue == 0)
                    {
                        ThirdValiue = Convert.ToDouble(Value);
                        if (Sing == "-")
                        {
                            Result = SecondValue - ThirdValiue;
                            Value = " " + Convert.ToString(Result);

                            textBox1.Text = Value;
                        }
                        else if (Sing == "+")
                        {
                            Result = ThirdValiue + SecondValue;
                            Value = " " + Convert.ToString(Result);

                            textBox1.Text = Value;
                        }
                        else if (Sing == "/")
                        {
                            Result = SecondValue / ThirdValiue;
                            Value = " " + Convert.ToString(Result);

                            textBox1.Text = Value;
                        }
                        else if (Sing == "*")
                        {
                            ThirdValiue = Convert.ToDouble(Value);
                            Result = ThirdValiue * SecondValue;
                            Value = " " + Convert.ToString(Result);

                            textBox1.Text = Value;
                        }
                    }
                    else
                    {
                        SecondValue = Convert.ToDouble(Value);
                        if (Sing == "-")
                        {

                            Result = Result - SecondValue;
                            Value = " " + Convert.ToString(Result);

                            textBox1.Text = Value;
                        }
                        else if (Sing == "+")
                        {
                            Result = Result + SecondValue;
                            Value = " " + Convert.ToString(Result);

                            textBox1.Text = Value;
                        }
                        else if (Sing == "/")
                        {
                            Result = Result / SecondValue;
                            Value = " " + Convert.ToString(Result);

                            textBox1.Text = Value;
                        }
                        else if (Sing == "*")
                        {
                            SecondValue = Convert.ToDouble(Value);
                            Result = Result * SecondValue;
                            Value = " " + Convert.ToString(Result);

                            textBox1.Text = Value;
                        }
                    }
                }
            }
            i++;
            Sing = "*";
            Value = " ";
        }

        private void button1_Click(object sender, EventArgs e) // /
        {
            if (!string.IsNullOrWhiteSpace(Value))
            {

                if (numbers == 0)
                {
                    SecondValue = Convert.ToDouble(Value);
                    numbers = 1;
                }

                if (i >= 1 && string.IsNullOrWhiteSpace(Value) == false)
                {
                    if (ThirdValiue == 0)
                    {
                        ThirdValiue = Convert.ToDouble(Value);
                        if (Sing == "-")
                        {
                            Result = SecondValue - ThirdValiue;
                            Value = " " + Convert.ToString(Result);

                            textBox1.Text = Value;
                        }
                        else if (Sing == "+")
                        {
                            Result = ThirdValiue + SecondValue;
                            Value = " " + Convert.ToString(Result);

                            textBox1.Text = Value;
                        }
                        else if (Sing == "*")
                        {
                            Result = SecondValue * ThirdValiue;
                            Value = " " + Convert.ToString(Result);

                            textBox1.Text = Value;
                        }
                        else if (Sing == "/")
                        {
                            ThirdValiue = Convert.ToDouble(Value);
                            Result = SecondValue / ThirdValiue;
                            Value = " " + Convert.ToString(Result);

                            textBox1.Text = Value;
                        }
                    }
                    else
                    {
                        SecondValue = Convert.ToDouble(Value);
                        if (Sing == "-")
                        {

                            Result = Result - SecondValue;
                            Value = " " + Convert.ToString(Result);

                            textBox1.Text = Value;
                        }
                        else if (Sing == "+")
                        {
                            Result = Result + SecondValue;
                            Value = " " + Convert.ToString(Result);

                            textBox1.Text = Value;
                        }
                        else if (Sing == "*")
                        {
                            Result = Result * SecondValue;
                            Value = " " + Convert.ToString(Result);

                            textBox1.Text = Value;
                        }
                        else if (Sing == "/")
                        {
                            SecondValue = Convert.ToDouble(Value);
                            Result = Result / SecondValue;
                            Value = " " + Convert.ToString(Result);

                            textBox1.Text = Value;
                        }
                    }
                }
            }
            i++;
            Sing = "/";
            Value = " ";
        }

        private void button5_Click(object sender, EventArgs e) // =
        {
            if (!string.IsNullOrWhiteSpace(Value))
            {
                if (count == 0)
                {
                    SecondValue = Convert.ToDouble(Value);
                    count++;
                }
                else
                {
                    Result = SecondValue;
                    SecondValue = Convert.ToDouble(Value);
                    count++;
                }


                if (Sing == "+")
                {
                    Result = Result + SecondValue;
                    Value = " " + Convert.ToString(Result);

                    textBox1.Text = Value;
                }
                else if (Sing == "-")
                {
                    Result = Result - SecondValue;
                    Value = " " + Convert.ToString(Result);

                    textBox1.Text = Value;
                }
                else if (Sing == "*")
                {
                    Result = Result * SecondValue;
                    Value = " " + Convert.ToString(Result);

                    textBox1.Text = Value;
                }
                else if (Sing == "/")
                {
                    Result = Result / SecondValue;
                    Value = " " + Convert.ToString(Result);

                    textBox1.Text = Value;
                }
                Sing = "";
            }
            else
            {
                textBox1.Text = "0";
            }
        }
    }
}