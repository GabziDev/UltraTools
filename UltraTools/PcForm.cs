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
    }
}
