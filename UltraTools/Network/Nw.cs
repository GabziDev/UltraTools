using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace UltraTools.Network
{
    internal class Nw
    {
        // Variables
        private static string hostName;
        private static string ipV4local;
        private static string ipV6local;
        private static string ipGateway;
        private static string ipV4Public;
        private static string macAdr;

        // Fonctions
        public static void HostName()
        {
            hostName = Dns.GetHostName();
        }

        public static void IPlocal()
        {
            IPAddress[] localIPs = Dns.GetHostAddresses(hostName);

            foreach (IPAddress ip in localIPs)
            {
                try
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        ipV4local = ip.ToString();
                    }
                } catch {
                    ipV4local = "Aucun...";
                }

                try
                {
                    if (ip.AddressFamily == AddressFamily.InterNetworkV6)
                    {
                        ipV6local = ip.ToString();
                    }
                } catch
                {
                    ipV6local = "Aucun...";
                }
            }
        }

        public static void GM()
        {
            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface netInterface in networkInterfaces)
            {
                if (netInterface.OperationalStatus == OperationalStatus.Up &&
                    netInterface.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                {
                    IPInterfaceProperties ipProperties = netInterface.GetIPProperties();

                    PhysicalAddress macAddress = netInterface.GetPhysicalAddress();
                    macAdr = macAddress.ToString();

                    GatewayIPAddressInformationCollection gateways = ipProperties.GatewayAddresses;

                    foreach (GatewayIPAddressInformation gateway in gateways)
                    {
                        if (gateway.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            ipGateway = gateway.Address.ToString();
                        }
                    }

                    break;
                }
            }
        }

        public static void IPv4Public()
        {
            try
            {
                string jsonResult = new WebClient().DownloadString("https://ip.gabzdev.ch/");
                JObject jsonObject = JObject.Parse(jsonResult);

                ipV4Public = jsonObject["IpPublic"].ToString();
            }
            catch
            {
                ipV4Public = "Aucun...";
            }
        }

        // Get
        public string getHostName()
        {
            HostName();
            return hostName;
        }

        public string getIPv4Local()
        {
            IPlocal();
            return ipV4local;
        }

        public string getIPv6Local()
        {
            IPlocal();
            return ipV6local;
        }

        public string getIPgateway()
        {
            GM();
            return ipGateway;
        }

        public string getIPv4Public()
        {
            IPv4Public();
            return ipV4Public;
        }

        public string getMacAdr()
        {
            GM();
            return macAdr;
        }
    }
}
