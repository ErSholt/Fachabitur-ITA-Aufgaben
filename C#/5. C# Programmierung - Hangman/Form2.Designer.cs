namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtwort = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnvergleichen = new System.Windows.Forms.Button();
            this.lblfalsch = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buchstabenmerken spielen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gewünschtes Wort zum raten eingeben:";
            // 
            // txtwort
            // 
            this.txtwort.Location = new System.Drawing.Point(7, 31);
            this.txtwort.Name = "txtwort";
            this.txtwort.Size = new System.Drawing.Size(269, 20);
            this.txtwort.TabIndex = 2;
            this.txtwort.TextChanged += new System.EventHandler(this.txtwort_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(7, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Starten";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl1.Location = new System.Drawing.Point(4, 101);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(272, 45);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Ratewort";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // btnvergleichen
            // 
            this.btnvergleichen.Location = new System.Drawing.Point(169, 57);
            this.btnvergleichen.Name = "btnvergleichen";
            this.btnvergleichen.Size = new System.Drawing.Size(107, 30);
            this.btnvergleichen.TabIndex = 5;
            this.btnvergleichen.Text = "Vergleichen";
            this.btnvergleichen.UseVisualStyleBackColor = true;
            this.btnvergleichen.Click += new System.EventHandler(this.btnvergleichen_Click);
            // 
            // lblfalsch
            // 
            this.lblfalsch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblfalsch.ForeColor = System.Drawing.Color.Red;
            this.lblfalsch.Location = new System.Drawing.Point(4, 146);
            this.lblfalsch.Name = "lblfalsch";
            this.lblfalsch.Size = new System.Drawing.Size(284, 41);
            this.lblfalsch.TabIndex = 6;
            this.lblfalsch.Text = "Falsche Antworten: 0/7\r\nGesamt Antworten: 0/7\r\n";
            this.lblfalsch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(291, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 303);
            this.panel1.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 264);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(269, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Neue Runde - Neues Glück";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 328);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblfalsch);
            this.Controls.Add(this.btnvergleichen);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtwort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Galgenmänchen";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtwort;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnvergleichen;
        private System.Windows.Forms.Label lblfalsch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
    }
}