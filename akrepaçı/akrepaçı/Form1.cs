using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace akrepaçı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double akrp, ylkvn, aci, akrpaci, ylkvnaci;

        private void button1_Click(object sender, EventArgs e)
        {            
            akrp = Convert.ToInt32(textBox1.Text);
            ylkvn = Convert.ToInt32(textBox2.Text);
            get_angle(akrp, ylkvn);
            textBox1.Clear();
            textBox2.Clear();
        }

        private void get_angle(double akrp, double ylkvn)
        {
            if(akrp < 13)
            {
                akrpaci = (akrp * 30);
                ylkvnaci = ylkvn * 5.5;
                aci = akrpaci - ylkvnaci;

                if(aci < 0)
                {
                    aci = aci * (-1);
                    label4.Text = aci.ToString();
                }
                else
                {
                    label4.Text = aci.ToString();
                }
            }
            else if(akrp >= 13)
            {
                akrpaci = ((akrp - 12) * 30);
                ylkvnaci = ylkvn * 5.5;
                aci = akrpaci - ylkvnaci;

                if (aci < 0)
                {
                    aci = aci * (-1);
                    label4.Text = aci.ToString();
                }
                else
                {
                    label4.Text = aci.ToString();
                }
            }
        }
    }
}
