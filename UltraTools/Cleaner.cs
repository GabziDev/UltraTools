using Dark.Net;
using System.Diagnostics;
using UltraTools.Common;
using UltraTools.Pc;
using UltraTools.Styles;
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
            // Texts
            GradientCreator.GradientText(labelFirefox, Color.FromArgb(128, 128, 255), Color.FromArgb(95, 95, 240));
            // Round
            panelGlobal.Region = Region.FromHrgn(RoundCreator.CreateRoundRectRgn(0, 0, panelGlobal.Width, panelGlobal.Height, 25, 25));
        }

        // Styles
        private void Styles()
        {
            // Theme noir
            DarkNet darkNet = new DarkNet();
            darkNet.SetWindowThemeForms(this, Theme.Dark);
        }

        static void CloseFirefox()
        {
            Process[] processes = Process.GetProcessesByName("firefox");

            foreach (Process process in processes)
            {
                process.CloseMainWindow();
                process.WaitForExit(5000);
                if (!process.HasExited)
                {
                    process.Kill();
                }
            }
        }

        private void buttonClearCacheFirefox_Click(object sender, EventArgs e)
        {
            CloseFirefox();

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
                LogEvent($"[ERROR] Clear -> ({win.getHeure()} - {win.getDate()}) Error : {ex.ToString()}");
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

        private void buttonClearCookiesFirefox_Click(object sender, EventArgs e)
        {
            CloseFirefox();

            Windows win = new Windows();
            CheckFirefoxIsInstalled();

            string firefoxPath = $"C:\\Users\\{Environment.UserName}\\AppData\\Roaming\\Mozilla\\Firefox\\Profiles";

            try
            {
                string[] profileFolders = Directory.GetDirectories(firefoxPath);

                foreach (var profileFolder in profileFolders)
                {
                    string storageDefaultPath = Path.Combine(profileFolder, "storage", "default");

                    try
                    {
                        string[] files = Directory.GetFiles(storageDefaultPath);
                        foreach (var filePath in files)
                        {
                            File.Delete(filePath);



                            LogEvent($"[INFO] Deleted -> ({win.getHeure()} - {win.getDate()}) {Path.GetFileName(filePath)} supprimer '{profileFolder}'");
                        }

                        string[] subDirectories = Directory.GetDirectories(storageDefaultPath);
                        foreach (var subDir in subDirectories)
                        {
                            Directory.Delete(subDir, true);
                            LogEvent($"[INFO] Deleted -> ({win.getHeure()} - {win.getDate()}) supprimer '{profileFolder}'");
                        }

                        LogEvent($"[INFO] Clear '{profileFolder}'");
                    }
                    catch (Exception ex)
                    {
                        LogEvent($"[ERROR] Clear -> ({win.getHeure()} - {win.getDate()}) Error : {ex.ToString()}");
                    }
                }
            }
            catch (Exception ex)
            {
                LogEvent($"[ERROR] Clear -> ({win.getHeure()} - {win.getDate()}) Error : {ex.ToString()}");
            }
        }

        private void btnFlushDns_Click(object sender, EventArgs e)
        {

            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c " + "ipconfig /flushdns";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            LogEvent(output);
     


        }
    }
}
