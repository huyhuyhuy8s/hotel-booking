using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console.UC
{
    public partial class UCRoomManageValue : UserControl
    {
        public UCRoomManageValue()
        {
            InitializeComponent();
        }
        #region GET & SET
        public Guna2ContainerControl CCValue
        {
            get { return ccValue; }
            set { ccValue = value; }
        }
        public Guna2CustomCheckBox CheckBox
        {
            get { return cbCheck; }
            set { cbCheck = value; }
        }
        public Guna2Button More
        {
            get { return btnMore; }
            set { btnMore = value; }
        }
        public Label RoomId
        {
            get { return lblRoomId; }
            set { lblRoomId = value; }
        }
        public Label Type
        {
            get { return lblType; }
            set { lblType = value; }
        }
        public Label Id
        {
            get { return lblId; }
            set { lblId = value; }
        }
        public Label RoomName
        {
            get { return lblName; }
            set { lblName = value; }
        }
        public Label No
        {
            get { return lblNo; }
            set { lblNo = value; }
        }
        public Label Bed
        {
            get { return lblBed; }
            set { lblBed = value; }
        }
        public Label Person
        {
            get { return lblPerson; }
            set { lblPerson = value; }
        }
        public Label Price
        {
            get { return lblPrice; }
            set { lblPrice = value; }
        }
        public Label Area
        {
            get { return lblArea; }
            set { lblArea = value; }
        }
        #endregion
    }
}
