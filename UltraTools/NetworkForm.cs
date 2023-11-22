using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UltraTools
{
    public partial class NetworkForm : Form
    {
        // Instance
        private PopUp popUpInstance;

        public NetworkForm()
        {
            InitializeComponent();

            // Ajouter titre et logo
            Informations informations = new Informations();
            Text = informations.TitleForm("Réseaux");
            Icon = Properties.Resources.logo;
        }

        private void NetworkForm_Load(object sender, EventArgs e)
        {
            // Appeler les fonctions
            ShowNetworkInfo();

            // Ajouter un footer
            Informations informations = new Informations();
            labelFooter.Text = $"{informations.getAuthor()} - {informations.getCopyright()} - {informations.getVersion()}";
        }

        private void ShowNetworkInfo()
        {
            // Essayer sinon mettre une erreur
            try
            {
                // Recupérer les adresses ip
                string deviceName = Dns.GetHostName();
                string apiUrl = "https://ip.gabzdev.ch/";
                string ipPublic = new WebClient().DownloadString(apiUrl);
                string myIP = Dns.GetHostByName(deviceName).AddressList[0].ToString();

                // Afficher les informations
                labelHostName.Text = $"Nom d'Hôte : {deviceName}";
                labelIPv4Public.Text = $"IPv4 Public : {ipPublic}";
                labelIProuter.Text = $"IP Passerelle : ...";
                labelIPv6Public.Text = $"IPv6 Public : ...";

                IPAddress[] localIPs = Dns.GetHostAddresses(deviceName);

                // Parcourir toutes les IP trouver
                foreach (IPAddress ip in localIPs)
                {
                    // verifier si c'est une ipv4
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        // Afficher l'ipv4
                        labelIPv4Local.Text = $"IPv4 Local : {ip}";
                    }
                }

                // Parcourir toutes les IP trouver
                foreach (IPAddress ip in localIPs)
                {
                    // verifier si c'est une ipv6
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6)
                    {
                        // Afficher l'ipv6
                        labelIPv6Local.Text = $"IPv6 Local : {ip}";
                    }
                }
            }
            catch
            {
                // Afficher une erreur
                MessageBox.Show("Erreur");
                labelHostName.Text = $"Nom d'Hôte : Aucun";
                labelIPv4Local.Text = $"IPv4 Local : Aucun";
                labelIPv4Public.Text = $"IPv4 Public : Aucun";
            }
        }

        private void buttonScan_Click_1(object sender, EventArgs e)
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
                // Parcourir les ports de la liste
                foreach (int item in Ports)
                {
                    try
                    {
                        Scan.Connect(ip, item);
                        portOuvert.AppendLine(item.ToString());
                    }
                    catch
                    {
                        portFermer.AppendLine(item.ToString());
                    }
                }

                // Afficher les ports ouverts & fermer
                labelShowOpenPort.Text = $"Port(s) Ouvert\n{portOuvert}";
                labelShowClosePort.Text = $"Port(s) Fermer\n{portFermer}";
            }
        }

        // Liste des ports
        private static int[] Ports = new int[]
        {
            80,
            443,
            22,
            21
        };
    }
}