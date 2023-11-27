using System.Diagnostics;
using UltraTools.Common;

namespace UltraTools {
    public partial class PcForm : Form {
        // Instances
        private PopUp popUpInstance;

        public PcForm()
        {
            InitializeComponent();

            // Titre & Logo
            Informations informations = new Informations();
            Text = informations.TitleForm("PC");
            Icon = Properties.Resources.logo;
        }

        private void PcForm_Load(object sender, EventArgs e)
        {
            // Fonctions
            ShowInformations();

            // Footer
            Informations informations = new Informations();
            labelFooter.Text = informations.getCopyright();
        }

        private async void ShowInformations()
        {
            try
            {
                double availableGigaBytes = 0;
                double stockageRestant = 0;

                await Task.Run(() =>
                {
                    // RAM
                    PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available Bytes");
                    double availableBytes = ramCounter.NextValue();
                    availableGigaBytes = availableBytes / 1073741824;
                    availableGigaBytes = Math.Round(availableGigaBytes, 1);

                    // Stockage
                    DriveInfo driveInfo = new DriveInfo("C:");
                    stockageRestant = driveInfo.AvailableFreeSpace / (1024.0 * 1024.0 * 1024.0);
                    stockageRestant = Math.Round(stockageRestant, 1);
                });

                labelRAM.Text = ("R.A.M. Libre : " + availableGigaBytes + "Go");
                labelStorage.Text = ("Stockage Libre : " + stockageRestant + "Go");
            }
            catch (Exception ex)
            {
                // Message d'erreur 
                string erreur = ex.Message;
                popUpInstance = new PopUp();
                popUpInstance.Erreur(erreur);
            }
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 0 /f");
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/r /t 0 /f");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string command = rtboxEntreTerminale.Text;

            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c " + command;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            rtboxEntreTerminale.Text = output;
            process.WaitForExit();
        }
    }
}