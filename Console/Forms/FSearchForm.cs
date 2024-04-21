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

        public FSearchForm()
        {
            InitializeComponent();
            Control();
        }

        private void ShowHotel_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            UCShowroom ucshowroom = (UCShowroom)btn.Parent.Parent;
            FDisplayForm fdisplayForm = this.Parent.Parent as FDisplayForm;
            fdisplayForm.ShowRoom_Load(ucshowroom.LblHotelId);
        }

        public void InsertData(string location, DateTime checkin, DateTime checkout)
        {
            ucTerminal.CBProvince.SelectedItem = location;
            ucTerminal.DTCheckIn.Value = checkin;
            ucTerminal.DTCheckOut.Value = checkout;
            string query = String.Format("SELECT HotelId, RoomPrice, HotelName, RoomPicture, RoomName, RoomPerson, RoomBed, AC, Chair, Hairdryer, Desk, Refrigerator, Balcony, Bathtub, Champage, CoffeeMaker, Kitchen, SafetyBox, Minibar, Bidet, Throne " +
                "FROM ((Hotel " +
                "JOIN (Room JOIN TypeRoom ON Room.TypeId = TypeRoom.TypeId) ON Hotel.HotelId = (Room.RoomId / POWER (10, DATALENGTH (CAST (Room.RoomNo AS VARCHAR(MAX))))))" +
                "LEFT JOIN PersonOrder ON Room.RoomId = PersonOrder.RoomId)" +
                "WHERE Hotel.HotelProvince = '{0}' AND (OrderEnd < '{1}' OR OrderEnd IS NULL);", location, checkin.Date.ToString("MM/dd/yyyy"));

            outsideCommand = query;
        }

        public void Control()
        {
            int numberOfHotel = 6;
            flowPanel.Controls.Clear();
            UCShowroom[] uc = new UCShowroom[numberOfHotel];

            string query = (outsideCommand == null) ? "SELECT HotelId, RoomPrice, HotelName, RoomPicture, RoomName, RoomPerson, RoomBed, AC, Chair, Hairdryer, Desk, Refrigerator, Balcony, Bathtub, Champage, CoffeeMaker, Kitchen, SafetyBox, Minibar, Bidet, Throne " +
                "FROM ((Room JOIN TypeRoom ON Room.TypeId = TypeRoom.TypeId)" +
                "JOIN Hotel ON Hotel.HotelId = (Room.RoomId / POWER (10, DATALENGTH (CAST (Room.RoomNo AS VARCHAR(MAX))))))" : outsideCommand;
            DataSet dt = fc.GetData(query);

            SqlDataReader reader = fc.getForCombo(query);

            System.Drawing.Image[] pbroompic = new System.Drawing.Image[numberOfHotel];
            string[] HotelId = new string[numberOfHotel];
            string[] HotelName = new string[numberOfHotel];
            string[] RoomName = new string[numberOfHotel];
            string[] RoomBed = new string[numberOfHotel];
            string[] RoomPerson = new string[numberOfHotel];
            string[] RoomPrice = new string[numberOfHotel];
            string[,] InteriorArray = new string[numberOfHotel, 14];

            int index = 0;
            while (reader.Read() && index < HotelName.Length)
            {
                if (!reader.IsDBNull(reader.GetOrdinal("RoomPicture")))
                {
                    byte[] pic = (byte[])reader["RoomPicture"];
                    using (var stream = new MemoryStream(pic))
                    {
                        pbroompic[index] = System.Drawing.Image.FromStream(stream);
                    }
                }

                HotelId[index] = reader["HotelId"].ToString();
                HotelName[index] = reader["HotelName"].ToString();
                RoomName[index] = reader["RoomName"].ToString();
                RoomBed[index] = reader["RoomBed"].ToString() + " Bed";
                RoomPerson[index] = reader["RoomPerson"].ToString() + " Person";
                RoomPrice[index] = reader["RoomPrice"].ToString() + "000 VND";
                InteriorArray[index, 0] = reader["AC"].ToString();
                InteriorArray[index, 1] = reader["Chair"].ToString();
                InteriorArray[index, 2] = reader["Hairdryer"].ToString();
                InteriorArray[index, 3] = reader["Desk"].ToString();
                InteriorArray[index, 4] = reader["Refrigerator"].ToString();
                InteriorArray[index, 5] = reader["Balcony"].ToString();
                InteriorArray[index, 6] = reader["Bathtub"].ToString();
                InteriorArray[index, 7] = reader["Champage"].ToString();
                InteriorArray[index, 8] = reader["CoffeeMaker"].ToString();
                InteriorArray[index, 9] = reader["Kitchen"].ToString();
                InteriorArray[index, 10] = reader["SafetyBox"].ToString();
                InteriorArray[index, 11] = reader["Minibar"].ToString();
                InteriorArray[index, 12] = reader["Bidet"].ToString();
                InteriorArray[index, 13] = reader["Throne"].ToString();
                index++;
            }

            for (int i = 0; i < uc.Length; i++)
            {

                uc[i] = new UCShowroom();
                uc[i].LblHotelId = HotelId[i];
                uc[i].LblHotelName = HotelName[i];
                uc[i].PbRoomPic = pbroompic[i];
                uc[i].LblRoomName = RoomName[i];
                uc[i].LblRoomBed = RoomBed[i];
                uc[i].LblRoomPerson = RoomPerson[i];
                uc[i].LblRoomPrice = RoomPrice[i];
                //Add click button event to the Show Hotel Button
                uc[i].ShowHotel.Click += new EventHandler(ShowHotel_Click);
                int count = 0;
                for (int j = 13; j > 0 && count < 6; j--)
                {
                    if (InteriorArray[i, j] != "False")
                    switch (count)
                    {
                        case 0:
                            uc[i].LblInterior1 = CodeEdit.InteriorCheck(j);
                            uc[i].PBInterior1.Image = CodeEdit.InteriorPicture(j);
                            count++;
                            break;
                        case 1:
                            uc[i].LblInterior2 = CodeEdit.InteriorCheck(j);
                            uc[i].PBInterior2.Image = CodeEdit.InteriorPicture(j);
                            count++;
                            break;
                        case 2:
                            uc[i].LblInterior3 = CodeEdit.InteriorCheck(j);
                            uc[i].PBInterior3.Image = CodeEdit.InteriorPicture(j);
                            count++;
                            break;
                        case 3:
                            uc[i].LblInterior4 = CodeEdit.InteriorCheck(j);
                            uc[i].PBInterior4.Image = CodeEdit.InteriorPicture(j);
                            count++;
                            break;
                        case 4:
                            uc[i].LblInterior5 = CodeEdit.InteriorCheck(j);
                            uc[i].PBInterior5.Image = CodeEdit.InteriorPicture(j);
                            count++;
                            break;
                        case 5:
                            uc[i].LblInterior6 = CodeEdit.InteriorCheck(j);
                            uc[i].PBInterior6.Image = CodeEdit.InteriorPicture(j);
                            count++;
                            break;
                        }
                }
                if (uc[i].LblHotelName != null) flowPanel.Controls.Add(uc[i]);
            }
            reader.Close();

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
    }
}


