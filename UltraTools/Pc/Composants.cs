using System.Management;

namespace UltraTools.Pc {
    internal class Composants {
        // Variables
        private static string cpuName = Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER");
        private static string gpuName = "";

        // Fonctions
        static void GPUname()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            ManagementObjectCollection collection = searcher.Get();

            foreach (ManagementObject obj in collection)
            {
                gpuName = obj["Name"].ToString();
                break;
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
    }
}
