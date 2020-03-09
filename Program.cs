using System;
using System.Threading;
using System.Windows.Forms;

namespace BmLauncherWForm

{
    /// <summary>
    ///     Replacement Application for the original Batman: Arkham Asylum BmLauncher
    ///     Offers more configuration options, enables compatibility with High-Res Texture Packs
    ///     and automatically takes care of the ReadOnly properties of each file, removing
    ///     any requirement to manually edit .ini files. Guarantees a much more comfortable user experience.
    ///     @author frofoo (https://steamcommunity.com/id/frofoo)
    /// </summary>
    static class Program
    {
        public static Factory myFactory;

        public static BmLauncherForm client;

        public static NvidiaWorker nvWorker;

        // Mutex with this applications GUID as name
        static readonly Mutex mutex = new Mutex(true, "{cbb275f6-724f-4e82-a403-e333dcf6c0bf}");

        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                runWindow();
                mutex.ReleaseMutex();
            }
            else
            {
                NativeMethods.PostMessage((IntPtr)NativeMethods.HWND_BROADCAST, NativeMethods.WM_SHOWME, IntPtr.Zero,
                    IntPtr.Zero);
            }
        }

        public static void runWindow()
        {
            SysResolutions.getResolutions();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            client = new BmLauncherForm();
            myFactory = new Factory(client);
            myFactory.readFiles();
            Application.Run(client);
        }
    }
}