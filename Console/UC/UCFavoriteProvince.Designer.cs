namespace Console
{
    partial class UCFavoriteProvince
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNameProvince = new System.Windows.Forms.Label();
            this.picProvince = new System.Windows.Forms.PictureBox();
            this.lblFavouritePlace = new System.Windows.Forms.Label();
            this.picProvince2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProvince)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProvince2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.picProvince2);
            this.panel1.Controls.Add(this.picProvince);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 165);
            this.panel1.TabIndex = 0;
            // 
            // lblNameProvince
            // 
            this.lblNameProvince.AutoSize = true;
            this.lblNameProvince.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNameProvince.ForeColor = System.Drawing.Color.DimGray;
            this.lblNameProvince.Location = new System.Drawing.Point(319, 8);
            this.lblNameProvince.Name = "lblNameProvince";
            this.lblNameProvince.Size = new System.Drawing.Size(66, 30);
            this.lblNameProvince.TabIndex = 1;
            this.lblNameProvince.Text = "label1";
            // 
            // picProvince
            // 
            this.picProvince.Location = new System.Drawing.Point(17, 11);
            this.picProvince.Name = "picProvince";
            this.picProvince.Size = new System.Drawing.Size(261, 132);
            this.picProvince.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProvince.TabIndex = 0;
            this.picProvince.TabStop = false;
            // 
            // lblFavouritePlace
            // 
            this.lblFavouritePlace.AutoSize = true;
            this.lblFavouritePlace.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFavouritePlace.ForeColor = System.Drawing.Color.Black;
            this.lblFavouritePlace.Location = new System.Drawing.Point(13, 9);
            this.lblFavouritePlace.Name = "lblFavouritePlace";
            this.lblFavouritePlace.Size = new System.Drawing.Size(170, 23);
            this.lblFavouritePlace.TabIndex = 0;
            this.lblFavouritePlace.Text = "Most Favourite Place";
            // 
            // picProvince2
            // 
            this.picProvince2.Location = new System.Drawing.Point(313, 11);
            this.picProvince2.Name = "picProvince2";
            this.picProvince2.Size = new System.Drawing.Size(265, 132);
            this.picProvince2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProvince2.TabIndex = 1;
            this.picProvince2.TabStop = false;
            // 
            // UCFavoriteProvince
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblNameProvince);
            this.Controls.Add(this.lblFavouritePlace);
            this.Controls.Add(this.panel1);
            this.Name = "UCFavoriteProvince";
            this.Size = new System.Drawing.Size(597, 206);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProvince)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProvince2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFavouritePlace;
        private System.Windows.Forms.PictureBox picProvince;
        private System.Windows.Forms.Label lblNameProvince;
        private System.Windows.Forms.PictureBox picProvince2;
    }
}
