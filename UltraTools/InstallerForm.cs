using UltraTools.Common;

namespace UltraTools
{
    public partial class InstallerForm : Form
    {
        // Instances
        private PopUp popUpInstance;

        public InstallerForm()
        {
            InitializeComponent();

            // Titre & Logo
            Informations informations = new Informations();
            Text = informations.TitleForm("Installeur");
            Icon = Properties.Resources.logo;
        }

        private void InstallerForm_Load(object sender, EventArgs e)
        {
            // Footer
            Informations informations = new Informations();
            labelFooter.Text = informations.getCopyright();

            // MessageBox
            popUpInstance = new PopUp();
            popUpInstance.Dev();
        }
    }
}
