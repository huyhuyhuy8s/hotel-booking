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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProvince)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblNameProvince);
            this.panel1.Controls.Add(this.picProvince);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 154);
            this.panel1.TabIndex = 0;
            // 
            // lblNameProvince
            // 
            this.lblNameProvince.AutoSize = true;
            this.lblNameProvince.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNameProvince.ForeColor = System.Drawing.Color.DimGray;
            this.lblNameProvince.Location = new System.Drawing.Point(174, 57);
            this.lblNameProvince.Name = "lblNameProvince";
            this.lblNameProvince.Size = new System.Drawing.Size(57, 21);
            this.lblNameProvince.TabIndex = 1;
            this.lblNameProvince.Text = "label1";
            // 
            // picProvince
            // 
            this.picProvince.Location = new System.Drawing.Point(20, 11);
            this.picProvince.Name = "picProvince";
            this.picProvince.Size = new System.Drawing.Size(122, 132);
            this.picProvince.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProvince.TabIndex = 0;
            this.picProvince.TabStop = false;
            // 
            // lblFavouritePlace
            // 
            this.lblFavouritePlace.AutoSize = true;
            this.lblFavouritePlace.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFavouritePlace.ForeColor = System.Drawing.Color.Black;
            this.lblFavouritePlace.Location = new System.Drawing.Point(16, 15);
            this.lblFavouritePlace.Name = "lblFavouritePlace";
            this.lblFavouritePlace.Size = new System.Drawing.Size(170, 23);
            this.lblFavouritePlace.TabIndex = 0;
            this.lblFavouritePlace.Text = "Most Favourite Place";
            // 
            // UCFavoriteProvince
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblFavouritePlace);
            this.Controls.Add(this.panel1);
            this.Name = "UCFavoriteProvince";
            this.Size = new System.Drawing.Size(648, 206);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProvince)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFavouritePlace;
        private System.Windows.Forms.PictureBox picProvince;
        private System.Windows.Forms.Label lblNameProvince;
    }
}
