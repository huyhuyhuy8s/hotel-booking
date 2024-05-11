using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.ComponentModel;
using System.Reflection;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Data;

namespace Console
{
    public class GrowLabel : System.Windows.Forms.Label
    {
        private bool mGrowing;
        public GrowLabel()
        {
            this.AutoSize = false;
        }
        private void resizeLabel()
        {
            if (mGrowing) return;
            try
            {
                mGrowing = true;
                Size sz = new Size(this.Width, Int32.MaxValue);
                sz = TextRenderer.MeasureText(this.Text, this.Font, sz, TextFormatFlags.WordBreak);
                this.Height = sz.Height;
            }
            finally
            {
                mGrowing = false;
            }
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            resizeLabel();
        }
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            resizeLabel();
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            resizeLabel();
        }
    }

    static class CodeEdit
    {
        public static bool logged = false;
        public static int? id;
        public static DateTime start;
        public static DateTime end;

        public static void displayPicture(SqlDataReader reader, int id, PictureBox pbPicture)
        {
            if (!reader.IsDBNull(id))
            {
                byte[] pic = (byte[])reader.GetValue(id);
                using (var stream = new MemoryStream(pic))
                {
                    pbPicture.Image = System.Drawing.Image.FromStream(stream);
                }
            }
        }

        public static void addPic(string para, PictureBox pb, SqlParameterCollection parameter)
        {
            if (pb.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pb.Image.Save(ms, pb.Image.RawFormat);
                parameter.AddWithValue(para, ms.ToArray());
            }
            else
            {
                SqlParameter imageParameter = new SqlParameter(para, SqlDbType.Image);
                imageParameter.Value = DBNull.Value;
                parameter.Add(imageParameter);
            }
        }

        public static void updatePic(SqlParameter para, PictureBox pb, SqlParameterCollection parameter)
        {
            if (pb.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pb.Image.Save(ms, pb.Image.RawFormat);
                para.Value = ms.ToArray();
                parameter.Add(para);
            }
            else
            {
                para.Value = DBNull.Value;
                parameter.Add(para);
            }
        }

        #region Interior
        public static Bitmap InteriorPicture(int j)
        {
            switch (j)
            {
                case 0:
                    return Console.Properties.Resources.AC;
                case 1:
                    return Console.Properties.Resources.Chair;
                case 2:
                    return Console.Properties.Resources.Hairdryer;
                case 3:
                    return Console.Properties.Resources.Desk;
                case 4:
                    return Console.Properties.Resources.Refrigerator;
                case 5:
                    return Console.Properties.Resources.Balcony;
                case 6:
                    return Console.Properties.Resources.Bathtub;
                case 7:
                    return Console.Properties.Resources.Champage;
                case 8:
                    return Console.Properties.Resources.CoffeeMaker;
                case 9:
                    return Console.Properties.Resources.Kitchen;
                case 10:
                    return Console.Properties.Resources.SafetyLocker;
                case 11:
                    return Console.Properties.Resources.Minibar;
                case 12:
                    return Console.Properties.Resources.Bidet;
                case 13:
                    return Console.Properties.Resources.Throne;
                default:
                    return Console.Properties.Resources.banana;
            }
        }
        public static string InteriorCheck(int j)
        {
            switch (j)
            {
                case 0:
                    return "AC";
                case 1:
                    return "Chair";
                case 2:
                    return "Hairdryer";
                case 3:
                    return "Desk";
                case 4:
                    return "Refrigerator";
                case 5:
                    return "Balcony";
                case 6:
                    return "Bathtub";
                case 7:
                    return "Champage";
                case 8:
                    return "CoffeeMaker";
                case 9:
                    return "Kitchen";
                case 10:
                    return "SafetyBox";
                case 11:
                    return "Minibar";
                case 12:
                    return "Bidet";
                case 13:
                    return "Throne";
                default:
                    return "";
            }
        }
        #endregion

        #region Type
        public static int Reverse_RoomType(string roomtype)
        {
            switch(roomtype)
            {
                case "Standard":
                    return 1;
                case "Superior":
                    return 2;
                case "Deluxe":
                    return 3;
                case "Connection Room":
                    return 4;
                case "Mini Suite":
                    return 5;
                case "Studio Room":
                    return 6;
                case "Suite":
                    return 7;
                case "Queen Room":
                    return 8;
                case "King Room":
                    return 9;
                case "President Room":
                    return 10;
                default:
                    return 0;
            }
        }
        public static string RoomType(int roomid)
        {
            switch(roomid)
            {
                case 1:
                    return "Standard";
                case 2:
                    return "Superior";
                case 3:
                    return "Deluxe";
                case 4:
                    return "Connection Room";
                case 5:
                    return "Mini Suite";
                case 6:
                    return "Studio Room";
                case 7:
                    return "Suite";
                case 8:
                    return "Queen Room";
                case 9:
                    return "King Room";
                case 10:
                    return "President Room";
                default:
                    return "";
            }
        }
        public static int Reverse_TypeHotel(string hoteltype)
        {
            switch (hoteltype)
            {
                case "Hotel":
                    return 1;
                case "Motel":
                    return 2;
                case "Camping":
                    return 3;
                case "B&B":
                    return 4;
                case "Guest House":
                    return 5;
                case "Homestay":
                    return 6;
                case "Villa":
                    return 7;
                case "Apartment":
                    return 8;
                default:
                    return 0;
            }
        }
        public static string TypeHotel(int hoteltype)
        {
            switch (hoteltype)
            {
                case 1:
                    return "Hotel";
                case 2:
                    return "Motel";
                case 3:
                    return "Camping";
                case 4:
                    return "B&B";
                case 5:
                    return "Guest House";
                case 6:
                    return "Homestay";
                case 7:
                    return "Villa";
                case 8:
                    return "Apartment";
                default:
                    return "";
            }
        }
        #endregion

        public static void LabelChangeInt(System.Windows.Forms.Label lbl, int a)
        {
            lbl.Text = a.ToString();
        }
        public static void LoadForm(Form form, Panel displayPanel)
        {
            displayPanel.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            displayPanel.Controls.Add(form);
            form.Show();
        }
        //Load form into a Panel
        public static void RemoveEvent(Guna2Button b)
        {
            FieldInfo f1 = typeof(Control).GetField("EventClick", BindingFlags.Static | BindingFlags.NonPublic);

            object obj = f1.GetValue(b);
            PropertyInfo pi = b.GetType().GetProperty("Events", BindingFlags.NonPublic | BindingFlags.Instance);

            EventHandlerList list = (EventHandlerList)pi.GetValue(b, null);
            list.RemoveHandler(obj, list[obj]);
        }

        #region SQL Query
        public static SqlDataReader SqlRead(string query)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            return cmd.ExecuteReader();
        }
        public static int SqlUpdate(string query)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            int a = cmd.ExecuteNonQuery();
            conn.Close();
            return a;
        }
        public static int SqlScalar(string query)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
            int o;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;
                o = (int)cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
            finally
            {
                conn.Close();
            }
            return o;
        }
        #endregion
    }
}
