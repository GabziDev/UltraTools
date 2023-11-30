namespace UltraTools.Pc {
    internal class Windows {
        // Variables
        private static string username = "";
        private static string heure = "";
        private static string date = "";

        // Fonctions
        private void Username()
        {
            try
            {
                username = Environment.UserName;
            }
            catch
            {
                username = "...";
            }
        }

        private void HeureDate()
        {
            DateTime now = DateTime.Now;

            try
            {
                heure = now.ToString("HH:mm:ss");
            } catch
            {
                heure = "...";
            }

            try
            {
                date = now.ToString("dd/MM/yyyy");
            } catch
            {
                date = "...";
            }
        }

        // Get
        public string getUsername()
        {
            Username();
            return username;
        }

        public string getHeure()
        {
            HeureDate();
            return heure;
        }

        public string getDate()
        {
            HeureDate();
            return date;
        }
    }
}
