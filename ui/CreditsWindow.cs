﻿using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace BmLauncherWForm.ui
{
    public partial class CreditsWindow : Form
    {
        public CreditsWindow()
        {
            InitializeComponent();
        }

        private void rockCred_Click(object sender, EventArgs e)
        {
        }

        private void frofooLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://steamcommunity.com/id/frofoo/");
        }

        private void gpLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/c/GPUnity");
        }

        private void everLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Random number = new Random();

            if ((number.NextDouble() * (100.0 - 1.0) + 1.0) <= 10.0)
            {
                Process.Start("https://en.wikipedia.org/wiki/Baguette");
            }
            else
            {
                Process.Start("https://steamcommunity.com/id/EV3RGREEN");
            }

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://steamcommunity.com/sharedfiles/filedetails/?id=1159691355");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/neatodev/BmLauncher#batman-arkham-asylum---advanced-launcher");
        }
    }
}