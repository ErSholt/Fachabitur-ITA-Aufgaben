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
        int x,i,j,summe,k,summe2;
        






        public Form1()
        {
            InitializeComponent();
        }

      
        
        
        
        
        private void btnwürfeln_Click(object sender, EventArgs e)
        {


            x = Convert.ToInt32(txtanzahl.Text);
            for (k = 1; k <= 1000; k = k + 1)
             {
                i = 0;
                
                for (i = 1; i <= x; i = i + 1)
                {

                    j = zufall.Next(1, 7);

                    if (j <= 1)
                    {
                        summe = 0;                        
                        i = x;
                    }
                    else
                    {
                        summe = summe + j;
                    }
                }
                summe2 = summe2 + summe;
            }





            if (summe > 0)
                lblsumme.Text = "Durschnittgewinn" + summe2/1000 + "cent";
                


        }






    }
}
