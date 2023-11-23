using System.Runtime.InteropServices;
using UltraTools.Common;

namespace UltraTools
{
    public partial class MainForm : Form
    {
        private System.Windows.Forms.Timer timer;

        // Creer bouton rectangulaire avec des bords arrondis
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse
        );

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
            UserName();
            heureDate();
            BoutonStyle();

            // Refresh
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            heureDate();
        }

        // Changer style bouton navbar
        private void BoutonStyle()
        {
            btnNetwork.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnNetwork.Width, btnNetwork.Height, 7, 7));
            btnInstaller.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnInstaller.Width, btnInstaller.Height, 7, 7));
            btnBackup.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnBackup.Width, btnBackup.Height, 7, 7));
            btnPC.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnPC.Width, btnPC.Height, 7, 7));
        }

        // Afficher nom utilisateur.
        private void UserName()
        {
            try
            {
                string username = Environment.UserName;
                labelUser.Text = username;

                Console.WriteLine($"Nom d'utilisateur : {username}");
            }
            catch
            {
                labelUser.Text = "Erreur lors de la recuperation du nom d'utilisateur";
            }
        }

        // Afficher heure & date
        private void heureDate()
        {
            DateTime now = DateTime.Now;

            labelHeure.Text = now.ToString("HH:mm:ss");
            labelDate.Text = now.ToString("dd/MM/yyyy");
        }

        // Ajouter action pour les boutons de la nav
        private void btnNetwork_Click(object sender, EventArgs e)
        {
            NetworkForm network = new NetworkForm();
            network.ShowDialog();
        }

        private void btnInstaller_Click(object sender, EventArgs e)
        {
            InstallerForm installer = new InstallerForm();
            installer.ShowDialog();
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
