using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace BmLauncherWForm
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
            Process.Start("https://steamcommunity.com/id/GPUnity");
        }

        private void everLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://steamcommunity.com/id/EV3RGREEN");
        }

        private void CreditsWindow_Load(object sender, EventArgs e)
        {
        }
    }
}