using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private async void Form3_Load(object sender, EventArgs e)
        {

            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            for (int i = 0; i < 100; i++)
            {
                progressBar1.PerformStep();
            }
            await Task.Delay(1000);
            this.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void process1_Exited(object sender, EventArgs e)
        {
            
        }
    }
}
