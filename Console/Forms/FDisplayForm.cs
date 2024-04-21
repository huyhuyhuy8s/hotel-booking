using Guna.UI2.WinForms;
using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static Console.CodeEdit;

namespace Console
{
    public partial class FDisplayForm : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.conn);
        #region Form Assigned
        //Login value
        FBookingForm fbookingForm = new FBookingForm();
        FManagerForm fmanagerForm = new FManagerForm();
        FSearchForm fsearchForm = new FSearchForm();
        FShowRoom fshowRoom = new FShowRoom();
        FManageRoom fmanageRoom = new FManageRoom();
        HotelAssignmentForm hotelForm = new HotelAssignmentForm();
        FBookingRoom fBookingRoom = new FBookingRoom();
        #endregion

        #region Necessary Functions

        #endregion

        public FDisplayForm()
        {
            InitializeComponent();
            BookingForm_Load();
            //LoadForm(fshowRoom, panelShow);
        }

        #region Booking Room
        private void BookingRoom_Click(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            UCShowroom uc = btn.Parent.Parent as UCShowroom;
            fBookingRoom.InsertData(Int32.Parse(uc.LblHotelId)); //Room ID
            fBookingRoom.BTNReturn.Click += new EventHandler(BookingForm_Click);
            LoadForm(fBookingRoom, panelShow);
        }
        #endregion

        #region Manage Room
        private void ManageRoom_Click(object sender, EventArgs e)
        {
            ManageRoom_Load();
        }
        private void ManageRoom_Load()
        {
            fmanageRoom.Booked.Click += new EventHandler(ManageRoom_BookedClick);
            fmanageRoom.Booking.Click += new EventHandler(ManageRoom_BookingClick);
            fmanageRoom.Return.Click += new EventHandler(BookingForm_Click);
            LoadForm(fmanageRoom, panelShow);
        }
        private void ManageRoom_BookedClick (object sender, EventArgs e)
        {
            fmanageRoom.Booked.Enabled = false;
            fmanageRoom.Booking.Enabled = true;
            fmanageRoom.Panel_Load();
        }
        private void ManageRoom_BookingClick (object sender, EventArgs e)
        {
            fmanageRoom.Booking.Enabled = false;
            fmanageRoom.Booked.Enabled = true;
            fmanageRoom.Panel_Load();
        }
        #endregion

        #region Show Room
        public void ShowRoom_Load(string hotelId)
        {
            fshowRoom.InsertData(hotelId);
            foreach (UCShowroom uc in fshowRoom.FlowPanel.Controls)
            {
                uc.ShowHotel.Click += new EventHandler(BookingRoom_Click);
            }
            fshowRoom.Return.Click += new EventHandler(BookingForm_Click);
            LoadForm(fshowRoom, panelShow);
        }
        #endregion

        #region Search Form
        public void SearchForm_Load()
        {
            if (logged) SearchForm_Signed();
            else fsearchForm.CreateSignIn(); //SignIn and SignUp button rebuild
            fsearchForm.Terminal.BTNSearch.Click += new System.EventHandler(SearchForm_SearchClick);
            LoadForm(fsearchForm, panelShow);
        }
        private void SearchForm_LogOut(object sender, EventArgs e)
        {
            logged = false;
            id = null;
            SearchForm_Load();
        }
        private void SearchForm_Signed()
        {
            fsearchForm.SignIn.Text = "Logout";
            RemoveEvent(fsearchForm.SignIn);
            fsearchForm.SignIn.Click += new System.EventHandler(SearchForm_LogOut);
            fsearchForm.SignUp.Text = "Become a manager";
            fsearchForm.SignUp.FillColor = Color.FromArgb(240, 224, 94);
            RemoveEvent(fsearchForm.SignUp);
            fsearchForm.SignUp.Click += new System.EventHandler(ManagerForm_Click);
        }
        private void SearchForm_SearchClick(object sender, EventArgs e)
        {
            if (fsearchForm.Terminal.CBProvince.SelectedItem == null) { MessageBox.Show("Please select Location"); return; }
            if (fsearchForm.Terminal.DTCheckIn.Value.Date < DateTime.Now.Date || fsearchForm.Terminal.DTCheckOut.Value.Date < DateTime.Now.Date) { MessageBox.Show("Your Check in/out date are in the pass\n Please check again"); return; }
            if (fsearchForm.Terminal.DTCheckOut.Value.Date < fsearchForm.Terminal.DTCheckIn.Value.Date) { MessageBox.Show("Check in date are larger check out date!"); return; }
            fsearchForm.InsertData(fsearchForm.Terminal.CBProvince.SelectedItem.ToString(), fsearchForm.Terminal.DTCheckIn.Value, fsearchForm.Terminal.DTCheckOut.Value);
            fsearchForm.Control();
            if (logged) SearchForm_Signed();
            LoadForm(fsearchForm, panelShow);
        }
        #endregion

        #region Booking Form
        private void BookingForm_SearchClick(object sender, EventArgs e)
        {
            if (fbookingForm.Terminal.CBProvince.SelectedItem == null) { MessageBox.Show("Please select Location"); return; }
            if (fbookingForm.Terminal.DTCheckIn.Value.Date < DateTime.Now.Date || fbookingForm.Terminal.DTCheckOut.Value.Date < DateTime.Now.Date) { MessageBox.Show("Your Check in/out date are in the pass\n Please check again"); return; }
            if (fbookingForm.Terminal.DTCheckOut.Value.Date < fbookingForm.Terminal.DTCheckIn.Value.Date) { MessageBox.Show("Check in date are larger check out date!"); return; }
            fsearchForm.InsertData(fbookingForm.Terminal.CBProvince.SelectedItem.ToString(), fbookingForm.Terminal.DTCheckIn.Value, fbookingForm.Terminal.DTCheckOut.Value);
            fsearchForm.Control();
            CodeEdit.start = fbookingForm.Terminal.DTCheckIn.Value.Date;
            CodeEdit.end = fbookingForm.Terminal.DTCheckOut.Value.Date;
            if (logged) SearchForm_Signed();
            SearchForm_Load();
        }
        public void BookingForm_Load()
        {
            if (logged) BookingForm_Signed();
            else BookingForm_Logged();
            fbookingForm.Terminal.BTNSearch.Click += new System.EventHandler(BookingForm_SearchClick);
            LoadForm(fbookingForm, panelShow);
        }
        //Booking Form

        private void BookingForm_Click(object sender, EventArgs e)
        {
            if (logged) BookingForm_Signed();
            LoadForm(fbookingForm,panelShow);
        }
        //Signed
        private void BookingForm_Signed()
        {
            fbookingForm.UserManage.Visible = true;
            fbookingForm.SignIn.Text = "Logout";
            fbookingForm.SignUp.Text = "Become a manager";
            fbookingForm.SignUp.FillColor = Color.FromArgb(240, 224, 94);
            RemoveEvent(fbookingForm.SignUp);
            fbookingForm.SignUp.Click += new System.EventHandler(ManagerForm_Click);
            RemoveEvent(fbookingForm.SignIn);
            fbookingForm.SignIn.Click += new System.EventHandler(BookingForm_LogOut);
        }
        private void BookingForm_Logged()
        {
            fbookingForm.UserManage.Visible = false;
            fbookingForm.ReLoad();
            fbookingForm.UserManage.Click += new EventHandler(ManageRoom_Click);
        }
        private void BookingForm_LogOut(object sender, EventArgs e)
        {
            logged = false;
            id = null;
            BookingForm_Load();
        }
        #endregion

        #region Manager Form
        //Manager
        private void ManagerForm_Load()
        {
            fmanagerForm.Back.Click += new System.EventHandler(BookingForm_Click);
            LoadForm(fmanagerForm, panelShow);
        }
        private void ManagerForm_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT PersonManager FROM Person WHERE PersonId = @id;";
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@id", id);
                if (cmd.ExecuteScalar().ToString() != "True")
                {
                    MessageBox.Show("You're seem not owning a hotel. Please sign up your hotel!");
                    hotelForm.ShowDialog();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }
            fmanagerForm.Back.Click += new System.EventHandler(BookingForm_Click);
            LoadForm(fmanagerForm, panelShow);
        }
        #endregion

    }
}
