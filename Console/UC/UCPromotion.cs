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
    public partial class UCPromotion : UserControl
    {
        public UCPromotion()
        {
            InitializeComponent();
        }

        #region GET && SET
        string _lblTitle;
        public string Title
        {
            get { return _lblTitle; }
            set { _lblTitle = value; lblTitle.Text = value; }
        }

        string _lblSubTitle;
        public string SubTitle
        {
            get { return _lblSubTitle; }
            set { _lblSubTitle = value; lblSubTitle.Text = value; }
        }

        //TableLayoutPanel _tablepanel;
        //public TableLayoutPanel TablePanel
        //{
        //    get { return _tablepanel; }
        //    set { _tablepanel = value; }
        //}
        public FlowLayoutPanel TablePanel
        {
            get { return tablePanel; }
            set { tablePanel = value; }
        }
        #endregion
    }
}