using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace BmLauncherWForm
{
    public partial class BmLauncherForm : Form

    {
        public static BmLauncherForm thisForm;

        public BmLauncherForm()
        {
            thisForm = this;
            InitializeComponent();
            applyButton.Enabled = false;
        }

        private void texgroupButton_Click(object sender, EventArgs e)
        {
            Program.myFactory.applyTexfix();
        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            Program.myFactory.writeGraphFile();
            launchButton.Enabled = false;
            if (File.Exists("NVSetter.exe"))
            {
                File.Delete("NVSetter.exe");
            }

            using (Process launchBmGame = new Process())
            {
                launchBmGame.StartInfo.FileName = "ShippingPC-BmGame.exe";
                launchBmGame.StartInfo.CreateNoWindow = true;
                launchBmGame.Start();
                Application.Exit();
            }
        }

        private void credLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new CreditsWindow().ShowDialog();
        }

        private void keyButton_Click(object sender, EventArgs e)
        {
            Program.myFactory.keybinds.ShowDialog();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            Program.myFactory.writeGraphFile();
            applyButton.Enabled = false;
        }

        private void nvBox_CheckedChanged(object sender, EventArgs e)
        {
            if (nvBox.Checked)
            {
                aoBox.Enabled = false;
            }
            else
            {
                aoBox.Enabled = true;
            }

            applyButton.Enabled = true;
        }

        private void fullscreenBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            applyButton.Enabled = true;
        }

        private void resBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            applyButton.Enabled = true;
        }

        private void vsyncBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            applyButton.Enabled = true;
        }

        private void detailBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            applyButton.Enabled = true;
        }

        private void ultraButton_Click(object sender, EventArgs e)
        {
            Presets.setUltra();
            applyButton.Enabled = true;
        }

        private void optiButton_Click(object sender, EventArgs e)
        {
            Presets.setOptimized();
            applyButton.Enabled = true;
        }

        private void aaBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            applyButton.Enabled = true;
        }

        private void fogBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            applyButton.Enabled = true;
        }

        private void bloomBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            applyButton.Enabled = true;
        }

        private void lensFlareBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            applyButton.Enabled = true;
        }

        private void dofBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            applyButton.Enabled = true;
        }

        private void distBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            applyButton.Enabled = true;
        }

        private void mBlurBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            applyButton.Enabled = true;
        }

        private void memPoolBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            applyButton.Enabled = true;
        }

        private void anisoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            applyButton.Enabled = true;
        }

        private void sphericBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            applyButton.Enabled = true;
        }

        private void aoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            applyButton.Enabled = true;
        }

        private void dShadowBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            applyButton.Enabled = true;
        }

        private void texelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            applyButton.Enabled = true;
        }

        private void maxShadowBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            applyButton.Enabled = true;
        }

        private void physxBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            applyButton.Enabled = true;
        }

        private void disableIntroButton_Click(object sender, EventArgs e)
        {
            Program.myFactory.applyIntroFix();
        }

        private void maxSmoothTextBox_TextChanged(object sender, EventArgs e)
        {
            applyButton.Enabled = true;
        }
    }
}