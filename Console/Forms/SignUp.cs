using Console.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console
{
    public partial class SignUp : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.conn);
        private KhachSanContext ksContext;
        public SignUp()
        {
            InitializeComponent();
            ksContext = new KhachSanContext();
        }


        #region DRAG & CLOSE
        private void cbClose_Click(object sender, EventArgs e)
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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" || txtPhoneNumber.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" 
                    || dtDOB.Value == null) return;

                using (var db = new KhachSanContext())
                {
                    var person = new Person
                    {
                        PersonName = txtName.Text,
                        PersonPhonenumber = txtPhoneNumber.Text,
                        PersonEmail = txtEmail.Text,
                        PersonPassword = txtPassword.Text,
                        PersonDOB = dtDOB.Value,
                    };
                }
                MessageBox.Show("Successfully Sign Up!");

                // Ket noi
                //connection.Open();
                //SqlCommand cmd = new SqlCommand();
                //cmd.Connection = connection;
                //cmd.CommandText = "DECLARE @check INT = (SELECT PersonId FROM Person WHERE (PersonPhonenumber = @phonenumber));" +
                //    "DECLARE @id INT = (SELECT count(1) FROM Person);" +
                //    "SELECT @id = SUM (@id + 1);" +
                //    "IF (@check >= 1) " +
                //    "PRINT @id;" +
                //    "ELSE " +
                //    "INSERT INTO Person VALUES (@id, @name, @phonenumber, @email, @password, @dob, 0);";

                //SqlParameterCollection parameter = cmd.Parameters;

                //parameter.AddWithValue("@name", txtName.Text);
                //parameter.AddWithValue("@phonenumber", txtPhoneNumber.Text);
                //parameter.AddWithValue("@email", txtEmail.Text);
                //parameter.AddWithValue("@password", txtPassword.Text);
                //parameter.AddWithValue("@dob", dtDOB.Value);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to sign up\n" + ex);
            }
            finally
            {
                connection.Close();
            }
            this.Dispose();
        }

        private void pbShowPassword_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = (txtPassword.PasswordChar == '*') ? '\0' : '*';
        }
    }
}
