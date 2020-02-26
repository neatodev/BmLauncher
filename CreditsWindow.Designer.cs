namespace BmLauncherWForm
{
    partial class CreditsWindow
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
            this.rockCred = new System.Windows.Forms.Label();
            this.credBox = new System.Windows.Forms.GroupBox();
            this.writtenLabel = new System.Windows.Forms.Label();
            this.everLabel = new System.Windows.Forms.LinkLabel();
            this.gpLabel = new System.Windows.Forms.LinkLabel();
            this.collabLabel = new System.Windows.Forms.Label();
            this.frofooLabel = new System.Windows.Forms.LinkLabel();
            this.credBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // rockCred
            // 
            this.rockCred.AutoSize = true;
            this.rockCred.Location = new System.Drawing.Point(9, 9);
            this.rockCred.Name = "rockCred";
            this.rockCred.Size = new System.Drawing.Size(186, 13);
            this.rockCred.TabIndex = 0;
            this.rockCred.Text = "Game created by Rocksteady Studios";
            this.rockCred.Click += new System.EventHandler(this.rockCred_Click);
            // 
            // credBox
            // 
            this.credBox.Controls.Add(this.writtenLabel);
            this.credBox.Controls.Add(this.everLabel);
            this.credBox.Controls.Add(this.gpLabel);
            this.credBox.Controls.Add(this.collabLabel);
            this.credBox.Controls.Add(this.frofooLabel);
            this.credBox.Location = new System.Drawing.Point(12, 25);
            this.credBox.Name = "credBox";
            this.credBox.Size = new System.Drawing.Size(183, 91);
            this.credBox.TabIndex = 1;
            this.credBox.TabStop = false;
            // 
            // writtenLabel
            // 
            this.writtenLabel.AutoSize = true;
            this.writtenLabel.Location = new System.Drawing.Point(6, 15);
            this.writtenLabel.Name = "writtenLabel";
            this.writtenLabel.Size = new System.Drawing.Size(110, 13);
            this.writtenLabel.TabIndex = 4;
            this.writtenLabel.Text = "Application written by:";
            // 
            // everLabel
            // 
            this.everLabel.AutoSize = true;
            this.everLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.everLabel.Location = new System.Drawing.Point(6, 74);
            this.everLabel.Name = "everLabel";
            this.everLabel.Size = new System.Drawing.Size(74, 13);
            this.everLabel.TabIndex = 3;
            this.everLabel.TabStop = true;
            this.everLabel.Text = "EVERGREEN";
            this.everLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.everLabel_LinkClicked);
            // 
            // gpLabel
            // 
            this.gpLabel.AutoSize = true;
            this.gpLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.gpLabel.Location = new System.Drawing.Point(6, 59);
            this.gpLabel.Name = "gpLabel";
            this.gpLabel.Size = new System.Drawing.Size(46, 13);
            this.gpLabel.TabIndex = 2;
            this.gpLabel.TabStop = true;
            this.gpLabel.Text = "GPUnity";
            this.gpLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gpLabel_LinkClicked);
            // 
            // collabLabel
            // 
            this.collabLabel.AutoSize = true;
            this.collabLabel.Location = new System.Drawing.Point(6, 45);
            this.collabLabel.Name = "collabLabel";
            this.collabLabel.Size = new System.Drawing.Size(105, 13);
            this.collabLabel.TabIndex = 1;
            this.collabLabel.Text = "In Collaboration with:";
            // 
            // frofooLabel
            // 
            this.frofooLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.frofooLabel.AutoSize = true;
            this.frofooLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.frofooLabel.Location = new System.Drawing.Point(7, 29);
            this.frofooLabel.Name = "frofooLabel";
            this.frofooLabel.Size = new System.Drawing.Size(34, 13);
            this.frofooLabel.TabIndex = 0;
            this.frofooLabel.TabStop = true;
            this.frofooLabel.Text = "frofoo";
            this.frofooLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.frofooLabel_LinkClicked);
            // 
            // CreditsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 122);
            this.Controls.Add(this.credBox);
            this.Controls.Add(this.rockCred);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreditsWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credits";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CreditsWindow_Load);
            this.credBox.ResumeLayout(false);
            this.credBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rockCred;
        private System.Windows.Forms.GroupBox credBox;
        private System.Windows.Forms.LinkLabel everLabel;
        private System.Windows.Forms.LinkLabel gpLabel;
        private System.Windows.Forms.Label collabLabel;
        private System.Windows.Forms.LinkLabel frofooLabel;
        private System.Windows.Forms.Label writtenLabel;
    }
}