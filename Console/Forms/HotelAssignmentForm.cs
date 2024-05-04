using Console.Model;
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
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace Console
{
    public partial class HotelAssignmentForm : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.conn);
        private KhachSanContext ksContext;
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
            ksContext = new KhachSanContext();

            var typehotels = ksContext.TypeHotels.ToList();
            
            foreach (var typehotel in typehotels)
            {
                cbType.Items.Add(typehotel.ToString());
            }
        }

        #region SIGNUP
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" || cbType.SelectedItem == null || txtDescription.Text == "" 
                    || cbProvince.SelectedItem == null || txtAddress.Text == "" || txtHotline.Text == "") return;
                // Ket noi
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "DECLARE @id INT = (SELECT count(1) FROM Hotel);" +
                    "SELECT @id = SUM (@id + 1);" +
                    "INSERT INTO Hotel VALUES (@id, @name, @address, @province, @description, @type, @image, @hotline)" +
                    "INSERT INTO HotelOwn VALUES (@person, @id);" +
                    "UPDATE Person SET PersonManager = 1 WHERE PersonId = @person";

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

                parameter.AddWithValue("@person", CodeEdit.id);
                parameter.AddWithValue("@name", txtName.Text);
                parameter.AddWithValue("@type", Int32.Parse(cbType.SelectedIndex.ToString()) + 1);
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
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            {
                if ((opf.ShowDialog() == DialogResult.OK))
                {
                    pbPicture.Image = Image.FromFile(opf.FileName);
                }
            }
        }
        #endregion
    }
}
