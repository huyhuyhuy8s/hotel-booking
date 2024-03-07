using System.Reflection.Emit;
using System.Windows.Forms;

namespace Console
{
    partial class Terminal
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
            this.lblDiaDiem = new System.Windows.Forms.Label();
            this.cBoxDiaDiem = new System.Windows.Forms.ComboBox();
            this.lblNgayDi = new System.Windows.Forms.Label();
            this.lblNgayVe = new System.Windows.Forms.Label();
            this.dtPickerNgayDi = new System.Windows.Forms.DateTimePicker();
            this.dtPickerNgayVe = new System.Windows.Forms.DateTimePicker();
            this.lblSoNguoi = new System.Windows.Forms.Label();
            this.btnTang = new System.Windows.Forms.Button();
            this.btnGiam = new System.Windows.Forms.Button();
            this.lblSNguoi = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.lblGiaTien = new System.Windows.Forms.Label();
            this.lblTrackBar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDiaDiem
            // 
            this.lblDiaDiem.AutoSize = true;
            this.lblDiaDiem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaDiem.Location = new System.Drawing.Point(30, 4);
            this.lblDiaDiem.Name = "lblDiaDiem";
            this.lblDiaDiem.Size = new System.Drawing.Size(61, 17);
            this.lblDiaDiem.TabIndex = 0;
            this.lblDiaDiem.Text = "Dia diem";
            // 
            // cBoxDiaDiem
            // 
            this.cBoxDiaDiem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxDiaDiem.FormattingEnabled = true;
            this.cBoxDiaDiem.Items.AddRange(new object[] {
            "Da Nang",
            "Ha Noi",
            "TP.HCM",
            "Binh Duong",
            "Dong Nai"});
            this.cBoxDiaDiem.Location = new System.Drawing.Point(127, 3);
            this.cBoxDiaDiem.Name = "cBoxDiaDiem";
            this.cBoxDiaDiem.Size = new System.Drawing.Size(284, 25);
            this.cBoxDiaDiem.TabIndex = 2;
            this.cBoxDiaDiem.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblNgayDi
            // 
            this.lblNgayDi.AutoSize = true;
            this.lblNgayDi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDi.Location = new System.Drawing.Point(31, 42);
            this.lblNgayDi.Name = "lblNgayDi";
            this.lblNgayDi.Size = new System.Drawing.Size(54, 17);
            this.lblNgayDi.TabIndex = 3;
            this.lblNgayDi.Text = "Ngay di";
            // 
            // lblNgayVe
            // 
            this.lblNgayVe.AutoSize = true;
            this.lblNgayVe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayVe.Location = new System.Drawing.Point(30, 85);
            this.lblNgayVe.Name = "lblNgayVe";
            this.lblNgayVe.Size = new System.Drawing.Size(58, 17);
            this.lblNgayVe.TabIndex = 4;
            this.lblNgayVe.Text = "Ngay ve";
            // 
            // dtPickerNgayDi
            // 
            this.dtPickerNgayDi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerNgayDi.Location = new System.Drawing.Point(127, 40);
            this.dtPickerNgayDi.Name = "dtPickerNgayDi";
            this.dtPickerNgayDi.Size = new System.Drawing.Size(284, 25);
            this.dtPickerNgayDi.TabIndex = 5;
            this.dtPickerNgayDi.ValueChanged += new System.EventHandler(this.dtPickerNgayDi_ValueChanged);
            // 
            // dtPickerNgayVe
            // 
            this.dtPickerNgayVe.Checked = false;
            this.dtPickerNgayVe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerNgayVe.Location = new System.Drawing.Point(127, 80);
            this.dtPickerNgayVe.Name = "dtPickerNgayVe";
            this.dtPickerNgayVe.Size = new System.Drawing.Size(284, 25);
            this.dtPickerNgayVe.TabIndex = 6;
            this.dtPickerNgayVe.ValueChanged += new System.EventHandler(this.dtPickerNgayVe_ValueChanged);
            // 
            // lblSoNguoi
            // 
            this.lblSoNguoi.AutoSize = true;
            this.lblSoNguoi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNguoi.Location = new System.Drawing.Point(30, 121);
            this.lblSoNguoi.Name = "lblSoNguoi";
            this.lblSoNguoi.Size = new System.Drawing.Size(58, 17);
            this.lblSoNguoi.TabIndex = 7;
            this.lblSoNguoi.Text = "So nguoi";
            // 
            // btnTang
            // 
            this.btnTang.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTang.Location = new System.Drawing.Point(302, 112);
            this.btnTang.Name = "btnTang";
            this.btnTang.Size = new System.Drawing.Size(109, 27);
            this.btnTang.TabIndex = 8;
            this.btnTang.Text = "+";
            this.btnTang.UseVisualStyleBackColor = true;
            this.btnTang.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnGiam
            // 
            this.btnGiam.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiam.Location = new System.Drawing.Point(125, 112);
            this.btnGiam.Name = "btnGiam";
            this.btnGiam.Size = new System.Drawing.Size(109, 27);
            this.btnGiam.TabIndex = 9;
            this.btnGiam.Text = "-";
            this.btnGiam.UseVisualStyleBackColor = true;
            this.btnGiam.Click += new System.EventHandler(this.btnGiam_Click);
            // 
            // lblSNguoi
            // 
            this.lblSNguoi.AutoSize = true;
            this.lblSNguoi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSNguoi.Location = new System.Drawing.Point(263, 117);
            this.lblSNguoi.Name = "lblSNguoi";
            this.lblSNguoi.Size = new System.Drawing.Size(15, 17);
            this.lblSNguoi.TabIndex = 10;
            this.lblSNguoi.Text = "1";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(24, 189);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(387, 29);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // trackBar
            // 
            this.trackBar.LargeChange = 10;
            this.trackBar.Location = new System.Drawing.Point(202, 145);
            this.trackBar.Maximum = 200;
            this.trackBar.Minimum = 1;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(209, 45);
            this.trackBar.SmallChange = 5;
            this.trackBar.TabIndex = 12;
            this.trackBar.TabStop = false;
            this.trackBar.TickFrequency = 5;
            this.trackBar.Value = 200;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = true;
            this.lblGiaTien.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTien.Location = new System.Drawing.Point(30, 155);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(53, 17);
            this.lblGiaTien.TabIndex = 13;
            this.lblGiaTien.Text = "Gia tien";
            // 
            // lblTrackBar
            // 
            this.lblTrackBar.AutoSize = true;
            this.lblTrackBar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackBar.Location = new System.Drawing.Point(124, 155);
            this.lblTrackBar.Name = "lblTrackBar";
            this.lblTrackBar.Size = new System.Drawing.Size(80, 17);
            this.lblTrackBar.TabIndex = 14;
            this.lblTrackBar.Text = "20.000.000đ";
            // 
            // Terminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTrackBar);
            this.Controls.Add(this.lblGiaTien);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblSNguoi);
            this.Controls.Add(this.btnGiam);
            this.Controls.Add(this.btnTang);
            this.Controls.Add(this.lblSoNguoi);
            this.Controls.Add(this.dtPickerNgayVe);
            this.Controls.Add(this.dtPickerNgayDi);
            this.Controls.Add(this.lblNgayVe);
            this.Controls.Add(this.lblNgayDi);
            this.Controls.Add(this.cBoxDiaDiem);
            this.Controls.Add(this.lblDiaDiem);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Terminal";
            this.Size = new System.Drawing.Size(450, 229);
            this.Load += new System.EventHandler(this.Terminal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiaDiem;
        private System.Windows.Forms.ComboBox cBoxDiaDiem;
        private System.Windows.Forms.Label lblNgayDi;
        private System.Windows.Forms.Label lblNgayVe;
        private System.Windows.Forms.DateTimePicker dtPickerNgayDi;
        private System.Windows.Forms.DateTimePicker dtPickerNgayVe;
        private System.Windows.Forms.Label lblSoNguoi;
        private System.Windows.Forms.Button btnTang;
        private System.Windows.Forms.Button btnGiam;
        private System.Windows.Forms.Label lblSNguoi;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label lblGiaTien;
        private System.Windows.Forms.Label lblTrackBar;

        /// <summary>
        /// Value from UC Terminal
        /// </summary>
        //Dia diem
        public System.Windows.Forms.Label LblDiaDiem { get { return lblDiaDiem; } }
        public System.Windows.Forms.ComboBox CBoxDiaDiem { get { return cBoxDiaDiem;} }

        ///Ngay di va ngay ve
        public System.Windows.Forms.Label LblNgayDi {  get { return lblNgayDi; } }
        public System.Windows.Forms.DateTimePicker DtPickerNgayDi { get { return dtPickerNgayDi; } }
        public System.Windows.Forms.Label LblNgayVe { get { return lblNgayVe; } }
        public System.Windows.Forms.DateTimePicker DtPickerNgayVe { get { return dtPickerNgayVe; } }

        //So nguoi
        public System.Windows.Forms.Label LblSoNguoi { get { return lblSoNguoi; } }
        public System.Windows.Forms.Button BtnAdd {  get { return btnTang; } }
        public System.Windows.Forms.Button BtnMinus { get { return btnGiam; } }
        public System.Windows.Forms.Label LblValue { get { return lblSNguoi; } }

        //Gia tien
        public System.Windows.Forms.TrackBar TrackBar {  get { return trackBar; } }
        public System.Windows.Forms.Label LblGiaTien { get { return lblGiaTien; } }
        public System.Windows.Forms.Label LblTrackBar { get { return lblTrackBar; } set { lblTrackBar = value; } }

        //Submit
        public System.Windows.Forms.Button BtnSubmit { get { return btnSubmit; } }
    }
}
