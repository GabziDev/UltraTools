using System.Diagnostics;
using UltraTools.Common;
using UltraTools.Pc;

namespace UltraTools
{
    public partial class PcForm : Form
    {
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
            ShowComponentInfo();
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
                string result = "error";

           
               
                await Task.Run(() =>
                {

                    Process process = new Process();
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/c " + "systeminfo";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    //process.StartInfo.CreateNoWindow = true; // Ajout de cette ligne pour cacher la fenêtre du terminal
                    process.Start();
                    // skip ligne 2
                    process.StandardOutput.ReadLine();
                    process.StandardOutput.ReadLine();

                    // lis ligne 
                    string output = process.StandardOutput.ReadLine();
                    string toRemove = "Nom du systŠme d’exploitation:         ";
                    Console.WriteLine(output);
                    result = output.Substring(toRemove.Length);
                    process.WaitForExit();


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

                lblNomOs.Text = "version windows" + result;
                labelRAM.Text = ("R.A.M. Libre : " + availableGigaBytes + "Go");
                labelStorage.Text = ("Stockage Libre (OS) : " + stockageRestant + "Go");

            }
            catch (Exception ex)
            {
                // Message d'erreur 
                string erreur = ex.Message;
                popUpInstance = new PopUp();
                popUpInstance.Erreur(erreur);
            }
        }

        private void ShowComponentInfo()
        {
            Composants composants = new Composants();

            labelCPUname.Text = $"Nom CPU : {composants.getCpuName()}";
            labelGPUname.Text = $"Nom GPU : {composants.getGpuName()}";
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

        private void BtnNetUser_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c " + "net user ";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            rtboxEntreTerminale.Text = output;
            process.WaitForExit();
        }

        private void lblNomOs_Click(object sender, EventArgs e)
        {

        }
    }
}