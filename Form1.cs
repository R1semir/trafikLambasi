using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trafikLambasi
{
    public partial class Form1 : Form
    {
        int sure = 0;
        public Form1()
        {
            InitializeComponent();
        }
        //ışık süreleri 3 lamba mevcut. 0 ile 30 saniye kırmızı. 30 ile 40 sarı . 40 ile 70 yeşil sıfırla sonra.
        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = sure.ToString();
            if (sure == 0)
            {
                BackColor = Color.Red;
            }
            if (sure == 30)
            {
                BackColor = Color.Yellow;
            }
            if (sure == 40)
            {
                BackColor = Color.Green;
            }
            if (sure == 70)
            {

                sure = -1;
            }
            sure++;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
