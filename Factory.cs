using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using BmLauncherWForm.Properties;

namespace BmLauncherWForm
{
    /// Factory that read and writes all of the accessed files.
    /// Applies various fixes and executes the NVSetter file if conditions are met.
    class Factory
    {
        // location of the BmEngine configuration file
        private static readonly string configFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                                                    "\\Square Enix\\Batman Arkham Asylum GOTY\\BmGame\\Config\\BmEngine.ini";

        // location of the UserEngine configuration file
        private static readonly string userEngineFile =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
            "\\Square Enix\\Batman Arkham Asylum GOTY\\BmGame\\Config\\UserEngine.ini";

        // location of the UserInput configuration file
        public static string inputFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                                         "\\Square Enix\\Batman Arkham Asylum GOTY\\BmGame\\Config\\UserInput.ini";

        // folder containing all configuration files
        private static readonly string configDirectory =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
            "\\Square Enix\\Batman Arkham Asylum GOTY\\BmGame\\Config\\";

        // form associated to the factory
        private static BmLauncherForm client;

        // FileInfo used to control the readonly properties of the BmEngine file
        private static readonly FileInfo configInfo = new FileInfo(configFile);

        // FileInfo used to control the readonly properties of the UserEngine file
        private static readonly FileInfo userEngineInfo = new FileInfo(userEngineFile);

        // contains all lines (as strings) of the BmEngine file
        private static readonly List<string> configList = new List<string>();

        // contains all lines (as strings) of the UserInput file
        public static List<string> inputList = new List<string>();

        // prepackaged BmEngine file, used in case file is missing
        private static readonly string bmEnginePremade = Resources.BmEngine;

        // prepackaged UserEngine file, used in case file is missing
        private static readonly string userEnginePremade = Resources.UserEngine;

        // prepackaged UserInput file, used in case file is missing
        private static readonly string userInputPremade = Resources.UserInput;

        // string array containing all lines that need to be changed for the GPUnity texturepack to work
        private static readonly string[] texFixLines =
        {
            "TEXTUREGROUP_Character=(MinLODSize=512,MaxLODSize=4096,LODBias=0)",
            "TEXTUREGROUP_CharacterNormalMap=(MinLODSize=512,MaxLODSize=4096,LODBias=0)",
            "TEXTUREGROUP_Cinematic=(MinLODSize=1,MaxLODSize=4096,LODBias=0)",
            "TEXTUREGROUP_World_Hi=(MinLODSize=256,MaxLODSize=4096,LODBias=0)",
            "TEXTUREGROUP_WorldNormalMap_Hi=(MinLODSize=256,MaxLODSize=4096,LODBias=0)", "PoolSize=4096"
        };

        // string array containing all lines to disable startup movies
        private static readonly string[] startUpMovieLines =
        {
            ";StartupMovies=baa_logo_run_v5_h264", ";StartupMovies=UTlogo", ";StartupMovies=Legal",
            ";StartupMovies=Black"
        };

        // keybind form associated to the factory
        public KeybindForm keybinds = new KeybindForm();

        // integer used for switch cases by GraphicsInterpreter
        public int lineInt = 21;

        /// <summary>
        ///     Constructor for the Factory class. Initializes the client and GPU name and extracts the NvAPIWrapper for NVIDIA
        ///     GPUs
        /// </summary>
        public Factory(BmLauncherForm form)
        {
            client = form;
            setGPUname();
            extractWrapper();
        }

        /// <summary>
        ///     Method that executes the other read methods.
        /// </summary>
        public void readFiles()
        {
            readDirectory();
            readConfigFile();
            readInputFile();
        }

