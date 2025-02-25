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
            this.components = new System.ComponentModel.Container();
            this.lblzahl = new System.Windows.Forms.Label();
            this.btnanzeigen = new System.Windows.Forms.Button();
            this.txtwort = new System.Windows.Forms.TextBox();
            this.btnchecken = new System.Windows.Forms.Button();
            this.lblziel = new System.Windows.Forms.Label();
            this.warte = new System.Windows.Forms.Timer(this.components);
            this.lblpunkte = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblzahl
            // 
            this.lblzahl.AutoSize = true;
            this.lblzahl.BackColor = System.Drawing.Color.Gainsboro;
            this.lblzahl.Location = new System.Drawing.Point(13, 18);
            this.lblzahl.Name = "lblzahl";
            this.lblzahl.Size = new System.Drawing.Size(64, 13);
            this.lblzahl.TabIndex = 0;
            this.lblzahl.Text = "Buchstaben";
            // 
            // btnanzeigen
            // 
            this.btnanzeigen.Location = new System.Drawing.Point(13, 44);
            this.btnanzeigen.Name = "btnanzeigen";
            this.btnanzeigen.Size = new System.Drawing.Size(263, 23);
            this.btnanzeigen.TabIndex = 1;
            this.btnanzeigen.Text = "Buchstaben anzeigen";
            this.btnanzeigen.UseVisualStyleBackColor = true;
            this.btnanzeigen.Click += new System.EventHandler(this.btnanzeigen_Click);
            // 
            // txtwort
            // 
            this.txtwort.Location = new System.Drawing.Point(13, 88);
            this.txtwort.Name = "txtwort";
            this.txtwort.Size = new System.Drawing.Size(263, 20);
            this.txtwort.TabIndex = 2;
            this.txtwort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtwort_KeyDown);
            // 
            // btnchecken
            // 
            this.btnchecken.Location = new System.Drawing.Point(13, 114);
            this.btnchecken.Name = "btnchecken";
            this.btnchecken.Size = new System.Drawing.Size(263, 23);
            this.btnchecken.TabIndex = 3;
            this.btnchecken.Text = "Buchstaben checken";
            this.btnchecken.UseVisualStyleBackColor = true;
            this.btnchecken.Click += new System.EventHandler(this.btnchecken_Click);
            // 
            // lblziel
            // 
            this.lblziel.AutoSize = true;
            this.lblziel.Location = new System.Drawing.Point(13, 155);
            this.lblziel.Name = "lblziel";
            this.lblziel.Size = new System.Drawing.Size(76, 13);
            this.lblziel.TabIndex = 4;
            this.lblziel.Text = "Richtig/Falsch";
            // 
            // warte
            // 
            this.warte.Interval = 2000;
            this.warte.Tick += new System.EventHandler(this.warte_Tick);
            // 
            // lblpunkte
            // 
            this.lblpunkte.AutoSize = true;
            this.lblpunkte.Location = new System.Drawing.Point(13, 176);
            this.lblpunkte.Name = "lblpunkte";
            this.lblpunkte.Size = new System.Drawing.Size(44, 13);
            this.lblpunkte.TabIndex = 5;
            this.lblpunkte.Text = "Punkte:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Hangman Spielen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 244);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblpunkte);
            this.Controls.Add(this.lblziel);
            this.Controls.Add(this.btnchecken);
            this.Controls.Add(this.txtwort);
            this.Controls.Add(this.btnanzeigen);
            this.Controls.Add(this.lblzahl);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Buchstaben merken";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblzahl;
        private System.Windows.Forms.Button btnanzeigen;
        private System.Windows.Forms.TextBox txtwort;
        private System.Windows.Forms.Button btnchecken;
        private System.Windows.Forms.Label lblziel;
        private System.Windows.Forms.Timer warte;
        private System.Windows.Forms.Label lblpunkte;
        private System.Windows.Forms.Button button1;
    }
}

