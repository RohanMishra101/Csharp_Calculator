namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = display.Text;
            display.Text = str + "4";
        }

        private void num1_Click(object sender, EventArgs e)
        {
            /*num1.Text = "1";*/
            string str = display.Text;
            display.Text = str + "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string str = display.Text;
            display.Text = str + "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            string str = display.Text;
            display.Text = str + "3";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            string str = display.Text;
            display.Text = str + "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            string str = display.Text;
            display.Text = str + "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            string str = display.Text;
            display.Text = str + "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            string str = display.Text;
            display.Text = str + "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            string str = display.Text;
            display.Text = str + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string str = display.Text;
            display.Text = str + "0";
        }

        private void add_Click(object sender, EventArgs e)
        {
            string str1 = display.Text;
            display.Text = str1 + " + ";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string str2 = display.Text;
            //MessageBox.Show(str2);
            int len = str2.Length;
            for (int i = 0; str2[i] < len; i++)
            {
                if (str2[i] == '+')
                {
                    

                }
                else if (str2[i] == '-')
                {

                }
                else if (str2[i] == '*')
                {

                }
                else if (str2[i]== '/')
                {
                    
                }
                else
                {
                    string tempNum = Convert.ToString(str2[i]);
                    string num1 = " ";
                    num1 += tempNum;
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string str1 = display.Text;
            display.Text = str1 + ".";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string str1 = display.Text;
            display.Text = str1 + " / ";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string str1 = display.Text;
            display.Text = str1 + " * ";
        }

        private void sub_Click(object sender, EventArgs e)
        {
            string str1 = display.Text;
            display.Text = str1 + " - ";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void display_TextChanged(object sender, EventArgs e)
        {

        }
    }
}