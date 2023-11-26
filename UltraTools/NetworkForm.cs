using System.Net.Sockets;
using System.Text;
using UltraTools.Common;
using UltraTools.Network;

namespace UltraTools
{
    public partial class NetworkForm : Form
    {
        // Instances
        private PopUp popUpInstance;
        private Nw network;

        public NetworkForm()
        {
            InitializeComponent();

            // Titre & Logo
            Informations informations = new Informations();
            Text = informations.TitleForm("Réseaux");
            Icon = Properties.Resources.logo;

            // Desactiver le label status du scanport
            labelStatus.Visible = false;
        }

        private void NetworkForm_Load(object sender, EventArgs e)
        {
            // Appeler les fonctions
            ShowNetworkInfo();

            // Footer
            Informations informations = new Informations();
            labelFooter.Text = informations.getCopyright();
        }

        private void ShowNetworkInfo()
        {
            // Instance
            network = new Nw();

            // Afficher informations
            labelHostName.Text = $"Nom d'Hôte : {network.getHostName()}";
            labelIPv4Local.Text = $"IPv4 Local : {network.getIPv4Local()}";
            labelIPv6Local.Text = $"IPv6 Local : {network.getIPv6Local()}";
            labelIProuter.Text = $"IP Passerelle : {network.getIPgateway()}";
            labelIPv4Public.Text = $"IP Public : {network.getIPv4Public()}";
            labelMacAdr.Text = $"Adresse MAC : {network.getMacAdr()}";
        }

        private async void buttonScan_Click_1(object sender, EventArgs e)
        {
            // Instances
            popUpInstance = new PopUp();
            TcpClient Scan = new TcpClient();

            // Recuperer l'entrer
            string ip = textBoxScanPort.Text;

            // Stocker les ports ouvert & fermer
            StringBuilder portOuvert = new StringBuilder();
            StringBuilder portFermer = new StringBuilder();

            // Si le PopUp Warning ScanPort est OK
            if (popUpInstance.ScanPort())
            {
                // Bloquer pendant l'analyse
                buttonScan.Enabled = false;
                textBoxScanPort.Enabled = false;
                labelStatus.Visible = true;

                labelShowOpenPort.Text = $"Port(s) Ouvert";
                labelShowClosePort.Text = $"Port(s) Fermé";

                // Aller sur un autre thread
                await Task.Run(() =>
                {
                    // Parcourir les ports de la liste
                    foreach (int item in Ports)
                    {
                        TcpClient Scan = new TcpClient();
                        try
                        {
                            Scan.Connect(ip, item);
                            portOuvert.AppendLine($"{item}");
                        }
                        catch
                        {
                            portFermer.AppendLine($"{item}");
                        }
                        finally
                        {
                            Scan.Close();
                        }
                    }
                });

                // Afficher les ports ouverts & fermés
                labelShowOpenPort.Text = $"Port(s) Ouvert\n{portOuvert}";
                labelShowClosePort.Text = $"Port(s) Fermé\n{portFermer}";

                // Ne plus bloquer a la fin de l'analyse
                buttonScan.Enabled = true;
                textBoxScanPort.Enabled = true;
                labelStatus.Visible = false;
            }
        }

        // Liste des ports
        private static int[] Ports = new int[]
        {
            80,
            25565,
            443,
            22,
            21
        };

        private void labelHostName_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(network.getHostName());
        }

        private void labelIPv4Local_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(network.getIPv4Local());
        }

        private void labelIPv6Local_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(network.getIPv6Local());
        }

        private void labelIProuter_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(network.getIPgateway());
        }

        private void labelIPv4Public_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(network.getIPv4Public());
        }

        private void labelMacAdr_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(network.getMacAdr());
        }

        private void labelHostName_MouseHover(object sender, EventArgs e)
        {
            labelHostName.ForeColor = Color.Cyan;
            labelHostName.Cursor = Cursors.Hand;
        }

        private void labelHostName_MouseLeave(object sender, EventArgs e)
        {
            labelHostName.ForeColor = SystemColors.Control;
        }

        private void labelIPv4Local_MouseHover(object sender, EventArgs e)
        {
            labelIPv4Local.ForeColor = Color.Cyan;
            labelIPv4Local.Cursor = Cursors.Hand;
        }

        private void labelIPv4Local_MouseLeave(object sender, EventArgs e)
        {
            labelIPv4Local.ForeColor = SystemColors.Control;
        }

        private void labelIPv6Local_MouseHover(object sender, EventArgs e)
        {
            labelIPv6Local.ForeColor = Color.Cyan;
            labelIPv6Local.Cursor = Cursors.Hand;
        }

        private void labelIPv6Local_MouseLeave(object sender, EventArgs e)
        {
            labelIPv6Local.ForeColor = SystemColors.Control;
        }

        private void labelIProuter_MouseHover(object sender, EventArgs e)
        {
            labelIProuter.ForeColor = Color.Cyan;
            labelIProuter.Cursor = Cursors.Hand;
        }

        private void labelIProuter_MouseLeave(object sender, EventArgs e)
        {
            labelIProuter.ForeColor = SystemColors.Control;
        }

        private void labelIPv4Public_MouseHover(object sender, EventArgs e)
        {
            labelIPv4Public.ForeColor = Color.Cyan;
            labelIPv4Public.Cursor = Cursors.Hand;
        }

        private void labelIPv4Public_MouseLeave(object sender, EventArgs e)
        {
            labelIPv4Public.ForeColor = SystemColors.Control;
        }

        private void labelMacAdr_MouseHover(object sender, EventArgs e)
        {
            labelMacAdr.ForeColor = Color.Cyan;
            labelMacAdr.Cursor = Cursors.Hand;
        }

        private void labelMacAdr_MouseLeave(object sender, EventArgs e)
        {
            labelMacAdr.ForeColor = SystemColors.Control;
        }
    }
}