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
        public static Bitmap InteriorPicture(int j)
        {
            switch (j)
            {
                case 0:
                    return Console.Properties.Resources.AC;
                case 1:
                    return Console.Properties.Resources.Hairdryer;
                case 2:
                    return Console.Properties.Resources.Chair;
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
                    return "Hairdryer";
                case 2:
                    return "Chair";
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
    }

}
