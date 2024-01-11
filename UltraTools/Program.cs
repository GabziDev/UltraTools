using UltraTools.Pc;
using static UltraTools.Common.Log;

namespace UltraTools
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Windows win = new Windows();

            // Log dans le fichier que l'app a �t� ouverte
            CreateFile();
            LogEvent($"[INFO] UltraTools -> {win.getHeure()} - {win.getDate()} [Application d�marrer]");

            // Initialiser le MainForm
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}