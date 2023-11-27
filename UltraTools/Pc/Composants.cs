using System.Management;

namespace UltraTools.Pc {
    internal class Composants {
        // Variables
        private static string cpuName = Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER");
        private static string gpuName = "";
        private List<string> ramList;

        // Constructeur
        public Composants()
        {
            ramList = new List<string>();
            RamInfo();
        }

        // Fonctions
        static void GPUname()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
                ManagementObjectCollection collection = searcher.Get();

                foreach (ManagementObject obj in collection)
                {
                    gpuName = obj["Name"].ToString();
                    break;
                }
            } catch {
                gpuName = "Aucun...";
            }
        }

        private void RamInfo()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
                ManagementObjectCollection collection = searcher.Get();

                foreach (ManagementObject obj in collection)
                {
                    string ramBrand = obj["Manufacturer"].ToString();
                    ramList.Add(ramBrand);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la récupération de la marque de la RAM : {ex.Message}");
            }
        }


        // Get
        public string getCpuName()
        {
            return cpuName;
        } 

        public string getGpuName()
        {
            GPUname();
            return gpuName;
        }

        public List<string> GetRamInfo()
        {
            return ramList;
        }
    }
}
