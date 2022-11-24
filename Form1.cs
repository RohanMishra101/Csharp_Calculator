namespace Calculator
{
    public partial class Form1 : Form
    {
        string operate="";
        decimal calculate1=0,calculate2=0;
        int count = 0;
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
        public void check1()
        {
            if (display.Text != "" && display.Text != "+" && display.Text != "-" && display.Text != "*" && display.Text != "/")
            {
                calculate1 = Convert.ToDecimal(display.Text);
            }
        }
        public void check2()
        {
            if (display.Text != "" && display.Text != "+" && display.Text != "-" && display.Text != "*" && display.Text != "/")
            {
                calculate2 = Convert.ToDecimal(display.Text);
            }
        }
        private void add_Click(object sender, EventArgs e)
        {
            string str1 = display.Text;
            display.Text = str1 + " + ";
            check1();
            operate = "+";
            display.Clear();
            
            count = 1;
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
            check1();
            operate = "/";
            count = 2;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string str1 = display.Text;
            display.Text = str1 + " * ";
            check1();
            operate = "*";
            count = 3;
        }

        private void sub_Click(object sender, EventArgs e)
        {
            string str1 = display.Text;
            display.Text = str1 + " - ";
            check1();
            operate = "-";
            count = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void display_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button16_Click(object sender, EventArgs e)
        {
            mainCal(count);
        }
        public void mainCal(int count)
        {
            decimal ans;
            switch(count)
            {
                case 1:
                    ans =calculate1+Convert.ToDecimal(display.Text);
                    display.Text = ans.ToString();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    break;
            }
        }
    }
}