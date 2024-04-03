using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronometre_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dakika = 0, saniye = 0, salise = 1;

        private void durdur_Click(object sender, EventArgs e)
        {
            durdur.Enabled = false;
            sifirla.Enabled = true;
            timer1.Stop();
            basla.Enabled = true;
            basla.Text = "DEVAM ET";
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (salise == 60)
            {
                saniye++;
                salise = 0;
                if (saniye == 60)
                {
                    dakika++;
                    saniye = 0;
                }
            }
            label4.Text = Convert.ToString(dakika);
            label5.Text = Convert.ToString(saniye);
            label6.Text = Convert.ToString(salise);
            salise++;
        }

        private void sifirla_Click(object sender, EventArgs e)
        {
            dakika = 0;
            saniye = 0;
            salise = 0;
            basla.Enabled = true;
            durdur.Enabled = false;
            sifirla.Enabled = false;
            basla.Text = "BAŞLA";
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
        }

        private void basla_Click(object sender, EventArgs e)
        {
            timer1.Start();
            basla.Enabled = false;
            durdur.Enabled = true;
            sifirla.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
            durdur.Enabled = false;
            sifirla.Enabled = false;
        }
    }
}
