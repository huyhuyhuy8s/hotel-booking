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
        UCTerminal userTerminal = new UCTerminal();
        string hotelId;
        string queryCommand = "";
        string originCommand = "";
        string interiorCommand = "";
        string bedpersonCommand = "";
        readonly int _rightMargin6, _rightMargin5, _rightMargin4;

        public FShowRoom()
        {
            InitializeComponent();
            _rightMargin6 = lblLocation6.Parent.Width - lblLocation6.Right;
            _rightMargin5 = lblLocation5.Parent.Width - lblLocation5.Right;
            _rightMargin4 = lblLocation4.Parent.Width - lblLocation4.Right;
        }

        public void InsertData(string hotelId, string location, DateTime checkin, DateTime checkout)
        {
            this.hotelId = hotelId;
            userTerminal.CBProvince.SelectedItem = location;
            userTerminal.DTCheckIn.Value = checkin;
            userTerminal.DTCheckOut.Value = checkout;
            ShowHotel_Load();
        }

        #region Filter
        private void clearFilter(object sender, EventArgs e)
        {
            bedpersonCommand = "";
            //foreach (Control c in panelBedPerson.Controls)
            //{
            //    if (c.Name == "numPerson") { (c as Guna2NumericUpDown).Value = 2; }
            //    else if (c.Name == "numBed") { (c as Guna2NumericUpDown).Value = 1; }
            //}
            interiorCommand = "";
            foreach (Control c in panelInterior.Controls)
                if (c is Guna2CheckBox && ((Guna2CheckBox)c).Checked) ((Guna2CheckBox)c).Checked = false;
            ShowRoom_Load(0);
            MessageBox.Show("Clear filters successed!");
        }
        private void checkBedPerson(object sender, EventArgs e)
        {
            string query = " AND (";
            bool firstCheck = true;
            foreach (Control c in panelBedPerson.Controls)
            {
                if (c is Guna2NumericUpDown)
                {
                    if (firstCheck) firstCheck = false;
                    else query += " AND";
                    switch (c.Name)
                    {
                        case "numPerson":
                            query += string.Format(" RoomPerson = {0}", ((Guna2NumericUpDown)c).Value);
                            break;
                        case "numBed":
                            query += string.Format(" RoomBed = {0}", ((Guna2NumericUpDown)c).Value);
                            break;
                    }
                }
            }
            query += ")";
            bedpersonCommand = (firstCheck) ? "" : query;
            ShowRoom_Load(0);
        }
        private void checkInterior(object sender, EventArgs e)
        {
            string query = " AND (";
            bool firstCheck = true;
            foreach (Control c in panelInterior.Controls)
            {
                if (c is Guna2CheckBox && ((Guna2CheckBox)c).Checked)
                {
                    if (firstCheck) firstCheck = false;
                    else query += " AND";
                    switch (c.Text)
                    {
                        case "Air Conditioner":
                            query += " AC = 1";
                            break;
                        case "Hairdryer":
                            query += " Hairdryer = 1";
                            break;
                        case "Chair":
                            query += " Chair = 1";
                            break;
                        case "Desk":
                            query += " Desk = 1";
                            break;
                        case "Refrigerator":
                            query += " Refrigerator = 1";
                            break;
                        case "Balcony":
                            query += " Balcony = 1";
                            break;
                        case "Bathtub":
                            query += " Bathtub = 1";
                            break;
                        case "Minibar":
                            query += " Minibar = 1";
                            break;
                        case "Coffee Maker":
                            query += " CoffeeMaker = 1";
                            break;
                        case "Safety Box":
                            query += " SafetyBox = 1";
                            break;
                        case "Champage":
                            query += " Champage = 1";
                            break;
                        case "Kitchen":
                            query += " Kitchen = 1";
                            break;
                        case "Bidet":
                            query += " Bidet = 1";
                            break;
                        case "Throne":
                            query += " Throne = 1";
                            break;
                    }
                }
            }
            query += ")";
            interiorCommand = (firstCheck) ? "" : query;
            ShowRoom_Load(0);
        }
        #endregion

        private void ShowHotel_Load()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            ucTerminals.CBProvince.SelectedItem = userTerminal.CBProvince.SelectedItem;
            ucTerminals.DTCheckIn.Value = userTerminal.DTCheckIn.Value;
            ucTerminals.DTCheckOut.Value = userTerminal.DTCheckOut.Value;
            originCommand = "";
            ShowRoom_Load(1);
        }

        private void ShowRoom_Load(int a)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            if (originCommand == "") originCommand = String.Format("SELECT *, COUNT(1) OVER () " +
                "FROM (Hotel JOIN Province ON Hotel.HotelProvince = Province.Name) " +
                "RIGHT JOIN (Room JOIN TypeRoom ON Room.TypeId = TypeRoom.TypeId) " +
                "ON HotelId = (RoomId / POWER (10, DATALENGTH (CAST (RoomNo AS VARCHAR(MAX))))) " +
                "LEFT JOIN " +
                "(SELECT DISTINCT t1.RoomId " +
                "FROM " +
                "(SELECT RoomId FROM (Hotel " +
                "JOIN Province ON Hotel.HotelProvince = Province.Name) " +
                "RIGHT JOIN (Room " +
                "JOIN TypeRoom ON Room.TypeId = TypeRoom.TypeId) " +
                "ON HotelId = (RoomId / POWER (10, DATALENGTH (CAST (RoomNo AS VARCHAR(MAX))))) WHERE HotelId = {0}) as t1 " +
                "RIGHT JOIN PersonOrder ON t1.RoomId = PersonOrder.RoomId " +
                "WHERE (OrderEnd > '{1}' AND OrderStart < '{2}')) as t2 ON Room.RoomId = t2.RoomId " +
                "WHERE HotelId = {0}", hotelId, userTerminal.DTCheckIn.Value.ToString("yyyy/MM/dd"), userTerminal.DTCheckOut.Value.ToString("yyyy/MM/dd"));
            cmd.CommandText = originCommand + interiorCommand + bedpersonCommand;
            SqlDataReader reader = cmd.ExecuteReader();

            bool hotelCheck = false;
            int count = 0;
            UCShowroom[] ucshowrooms = new UCShowroom[0];
            flowPanel.Controls.Clear();
            while (reader.Read())
            {
                //Hotel Properties
                if (!hotelCheck)
                {
                    lblName.Text = reader.GetString(1);
                    lblAddress.Text = reader.GetString(2);
                    lblDescription.Text = reader.GetString(4);
                    lblDescription.TextAlign = ContentAlignment.MiddleCenter;

                    //Display picture
                    CodeEdit.displayPicture(reader, 6, pbPicture);
                    CodeEdit.displayPicture(reader, 7, pbPicture2);
                    CodeEdit.displayPicture(reader, 8, pbPicture3);
                    CodeEdit.displayPicture(reader, 9, pbPicture4);
                    CodeEdit.displayPicture(reader, 10, pbPicture5);

                    string province = reader.GetString(3);
                    ucshowrooms = new UCShowroom[reader.GetInt32(48)];
                    List<Label> labels = new List<Label> { lblLocation1, lblLocation2, lblLocation3, lblLocation4, lblLocation5, lblLocation6 };
                    for (int i = 0; i < 6; i++)
                    {
                        labels[i].Text = reader.GetString(15 + i);
                    }
                    hotelCheck = true;
                }

                // x Room Properties
                UCShowroom sr = ucshowrooms[count] = new UCShowroom();
                sr.LblHotelId = reader.GetValue(22).ToString(); //Room ID
                ++count;
                sr.LblHotelName = reader.GetString(24);
                byte[] roompic;
                if (!(reader.GetValue(30) is DBNull))
                {
                    roompic = (byte[])reader.GetValue(30);
                    using (var stream = new MemoryStream(roompic))
                    {
                        sr.PbRoomPic = System.Drawing.Image.FromStream(stream);
                    }
                }
                sr.LblRoomName = reader.GetString(24);
                sr.LblRoomBed = reader.GetValue(26).ToString();
                sr.LblRoomPerson = reader.GetValue(27).ToString();

                // Room Interiors 
                int interior_index = 0;
                for (int i = 13; i >= 0 && interior_index < 6; i--)
                {
                    if (reader.GetBoolean(33 + i))
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
                sr.LblRoomPrice = reader.GetValue(28).ToString() + "000 VND";
                if (!reader.IsDBNull(47)) sr.ShowHotel.Enabled = false;
                if (sr.LblRoomName != null) flowPanel.Controls.Add(sr);
            }
            reader.Close();
            connection.Close();
            if (a == 0)
            {
                Panel panelShow = this.Parent as Panel;
                FDisplayForm df = panelShow.Parent as FDisplayForm;
                df.ShowRoom_Inserted();
            }
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
        public UCTerminal Terminal
        {
            get { return ucTerminals; }
            set { ucTerminals = value; }
        }
        public FlowLayoutPanel FlowPanel
        {
            get { return flowPanel; }
            set { flowPanel = value; }
        }
        public Guna2Button Back
        {
            get { return btnBack; }
            set { btnBack = value; }
        }
        public Guna2Button Return
        {
            get { return btnReturn; }
            set { btnReturn = value; }
        }
        #endregion

        #region SizeChanged
        private void lblLocation6_SizeChanged(object sender, EventArgs e)
        {
            lblLocation6.Location = new Point(lblLocation6.Parent.Width - _rightMargin6 - lblLocation6.Width, lblLocation6.Top);
        }
        private void lblLocation5_SizeChanged(object sender, EventArgs e)
        {
            lblLocation5.Location = new Point(lblLocation5.Parent.Width - _rightMargin5 - lblLocation5.Width, lblLocation5.Top);
        }
        private void lblLocation4_SizeChanged(object sender, EventArgs e)
        {
            lblLocation4.Location = new Point(lblLocation4.Parent.Width - _rightMargin4 - lblLocation4.Width, lblLocation4.Top);
        }
        #endregion
    }
}