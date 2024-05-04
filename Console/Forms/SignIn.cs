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
using System.Xml.Linq;

namespace Console
{
    public partial class SignIn : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.conn);
        public SignIn()
        {
            InitializeComponent();
        }

        #region DRAG && CLOSE
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

        private void btnPasswordShow_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = (txtPassword.PasswordChar == '*') ? '\0' : '*';
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPhoneNumber.Text == "" || txtPassword.Text == "") return;
                // Ket noi
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection; //111111111
                cmd.CommandText = "SELECT PersonId FROM Person WHERE (PersonPhonenumber = @phonenumber AND PersonPassword = @password)";

                SqlParameterCollection parameter = cmd.Parameters;

                parameter.AddWithValue("@phonenumber", txtPhoneNumber.Text);
                parameter.AddWithValue("@password", txtPassword.Text);
                object o = cmd.ExecuteScalar();
                if (o != null)
                {
                    MessageBox.Show("Successfully logged!");
                    CodeEdit.logged = true;
                    CodeEdit.id = Int32.Parse(o.ToString());
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Phone number or Password is not correct");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to login\n" + ex);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.ShowDialog();
        }
    }
}
