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

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}