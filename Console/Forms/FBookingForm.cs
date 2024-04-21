using Console.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Data.SqlClient;
using System.Management;

namespace Console
{
    public partial class FBookingForm : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.conn);
        public FBookingForm()
        {
            InitializeComponent();
            
            flowPanel.FlowDirection = FlowDirection.TopDown;
            flowPanel.WrapContents = false;
            flowPanel.AutoScroll = true;
        }

        private void FormBooking_Load(object sender, EventArgs e)
        {
            FlowPanelGenerate();
        }

        private void FlowPanelGenerate()
        {
            #region Promotion Values
            UCPromotionValue[] listPromotion = new UCPromotionValue[2];
            for (int i = 0; i < listPromotion.Length; i++)
            {
                listPromotion[i] = new UCPromotionValue();
            }
            listPromotion[0].Title = "New year, new adventures";
            listPromotion[0].SubTitle = "Save 15% or more when you book and stay before April 1, 2024";
            listPromotion[0].PbPromotion = Console.Properties.Resources.banana;
            listPromotion[0].Dock = DockStyle.Left;
            listPromotion[1].Title = "Seize the moment!";
            listPromotion[1].SubTitle = "Save 15% or more when you book and stay before October 1, 2024";
            listPromotion[1].PbPromotion = Console.Properties.Resources.banana;
            listPromotion[1].Dock = DockStyle.Right;
            #endregion

            #region UCPromotion
            flowPanel.Controls.Clear();
            UCPromotion promotion = new UCPromotion();
            //promotion.BackColor = Color.FromArgb(225, 231, 255);
            promotion.Title = "Offers and Promotions";
            promotion.SubTitle = "Promotions, deals, and special offers for you";
            //promotion.TablePanel.Controls.Add(listPromotion[0], 0, 0);
            //promotion.TablePanel.Controls.Add(listPromotion[1], 1, 0);
            #endregion

            UCExplore explore = new UCExplore();

            //Add item
            flowPanel.Controls.Add(promotion);
            flowPanel.Controls.Add(explore);
            //flowPanel.Controls.SetChildIndex(promotion, flowPanel.Controls.GetChildIndex(explore) + 1);
        }

        #region Terminal_Events
        //private void btnLocation_Click(object sender, EventArgs e)
        //{
        //    ucLocation1.Visible = !ucLocation1.Visible;
        //}

        private void btnPeople_Click(object sender, EventArgs e)
        {
            ucPeople1.Visible = !ucPeople1.Visible;
        }

        private void ucTerminal1_Load(object sender, EventArgs e)
        {
            LoadPeople();
            //ucTerminal.BTNLocation.Click += new System.EventHandler(btnLocation_Click);
            ucTerminal.BTNPeople.Click += new System.EventHandler(btnPeople_Click);
        }
        #endregion

        #region People_Event
        public void LoadPeople()
        {
            ucTerminal.BTNPeople.Text = $"{ucPeople1.Adult} adult - {ucPeople1.Child} children - {ucPeople1.Room} rooms";
        }
        private void peopleChange(object sender, EventArgs e)
        {
            LoadPeople();
        }
        private void ucPeople1_Load(object sender, EventArgs e)
        {
            ucPeople1.LBLAdult.TextChanged += new System.EventHandler(peopleChange);
            ucPeople1.LBLChild.TextChanged += new System.EventHandler(peopleChange);
            ucPeople1.LBLRoom.TextChanged += new System.EventHandler(peopleChange);
        }
        #endregion

        #region GET && SET
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
        public Guna2Button UserManage
        {
            get { return btnUserManage; }
            set { btnUserManage = value; }
        }
        #endregion

        #region Login SignUp
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SignIn login = new SignIn();
            login.ShowDialog();
            if (CodeEdit.logged) 
            {
                FDisplayForm dp = this.Parent.Parent as FDisplayForm; //danger
                dp.BookingForm_Load();
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.ShowDialog();
        }
        #endregion

        public void ReLoad()
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }
    }
}
