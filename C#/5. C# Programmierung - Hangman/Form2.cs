using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {


        string rate, lösung, guess, word;
        int länge,i,zähler,count,gesamt, kürze;




        public Form2()
        {
           
            InitializeComponent();

        }

        //####################################################
        private void button1_Click(object sender, EventArgs e)
        {

            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();

        }
        //####################################################
        private void button2_Click(object sender, EventArgs e)
        {

            lösung = txtwort.Text;
            länge = lösung.Length;
           
            for (int i = 0; i < länge; i++)
            {               
                rate = rate + "#";
            }
            lbl1.Text = rate;
            btnvergleichen.Enabled = true;
            button2.Enabled = false;
            txtwort.Text = "";
            


            

           



        }
        //####################################################
        private void btnvergleichen_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Black, 10);
            Pen b = new Pen(Color.Black, 5);

            gesamt = gesamt + 1;
            kürze = txtwort.Text.Length;
            if (kürze <= 1)
            {

                if (zähler < 10)
                {

                    guess = txtwort.Text;
                    for (i = 0; i < länge; i++)
                    {
                        word = lösung.Substring(i, 1);
                       
                        if (guess == word)
                        {
                            rate = rate.Remove(i, 1);
                            rate = rate.Insert(i, guess);
                            count = count + 1;
                            lbl1.Text = rate;
                            lblfalsch.Text = " Falsche Antworten: " + Convert.ToString(zähler) + "/7" + Environment.NewLine + "Gesamt Anzahl der Versuche:" + gesamt;

                            if (rate == lösung)
                            {
                                lblfalsch.ForeColor = Color.Green;
                                lblfalsch.Text = " Glückwunsch sie haben haben Gewonnen mit " + gesamt + " Versuch/en und davon " + zähler + " falschen";
                                btnvergleichen.Enabled = false;
                            }
                        }
                    }

                        if (count >= 1)
                        {
                            count = 0;
                        }
                        else
                        {
                            count = 0;
                            zähler = zähler + 1;
                            lblfalsch.Text = " Falsche Antworten: " + Convert.ToString(zähler) + "/7" + Environment.NewLine + "Gesamt Anzahl der Versuche:" + gesamt;



                            if (zähler == 1)
                            {

                                g.DrawLine(p, new Point(250, 300), new Point(250, 5));

                            }
                            if (zähler == 2)
                            {

                                g.DrawLine(p, new Point(255, 5), new Point(100, 5));

                            }

                            if (zähler == 3)
                            {

                                g.DrawLine(p, new Point(105, 5), new Point(105, 50));

                            }

                            if (zähler == 4)
                            {

                                g.DrawEllipse(b, 90, 50, 30, 30);

                            }

                            if (zähler == 5)
                            {

                                g.DrawLine(b, new Point(105, 80), new Point(105, 140));

                            }

                            if (zähler == 6)
                            {

                                g.DrawLine(b, new Point(105, 95), new Point(120, 120));
                                g.DrawLine(b, new Point(105, 95), new Point(90, 120));


                            }

                            if (zähler == 7)
                            {

                                g.DrawLine(b, new Point(105, 140), new Point(120, 160));
                                g.DrawLine(b, new Point(105, 140), new Point(90, 160));
                                btnvergleichen.Enabled = false;
                                lblfalsch.Text = "Sie haben zuviele versuche gebraucht ihr Hangman ist tod. " + Environment.NewLine + "Die lösung war: " + lösung;


                            }

                        }
                    }
                }

                else
                {
                    guess = txtwort.Text;

                    if (guess == lösung)
                    {
                        lblfalsch.ForeColor = Color.Green;
                        lblfalsch.Text = " Glückwunsch sie haben haben Gewonnen mit " + gesamt + " Versuch/en und davon " + zähler + " falschen";
                        btnvergleichen.Enabled = false;
                        lbl1.Text = guess;

                    }
                    else
                    {
                        zähler = zähler + 1;
                        lblfalsch.Text = " Falsche Antworten: " + Convert.ToString(zähler) + "/7" + Environment.NewLine + "Gesamt Anzahl der Versuche:" + gesamt;



                        if (zähler == 1)
                        {

                            g.DrawLine(p, new Point(250, 300), new Point(250, 5));

                        }
                        if (zähler == 2)
                        {

                            g.DrawLine(p, new Point(255, 5), new Point(100, 5));

                        }

                        if (zähler == 3)
                        {

                            g.DrawLine(p, new Point(105, 5), new Point(105, 50));

                        }

                        if (zähler == 4)
                        {

                            g.DrawEllipse(b, 90, 50, 30, 30);

                        }

                        if (zähler == 5)
                        {

                            g.DrawLine(b, new Point(105, 80), new Point(105, 140));

                        }

                        if (zähler == 6)
                        {

                            g.DrawLine(b, new Point(105, 95), new Point(120, 120));
                            g.DrawLine(b, new Point(105, 95), new Point(90, 120));


                        }

                        if (zähler == 7)
                        {

                            g.DrawLine(b, new Point(105, 140), new Point(120, 160));
                            g.DrawLine(b, new Point(105, 140), new Point(90, 160));
                            btnvergleichen.Enabled = false;
                            lblfalsch.Text = "Sie haben zuviele versuche gebraucht ihr Hangman ist tod. " + Environment.NewLine + "Die lösung war: " + lösung;
                        }


                    }
                
            }
        }
        
        //####################################################
        private void lbl1_Click(object sender, EventArgs e)
        {

        }
        //####################################################
        private void Form2_Load(object sender, EventArgs e)
        {
            btnvergleichen.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            count = 0;
            zähler = 0;
            btnvergleichen.Enabled = false;
            button2.Enabled = true;
            rate = "";
            lösung = "";
            guess = "";
            word = "";
            gesamt = 0;
            länge = 0;
            lblfalsch.Text = "Falsche Antworten 0/7" + Environment.NewLine + "Gesamt Antworten: 0";
            panel1.Controls.Clear();
            lbl1.Text = "";
            panel1.Invalidate();
            lblfalsch.ForeColor = Color.Red;
            txtwort.Text = "";



             
               



        }

        private void txtwort_TextChanged(object sender, EventArgs e)
        {

        }
        //####################################################










    }
}
