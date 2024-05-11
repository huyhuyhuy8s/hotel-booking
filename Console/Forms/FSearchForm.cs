using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Console
{
    public partial class FSearchForm : Form
    {
        SearchFunction fc = new SearchFunction();
        string outsideCommand;
        string originCommand;
        string typeCommand = "";
        string starCommand = "";

        public FSearchForm()
        {
            InitializeComponent();
            Control();
        }

        private void ShowHotel_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            UCShowHotel2 ucshowhotel = (UCShowHotel2)btn.Parent.Parent;
            FDisplayForm fdisplayForm = this.Parent.Parent as FDisplayForm;
            fdisplayForm.ShowRoom_Load(ucshowhotel.LblHotelId, Terminal.CBProvince.SelectedItem.ToString(), Terminal.DTCheckIn.Value, Terminal.DTCheckOut.Value);
        }

        public void InsertData(string location, DateTime checkin, DateTime checkout)
        {
            ucTerminal.CBProvince.SelectedItem = location;
            ucTerminal.DTCheckIn.Value = checkin;
            ucTerminal.DTCheckOut.Value = checkout;
            string stringHotel = string.Format("");
            SqlDataReader reader = CodeEdit.SqlRead(string.Format("SELECT HotelId FROM Hotel WHERE HotelProvince = '{0}'", location));
            bool stringHotelCheck = false;
            while (reader.Read())
            {
                if (!stringHotelCheck)
                {
                    stringHotelCheck = true;
                    stringHotel += "WHERE HotelId = " + reader.GetInt32(0).ToString();
                }
                else
                {
                    stringHotel += " OR HotelId = " + reader.GetInt32(0).ToString();
                }
            }
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.conn);
            connection.Close();

            string query = String.Format("SELECT Hotel.HotelId, HotelName, HotelImage, HotelAddress, HotelHotline, HotelDescription, HotelStar, " +
                "(SELECT MIN(RoomPrice) FROM Room WHERE Hotel.HotelId = (RoomId / POWER (10, DATALENGTH (CAST (RoomNo AS VARCHAR(MAX)))))) AS Mini, " +
                "COUNT(1) OVER () AS Id, HotelType , t3.HotelId " +
                "FROM Hotel JOIN (" +
                    "SELECT DISTINCT HotelId FROM (" +
                        "SELECT PersonOrder.OrderId, PersonOrder.OrderEnd, PersonOrder.OrderStart, Room.RoomNo, t1.RoomId, Hotel.HotelId " +
                        "FROM Room " +
                            "LEFT JOIN PersonOrder ON Room.RoomId = PersonOrder.RoomId " +
                            "JOIN Hotel ON Hotel.HotelId = (Room.RoomId / POWER (10, DATALENGTH (CAST (RoomNo AS VARCHAR(MAX))))) " +
                            "JOIN (" +
                                "SELECT DISTINCT Room.RoomId, OrderEnd, OrderStart " +
                                "FROM Room " +
                                    "LEFT JOIN PersonOrder ON Room.RoomId = PersonOrder.RoomId " +
                                "WHERE Room.RoomId IN " +
                                    "(SELECT RoomId FROM Room JOIN Hotel ON HotelId = (RoomId / POWER (10, DATALENGTH (CAST (RoomNo AS VARCHAR(MAX))))) {1}) " +
                                    "AND ( NOT (OrderEnd > '{3}' AND OrderStart < '{4}' AND OrderStatus = 1) OR OrderEnd IS NULL)" +
                        ") as t1 ON Room.RoomId = t1.RoomId " +
                    "WHERE Room.RoomId IN " +
                        "(SELECT RoomId FROM Room JOIN Hotel ON HotelId = (RoomId / POWER (10, DATALENGTH (CAST (RoomNo AS VARCHAR(MAX))))) " +
                        "{2})" +
                    ") AS t2 " +
                    "WHERE RoomId IS NOT NULL" +
                ") as t3 ON Hotel.HotelId = t3.HotelId WHERE Hotel.HotelProvince = '{0}'", location, stringHotel, stringHotel, checkin.ToString("yyyy/MM/dd"), checkout.ToString("yyyy/MM/dd")) ;

            originCommand = outsideCommand = query;
        }

        public void Control()
        {
            flowPanel.Controls.Clear();
            string query = (outsideCommand == null) ? "SELECT HotelId, HotelName, HotelImage, HotelAddress, HotelHotline, HotelDescription, HotelStar, (SELECT MIN(RoomPrice) FROM Room WHERE HotelId = (RoomId / POWER (10, DATALENGTH (CAST (RoomNo AS VARCHAR(MAX)))))) AS Mini, COUNT(1) OVER () AS Id, HotelType FROM Hotel" : outsideCommand;
            query += typeCommand + starCommand;
            if (outsideCommand == null) originCommand = query;
            DataSet dt = fc.GetData(query);

            SqlDataReader reader = fc.getForCombo(query);

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader tempReader = command.ExecuteReader();
            if (tempReader.Read())
            {
                int numberOfHotel = Int32.Parse(tempReader["Id"].ToString());
                conn.Close();

                UCShowHotel2[] uc = new UCShowHotel2[numberOfHotel];


                System.Drawing.Image[] pbroompic = new System.Drawing.Image[numberOfHotel];
                string[] HotelId = new string[numberOfHotel];
                string[] HotelName = new string[numberOfHotel];
                string[] HotelAddress = new string[numberOfHotel];
                string[] HotelHotline = new string[numberOfHotel];
                string[] HotelDescription = new string[numberOfHotel];
                string[] HotelStar = new string[numberOfHotel];
                string[] HotelPrice = new string[numberOfHotel];
                string[] HotelType = new string[numberOfHotel];

                int index = 0;
                while (reader.Read() && index < HotelName.Length)
                {
                    if (!reader.IsDBNull(reader.GetOrdinal("HotelImage")))
                    {
                        byte[] pic = (byte[])reader["HotelImage"];
                        using (var stream = new MemoryStream(pic))
                        {
                            pbroompic[index] = System.Drawing.Image.FromStream(stream);
                        }
                    }

                    HotelId[index] = reader["HotelId"].ToString();
                    HotelName[index] = reader["HotelName"].ToString();
                    HotelAddress[index] = reader["HotelAddress"].ToString();
                    HotelHotline[index] = reader["HotelHotline"].ToString();
                    HotelDescription[index] = reader["HotelDescription"].ToString();
                    HotelStar[index] = reader["HotelStar"].ToString() + " stars ";
                    HotelType[index] = reader["HotelType"].ToString();
                    if (!reader.IsDBNull(7)) HotelPrice[index] = reader["Mini"].ToString();
                    else HotelPrice[index] = "";
                    index++;
                }

                for (int i = 0; i < uc.Length; i++)
                {

                    uc[i] = new UCShowHotel2();
                    uc[i].LblHotelId = HotelId[i];
                    uc[i].LblHotelName = HotelName[i];
                    uc[i].PbRoomPic = pbroompic[i];
                    uc[i].LblHotelAddress = HotelAddress[i];
                    uc[i].LblHotelHotline = HotelHotline[i];
                    uc[i].LblHotelDescription = HotelDescription[i];
                    uc[i].LblHotelStar.Text = HotelStar[i];
                    uc[i].LblType.Text = CodeEdit.TypeHotel(Int32.Parse(HotelType[i]));
                    if (HotelPrice[i] == "")
                    {
                        uc[i].LblHotelPrice.Visible = false;
                        uc[i].LblOnly.Visible = false;
                    }
                    else uc[i].LblHotelPrice.Text = HotelPrice[i] + "000 VND";
                    //Add click button event to the Show Hotel Button
                    uc[i].ShowHotel.Click += new EventHandler(ShowHotel_Click);


                    flowPanel.Controls.Add(uc[i]);
                }
                reader.Close();
            }
            else
            {
                conn.Close();
                reader.Close();
            }
        }

        #region Login SignUp
        public void CreateSignIn()
        {
            btnSignIn.Text = "Sign In";
            CodeEdit.RemoveEvent(btnSignIn);
            btnSignIn.Click += new EventHandler(btnLogin_Click);

            btnSignUp.Text = "Sign Up";
            CodeEdit.RemoveEvent(btnSignUp);
            btnSignUp.Click += new EventHandler(btnSignUp_Click);
            btnSignUp.FillColor = System.Drawing.Color.White;
            btnSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(104)))), ((int)(((byte)(238)))));
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SignIn login = new SignIn();
            login.ShowDialog();
            if (CodeEdit.logged)
            {
                FDisplayForm dp = this.Parent.Parent as FDisplayForm; //danger
                dp.SearchForm_Load();
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.ShowDialog();
        }
        #endregion

        #region GET & SET
        public UCTerminal Terminal
        {
            get { return ucTerminal; }
            set { ucTerminal = value; }
        }
        public Guna2Button Return
        {
            get { return btnReturn; }
            set { btnReturn = value; }
        }
        public Guna2Button SignIn
        {
            get { return btnSignIn; } 
            set { btnSignIn = value; }
        }
        public Guna2Button SignUp
        {
            get { return btnSignUp; }
            set { btnSignUp = value; }
        }
        public FlowLayoutPanel FlowPanel
        {
            get { return flowPanel; }
            set {  flowPanel = value; }
        }
        #endregion

        #region Filters
        private void clearFilter(object sender, EventArgs e)
        {
            typeCommand = "";
            foreach (Control c in panelType.Controls)
                if (c is Guna2CheckBox && ((Guna2CheckBox)c).Checked) ((Guna2CheckBox)c).Checked = false;
            starCommand = "";
            foreach (Control c in panelStar.Controls)
                if (c is Guna2CheckBox && ((Guna2CheckBox)c).Checked) ((Guna2CheckBox)c).Checked = false;
            MessageBox.Show("Clear filters successed!");
        }
        private void checkType(object sender, EventArgs e)
        {
            string query = " AND (";
            bool firstCheck = true;
            foreach (Control c in panelType.Controls)
            {
                if (c is Guna2CheckBox && ((Guna2CheckBox)c).Checked)
                {
                    if (firstCheck) firstCheck = false;
                    else query += " OR";
                    switch (c.Text)
                    {
                        case "Hotel":
                            query += " HotelType = 1";
                            break;
                        case "Motel":
                            query += " HotelType = 2";
                            break;
                        case "Camping":
                            query += " HotelType = 3";
                            break;
                        case "B&B":
                            query += " HotelType = 4";
                            break;
                        case "Guest House":
                            query += " HotelType = 5";
                            break;
                        case "Homestay":
                            query += " HotelType = 6";
                            break;
                        case "Villa":
                            query += " HotelType = 7";
                            break;
                        case "Apartment":
                            query += " HotelType = 8";
                            break;
                    }
                }
            }
            query += ")";
            typeCommand = (firstCheck) ? "" : query;
            Control();
        }

        private void checkStar(object sender, EventArgs e)
        {
            string query = " AND (";
            bool firstCheck = true;
            foreach (Control c in panelStar.Controls)
            {
                if (c is Guna2CheckBox && ((Guna2CheckBox)c).Checked)
                {
                    if (firstCheck) firstCheck = false;
                    else query += " OR";
                    switch (c.Text)
                    {
                        case "1 star":
                            query += " HotelStar = 1";
                            break;
                        case "2 stars":
                            query += " HotelStar = 2";
                            break;
                        case "3 stars":
                            query += " HotelStar = 3";
                            break;
                        case "4 stars":
                            query += " HotelStar = 4";
                            break;
                        case "5 stars":
                            query += " HotelStar = 5";
                            break;
                    }
                }
            }
            query += ")";
            starCommand = (firstCheck) ? "" : query;
            Control();
        }
        #endregion
    }
}


