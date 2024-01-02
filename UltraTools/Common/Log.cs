using Microsoft.VisualBasic;
using System.IO;

namespace UltraTools.Common {
    internal class Log {

        public static void CreateFile()
        {
            if (!File.Exists("log.txt"))
            {
                using (StreamWriter sw = File.CreateText("log.txt"));
            }
        }

        public static void LogEvent(string content)
        {
            using (StreamWriter write = new StreamWriter("log.txt", true))
            {
                write.WriteLine(content);
            }
        }
    }
}