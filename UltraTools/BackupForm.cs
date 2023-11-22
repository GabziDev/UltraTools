namespace UltraTools
{
    public partial class BackupForm : Form
    {
        // Instance
        private PopUp popUpInstance;

        public BackupForm()
        {
            InitializeComponent();

            // Ajouter titre et logo
            Informations informations = new Informations();
            Text = informations.TitleForm("Backup");
            Icon = Properties.Resources.logo;
        }

        private void BackupForm_Load(object sender, EventArgs e)
        {
            // Ajouter un footer
            Informations informations = new Informations();
            labelFooter.Text = $"{informations.getAuthor()} - {informations.getCopyright()} - {informations.getVersion()}";

            // Afficher PopUp
            popUpInstance = new PopUp();
            popUpInstance.Dev();
        }
    }
}
