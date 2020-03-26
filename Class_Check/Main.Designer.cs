namespace Class_Check
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Inv_Lnk = new System.Windows.Forms.LinkLabel();
            this.Chk_Lnk = new System.Windows.Forms.LinkLabel();
            this.Mod_Lnk = new System.Windows.Forms.LinkLabel();
            this.Rpt_Lnk = new System.Windows.Forms.LinkLabel();
            this.Set_Lnk = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Inv_Lnk
            // 
            this.Inv_Lnk.AutoSize = true;
            this.Inv_Lnk.Location = new System.Drawing.Point(37, 68);
            this.Inv_Lnk.Name = "Inv_Lnk";
            this.Inv_Lnk.Size = new System.Drawing.Size(102, 17);
            this.Inv_Lnk.TabIndex = 0;
            this.Inv_Lnk.TabStop = true;
            this.Inv_Lnk.Text = "Take Inventory";
            this.Inv_Lnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Inv_Lnk_LinkClicked);
            // 
            // Chk_Lnk
            // 
            this.Chk_Lnk.AutoSize = true;
            this.Chk_Lnk.Location = new System.Drawing.Point(37, 29);
            this.Chk_Lnk.Name = "Chk_Lnk";
            this.Chk_Lnk.Size = new System.Drawing.Size(134, 17);
            this.Chk_Lnk.TabIndex = 1;
            this.Chk_Lnk.TabStop = true;
            this.Chk_Lnk.Text = "Classroom Checklist";
            this.Chk_Lnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Chk_Lnk_LinkClicked);
            // 
            // Mod_Lnk
            // 
            this.Mod_Lnk.AutoSize = true;
            this.Mod_Lnk.Location = new System.Drawing.Point(37, 103);
            this.Mod_Lnk.Name = "Mod_Lnk";
            this.Mod_Lnk.Size = new System.Drawing.Size(111, 17);
            this.Mod_Lnk.TabIndex = 2;
            this.Mod_Lnk.TabStop = true;
            this.Mod_Lnk.Text = "Modify Inventory";
            this.Mod_Lnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Mod_Lnk_LinkClicked);
            // 
            // Rpt_Lnk
            // 
            this.Rpt_Lnk.AutoSize = true;
            this.Rpt_Lnk.Location = new System.Drawing.Point(37, 139);
            this.Rpt_Lnk.Name = "Rpt_Lnk";
            this.Rpt_Lnk.Size = new System.Drawing.Size(91, 17);
            this.Rpt_Lnk.TabIndex = 3;
            this.Rpt_Lnk.TabStop = true;
            this.Rpt_Lnk.Text = "Quick Report";
            this.Rpt_Lnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Rpt_Lnk_LinkClicked);
            // 
            // Set_Lnk
            // 
            this.Set_Lnk.AutoSize = true;
            this.Set_Lnk.Location = new System.Drawing.Point(37, 173);
            this.Set_Lnk.Name = "Set_Lnk";
            this.Set_Lnk.Size = new System.Drawing.Size(59, 17);
            this.Set_Lnk.TabIndex = 4;
            this.Set_Lnk.TabStop = true;
            this.Set_Lnk.Text = "Settings";
            this.Set_Lnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Set_Lnk_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Set_Lnk);
            this.Controls.Add(this.Rpt_Lnk);
            this.Controls.Add(this.Mod_Lnk);
            this.Controls.Add(this.Chk_Lnk);
            this.Controls.Add(this.Inv_Lnk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassCheck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Inv_Lnk;
        private System.Windows.Forms.LinkLabel Chk_Lnk;
        private System.Windows.Forms.LinkLabel Mod_Lnk;
        private System.Windows.Forms.LinkLabel Rpt_Lnk;
        private System.Windows.Forms.LinkLabel Set_Lnk;
    }
}

