using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Net.Sockets;

namespace UltraTools.Network
{
    internal class Nw
    {
        // Variables
        private static string nicName;
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

        static void GetIPs()
        {
            NetworkInterface selectedNic = null;

            // Recuperer les interfaces dispo
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up &&
                    (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet || nic.NetworkInterfaceType == NetworkInterfaceType.Wireless80211))
                {
                    if (selectedNic == null || GetInterfacePriority(nic) < GetInterfacePriority(selectedNic))
                    {
                        selectedNic = nic;
                    }
                }
            }

            if (selectedNic != null)
            {
                // Recuperer le nom de la carte
                if (selectedNic != null)
                {
                    nicName = selectedNic.Name;
                }
                else
                {
                    nicName = "Carte réseau";
                }

                // Recuperer les IPs Local
                foreach (UnicastIPAddressInformation ip in selectedNic.GetIPProperties().UnicastAddresses)
                {
                    if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        ipV4local = ip.Address.ToString();
                    } else
                    {
                        ipV4local = "Aucune...";
                    }

                    if (ip.Address.AddressFamily == AddressFamily.InterNetworkV6)
                    {
                        ipV6local = ip.Address.ToString();
                    } else
                    {
                        ipV6local = "Aucune...";
                    }
                }

                // Recuperer l'IP du routeur
                GatewayIPAddressInformationCollection gateways = selectedNic.GetIPProperties().GatewayAddresses;
                if (gateways.Count > 0)
                {
                    if (gateways[0].Address != null)
                    {
                        ipGateway = gateways[0].Address.ToString();
                    }
                    else
                    {
                        ipGateway = "Aucune...";
                    }
                } else
                {
                    ipGateway = "Aucune...";
                }

                // Recuperer l'adresse mac
                if (selectedNic.GetPhysicalAddress() != null)
                {
                    macAdr = selectedNic.GetPhysicalAddress().ToString();
                }
                else
                {
                    macAdr = "Aucune...";
                }
            }
        }

        // Prendre la carte prioritaire
        static int GetInterfacePriority(NetworkInterface nic)
        {
            return nic.GetIPProperties().GetIPv4Properties().Index;
        }

        // Recup l'adresse ip public
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
                ipV4Public = "Aucune...";
            }
        }

        // Get
        public string getNicName()
        {
            GetIPs();
            return nicName;
        }

        public string getHostName()
        {
            HostName();
            return hostName;
        }

        public string getIPv4Local()
        {
            GetIPs();
            return ipV4local;
        }

        public string getIPv6Local()
        {
            GetIPs();
            return ipV6local;
        }

        public string getIPgateway()
        {
            GetIPs();
            return ipGateway;
        }

        public string getIPv4Public()
        {
            IPv4Public();
            return ipV4Public;
        }

        public string getMacAdr()
        {
            GetIPs();
            return macAdr;
        }
    }
}
