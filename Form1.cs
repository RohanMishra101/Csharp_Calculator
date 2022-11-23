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
            add_Click(display.Text, e);
        }

        private void add_Click(object sender, EventArgs e)
        {
            string str1 = display.Text;
            display.Text = str1 + " + ";
            button16_Click("+", e);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            /*if (sender == "+")
            {

            }*/
        }
    }
}