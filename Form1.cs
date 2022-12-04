//sql express
//Micro sql server management studio
using System.Data;
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


        private void button3_Click(object sender, EventArgs e)
        {
            /*this.Show();
            Form2 form = new Form2();
            form.Show();*/
            conn.Open();
            string query = "Select * from Coders";
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "Manish")
                {
                    errorProvider1.SetError(textBox2, "Very Bad");
                }
                else
                {
                    conn.Open();
                    string data1 = textBox2.Text;
                    string data2 = textBox3.Text;
                    string data3 = textBox4.Text;
                    bool data4 = checkBox1.Checked;
                    bool data5 = radioButton1.Checked;
                    int data6 = dateTimePicker1.Value.Year;
                    int data7=dateTimePicker1 .Value.Month;
                    int data8=dateTimePicker1 .Value.Day;
                    int data9 = Convert.ToInt32(textBox5.Text);
                    string query1 = "Select Month from Coders where month='"+data9+"'";
                    SqlCommand sqlCommand = new SqlCommand(query1, conn);
                    int data=(int)sqlCommand.ExecuteScalar();
                    //SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
                    //DataTable dt = new DataTable();
                    //sda.Fill(dt);
                    if (data == data9)
                    {
                        MessageBox.Show("Already Exists");
                    }
                    conn.Close();
                    conn.Open();
                    string query = "Insert into Coders values('" + data1 + "','" + data2 + "','" + data3 + "','" + data4 + "','" + data5 + "','" + data6 + "','" + data7 + "','" + data8 + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Saved Successfully");
                    conn.Close();
                    /*cmd.Parameters.AddWithValue("@data1",textBox)*/
                }
            }
           catch (Exception ex)
            {
                MessageBox.Show("Save unsucessful "+ex.Message);
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
            catch (Exception )
            {
                MessageBox.Show("Deletion unsucessfull");
            }
        }

 
        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open();
            string query = "Select * from Coders";
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            /*dataGridView1.Rows.Add(content);*/
            conn.Close();
         /*   for(int i=0;i<dt.Rows.Count;i++)
            {
                string adt_id=dt.Rows[i]["id"].ToString();
            }*/
        }
        private void button6_Click(object sender, EventArgs e)
        {
            conn.Open();
            string dataUpd1 = textBox2.Text;
            string query = "SELECT * from Coders where name='"+dataUpd1+"'";
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                string data1 = dt.Rows[0]["name"].ToString();
                string data2 = dt.Rows[0]["coding_skill"].ToString();
                string data3 = dt.Rows[0]["looks"].ToString();
                bool test = false;
                bool data4 =Boolean.TryParse(dt.Rows[0]["Qualification"].ToString(),out test);
                bool data5 = Boolean.TryParse(dt.Rows[0]["GF"].ToString(),out test);
                textBox2.Text = data1;
                textBox3.Text = data2;
                textBox4.Text = data3;
                if(data4 == true)
                {
                    checkBox1.Checked=true;
                }
                else
                {
                    checkBox1.Checked = false;
                }
                if (data5 == true)
                {
                    radioButton1.Checked=true;
                }
                else
                {
                    radioButton1.Checked = false;
                }
            }
            conn.Close();
        }
        private void button7_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string data1 = textBox2.Text;
                string data2 = textBox3.Text;
                string data3 = textBox4.Text;
                string query = "UPDATE Coders SET name='" + data1 + "',coding_skill='" + data2 + "',Looks='" + data3 + "' WHERE name='" + data1 + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully");
                conn.Close();
            }
           catch (Exception ex)
            {
                MessageBox.Show("Update Unsucessfull. Error: "+ex.Message);
            }
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "Manish") 
            errorProvider1.SetError(textBox2,"Khattam Coder ho choose at your own risk");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Form3 something;
            this.Hide();
            something = new Form3();
            something.ShowDialog();
            this.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DataGridViewRow data = dataGridView1.CurrentRow;
            string name=data.Cells["name"].Value.ToString();
            string coding_skill=data.Cells["coding_skill"].Value.ToString();
            string Looks=data.Cells["Looks"].Value.ToString();
          /*  bool data4 = Convert.ToBoolean(data.Cells["Qualification"].Value);
            bool data5 = Convert.ToBoolean(data.Cells["GF"].Value);*/
            textBox2.Text = name;
            textBox3.Text = coding_skill;
            textBox4.Text = Looks;
           /* if (data4 == true)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
            if (data5 == true)
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton1.Checked = false;
            }*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*textBox1.Text = " ";
            textBox1.ForeColor = Color.Black;
            *//*textBox1.PasswordChar = '●';*//*
            textBox1.UseSystemPasswordChar = true;
            if (textBox1.Text.Length == 0)
            {
                textBox1.ForeColor = Color.Gray;

                textBox1.Text = "Enter password";

                textBox1.UseSystemPasswordChar = false;

                SelectNextControl(textBox1, true, true, false, true);
            }*/
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}