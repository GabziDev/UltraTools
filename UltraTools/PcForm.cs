using System.Diagnostics;

namespace UltraTools
{
    public partial class PcForm : Form
    {
        // Instance
        private PopUp popUpInstance;

        public PcForm()
        {
            InitializeComponent();

            // Ajouter titre et logo
            Informations informations = new Informations();
            Text = informations.TitleForm("PC");
            Icon = Properties.Resources.logo;
            //ram 
            PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available Bytes");
            double availableBytes = ramCounter.NextValue();
            double availableGigaBytes = availableBytes / 1073741824;
            availableGigaBytes = Math.Round(availableGigaBytes, 1);

            //stockage
            DriveInfo driveInfo = new DriveInfo("C:");
            double stockageRestant = driveInfo.AvailableFreeSpace / (1024.0 * 1024.0 * 1024.0);
            stockageRestant = Math.Round(stockageRestant, 1);






            lblStockage.Text = ("il reste en stockage " + stockageRestant + " GB de libre ");
            lblRam.Text = ("il reste en ram" + availableGigaBytes + " GB de libre ");

        }

        private void PcForm_Load(object sender, EventArgs e)
        {
            // Ajouter un footer
            Informations informations = new Informations();
            labelFooter.Text = $"{informations.getAuthor()} - {informations.getCopyright()} - {informations.getVersion()}";

            // Afficher PopUp
            popUpInstance = new PopUp();
            popUpInstance.Dev();
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
