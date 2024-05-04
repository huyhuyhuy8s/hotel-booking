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
            UCShowHotel2 ucshowhotel = (UCShowHotel2)btn.Parent.Parent;
            FDisplayForm fdisplayForm = this.Parent.Parent as FDisplayForm;
            fdisplayForm.ShowRoom_Load(ucshowhotel.LblHotelId);
        }

        public void InsertData(string location, DateTime checkin, DateTime checkout)
        {
            ucTerminal.CBProvince.SelectedItem = location;
            ucTerminal.DTCheckIn.Value = checkin;
            ucTerminal.DTCheckOut.Value = checkout;
            string query = String.Format("SELECT HotelId, HotelName, HotelImage, HotelAddress, HotelHotline, HotelDescription, COUNT(1) OVER () AS Id " +
                "FROM Hotel " +
                "WHERE Hotel.HotelProvince = '{0}';", location);

            outsideCommand = query;
        }

        public void Control()
        {
            string query = (outsideCommand == null) ? "SELECT HotelId, HotelName, HotelImage, HotelAddress, HotelHotline, HotelDescription, COUNT(1) OVER () AS Id FROM Hotel" : outsideCommand;
            DataSet dt = fc.GetData(query);

            SqlDataReader reader = fc.getForCombo(query);

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader tempReader = command.ExecuteReader();
            tempReader.Read();
            int numberOfHotel = Int32.Parse(tempReader["Id"].ToString());
            conn.Close();

            flowPanel.Controls.Clear();
            UCShowHotel2[] uc = new UCShowHotel2[numberOfHotel];


            System.Drawing.Image[] pbroompic = new System.Drawing.Image[numberOfHotel];
            string[] HotelId = new string[numberOfHotel];
            string[] HotelName = new string[numberOfHotel];
            string[] HotelAddress = new string[numberOfHotel];
            string[] HotelHotline = new string[numberOfHotel];
            string[] HotelDescription = new string[numberOfHotel];

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
                //Add click button event to the Show Hotel Button
                uc[i].ShowHotel.Click += new EventHandler(ShowHotel_Click);


                flowPanel.Controls.Add(uc[i]);
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


