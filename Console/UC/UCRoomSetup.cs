using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console
{
    public partial class UCRoomSetup : UserControl
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.conn);
        int hotel;
        public UCRoomSetup()
        {
            InitializeComponent();
        }
        public void RoomSetup_Load()
        {
            DTG_LOAD();
            txtType_Load();
        }
        public void HotelUpdate()
        {
            string hotelQuery = string.Format("SELECT HotelId FROM HotelOwn WHERE PersonId = {0}", CodeEdit.id);
            hotel = CodeEdit.SqlScalar(hotelQuery);
        }
        private void txtType_Load()
        {
            txtType.Items.Clear();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT NameRoom FROM TypeRoom;";
                cmd.Connection = connection;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtType.Items.Add(dr[0]);
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

        private void DTG_LOAD()
        {
            try
            {
                connection.Open();
                string sqlStr = string.Format("SELECT TypeRoom.NameRoom, RoomNo, RoomName, RoomBed, RoomPerson, RoomPrice, RoomArea FROM " +
                    "Room LEFT JOIN TypeRoom ON Room.TypeId = TypeRoom.TypeId " +
                    "WHERE (RoomId / POWER (10, DATALENGTH (CAST (RoomNo AS VARCHAR(MAX))))) = {0}", hotel);

                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dtgView.DataSource = dt; /// gvHsinh = name cua data gridview

                //byte[] pic = ;
                //pic = (byte[])dtgView.CurrentRow.Cells[8].Value;
                //MemoryStream picture = new MemoryStream(pic);
                //pbPicture.Image = Image.FromStream(picture);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtType.SelectedItem == null || txtName.Text == "" || txtNo.Text == "" || txtBed.Text == "" || txtPerson.Text == "" || txtPrice.Text == ""
                || txtArea.Text == "") return;
            try
            {
                // Ket noi
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO Room VALUES (@id, @type, @name, @no, @bed, @person, @price, @area, @image)";

                SqlParameterCollection parameter = cmd.Parameters;

                if (pbPicture.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    pbPicture.Image.Save(ms, pbPicture.Image.RawFormat);
                    parameter.AddWithValue("@image", ms.ToArray());
                }
                else
                {
                    parameter.AddWithValue("@image", null);
                }

                parameter.AddWithValue("@id", hotel.ToString() + txtNo.Text);
                parameter.AddWithValue("@type", Int32.Parse(txtType.SelectedIndex.ToString()) + 1);
                parameter.AddWithValue("@name", txtName.Text);
                parameter.AddWithValue("@no", txtNo.Text);
                parameter.AddWithValue("@bed", txtBed.Text);
                parameter.AddWithValue("@person", txtPerson.Text);
                parameter.AddWithValue("@price", txtPrice.Text);
                parameter.AddWithValue("@area", txtArea.Text);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Successfully added!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to add\n" + ex);
            }
            finally
            {
                connection.Close();
                DTG_LOAD();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            {
                if ((opf.ShowDialog() == DialogResult.OK))
                {
                    pbPicture.Image = Image.FromFile(opf.FileName);
                }
            }
        }

        private void txtType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT NameRoom FROM TypeRoom WHERE TypeId = @id;";
                cmd.Parameters.AddWithValue("@id", Int32.Parse(txtType.SelectedIndex.ToString()) + 1);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                txtName.Text = dr[0].ToString();

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
    }
}
