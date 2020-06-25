using System;

namespace BmLauncherWForm
{
    /// <summary>
    ///     Helper Class for Graphics. Used to change parameters in Graphics class in accordance with user input.
    /// </summary>
    static class GraphicsWriter
    {
        private static bool isHBAO;

        public static void writeAll()
        {
            setLang();
            setAAMode();
            setAO();
            setAnisotropy();
            setBloom();
            setBlur();
            setDOF();
            setDetailMode();
            setDist();
            setDynamicShadows();
            setFogVolumes();
            setFullScreen();
            setHbaoPlus();
            setLensFlares();
            setMaxShadowRes();
            setMaxSmoothedFrames();
            setMemoryPools();
            setPhysX();
            setRes();
            setShadowTexels();
            setSphericalHarmonic();
            setVsync();
            setThreadLag();
        }

        private static void setRes()
        {
            Object selectedRes = Program.client.resBox.SelectedItem;
            string resX = selectedRes.ToString().Substring(0, selectedRes.ToString().LastIndexOf("x"));
            string resY = selectedRes.ToString().Substring(selectedRes.ToString().LastIndexOf("x") + 1);

            Graphics.setResolutionX(resX);
            Graphics.setResolutionY(resY);
        }

        private static void setLang()
        {
            int caseValue = Program.client.langBox.SelectedIndex;
            switch (caseValue)
            {
                case 0:
                    Graphics.setLanguage("int");
                    break;
                case 1:
                    Graphics.setLanguage("deu");
                    break;
                case 2:
                    Graphics.setLanguage("fra");
                    break;
                case 3:
                    Graphics.setLanguage("ita");
                    break;
                case 4:
                    Graphics.setLanguage("esn");
                    break;
            }
        }

        private static void setFullScreen()
        {
            Graphics.setFullScreen(Program.client.fullscreenBox.SelectedIndex == 0 ? "False" : "True");
        }

        private static void setVsync()
        {
            Graphics.setVsync(Program.client.vsyncBox.SelectedIndex == 0 ? "False" : "True");
        }

        private static void setFogVolumes()
        {
            Graphics.setFogVolumes(Program.client.fogBox.SelectedIndex == 0 ? "False" : "True");
        }

        private static void setBloom()
        {
            if (Program.client.bloomBox.SelectedIndex == 0)
            {
                Graphics.setBloom("False");
                Graphics.setHighQualityBloom("False");
            }
            else
            {
                Graphics.setBloom("True");
                Graphics.setHighQualityBloom("True");
            }
        }

        private static void setLensFlares()
        {
            Graphics.setLensFlares(Program.client.lensFlareBox.SelectedIndex == 0 ? "False" : "True");
        }

        private static void setDOF()
        {
            Graphics.setDepthOfField(Program.client.dofBox.SelectedIndex == 0 ? "False" : "True");
        }

        private static void setDist()
        {
            Graphics.setDistortion(Program.client.distBox.SelectedIndex == 0 ? "False" : "True");
        }

        private static void setBlur()
        {
            Graphics.setMotionBlur(Program.client.mBlurBox.SelectedIndex == 0 ? "False" : "True");
        }

        private static void setAO()
        {
            if ((Program.client.aoBox.SelectedIndex == 0 && Program.client.aoBox.Enabled) ||
                !Program.client.aoBox.Enabled)
            {
                Graphics.setAmbientOcclusion("False");
            }
            else
            {
                Graphics.setAmbientOcclusion("True");
            }
        }

        private static void setSphericalHarmonic()
        {
            Graphics.setDisableSphericalHarmonicLights(Program.client.sphericBox.SelectedIndex == 0 ? "True" : "False");
        }

        private static void setDynamicShadows()
        {
            Graphics.setDynamicShadows(Program.client.dShadowBox.SelectedIndex == 0 ? "False" : "True");
        }

        private static void setHbaoPlus()
        {
            if (!Program.client.gpInfoLabel.Text.Contains("NVIDIA"))
            {
                return;
            }

            Program.nvWorker.setNVSettings();
            if (NvidiaWorker.hasHBAO || !Program.client.nvBox.Checked || isHBAO)
            {
                return;
            }

            Program.myFactory.execNVSetter();
            isHBAO = true;
        }

        private static void setMaxSmoothedFrames()
        {
            if (Program.client.maxSmoothTextBox.Text.Trim().Equals("") ||
                Int16.Parse(Program.client.maxSmoothTextBox.Text.Trim()) < 25)
            {
                Program.client.maxSmoothTextBox.Text = "62";
                Graphics.setMaxSmoothedFramerate("62.000000");
            }
            else
            {
                Graphics.setMaxSmoothedFramerate(Program.client.maxSmoothTextBox.Text.Trim() + ".000000");
            }
        }

        private static void setDetailMode()
        {
            int caseValue = Program.client.detailBox.SelectedIndex;

            switch (caseValue)
            {
                case 0:
                    Graphics.setDetailMode("0");
                    break;
                case 1:
                    Graphics.setDetailMode("1");
                    break;
                case 2:
                    Graphics.setDetailMode("2");
                    break;
            }
        }

        private static void setAAMode()
        {
            int caseValue = Program.client.aaBox.SelectedIndex;

            switch (caseValue)
            {
                case 0:
                    Graphics.setMultiSampling("1");
                    break;
                case 1:
                    Graphics.setMultiSampling("2");
                    break;
                case 2:
                    Graphics.setMultiSampling("4");
                    break;
                case 3:
                    Graphics.setMultiSampling("10");
                    break;
            }
        }

        private static void setAnisotropy()
        {
            int caseValue = Program.client.anisoBox.SelectedIndex;

            switch (caseValue)
            {
                case 0:
                    Graphics.setMaxAnisotropy("4");
                    break;
                case 1:
                    Graphics.setMaxAnisotropy("8");
                    break;
                case 2:
                    Graphics.setMaxAnisotropy("16");
                    break;
            }
        }

        private static void setMemoryPools()
        {
            int caseValue = Program.client.memPoolBox.SelectedIndex;

            switch (caseValue)
            {
                case 0:
                    Graphics.setMemoryPoolsValue("512");
                    break;
                case 1:
                    Graphics.setMemoryPoolsValue("1024");
                    break;
            }
        }

        private static void setShadowTexels()
        {
            int caseValue = Program.client.texelBox.SelectedIndex;

            switch (caseValue)
            {
                case 0:
                    Graphics.setShadowTexels("1.273240");
                    break;
                case 1:
                    Graphics.setShadowTexels("2.000000");
                    break;
                case 2:
                    Graphics.setShadowTexels("4.000000");
                    break;
            }
        }

        private static void setMaxShadowRes()
        {
            int caseValue = Program.client.maxShadowBox.SelectedIndex;

            switch (caseValue)
            {
                case 0:
                    Graphics.setMaxShadowResolution("1024");
                    break;
                case 1:
                    Graphics.setMaxShadowResolution("2048");
                    break;
                case 2:
                    Graphics.setMaxShadowResolution("4096");
                    break;
            }
        }

        private static void setPhysX()
        {
            int caseValue = Program.client.physxBox.SelectedIndex;

            switch (caseValue)
            {
                case 0:
                    Graphics.setPhysX("0");
                    break;
                case 1:
                    Graphics.setPhysX("1");
                    break;
                case 2:
                    Graphics.setPhysX("2");
                    break;
            }
        }

        private static void setThreadLag()
        {
            Graphics.setFrameThreadLag(Program.client.frameCheckBox.Checked ? "True" : "False");
        }
    }
}