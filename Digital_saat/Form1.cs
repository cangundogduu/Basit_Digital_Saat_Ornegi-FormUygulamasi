using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_saat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int saat = 0, dakika = 0, saniye = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            label3.Text = saniye.ToString();
            if (saniye == 20)
            {
                dakika++;
                label2.Text = dakika.ToString();
                saniye = 0;
            }
            if (dakika == 5)
            {
                saat++;
                label1.Text = saat.ToString();
                dakika = 0;
            
            }
            if (saat == 5)
            {
                saat = 0;
                
            }
        }
    }
}
