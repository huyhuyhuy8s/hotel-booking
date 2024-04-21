using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console
{
    public partial class UCPeople : UserControl
    {
        int adult = 1, child = 0, room = 1;
        public UCPeople()
        {
            InitializeComponent();
        }

        #region GET && SET
        public int Adult { get { return adult; } }
        public int Child { get { return child; } }
        public int Room { get { return room; } }
        public Label LBLAdult
        {
            get { return lblAdultValue; }
            set { lblAdultValue = value; }
        }
        public Label LBLChild
        {
            get { return lblChildrenValue; }
            set { lblChildrenValue = value; }
        }
        public Label LBLRoom
        {
            get { return lblRoomValue; }
            set { lblRoomValue = value; }
        }
        #endregion


        private void btnAddMinus_Click(object sender, EventArgs e)
        {
            var button = (Guna.UI2.WinForms.Guna2Button)sender;
            string text = button.Text;
            string name = button.Name;
            if (name == "btnRoomAdd" || name == "btnRoomMinus")
            {
                if (text == "+")
                {
                    if (room < 10) CodeEdit.LabelChangeInt(lblRoomValue, ++room);
                }
                else
                {
                    if (room > 1) CodeEdit.LabelChangeInt(lblRoomValue, --room);
                }
            }
            else if (name == "btnAdultAdd" || name == "btnAdultMinus") 
            {
                if (text == "+")
                {
                    if (adult < 20) CodeEdit.LabelChangeInt(lblAdultValue, ++adult);
                }
                else
                {
                    if (adult > 1) CodeEdit.LabelChangeInt(lblAdultValue, --adult);
                }
            }
            else
            {
                if (text == "+")
                {
                    if (child < 20) CodeEdit.LabelChangeInt(lblChildrenValue, ++child);
                }
                else
                {
                    if (child > 1) CodeEdit.LabelChangeInt(lblChildrenValue, --child);
                }
            }
        }
    }
}
