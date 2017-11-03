using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {            
            this.progressBar1.Increment(2);
            sayac++;

            if(sayac == 55)
            {
                this.Hide();
                MessageBox.Show("Kurulum Tamamlandı.");
                this.Close();
            }
           
        }
    }
}
