namespace ParmakBoyu
{
    partial class FCinsiyet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCinsiyet));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEgitim = new System.Windows.Forms.TextBox();
            this.btnSonuc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDosya = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "File Path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Traning Set %";
            // 
            // txtEgitim
            // 
            this.txtEgitim.Location = new System.Drawing.Point(158, 88);
            this.txtEgitim.Name = "txtEgitim";
            this.txtEgitim.Size = new System.Drawing.Size(145, 27);
            this.txtEgitim.TabIndex = 11;
            // 
            // btnSonuc
            // 
            this.btnSonuc.Location = new System.Drawing.Point(5, 140);
            this.btnSonuc.Name = "btnSonuc";
            this.btnSonuc.Size = new System.Drawing.Size(156, 27);
            this.btnSonuc.TabIndex = 10;
            this.btnSonuc.Text = "Result";
            this.btnSonuc.UseVisualStyleBackColor = true;
            this.btnSonuc.Click += new System.EventHandler(this.btnSonuc_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = "Open File Path";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtDosya
            // 
            this.txtDosya.Location = new System.Drawing.Point(100, 18);
            this.txtDosya.Name = "txtDosya";
            this.txtDosya.Size = new System.Drawing.Size(203, 27);
            this.txtDosya.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 27);
            this.button2.TabIndex = 14;
            this.button2.Text = "Previous";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FCinsiyet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(317, 179);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEgitim);
            this.Controls.Add(this.btnSonuc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDosya);
            this.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FCinsiyet";
            this.Text = "BLOOD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEgitim;
        private System.Windows.Forms.Button btnSonuc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDosya;
        private System.Windows.Forms.Button button2;


    }
}

