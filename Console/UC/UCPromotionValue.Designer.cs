using System.Reflection.Emit;

namespace Console.UC
{
    partial class UCPromotionValue
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPromotionValue));
            this.pbPromotion = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnFind = new Guna.UI2.WinForms.Guna2Button();
            this.lblSubTitle = new Console.GrowLabel();
            this.lblTitle = new Console.GrowLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbPromotion)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPromotion
            // 
            this.pbPromotion.BackColor = System.Drawing.Color.Transparent;
            this.pbPromotion.BorderRadius = 10;
            this.pbPromotion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPromotion.Image = ((System.Drawing.Image)(resources.GetObject("pbPromotion.Image")));
            this.pbPromotion.ImageRotate = 0F;
            this.pbPromotion.Location = new System.Drawing.Point(0, 0);
            this.pbPromotion.Name = "pbPromotion";
            this.pbPromotion.Size = new System.Drawing.Size(611, 190);
            this.pbPromotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPromotion.TabIndex = 2;
            this.pbPromotion.TabStop = false;
            this.pbPromotion.UseTransparentBackground = true;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFind.BorderRadius = 10;
            this.btnFind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFind.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(104)))), ((int)(((byte)(238)))));
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(21, 127);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(180, 45);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find Early 2024 Deals";
            this.btnFind.UseTransparentBackground = true;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.BackColor = System.Drawing.Color.White;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblSubTitle.Location = new System.Drawing.Point(17, 38);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(428, 20);
            this.lblSubTitle.TabIndex = 3;
            this.lblSubTitle.Text = "Save 15% or more when you book and stay before April 1, 2024";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblTitle.Location = new System.Drawing.Point(17, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(210, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "New year, new adventures";
            // 
            // UCPromotionValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbPromotion);
            this.Name = "UCPromotionValue";
            this.Size = new System.Drawing.Size(611, 190);
            ((System.ComponentModel.ISupportInitialize)(this.pbPromotion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Guna.UI2.WinForms.Guna2PictureBox pbPromotion;
        public Guna.UI2.WinForms.Guna2Button btnFind;
        public GrowLabel lblTitle;
        public GrowLabel lblSubTitle;
    }
}
