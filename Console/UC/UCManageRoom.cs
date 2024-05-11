using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console
{
    public partial class UCManageRoom : UserControl
    {
        public UCManageRoom()
        {
            InitializeComponent();
        }

        #region GET & SET
        public Label RoomName
        {
            get { return lblRoomName; }
            set { lblRoomName = value; }
        }
        public Label Order
        {
            get { return lblOrderId; }
            set { lblOrderId = value; }
        }
        public Label Province
        {
            get { return lblProvince; }
            set { lblProvince = value; }
        }
        public Label CheckDate
        {
            get { return lblCheckDate; }
            set { lblCheckDate = value; }
        }
        public Label HotelName
        {
            get { return lblHotelName; }
            set { lblHotelName = value; }
        }
        public Label CheckIn
        {
            get { return lblCheckinDate; }
            set { lblCheckinDate = value; }
        }
        public Label CheckOut
        {
            get { return lblCheckoutDate; }
            set { lblCheckoutDate = value; }
        }
        public Label Status
        {
            get { return lblCanceled; }
            set { lblCanceled = value; }
        }
        public Guna2PictureBox PBPictureBox
        {
            get { return pbRoomPicture; }
            set { pbRoomPicture = value; }
        }
        public Guna2Button ManageBooking
        {
            get { return btnManageBooking; }
            set { btnManageBooking = value; }
        }
        #endregion
    }
}
