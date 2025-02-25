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
            this.btnstart = new System.Windows.Forms.Button();
            this.lblanton = new System.Windows.Forms.Label();
            this.lblcäsar = new System.Windows.Forms.Label();
            this.lblberta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(13, 29);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(263, 23);
            this.btnstart.TabIndex = 0;
            this.btnstart.Text = "Test Starten 3000 Fach";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // lblanton
            // 
            this.lblanton.AutoSize = true;
            this.lblanton.Location = new System.Drawing.Point(13, 67);
            this.lblanton.Name = "lblanton";
            this.lblanton.Size = new System.Drawing.Size(78, 13);
            this.lblanton.TabIndex = 1;
            this.lblanton.Text = "Anton Statistik:";
            // 
            // lblcäsar
            // 
            this.lblcäsar.AutoSize = true;
            this.lblcäsar.Location = new System.Drawing.Point(13, 107);
            this.lblcäsar.Name = "lblcäsar";
            this.lblcäsar.Size = new System.Drawing.Size(77, 13);
            this.lblcäsar.TabIndex = 2;
            this.lblcäsar.Text = "Cäsar Statisitk:";
            // 
            // lblberta
            // 
            this.lblberta.AutoSize = true;
            this.lblberta.Location = new System.Drawing.Point(13, 146);
            this.lblberta.Name = "lblberta";
            this.lblberta.Size = new System.Drawing.Size(75, 13);
            this.lblberta.TabIndex = 3;
            this.lblberta.Text = "Berta Statistik:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 266);
            this.Controls.Add(this.lblberta);
            this.Controls.Add(this.lblcäsar);
            this.Controls.Add(this.lblanton);
            this.Controls.Add(this.btnstart);
            this.Name = "Form1";
            this.Text = "Würfelspiel 3000";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Label lblanton;
        private System.Windows.Forms.Label lblcäsar;
        private System.Windows.Forms.Label lblberta;
    }
}

