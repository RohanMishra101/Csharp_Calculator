using System.Data.SqlClient;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string operate = "";
        decimal result = 0;
        DataGridView Da = new DataGridView();
        //USING . instead of address helps to access every other device
        SqlConnection conn=new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=goodData;user id=sa;password=joker1245780;");
        public Form1()
        {
            InitializeComponent();
        }
        
        private void num1_Click(object sender, EventArgs e)
        {
            
            if (display.Text == "+" || display.Text == "-" || display.Text == "*" || display.Text == "/")
            {
                display.Text = "1";
            }
            else
            {
                string str = display.Text;
                display.Text=  str + "1";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (display.Text == "+" || display.Text == "-" || display.Text == "*" || display.Text == "/")
            {
                display.Text = "2";
            }
            else
            {
                string str = display.Text;
                display.Text = str + "2";
            }
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (display.Text == "+" || display.Text == "-" || display.Text == "*" || display.Text == "/")
            {
                display.Text = "3";
            }
            else
            {
                string str = display.Text;
                display.Text = str + "3";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (display.Text == "+" || display.Text == "-" || display.Text == "*" || display.Text == "/")
            {
                display.Text = "4";
            }
            else
            {
                string str = display.Text;
                display.Text = str + "4";
            }
        }
        private void num5_Click(object sender, EventArgs e)
        {
            if (display.Text == "+" || display.Text == "-" || display.Text == "*" || display.Text == "/")
            {
                display.Text = "5";
            }
            else
            {
                string str = display.Text;
                display.Text = str + "5";
            }
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (display.Text == "+" || display.Text == "-" || display.Text == "*" || display.Text == "/")
            {
                display.Text = "6";
            }
            else
            {
                string str = display.Text;
                display.Text = str + "6";
            }
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (display.Text == "+" || display.Text == "-" || display.Text == "*" || display.Text == "/")
            {
                display.Text = "7";
            }
            else
            {
                string str = display.Text;
                display.Text = str + "7";
            }
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (display.Text == "+" || display.Text == "-" || display.Text == "*" || display.Text == "/")
            {
                display.Text = "8";
            }
            else
            {
                string str = display.Text;
                display.Text = str + "8";
            }
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (display.Text == "+" || display.Text == "-" || display.Text == "*" || display.Text == "/")
            {
                display.Text = "9";
            }
            else
            {
                string str = display.Text;
                display.Text = str + "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (display.Text == "+" || display.Text == "-" || display.Text == "*" || display.Text == "/")
            {
                display.Text = "0";
            }
            else
            {
                string str = display.Text;
                display.Text = str + "0";
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            GetResult();
            operate = "+";
            display.Text = "+";

        }
        public void GetResult()
        {
            if (display.Text != "" && display.Text != "+" && display.Text != "-" && display.Text != "*" && display.Text != "/" )
            {
                result = Convert.ToDecimal(display.Text);
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            decimal firstNum = result;
            decimal secondNum = Convert.ToDecimal(display.Text);
            switch (operate)
            {
                case "+":
                    result = (firstNum+secondNum);
                    display.Text = firstNum + " + " + secondNum + " = " + result.ToString();
                    break;
                case "-":
                    result = (firstNum - secondNum);
                    display.Text = firstNum + " - " + secondNum + " = " + result.ToString();
                    break;
                case "*":
                    result = (firstNum * secondNum);
                    display.Text = firstNum + " * " + secondNum + " = " + result.ToString();
                    break;
                case "/":
                    result = (firstNum / secondNum);
                    display.Text = firstNum + " / " + secondNum + " = " + result.ToString();
                    break;
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            string str1 = display.Text;
            display.Text = str1 + ".";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            GetResult();
            operate = "+";
            display.Text = "/";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            GetResult();
            operate = "*";
            display.Text = "*";
        }

        private void sub_Click(object sender, EventArgs e)
        {
            GetResult();
            operate = "-";
            display.Text = "-";
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

        private void button3_Click(object sender, EventArgs e)
        {
            /*this.Show();
            Form2 form = new Form2();
            form.Show();*/
            string str1 = textBox2.Text;
            string str2 = textBox3.Text;
            string str3 = textBox4.Text;
            dataGridView1.Rows.Add(str1,str2,str3);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string data1 = textBox2.Text;
                string data2 = textBox3.Text;
                string data3 = textBox4.Text;
                string query = "Insert into Coders values('"+ data1+"','"+ data2+"','"+ data3+"')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully");
                conn.Close();
            }
           catch (Exception ex)
            {
                MessageBox.Show("Save unsucessfull");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string dataDel = textBox2.Text;
                conn.Open();
                string query = "DELETE From Coders where name = '"+dataDel+"'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deletion unsucessfull");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string dataUpd1 = textBox2.Text;
                string dataUpd2 = textBox3.Text;
                string dataUpd3 = textBox4.Text;
                conn.Open();
                string query = "UPDATE Coders SET name = '"+dataUpd1+"', coding_skill = '"+dataUpd2+"', Looks = '"+dataUpd3+"' WHERE name = '"+dataUpd1+"'; ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update unsucessfull");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}