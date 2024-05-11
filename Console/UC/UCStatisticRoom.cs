using Console.Model;
using Guna.UI2.WinForms;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace Console
{
    public partial class UCStatisticRoom : UserControl
    {
        SearchFunction fc = new SearchFunction();
        SqlConnection con = new SqlConnection(Properties.Settings.Default.conn);
        public DateTime start;
        public DateTime end;
        int? personid = 1;
        public UCStatisticRoom()
        {
            InitializeComponent();
        }
        public void InsertData()
        {
            personid = CodeEdit.id;
            //start = CodeEdit.start;
            //end = CodeEdit.end;
        }
        public void UCStatisticRoom_Load(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            UCStatisticRoom_ReLoad();
        }
        #region GET & SET
        public int? Personid
        {
            get { return personid; }
            set { personid = value; }
        }
        public DateTime Start
        {
            get { return start; }
            set { start = value; }
        }
        public DateTime End
        {
            get { return end; }
            set { end = value; }
        }
        public Guna2DateTimePicker DTDateFrom
        {
            get { return dtDateFrom; }
            set { dtDateFrom = value; }
        }
        public Guna2DateTimePicker DTDateTo
        {
            get { return dtDateTo; }
            set { dtDateTo = value; }
        }
        public Guna2Button BTSearch
        {
            get { return btSearch; }
            set { btSearch = value; }
        }
        public Guna2Button BTLast30days
        {
            get { return btLast30days; }
            set { btLast30days = value; }
        }
        public Guna2Button BTLast7days
        {
            get { return btLast7days; }
            set { btLast7days = value; }
        }
        public Guna2Button BTYesterday
        {
            get { return btYesterday; }
            set { btYesterday = value; }
        }
        public Label LblNumOrders
        {
            get { return lblNumOrders; }
            set { lblNumOrders = value; }
        }
        public Label LblTotalRevenue
        {
            get { return lblTotal; }
            set { lblTotal = value; }
        }
        public Chart CStatistic
        {
            get { return cStatistic; }
            set { cStatistic = value; }
        }
        public Chart CTop3Customers
        {
            get { return cTop3Customers; }
            set { cTop3Customers = value; }
        }
        public Label LblNumCustomers
        {
            get { return lblNumCustomers; }
            set { lblNumCustomers = value; }
        }
        public Label LblTotalProceeds
        {
            get { return lblTotalProceeds; }
            set { lblTotalProceeds = value; }
        }
        #endregion

        public void SearchValue()
        {
            if (DTDateTo.Value > DTDateFrom.Value && DTDateFrom.Value != DateTime.Now && DTDateTo.Value <= DateTime.Now)
            {
                this.Start = DTDateFrom.Value;
                this.End = DTDateTo.Value;
                this.UCStatisticRoom_ReLoad();
            }
            else
            {
                MessageBox.Show("Please provide the start date and end date!");
            }
        }

        public void BTSearch_Click(object sender, EventArgs e)
        {
            SearchValue();
        }

        private void BTLast30days_Click(object sender, EventArgs e)
        {
            this.Start = DateTime.Now.AddDays(-30);
            this.End = DateTime.Now;
            this.UCStatisticRoom_ReLoad();

        }

        private void BTLast7days_Click(object sender, EventArgs e)
        {
            this.Start = DateTime.Now.AddDays(-7);
            this.End = DateTime.Now;
            this.UCStatisticRoom_ReLoad();
        }

        private void BTYesterday_Click(object sender, EventArgs e)
        {
            this.Start = DateTime.Now.AddDays(-1);
            this.End = DateTime.Now.AddDays(-1);
            this.UCStatisticRoom_ReLoad();
        }
        public void UCStatisticRoom_ReLoad()
        {
            #region GET ITEMS

            string query = string.Format("DECLARE @hotelid INT = (SELECT Hotel.HotelId FROM (Hotel JOIN (HotelOwn JOIN Person ON HotelOwn.PersonId = Person.PersonId) ON Hotel.HotelId = HotelOwn.HotelId) WHERE Person.PersonId = '{0}') " +
                                         "SELECT  SUM(TotalMoney) AS Total, COUNT(OrderId) AS NumOrder " +
                                         "FROM (PersonOrder JOIN (Room JOIN Hotel ON HotelId = (Room.RoomId / POWER (10, DATALENGTH (CAST (RoomNo AS VARCHAR(MAX)))))) ON PersonOrder.RoomId = Room.RoomId ) " +
                                         "WHERE OrderStart BETWEEN '{1}' AND '{2}' AND Hotel.HotelId = @hotelid", Personid, Start.ToString("yyyy/MM/dd"), End.ToString("yyyy/MM/dd"));
            DataSet dt = fc.GetData(query);

            if (dt.Tables[0].Rows.Count > 0)
            {
                DataRow row = dt.Tables[0].Rows[0];
                //roomid = int.Parse(row["RoomId"].ToString());
                LblNumOrders.Text = row["NumOrder"].ToString();
                lblTotalRevenua.Text = row["Total"].ToString();

            }
            #endregion

            #region FILL CHART PROFITS

            DataTable dt1 = new DataTable();
            con.Open();
            string query1 = string.Format("DECLARE @hotelid INT = (SELECT Hotel.HotelId FROM (Hotel JOIN (HotelOwn JOIN Person ON HotelOwn.PersonId = Person.PersonId) ON Hotel.HotelId = HotelOwn.HotelId) WHERE Person.PersonId = '{0}')" +
                                          " SELECT OrderStart, SUM(TotalMoney) AS Profit " +
                                          "FROM (PersonOrder JOIN (Room JOIN Hotel ON HotelId = (Room.RoomId / POWER (10, DATALENGTH (CAST (RoomNo AS VARCHAR(MAX)))))) ON PersonOrder.RoomId = Room.RoomId ) " +
                                          "WHERE OrderStart BETWEEN '{1}' AND '{2}' AND Hotel.HotelId = @hotelid " +
                                          "GROUP BY OrderStart", Personid, Start.ToString("yyyy/MM/dd"), End.ToString("yyyy/MM/dd"));
            SqlDataAdapter da = new SqlDataAdapter(query1, con);
            da.Fill(dt1);
            DataView source = new DataView(dt1);
            CStatistic.DataSource = source;
            con.Close();

            CStatistic.Series["Profit"].XValueMember = "OrderStart";
            CStatistic.Series["Profit"].YValueMembers = "Profit";
            CStatistic.DataBind();
            #endregion

            #region FILL CHART TOP CUSTOMERS

            DataTable dt2 = new DataTable();
            con.Open();
            string query2 = string.Format("DECLARE @hotelid INT = (SELECT Hotel.HotelId FROM (Hotel JOIN (HotelOwn JOIN Person ON HotelOwn.PersonId = Person.PersonId) ON Hotel.HotelId = HotelOwn.HotelId) WHERE Person.PersonId = '{0}') " +
                                          "SELECT COUNT(*) as Countt, PersonOrder.PersonId, PersonName " +
                                          "FROM (Person " +
                                          "JOIN (PersonOrder " +
                                          "JOIN (Room JOIN Hotel ON (Room.RoomId / POWER (10, DATALENGTH (CAST (RoomNo AS VARCHAR(MAX)))))=Hotel.HotelId ) ON PersonOrder.RoomId = Room.RoomId) ON Person.PersonId = PersonOrder.PersonId ) " +
                                          "WHERE OrderStart BETWEEN '{1}' AND '{2}' AND Hotel.HotelId = @hotelid " +
                                          "GROUP BY PersonOrder.PersonId, Person.PersonName " +
                                          "ORDER BY COUNT(PersonOrder.PersonId) DESC " +
            "OFFSET 0 ROWS " +
                                          "FETCH FIRST 3 ROWS ONLY", Personid, Start.ToString("yyyy/MM/dd"), End.ToString("yyyy/MM/dd"));
            SqlDataAdapter da2 = new SqlDataAdapter(query2, con);
            da2.Fill(dt2);
            DataView source2 = new DataView(dt2);
            CTop3Customers.DataSource = source2;
            con.Close();

            CTop3Customers.Series["Customers"].XValueMember = "PersonName";
            CTop3Customers.Series["Customers"].YValueMembers = "Countt";
            CTop3Customers.DataBind();
            #endregion

            #region GET TOTALS

            string query3 = string.Format("DECLARE @hotelid INT = (SELECT Hotel.HotelId FROM (Hotel JOIN (HotelOwn JOIN Person ON HotelOwn.PersonId = Person.PersonId) ON Hotel.HotelId = HotelOwn.HotelId) WHERE Person.PersonId = '{0}') " +
                                          "SELECT SUM(TotalMoney) AS Total, COUNT(*) AS Customers " +
                                          "FROM (PersonOrder JOIN (Room " +
                                          "JOIN Hotel ON HotelId = (Room.RoomId / POWER (10, DATALENGTH (CAST (RoomNo AS VARCHAR(MAX)))))) ON PersonOrder.RoomId = Room.RoomId ) " +
                                          "WHERE Hotel.HotelId = @hotelid", Personid);
            DataSet dt3 = fc.GetData(query3);
            if (dt3.Tables[0].Rows.Count > 0)
            {
                DataRow row1 = dt3.Tables[0].Rows[0];
                LblNumCustomers.Text = row1["Customers"].ToString();
                LblTotalProceeds.Text = row1["Total"].ToString();
            }
            #endregion
        }

    }
    

}
