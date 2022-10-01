namespace calculator_VP_Assignment_1_190878
{
    public partial class Form1 : Form
    {
        private int operand_1 , operand_2;
        private string opertion; 
        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == "")
            {
                inputBox.Text = "0";
            }
            else
            {
                if(inputBox.Text == "0")
                {

                }
                else
                {
                    inputBox.Text += "0";
                }
                
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if(inputBox.Text == "")
            {
                inputBox.Text = "1";
            }
            else
            {
                inputBox.Text += "1";
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == "")
            {
                inputBox.Text = "2";
            }
            else
            {
                inputBox.Text += "2";
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == "")
            {
                inputBox.Text = "3";
            }
            else
            {
                inputBox.Text += "3";
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == "")
            {
                inputBox.Text = "4";
            }
            else
            {
                inputBox.Text += "4";
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == "")
            {
                inputBox.Text = "5";
            }
            else
            {
                inputBox.Text += "5";
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == "")
            {
                inputBox.Text = "6";
            }
            else
            {
                inputBox.Text += "6";
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == "")
            {
                inputBox.Text = "7";
            }
            else
            {
                inputBox.Text += "7";
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == "")
            {
                inputBox.Text = "8";
            }
            else
            {
                inputBox.Text += "8";
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == "")
            {
                inputBox.Text = "9";
            }
            else
            {
                inputBox.Text += "9";
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(inputBox.Text != "")
            {
                operand_1 = Convert.ToInt32(inputBox.Text);
                opertion = "+";
                inputBox.Text = "";
            }
        }

        private void btn_equals_Click(object sender, EventArgs e)
        {
            try
            {
                if (inputBox.Text != "")
                {
                    operand_2 = Convert.ToInt32(inputBox.Text);
                    if (opertion == "+")
                    {
                        inputBox.Text = Convert.ToString(operand_1 + operand_2);
                    }
                    else if (opertion == "-")
                    {

                        inputBox.Text = Convert.ToString(operand_1 - operand_2);
                    }
                    else if (opertion == "*")
                    {

                        inputBox.Text = Convert.ToString(operand_1 * operand_2);
                    }
                    else if (opertion == "/")
                    {

                        inputBox.Text = Convert.ToString(operand_1 / operand_2);
                    }
                }

            }
            catch(Exception)
            {
                MessageBox.Show("zero can't be denominator");
                inputBox.Text = "";

            }
           

        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (inputBox.Text != "")
            {
                operand_1 = Convert.ToInt32(inputBox.Text);
                opertion = "-";
                inputBox.Text = "";
            }
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            if (inputBox.Text != "")
            {
                operand_1 = Convert.ToInt32(inputBox.Text);
                opertion = "*";
                inputBox.Text = "";
            }
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            if (inputBox.Text != "")
            {
                operand_1 = Convert.ToInt32(inputBox.Text);
                opertion = "/";
                inputBox.Text = "";
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if(inputBox.Text != "")
            {
                inputBox.Text = "";
            }
        }
    }
}