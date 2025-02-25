using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Random zufall = new Random();

        int berta, anton, cäsar, zählen, x1, x2, x3;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnstart_Click(object sender, EventArgs e)
        {

            do
            {
                x1 = zufall.Next(1, 7);
                x2 = zufall.Next(1, 7);
                x3 = x1 + x2;

                if ((x3 > 1 )&& (x3 <=5 ))
                {
                    anton = anton + 1;
                }
                else if ((x3 >= 6) && (x3 <= 8))
                {
                    berta = berta + 1;
                }
                else if (x3 >= 9) 
                {
                    cäsar = cäsar + 1;
                }

                zählen = zählen + 1;

            }
            while (zählen <= 3000);



            lblanton.Text = "Anton Statistik: " + anton + " Gewonnen, " + anton / 30 + "% Gewinnchance";
            lblberta.Text = "Berta Statistik: " + berta + " Gewonnen, " + berta / 30 + "% Gewinnchance";
            lblcäsar.Text = "Cäsar Statistik: " + cäsar + " Gewonnen, " + cäsar / 30 + "% Gewinnchance";









        }
    }
}
