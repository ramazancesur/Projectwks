namespace ParmakBoyu
{
    partial class FrmAnlik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnlik));
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValleyThickness = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRidgeThickness = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValleyCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRidgeCount = new System.Windows.Forms.TextBox();
            this.BtnSonuc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Valley Thickness";
            // 
            // txtValleyThickness
            // 
            this.txtValleyThickness.Location = new System.Drawing.Point(142, 103);
            this.txtValleyThickness.Name = "txtValleyThickness";
            this.txtValleyThickness.Size = new System.Drawing.Size(157, 23);
            this.txtValleyThickness.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Ridge Thickness";
            // 
            // txtRidgeThickness
            // 
            this.txtRidgeThickness.Location = new System.Drawing.Point(142, 72);
            this.txtRidgeThickness.Name = "txtRidgeThickness";
            this.txtRidgeThickness.Size = new System.Drawing.Size(157, 23);
            this.txtRidgeThickness.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Valley Count";
            // 
            // txtValleyCount
            // 
            this.txtValleyCount.Location = new System.Drawing.Point(142, 41);
            this.txtValleyCount.Name = "txtValleyCount";
            this.txtValleyCount.Size = new System.Drawing.Size(157, 23);
            this.txtValleyCount.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ridge Count ";
            // 
            // txtRidgeCount
            // 
            this.txtRidgeCount.Location = new System.Drawing.Point(142, 12);
            this.txtRidgeCount.Name = "txtRidgeCount";
            this.txtRidgeCount.Size = new System.Drawing.Size(157, 23);
            this.txtRidgeCount.TabIndex = 22;
            // 
            // BtnSonuc
            // 
            this.BtnSonuc.Location = new System.Drawing.Point(187, 173);
            this.BtnSonuc.Name = "BtnSonuc";
            this.BtnSonuc.Size = new System.Drawing.Size(112, 27);
            this.BtnSonuc.TabIndex = 34;
            this.BtnSonuc.Text = "Result";
            this.BtnSonuc.UseVisualStyleBackColor = true;
            this.BtnSonuc.Click += new System.EventHandler(this.BtnSonuc_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 27);
            this.button1.TabIndex = 35;
            this.button1.Text = "Previous";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmAnlik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(355, 239);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnSonuc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValleyThickness);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRidgeThickness);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValleyCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRidgeCount);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAnlik";
            this.Text = "Prediction";
            this.Load += new System.EventHandler(this.FrmAnlik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValleyThickness;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRidgeThickness;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValleyCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRidgeCount;
        private System.Windows.Forms.Button BtnSonuc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}