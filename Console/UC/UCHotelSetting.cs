using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console.UC
{
    public partial class UCHotelSetting : UserControl
    {
        int hotel;

        //Hotel Values
        string type;
        int star;
        string province;
        string address;
        string hotline;
        string description;
        byte[] picture, picture2, picture3, picture4, picture5;

        public UCHotelSetting()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
            SqlDataReader reader = CodeEdit.SqlRead("SELECT TypeName FROM TypeHotel");

            while (reader.Read())
            {
                cbType.Items.Add(reader.GetString(0));
            }
            conn.Close();
            for(int i = 1; i <= 5; i++)
            {
                cbStar.Items.Add(i);
            }
            reader = CodeEdit.SqlRead("SELECT Name FROM Province");
            while (reader.Read())
            {
                cbProvince.Items.Add(reader.GetString(0));
            }
            conn.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select upto 5 hotel images";
            ofd.Multiselect = true;
            ofd.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            DialogResult dr = ofd.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                string[] files = ofd.FileNames;
                int count = 0;
                foreach (string filename in files)
                {
                    switch (count)
                    {
                        case 0:
                            pbPicture.Image = Image.FromFile(filename); break;
                        case 1:
                            pbPicture2.Image = Image.FromFile(filename); break;
                        case 2:
                            pbPicture3.Image = Image.FromFile(filename); break;
                        case 3:
                            pbPicture4.Image = Image.FromFile(filename); break;
                        case 4:
                            pbPicture5.Image = Image.FromFile(filename); break;
                    }
                    count++;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbType.SelectedItem == null || cbStar.SelectedItem == null || cbProvince.SelectedItem == null || txtAddress.Text == "" || txtHotline.Text == "" || txtDescription.Text == "" || pbPicture.Image == null)
            {
                MessageBox.Show("Please fill all the value to update");
                return;
            }
            if (cbType.SelectedItem.ToString() != type || (int)cbStar.SelectedItem != star || cbProvince.SelectedItem.ToString() != province || txtAddress.Text != address || txtHotline.Text != hotline || txtDescription.Text != description)
            {
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = string.Format("UPDATE Hotel " +
                        "SET HotelType = @type, HotelStar = @star, HotelProvince = @province, HotelAddress = @address, HotelHotline = @hotline, " +
                        "HotelDescription = @description, HotelImage = @image, HotelImage2 = @image2, HotelImage3 = @image3, HotelImage4 = @image4, HotelImage5 = @image5 " +
                        "WHERE HotelId = {0}", hotel);

                    SqlParameterCollection parameter = cmd.Parameters;

                    parameter.AddWithValue("@type", CodeEdit.Reverse_TypeHotel(cbType.SelectedItem.ToString()));
                    parameter.AddWithValue("@star", cbStar.SelectedItem);
                    parameter.AddWithValue("@province", cbProvince.SelectedItem);
                    parameter.AddWithValue("@address", txtAddress.Text);
                    parameter.AddWithValue("@hotline", txtHotline.Text);
                    parameter.AddWithValue("@description", txtDescription.Text);

                    SqlParameter photo1 = new SqlParameter("@image", SqlDbType.VarBinary);
                    SqlParameter photo2 = new SqlParameter("@image2", SqlDbType.VarBinary);
                    SqlParameter photo3 = new SqlParameter("@image3", SqlDbType.VarBinary);
                    SqlParameter photo4 = new SqlParameter("@image4", SqlDbType.VarBinary);
                    SqlParameter photo5 = new SqlParameter("@image5", SqlDbType.VarBinary);
                    CodeEdit.updatePic(photo1, pbPicture, parameter);
                    CodeEdit.updatePic(photo2, pbPicture2, parameter);
                    CodeEdit.updatePic(photo3, pbPicture3, parameter);
                    CodeEdit.updatePic(photo4, pbPicture4, parameter);
                    CodeEdit.updatePic(photo5, pbPicture5, parameter);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Successfully updated!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to update\n" + ex);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private byte[] GetPicture(SqlDataReader reader, int id)
        {
            if (!reader.IsDBNull(id))
            {
                byte[] pic = (byte[])reader.GetValue(id);
                return pic;
            }
            else return null;
        }

        public void HotelUpdate()
        {
            string hotelQuery = string.Format("SELECT HotelId FROM HotelOwn WHERE PersonId = {0}", CodeEdit.id);
            hotel = CodeEdit.SqlScalar(hotelQuery);
        }
        public void HotelSetting_Load()
        {
            SqlDataReader reader = CodeEdit.SqlRead(string.Format("SELECT TypeHotel.TypeName, HotelStar, HotelProvince, HotelAddress, HotelHotline, HotelDescription, " +
                "HotelImage, HotelImage2, HotelImage3, HotelImage4, HotelImage5 " +
                "FROM Hotel JOIN TypeHotel ON Hotel.HotelType = TypeHotel.HotelType WHERE HotelId = {0}", hotel));
            while(reader.Read())
            {
                cbType.SelectedItem = type = reader.GetString(0);
                cbStar.SelectedItem = star = reader.GetInt32(1);
                cbProvince.SelectedItem = province = reader.GetString(2);
                txtAddress.Text = address = reader.GetString(3);
                txtHotline.Text = hotline = reader.GetInt32(4).ToString();
                txtDescription.Text = description = reader.GetString(5);

                picture = GetPicture(reader, 6);
                picture2 = GetPicture(reader, 7);
                picture3 = GetPicture(reader, 8);
                picture4 = GetPicture(reader, 9);
                picture5 = GetPicture(reader, 10);

                CodeEdit.displayPicture(reader, 6, pbPicture);
                CodeEdit.displayPicture(reader, 7, pbPicture2);
                CodeEdit.displayPicture(reader, 8, pbPicture3);
                CodeEdit.displayPicture(reader, 9, pbPicture4);
                CodeEdit.displayPicture(reader, 10, pbPicture5);
            }
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
            conn.Close();
        }
    }
}
