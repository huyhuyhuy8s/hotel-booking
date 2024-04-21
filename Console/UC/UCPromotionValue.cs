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

namespace Console.UC
{
    public partial class UCPromotionValue : UserControl
    {
        public UCPromotionValue()
        {
            InitializeComponent();

            #region Transparent Label
            var pos = lblTitle.Parent.PointToScreen(lblTitle.Location);
            pos = pbPromotion.PointToClient(pos);
            lblTitle.Parent = pbPromotion;
            lblTitle.Location = pos;
            lblTitle.BackColor = Color.Transparent;
            var pos2 = lblSubTitle.Parent.PointToScreen(lblSubTitle.Location);
            pos2 = pbPromotion.PointToClient(pos2);
            lblSubTitle.Parent = pbPromotion;
            lblSubTitle.Location = pos2;
            lblSubTitle.BackColor = Color.Transparent;
            #endregion

        }

        #region GET && SET
        string _lbltitle;
        public string Title
        {
            get { return _lbltitle; }
            set {  _lbltitle = value; lblTitle.Text = value; }
        }
        string _lblsubtitle;
        public string SubTitle
        {
            get { return _lblsubtitle; }
            set { _lblsubtitle = value; lblSubTitle.Text = value; }
        }
        Image _pbPromotion;
        public Image PbPromotion
        {
            get { return _pbPromotion; }
            set { _pbPromotion = value; pbPromotion.Image = value; }
        }
        string _btnFind;
        public string ButtonFind
        {
            get { return _btnFind; }
            set { _btnFind = value; btnFind.Text = value; }
        }
        #endregion
    }
}
