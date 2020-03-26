namespace Class_Check
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.Hom_Lnk = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Hom_Lnk
            // 
            this.Hom_Lnk.AutoSize = true;
            this.Hom_Lnk.Location = new System.Drawing.Point(677, 52);
            this.Hom_Lnk.Name = "Hom_Lnk";
            this.Hom_Lnk.Size = new System.Drawing.Size(45, 17);
            this.Hom_Lnk.TabIndex = 0;
            this.Hom_Lnk.TabStop = true;
            this.Hom_Lnk.Text = "Home";
            this.Hom_Lnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Hom_Lnk_LinkClicked);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Hom_Lnk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Hom_Lnk;
    }
}