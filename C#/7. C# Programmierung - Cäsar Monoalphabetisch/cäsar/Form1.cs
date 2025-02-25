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
    public partial class Form1 : Form
    {
        //#########################################################
        const string buchstabe = "abcdefghijklmnopqrstvwxyz";
        string word,enwort,dewort,index;
        int länge,i,k,j,a;
        Boolean all = false;   
        //#########################################################
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Maximum = 25;
            numericUpDown2.Maximum = 25;
        }
        //#####################################################
        private void btnen_Click(object sender, EventArgs e)
        {
            dewort = "";
            txten.Text = "";
            word = txtwort.Text;
            länge = word.Length;
            k = Convert.ToInt32(numericUpDown1.Value);
            for (i = 0; i < länge; i++)
            {
                enwort = word.Substring(i, 1);
                enwort = enwort.ToLower();

                for (j = 0; j < 25; j++)
                {

                    int position = buchstabe.IndexOf(enwort);
                    int max = position - k;
                    int minus = Math.Abs(max) ;
                    index = buchstabe.Substring(j, 1);

                    if (index == enwort)
                    {                      
                        if (max <0)
                        {
                            dewort = dewort + buchstabe.Substring(25 - minus , 1);
                        }
                        if (max  >=0)
                        {
                            dewort = dewort + buchstabe.Substring(j - k, 1);
                        }                       
                    }
                }
            }
            txten.Text = dewort;
        }
        //#########################################################
        private void btnde_Click(object sender, EventArgs e)
        {
            if (all == true)
            {               
                dewort = "";
                txtde.Text = "";
                word = txten.Text;
                länge = word.Length;
                
                for (a = 1; a < 25; a++)
                {
                    for (i = 0; i < länge; i++)
                    {
                        enwort = word.Substring(i, 1);
                        enwort = enwort.ToLower();
                        for (j = 0; j < 25; j++)
                        {
                            index = buchstabe.Substring(j, 1);
                            if (index == enwort)
                            {
                                int position = buchstabe.IndexOf(enwort);
                                int max = position + a;
                                int höher = max - 25;
                                if (max < 25)
                                {
                                    dewort = dewort + buchstabe.Substring(j + a, 1);
                                }
                                if (max >= 25)
                                {
                                    dewort = dewort + buchstabe.Substring(0 + höher, 1);
                                }
                            }
                        }
                    }
                    lballe.Items.Add(a + " Verschiebungen: " + dewort);
                    dewort = "";
                }               
            }

            if (all == false)                
            {               
                dewort = "";
                txtde.Text = "";
                word = txten.Text;
                länge = word.Length;
                k = Convert.ToInt32(numericUpDown2.Value);
                    for (i = 0; i < länge; i++)
                    {
                        enwort = word.Substring(i, 1);
                        enwort = enwort.ToLower();
                        for (j = 0; j < 25; j++)
                        {
                            index = buchstabe.Substring(j, 1);
                            if (index == enwort)
                            {
                                int position = buchstabe.IndexOf(enwort);
                                int max = position + k;
                                int höher = max - 25;                                
                                 if (max < 25)
                                 {
                                     dewort = dewort + buchstabe.Substring(j + k, 1);
                                 }
                                if(max >= 25)
                                {
                                    dewort = dewort + buchstabe.Substring(0 + höher, 1);
                                }
                            }
                        }          
                    }
                    txtde.Text = dewort;                                    
                }
        }
        //#############################################################
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (all == false)
            {
                numericUpDown2.Enabled = false;
                txtde.Enabled = false;
                all = true;
            }
            else 
            {
                numericUpDown2.Enabled = true;
                txtde.Enabled = true;
                all = false;                
            }
        }
        //#####################################################
        private void txtwort_TextChanged(object sender, EventArgs e)
        {

        }
        //#####################################################
        private void button1_Click(object sender, EventArgs e)
        {
        }
        //#####################################################
        private void btnmono_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //#####################################################
        
    }
}
