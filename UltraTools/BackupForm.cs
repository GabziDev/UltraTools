using System.IO.Compression;
using UltraTools.Common;
using UltraTools.Pc;

namespace UltraTools {
    public partial class BackupForm : Form {

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
    }
}
