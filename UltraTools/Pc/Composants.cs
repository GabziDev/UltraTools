using System.Management;

namespace UltraTools.Pc {
    internal class Composants {
        // Variables
        private static string cpuName = Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER");
        private static string gpuName = "";

        // Listes
        private static List<string> diskList = new List<string>();
        private static List<string> memorySlotList = new List<string>();

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

        static void DiskInfo()
        {
            try
            {
                DriveInfo[] allDrives = DriveInfo.GetDrives();

                foreach (DriveInfo drive in allDrives)
                {
                    double libre = drive.TotalFreeSpace / (1024 * 1024 * 1024);
                    double total = drive.TotalSize / (1024 * 1024 * 1024);
                    double utilise = total - libre;

                    string info = $"- {drive.Name[0]}{drive.Name[1]} {utilise}Go/{total}Go ({drive.DriveFormat})";
                    diskList.Add(info);
                }
            }
            catch
            {
                diskList.Add("Aucun disque détecté...");
            }
        }

        static void MemorySlotInfo()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
                ManagementObjectCollection collection = searcher.Get();

                int slotNumber = 1;

                foreach (ManagementObject obj in collection)
                {
                    ulong capacity = Convert.ToUInt64(obj["Capacity"]);
                    string capacityGB = $"{capacity / (1024 * 1024 * 1024)}Go";
                    memorySlotList.Add($"#{slotNumber++} {capacityGB}");
                }

                while (slotNumber <= collection.Count)
                {
                    memorySlotList.Add($"#{slotNumber++} (Vide)");
                }
            }
            catch
            {
                memorySlotList.Add("Aucun...");
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

        public string GetDiskInfo()
        {
            diskList.Clear(); // Reset la list avant de l'afficher

            DiskInfo();
            return string.Join("\n", diskList);
        }

        public string GetMemorySlotInfo()
        {
            memorySlotList.Clear(); // Reset la list avant de l'afficher

            MemorySlotInfo();
            return string.Join("\n", memorySlotList);
        }
    }
}
