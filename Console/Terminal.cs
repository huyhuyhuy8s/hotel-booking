using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console
{
    public partial class Terminal : UserControl
    {
        int giatien = 200;
        DateTime today = DateTime.Now;
        public Terminal()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Terminal_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //System.Console.WriteLine(trackBar.Value);
            int giaphong = trackBar.Value;
            if (giaphong >= 10) LblTrackBar.Text = (giaphong/10).ToString() + ".000.000d";
            else LblTrackBar.Text = giaphong.ToString() + "00.000d";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(lblSNguoi.Text) == 20) return;
            lblSNguoi.Text = (Int32.Parse(lblSNguoi.Text) + 1).ToString();
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(lblSNguoi.Text) == 1) return;
            lblSNguoi.Text = (Int32.Parse(lblSNguoi.Text) - 1).ToString();
        }

        private void dtPickerNgayVe_ValueChanged(object sender, EventArgs e)
        {
            if (dtPickerNgayDi.Value > dtPickerNgayVe.Value || dtPickerNgayVe.Value < today) return;
        }

        private void dtPickerNgayDi_ValueChanged(object sender, EventArgs e)
        {
            if (dtPickerNgayDi.Value < today) return;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
        }
    }
}
