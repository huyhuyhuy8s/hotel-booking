using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Guna2Button = Guna.UI2.WinForms.Guna2Button;
using Guna.UI2.WinForms;

namespace Console
{
    public partial class FManagerForm : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.conn);
        public FManagerForm()
        {
            InitializeComponent();
            //ucRoomSetup1.
        }

        #region GET && SET
        public Guna2ContainerControl CCTop
        {
            get { return ccTop; }
            set { ccTop = value; }
        }
        public Guna2Button Back
        {
            get { return btnReturn; }
            set { btnReturn = value; }
        }
        public Guna2Button HotelSetting
        {
            get { return btnHotelSetting; }
            set { btnHotelSetting = value; }
        }
        public Guna2Button RoomManage
        {
            get { return btnRoomManage; }
            set { btnRoomManage = value; }
        }
        public Guna2Button RoomSetup
        {
            get { return btnRoomSetup; }
            set { btnRoomSetup = value; }
        }
        public Guna2Button Home
        {
            get { return btnHome; }
            set { btnHome = value; }
        }
        public Panel PanelManager
        {
            get { return panelManager; }
            set { panelManager = value; }
        }
        #endregion

        private void ManagerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
