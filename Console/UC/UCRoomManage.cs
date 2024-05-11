using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console.UC
{
    public partial class UCRoomManage : UserControl
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.conn);
        string originCommand = "";
        string nameCommand = "";
        string noCommand = "";
        string typeCommand = "";
        public UCRoomManage()
        {
            InitializeComponent();
            ucTitle.CheckBox.CheckedChanged += new EventHandler(CheckAll);
            ucTitle.More.Visible = false;
            ucTitle.CCValue.FillColor = Color.FromArgb(124, 104, 238);
            foreach (Control c in ucTitle.CCValue.Controls)
            {
                if (c is Label)
                    c.ForeColor = Color.White;
            }
            ucTitle.Id.Text = "Id";
            ucTitle.Type.Text = "Type";
            ucTitle.RoomName.Text = "Name";
            ucTitle.No.Text = "No";
            ucTitle.Bed.Text = "Bed";
            ucTitle.Person.Text = "Person";
            ucTitle.Price.Text = "Price";
            ucTitle.Area.Text = "Area";

            SqlDataReader dr = CodeEdit.SqlRead("SELECT NameRoom FROM TypeRoom;");
            while (dr.Read())
            {
                cbType.Items.Add(dr[0]);
            }
            connection.Close();

            int no = 0;
            while (no < 5)
            {
                cbNo.Items.Add(++no);
            }
            //cbNo.StartIndex = -1;
        }
           
        public void RoomManage_Load()
        {
            originCommand = string.Format("DECLARE @hotelid INT = (SELECT Hotel.HotelId FROM (Hotel JOIN HotelOwn ON Hotel.HotelId = HotelOwn.HotelId AND HotelOwn.PersonId = {0})) " +
                "SELECT RoomName, RoomNo, RoomBed, RoomPerson, RoomPrice, RoomArea, TypeId, RoomId " +
                "FROM Room JOIN Hotel " +
                "ON Hotel.HotelId = (RoomId / POWER (10, DATALENGTH (CAST (RoomNo AS VARCHAR(MAX))))) " +
                "WHERE HotelId = @hotelid", CodeEdit.id);
            RoomManage_Update();
        }

        public void RoomManage_Update()
        {
            SqlDataReader reader = CodeEdit.SqlRead((originCommand == "") ? string.Format("DECLARE @hotelid INT = (SELECT Hotel.HotelId FROM (Hotel JOIN HotelOwn ON Hotel.HotelId = HotelOwn.HotelId AND HotelOwn.PersonId = {0})) " +
                "SELECT RoomName, RoomNo, RoomBed, RoomPerson, RoomPrice, RoomArea, TypeId, RoomId " +
                "FROM Room JOIN Hotel " +
                "ON Hotel.HotelId = (RoomId / POWER (10, DATALENGTH (CAST (RoomNo AS VARCHAR(MAX))))) " +
                "WHERE HotelId = @hotelid", CodeEdit.id) : originCommand + nameCommand + noCommand + typeCommand);
            flowPanel.Controls.Clear();
            //cbNo.Items.Clear();
            //cbNo.Items.Add("Room No");
            //cbNo.StartIndex = 0;
            int count = 1;
            while (reader.Read())
            {
                UCRoomManageValue uc = new UCRoomManageValue();
                uc.Id.Text = count.ToString();
                count++;
                uc.RoomName.Text = reader.GetString(0);
                uc.No.Text = reader.GetValue(1).ToString();
                uc.Bed.Text = reader.GetValue(2).ToString();
                uc.Person.Text = reader.GetValue(3).ToString();
                uc.Price.Text = reader.GetValue(4).ToString();
                uc.Area.Text = reader.GetValue(5).ToString();
                uc.Type.Text = CodeEdit.RoomType(reader.GetInt32(6));
                uc.CheckBox.CheckedChanged += new EventHandler(AllChecked);
                uc.RoomId.Text = reader.GetValue(7).ToString();

                flowPanel.Controls.Add(uc);
            }
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.conn);
            connection.Close();
        }

        #region GET & SET
        public Guna2Button AddRoom
        {
            get { return btnAdd; }
            set { btnAdd = value; }
        }
        public Guna2Button DeleteRoom
        {
            get { return btnDelete; }
            set { btnDelete = value; }
        }
        #endregion

        #region Filters
        public void CheckAll(object sender, EventArgs e)
        {
            foreach (UCRoomManageValue uc in flowPanel.Controls)
            {
                uc.CheckBox.Checked = ucTitle.CheckBox.Checked;
            }
        }
        public void AllChecked(object sender, EventArgs e)
        {
            bool check = false, value = check;
            foreach (UCRoomManageValue uc in flowPanel.Controls)
            {
                if (!check)
                {
                    check = true;
                    value = uc.CheckBox.Checked;
                    if (ucTitle.CheckBox.Checked == value) return;
                }
                else
                {
                    if (value != uc.CheckBox.Checked)
                    {
                        //ucTitle.CheckBox.Checked = false;
                        return;
                    }
                }
            }
            ucTitle.CheckBox.Checked = value;
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                nameCommand = "";
            }
            else
            {
                string query = " AND ";
                bool firstCheck = true;
                if (firstCheck) firstCheck = false;
                query += string.Format(" RoomName LIKE '{0}%'", txtName.Text);
                nameCommand = (firstCheck) ? "" : query;
            }
            RoomManage_Update();
        }

        private void cbNo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbNo.SelectedItem.ToString() == "Room No")
            {
                noCommand = "";
            }
            else
            {
                string query = " AND ";
                bool firstCheck = true;
                if (firstCheck) firstCheck = false;
                query += string.Format(" RoomNo = '{0}'", cbNo.SelectedItem);
                noCommand = (firstCheck) ? "" : query;
            }
            RoomManage_Update();
        }

        private void cbType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbType.SelectedItem.ToString() == "Room Type")
            {
                typeCommand = "";
            }
            else
            {
                string query = " AND ";
                bool firstCheck = true;
                if (firstCheck) firstCheck = false;
                query += string.Format(" TypeId = {0}", CodeEdit.Reverse_RoomType(cbType.SelectedItem.ToString()));
                typeCommand = (firstCheck) ? "" : query;
            }
            RoomManage_Update();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            cbNo.SelectedIndex = 0;
            cbType.SelectedIndex = 0;
        }
        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /* 
             SELECT *
 FROM (Room LEFT JOIN PersonOrder ON Room.RoomId = PersonOrder.RoomId) 
 LEFT JOIN (SELECT RoomId FROM PersonOrder WHERE (OrderEnd > GETDATE() AND OrderStart IS NOT NULL AND OrderStatus = 1)) as t2 ON Room.RoomId = t2.RoomId
 WHERE (OrderEnd < GETDATE() OR OrderEnd IS NULL) AND (Room.RoomId <> t2.RoomId OR t2.RoomId IS NULL)
 AND (Room.RoomId = 141 OR Room.RoomId = 142 OR Room.RoomId = 143)
             */
            string query = string.Format("SELECT Room.RoomId, OrderStart, OrderEnd, t2.RoomId" +
                " FROM (Room LEFT JOIN PersonOrder ON Room.RoomId = PersonOrder.RoomId) " +
                " LEFT JOIN (SELECT RoomId FROM PersonOrder WHERE (OrderEnd > GETDATE() AND OrderStart IS NOT NULL AND OrderStatus = 1)) as t2 ON Room.RoomId = t2.RoomId" +
                " WHERE (OrderEnd < GETDATE() OR OrderEnd IS NULL) AND (Room.RoomId <> t2.RoomId OR t2.RoomId IS NULL)");
            bool check = false;
            foreach (UCRoomManageValue uc in flowPanel.Controls)
            {
                if (uc.CheckBox.Checked)
                {
                    if (!check)
                    {
                        query += " AND (";
                        check = true;
                    }
                    else
                    {
                        query += " OR ";
                    }
                    query += string.Format("Room.RoomId = {0}", uc.RoomId.Text);
                }
            }
            if (!check)
            {
                MessageBox.Show("No room was selected");
                return;
            }
            query += ");";
            SqlDataReader reader = CodeEdit.SqlRead(query);
            List<int> rooms = new List<int>();
            while (reader.Read())
            {
                rooms.Add(reader.GetInt32(0));
            }
            connection.Close();
            string deleteQuery = string.Format("DELETE FROM Room WHERE ");
            foreach (int i in rooms)
            {
                if (check) check = false;
                else deleteQuery += " OR ";
                deleteQuery += string.Format("RoomId = {0}", i);
            }
            MessageBox.Show(string.Format("Deleted {0} room(s)",CodeEdit.SqlUpdate(deleteQuery)));
            RoomManage_Update();
        }
    }
}
