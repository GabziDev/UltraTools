using System.IO;
using static UltraTools.Common.Log;


namespace UltraTools {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            CreateFile();

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}