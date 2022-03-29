namespace BmLauncherWForm.data
{
    /// <summary>
    ///     Simple Class to store values for the presets.
    /// </summary>
    internal static class Presets
    {
        private static void setCommon()
        {
            Program.Client.detailBox.SelectedIndex = 2;
            Program.Client.fogBox.SelectedIndex = 1;
            Program.Client.anisoBox.SelectedIndex = 2;
            Program.Client.aoBox.SelectedIndex = 0;
            Program.Client.sphericBox.SelectedIndex = 1;
            Program.Client.bloomBox.SelectedIndex = 1;
            Program.Client.lensFlareBox.SelectedIndex = 1;
            Program.Client.dShadowBox.SelectedIndex = 1;
            Program.Client.dofBox.SelectedIndex = 1;
            Program.Client.distBox.SelectedIndex = 1;
            Program.Client.memPoolBox.SelectedIndex = 0;
        }

        public static void setUltra()
        {
            setCommon();
            Program.Client.aaBox.SelectedIndex = 2;
            Program.Client.maxShadowBox.SelectedIndex = 2;
            Program.Client.texelBox.SelectedIndex = 2;
            Program.Client.physxBox.SelectedIndex = Program.Client.gpInfoLabel.Text.Contains("NVIDIA") ? 1 : 0;
        }

        public static void setOptimized()
        {
            setCommon();
            Program.Client.aaBox.SelectedIndex = 1;
            Program.Client.maxShadowBox.SelectedIndex = 1;
            Program.Client.texelBox.SelectedIndex = 1;
            Program.Client.physxBox.SelectedIndex = 0;
        }
    }
}