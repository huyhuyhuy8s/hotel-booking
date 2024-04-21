namespace Console
{
    partial class FDisplayForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelShow = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelShow
            // 
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShow.Location = new System.Drawing.Point(0, 0);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(1584, 761);
            this.panelShow.TabIndex = 0;
            // 
            // FDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 761);
            this.Controls.Add(this.panelShow);
            this.Name = "FDisplayForm";
            this.Text = "DisplayForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelShow;
    }
}