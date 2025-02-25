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
            this.txtwort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txten = new System.Windows.Forms.TextBox();
            this.btnde = new System.Windows.Forms.Button();
            this.txtde = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.lballe = new System.Windows.Forms.ListBox();
            this.btnmono = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtwort
            // 
            this.txtwort.Location = new System.Drawing.Point(13, 24);
            this.txtwort.Name = "txtwort";
            this.txtwort.Size = new System.Drawing.Size(263, 20);
            this.txtwort.TabIndex = 0;
            this.txtwort.TextChanged += new System.EventHandler(this.txtwort_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zu verschlüsselndes Wort eingeben:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(13, 50);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "... Stellen verschieben";
            // 
            // btnen
            // 
            this.btnen.Location = new System.Drawing.Point(13, 76);
            this.btnen.Name = "btnen";
            this.btnen.Size = new System.Drawing.Size(263, 23);
            this.btnen.TabIndex = 5;
            this.btnen.Text = "Verschlüsselung starten";
            this.btnen.UseVisualStyleBackColor = true;
            this.btnen.Click += new System.EventHandler(this.btnen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Verschlüsselter Text:";
            // 
            // txten
            // 
            this.txten.Location = new System.Drawing.Point(13, 128);
            this.txten.Name = "txten";
            this.txten.Size = new System.Drawing.Size(263, 20);
            this.txten.TabIndex = 7;
            // 
            // btnde
            // 
            this.btnde.Location = new System.Drawing.Point(13, 180);
            this.btnde.Name = "btnde";
            this.btnde.Size = new System.Drawing.Size(263, 23);
            this.btnde.TabIndex = 8;
            this.btnde.Text = "Entschlüsselung starten";
            this.btnde.UseVisualStyleBackColor = true;
            this.btnde.Click += new System.EventHandler(this.btnde_Click);
            // 
            // txtde
            // 
            this.txtde.Location = new System.Drawing.Point(13, 209);
            this.txtde.Name = "txtde";
            this.txtde.Size = new System.Drawing.Size(263, 20);
            this.txtde.TabIndex = 10;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(59, 155);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(124, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Alle zahlen probieren";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(13, 154);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown2.TabIndex = 12;
            // 
            // lballe
            // 
            this.lballe.FormattingEnabled = true;
            this.lballe.Location = new System.Drawing.Point(302, 13);
            this.lballe.Name = "lballe";
            this.lballe.Size = new System.Drawing.Size(344, 212);
            this.lballe.TabIndex = 13;
            // 
            // btnmono
            // 
            this.btnmono.Location = new System.Drawing.Point(13, 232);
            this.btnmono.Name = "btnmono";
            this.btnmono.Size = new System.Drawing.Size(629, 23);
            this.btnmono.TabIndex = 14;
            this.btnmono.Text = "Auf Monoalphabetische Verschlüselung wechseln";
            this.btnmono.UseVisualStyleBackColor = true;
            this.btnmono.Click += new System.EventHandler(this.btnmono_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 267);
            this.Controls.Add(this.btnmono);
            this.Controls.Add(this.lballe);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtde);
            this.Controls.Add(this.btnde);
            this.Controls.Add(this.txten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtwort);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Cäsar - Verschlüsselung";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtwort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txten;
        private System.Windows.Forms.Button btnde;
        private System.Windows.Forms.TextBox txtde;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.ListBox lballe;
        private System.Windows.Forms.Button btnmono;
    }
}

