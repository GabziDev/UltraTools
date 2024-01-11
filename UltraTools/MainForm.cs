using Dark.Net;
using System.Runtime.InteropServices;
using UltraTools.Common;
using UltraTools.Pc;
using UltraTools.Styles;

namespace UltraTools {
    public partial class MainForm : Form
    {

        private System.Windows.Forms.Timer timer;
        private Windows win = new Windows();

        public MainForm()
        {
            InitializeComponent();

            // Titre & Logo
            Informations informations = new Informations();
            Text = informations.TitleForm("Accueil");
            Icon = Properties.Resources.logo;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Fonctions
            Styles();

            labelUser.Text = win.getUsername();

            // Refresh
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        // Styles
        private void Styles()
        {
            // Theme noir
            DarkNet darkNet = new DarkNet();
            darkNet.SetWindowThemeForms(this, Theme.Dark);
            // Boutons
            ButtonStyle.StyleBtn(btnNetwork);
            ButtonStyle.StyleBtn(btnBackup);
            ButtonStyle.StyleBtn(btnPC);
            ButtonStyle.StyleBtn(btnCleaner);
            // Texts
            GradientCreator.GradientText(labelTitre, Color.FromArgb(128, 128, 255), Color.FromArgb(95, 95, 240));
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            labelHeure.Text = win.getHeure();
            labelDate.Text = win.getDate();
        }

        // Ajouter action pour les boutons de la nav
        private void btnNetwork_Click(object sender, EventArgs e)
        {
            NetworkForm network = new NetworkForm();
            network.ShowDialog();
        }

        private void btnCleaner_Click(object sender, EventArgs e)
        {
            Cleaner cleaner = new Cleaner();
            cleaner.ShowDialog();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            BackupForm backup = new BackupForm();
            backup.ShowDialog();
        }

        private void btnPC_Click(object sender, EventArgs e)
        {
            PcForm pc = new PcForm();
            pc.ShowDialog();
        }
    }
}
