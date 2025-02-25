using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        string pfad, schlüssel, secret,klarwort, neubuch, buchstabe;
        const string abc = "abcdefghijklmnopqrstvwxyz";

        private void txtverwort_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        int i, position, länge;

        public Form2()
        {
            InitializeComponent();
        }
        //####################################################################
        private void button1_Click(object sender, EventArgs e)
        {          
            OpenFileDialog   schlüsselsuche = new OpenFileDialog();
            if (schlüsselsuche.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pfad = schlüsselsuche.FileName;
                txtpfad.Text = pfad;
            }              
        }
        //####################################################################
        private void btnentschlüssel_Click(object sender, EventArgs e)
        {

            secret = txtwort.Text.ToLower();
            länge = secret.Length;


            if (File.Exists(pfad))
            {
                StreamReader key = new StreamReader(pfad, System.Text.Encoding.Default);
                schlüssel = key.ReadToEnd();
                key.Close();
               
            }
            
            for (i = 0; i < länge; i++)
            {
                buchstabe = secret.Substring(i, 1);
                position = schlüssel.IndexOf(buchstabe);
                neubuch = abc.Substring(position, 1);
                klarwort = klarwort + neubuch;
            }
            txtverwort.Text = klarwort;
            listBox1.Items.Add(schlüssel);
            listBox2.Items.Add(klarwort);




        }
        //####################################################################
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        //####################################################################
    }
}
