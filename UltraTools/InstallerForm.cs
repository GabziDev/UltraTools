namespace UltraTools
{
    public partial class InstallerForm : Form
    {
        // Instance
        private PopUp popUpInstance;

        public InstallerForm()
        {
            InitializeComponent();

            // Ajouter titre et logo
            Informations informations = new Informations();
            Text = informations.TitleForm("Installeur");
            Icon = Properties.Resources.logo;
        }

        private void InstallerForm_Load(object sender, EventArgs e)
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
