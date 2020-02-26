namespace BmLauncherWForm
{
    /// <summary>
    ///     Simple Class to store values for the presets.
    /// </summary>
    static class Presets
    {
        private static void setCommon()
        {
            Program.client.detailBox.SelectedIndex = 2;
            Program.client.aaBox.SelectedIndex = 0;
            Program.client.fogBox.SelectedIndex = 1;
            Program.client.anisoBox.SelectedIndex = 2;
            Program.client.aoBox.SelectedIndex = 0;
            Program.client.sphericBox.SelectedIndex = 1;
            Program.client.bloomBox.SelectedIndex = 1;
            Program.client.lensFlareBox.SelectedIndex = 1;
            Program.client.dShadowBox.SelectedIndex = 1;
            Program.client.dofBox.SelectedIndex = 1;
            Program.client.distBox.SelectedIndex = 1;
            Program.client.memPoolBox.SelectedIndex = 0;
            Program.client.mBlurBox.SelectedIndex = 1;
        }

        public static void setUltra()
        {
            setCommon();
            Program.client.maxShadowBox.SelectedIndex = 2;
            Program.client.texelBox.SelectedIndex = 2;
            Program.client.physxBox.SelectedIndex = 2;
        }

        public static void setOptimized()
        {
            setCommon();
            Program.client.maxShadowBox.SelectedIndex = 1;
            Program.client.texelBox.SelectedIndex = 1;
            Program.client.physxBox.SelectedIndex = 0;
        }
    }
}