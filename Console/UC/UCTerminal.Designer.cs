namespace Console
{
    partial class UCTerminal
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
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnPeople = new Guna.UI2.WinForms.Guna2Button();
            this.dtCheckout = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtCheckin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbProvince = new RJCodeAdvance.RJControls.RJComboBox();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSearch.BorderRadius = 10;
            this.btnSearch.BorderThickness = 1;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(224)))), ((int)(((byte)(94)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1009, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(270, 50);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseTransparentBackground = true;
            // 
            // btnPeople
            // 
            this.btnPeople.BackColor = System.Drawing.Color.Transparent;
            this.btnPeople.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPeople.BorderRadius = 10;
            this.btnPeople.BorderThickness = 1;
            this.btnPeople.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPeople.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPeople.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPeople.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPeople.FillColor = System.Drawing.Color.White;
            this.btnPeople.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeople.ForeColor = System.Drawing.Color.DimGray;
            this.btnPeople.Location = new System.Drawing.Point(733, 24);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Size = new System.Drawing.Size(270, 50);
            this.btnPeople.TabIndex = 0;
            this.btnPeople.Text = "People";
            this.btnPeople.UseTransparentBackground = true;
            // 
            // dtCheckout
            // 
            this.dtCheckout.BackColor = System.Drawing.Color.Transparent;
            this.dtCheckout.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(104)))), ((int)(((byte)(238)))));
            this.dtCheckout.BorderRadius = 10;
            this.dtCheckout.BorderThickness = 1;
            this.dtCheckout.Checked = true;
            this.dtCheckout.CheckedState.FillColor = System.Drawing.Color.White;
            this.dtCheckout.CheckedState.ForeColor = System.Drawing.Color.DimGray;
            this.dtCheckout.FillColor = System.Drawing.Color.White;
            this.dtCheckout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCheckout.ForeColor = System.Drawing.Color.DimGray;
            this.dtCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCheckout.Location = new System.Drawing.Point(527, 24);
            this.dtCheckout.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtCheckout.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtCheckout.Name = "dtCheckout";
            this.dtCheckout.Size = new System.Drawing.Size(200, 50);
            this.dtCheckout.TabIndex = 1;
            this.dtCheckout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtCheckout.UseTransparentBackground = true;
            this.dtCheckout.Value = new System.DateTime(2024, 3, 16, 13, 14, 8, 798);
            // 
            // dtCheckin
            // 
            this.dtCheckin.BackColor = System.Drawing.Color.Transparent;
            this.dtCheckin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(104)))), ((int)(((byte)(238)))));
            this.dtCheckin.BorderRadius = 10;
            this.dtCheckin.BorderThickness = 1;
            this.dtCheckin.Checked = true;
            this.dtCheckin.CheckedState.FillColor = System.Drawing.Color.White;
            this.dtCheckin.CheckedState.ForeColor = System.Drawing.Color.DimGray;
            this.dtCheckin.FillColor = System.Drawing.Color.White;
            this.dtCheckin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCheckin.ForeColor = System.Drawing.Color.DimGray;
            this.dtCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCheckin.Location = new System.Drawing.Point(321, 24);
            this.dtCheckin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtCheckin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtCheckin.Name = "dtCheckin";
            this.dtCheckin.Size = new System.Drawing.Size(200, 50);
            this.dtCheckin.TabIndex = 0;
            this.dtCheckin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtCheckin.UseTransparentBackground = true;
            this.dtCheckin.Value = new System.DateTime(2024, 3, 16, 13, 14, 8, 798);
            // 
            // cbProvince
            // 
            this.cbProvince.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbProvince.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbProvince.BorderSize = 1;
            this.cbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbProvince.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProvince.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.cbProvince.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbProvince.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbProvince.ListTextColor = System.Drawing.Color.DimGray;
            this.cbProvince.Location = new System.Drawing.Point(45, 24);
            this.cbProvince.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Padding = new System.Windows.Forms.Padding(1);
            this.cbProvince.Size = new System.Drawing.Size(270, 50);
            this.cbProvince.TabIndex = 4;
            this.cbProvince.Texts = "Select Location";
            // 
            // UCTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(104)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.dtCheckin);
            this.Controls.Add(this.dtCheckout);
            this.Controls.Add(this.btnPeople);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbProvince);
            this.Name = "UCTerminal";
            this.Size = new System.Drawing.Size(1326, 100);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnPeople;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtCheckout;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtCheckin;
        private RJCodeAdvance.RJControls.RJComboBox cbProvince;
    }
}
