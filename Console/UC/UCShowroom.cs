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
    public partial class UCShowroom : UserControl
    {
        public UCShowroom()
        {
            InitializeComponent();
        }

        #region GET & SET
        private Image roompic;
        private string htid;
        private string htname;
        private string roomname;
        private string roombed;
        private string roomperson;
        private string roomprice;
        private string roominterior1;
        private string roominterior2;
        private string roominterior3;
        private string roominterior4;
        private string roominterior5;
        private string roominterior6;
        public Image PbRoomPic
        {
            get { return roompic; }
            set { roompic = value; pbRoomPic.Image = value; }
        }
        public string LblHotelId
        {
            get { return htid; } 
            set {  htid = value; lblHotelId.Text = value; }
        }
        public string LblHotelName
        {
            get { return htname;}
            set { htname = value; lblHotelName.Text = value; }

        }
        public string LblRoomName
        {
            get { return roomname; }
            set { roomname = value; lblRoomName.Text = value; }
        }
        public string LblRoomBed
        {
            get { return roombed; }
            set { roombed = value; lblRoomBed.Text = value; }
        }
        public string LblRoomPerson
        {
            get { return roomperson; }
            set { roomperson = value; lblRoomPerson.Text = value; }
        }
        public string LblRoomPrice
        {
            get { return roomprice; }
            set { roomprice = value; lblPrice.Text = value; }
        }
        public string LblInterior1
        {
            get { return roominterior1; }
            set { roominterior1 = value;lblInterior1.Text = value; }
        }
        public string LblInterior2
        {
            get { return roominterior2; }
            set { roominterior2 = value; lblInterior2.Text = value; }
        }
        public string LblInterior3
        {
            get { return roominterior3; }
            set { roominterior3 = value; lblInterior3.Text = value; }
        }
        public string LblInterior4
        {
            get { return roominterior4; }
            set { roominterior4 = value; lblInterior4.Text = value; }
        }
        public string LblInterior5
        {
            get { return roominterior5; }
            set { roominterior5 = value; lblInterior5.Text = value; }
        }
        public string LblInterior6
        {
            get { return roominterior6; }
            set { roominterior6 = value; lblInterior6.Text = value; }
        }


        ////
        public Guna2PictureBox PBInterior1
        {
            get { return pbInterior1; }
            set { pbInterior1 = value; }
        }
        public Guna2PictureBox PBInterior2
        {
            get { return pbInterior2; }
            set { pbInterior2 = value; }
        }
        public Guna2PictureBox PBInterior3
        {
            get { return pbInterior3; }
            set { pbInterior3 = value; }
        }
        public Guna2PictureBox PBInterior4
        {
            get { return pbInterior4; }
            set { pbInterior4 = value; }
        }
        public Guna2PictureBox PBInterior5
        {
            get { return pbInterior5; }
            set { pbInterior5 = value; }
        }
        public Guna2PictureBox PBInterior6
        {
            get { return pbInterior6; }
            set { pbInterior6 = value; }
        }
        public Guna2Button ShowHotel
        {
            get { return btnShowHotel; }
            set { btnShowHotel = value; }
        }
        #endregion
    }
}
