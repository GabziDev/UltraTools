using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using UltraTools.Common;
using UltraTools.Network;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UltraTools {
    public partial class NetworkForm : Form {
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
            labelStatusScanningPort.Visible = false;
            labelStatusScanningWhois.Visible = false;
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

        private void buttonLookUp_Click(object sender, EventArgs e)
        {
            string domain = textBoxDomain.Text;

            buttonLookUp.Enabled = false;
            textBoxDomain.Enabled = false;
            labelStatusScanningWhois.Visible = true;

            labelDomainName.Visible = false;
            labelCreatedDate.Visible = false;
            labelStatusDomain.Visible = false;
            labelServ1.Visible = false;
            labelServ2.Visible = false;
            labelRegistrarName.Visible = false;

            string apiURL = $"https://www.whoisxmlapi.com/whoisserver/WhoisService?apiKey=at_0ZUZn4tLMfx7tWFco3UxPSvnowuGd&outputFormat=json&domainName={domain}";

            try
            {
                string jsonResult = new WebClient().DownloadString(apiURL);
                JObject jsonObject = JObject.Parse(jsonResult);

                labelDomainName.Text = "Nom de domaine : " + jsonObject["WhoisRecord"]["registryData"]["domainName"].ToString();
                labelCreatedDate.Text = "Date de création : " + jsonObject["WhoisRecord"]["registryData"]["createdDate"].ToString();

                labelStatusDomain.Text = "Status : " + jsonObject["WhoisRecord"]["registryData"]["status"].ToString();

                labelServ1.Text = "Serveur primaire : " + jsonObject["WhoisRecord"]["registryData"]["nameServers"]["hostNames"][0].ToString();
                labelServ2.Text = "Serveur secondaire : " + jsonObject["WhoisRecord"]["registryData"]["nameServers"]["hostNames"][1].ToString();

                labelRegistrarName.Text = "Nom de registre : " + jsonObject["WhoisRecord"]["registryData"]["registrarName"].ToString();
            }
            catch
            {

            }

            labelDomainName.Visible = true;
            labelCreatedDate.Visible = true;
            labelStatusDomain.Visible = true;
            labelServ1.Visible = true;
            labelServ2.Visible = true;
            labelRegistrarName.Visible = true;

            buttonLookUp.Enabled = true;
            textBoxDomain.Enabled = true;
            labelStatusScanningWhois.Visible = false;
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
                labelStatusScanningPort.Visible = true;

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
                labelStatusScanningPort.Visible = false;
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