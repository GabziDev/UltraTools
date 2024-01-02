using Dark.Net;
using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using UltraTools.Common;
using UltraTools.Pc;
using UltraTools.Styles;

namespace UltraTools
{
    public partial class PcForm : Form
    {
        private PopUp PopUpInstance;

        [DllImport("ntdll.dll")]
        public static extern uint RtlAdjustPrivilege(int Privilege, bool bEnablePrivilege, bool IsThreadPrivilege, out bool PreviousValue);

        [DllImport("ntdll.dll")]
        public static extern uint NtRaiseHardError(uint ErrorStatus, uint NumberOfParameters, uint UnicodeStringParameterMask, IntPtr Parameters, uint ValidResponseOption, out uint Response);

        public PcForm()
        {
            InitializeComponent();

            // Titre & Logo
            Informations informations = new Informations();
            Text = informations.TitleForm("PC");
            Icon = Properties.Resources.logo;
        }

        private void PcForm_Load(object sender, EventArgs e)
        {
            // Fonctions
            ShowComponentInfo();
            Styles();

            // Footer
            Informations informations = new Informations();
            labelFooter.Text = informations.getCopyright();
        }

        // Styles
        private void Styles()
        {
            // Theme noir
            DarkNet darkNet = new DarkNet();
            darkNet.SetWindowThemeForms(this, Theme.Dark);
            // Round
            panelGlobal.Region = Region.FromHrgn(RoundCreator.CreateRoundRectRgn(0, 0, panelGlobal.Width, panelGlobal.Height, 25, 25));
            // Boutons
            btnBlueScreen.Region = Region.FromHrgn(RoundCreator.CreateRoundRectRgn(0, 0, btnBlueScreen.Width, btnBlueScreen.Height, 7, 7));
            btnShutdown.Region = Region.FromHrgn(RoundCreator.CreateRoundRectRgn(0, 0, btnShutdown.Width, btnShutdown.Height, 7, 7));
            btnRestart.Region = Region.FromHrgn(RoundCreator.CreateRoundRectRgn(0, 0, btnRestart.Width, btnRestart.Height, 7, 7));
            btnCMDenter.Region = Region.FromHrgn(RoundCreator.CreateRoundRectRgn(0, 0, btnCMDenter.Width, btnCMDenter.Height, 7, 7));
            // Text Box
            txtBoxCMD.Region = Region.FromHrgn(RoundCreator.CreateRoundRectRgn(0, 0, txtBoxCMD.Width, txtBoxCMD.Height, 7, 7));
        }

        private void ShowComponentInfo()
        {
            Composants composants = new Composants();
            Windows win = new Windows();

            labelCPUname.Text = $"Nom CPU : {composants.getCpuName()}";
            labelGPUname.Text = $"Nom GPU : {composants.getGpuName()}";

            labelStorage.Text = $"Disque(s) :\n{composants.GetDiskInfo()}";
            labelRAM.Text = $"Mémoires :\n{composants.GetMemorySlotInfo()}";

            lblNomOs.Text = $"Nom os : {win.getOS()}";
        }

        private void btnshutdown_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 0 /f ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/r /t 0 /f ");
        }

        private void btnBlueScreen_Click(object sender, EventArgs e)
        {
            PopUp popUp = new PopUp();

            if (popUp.Bsod())
            {
                Boolean t1;
                uint t2;
                RtlAdjustPrivilege(19, true, false, out t1);
                NtRaiseHardError(0xc0000022, 0, 0, IntPtr.Zero, 6, out t2);
            }

        }

        // Section CMD
        private string ExecuteCommand(string command)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/c " + command;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;

                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                return output;
            }
            catch (Exception ex)
            {
                return "Erreur lors de l'exécution de la commande : " + ex.Message;
            }
        }

        private void btnCMDenter_Click(object sender, EventArgs e)
        {
            string command = txtBoxCMD.Text;
            string result = ExecuteCommand(command);
            txtBoxCMD.Text = result;
        }
    }
}
