using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;
using System.Xml.Linq;
using Guna.UI2.WinForms;

namespace Console
{
    public partial class FOrderReason : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.conn);
        int? orderid;
        bool check = false;
        string cmd;
        public FOrderReason()
        {
            InitializeComponent();
        }
        public FOrderReason(int orderid)
        {
            this.orderid = orderid;
            InitializeComponent();
        }

        public bool FOrderReason_Open(string cmd)
        {
            this.cmd = cmd;
            this.ShowDialog();
            return check;
        }

        #region GET && SET
        public Guna2RadioButton Reason1
        {
            get { return rdReason1; }
            set { rdReason1 = value; }
        }
        public Guna2RadioButton Reason2
        {
            get { return rdReason2; }
            set { rdReason2 = value; }
        }
        public Guna2RadioButton Reason3
        {
            get { return rdReason3; }
            set { rdReason3 = value; }
        }
        public Guna2RadioButton Reason4
        {
            get { return rdReason4; }
            set { rdReason4 = value; }
        }
        public Guna2RadioButton Reason5
        {
            get { return rdReason5; }
            set { rdReason5 = value; }
        }
        public Guna2RadioButton Reason6
        {
            get { return rdReason6; }
            set { rdReason6 = value; }
        }
        public Guna2Button Submit
        {
            get { return btnSubmit; }
            set { btnSubmit = value; }
        }
        public Guna2TextBox ReasonBox
        {
            get { return txtReason; }
            set { txtReason = value; }
        }
        #endregion

        #region DRAG && CLOSE
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void guna2Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Reason1.Checked || Reason2.Checked || Reason3.Checked || Reason4.Checked || Reason5.Checked || (Reason6.Checked && ReasonBox.Text != ""))
            {
                try
                {
                    // Ket noi
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = string.Format(this.cmd);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Cancelled");
                        check = true;
                    }
                    else
                    {
                        MessageBox.Show("Something goes wrong");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to cancel\n" + ex);
                }
                finally
                {
                    connection.Close();
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Please choose a reason!");
            }
        }
    }
}
