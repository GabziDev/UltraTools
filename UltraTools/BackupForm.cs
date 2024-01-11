using Dark.Net;
using System.IO.Compression;
using UltraTools.Common;
using UltraTools.Pc;
using UltraTools.Styles;

namespace UltraTools {
    public partial class BackupForm : Form {

        private Windows win = new Windows();

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
            // Fonctions
            Styles();

            // Footer
            Informations informations = new Informations();
            labelFooter.Text = informations.getCopyright();
        }

        // Styles
        private void Styles()
        {
            // Theme noir
            DarkNet darkNet = new DarkNet();
            darkNet.SetWindowThemeForms(this, Theme.Dark);
            // Round
            panelGlobal.Region = Region.FromHrgn(RoundCreator.CreateRoundRectRgn(0, 0, panelGlobal.Width, panelGlobal.Height, 25, 25));
            // Btn
            ButtonStyle.StyleBtn(buttonBackup);
            ButtonStyle.StyleBtn(buttonCancel);
        }

        private async void BackupBeta()
        {
            Windows win = new Windows();

            string directory = textBoxDirectory.Text;
            string output = textBoxOutput.Text;

            await Task.Run(() =>
            {
                try
                {
                    ZipFile.CreateFromDirectory(directory, output + $"/Backup_{win.getDate()}_{win.getHeure().Replace(":", "-")}.zip", CompressionLevel.Fastest, true);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            });
        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            BackupBeta();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
