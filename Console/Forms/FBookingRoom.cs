using Console.Model;
using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Console
{
    public partial class FBookingRoom : Form
    {
        SearchFunction fc = new SearchFunction();
        int roomid = 412;

        int? personid = CodeEdit.id;
        DateTime start = CodeEdit.start;
        DateTime end = CodeEdit.end;

        public FBookingRoom()
        {
            InitializeComponent();
            GetData();
            //this.btBookNow_ += new EventHandler(btBookNow_Click);
        }

        public void InsertData(int roomid)
        {
            this.roomid = roomid;
        }

        private void FRequestBooking_Load(object sender, EventArgs e)
        {
            if (personid != null)
            {
                string query = string.Format("SELECT PersonName, PersonEmail, PersonNumberphone" +
                    " FROM Person WHERE PersonId = {0}", personid);
                DataSet dt = fc.GetData(query);

                if (dt.Tables[0].Rows.Count > 0)
                {
                    DataRow row = dt.Tables[0].Rows[0];
                    txtName.Text = row["PersonName"].ToString();
                    txtEmail.Text = row["PersonEmail"].ToString();
                    txtPhone.Text = row["PersonNumberphone"].ToString();
                }
            }
        }

        private void GetData()
        {
            string sqlStr = string.Format("SELECT Room.RoomId, Room.RoomPrice, Room.RoomName, hotel.HotelName, hotel.HotelAddress " +
                "FROM (Room " +
                "JOIN hotel ON HotelId = (RoomId / POWER (10, DATALENGTH (CAST (RoomNo AS VARCHAR(MAX)))))) " +
                "WHERE Room.RoomId = {0}", roomid);
            DataSet dt = fc.GetData(sqlStr);

            //SqlDataReader reader = fc.getForCombo(query);
            if (dt.Tables[0].Rows.Count > 0)
            {
                DataRow row = dt.Tables[0].Rows[0];
                roomid = int.Parse(row["RoomId"].ToString());
                lblHotelName.Text = row["HotelName"].ToString();
                lblAddress.Text = row["HotelAddress"].ToString();
                lblRType.Text = row["RoomName"].ToString();
                lblCInDay.Text = start.ToShortDateString();
                lblCOutDay.Text = end.ToShortDateString();
                lblRoomPrice.Text = row["RoomPrice"].ToString();
                lblRoomType.Text = row["RoomName"].ToString();
            }
        }

        private void btBookNow_Click(object sender, EventArgs e)
        {
            bool booked = false;
            if (!booked && txtName.Text != "" && txtEmail.Text != "" && txtPhone.Text != "")
            {
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.conn);
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = string.Format("INSERT INTO Person (PersonName, PersonPhoneNumber, PersonEmail) VALUES ('{0}', '{1}', '{2}'); SELECT PersonId FROM Person WHERE PersonName = '{3}' AND PersonPhonenumber = '{4}' AND PersonEmail = '{5}'", txtName.Text, txtPhone.Text, txtEmail.Text, txtName.Text, txtPhone.Text, txtEmail.Text);
                personid = int.Parse(cmd.ExecuteScalar().ToString());
                connection.Close();


                string sqlStr = string.Format("INSERT INTO PersonOrder(PersonId, RoomId, OrderStart, OrderEnd) VALUES ({0}, {1}, '{2}', '{3}')", personid, roomid, start.ToShortDateString(), end.ToShortDateString());
                fc.setData(sqlStr, "Da Them Phong");
            }

        }
        #region GET & SET
        public Guna2Button BTNReturn
        {
            get { return btnReturn; }
            set { btnReturn = value; }
        }
        #endregion
    }
}


       
    


