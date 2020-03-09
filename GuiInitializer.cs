using System;

namespace BmLauncherWForm
{
    /// <summary>
    ///     Graphics helper class. Initializes the GUI with correct values from BmEngine file
    /// </summary>
    static class GuiInitializer
    {
        public static void init()
        {
            // all false/true values
            Program.client.fullscreenBox.SelectedIndex =
                Graphics.isFullScreen().Equals("False", StringComparison.InvariantCultureIgnoreCase) ? 0 : 1;
            Program.client.vsyncBox.SelectedIndex =
                Graphics.isVsync().Equals("False", StringComparison.InvariantCultureIgnoreCase) ? 0 : 1;
            Program.client.dofBox.SelectedIndex =
                Graphics.isDepthOfField().Equals("False", StringComparison.InvariantCultureIgnoreCase) ? 0 : 1;
            Program.client.aoBox.SelectedIndex =
                Graphics.isAmbientOcclusion().Equals("False", StringComparison.InvariantCultureIgnoreCase) ? 0 : 1;
            Program.client.lensFlareBox.SelectedIndex =
                Graphics.isLensFlares().Equals("False", StringComparison.InvariantCultureIgnoreCase) ? 0 : 1;
            Program.client.mBlurBox.SelectedIndex =
                Graphics.isMotionBlur().Equals("False", StringComparison.InvariantCultureIgnoreCase) ? 0 : 1;
            Program.client.bloomBox.SelectedIndex =
                Graphics.isBloom().Equals("False", StringComparison.InvariantCultureIgnoreCase) ? 0 : 1;
            Program.client.dShadowBox.SelectedIndex =
                Graphics.isDynamicShadows().Equals("False", StringComparison.InvariantCultureIgnoreCase) ? 0 : 1;
            Program.client.sphericBox.SelectedIndex = Graphics.isDisableSphericalHarmonicLights()
                .Equals("True", StringComparison.InvariantCultureIgnoreCase)
                ? 0
                : 1;
            Program.client.fogBox.SelectedIndex =
                Graphics.isFogVolumes().Equals("False", StringComparison.InvariantCultureIgnoreCase) ? 0 : 1;
            Program.client.distBox.SelectedIndex =
                Graphics.isDistortion().Equals("False", StringComparison.InvariantCultureIgnoreCase) ? 0 : 1;
            Program.client.frameCheckBox.Checked = Graphics.getFrameThreadLag().Equals("True");
            // everything else
            initLang();
            initAA();
            initPhysx();
            initAnisotropy();
            initDetailmode();
            initShadowTexels();
            initShadowRes();
            initMaxSmoothedFrames();
            initMemoryPoolsValue();
            initResolutions();
            initHBAONVIDIA();
        }

        private static void initLang()
        {
            if (Graphics.getLanguage().Equals("int"))
            {
                Program.client.langBox.SelectedIndex = 0;
            }

            if (Graphics.getLanguage().Equals("deu"))
            {
                Program.client.langBox.SelectedIndex = 1;
            }

            if (Graphics.getLanguage().Equals("fra"))
            {
                Program.client.langBox.SelectedIndex = 2;
            }

            if (Graphics.getLanguage().Equals("ita"))
            {
                Program.client.langBox.SelectedIndex = 3;
            }

            if (Graphics.getLanguage().Equals("esn"))
            {
                Program.client.langBox.SelectedIndex = 4;
            }
        }

        private static void initAA()
        {

            switch (Int16.Parse(Graphics.getMultiSampling()))
            {
                case 1:
                    Program.client.aaBox.SelectedIndex = 0;
                    break;
                case 2:
                    Program.client.aaBox.SelectedIndex = 1;
                    break;
                case 4:
                    Program.client.aaBox.SelectedIndex = 2;
                    break;
                case 10:
                    Program.client.aaBox.SelectedIndex = 3;
                    break;
            }
        }

        private static void initPhysx()
        {

            switch (Int16.Parse(Graphics.getPhysX()))
            {
                case 0:
                    Program.client.physxBox.SelectedIndex = 0;
                    break;
                case 1:
                    Program.client.physxBox.SelectedIndex = 1;
                    break;
                case 2:
                    Program.client.physxBox.SelectedIndex = 2;
                    break;
            }
        }

        private static void initAnisotropy()
        {

            switch (Int16.Parse(Graphics.getMaxAnisotropy()))
            {
                case 4:
                    Program.client.anisoBox.SelectedIndex = 0;
                    break;
                case 8:
                    Program.client.anisoBox.SelectedIndex = 1;
                    break;
                case 16:
                    Program.client.anisoBox.SelectedIndex = 2;
                    break;
            }
        }

        private static void initDetailmode()
        {

            switch (Int16.Parse(Graphics.getDetailMode()))
            {
                case 0:
                    Program.client.detailBox.SelectedIndex = 0;
                    break;
                case 1:
                    Program.client.detailBox.SelectedIndex = 1;
                    break;
                case 2:
                    Program.client.detailBox.SelectedIndex = 2;
                    break;
            }
        }

        private static void initShadowTexels()
        {

            switch (Int16.Parse(Graphics.getShadowTexels().Substring(0, 1)))
            {
                case 1:
                    Program.client.texelBox.SelectedIndex = 0;
                    break;
                case 2:
                    Program.client.texelBox.SelectedIndex = 1;
                    break;
                case 4:
                    Program.client.texelBox.SelectedIndex = 2;
                    break;
            }
        }

        private static void initShadowRes()
        {

            switch (Int16.Parse(Graphics.getMaxShadowResolution()))
            {
                case 1024:
                    Program.client.maxShadowBox.SelectedIndex = 0;
                    break;
                case 2048:
                    Program.client.maxShadowBox.SelectedIndex = 1;
                    break;
                case 4096:
                    Program.client.maxShadowBox.SelectedIndex = 2;
                    break;
            }
        }

        private static void initMaxSmoothedFrames()
        {
            Program.client.maxSmoothTextBox.Text = Graphics.getMaxSmoothedFramerate()
                .Substring(0, Graphics.getMaxSmoothedFramerate().LastIndexOf("."));
        }

        private static void initMemoryPoolsValue()
        {

            switch (Int16.Parse(Graphics.getMemoryPoolsValue()))
            {
                case 512:
                    Program.client.memPoolBox.SelectedIndex = 0;
                    break;
                case 1024:
                    Program.client.memPoolBox.SelectedIndex = 1;
                    break;
            }
        }

        private static void initResolutions()
        {
            foreach (string resolution in SysResolutions.resolutionList)
            {
                Program.client.resBox.Items.Add(resolution);
            }

            string myResolution = Graphics.getResolutionX() + "x" + Graphics.getResolutionY();

            foreach (string res in Program.client.resBox.Items)
            {
                if (!res.Equals(myResolution))
                {
                    continue;
                }

                int index = Program.client.resBox.Items.IndexOf(res);
                Program.client.resBox.SelectedIndex = index;
            }
        }

        /// <summary>
        ///     Initializes NVIDIA component, only if NVIDIA card is found.
        ///     Sets displayed tooltips accordingly.
        /// </summary>
        private static void initHBAONVIDIA()
        {
            if (Program.client.gpInfoLabel.Text.Contains("NVIDIA"))
            {
                Program.nvWorker = new NvidiaWorker();
                Program.client.nvBox.Enabled = true;
                Program.client.nvidiaToolTip.Active = true;
            }
            else
            {
                Program.client.amdToolTip.Active = true;
                Program.client.amdToolTip.ShowAlways = true;
                Program.client.nvBox.Enabled = false;
            }
        }
    }
}