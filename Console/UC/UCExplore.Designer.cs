namespace Console.UC
{
    partial class UCExplore
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
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ucExploreValue1 = new Console.UC.UCExploreValue();
            this.ucExploreValue2 = new Console.UC.UCExploreValue();
            this.flowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Location = new System.Drawing.Point(3, 28);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(322, 21);
            this.lblSubTitle.TabIndex = 4;
            this.lblSubTitle.Text = "These popular destinations have a lot to offer";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(153, 25);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Explore Vietnam";
            // 
            // flowPanel
            // 
            this.flowPanel.Controls.Add(this.ucExploreValue1);
            this.flowPanel.Controls.Add(this.ucExploreValue2);
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowPanel.Location = new System.Drawing.Point(0, 60);
            this.flowPanel.Margin = new System.Windows.Forms.Padding(10);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(1304, 198);
            this.flowPanel.TabIndex = 5;
            // 
            // ucExploreValue1
            // 
            this.ucExploreValue1.BackColor = System.Drawing.Color.Transparent;
            this.ucExploreValue1.Location = new System.Drawing.Point(3, 3);
            this.ucExploreValue1.Name = "ucExploreValue1";
            this.ucExploreValue1.Size = new System.Drawing.Size(163, 190);
            this.ucExploreValue1.TabIndex = 0;
            // 
            // ucExploreValue2
            // 
            this.ucExploreValue2.BackColor = System.Drawing.Color.Transparent;
            this.ucExploreValue2.Location = new System.Drawing.Point(172, 3);
            this.ucExploreValue2.Name = "ucExploreValue2";
            this.ucExploreValue2.Size = new System.Drawing.Size(163, 190);
            this.ucExploreValue2.TabIndex = 1;
            // 
            // UCExplore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "UCExplore";
            this.Size = new System.Drawing.Size(1304, 258);
            this.flowPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.FlowLayoutPanel flowPanel;
        private UCExploreValue ucExploreValue1;
        public System.Windows.Forms.Label lblSubTitle;
        public System.Windows.Forms.Label lblTitle;
        private UCExploreValue ucExploreValue2;
    }
}