        /// <summary>
        ///     This method is especially (and probably only) useful when first launching the game.
        ///     It will create the config directory and place prepackaged configuration files in there.
        /// </summary>
        private void readDirectory()
        {
            if (!Directory.Exists(configDirectory))
            {
                Directory.CreateDirectory(configDirectory);
                File.Create(configDirectory + "BmCamera.ini").Dispose();
                StreamWriter camFile = new StreamWriter(configDirectory + "BmCamera.ini");
                File.Create(configDirectory + "BmCompat.ini").Dispose();
                StreamWriter compFile = new StreamWriter(configDirectory + "BmCompat.ini");
                File.Create(configDirectory + "BmEditor.ini").Dispose();
                StreamWriter editFile = new StreamWriter(configDirectory + "BmEditor.ini");
                File.Create(configDirectory + "BmEditorUserSettings.ini").Dispose();
                StreamWriter editUserFile = new StreamWriter(configDirectory + "BmEditorUserSettings.ini");
                File.Create(configDirectory + "BmGame.ini").Dispose();
                StreamWriter gameFile = new StreamWriter(configDirectory + "BmGame.ini");
                File.Create(configDirectory + "BmInput.ini").Dispose();
                StreamWriter fakeInputFile = new StreamWriter(configDirectory + "BmInput.ini");
                File.Create(configDirectory + "BmUI.ini").Dispose();
                StreamWriter uiFile = new StreamWriter(configDirectory + "BmUI.ini");
                File.Create(configDirectory + "UserGame.ini").Dispose();
                StreamWriter uGameFile = new StreamWriter(configDirectory + "UserGame.ini");
                camFile.Write(Resources.BmCamera);
                compFile.Write(Resources.BmCompat);
                editFile.Write(Resources.BmEditor);
                editUserFile.Write(Resources.BmEditorUserSettings);
                gameFile.Write(Resources.BmGame);
                fakeInputFile.Write(Resources.BmInput);
                uiFile.Write(Resources.BmUI);
                uGameFile.Write(Resources.UserGame);
                camFile.Close();
                compFile.Close();
                editFile.Close();
                editUserFile.Close();
                gameFile.Close();
                fakeInputFile.Close();
                uiFile.Close();
                uGameFile.Close();
            }
        }

        /// <summary>
        ///     Reads the each line of BmEngine and saves it to a string list.
        ///     Overwrites pre-existing file if it's not created by Launcher.
        ///     Initializes the GUI after every parameter has been read.
        /// </summary>
        private void readConfigFile()
        {
            // creates files if they don't exist
            if (!File.Exists(configFile))
            {
                File.Create(configFile).Dispose();
                using (StreamWriter file = new StreamWriter(configFile))
                {
                    file.Write(bmEnginePremade);
                }
            }

            if (!File.Exists(userEngineFile))
            {
                File.Create(userEngineFile).Dispose();
                using (StreamWriter file = new StreamWriter(userEngineFile))
                {
                    file.Write(userEnginePremade);
                }
            }

            string[] confLines = File.ReadAllLines(configFile);

            // if-condition only relevant if BmEngine was not created by the Launcher. Will overwrite existing file
            if (!confLines.Last().Equals("[Generated by Batman: Arkham Asylum - Advanced Launcher]"))
            {
                configInfo.IsReadOnly = false;
                userEngineInfo.IsReadOnly = false;
                File.Delete(configFile);
                using (StreamWriter file = new StreamWriter(configFile))
                {
                    file.Write(bmEnginePremade);
                    configInfo.IsReadOnly = true;
                }

                File.Delete(userEngineFile);
                using (StreamWriter file = new StreamWriter(userEngineFile))
                {
                    file.Write(userEnginePremade);
                    userEngineInfo.IsReadOnly = true;
                }
            }

            for (int i = 0; i < confLines.Length; i++)
            {
                configList.Add(confLines[i]);
                if (i >= 1161 && i <= 1166)
                {
                    GraphicsInterpreter.checkIntro(confLines[i]);
                }

                if (i == 663 || (i >= 1108 && i <= 1135))
                {
                    GraphicsInterpreter.checkTex(confLines[i]);
                }

                if (i == lineInt)
                {
                    GraphicsInterpreter.interpretGraphics(confLines[i], true, lineInt);
                }
            }

            GuiInitializer.init();
        }

        /// <summary>
        ///     Reads the UserInput file and saves the lines to a string list.
        ///     Overwrites pre-existing file if it's not created by Launcher.
        /// </summary>
        public void readInputFile()
        {
            // creates file if it doesn't exist
            if (!File.Exists(inputFile))
            {
                File.Create(inputFile).Dispose();
                using (StreamWriter file = new StreamWriter(inputFile))
                {
                    file.Write(userInputPremade);
                }
            }

            string[] inputLines = File.ReadAllLines(inputFile);

            // if-condition only relevant if UserInput was not created by the Launcher. Will overwrite existing file
            if (!inputLines.Last().Equals("[Generated by Batman: Arkham Asylum Advanced Launcher]"))
            {
                File.Delete(inputFile);
                using (StreamWriter file = new StreamWriter(inputFile))
                {
                    file.Write(userInputPremade);
                }

                inputLines = File.ReadAllLines(inputFile);
            }

            for (int i = 0; i < inputLines.Length; i++)
            {
                inputList.Add(inputLines[i]);
                if (i < 51)
                {
                    KeybindInterpreter.interpretKeys(inputLines[i], true);
                }
            }
        }

