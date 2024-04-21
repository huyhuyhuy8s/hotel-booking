using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Console
{
    internal class SearchFunction
    {
        protected SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-1HVDVK8;Initial Catalog=KhachSan;Integrated Security=True;";
            return conn;
        }

        public DataSet GetData (string query)
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(string query, string messange)
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand(); ;
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(messange, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        public SqlDataReader getForCombo(string query)
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand(); 
            cmd.Connection = conn;
            conn.Open();
            cmd= new SqlCommand(query,conn); 
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }
        
    }
}
