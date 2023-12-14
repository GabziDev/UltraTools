using Dark.Net;
using UltraTools.Common;
using UltraTools.Pc;
using static UltraTools.Common.Log;

namespace UltraTools
{
    public partial class Cleaner : Form
    {
        public Cleaner()
        {
            InitializeComponent();

            // Titre & Logo
            Informations informations = new Informations();
            Text = informations.TitleForm("Cleaner");
            Icon = Properties.Resources.logo;
        }

        private void Cleaner_Load(object sender, EventArgs e)
        {
            // Fonctions
            Styles();
            CheckFirefoxIsInstalled();

            // Footer
            Informations informations = new Informations();
            labelFooter.Text = informations.getCopyright();
        }

        // Styles
        private void Styles()
        {
            // Theme noir
            DarkNet darkNet = new DarkNet();
            darkNet.SetWindowThemeForms(this, Theme.Dark);
        }

        private void buttonClearCacheFirefox_Click(object sender, EventArgs e)
        {
            Windows win = new Windows();
            CheckFirefoxIsInstalled();

            string firefoxPath = $"C:\\Users\\{Environment.UserName}\\AppData\\Local\\Mozilla\\Firefox\\Profiles";

            string[] cacheDossiers = { "thumbnails", "startupCache", "cache2", "jumpListCache", "" };

            try
            {
                string[] profilDossiers = Directory.GetDirectories(firefoxPath);

                foreach (var profileFolder in profilDossiers)
                {
                    foreach (var folder in cacheDossiers)
                    {
                        string folderPath = Path.Combine(profileFolder, folder);

                        if (Directory.Exists(folderPath))
                        {
                            try
                            {
                                Directory.Delete(folderPath, true);
                                LogEvent($"[INFO] Clear -> ({win.getHeure()} - {win.getDate()}) Cache clear dans le profil '{profileFolder}'");
                            }
                            catch
                            {
                            }
                        }
                        else
                        {
                            LogEvent($"[ERROR] Clear -> ({win.getHeure()} - {win.getDate()}) Aucun cache trouver dans le profil '{profileFolder}'");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogEvent($"Aucun profil...");
            }
        }

        private void CheckFirefoxIsInstalled()
        {
            Windows win = new Windows();

            string path = $"C:\\Users\\{Environment.UserName}\\AppData\\Local\\Mozilla\\Firefox";

            if (!Directory.Exists(path))
            {
                LogEvent($"[ERROR] Clear -> ({win.getHeure()} - {win.getDate()}) Firefox n'est pas installé ou aucun profile firefox n'est detecté.");
            }
        }

        private void buttonClearHistoriqueFirefox_Click(object sender, EventArgs e)
        {

        }
    }
}