        /// <summary>
        ///     Method is called when 'Apply Settings' or 'Start Game' gets pressed.
        ///     Utilizes GraphicsWriter helper class to change Parameters in Graphics class.
        ///     GraphicsInterpreter is used to write Graphics parameters to file.
        ///     This method also controls the readonly functionality.
        ///     After the writing procedure is done, file is made readonly.
        /// </summary>
        public void writeGraphFile()
        {
            configInfo.IsReadOnly = false;
            GraphicsWriter.writeAll();
            string newLine;
            using (StreamWriter file = new StreamWriter(configFile))
            {
                for (int i = 0; i < configList.Count; i++)
                {
                    if (i != lineInt)
                    {
                        file.WriteLine(configList[i]);
                    }
                    else
                    {
                        newLine = GraphicsInterpreter.interpretGraphics(configList[i], false, lineInt);
                        file.WriteLine(newLine);
                    }
                }

                file.Close();
            }

            configInfo.IsReadOnly = true;
        }

        /// <summary>
        ///     Saves Keybinds to UserInput file. Only interprets the first 56 lines, to allow for customization by the users after
        ///     that.
        /// </summary>
        public void writeInputFile()
        {
            string newLine;
            using (StreamWriter file = new StreamWriter(inputFile))
            {
                for (int i = 0; i < 56; i++)
                {
                    newLine = KeybindInterpreter.interpretKeys(inputList[i], false);
                    file.WriteLine(newLine);
                }

                for (int i = 56; i < inputList.Count; i++)
                {
                    file.WriteLine(inputList[i]);
                }

                file.Close();
            }
        }

        /// <summary>
        ///     Calls texfix method to change Texturegroup parameters in BmEngine file.
        /// </summary>
        public void applyTexfix()
        {
            configInfo.IsReadOnly = false;
            using (StreamWriter file = new StreamWriter(configFile))
            {
                for (int i = 0; i < configList.Count; i++)
                {
                    configList[i] = texfix(configList[i]);
                    file.WriteLine(configList[i]);
                }

                file.Close();
            }

            texApplied();
            configInfo.IsReadOnly = true;
        }

        /// <summary>
        ///     Checks string and changes it to appropriate string from array.
        ///     Used by applyTexfix() method.
        /// </summary>
        /// <param name="lineToCheck">Line that gets checked</param>
        /// <returns>Corrected line</returns>
        private string texfix(string lineToCheck)
        {
            if (lineToCheck.Contains("TEXTUREGROUP_Character=(MinLODSize="))
            {
                lineToCheck = texFixLines[0];
                return lineToCheck;
            }

            if (lineToCheck.Contains("TEXTUREGROUP_CharacterNormalMap=(MinLODSize="))
            {
                lineToCheck = texFixLines[1];
                return lineToCheck;
            }

            if (lineToCheck.Contains("TEXTUREGROUP_Cinematic=(MinLODSize="))
            {
                lineToCheck = texFixLines[2];
                return lineToCheck;
            }

            if (lineToCheck.Contains("TEXTUREGROUP_World_Hi=(MinLODSize="))
            {
                lineToCheck = texFixLines[3];
                return lineToCheck;
            }

            if (lineToCheck.Contains("TEXTUREGROUP_WorldNormalMap_Hi=(MinLODSize="))
            {
                lineToCheck = texFixLines[4];
                return lineToCheck;
            }

            if (lineToCheck.Contains("PoolSize") && !lineToCheck.Contains("CommonAudio"))
            {
                lineToCheck = texFixLines[5];
                return lineToCheck;
            }

            return lineToCheck;
        }

        /// <summary>
        ///     Method that disables texgroupButton.
        ///     Used by Factory for applyTexfix() method.
        ///     Is called by GraphicsInterpreter if conditions are met.
        /// </summary>
        public void texApplied()
        {
            client.texgroupButton.Text = "Texture Pack Fix applied!";
            client.texgroupButton.Enabled = false;
        }

