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

namespace Console
{
    public partial class FOrder : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.conn);
        int? orderid;
        bool check = false;
        public FOrder()
        {
            InitializeComponent();
        }
        public FOrder(int orderid)
        {
            this.orderid = orderid;
            InitializeComponent();
        }

        public bool FOrder_Open()
        {
            this.ShowDialog();
            return check;
        }

        private void FOrder_Load(object sender, EventArgs e)
        {
            if (orderid != null)
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = string.Format("SELECT * FROM PersonOrder WHERE OrderId = {0}", orderid);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtPersonId.Text = reader.GetValue(1).ToString();
                    txtRoomId.Text = reader.GetValue(2).ToString();
                    dtCheckIn.Value = reader.GetDateTime(3);
                    dtCheckOut.Value = reader.GetDateTime(4);
                }
                connection.Close();
            }
            else MessageBox.Show("No value to show");
        }

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPersonId.Text == "" || txtRoomId.Text == "" && dtCheckIn.Value.Date <= dtCheckOut.Value.Date) return;
                // Ket noi
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = string.Format("UPDATE PersonOrder SET OrderStart = '{0}', OrderEnd = '{1}' WHERE OrderId = {2}", dtCheckIn.Value.Date.ToString(), dtCheckOut.Value.Date.ToString(), orderid);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Update successed");
                    check = true;
                }
                else
                {
                    MessageBox.Show("Something goes wrong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update\n" + ex);
            }
            finally
            {
                connection.Close();
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                // Ket noi
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = string.Format("UPDATE PersonOrder SET OrderStatus = {0} WHERE OrderId = {1}", 0, orderid);

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
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
