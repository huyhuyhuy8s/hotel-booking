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
    public partial class UCFavoriteProvince : UserControl
    {
        public UCFavoriteProvince()
        {
            InitializeComponent();
        }
        private string name;
        private Image picture;

        public string Name
        {
            get { return name; }
            set { name = value; lblNameProvince.Text= value; }
        }
        public Image Picture
        {
            get { return picture; }
            set { picture = value; picProvince.Image = value; }
        }

        
    }
}
