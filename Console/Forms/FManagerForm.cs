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

namespace Console
{
    public partial class FManagerForm : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.conn);
        public FManagerForm()
        {
            InitializeComponent();
        }

        #region GET && SET
        public Guna.UI2.WinForms.Guna2Button Back
        {
            get { return btnReturn; }
            set {  btnReturn = value; }
        }
        #endregion

        private void ManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }
    }
}
