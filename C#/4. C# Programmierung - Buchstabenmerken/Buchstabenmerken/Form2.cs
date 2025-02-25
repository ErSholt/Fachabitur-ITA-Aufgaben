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
    public partial class Form2 : Form
    {
        string ratewort, raute, type, ratewort2,type2;
        Single länge, a;
        int i;
        
        




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

           
            ratewort = txtwort.Text.ToLower();
            länge = ratewort.Length;
            char[] ratewort2 = new string('_', ratewort.Length).ToCharArray();
            lbl1.Text = ratewort2;
            button2.Enabled = false;
            label1.Text = "Aufgehts raten sie jeden buchstaben! " + ratewort;
            btnvergleichen.Enabled = true;

           



        }
        //####################################################
        private void btnvergleichen_Click(object sender, EventArgs e)
        {
          



            lbl1.Text = ratewort2;
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
        //####################################################










    }
}
