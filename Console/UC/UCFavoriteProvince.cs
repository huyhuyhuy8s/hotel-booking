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
        public PictureBox PicProvince
        {
            get { return picProvince; }
            set { picProvince = value; }
        }
        public PictureBox PicProvince2
        {
            get { return picProvince2; }
            set { picProvince2 = value; }
        }

    }
}
