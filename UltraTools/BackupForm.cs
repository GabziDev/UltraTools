using UltraTools.Common;

namespace UltraTools
{
    public partial class BackupForm : Form
    {
        // Instances
        private PopUp popUpInstance;

        public BackupForm()
        {
            InitializeComponent();

            // Titre & Logo
            Informations informations = new Informations();
            Text = informations.TitleForm("Backup");
            Icon = Properties.Resources.logo;
        }

        private void BackupForm_Load(object sender, EventArgs e)
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
