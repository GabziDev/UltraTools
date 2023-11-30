using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace UltraTools.Common
{
    internal class Informations
    {
        private static string version = "1.0.6-BETA";
        private static string copyright = $"© {DateTime.Now.Year} UltraTools. Tous droits réservés.";
        private static string[] author = { "GabzDEV", ", Souciss" };

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
            string authorList = "";

            for (int i = 0; i < author.Length; i++)
            {
                authorList += author[i].ToString();
            }

            return authorList;
        }

        public string TitleForm(string nomForm)
        {
            return $"{nomForm} - {getVersion()} - [{getAuthor()}]";
        }
    }
}
