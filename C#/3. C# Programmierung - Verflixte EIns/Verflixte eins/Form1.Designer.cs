namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtanzahl = new System.Windows.Forms.TextBox();
            this.btnwürfeln = new System.Windows.Forms.Button();
            this.lblsumme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anzahl der Würfel:";
            // 
            // txtanzahl
            // 
            this.txtanzahl.Location = new System.Drawing.Point(114, 17);
            this.txtanzahl.Name = "txtanzahl";
            this.txtanzahl.Size = new System.Drawing.Size(100, 20);
            this.txtanzahl.TabIndex = 1;
            // 
            // btnwürfeln
            // 
            this.btnwürfeln.Location = new System.Drawing.Point(13, 54);
            this.btnwürfeln.Name = "btnwürfeln";
            this.btnwürfeln.Size = new System.Drawing.Size(263, 23);
            this.btnwürfeln.TabIndex = 2;
            this.btnwürfeln.Text = "Würfel!";
            this.btnwürfeln.UseVisualStyleBackColor = true;
            this.btnwürfeln.Click += new System.EventHandler(this.btnwürfeln_Click);
            // 
            // lblsumme
            // 
            this.lblsumme.AutoSize = true;
            this.lblsumme.Location = new System.Drawing.Point(14, 106);
            this.lblsumme.Name = "lblsumme";
            this.lblsumme.Size = new System.Drawing.Size(85, 13);
            this.lblsumme.TabIndex = 3;
            this.lblsumme.Text = "Geld gewonnen:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 266);
            this.Controls.Add(this.lblsumme);
            this.Controls.Add(this.btnwürfeln);
            this.Controls.Add(this.txtanzahl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Verflixte eins";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtanzahl;
        private System.Windows.Forms.Button btnwürfeln;
        private System.Windows.Forms.Label lblsumme;
    }
}

