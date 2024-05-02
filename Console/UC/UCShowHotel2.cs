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
    public partial class UCShowHotel2 : UserControl
    {
        public UCShowHotel2()
        {
            InitializeComponent();
        }
        
        private Image hotelpic;
        private string htid;
        private string htname;
        private string htaddress;
        private string hthotline;
        private string htdescription;
        public Image PbRoomPic
        {
            get { return hotelpic; }
            set { hotelpic = value; pbHotelPic.Image = value; }
        }
        public string LblHotelId
        {
            get { return htid; }
            set { htid = value; lblHotelId.Text = value; }
        }
        public string LblHotelName
        {
            get { return htname; }
            set { htname = value; lblHotelName.Text = value; }

        }
        public string LblHotelAddress
        {
            get { return htaddress; }
            set { htaddress = value; lblHotelAddress.Text = value; }
        }
        public string LblHotelHotline
        {
            get { return hthotline; }
            set { hthotline = value; lblHotelHotline.Text = value; }
        }
        public string LblHotelDescription
        {
            get { return htdescription; }
            set { htdescription = value; lblHotelDescription.Text = value; }
        }
        public Guna2Button ShowHotel
        {
            get { return btnShowHotel; }
            set { btnShowHotel = value;}
        }
            
    }


}

