using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraTools
{
    internal class Informations
    {
        private static string version = "1.0.2-BETA";
        private static string copyright = $"© {DateTime.Now.Year} UltraTools. Tous droits réservés.";
        private static string author = "GabzDEV";

        public string getVersion()
        {
            return version;
        }

        public string getCopyright()
        {
            return copyright;
        }

        public string getAuthor()
        {
            return author;
        }
    }
}
