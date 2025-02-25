using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        Random zufall = new Random();
        int x;
        int summe1, summe2, zählen;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnwürfeln_Click(object sender, EventArgs e)
        {




            if (zählen == 3)
            {
                btn100fach.Enabled = true;
                btn10fach.Enabled = true;
                btn1fach.Enabled = true;
            }


            x = zufall.Next(1, 7);
            lblzahl.Text = "Gewürfelte Zahl: " + Convert.ToString(x);





        }

        private void btn1fach_Click(object sender, EventArgs e)
        {




            if (zählen < 3)
            {
                summe1 = summe1 + x;
                lblsumme.Text = "Summe Spieler1: " + Convert.ToString(summe1);
                btn1fach.Enabled = false;
            }
            else
            {
                summe2 = summe2 + x;
                lblsumme2.Text = "Summe Spieler2: " + Convert.ToString(summe2);
                btn1fach.Enabled = false;
            }

            zählen = zählen + 1;

            if (zählen == 3)
            {
                btnwürfeln.Text = "Würfeln Spieler2";
            }


            if ((zählen == 6) && (summe1 < summe2))
            {
                lblwin.Text = "Gewonnen hat Spieler 1";
            }
            else
            {
                lblwin.Text = "Gewonnen hat Spieler2";
            }





        }

        private void btn10fach_Click(object sender, EventArgs e)
        {




            if (zählen < 3)
            {
                summe1 = summe1 + x * 10;
                lblsumme.Text = "Summe Spieler1: " + Convert.ToString(summe1);
                btn10fach.Enabled = false;
            }
            else
            {
                summe2 = summe2 + x * 10;
                lblsumme2.Text = "Summe Spieler2: " + Convert.ToString(summe2);
                btn10fach.Enabled = false;
            }

            zählen = zählen + 1;

            if (zählen == 3)
            {
                btnwürfeln.Text = "Würfeln Spieler2";
            }


            if ((zählen == 6) && (summe1 < summe2))
            {
                lblwin.Text = "Gewonnen hat Spieler 1";
            }
            else
            {
                lblwin.Text = "Gewonnen hat Spieler2";
            }





        }

        private void btn100fach_Click(object sender, EventArgs e)
        {





            if (zählen < 3)
            {
                summe1 = summe1 + x * 100;
                lblsumme.Text = "SummeSpieler1: " + Convert.ToString(summe1);
                btn100fach.Enabled = false;
            }
            else
            {
                summe2 = summe2 + x * 100;
                lblsumme2.Text = "Summe Spieler2: " + Convert.ToString(summe2);
                btn100fach.Enabled = false;

            }

            zählen = zählen + 1;

            if (zählen == 3)
            {
                btnwürfeln.Text = "Würfeln Spieler2";
            }


                if ((zählen == 6) && (summe1 < summe2))
                {
                    lblwin.Text = "Gewonnen hat Spieler 1";
                }
                else
                {
                    lblwin.Text = "Gewonnen hat Spieler2";
                }



            
        }
    }
}
