using Dark.Net;
using UltraTools.Common;
using UltraTools.Styles;

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
            // Fonctions
            Styles();

            // Footer
            Informations informations = new Informations();
            labelFooter.Text = informations.getCopyright();

            // MessageBox
            popUpInstance = new PopUp();
            popUpInstance.Dev();
        }

        // Styles
        private void Styles()
        {
            // Theme noir
            DarkNet darkNet = new DarkNet();
            darkNet.SetWindowThemeForms(this, Theme.Dark);
        }
    }
}
