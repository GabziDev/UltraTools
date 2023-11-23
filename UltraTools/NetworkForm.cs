using System.Drawing.Drawing2D;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;

namespace UltraTools {
    public partial class NetworkForm : Form {
        // Instance
        private PopUp popUpInstance;

        // Variables
        public string deviceName;
        public string apiUrl;
        public string ipPublic;
        public string myIP;
        public string ipV4;
        public string ipV4Gateway;
        public string ipV6;
        public string macAdr;

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
                deviceName = Dns.GetHostName();
                apiUrl = "https://ip.gabzdev.ch/";
                ipPublic = new WebClient().DownloadString(apiUrl);
                myIP = Dns.GetHostByName(deviceName).AddressList[0].ToString();

                // Afficher les informations
                labelHostName.Text = $"Nom d'Hôte : {deviceName}";
                labelIPv4Public.Text = $"IPv4 Public : {ipPublic}";

                NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
                IPAddress[] localIPs = Dns.GetHostAddresses(deviceName);

                // Parcourir toutes les IP trouver
                foreach (IPAddress ip in localIPs)
                {
                    // verifier si c'est une ipv4
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        // Afficher l'ipv4
                        ipV4 = ip.ToString();
                        labelIPv4Local.Text = $"IPv4 Local : {ipV4}";
                    }
                }

                foreach (NetworkInterface netInterface in networkInterfaces)
                {
                    if (netInterface.OperationalStatus == OperationalStatus.Up &&
                        netInterface.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                    {
                        IPInterfaceProperties ipProperties = netInterface.GetIPProperties();

                        GatewayIPAddressInformationCollection gateways = ipProperties.GatewayAddresses;

                        foreach (GatewayIPAddressInformation gateway in gateways)
                        {
                            if (gateway.Address.AddressFamily == AddressFamily.InterNetwork)
                            {
                                ipV4Gateway = gateway.Address.ToString();
                                labelIProuter.Text = $"IP Passerelle : {ipV4Gateway}";
                            }
                        }
                    }
                    macAdr = netInterface.GetPhysicalAddress().ToString();
                    labelMacAdr.Text = $"Adresse MAC : {macAdr}";
                }

                // Parcourir toutes les IP trouver
                foreach (IPAddress ip in localIPs)
                {
                    // verifier si c'est une ipv6
                    if (ip.AddressFamily == AddressFamily.InterNetworkV6)
                    {
                        // Afficher l'ipv6
                        ipV6 = ip.ToString();
                        labelIPv6Local.Text = $"IPv6 Local : {ipV6}";
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
                labelIProuter.Text = $"IP Passerelle : Aucun";
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

        private void labelHostName_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(deviceName);
        }

        private void labelIPv4Local_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ipV4);
        }

        private void labelIPv6Local_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ipV6);
        }

        private void labelIProuter_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ipV4Gateway);
        }

        private void labelIPv4Public_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ipPublic);
        }

        private void labelMacAdr_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(macAdr);
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