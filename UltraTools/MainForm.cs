﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UltraTools
{
    public partial class MainForm : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UserName();
            heureDate();
            BoutonStyle();
        }

        private void BoutonStyle()
        {
            btnNetwork.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnNetwork.Width, btnNetwork.Height, 7, 7));
            btnInstaller.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnInstaller.Width, btnInstaller.Height, 7, 7));
            btnBackup.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnBackup.Width, btnBackup.Height, 7, 7));
            btnPC.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnPC.Width, btnPC.Height, 7, 7));
        }

        private void UserName()
        {
            try
            {
                string username = Environment.UserName;
                labelUser.Text = username;

                Console.WriteLine($"Nom d'utilisateur : {username}");
            }
            catch
            {
                labelUser.Text = "Erreur lors de la recuperation du nom d'utilisateur";
            }
        }

        private void heureDate()
        {
            DateTime now = DateTime.Now;

            labelHeure.Text = now.ToString("HH:mm:ss");
            labelDate.Text = now.ToString("dd/MM/yyyy");
        }

        private void btnNetwork_Click(object sender, EventArgs e)
        {
            NetworkForm network = new NetworkForm();
            network.ShowDialog();
        }

        private void btnInstaller_Click(object sender, EventArgs e)
        {
            InstallerForm installer = new InstallerForm();
            installer.ShowDialog();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            BackupForm backup = new BackupForm();
            backup.ShowDialog();
        }

        private void btnPC_Click(object sender, EventArgs e)
        {
            PcForm pc = new PcForm();
            pc.ShowDialog();
        }
    }
}
