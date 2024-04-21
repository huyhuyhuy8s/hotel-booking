using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console
{
    public partial class FShowRoom : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.conn);
        string hotelId;
        public FShowRoom()
        {
            InitializeComponent();
        }

        public void InsertData(string hotelId)
        {
            this.hotelId = hotelId;
            ShowRoom_Load();
        }

        private void ShowRoom_Load()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = String.Format("SELECT *, COUNT(1) OVER () FROM (Hotel " +
                "JOIN Province ON Hotel.HotelProvince = Province.Name) " +
                "RIGHT JOIN (Room " +
                "JOIN TypeRoom ON Room.TypeId = TypeRoom.TypeId) " +
                "ON HotelId = (RoomId / POWER (10, DATALENGTH (CAST (RoomNo AS VARCHAR(MAX))))) " +
                "WHERE HotelId = {0}", hotelId);
            SqlDataReader reader = cmd.ExecuteReader();

            bool hotelCheck = false;
            int count = 0;
            UCShowroom[] ucshowrooms = new UCShowroom[0];
            while (reader.Read())
            {
                //Hotel Properties
                if (!hotelCheck)
                {
                    lblName.Text = reader.GetString(1);
                    lblAddress.Text = reader.GetString(2);
                    lblDescription.Text = reader.GetString(4);
                    byte[] pic = (byte[])reader.GetValue(6);
                    using (var stream = new MemoryStream(pic))
                    {
                        pbPicture.Image = System.Drawing.Image.FromStream(stream);
                    }
                    string province = reader.GetString(3);
                    ucshowrooms = new UCShowroom[Int32.Parse(reader.GetValue(41).ToString())];
                    List<Label> labels = new List<Label> { lblLocation1, lblLocation2, lblLocation3, lblLocation4, lblLocation5, lblLocation6 };
                    for (int i = 0; i < 6; i++) 
                    {
                        labels[i].Text = reader.GetString(10 + i);
                    }
                    hotelCheck = true;
                }

                // x Room Properties
                UCShowroom sr = ucshowrooms[count] = new UCShowroom();
                sr.LblHotelId = reader.GetValue(16).ToString(); //Room ID
                sr.LblHotelName = (++count).ToString();
                byte[] roompic = (byte[])reader.GetValue(24);
                using (var stream = new MemoryStream(roompic))
                {
                    sr.PbRoomPic = System.Drawing.Image.FromStream(stream);
                }
                sr.LblRoomName = reader.GetString(18);
                sr.LblRoomBed = reader.GetValue(20).ToString();
                sr.LblRoomPerson = reader.GetValue(21).ToString();

                // Room Interiors 
                int interior_index = 0;
                for (int i = 13; i >= 0 && interior_index < 6; i--)
                {
                    if (!reader.GetBoolean(27 + i))
                    switch (interior_index)
                    {
                        case 0:
                            sr.LblInterior1 = CodeEdit.InteriorCheck(i);
                            sr.PBInterior1.Image = CodeEdit.InteriorPicture(i);
                            interior_index++;
                            break;
                        case 1:
                            sr.LblInterior2 = CodeEdit.InteriorCheck(i);
                            sr.PBInterior2.Image = CodeEdit.InteriorPicture(i);
                            interior_index++;
                            break;
                        case 2:
                            sr.LblInterior3 = CodeEdit.InteriorCheck(i);
                            sr.PBInterior3.Image = CodeEdit.InteriorPicture(i);
                            interior_index++;
                            break;
                        case 3:
                            sr.LblInterior4 = CodeEdit.InteriorCheck(i);
                            sr.PBInterior4.Image = CodeEdit.InteriorPicture(i);
                            interior_index++;
                            break;
                        case 4:
                            sr.LblInterior5 = CodeEdit.InteriorCheck(i);
                            sr.PBInterior5.Image = CodeEdit.InteriorPicture(i);
                            interior_index++;
                            break;
                        case 5:
                            sr.LblInterior6 = CodeEdit.InteriorCheck(i);
                            sr.PBInterior6.Image = CodeEdit.InteriorPicture(i);
                            interior_index++;
                            break;
                    }
                }
                sr.LblRoomPrice = reader.GetValue(22).ToString();
                if (sr.LblRoomName != null) flowPanel.Controls.Add(sr);
            }
            reader.Close();
            connection.Close();
        }

        #region GET & SET
        public Label Location1
        {
            get { return lblLocation1; }
            set { lblLocation1 = value; }
        }
        public Label Location2
        {
            get { return lblLocation2; }
            set { lblLocation2 = value; }
        }
        public Label Location3
        {
            get { return lblLocation3; }
            set { lblLocation3 = value; }
        }
        public Label Location4
        {
            get { return lblLocation4; }
            set { lblLocation4 = value; }
        }
        public Label Location5
        {
            get { return lblLocation5; }
            set { lblLocation5 = value; }
        }
        public Label Location6
        {
            get { return lblLocation6; }
            set { lblLocation6 = value; }
        }
        public FlowLayoutPanel FlowPanel
        {
            get { return flowPanel; }
            set { flowPanel = value; }
        }
        public Guna2Button Return
        {
            get { return btnReturn; }
            set {  btnReturn = value; }
        }
        #endregion
    }
}
