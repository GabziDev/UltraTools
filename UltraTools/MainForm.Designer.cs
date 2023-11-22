using System.Drawing.Drawing2D;

namespace UltraTools
{
    partial class MainForm
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
            btnNetwork = new Button();
            btnInstaller = new Button();
            btnBackup = new Button();
            btnPC = new Button();
            panelNavbar = new Panel();
            labelTitre = new Label();
            labelBvn = new Label();
            labelUser = new Label();
            labelHeure = new Label();
            labelDate = new Label();
            panelMiddle = new Panel();
            panelNavbar.SuspendLayout();
            panelMiddle.SuspendLayout();
            SuspendLayout();
            // 
            // btnNetwork
            // 
            btnNetwork.BackColor = Color.FromArgb(46, 46, 83);
            btnNetwork.FlatAppearance.BorderSize = 0;
            btnNetwork.FlatStyle = FlatStyle.Flat;
            btnNetwork.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNetwork.ForeColor = SystemColors.Control;
            btnNetwork.Location = new Point(607, 17);
            btnNetwork.Margin = new Padding(3, 4, 3, 4);
            btnNetwork.Name = "btnNetwork";
            btnNetwork.Size = new Size(86, 43);
            btnNetwork.TabIndex = 0;
            btnNetwork.Text = "Réseaux";
            btnNetwork.UseVisualStyleBackColor = false;
            btnNetwork.Click += btnNetwork_Click;
            // 
            // btnInstaller
            // 
            btnInstaller.BackColor = Color.FromArgb(46, 46, 83);
            btnInstaller.FlatAppearance.BorderSize = 0;
            btnInstaller.FlatStyle = FlatStyle.Flat;
            btnInstaller.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnInstaller.ForeColor = SystemColors.Control;
            btnInstaller.Location = new Point(699, 17);
            btnInstaller.Margin = new Padding(3, 4, 3, 4);
            btnInstaller.Name = "btnInstaller";
            btnInstaller.Size = new Size(88, 43);
            btnInstaller.TabIndex = 1;
            btnInstaller.Text = "Installeur";
            btnInstaller.UseVisualStyleBackColor = false;
            btnInstaller.Click += btnInstaller_Click;
            // 
            // btnBackup
            // 
            btnBackup.BackColor = Color.FromArgb(46, 46, 83);
            btnBackup.FlatAppearance.BorderSize = 0;
            btnBackup.FlatStyle = FlatStyle.Flat;
            btnBackup.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBackup.ForeColor = SystemColors.Control;
            btnBackup.Location = new Point(794, 17);
            btnBackup.Margin = new Padding(3, 4, 3, 4);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(86, 43);
            btnBackup.TabIndex = 2;
            btnBackup.Text = "Backup";
            btnBackup.UseVisualStyleBackColor = false;
            btnBackup.Click += btnBackup_Click;
            // 
            // btnPC
            // 
            btnPC.BackColor = Color.FromArgb(46, 46, 83);
            btnPC.FlatAppearance.BorderSize = 0;
            btnPC.FlatStyle = FlatStyle.Flat;
            btnPC.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPC.ForeColor = SystemColors.Control;
            btnPC.Location = new Point(887, 17);
            btnPC.Margin = new Padding(3, 4, 3, 4);
            btnPC.Name = "btnPC";
            btnPC.Size = new Size(86, 43);
            btnPC.TabIndex = 3;
            btnPC.Text = "PC";
            btnPC.UseVisualStyleBackColor = false;
            btnPC.Click += btnPC_Click;
            // 
            // panelNavbar
            // 
            panelNavbar.BackColor = Color.FromArgb(38, 39, 70);
            panelNavbar.Controls.Add(labelTitre);
            panelNavbar.Controls.Add(btnPC);
            panelNavbar.Controls.Add(btnBackup);
            panelNavbar.Controls.Add(btnNetwork);
            panelNavbar.Controls.Add(btnInstaller);
            panelNavbar.Location = new Point(0, 0);
            panelNavbar.Margin = new Padding(3, 4, 3, 4);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(990, 77);
            panelNavbar.TabIndex = 4;
            // 
            // labelTitre
            // 
            labelTitre.AutoSize = true;
            labelTitre.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitre.ForeColor = SystemColors.ControlLightLight;
            labelTitre.Location = new Point(0, 17);
            labelTitre.Name = "labelTitre";
            labelTitre.Size = new Size(189, 39);
            labelTitre.TabIndex = 0;
            labelTitre.Text = "UltraTools";
            // 
            // labelBvn
            // 
            labelBvn.AutoSize = true;
            labelBvn.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelBvn.ForeColor = SystemColors.Control;
            labelBvn.Location = new Point(2, 0);
            labelBvn.MaximumSize = new Size(314, 80);
            labelBvn.MinimumSize = new Size(314, 27);
            labelBvn.Name = "labelBvn";
            labelBvn.Size = new Size(314, 51);
            labelBvn.TabIndex = 6;
            labelBvn.Text = "Bienvenue";
            labelBvn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelUser.ForeColor = Color.FromArgb(128, 128, 255);
            labelUser.Location = new Point(3, 53);
            labelUser.MaximumSize = new Size(314, 80);
            labelUser.MinimumSize = new Size(314, 27);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(314, 37);
            labelUser.TabIndex = 7;
            labelUser.Text = "nomUtilisateur";
            labelUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelHeure
            // 
            labelHeure.AutoSize = true;
            labelHeure.Font = new Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelHeure.ForeColor = SystemColors.Control;
            labelHeure.Location = new Point(3, 143);
            labelHeure.MaximumSize = new Size(314, 80);
            labelHeure.MinimumSize = new Size(314, 27);
            labelHeure.Name = "labelHeure";
            labelHeure.Size = new Size(314, 43);
            labelHeure.TabIndex = 9;
            labelHeure.Text = "labelHeure";
            labelHeure.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate.ForeColor = Color.FromArgb(128, 128, 255);
            labelDate.Location = new Point(2, 187);
            labelDate.MaximumSize = new Size(314, 80);
            labelDate.MinimumSize = new Size(314, 27);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(314, 37);
            labelDate.TabIndex = 10;
            labelDate.Text = "labelDate";
            labelDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelMiddle
            // 
            panelMiddle.Controls.Add(labelBvn);
            panelMiddle.Controls.Add(labelDate);
            panelMiddle.Controls.Add(labelUser);
            panelMiddle.Controls.Add(labelHeure);
            panelMiddle.Location = new Point(344, 260);
            panelMiddle.Margin = new Padding(3, 4, 3, 4);
            panelMiddle.Name = "panelMiddle";
            panelMiddle.Size = new Size(320, 227);
            panelMiddle.TabIndex = 11;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 46, 83);
            ClientSize = new Size(990, 717);
            Controls.Add(panelMiddle);
            Controls.Add(panelNavbar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += MainForm_Load;
            panelNavbar.ResumeLayout(false);
            panelNavbar.PerformLayout();
            panelMiddle.ResumeLayout(false);
            panelMiddle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNetwork;
        private Button btnInstaller;
        private Button btnBackup;
        private Button btnPC;
        private Panel panelNavbar;
        private Label labelTitre;
        private Label labelBvn;
        private Label labelUser;
        private Label labelHeure;
        private Label labelDate;
        private Panel panelMiddle;
    }
}