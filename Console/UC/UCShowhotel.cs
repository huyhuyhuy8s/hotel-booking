using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Console
{
    public partial class UCShowhotel : UserControl
    {

        private Image htpicture;
        private string htname;
        private string htaddress;
        private string htdescription;
        

        public Image HotelPicture
        {
            get { return htpicture; }
            set { htpicture = value; pbPictureHotel.Image = value; }
        }
        public string HotelName
        {
            get { return htname; }
            set { htname = value; lbNameHotel.Text = value; }
        }
        public string HotelAddress
        {
            get { return htaddress; }
            set { htaddress = value; lbAddressHotel.Text = value; }
        }
        public string HotelDescription
        {
            get { return htdescription; }
            set { htdescription = value; lbDescriptionHotel.Text = value; }
        }
        


        public UCShowhotel()
        {
            InitializeComponent();
            this.MouseEnter += new EventHandler(ucShowhotel_MouseEnter);
            this.MouseLeave += new EventHandler(ucShowhotel_MouseLeave);
        }
        public void UCShowhotel_Load(object sender, EventArgs e)
        {
            
        }
 

    

        #region Hover Effect
        public void ucShowhotel_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(225, 231, 255);
        }
        public void ucShowhotel_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
        #endregion

        private void tbDescriptionhotel_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void lbNameHotel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbNameHotel_Click_1(object sender, EventArgs e)
        {

        }

        private void pbPictureHotel_Click(object sender, EventArgs e)
        {

        }
        

        private void btShowroom_Click(object sender, EventArgs e)
        {

        }

        private void pbPictureHotel_Click_1(object sender, EventArgs e)
        {

        }

        private void UCShowhotel_Load_1(object sender, EventArgs e)
        {

        }

        private void lbDescriptionHotel_Click(object sender, EventArgs e)
        {

        }

        private void lbAddressHotel_Click(object sender, EventArgs e)
        {

        }
    }
}

