﻿using Dark.Net;
using System.Diagnostics;
using UltraTools.Common;
using UltraTools.Pc;
using UltraTools.Styles;

namespace UltraTools
{
    public partial class PcForm : Form
    {
        // Instances

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
    }
}
