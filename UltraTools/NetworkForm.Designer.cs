namespace UltraTools
{
    partial class NetworkForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelIPv4Local = new Label();
            labelIPv4Public = new Label();
            panelNameNic = new Panel();
            labelNicName = new Label();
            labelHostName = new Label();
            panelInfoNetwork = new Panel();
            labelMacAdr = new Label();
            labelIProuter = new Label();
            labelIPv6Local = new Label();
            panelScanPort = new Panel();
            labelStatusScanningPort = new Label();
            underlineTextboxSP = new Panel();
            labelShowClosePort = new Label();
            labelShowOpenPort = new Label();
            buttonScan = new Button();
            textBoxScanPort = new TextBox();
            labelScanTitle = new Label();
            panelWhois = new Panel();
            labelRegistrarName = new Label();
            labelStatusScanningWhois = new Label();
            labelServ2 = new Label();
            labelServ1 = new Label();
            labelStatusDomain = new Label();
            labelCreatedDate = new Label();
            labelDomainName = new Label();
            underlineTextboxWD = new Panel();
            buttonLookUp = new Button();
            textBoxDomain = new TextBox();
            labelWhoisTitle = new Label();
            labelFooter = new Label();
            panelNameNic.SuspendLayout();
            panelInfoNetwork.SuspendLayout();
            panelScanPort.SuspendLayout();
            panelWhois.SuspendLayout();
            SuspendLayout();
            // 
            // labelIPv4Local
            // 
            labelIPv4Local.AutoSize = true;
            labelIPv4Local.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelIPv4Local.ForeColor = SystemColors.Control;
            labelIPv4Local.Location = new Point(3, 25);
            labelIPv4Local.Name = "labelIPv4Local";
            labelIPv4Local.Size = new Size(87, 21);
            labelIPv4Local.TabIndex = 8;
            labelIPv4Local.Text = "IPv4 Local :";
            labelIPv4Local.Click += labelIPv4Local_Click;
            labelIPv4Local.MouseLeave += labelIPv4Local_MouseLeave;
            labelIPv4Local.MouseHover += labelIPv4Local_MouseHover;
            // 
            // labelIPv4Public
            // 
            labelIPv4Public.AutoSize = true;
            labelIPv4Public.FlatStyle = FlatStyle.System;
            labelIPv4Public.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelIPv4Public.ForeColor = SystemColors.Control;
            labelIPv4Public.Location = new Point(299, 25);
            labelIPv4Public.Name = "labelIPv4Public";
            labelIPv4Public.Size = new Size(80, 21);
            labelIPv4Public.TabIndex = 10;
            labelIPv4Public.Text = " IP Public :";
            labelIPv4Public.Click += labelIPv4Public_Click;
            labelIPv4Public.MouseLeave += labelIPv4Public_MouseLeave;
            labelIPv4Public.MouseHover += labelIPv4Public_MouseHover;
            // 
            // panelNameNic
            // 
            panelNameNic.BackColor = Color.FromArgb(38, 39, 70);
            panelNameNic.Controls.Add(labelNicName);
            panelNameNic.Location = new Point(12, 6);
            panelNameNic.Name = "panelNameNic";
            panelNameNic.Size = new Size(202, 38);
            panelNameNic.TabIndex = 12;
            // 
            // labelNicName
            // 
            labelNicName.AutoSize = true;
            labelNicName.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            labelNicName.ForeColor = Color.MediumSlateBlue;
            labelNicName.Location = new Point(3, 3);
            labelNicName.Name = "labelNicName";
            labelNicName.Size = new Size(136, 28);
            labelNicName.TabIndex = 0;
            labelNicName.Text = "Carte Réseau";
            // 
            // labelHostName
            // 
            labelHostName.AutoSize = true;
            labelHostName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelHostName.ForeColor = SystemColors.Control;
            labelHostName.Location = new Point(3, 4);
            labelHostName.Name = "labelHostName";
            labelHostName.Size = new Size(102, 21);
            labelHostName.TabIndex = 17;
            labelHostName.Text = "Nom d'Hôte :";
            // 
            // panelInfoNetwork
            // 
            panelInfoNetwork.BackColor = Color.FromArgb(38, 39, 70);
            panelInfoNetwork.Controls.Add(labelHostName);
            panelInfoNetwork.Controls.Add(labelMacAdr);
            panelInfoNetwork.Controls.Add(labelIProuter);
            panelInfoNetwork.Controls.Add(labelIPv6Local);
            panelInfoNetwork.Controls.Add(labelIPv4Local);
            panelInfoNetwork.Controls.Add(labelIPv4Public);
            panelInfoNetwork.Location = new Point(12, 50);
            panelInfoNetwork.Name = "panelInfoNetwork";
            panelInfoNetwork.Size = new Size(776, 74);
            panelInfoNetwork.TabIndex = 16;
            // 
            // labelMacAdr
            // 
            labelMacAdr.AutoSize = true;
            labelMacAdr.FlatStyle = FlatStyle.System;
            labelMacAdr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelMacAdr.ForeColor = SystemColors.Control;
            labelMacAdr.Location = new Point(541, 4);
            labelMacAdr.Name = "labelMacAdr";
            labelMacAdr.Size = new Size(110, 21);
            labelMacAdr.TabIndex = 15;
            labelMacAdr.Text = "Adresse MAC :";
            labelMacAdr.Click += labelMacAdr_Click;
            labelMacAdr.MouseLeave += labelMacAdr_MouseLeave;
            labelMacAdr.MouseHover += labelMacAdr_MouseHover;
            // 
            // labelIProuter
            // 
            labelIProuter.AutoSize = true;
            labelIProuter.FlatStyle = FlatStyle.System;
            labelIProuter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelIProuter.ForeColor = SystemColors.Control;
            labelIProuter.Location = new Point(299, 4);
            labelIProuter.Name = "labelIProuter";
            labelIProuter.Size = new Size(106, 21);
            labelIProuter.TabIndex = 13;
            labelIProuter.Text = " IP Passerelle :";
            labelIProuter.Click += labelIProuter_Click;
            labelIProuter.MouseLeave += labelIProuter_MouseLeave;
            labelIProuter.MouseHover += labelIProuter_MouseHover;
            // 
            // labelIPv6Local
            // 
            labelIPv6Local.AutoSize = true;
            labelIPv6Local.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelIPv6Local.ForeColor = SystemColors.Control;
            labelIPv6Local.Location = new Point(3, 46);
            labelIPv6Local.Name = "labelIPv6Local";
            labelIPv6Local.Size = new Size(87, 21);
            labelIPv6Local.TabIndex = 12;
            labelIPv6Local.Text = "IPv6 Local :";
            labelIPv6Local.Click += labelIPv6Local_Click;
            labelIPv6Local.MouseLeave += labelIPv6Local_MouseLeave;
            labelIPv6Local.MouseHover += labelIPv6Local_MouseHover;
            // 
            // panelScanPort
            // 
            panelScanPort.BackColor = Color.FromArgb(38, 39, 70);
            panelScanPort.Controls.Add(labelStatusScanningPort);
            panelScanPort.Controls.Add(underlineTextboxSP);
            panelScanPort.Controls.Add(labelShowClosePort);
            panelScanPort.Controls.Add(labelShowOpenPort);
            panelScanPort.Controls.Add(buttonScan);
            panelScanPort.Controls.Add(textBoxScanPort);
            panelScanPort.Controls.Add(labelScanTitle);
            panelScanPort.Location = new Point(12, 130);
            panelScanPort.Name = "panelScanPort";
            panelScanPort.Size = new Size(776, 149);
            panelScanPort.TabIndex = 13;
            // 
            // labelStatusScanningPort
            // 
            labelStatusScanningPort.AutoSize = true;
            labelStatusScanningPort.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelStatusScanningPort.ForeColor = Color.Red;
            labelStatusScanningPort.Location = new Point(276, 10);
            labelStatusScanningPort.Name = "labelStatusScanningPort";
            labelStatusScanningPort.Size = new Size(258, 20);
            labelStatusScanningPort.TabIndex = 7;
            labelStatusScanningPort.Text = "Veuillez patienter, nous scannons l'IP...";
            // 
            // underlineTextboxSP
            // 
            underlineTextboxSP.BackColor = Color.MediumSlateBlue;
            underlineTextboxSP.Location = new Point(75, 53);
            underlineTextboxSP.Name = "underlineTextboxSP";
            underlineTextboxSP.Size = new Size(100, 2);
            underlineTextboxSP.TabIndex = 6;
            // 
            // labelShowClosePort
            // 
            labelShowClosePort.AutoSize = true;
            labelShowClosePort.ForeColor = SystemColors.Control;
            labelShowClosePort.Location = new Point(495, 35);
            labelShowClosePort.Name = "labelShowClosePort";
            labelShowClosePort.Size = new Size(82, 15);
            labelShowClosePort.TabIndex = 4;
            labelShowClosePort.Text = "Port(s) Fermer";
            // 
            // labelShowOpenPort
            // 
            labelShowOpenPort.AutoSize = true;
            labelShowOpenPort.ForeColor = SystemColors.Control;
            labelShowOpenPort.Location = new Point(276, 35);
            labelShowOpenPort.Name = "labelShowOpenPort";
            labelShowOpenPort.Size = new Size(81, 15);
            labelShowOpenPort.TabIndex = 3;
            labelShowOpenPort.Text = "Port(s) Ouvert";
            // 
            // buttonScan
            // 
            buttonScan.Location = new Point(75, 78);
            buttonScan.Name = "buttonScan";
            buttonScan.Size = new Size(100, 23);
            buttonScan.TabIndex = 2;
            buttonScan.Text = "Lancer";
            buttonScan.UseVisualStyleBackColor = true;
            buttonScan.Click += buttonScan_Click_1;
            // 
            // textBoxScanPort
            // 
            textBoxScanPort.BackColor = Color.FromArgb(38, 39, 70);
            textBoxScanPort.BorderStyle = BorderStyle.None;
            textBoxScanPort.ForeColor = Color.White;
            textBoxScanPort.Location = new Point(75, 35);
            textBoxScanPort.Name = "textBoxScanPort";
            textBoxScanPort.Size = new Size(100, 16);
            textBoxScanPort.TabIndex = 1;
            textBoxScanPort.Text = "Adresse IP...";
            // 
            // labelScanTitle
            // 
            labelScanTitle.AutoSize = true;
            labelScanTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelScanTitle.ForeColor = Color.MediumSlateBlue;
            labelScanTitle.ImageAlign = ContentAlignment.TopCenter;
            labelScanTitle.Location = new Point(-263, 0);
            labelScanTitle.MinimumSize = new Size(775, 20);
            labelScanTitle.Name = "labelScanTitle";
            labelScanTitle.Size = new Size(775, 32);
            labelScanTitle.TabIndex = 0;
            labelScanTitle.Text = "Scan Port";
            labelScanTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelWhois
            // 
            panelWhois.BackColor = Color.FromArgb(38, 39, 70);
            panelWhois.Controls.Add(labelRegistrarName);
            panelWhois.Controls.Add(labelStatusScanningWhois);
            panelWhois.Controls.Add(labelServ2);
            panelWhois.Controls.Add(labelServ1);
            panelWhois.Controls.Add(labelStatusDomain);
            panelWhois.Controls.Add(labelCreatedDate);
            panelWhois.Controls.Add(labelDomainName);
            panelWhois.Controls.Add(underlineTextboxWD);
            panelWhois.Controls.Add(buttonLookUp);
            panelWhois.Controls.Add(textBoxDomain);
            panelWhois.Controls.Add(labelWhoisTitle);
            panelWhois.Location = new Point(12, 285);
            panelWhois.Name = "panelWhois";
            panelWhois.Size = new Size(776, 138);
            panelWhois.TabIndex = 14;
            // 
            // labelRegistrarName
            // 
            labelRegistrarName.AutoSize = true;
            labelRegistrarName.ForeColor = SystemColors.Control;
            labelRegistrarName.Location = new Point(495, 82);
            labelRegistrarName.Name = "labelRegistrarName";
            labelRegistrarName.Size = new Size(110, 15);
            labelRegistrarName.TabIndex = 13;
            labelRegistrarName.Text = "Nom de registre : ...";
            // 
            // labelStatusScanningWhois
            // 
            labelStatusScanningWhois.AutoSize = true;
            labelStatusScanningWhois.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelStatusScanningWhois.ForeColor = Color.Red;
            labelStatusScanningWhois.Location = new Point(276, 10);
            labelStatusScanningWhois.Name = "labelStatusScanningWhois";
            labelStatusScanningWhois.Size = new Size(311, 20);
            labelStatusScanningWhois.TabIndex = 8;
            labelStatusScanningWhois.Text = "Veuillez patienter, nous scannons le domaine..";
            // 
            // labelServ2
            // 
            labelServ2.AutoSize = true;
            labelServ2.ForeColor = SystemColors.Control;
            labelServ2.Location = new Point(495, 58);
            labelServ2.Name = "labelServ2";
            labelServ2.Size = new Size(124, 15);
            labelServ2.TabIndex = 12;
            labelServ2.Text = "Serveur secondaire : ...";
            // 
            // labelServ1
            // 
            labelServ1.AutoSize = true;
            labelServ1.ForeColor = SystemColors.Control;
            labelServ1.Location = new Point(495, 35);
            labelServ1.Name = "labelServ1";
            labelServ1.Size = new Size(111, 15);
            labelServ1.TabIndex = 11;
            labelServ1.Text = "Serveur primaire : ...";
            // 
            // labelStatusDomain
            // 
            labelStatusDomain.AutoSize = true;
            labelStatusDomain.ForeColor = SystemColors.Control;
            labelStatusDomain.Location = new Point(276, 82);
            labelStatusDomain.Name = "labelStatusDomain";
            labelStatusDomain.Size = new Size(57, 15);
            labelStatusDomain.TabIndex = 10;
            labelStatusDomain.Text = "Status : ...";
            // 
            // labelCreatedDate
            // 
            labelCreatedDate.AutoSize = true;
            labelCreatedDate.ForeColor = SystemColors.Control;
            labelCreatedDate.Location = new Point(276, 58);
            labelCreatedDate.Name = "labelCreatedDate";
            labelCreatedDate.Size = new Size(111, 15);
            labelCreatedDate.TabIndex = 9;
            labelCreatedDate.Text = "Date de création : ...";
            // 
            // labelDomainName
            // 
            labelDomainName.AutoSize = true;
            labelDomainName.ForeColor = SystemColors.Control;
            labelDomainName.Location = new Point(276, 35);
            labelDomainName.Name = "labelDomainName";
            labelDomainName.Size = new Size(118, 15);
            labelDomainName.TabIndex = 8;
            labelDomainName.Text = "Nom de domaine : ...";
            // 
            // underlineTextboxWD
            // 
            underlineTextboxWD.BackColor = Color.MediumSlateBlue;
            underlineTextboxWD.Location = new Point(77, 53);
            underlineTextboxWD.Name = "underlineTextboxWD";
            underlineTextboxWD.Size = new Size(100, 2);
            underlineTextboxWD.TabIndex = 7;
            // 
            // buttonLookUp
            // 
            buttonLookUp.Location = new Point(77, 80);
            buttonLookUp.Name = "buttonLookUp";
            buttonLookUp.Size = new Size(100, 23);
            buttonLookUp.TabIndex = 3;
            buttonLookUp.Text = "Lancer";
            buttonLookUp.UseVisualStyleBackColor = true;
            buttonLookUp.Click += buttonLookUp_Click;
            // 
            // textBoxDomain
            // 
            textBoxDomain.BackColor = Color.FromArgb(38, 39, 70);
            textBoxDomain.BorderStyle = BorderStyle.None;
            textBoxDomain.ForeColor = Color.White;
            textBoxDomain.Location = new Point(77, 35);
            textBoxDomain.Name = "textBoxDomain";
            textBoxDomain.Size = new Size(100, 16);
            textBoxDomain.TabIndex = 2;
            textBoxDomain.Text = "Domaine...";
            // 
            // labelWhoisTitle
            // 
            labelWhoisTitle.AutoSize = true;
            labelWhoisTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelWhoisTitle.ForeColor = Color.MediumSlateBlue;
            labelWhoisTitle.ImageAlign = ContentAlignment.TopCenter;
            labelWhoisTitle.Location = new Point(-263, 0);
            labelWhoisTitle.MinimumSize = new Size(775, 20);
            labelWhoisTitle.Name = "labelWhoisTitle";
            labelWhoisTitle.Size = new Size(775, 32);
            labelWhoisTitle.TabIndex = 1;
            labelWhoisTitle.Text = "Whois Domain";
            labelWhoisTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelFooter
            // 
            labelFooter.AutoSize = true;
            labelFooter.ForeColor = Color.White;
            labelFooter.Location = new Point(12, 426);
            labelFooter.Name = "labelFooter";
            labelFooter.Size = new Size(66, 15);
            labelFooter.TabIndex = 15;
            labelFooter.Text = "labelFooter";
            // 
            // NetworkForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 46, 83);
            ClientSize = new Size(800, 450);
            Controls.Add(panelNameNic);
            Controls.Add(labelFooter);
            Controls.Add(panelWhois);
            Controls.Add(panelScanPort);
            Controls.Add(panelInfoNetwork);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "NetworkForm";
            Load += NetworkForm_Load;
            panelNameNic.ResumeLayout(false);
            panelNameNic.PerformLayout();
            panelInfoNetwork.ResumeLayout(false);
            panelInfoNetwork.PerformLayout();
            panelScanPort.ResumeLayout(false);
            panelScanPort.PerformLayout();
            panelWhois.ResumeLayout(false);
            panelWhois.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelIPv4Local;
        private Label labelIPv4Public;
        private Panel panelNameNic;
        private Panel panelInfoNetwork;
        private Panel panelScanPort;
        private Label labelScanTitle;
        private Panel panelWhois;
        private Label labelWhoisTitle;
        private TextBox textBoxScanPort;
        private TextBox textBoxDomain;
        private Button buttonScan;
        private Button buttonLookUp;
        private Label labelIPv6Local;
        private Label labelIProuter;
        private Label labelShowClosePort;
        private Label labelShowOpenPort;
        private Label labelFooter;
        private Label labelMacAdr;
        private Panel underlineTextboxSP;
        private Panel underlineTextboxWD;
        private Label labelStatusScanningPort;
        private Label labelDomainName;
        private Label labelCreatedDate;
        private Label labelStatusDomain;
        private Label labelServ1;
        private Label labelServ2;
        private Label labelRegistrarName;
        private Label labelStatusScanningWhois;
        private Label labelNicName;
        private Label labelHostName;
    }
}