        /// <summary>
        ///     Works exactly like applyTexfix().
        ///     Calls introFix() method to correct the input string.
        /// </summary>
        public void applyIntroFix()
        {
            configInfo.IsReadOnly = false;
            using (StreamWriter file = new StreamWriter(configFile))
            {
                for (int i = 0; i < configList.Count; i++)
                {
                    configList[i] = introFix(configList[i]);
                    file.WriteLine(configList[i]);
                }

                file.Close();
            }

            introApplied();
            configInfo.IsReadOnly = true;
            //  Application.Restart();
        }

        /// <summary>
        ///     Checks string and changes it to appropriate string from array.
        ///     Used by applyIntroFix() method.
        /// </summary>
        /// <param name="lineToCheck">Line that gets checked</param>
        /// <returns>Corrected line</returns>
        private string introFix(string lineToCheck)
        {
            if (lineToCheck.Contains("StartupMovies=baa_logo_run_v5_h264"))
            {
                lineToCheck = startUpMovieLines[0];
                return lineToCheck;
            }

            if (lineToCheck.Contains("StartupMovies=UTlogo"))
            {
                lineToCheck = startUpMovieLines[1];
                return lineToCheck;
            }

            if (lineToCheck.Contains("StartupMovies=Legal"))
            {
                lineToCheck = startUpMovieLines[2];
                return lineToCheck;
            }

            if (lineToCheck.Contains("StartupMovies=Black"))
            {
                lineToCheck = startUpMovieLines[3];
                return lineToCheck;
            }

            return lineToCheck;
        }

        /// <summary>
        ///     Method that disables disableIntroButton.
        ///     Used by Factory for applyIntroFix() method.
        ///     Is called by GraphicsInterpreter if conditions are met.
        /// </summary>
        public void introApplied()
        {
            client.disableIntroButton.Text = "Startup Movies disabled!";
            client.disableIntroButton.Enabled = false;
        }

        /// <summary>
        ///     Utilizes ManagementObjectSearcher to gather GPU information.
        ///     Changes gpInfoLabel accordingly. Called in Constructor.
        /// </summary>
        private void setGPUname()
        {
            string gpu = "";
            ManagementObjectSearcher search = new ManagementObjectSearcher("SELECT * FROM Win32_DisplayConfiguration");
            foreach (ManagementObject obj in search.Get())
            {
                foreach (PropertyData data in obj.Properties)
                {
                    if (data.Name == "Description")
                    {
                        gpu = data.Value.ToString();
                    }
                }
            }

            if (gpu.Contains("NVIDIA"))
            {
                client.gpInfoLabel.ForeColor = Color.Green;
            }

            if (gpu.Contains("Radeon") || gpu.Contains("AMD") || gpu.Contains("Intel"))
            {
                gpu = gpu + " (PhysX not recommended)";
                if (gpu.Contains("Radeon") || gpu.Contains("AMD"))
                {
                    client.gpInfoLabel.ForeColor = Color.Red;
                }
                else
                {
                    client.gpInfoLabel.ForeColor = Color.Blue;
                }
            }

            client.gpInfoLabel.Text = gpu;
        }

        /// <summary>
        ///     Used to extract the NvAPIWrapper.dll resource needed for NVIDIA GPUs to modify AO settings
        /// </summary>
        private void extractWrapper()
        {
            if (client.gpInfoLabel.Text.Contains("NVIDIA"))
            {
                if (!File.Exists("NvAPIWrapper.dll"))
                {
                    File.WriteAllBytes("NvAPIWrapper.dll", Resources.NvAPIWrapper);
                }
            }
        }

        /// <summary>
        ///     Executes helper application that requires admin privileges.
        ///     Application sets HBAO+ compatibility flags in NVIDIA profile.
        ///     Called by GraphicsWriter if conditions are met.
        /// </summary>
        public void execNVSetter()
        {
            if (!File.Exists("NVSetter.exe"))
            {
                string exeLocation = Path.Combine(Directory.GetCurrentDirectory(), "NVSetter.exe");

                using (FileStream stream = new FileStream(exeLocation, FileMode.CreateNew, FileAccess.Write))
                {
                    byte[] bytes = Resources.getNVSetter();
                    stream.Write(bytes, 0, bytes.Length);
                }
            }

            ProcessStartInfo nvProcess = new ProcessStartInfo("NVSetter.exe");
            nvProcess.Verb = "runas";
            Process.Start(nvProcess);
        }
    }
}