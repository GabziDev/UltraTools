using System.Diagnostics;

namespace UltraTools {
    public partial class PcForm : Form {
        // Instance
        private PopUp popUpInstance;
        private System.Windows.Forms.Timer timer;

        public PcForm()
        {
            InitializeComponent();

            // Ajouter titre et logo
            Informations informations = new Informations();
            Text = informations.TitleForm("PC");
            Icon = Properties.Resources.logo;
        }

        private void PcForm_Load(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 500;
            timer.Tick += Timer_Tick;

            timer.Start();

            // Ajouter un footer
            Informations informations = new Informations();
            labelFooter.Text = $"{informations.getAuthor()} - {informations.getCopyright()} - {informations.getVersion()}";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ShowInformations();
        }

        private void ShowInformations()
        {
            try
            {
                //cpu
                PerformanceCounter cpuCounter;
                cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");

                //ram 
                PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available Bytes");
                double availableBytes = ramCounter.NextValue();
                double availableGigaBytes = availableBytes / 1073741824;
                availableGigaBytes = Math.Round(availableGigaBytes, 1);
                labelRAM.Text = ("R.A.M. Libre : " + availableGigaBytes + "Go");

                //stockage
                DriveInfo driveInfo = new DriveInfo("C:");
                double stockageRestant = driveInfo.AvailableFreeSpace / (1024.0 * 1024.0 * 1024.0);
                stockageRestant = Math.Round(stockageRestant, 1);
                labelStorage.Text = ("Stockage Libre : " + stockageRestant + "Go -->" + cpuCounter.NextValue() + "%");
            }
            catch (Exception ex)
            {
                // Afficher message d'erreur
                string erreur = ex.Message;
                popUpInstance = new PopUp();
                popUpInstance.Erreur(erreur);
            }

        }
    }
}
