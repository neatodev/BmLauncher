namespace BmLauncherWForm
{
    /// <summary>
    ///     Helper class for the static Graphics class
    ///     Used to read and write all of the values to and from Graphics
    /// </summary>
    static class GraphicsInterpreter
    {
        private static bool charCheck;
        private static bool charNormalCheck;
        private static bool cinemaCheck;
        private static bool worldHiCheck;
        private static bool worldNormCheck;
        private static bool poolCheck;
        private static bool introOne;
        private static bool introTwo;
        private static bool introThree;
        private static bool introFour;

        /// <summary>
        ///     Large method that serves as the main function for this class.
        ///     Reads and writes Graphics, also checks if fixes have been applied if read is true
        /// </summary>
        /// <param name="lineToCheck">Input line that is being read or written</param>
        /// <param name="read">Boolean that determines if Graphics should be written to or read from</param>
        /// <returns>BmEngine value of string or new line to write into BmEngine</returns>
        public static string interpretGraphics(string lineToCheck, bool read)
        {
            if (lineToCheck.Contains("Fullscreen="))
            {
                if (read)
                {
                    Graphics.setFullScreen(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                }
                else
                {
                    lineToCheck = "Fullscreen=" + Graphics.isFullScreen();
                }

                return lineToCheck;
            }

            if (lineToCheck.Contains("UseVsync="))
            {
                if (read)
                {
                    Graphics.setVsync(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                }
                else
                {
                    lineToCheck = "UseVsync=" + Graphics.isVsync();
                }

                return lineToCheck;
            }

            if (lineToCheck.Contains("ResX="))
            {
                if (read && Graphics.getResolutionX().Equals("default"))
                {
                    Graphics.setResolutionX(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                }
                else
                {
                    lineToCheck = "ResX=" + Graphics.getResolutionX();
                }

                return lineToCheck;
            }

            if (lineToCheck.Contains("ResY="))
            {
                if (read && Graphics.getResolutionY().Equals("default"))
                {
                    Graphics.setResolutionY(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                }
                else
                {
                    lineToCheck = "ResY=" + Graphics.getResolutionY();
                }

                return lineToCheck;
            }

            if (!lineToCheck.Contains("Use") && lineToCheck.Contains("ScreenPercentage=") &&
                !lineToCheck.Contains("Upscale"))
            {
                if (read)
                {
                    Graphics.setScreenPercentageUIScale(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                }
                else
                {
                    lineToCheck = "ScreenPercentage=" + Graphics.getScreenPercentageUIScale();
                }

                return lineToCheck;
            }

            if (lineToCheck.Contains("DetailMode="))
            {
                if (read)
                {
                    Graphics.setDetailMode(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                }
                else
                {
                    lineToCheck = "DetailMode=" + Graphics.getDetailMode();
                }

                return lineToCheck;
            }

            if (lineToCheck.Contains("MaxMultisamples="))
            {
                if (read)
                {
                    Graphics.setMultiSampling(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                }
                else
                {
                    lineToCheck = "MaxMultisamples=" + Graphics.getMultiSampling();
                }

                return lineToCheck;
            }

            if (lineToCheck.Contains("DepthOfField="))
            {
                if (read)
                {
                    Graphics.setDepthOfField(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                }
                else
                {
                    lineToCheck = "DepthOfField=" + Graphics.isDepthOfField();
                }

                return lineToCheck;
            }

            if (lineToCheck.Contains("AmbientOcclusion="))
            {
                if (read)
                {
                    Graphics.setAmbientOcclusion(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                }
                else
                {
                    lineToCheck = "AmbientOcclusion=" + Graphics.isAmbientOcclusion();
                }

                return lineToCheck;
            }

            if (lineToCheck.Contains("Bloom=") && !lineToCheck.Contains("UseHighQuality"))
            {
                if (read)
                {
                    Graphics.setBloom(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                }
                else
                {
                    lineToCheck = "Bloom=" + Graphics.isBloom();
                }

                return lineToCheck;
            }

            if (lineToCheck.Contains("UseHighQualityBloom="))
            {
                if (read)
                {
                    Graphics.setHighQualityBloom(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                }
                else
                {
                    lineToCheck = "UseHighQualityBloom=" + Graphics.isBloom();
                }

                return lineToCheck;
            }

            if (lineToCheck.Contains("LensFlares="))
            {
                if (read)
                {
                    Graphics.setLensFlares(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                }
                else
                {
                    lineToCheck = "LensFlares=" + Graphics.isLensFlares();
                }

                return lineToCheck;
            }

            if (lineToCheck.Contains("MotionBlur="))
            {
                if (read)
                {
                    Graphics.setMotionBlur(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                }
                else
                {
                    lineToCheck = "MotionBlur=" + Graphics.isMotionBlur();
                }

                return lineToCheck;
            }

            if (lineToCheck.Contains("MaxAnisotropy="))
            {
                if (read)
                {
                    Graphics.setMaxAnisotropy(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                }
                else
                {
                    lineToCheck = "MaxAnisotropy=" + Graphics.getMaxAnisotropy();
                }

                return lineToCheck;
            }

            if (lineToCheck.Contains("DynamicShadows="))
            {
                if (read)
                {
                    Graphics.setDynamicShadows(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                }
                else
                {
                    lineToCheck = "DynamicShadows=" + Graphics.isDynamicShadows();
                }

                return lineToCheck;
            }

            if (lineToCheck.Contains("MaxShadowResolution="))
            {
                if (read)
                {
                    Graphics.setMaxShadowResolution(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                }
                else
                {
                    lineToCheck = "MaxShadowResolution=" + Graphics.getMaxShadowResolution();
                }

                return lineToCheck;
            }

            if (lineToCheck.Contains("ShadowFilterRadius="))
            {
                if (read)
                {
                    Graphics.setShadowFilterRadius(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                }
                else
                {
                    lineToCheck = "ShadowFilterRadius=" + Graphics.getShadowFilterRadius();
                }

                return lineToCheck;
            }

            if (lineToCheck.Contains("MaxSmoothedFrameRate="))
            {
                if (read)
                {
                    Graphics.setMaxSmoothedFramerate(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                }
                else
                {
                    lineToCheck = "MaxSmoothedFrameRate=" + Graphics.getMaxSmoothedFramerate();
                }

                return lineToCheck;
            }

            if (lineToCheck.Contains("DisableSphericalHarmonicLights="))
            {
                if (read)
                {
                    Graphics.setDisableSphericalHarmonicLights(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                }
                else
                {
                    lineToCheck = "DisableSphericalHarmonicLights=" + Graphics.isDisableSphericalHarmonicLights();
                }

                return lineToCheck;
            }

            if (lineToCheck.Contains("FogVolumes="))
            {
                if (read)
                {
                    Graphics.setFogVolumes(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                }
                else
                {
                    lineToCheck = "FogVolumes=" + Graphics.isFogVolumes();
                }

                return lineToCheck;
            }

            if (lineToCheck.Contains("Distortion=") && !lineToCheck.Contains("DropParticle"))
            {
                if (read)
                {
                    Graphics.setDistortion(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                }
                else
                {
                    lineToCheck = "Distortion=" + Graphics.isDistortion();
                }

                return lineToCheck;
            }

            if (lineToCheck.Contains("ShadowTexelsPerPixel="))
            {
                if (read)
                {
                    Graphics.setShadowTexels(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                }
                else
                {
                    lineToCheck = "ShadowTexelsPerPixel=" + Graphics.getShadowTexels();
                }

                return lineToCheck;
            }

            if (lineToCheck.Contains("PhysXLevel="))
            {
                if (read)
                {
                    Graphics.setPhysX(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                }
                else
                {
                    lineToCheck = "PhysXLevel=" + Graphics.getPhysX();
                }

                return lineToCheck;
            }

            if (lineToCheck.Contains("FLightPrimitiveInteractionInitialBlockSize="))
            {
                if (read)
                {
                    Graphics.setMemoryPoolsValue(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                }
                else
                {
                    lineToCheck = "FLightPrimitiveInteractionInitialBlockSize=" + Graphics.getMemoryPoolsValue();
                }

                return lineToCheck;
            }

            if (lineToCheck.Contains("FModShadowPrimitiveInteractionInitialBlockSize="))
            {
                if (!read)
                {
                    lineToCheck = "FModShadowPrimitiveInteractionInitialBlockSize=" + Graphics.getMemoryPoolsValue();
                }

                return lineToCheck;
            }

            // Check if Texturepack Fix & Disable Startup Movies are already active upon reading the file
            if (!read)
            {
                return lineToCheck;
            }

            if (lineToCheck.Equals("TEXTUREGROUP_Character=(MinLODSize=512,MaxLODSize=4096,LODBias=0)"))
            {
                charCheck = true;
            }

            if (lineToCheck.Equals("TEXTUREGROUP_CharacterNormalMap=(MinLODSize=512,MaxLODSize=4096,LODBias=0)"))
            {
                charNormalCheck = true;
            }

            if (lineToCheck.Equals("TEXTUREGROUP_Cinematic=(MinLODSize=1,MaxLODSize=4096,LODBias=0)"))
            {
                cinemaCheck = true;
            }

            if (lineToCheck.Equals("TEXTUREGROUP_World_Hi=(MinLODSize=256,MaxLODSize=4096,LODBias=0)"))
            {
                worldHiCheck = true;
            }

            if (lineToCheck.Equals("TEXTUREGROUP_WorldNormalMap_Hi=(MinLODSize=256,MaxLODSize=4096,LODBias=0)"))
            {
                worldNormCheck = true;
            }

            if (lineToCheck.Equals("PoolSize=4096"))
            {
                poolCheck = true;
            }

            if (charCheck && charNormalCheck && cinemaCheck && worldHiCheck && worldNormCheck && poolCheck)
            {
                Program.myFactory.texApplied();
            }

            if (lineToCheck.Equals(";StartupMovies=baa_logo_run_v5_h264"))
            {
                introOne = true;
            }

            if (lineToCheck.Equals(";StartupMovies=UTlogo"))
            {
                introTwo = true;
            }

            if (lineToCheck.Equals(";StartupMovies=Legal"))
            {
                introThree = true;
            }

            if (lineToCheck.Equals(";StartupMovies=Black"))
            {
                introFour = true;
            }

            if (introOne && introTwo && introThree && introFour)
            {
                Program.myFactory.introApplied();
            }

            return lineToCheck;
        }
    }
}