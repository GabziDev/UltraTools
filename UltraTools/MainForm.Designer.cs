﻿using System.Drawing.Drawing2D;

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
            panel1 = new Panel();
            labelTitre = new Label();
            labelBvn = new Label();
            labelUser = new Label();
            labelHeure = new Label();
            labelDate = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnNetwork
            // 
            btnNetwork.BackColor = Color.FromArgb(46, 46, 83);
            btnNetwork.FlatAppearance.BorderSize = 0;
            btnNetwork.FlatStyle = FlatStyle.Flat;
            btnNetwork.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNetwork.ForeColor = SystemColors.Control;
            btnNetwork.Location = new Point(531, 13);
            btnNetwork.Name = "btnNetwork";
            btnNetwork.Size = new Size(75, 32);
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
            btnInstaller.Location = new Point(612, 13);
            btnInstaller.Name = "btnInstaller";
            btnInstaller.Size = new Size(77, 32);
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
            btnBackup.Location = new Point(695, 13);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(75, 32);
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
            btnPC.Location = new Point(776, 13);
            btnPC.Name = "btnPC";
            btnPC.Size = new Size(75, 32);
            btnPC.TabIndex = 3;
            btnPC.Text = "PC";
            btnPC.UseVisualStyleBackColor = false;
            btnPC.Click += btnPC_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(38, 39, 70);
            panel1.Controls.Add(labelTitre);
            panel1.Controls.Add(btnPC);
            panel1.Controls.Add(btnBackup);
            panel1.Controls.Add(btnNetwork);
            panel1.Controls.Add(btnInstaller);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(866, 58);
            panel1.TabIndex = 4;
            // 
            // labelTitre
            // 
            labelTitre.AutoSize = true;
            labelTitre.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitre.ForeColor = SystemColors.ControlLightLight;
            labelTitre.Location = new Point(0, 13);
            labelTitre.Name = "labelTitre";
            labelTitre.Size = new Size(151, 32);
            labelTitre.TabIndex = 0;
            labelTitre.Text = "UltraTools";
            // 
            // labelBvn
            // 
            labelBvn.AutoSize = true;
            labelBvn.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelBvn.ForeColor = SystemColors.Control;
            labelBvn.Location = new Point(2, 0);
            labelBvn.MaximumSize = new Size(275, 60);
            labelBvn.MinimumSize = new Size(275, 20);
            labelBvn.Name = "labelBvn";
            labelBvn.Size = new Size(275, 40);
            labelBvn.TabIndex = 6;
            labelBvn.Text = "Bienvenue";
            labelBvn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelUser.ForeColor = Color.FromArgb(128, 128, 255);
            labelUser.Location = new Point(3, 40);
            labelUser.MaximumSize = new Size(275, 60);
            labelUser.MinimumSize = new Size(275, 20);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(275, 30);
            labelUser.TabIndex = 7;
            labelUser.Text = "nomUtilisateur";
            labelUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelHeure
            // 
            labelHeure.AutoSize = true;
            labelHeure.Font = new Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelHeure.ForeColor = SystemColors.Control;
            labelHeure.Location = new Point(3, 107);
            labelHeure.MaximumSize = new Size(275, 60);
            labelHeure.MinimumSize = new Size(275, 20);
            labelHeure.Name = "labelHeure";
            labelHeure.Size = new Size(275, 33);
            labelHeure.TabIndex = 9;
            labelHeure.Text = "label6";
            labelHeure.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate.ForeColor = Color.FromArgb(128, 128, 255);
            labelDate.Location = new Point(2, 140);
            labelDate.MaximumSize = new Size(275, 60);
            labelDate.MinimumSize = new Size(275, 20);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(275, 30);
            labelDate.TabIndex = 10;
            labelDate.Text = "label2";
            labelDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelBvn);
            panel2.Controls.Add(labelDate);
            panel2.Controls.Add(labelUser);
            panel2.Controls.Add(labelHeure);
            panel2.Location = new Point(285, 178);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 170);
            panel2.TabIndex = 11;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 46, 83);
            ClientSize = new Size(866, 538);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UltraTools - Menu";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNetwork;
        private Button btnInstaller;
        private Button btnBackup;
        private Button btnPC;
        private Panel panel1;
        private Label labelTitre;
        private Label labelBvn;
        private Label labelUser;
        private Label labelHeure;
        private Label labelDate;
        private Panel panel2;
    }
}