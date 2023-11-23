using System.Diagnostics;

namespace UltraTools {
    public partial class PcForm : Form {
        // Instance
        private PopUp popUpInstance;

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
            try
            {
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
                labelStorage.Text = ("Stockage Libre : " + stockageRestant + "Go");
            }
            catch (Exception ex)
            {
                // Afficher message d'erreur
                string erreur = ex.Message;
                popUpInstance = new PopUp();
                popUpInstance.Erreur(erreur);
            }

            // Ajouter un footer
            Informations informations = new Informations();
            labelFooter.Text = $"{informations.getAuthor()} - {informations.getCopyright()} - {informations.getVersion()}";
        }
    }
}
