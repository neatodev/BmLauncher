using NLog;

namespace BmLauncherWForm.data
{
    /// <summary>
    ///     Helper class for the static Graphics class
    ///     Used to read and write all of the values to and from Graphics
    /// </summary>
    internal class GraphicsInterpreter
    {
        // logger for easy debugging
        private static Logger logger = LogManager.GetCurrentClassLogger();

        private static bool charCheck;
        private static bool charNormalCheck;
        private static bool poolCheck;
        private static bool introOne;
        private static bool introTwo;
        private static bool introThree;
        private static bool introFour;

        /// <summary>
        ///     Large method that serves as the main function for this class.
        ///     Reads and writes Graphics.
        /// </summary>
        /// <param name="lineToCheck">Input line that is being read or written</param>
        /// <param name="read">Boolean that determines if Graphics should be written to or read from</param>
        /// <returns>BmEngine value of string or new line to write into BmEngine</returns>
        public string interpretGraphics(string lineToCheck, bool read, int switchCase)
        {
            switch (switchCase)
            {
                // language
                case 21:
                    if (read)
                    {
                        Graphics.setLanguage(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "Language=" + Graphics.getLanguage();
                    }

                    Program.MyFactory.LineInt = 110;
                    return lineToCheck;

                // physx
                case 110:
                    if (read)
                    {
                        Graphics.setPhysX(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "PhysXLevel=" + Graphics.getPhysX();
                    }

                    Program.MyFactory.LineInt = 154;
                    return lineToCheck;

                // max smoothed framerate
                case 154:
                    if (read)
                    {
                        Graphics.setMaxSmoothedFramerate(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "MaxSmoothedFrameRate=" + Graphics.getMaxSmoothedFramerate();
                    }

                    Program.MyFactory.LineInt = 1029;
                    return lineToCheck;

                // FLightPrimitiveInteractionInitialBlockSize
                case 1029:
                    if (read)
                    {
                        Graphics.setMemoryPoolsValue(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "FLightPrimitiveInteractionInitialBlockSize=" + Graphics.getMemoryPoolsValue();
                    }

                    Program.MyFactory.LineInt = 1030;
                    return lineToCheck;

                // FModShadowPrimitiveInteractionInitialBlockSize
                case 1030:
                    if (!read)
                    {
                        lineToCheck = "FModShadowPrimitiveInteractionInitialBlockSize=" +
                                      Graphics.getMemoryPoolsValue();
                    }

                    Program.MyFactory.LineInt = 1038;
                    return lineToCheck;

                // dynamic shadows
                case 1038:
                    if (read)
                    {
                        Graphics.setDynamicShadows(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "DynamicShadows=" + Graphics.isDynamicShadows();
                    }

                    Program.MyFactory.LineInt = 1048;
                    return lineToCheck;

                // motion blur
                case 1048:
                    if (read)
                    {
                        Graphics.setMotionBlur(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "MotionBlur=" + Graphics.isMotionBlur();
                    }

                    Program.MyFactory.LineInt = 1057;
                    return lineToCheck;

                // depth of field
                case 1057:
                    if (read)
                    {
                        Graphics.setDepthOfField(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "DepthOfField=" + Graphics.isDepthOfField();
                    }

                    Program.MyFactory.LineInt = 1058;
                    return lineToCheck;

                // ambient occlusion
                case 1058:
                    if (read)
                    {
                        Graphics.setAmbientOcclusion(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "AmbientOcclusion=" + Graphics.isAmbientOcclusion();
                    }

                    Program.MyFactory.LineInt = 1059;
                    return lineToCheck;

                // bloom
                case 1059:
                    if (read)
                    {
                        Graphics.setBloom(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "Bloom=" + Graphics.isBloom();
                    }

                    Program.MyFactory.LineInt = 1060;
                    return lineToCheck;

                // hq bloom
                case 1060:
                    if (read)
                    {
                        Graphics.setHighQualityBloom(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "UseHighQualityBloom=" + Graphics.isBloom();
                    }

                    Program.MyFactory.LineInt = 1061;
                    return lineToCheck;

                // distortion
                case 1061:
                    if (read)
                    {
                        Graphics.setDistortion(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "Distortion=" + Graphics.isDistortion();
                    }

                    Program.MyFactory.LineInt = 1066;
                    return lineToCheck;

                // lens flares
                case 1066:
                    if (read)
                    {
                        Graphics.setLensFlares(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "LensFlares=" + Graphics.isLensFlares();
                    }

                    Program.MyFactory.LineInt = 1067;
                    return lineToCheck;

                // fog volumes
                case 1067:
                    if (read)
                    {
                        Graphics.setFogVolumes(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "FogVolumes=" + Graphics.isFogVolumes();
                    }

                    Program.MyFactory.LineInt = 1069;
                    return lineToCheck;

                // oneframethreadlag
                case 1069:
                    if (read)
                    {
                        Graphics.setFrameThreadLag(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "OneFrameThreadLag=" + Graphics.getFrameThreadLag();
                    }

                    Program.MyFactory.LineInt = 1070;
                    return lineToCheck;

                // vsync
                case 1070:
                    if (read)
                    {
                        Graphics.setVsync(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "UseVsync=" + Graphics.isVsync();
                    }

                    Program.MyFactory.LineInt = 1072;
                    return lineToCheck;

                // fullscreen
                case 1072:
                    if (read)
                    {
                        Graphics.setFullScreen(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "Fullscreen=" + Graphics.isFullScreen();
                    }

                    Program.MyFactory.LineInt = 1076;
                    return lineToCheck;

                // detail mode
                case 1076:
                    if (read)
                    {
                        Graphics.setDetailMode(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "DetailMode=" + Graphics.getDetailMode();
                    }

                    Program.MyFactory.LineInt = 1078;
                    return lineToCheck;

                // max anisotropy
                case 1078:
                    if (read)
                    {
                        Graphics.setMaxAnisotropy(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "MaxAnisotropy=" + Graphics.getMaxAnisotropy();
                    }

                    Program.MyFactory.LineInt = 1079;
                    return lineToCheck;

                // max aa
                case 1079:
                    if (read)
                    {
                        Graphics.setMultiSampling(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "MaxMultisamples=" + Graphics.getMultiSampling();
                    }

                    Program.MyFactory.LineInt = 1082;
                    return lineToCheck;

                // max shadow res
                case 1082:
                    if (read)
                    {
                        Graphics.setMaxShadowResolution(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "MaxShadowResolution=" + Graphics.getMaxShadowResolution();
                    }

                    Program.MyFactory.LineInt = 1085;
                    return lineToCheck;

                // res x
                case 1085:
                    if (read && Graphics.getResolutionX().Equals("default"))
                    {
                        Graphics.setResolutionX(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "ResX=" + Graphics.getResolutionX();
                    }

                    Program.MyFactory.LineInt = 1086;
                    return lineToCheck;

                // res y
                case 1086:
                    if (read && Graphics.getResolutionY().Equals("default"))
                    {
                        Graphics.setResolutionY(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "ResY=" + Graphics.getResolutionY();
                    }

                    Program.MyFactory.LineInt = 1090;
                    return lineToCheck;

                // shadow texels
                case 1090:
                    if (read)
                    {
                        Graphics.setShadowTexels(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "ShadowTexelsPerPixel=" + Graphics.getShadowTexels();
                    }

                    Program.MyFactory.LineInt = 1096;
                    return lineToCheck;

                // shadow filter radius
                case 1096:
                    if (read)
                    {
                        Graphics.setShadowFilterRadius(lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "ShadowFilterRadius=" + Graphics.getShadowFilterRadius();
                    }

                    Program.MyFactory.LineInt = 1127;
                    return lineToCheck;

                case 1127:
                    if (read)
                    {
                        Graphics.setDisableSphericalHarmonicLights(
                            lineToCheck.Substring(lineToCheck.LastIndexOf("=") + 1));
                    }
                    else
                    {
                        lineToCheck = "DisableSphericalHarmonicLights=" + Graphics.isDisableSphericalHarmonicLights();
                    }

                    Program.MyFactory.LineInt = 21;
                    return lineToCheck;
            }

            return lineToCheck;
        }

        public static void checkTex(string lineToCheck)
        {
            if (charCheck && charNormalCheck && poolCheck)
            {
                Program.MyFactory.texApplied();
                logger.Info("checkTex - Texture Pack Fix is enabled.");
                return;
            }

            if (lineToCheck.Equals("TEXTUREGROUP_Character=(MinLODSize=512,MaxLODSize=4096,LODBias=0)") && !charCheck)
            {
                charCheck = true;
                return;
            }

            if (lineToCheck.Equals("TEXTUREGROUP_CharacterNormalMap=(MinLODSize=512,MaxLODSize=4096,LODBias=0)") &&
                !charNormalCheck)
            {
                charNormalCheck = true;
                return;
            }

            if (lineToCheck.Equals("PoolSize=4096") && !poolCheck)
            {
                poolCheck = true;
            }
        }

        public static void checkIntro(string lineToCheck)
        {
            if (introOne && introTwo && introThree && introFour)
            {
                Program.MyFactory.introApplied();
                logger.Info("checkIntro - Startup Movies are disabled.");
                return;
            }

            if (lineToCheck.Equals(";StartupMovies=baa_logo_run_v5_h264") && !introOne)
            {
                introOne = true;
                return;
            }

            if (lineToCheck.Equals(";StartupMovies=UTlogo") && !introTwo)
            {
                introTwo = true;
                return;
            }

            if (lineToCheck.Equals(";StartupMovies=Legal") && !introThree)
            {
                introThree = true;
                return;
            }

            if (lineToCheck.Equals(";StartupMovies=Black") && !introFour)
            {
                introFour = true;
            }
        }
    }
}