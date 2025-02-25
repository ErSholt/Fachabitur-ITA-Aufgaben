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
        string buchstaben = "abcdefghijklmnopqrstvwxyz", wort;
        Single x, punkte;
        Random zufall = new Random();

        public Form1()
        {
            InitializeComponent();
            
        }

      //####################################################
        private void Form1_Load(object sender, EventArgs e)
        {
            txtwort.Enabled = false;
            btnchecken.Enabled = false;
            
        }
      //####################################################

        private void btnanzeigen_Click(object sender, EventArgs e)
        {
            btnchecken.Enabled = false;
            txtwort.Enabled = false;
            x = zufall.Next(1, 27);
            wort = wort +  buchstaben.Substring(Convert.ToInt32(x - 1), 1 );
            lblzahl.Text = wort;
            btnanzeigen.Enabled = false;
            warte.Enabled = true;
        }
      //#####################################################
        private void warte_Tick(object sender, EventArgs e)
        {
            lblzahl.Text = "";
            warte.Enabled = false;
            btnchecken.Enabled = true;
            txtwort.Enabled = true;
        }
       //####################################################
        private void btnchecken_Click(object sender, EventArgs e)
        {
            if (txtwort.Text == wort)
            {
                lblziel.ForeColor = Color.Green;
                lblziel.Text = "Richtig nächstes lvl";
                btnanzeigen.Enabled = true;
                txtwort.Text = "";
                punkte = punkte + 1;
                lblpunkte.Text = "Punkte: " + punkte;
            }
            else
            {
                lblziel.ForeColor = Color.Red;
                lblziel.Text = "Falsch, die Lösung war: " + wort + ". Neue Runde!";
                txtwort.Text = "";
                wort = "";
                punkte = 0;
                lblpunkte.Text = "Punkte: " + punkte;
            }
            txtwort.Enabled = false;
            btnchecken.Enabled = false;
        }
      //####################################################
  

        private void txtwort_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                btnchecken_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();


        }
      //####################################################
    }
}
