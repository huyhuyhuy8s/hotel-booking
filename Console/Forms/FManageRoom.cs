using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console
{
    public partial class FManageRoom : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.conn);
        public FManageRoom()
        {
            InitializeComponent();
        }

        private void ManageBooking_Click(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            UCManageRoom uc = btn.Parent.Parent.Parent as UCManageRoom;
            FOrder foder = new FOrder(Int32.Parse(uc.Order.Text));
            if (foder.FOrder_Open()) Panel_Load();
        }

        private void FUserManage_Load(object sender, EventArgs e)
        {
            Panel_Load();
        }

        public void Panel_Load()
        {
            connection.Open();
            flowPanel.Controls.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = String.Format("SELECT * FROM (Person " +
                "RIGHT JOIN (PersonOrder " +
                "JOIN Room ON PersonOrder.RoomId = Room.RoomId) " +
                "JOIN Hotel ON HotelId = (Room.RoomId / POWER (10, DATALENGTH (CAST (RoomNo AS VARCHAR(MAX))))) " +
                "ON Person.PersonId = PersonOrder.PersonId) " +
                "WHERE Person.PersonId = {0};", CodeEdit.id);
            SqlDataReader reader = cmd.ExecuteReader();
            bool user_check = false;
            while (reader.Read())
            {
                if (!user_check)
                {
                    txtUserName.Text = reader.GetString(1);
                    txtPhoneNum.Text = reader.GetString(2);
                    txtEmail.Text = reader.GetString(3);
                    txtPassword.Text = reader.GetString(4);
                    dtDOB.Value = reader.GetDateTime(5);
                    user_check = true;
                }

                DateTime end = reader.GetDateTime(11).Date;
                bool status = reader.GetBoolean(12);
                DateTime now = DateTime.Now.Date;
                //if (!btnBooked.Enabled && DateTime.Now.Date > end.Date || btnBooked.Enabled && DateTime.Now.Date <= end.Date
                if (!btnBooked.Enabled && (now > end && !status || now > end && status || now <= end && !status) || btnBooked.Enabled && now <= end && status)
                {
                    UCManageRoom uc = new UCManageRoom();
                    uc.Order.Text = reader.GetValue(7).ToString();
                    uc.Province.Text = reader.GetString(27);
                    uc.CheckDate.Text = end.ToLongDateString();
                    uc.HotelName.Text = reader.GetString(25);
                    uc.RoomName.Text = reader.GetString(17);
                    if (!reader.IsDBNull(23))
                    {
                        byte[] roompic = (byte[])reader.GetValue(23);
                        using (var stream = new MemoryStream(roompic))
                        {
                            uc.PBPictureBox.Image = System.Drawing.Image.FromStream(stream);
                        }
                    }

                    //Status updating
                    if (!btnBooked.Enabled) //Check if in Booked option
                    {
                        if (now <= end && !status || !reader.IsDBNull(13)) uc.Status.Text = "Cancelled"; //Case day isn't passed but status is cancelled
                        else //other case
                        {
                            if (now > end && status) //Case day is passed but the status isn't cancelled -> update status into booked (same as cancelled)
                            {
                                int order = (Int32)reader.GetValue(7);
                                connection.Close();
                                CodeEdit.SqlUpdate(string.Format("UPDATE PersonOrder SET OrderStatus = 0 WHERE OrderId = {0}", order));
                                Panel_Load();
                                return;
                            }
                            uc.Status.Text = "Booked"; //Both case are booked cuz in the pass
                        }
                    }
                    else uc.Status.Text = "Booking"; //Booking option have only 1 case so their status must be booking

                    uc.CheckIn.Text = reader.GetDateTime(10).ToLongDateString();
                    uc.CheckOut.Text = end.ToLongDateString();
                    uc.ManageBooking.Click += new EventHandler(ManageBooking_Click);
                    flowPanel.Controls.Add(uc);
                }
            }
            connection.Close();
        }

        #region GET & SET
        public Guna2Button Booked
        {
            get { return btnBooked; }
            set { btnBooked = value; }
        }
        public Guna2Button Booking
        {
            get { return btnBooking; }
            set { btnBooking = value; }
        }
        public Guna2Button Return
        {
            get { return btnReturn; }
            set { btnReturn = value; }
        }
        #endregion

        private void btnBooked_Click(object sender, EventArgs e)
        {
            btnBooked.Enabled = false;
            btnBooking.Enabled = true;
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            btnBooked.Enabled = true;
            btnBooking.Enabled = false;
        }

        private void btSaveInfor_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = string.Format("UPDATE Person SET PersonName = '{0}', PersonEmail = '{1}', PersonPhonenumber = '{2}', PersonPassword = '{3}', PersonDOB = '{4}' WHERE PersonId = {5}", txtUserName.Text, txtEmail.Text, txtPhoneNum.Text, txtPassword.Text, dtDOB.Value.ToShortDateString(), CodeEdit.id);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Update Successed!");
                }
                else
                {
                    MessageBox.Show("Nothing was updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("False\n" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}