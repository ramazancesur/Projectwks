namespace ParmakBoyu
{
    partial class CrossValidation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrossValidation));
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtDosya = new System.Windows.Forms.TextBox();
            this.BtnAra = new System.Windows.Forms.Button();
            this.BtnSonuc = new System.Windows.Forms.Button();
            this.txtFolds = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 144);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 28);
            this.button1.TabIndex = 20;
            this.button1.Text = "Previous";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtDosya
            // 
            this.txtDosya.Location = new System.Drawing.Point(128, 33);
            this.txtDosya.Margin = new System.Windows.Forms.Padding(4);
            this.txtDosya.Name = "txtDosya";
            this.txtDosya.Size = new System.Drawing.Size(232, 22);
            this.txtDosya.TabIndex = 14;
            // 
            // BtnAra
            // 
            this.BtnAra.Location = new System.Drawing.Point(256, 63);
            this.BtnAra.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(104, 28);
            this.BtnAra.TabIndex = 15;
            this.BtnAra.Text = "Open File Path";
            this.BtnAra.UseVisualStyleBackColor = true;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // BtnSonuc
            // 
            this.BtnSonuc.Location = new System.Drawing.Point(16, 144);
            this.BtnSonuc.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSonuc.Name = "BtnSonuc";
            this.BtnSonuc.Size = new System.Drawing.Size(183, 28);
            this.BtnSonuc.TabIndex = 16;
            this.BtnSonuc.Text = "Result";
            this.BtnSonuc.UseVisualStyleBackColor = true;
            this.BtnSonuc.Click += new System.EventHandler(this.BtnSonuc_Click);
            // 
            // txtFolds
            // 
            this.txtFolds.Location = new System.Drawing.Point(198, 105);
            this.txtFolds.Margin = new System.Windows.Forms.Padding(4);
            this.txtFolds.Name = "txtFolds";
            this.txtFolds.Size = new System.Drawing.Size(162, 22);
            this.txtFolds.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cross Validation Folds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "File Path";
            // 
            // CrossValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(369, 190);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFolds);
            this.Controls.Add(this.BtnSonuc);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.txtDosya);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CrossValidation";
            this.Text = "CrossValidation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtDosya;
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.Button BtnSonuc;
        private System.Windows.Forms.TextBox txtFolds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;


    }
}