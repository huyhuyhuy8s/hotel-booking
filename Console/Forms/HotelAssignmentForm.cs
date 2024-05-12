using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;
using Image = System.Drawing.Image;

namespace Console
{
    public partial class HotelAssignmentForm : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.conn);
        public HotelAssignmentForm()
        {
            InitializeComponent();
            Load_TypeHotel();
        }

        #region INTERFACE
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void guna2Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void Load_TypeHotel()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT TypeName FROM TypeHotel;";
                cmd.Connection = connection;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbType.Items.Add(dr[0]);
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

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT Name FROM Province;";
                cmd.Connection = connection;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbProvince.Items.Add(dr[0]);
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

        #region SIGNUP
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" || cbType.SelectedItem == null || txtDescription.Text == "" || cbStar.SelectedItem == null 
                    || cbProvince.SelectedItem == null || txtAddress.Text == "" || txtHotline.Text == "") return;
                // Ket noi
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "DECLARE @id INT = (SELECT count(1) FROM Hotel);" +
                    "SELECT @id = SUM (@id + 1);" +
                    "INSERT INTO Hotel VALUES (@id, @name, @address, @province, @description, @type, @image, @image2, @image3, @image4, @image5, @hotline, @star)" +
                    "INSERT INTO HotelOwn VALUES (@person, @id);" +
                    "UPDATE Person SET PersonManager = 1 WHERE PersonId = @person";

                SqlParameterCollection parameter = cmd.Parameters;

                CodeEdit.addPic("@image", pbPicture, parameter);
                CodeEdit.addPic("@image2", pbPicture2, parameter);
                CodeEdit.addPic("@image3", pbPicture3, parameter);
                CodeEdit.addPic("@image4", pbPicture4, parameter);
                CodeEdit.addPic("@image5", pbPicture5, parameter);

                parameter.AddWithValue("@person", CodeEdit.id);
                parameter.AddWithValue("@name", txtName.Text);
                parameter.AddWithValue("@type", Int32.Parse(cbType.SelectedIndex.ToString()) + 1);
                parameter.AddWithValue("@star", Int32.Parse(cbStar.SelectedIndex.ToString()) + 1);
                parameter.AddWithValue("@description", txtDescription.Text);
                parameter.AddWithValue("@address", txtAddress.Text);
                parameter.AddWithValue("@province", cbProvince.SelectedItem.ToString());
                parameter.AddWithValue("@hotline", txtHotline.Text);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Successfully added!");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to add\n" + ex);
            }
            finally
            {
                connection.Close();
                //Dispose();
            }
        }
        #endregion

        #region Browse Image
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select upto 5 hotel images";
            ofd.Multiselect = true;
            ofd.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            DialogResult dr = ofd.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                string[]files = ofd.FileNames;
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
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
