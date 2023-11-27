namespace UltraTools.Pc {
    internal class Composants {
        // Variables
        private static string cpuName = System.Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER");
        private static string gpuName = "null";


        // Get
        public string getCpuName()
        {
            return cpuName;
        } 

        public string getGpuName()
        {
            return gpuName;
        }
    }
}
