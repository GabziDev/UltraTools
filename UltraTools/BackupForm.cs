using System.IO.Compression;
using System.Threading;
using UltraTools.Common;
using UltraTools.Pc;

using static UltraTools.Common.Log;

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
            LogEvent($"[INFO] UltraTools -> {win.getHeure()} - {win.getDate()} [Application démarrer]");

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

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
