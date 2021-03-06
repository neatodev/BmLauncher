﻿using BmLauncherWForm.data;
using NLog;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;
using BmLauncherWForm.infrastructure;

namespace BmLauncherWForm.ui
{
    public partial class BmLauncherForm : Form

    {
        // logger for easy debugging
        private static Logger logger = LogManager.GetCurrentClassLogger();

        private static bool firstLaunch;
        private static bool readWarning;

        public bool ChangedConfig;

        public BmLauncherForm()
        {
            InitializeComponent();
        }

        private void texgroupButton_Click(object sender, EventArgs e)
        {
            Program.MyFactory.applyTexfix();
        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            if (ChangedConfig)
            {
                Program.MyFactory.writeGraphFile();
            }
            else
            {
                logger.Info("No configuration changes made.");
            }
            launchButton.Enabled = false;

            using (Process launchBmGame = new Process())
            {
                Factory.InputFileInfo.IsReadOnly = true;
                launchBmGame.StartInfo.FileName = "ShippingPC-BmGame.exe";
                launchBmGame.StartInfo.CreateNoWindow = true;
                launchBmGame.Start();
                logger.Info("Launching game application. Logging has concluded at {0}, on {1}.",
                    DateTime.Now.ToString("HH:mm:ss"), DateTime.Now.ToString("D", new CultureInfo("en-GB")));
                LogManager.Flush();
                Application.Exit();
            }
        }

        private void credLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new CreditsWindow().ShowDialog();
        }

        private void keyButton_Click(object sender, EventArgs e)
        {
            Program.MyFactory.Keybinds.ShowDialog();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            Program.MyFactory.writeGraphFile();
            applyButton.Enabled = false;
            ChangedConfig = false;
        }

        private void nvBox_CheckedChanged(object sender, EventArgs e)
        {
            aoBox.Enabled = !nvBox.Checked;
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void fullscreenBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void resBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void vsyncBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void detailBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void ultraButton_Click(object sender, EventArgs e)
        {
            Presets.setUltra();
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void optiButton_Click(object sender, EventArgs e)
        {
            Presets.setOptimized();
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void aaBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void fogBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void bloomBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void lensFlareBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void dofBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void distBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void mBlurBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void memPoolBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void anisoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void sphericBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void aoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void dShadowBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void texelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void maxShadowBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void physxBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!firstLaunch)
            {
                firstLaunch = true;
                return;
            }

            if (physxBox.SelectedIndex == 2 && !readWarning)
            {
                MessageBox.Show(
                    "Changing your PhysX settings to \'High\' will result in\r\nhuge frame drops for certain" +
                    " sections of the game.\r\nIt is recommended to select \'Medium\' settings.", @"PhysX Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                readWarning = true;
            }
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void disableIntroButton_Click(object sender, EventArgs e)
        {
            ChangedConfig = true;
            Program.MyFactory.applyIntroFix();
        }

        private void maxSmoothTextBox_TextChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void langBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }

        private void frameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ChangedConfig = true;
            applyButton.Enabled = true;
        }
    }
}