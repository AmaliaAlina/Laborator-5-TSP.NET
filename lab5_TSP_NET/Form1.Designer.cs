namespace lab4_TSP_NET
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
            this.buttonScenariu1 = new System.Windows.Forms.Button();
            this.buttonScenariu2 = new System.Windows.Forms.Button();
            this.buttonScenariu3 = new System.Windows.Forms.Button();
            this.buttonScenariu4 = new System.Windows.Forms.Button();
            this.buttonScenariu5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonScenariu1
            // 
            this.buttonScenariu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonScenariu1.Location = new System.Drawing.Point(0, 0);
            this.buttonScenariu1.Name = "buttonScenariu1";
            this.buttonScenariu1.Size = new System.Drawing.Size(493, 23);
            this.buttonScenariu1.TabIndex = 0;
            this.buttonScenariu1.Text = "Scenariu 1 ( incarcare si afisare date in aceasta baza de date)";
            this.buttonScenariu1.UseVisualStyleBackColor = true;
            this.buttonScenariu1.Click += new System.EventHandler(this.buttonScenariu1_Click);
            // 
            // buttonScenariu2
            // 
            this.buttonScenariu2.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonScenariu2.Location = new System.Drawing.Point(0, 23);
            this.buttonScenariu2.Name = "buttonScenariu2";
            this.buttonScenariu2.Size = new System.Drawing.Size(493, 23);
            this.buttonScenariu2.TabIndex = 1;
            this.buttonScenariu2.Text = "Scenariu 2";
            this.buttonScenariu2.UseVisualStyleBackColor = true;
            this.buttonScenariu2.Click += new System.EventHandler(this.buttonScenariu2_Click);
            // 
            // buttonScenariu3
            // 
            this.buttonScenariu3.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonScenariu3.Location = new System.Drawing.Point(0, 46);
            this.buttonScenariu3.Name = "buttonScenariu3";
            this.buttonScenariu3.Size = new System.Drawing.Size(493, 23);
            this.buttonScenariu3.TabIndex = 2;
            this.buttonScenariu3.Text = "Scenariu 3";
            this.buttonScenariu3.UseVisualStyleBackColor = true;
            this.buttonScenariu3.Click += new System.EventHandler(this.buttonScenariu3_Click);
            // 
            // buttonScenariu4
            // 
            this.buttonScenariu4.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonScenariu4.Location = new System.Drawing.Point(0, 69);
            this.buttonScenariu4.Name = "buttonScenariu4";
            this.buttonScenariu4.Size = new System.Drawing.Size(493, 23);
            this.buttonScenariu4.TabIndex = 3;
            this.buttonScenariu4.Text = "Scenariu 4";
            this.buttonScenariu4.UseVisualStyleBackColor = true;
            this.buttonScenariu4.Click += new System.EventHandler(this.buttonScenariu4_Click);
            // 
            // buttonScenariu5
            // 
            this.buttonScenariu5.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonScenariu5.Location = new System.Drawing.Point(0, 92);
            this.buttonScenariu5.Name = "buttonScenariu5";
            this.buttonScenariu5.Size = new System.Drawing.Size(493, 23);
            this.buttonScenariu5.TabIndex = 4;
            this.buttonScenariu5.Text = "Scenariu 5";
            this.buttonScenariu5.UseVisualStyleBackColor = true;
            this.buttonScenariu5.Click += new System.EventHandler(this.buttonScenariu5_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonScenariu5);
            this.panel1.Controls.Add(this.buttonScenariu4);
            this.panel1.Controls.Add(this.buttonScenariu3);
            this.panel1.Controls.Add(this.buttonScenariu2);
            this.panel1.Controls.Add(this.buttonScenariu1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 450);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(493, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 450);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Afisarea Scenariu 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonScenariu1;
        private System.Windows.Forms.Button buttonScenariu2;
        private System.Windows.Forms.Button buttonScenariu3;
        private System.Windows.Forms.Button buttonScenariu4;
        private System.Windows.Forms.Button buttonScenariu5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}

