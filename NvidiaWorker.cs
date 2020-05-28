using System;
using NvAPIWrapper;
using NvAPIWrapper.DRS;
using NvAPIWrapper.Native.Exceptions;

namespace BmLauncherWForm
{
    /// <summary>
    ///     Worker class utilizing the Nvidia API through NvAPIWrapper.
    ///     Used to find Arkham Asylum NVIDIA profile and modify it.
    /// </summary>
    class NvidiaWorker
    {
        private static string aoActive = "0";
        private static string aoValue = "0";

        public static bool hasHBAO = true;
        private readonly DriverSettingsSession session;
        private readonly DriverSettingsProfile prof;

        /// <summary>
        ///     Created in Program, instantiated by GuiInitializer.
        ///     Finds the Batman: Arkham Asylum Profile or creates it if it doesn't exist yet.
        ///     Calls getNVSettings().
        /// </summary>
        public NvidiaWorker()
        {
            NVIDIA.Initialize();
            session = DriverSettingsSession.CreateAndLoad();
            try
            {
                session.FindProfileByName("Batman: Arkham Asylum");
            }
            catch (NVIDIAApiException e)
            {
                Console.WriteLine(e);
                DriverSettingsProfile profile =
                    DriverSettingsProfile.CreateProfile(session, "Batman: Arkham Asylum", null);
                ProfileApplication profApp = ProfileApplication.CreateApplication(profile, "shippingpc-bmgame.exe");
                profile = profApp.Profile;
                profile.SetSetting(KnownSettingId.AmbientOcclusionModeActive, 0);
                profile.SetSetting(KnownSettingId.AmbientOcclusionMode, 0);
                session.Save();
            }

            prof = session.FindProfileByName("Batman: Arkham Asylum");
            getNVSettings();
        }


        /// <summary>
        ///     Sets NVIDIA settings in accordance to user input.
        ///     Called by GraphicsWriter.
        /// </summary>
        public void setNVSettings()
        {
            if (Program.client.nvBox.Checked)
            {
                prof.SetSetting(KnownSettingId.AmbientOcclusionModeActive, 1);
                prof.SetSetting(KnownSettingId.AmbientOcclusionMode, 2);
                session.Save();
            }
            else
            {
                prof.SetSetting(KnownSettingId.AmbientOcclusionModeActive, 0);
                prof.SetSetting(KnownSettingId.AmbientOcclusionMode, 0);
                session.Save();
            }
        }

        /// <summary>
        ///     Gets the current NVIDIA settings from the profile.
        ///     Adjusts checkbox accordingly.
        /// </summary>
        public void getNVSettings()
        {
            Int16 compValue = 0;
            try
            {
                aoActive = prof.GetSetting(KnownSettingId.AmbientOcclusionModeActive).ToString();
                aoValue = prof.GetSetting(KnownSettingId.AmbientOcclusionMode).ToString();
                compValue = Int16.Parse(prof.GetSetting(2916165).CurrentValue.ToString());
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e);
                prof.SetSetting(KnownSettingId.AmbientOcclusionModeActive, 0);
                prof.SetSetting(KnownSettingId.AmbientOcclusionMode, 0);
                Program.client.nvBox.Checked = false;
            }

            if (!aoActive.Contains("1") || !aoValue.Contains("2") || compValue != 48)
            {
                if (compValue != 48)
                {
                    hasHBAO = false;
                }
            }
            else
            {
                Program.client.nvBox.Checked = true;
            }
        }
    }
}