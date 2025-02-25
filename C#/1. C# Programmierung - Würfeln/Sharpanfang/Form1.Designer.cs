namespace WindowsFormsApplication2
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
            this.btnwürfeln = new System.Windows.Forms.Button();
            this.lblzahl = new System.Windows.Forms.Label();
            this.btn1fach = new System.Windows.Forms.Button();
            this.btn10fach = new System.Windows.Forms.Button();
            this.btn100fach = new System.Windows.Forms.Button();
            this.lblsumme = new System.Windows.Forms.Label();
            this.lblsumme2 = new System.Windows.Forms.Label();
            this.lblwin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnwürfeln
            // 
            this.btnwürfeln.Location = new System.Drawing.Point(13, 13);
            this.btnwürfeln.Name = "btnwürfeln";
            this.btnwürfeln.Size = new System.Drawing.Size(236, 23);
            this.btnwürfeln.TabIndex = 0;
            this.btnwürfeln.Text = "Würfeln Spieler1";
            this.btnwürfeln.UseVisualStyleBackColor = true;
            this.btnwürfeln.Click += new System.EventHandler(this.btnwürfeln_Click);
            // 
            // lblzahl
            // 
            this.lblzahl.AutoSize = true;
            this.lblzahl.Location = new System.Drawing.Point(13, 43);
            this.lblzahl.Name = "lblzahl";
            this.lblzahl.Size = new System.Drawing.Size(85, 13);
            this.lblzahl.TabIndex = 1;
            this.lblzahl.Text = "Gewürfelte Zahl:";
            // 
            // btn1fach
            // 
            this.btn1fach.Location = new System.Drawing.Point(12, 69);
            this.btn1fach.Name = "btn1fach";
            this.btn1fach.Size = new System.Drawing.Size(75, 37);
            this.btn1fach.TabIndex = 2;
            this.btn1fach.Text = "1-Fach Werten";
            this.btn1fach.UseVisualStyleBackColor = true;
            this.btn1fach.Click += new System.EventHandler(this.btn1fach_Click);
            // 
            // btn10fach
            // 
            this.btn10fach.Location = new System.Drawing.Point(93, 69);
            this.btn10fach.Name = "btn10fach";
            this.btn10fach.Size = new System.Drawing.Size(75, 37);
            this.btn10fach.TabIndex = 3;
            this.btn10fach.Text = "10-Fach Werten";
            this.btn10fach.UseVisualStyleBackColor = true;
            this.btn10fach.Click += new System.EventHandler(this.btn10fach_Click);
            // 
            // btn100fach
            // 
            this.btn100fach.Location = new System.Drawing.Point(174, 69);
            this.btn100fach.Name = "btn100fach";
            this.btn100fach.Size = new System.Drawing.Size(75, 37);
            this.btn100fach.TabIndex = 4;
            this.btn100fach.Text = "100-Fach Werten";
            this.btn100fach.UseVisualStyleBackColor = true;
            this.btn100fach.Click += new System.EventHandler(this.btn100fach_Click);
            // 
            // lblsumme
            // 
            this.lblsumme.AutoSize = true;
            this.lblsumme.Location = new System.Drawing.Point(13, 128);
            this.lblsumme.Name = "lblsumme";
            this.lblsumme.Size = new System.Drawing.Size(92, 13);
            this.lblsumme.TabIndex = 5;
            this.lblsumme.Text = "Summe Spieler 1: ";
            // 
            // lblsumme2
            // 
            this.lblsumme2.AutoSize = true;
            this.lblsumme2.Location = new System.Drawing.Point(13, 141);
            this.lblsumme2.Name = "lblsumme2";
            this.lblsumme2.Size = new System.Drawing.Size(89, 13);
            this.lblsumme2.TabIndex = 6;
            this.lblsumme2.Text = "Summe Spieler 2:";
            // 
            // lblwin
            // 
            this.lblwin.AutoSize = true;
            this.lblwin.Location = new System.Drawing.Point(16, 191);
            this.lblwin.Name = "lblwin";
            this.lblwin.Size = new System.Drawing.Size(80, 13);
            this.lblwin.TabIndex = 7;
            this.lblwin.Text = "Gewonnen hat:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 266);
            this.Controls.Add(this.lblwin);
            this.Controls.Add(this.lblsumme2);
            this.Controls.Add(this.lblsumme);
            this.Controls.Add(this.btn100fach);
            this.Controls.Add(this.btn10fach);
            this.Controls.Add(this.btn1fach);
            this.Controls.Add(this.lblzahl);
            this.Controls.Add(this.btnwürfeln);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Würfelspiel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnwürfeln;
        private System.Windows.Forms.Label lblzahl;
        private System.Windows.Forms.Button btn1fach;
        private System.Windows.Forms.Button btn10fach;
        private System.Windows.Forms.Button btn100fach;
        private System.Windows.Forms.Label lblsumme;
        private System.Windows.Forms.Label lblsumme2;
        private System.Windows.Forms.Label lblwin;
    }
}

