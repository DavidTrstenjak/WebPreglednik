namespace WebPreglednik
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.home = new System.Windows.Forms.Button();
            this.naprijed = new System.Windows.Forms.Button();
            this.nazad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 376);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 14);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(601, 41);
            this.textBox1.TabIndex = 4;
            // 
            // home
            // 
            this.home.BackgroundImage = global::WebPreglednik.Properties.Resources.home;
            this.home.Location = new System.Drawing.Point(736, 14);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(42, 43);
            this.home.TabIndex = 3;
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // naprijed
            // 
            this.naprijed.BackgroundImage = global::WebPreglednik.Properties.Resources.naprijed;
            this.naprijed.Location = new System.Drawing.Point(71, 13);
            this.naprijed.Name = "naprijed";
            this.naprijed.Size = new System.Drawing.Size(44, 43);
            this.naprijed.TabIndex = 2;
            this.naprijed.UseVisualStyleBackColor = true;
            this.naprijed.Click += new System.EventHandler(this.naprijed_Click);
            // 
            // nazad
            // 
            this.nazad.BackgroundImage = global::WebPreglednik.Properties.Resources.nazad1;
            this.nazad.Location = new System.Drawing.Point(13, 13);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(45, 43);
            this.nazad.TabIndex = 1;
            this.nazad.UseVisualStyleBackColor = true;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.home);
            this.Controls.Add(this.naprijed);
            this.Controls.Add(this.nazad);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.Button naprijed;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.TextBox textBox1;
    }
}

