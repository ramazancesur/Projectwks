namespace ParmakBoyu
{
    partial class Grup_Secimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grup_Secimi));
            this.btnCross = new System.Windows.Forms.Button();
            this.BtnYuzde = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCross
            // 
            this.btnCross.Location = new System.Drawing.Point(13, 13);
            this.btnCross.Margin = new System.Windows.Forms.Padding(4);
            this.btnCross.Name = "btnCross";
            this.btnCross.Size = new System.Drawing.Size(142, 151);
            this.btnCross.TabIndex = 0;
            this.btnCross.Text = "Cross Validation";
            this.btnCross.UseVisualStyleBackColor = true;
            this.btnCross.Click += new System.EventHandler(this.btnCross_Click);
            // 
            // BtnYuzde
            // 
            this.BtnYuzde.Location = new System.Drawing.Point(181, 13);
            this.BtnYuzde.Margin = new System.Windows.Forms.Padding(4);
            this.BtnYuzde.Name = "BtnYuzde";
            this.BtnYuzde.Size = new System.Drawing.Size(140, 151);
            this.BtnYuzde.TabIndex = 1;
            this.BtnYuzde.Text = "Percentage of Train Set\r\n";
            this.BtnYuzde.UseVisualStyleBackColor = true;
            this.BtnYuzde.Click += new System.EventHandler(this.BtnYuzde_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Previous";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Grup_Secimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(330, 222);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnYuzde);
            this.Controls.Add(this.btnCross);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Grup_Secimi";
            this.Text = "Choosing Groups";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCross;
        private System.Windows.Forms.Button BtnYuzde;
        private System.Windows.Forms.Button button1;
    }
}