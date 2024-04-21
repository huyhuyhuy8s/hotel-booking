namespace Console
{
    partial class UCPeople
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ccRoom = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.lblRoomValue = new System.Windows.Forms.Label();
            this.btnRoomAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnRoomMinus = new Guna.UI2.WinForms.Guna2Button();
            this.ccChildren = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.lblChildrenValue = new System.Windows.Forms.Label();
            this.btnChildrenAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnChildrenMinus = new Guna.UI2.WinForms.Guna2Button();
            this.ccAdult = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.lblAdultValue = new System.Windows.Forms.Label();
            this.btnAdultAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdultMinus = new Guna.UI2.WinForms.Guna2Button();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblChildren = new System.Windows.Forms.Label();
            this.lblAdult = new System.Windows.Forms.Label();
            this.ccRoom.SuspendLayout();
            this.ccChildren.SuspendLayout();
            this.ccAdult.SuspendLayout();
            this.SuspendLayout();
            // 
            // ccRoom
            // 
            this.ccRoom.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ccRoom.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ccRoom.BorderRadius = 10;
            this.ccRoom.BorderThickness = 1;
            this.ccRoom.Controls.Add(this.lblRoomValue);
            this.ccRoom.Controls.Add(this.btnRoomAdd);
            this.ccRoom.Controls.Add(this.btnRoomMinus);
            this.ccRoom.Location = new System.Drawing.Point(149, 110);
            this.ccRoom.Name = "ccRoom";
            this.ccRoom.Size = new System.Drawing.Size(147, 35);
            this.ccRoom.TabIndex = 9;
            this.ccRoom.Text = "guna2ContainerControl4";
            // 
            // lblRoomValue
            // 
            this.lblRoomValue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRoomValue.AutoSize = true;
            this.lblRoomValue.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomValue.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblRoomValue.Location = new System.Drawing.Point(65, 7);
            this.lblRoomValue.Name = "lblRoomValue";
            this.lblRoomValue.Size = new System.Drawing.Size(19, 21);
            this.lblRoomValue.TabIndex = 2;
            this.lblRoomValue.Text = "1";
            // 
            // btnRoomAdd
            // 
            this.btnRoomAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRoomAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnRoomAdd.BorderRadius = 10;
            this.btnRoomAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRoomAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRoomAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRoomAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRoomAdd.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRoomAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRoomAdd.ForeColor = System.Drawing.Color.White;
            this.btnRoomAdd.Location = new System.Drawing.Point(107, 0);
            this.btnRoomAdd.Name = "btnRoomAdd";
            this.btnRoomAdd.Size = new System.Drawing.Size(40, 35);
            this.btnRoomAdd.TabIndex = 1;
            this.btnRoomAdd.Text = "+";
            this.btnRoomAdd.Click += new System.EventHandler(this.btnAddMinus_Click);
            // 
            // btnRoomMinus
            // 
            this.btnRoomMinus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRoomMinus.BackColor = System.Drawing.Color.Transparent;
            this.btnRoomMinus.BorderRadius = 10;
            this.btnRoomMinus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRoomMinus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRoomMinus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRoomMinus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRoomMinus.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRoomMinus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRoomMinus.ForeColor = System.Drawing.Color.White;
            this.btnRoomMinus.Location = new System.Drawing.Point(0, 0);
            this.btnRoomMinus.Name = "btnRoomMinus";
            this.btnRoomMinus.Size = new System.Drawing.Size(40, 35);
            this.btnRoomMinus.TabIndex = 0;
            this.btnRoomMinus.Text = "-";
            this.btnRoomMinus.Click += new System.EventHandler(this.btnAddMinus_Click);
            // 
            // ccChildren
            // 
            this.ccChildren.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ccChildren.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ccChildren.BorderRadius = 10;
            this.ccChildren.BorderThickness = 1;
            this.ccChildren.Controls.Add(this.lblChildrenValue);
            this.ccChildren.Controls.Add(this.btnChildrenAdd);
            this.ccChildren.Controls.Add(this.btnChildrenMinus);
            this.ccChildren.Location = new System.Drawing.Point(149, 62);
            this.ccChildren.Name = "ccChildren";
            this.ccChildren.Size = new System.Drawing.Size(147, 35);
            this.ccChildren.TabIndex = 9;
            this.ccChildren.Text = "guna2ContainerControl2";
            // 
            // lblChildrenValue
            // 
            this.lblChildrenValue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblChildrenValue.AutoSize = true;
            this.lblChildrenValue.BackColor = System.Drawing.Color.Transparent;
            this.lblChildrenValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildrenValue.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblChildrenValue.Location = new System.Drawing.Point(65, 7);
            this.lblChildrenValue.Name = "lblChildrenValue";
            this.lblChildrenValue.Size = new System.Drawing.Size(19, 21);
            this.lblChildrenValue.TabIndex = 2;
            this.lblChildrenValue.Text = "0";
            // 
            // btnChildrenAdd
            // 
            this.btnChildrenAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnChildrenAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnChildrenAdd.BorderRadius = 10;
            this.btnChildrenAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChildrenAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChildrenAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChildrenAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChildrenAdd.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnChildrenAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChildrenAdd.ForeColor = System.Drawing.Color.White;
            this.btnChildrenAdd.Location = new System.Drawing.Point(107, 0);
            this.btnChildrenAdd.Name = "btnChildrenAdd";
            this.btnChildrenAdd.Size = new System.Drawing.Size(40, 35);
            this.btnChildrenAdd.TabIndex = 1;
            this.btnChildrenAdd.Text = "+";
            this.btnChildrenAdd.Click += new System.EventHandler(this.btnAddMinus_Click);
            // 
            // btnChildrenMinus
            // 
            this.btnChildrenMinus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnChildrenMinus.BackColor = System.Drawing.Color.Transparent;
            this.btnChildrenMinus.BorderRadius = 10;
            this.btnChildrenMinus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChildrenMinus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChildrenMinus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChildrenMinus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChildrenMinus.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnChildrenMinus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChildrenMinus.ForeColor = System.Drawing.Color.White;
            this.btnChildrenMinus.Location = new System.Drawing.Point(0, 0);
            this.btnChildrenMinus.Name = "btnChildrenMinus";
            this.btnChildrenMinus.Size = new System.Drawing.Size(40, 35);
            this.btnChildrenMinus.TabIndex = 0;
            this.btnChildrenMinus.Text = "-";
            this.btnChildrenMinus.Click += new System.EventHandler(this.btnAddMinus_Click);
            // 
            // ccAdult
            // 
            this.ccAdult.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ccAdult.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ccAdult.BorderRadius = 10;
            this.ccAdult.BorderThickness = 1;
            this.ccAdult.Controls.Add(this.lblAdultValue);
            this.ccAdult.Controls.Add(this.btnAdultAdd);
            this.ccAdult.Controls.Add(this.btnAdultMinus);
            this.ccAdult.Location = new System.Drawing.Point(149, 12);
            this.ccAdult.Name = "ccAdult";
            this.ccAdult.Size = new System.Drawing.Size(147, 35);
            this.ccAdult.TabIndex = 8;
            this.ccAdult.Text = "guna2ContainerControl3";
            // 
            // lblAdultValue
            // 
            this.lblAdultValue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAdultValue.AutoSize = true;
            this.lblAdultValue.BackColor = System.Drawing.Color.Transparent;
            this.lblAdultValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdultValue.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblAdultValue.Location = new System.Drawing.Point(65, 7);
            this.lblAdultValue.Name = "lblAdultValue";
            this.lblAdultValue.Size = new System.Drawing.Size(19, 21);
            this.lblAdultValue.TabIndex = 2;
            this.lblAdultValue.Text = "1";
            // 
            // btnAdultAdd
            // 
            this.btnAdultAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdultAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdultAdd.BorderRadius = 10;
            this.btnAdultAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdultAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdultAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdultAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdultAdd.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdultAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdultAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdultAdd.Location = new System.Drawing.Point(107, 0);
            this.btnAdultAdd.Name = "btnAdultAdd";
            this.btnAdultAdd.Size = new System.Drawing.Size(40, 35);
            this.btnAdultAdd.TabIndex = 1;
            this.btnAdultAdd.Text = "+";
            this.btnAdultAdd.Click += new System.EventHandler(this.btnAddMinus_Click);
            // 
            // btnAdultMinus
            // 
            this.btnAdultMinus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdultMinus.BackColor = System.Drawing.Color.Transparent;
            this.btnAdultMinus.BorderRadius = 10;
            this.btnAdultMinus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdultMinus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdultMinus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdultMinus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdultMinus.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdultMinus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdultMinus.ForeColor = System.Drawing.Color.White;
            this.btnAdultMinus.Location = new System.Drawing.Point(0, 0);
            this.btnAdultMinus.Name = "btnAdultMinus";
            this.btnAdultMinus.Size = new System.Drawing.Size(40, 35);
            this.btnAdultMinus.TabIndex = 0;
            this.btnAdultMinus.Text = "-";
            this.btnAdultMinus.Click += new System.EventHandler(this.btnAddMinus_Click);
            // 
            // lblRoom
            // 
            this.lblRoom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.ForeColor = System.Drawing.Color.White;
            this.lblRoom.Location = new System.Drawing.Point(26, 115);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(65, 21);
            this.lblRoom.TabIndex = 7;
            this.lblRoom.Text = "Rooms:";
            // 
            // lblChildren
            // 
            this.lblChildren.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblChildren.AutoSize = true;
            this.lblChildren.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildren.ForeColor = System.Drawing.Color.White;
            this.lblChildren.Location = new System.Drawing.Point(26, 68);
            this.lblChildren.Name = "lblChildren";
            this.lblChildren.Size = new System.Drawing.Size(82, 21);
            this.lblChildren.TabIndex = 6;
            this.lblChildren.Text = "Childrens:";
            // 
            // lblAdult
            // 
            this.lblAdult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAdult.AutoSize = true;
            this.lblAdult.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdult.ForeColor = System.Drawing.Color.White;
            this.lblAdult.Location = new System.Drawing.Point(26, 21);
            this.lblAdult.Name = "lblAdult";
            this.lblAdult.Size = new System.Drawing.Size(61, 21);
            this.lblAdult.TabIndex = 5;
            this.lblAdult.Text = "Adults:";
            // 
            // UCPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lblAdult);
            this.Controls.Add(this.lblChildren);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.ccAdult);
            this.Controls.Add(this.ccChildren);
            this.Controls.Add(this.ccRoom);
            this.Name = "UCPeople";
            this.Size = new System.Drawing.Size(322, 157);
            this.ccRoom.ResumeLayout(false);
            this.ccRoom.PerformLayout();
            this.ccChildren.ResumeLayout(false);
            this.ccChildren.PerformLayout();
            this.ccAdult.ResumeLayout(false);
            this.ccAdult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ContainerControl ccRoom;
        private System.Windows.Forms.Label lblRoomValue;
        private Guna.UI2.WinForms.Guna2Button btnRoomAdd;
        private Guna.UI2.WinForms.Guna2Button btnRoomMinus;
        private Guna.UI2.WinForms.Guna2ContainerControl ccChildren;
        private System.Windows.Forms.Label lblChildrenValue;
        private Guna.UI2.WinForms.Guna2Button btnChildrenAdd;
        private Guna.UI2.WinForms.Guna2Button btnChildrenMinus;
        private Guna.UI2.WinForms.Guna2ContainerControl ccAdult;
        private System.Windows.Forms.Label lblAdultValue;
        private Guna.UI2.WinForms.Guna2Button btnAdultAdd;
        private Guna.UI2.WinForms.Guna2Button btnAdultMinus;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblChildren;
        private System.Windows.Forms.Label lblAdult;
    }
}
