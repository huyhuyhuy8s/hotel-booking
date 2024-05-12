using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using RJCodeAdvance.RJControls;

namespace Console
{
    public partial class UCTerminal : UserControl
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.conn);
        public UCTerminal()
        {
            InitializeComponent();
            dtCheckin.Value = DateTime.Now.Date;
            dtCheckout.Value = DateTime.Now.Date;
            CBProvince_Load();
        }

        private void CBProvince_Load()
        {
            try
            {
                connection.Open();
                string sqlStr = string.Format("SELECT Name FROM Province");

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = sqlStr;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CBProvince.Items.Add(dr[0]);
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        #region GET && SET
        public RJComboBox CBProvince
        {
            get { return cbProvince; }
            set { cbProvince = value; }
        }
        public Guna2Button BTNPeople
        {
            get { return btnPeople; }
            set { btnPeople = value; }
        }
        public Guna2Button BTNSearch
        {
            get { return btnSearch; }
            set { btnSearch = value; }
        }
        public Guna2DateTimePicker DTCheckIn
        {
            get { return dtCheckin; }
            set { dtCheckin = value; }
        }
        public Guna2DateTimePicker DTCheckOut
        {
            get { return dtCheckout; }
            set { dtCheckout = value; }
        }
        #endregion
    }
}
