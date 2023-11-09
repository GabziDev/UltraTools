using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltraTools {
    public partial class NetworkForm : Form {
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
        }

        /*
         * 
         *  TEST !!!!
         *  PORT SCANNER TEST
         * 
         * 
         * 
         * 
         */

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            string ip = textBox1.Text;
            TcpClient Scan = new TcpClient();
            foreach (int s in Ports)
            {
                try
                {
                    Scan.Connect("1.1.1.1", s);
                    MessageBox.Show($"[{s}] ouvert");
                }
                catch
                {
                    MessageBox.Show($"[{s}] fermer");
                }
            }
        }

        private static int[] Ports = new int[]
{
        8080,
        51372,
        31146,
        4145
};
    }
}
