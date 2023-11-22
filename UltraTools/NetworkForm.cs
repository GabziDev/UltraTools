using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UltraTools
{
    public partial class NetworkForm : Form
    {
        public NetworkForm()
        {
            InitializeComponent();
        }

        private void NetworkForm_Load(object sender, EventArgs e)
        {
            try
            {
                string deviceName = Dns.GetHostName();

                string apiUrl = "https://ip.gabzdev.ch/";
                string ipPublic = new WebClient().DownloadString(apiUrl);

                string myIP = Dns.GetHostByName(deviceName).AddressList[0].ToString();


                labelHostName.Text = $"Nom d'Hôte : {deviceName}";
                labelIPv4Public.Text = $"IPv4 Public : {ipPublic}";
                labelIProuter.Text = $"IP Passerelle : ...";
                labelIPv6Public.Text = $"IPv6 Public : ...";

                IPAddress[] localIPs = Dns.GetHostAddresses(deviceName);
                foreach (IPAddress ip in localIPs)
                {
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        labelIPv4Local.Text = $"IPv4 Local : {ip}";
                    }
                }

                foreach (IPAddress ip in localIPs)
                {
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6)
                    {
                        labelIPv6Local.Text = $"IPv6 Local : {ip}";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Erreur");
                labelHostName.Text = $"Nom d'Hôte : Aucun";
                labelIPv4Local.Text = $"IPv4 Local : Aucun";
                labelIPv4Public.Text = $"IPv4 Public : Aucun";
            }

            Informations informations = new Informations();
            labelFooter.Text = $"{informations.getAuthor()} - {informations.getCopyright()} - {informations.getVersion()}";
        }

        private void buttonScan_Click_1(object sender, EventArgs e)
        {
            string ip = textBoxScanPort.Text;
            TcpClient Scan = new TcpClient();

            StringBuilder portOuvert = new StringBuilder();
            StringBuilder portFermer = new StringBuilder();

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

            labelShowOpenPort.Text = $"Port(s) Ouvert\n{portOuvert}";
            labelShowClosePort.Text = $"Port(s) Fermer\n{portFermer}";
        }

        private static int[] Ports = new int[]
        {
            80,
            443,
            22,
            21
        };
    }
}