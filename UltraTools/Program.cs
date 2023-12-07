using Microsoft.Win32;
using System.IO;
using UltraTools.Pc;
using static UltraTools.Common.Log;

namespace UltraTools {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Windows win = new Windows();

            CreateFile();

            LogEvent($"[INFO] UltraTools -> {win.getHeure()} - {win.getDate()} [Application démarrer]");

            RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            reg.SetValue("UltraTools", Application.ExecutablePath.ToString());

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}