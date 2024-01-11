namespace UltraTools.Common
{
    internal class Informations
    {
        // Variables Informations application
        private static string version = "1.0.7-BETA DEV VERSION";
        private static string copyright = $"© 2023 - {DateTime.Now.Year} UltraTools. Tous droits réservés.";
        private static string[] author = { "GabzDEV", ", Souciss" };

        // Get
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
