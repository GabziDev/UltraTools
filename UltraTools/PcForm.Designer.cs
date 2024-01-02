namespace UltraTools
{
    partial class PcForm
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
            panelGlobal = new Panel();
            btnShutdown = new Button();
            btnRestart = new Button();
            btnBlueScreen = new Button();
            btnCMDenter = new Button();
            txtBoxCMD = new RichTextBox();
            lblNomOs = new Label();
            labelGPUname = new Label();
            labelCPUname = new Label();
            labelStorage = new Label();
            labelRAM = new Label();
            labelFooter = new Label();
            panelGlobal.SuspendLayout();
            SuspendLayout();
            // 
            // panelGlobal
            // 
            panelGlobal.BackColor = Color.FromArgb(38, 39, 70);
            panelGlobal.Controls.Add(btnShutdown);
            panelGlobal.Controls.Add(btnRestart);
            panelGlobal.Controls.Add(btnBlueScreen);
            panelGlobal.Controls.Add(btnCMDenter);
            panelGlobal.Controls.Add(txtBoxCMD);
            panelGlobal.Controls.Add(lblNomOs);
            panelGlobal.Controls.Add(labelGPUname);
            panelGlobal.Controls.Add(labelCPUname);
            panelGlobal.Controls.Add(labelStorage);
            panelGlobal.Controls.Add(labelRAM);
            panelGlobal.Location = new Point(12, 12);
            panelGlobal.Name = "panelGlobal";
            panelGlobal.Size = new Size(776, 409);
            panelGlobal.TabIndex = 15;
            // 
            // btnShutdown
            // 
            btnShutdown.BackColor = Color.FromArgb(46, 46, 83);
            btnShutdown.FlatAppearance.BorderSize = 0;
            btnShutdown.FlatStyle = FlatStyle.Flat;
            btnShutdown.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnShutdown.ForeColor = SystemColors.Control;
            btnShutdown.Location = new Point(632, 146);
            btnShutdown.Name = "btnShutdown";
            btnShutdown.Size = new Size(125, 30);
            btnShutdown.TabIndex = 14;
            btnShutdown.Text = "Arrêter le PC";
            btnShutdown.UseVisualStyleBackColor = true;
            // 
            // btnRestart
            // 
            btnRestart.BackColor = Color.FromArgb(46, 46, 83);
            btnRestart.FlatAppearance.BorderSize = 0;
            btnRestart.FlatStyle = FlatStyle.Flat;
            btnRestart.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRestart.ForeColor = SystemColors.Control;
            btnRestart.Location = new Point(632, 182);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(125, 30);
            btnRestart.TabIndex = 13;
            btnRestart.Text = "Redémarrer le PC";
            btnRestart.UseVisualStyleBackColor = true;
            // 
            // btnBlueScreen
            // 
            btnBlueScreen.BackColor = Color.FromArgb(46, 46, 83);
            btnBlueScreen.FlatAppearance.BorderSize = 0;
            btnBlueScreen.FlatStyle = FlatStyle.Flat;
            btnBlueScreen.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBlueScreen.ForeColor = SystemColors.Control;
            btnBlueScreen.Location = new Point(632, 218);
            btnBlueScreen.Name = "btnBlueScreen";
            btnBlueScreen.Size = new Size(125, 30);
            btnBlueScreen.TabIndex = 12;
            btnBlueScreen.Text = "Blue Screen";
            btnBlueScreen.UseVisualStyleBackColor = true;
            btnBlueScreen.Click += btnBlueScreen_Click;
            // 
            // btnCMDenter
            // 
            btnCMDenter.BackColor = Color.FromArgb(46, 46, 83);
            btnCMDenter.FlatAppearance.BorderSize = 0;
            btnCMDenter.FlatStyle = FlatStyle.Flat;
            btnCMDenter.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnCMDenter.ForeColor = Color.FromArgb(128, 128, 255);
            btnCMDenter.Location = new Point(655, 279);
            btnCMDenter.Name = "btnCMDenter";
            btnCMDenter.Size = new Size(102, 115);
            btnCMDenter.TabIndex = 11;
            btnCMDenter.Text = "Executer";
            btnCMDenter.UseVisualStyleBackColor = true;
            btnCMDenter.Click += btnCMDenter_Click;
            // 
            // txtBoxCMD
            // 
            txtBoxCMD.BackColor = Color.FromArgb(46, 46, 83);
            txtBoxCMD.BorderStyle = BorderStyle.None;
            txtBoxCMD.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxCMD.ForeColor = SystemColors.Menu;
            txtBoxCMD.Location = new Point(14, 279);
            txtBoxCMD.Name = "txtBoxCMD";
            txtBoxCMD.Size = new Size(635, 115);
            txtBoxCMD.TabIndex = 10;
            txtBoxCMD.Text = "";
            // 
            // lblNomOs
            // 
            lblNomOs.AutoSize = true;
            lblNomOs.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomOs.ForeColor = SystemColors.Control;
            lblNomOs.Location = new Point(3, 53);
            lblNomOs.Name = "lblNomOs";
            lblNomOs.Size = new Size(85, 21);
            lblNomOs.TabIndex = 4;
            lblNomOs.Text = "Nom os : ...";
            // 
            // labelGPUname
            // 
            labelGPUname.AutoSize = true;
            labelGPUname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelGPUname.ForeColor = SystemColors.Control;
            labelGPUname.Location = new Point(3, 32);
            labelGPUname.Name = "labelGPUname";
            labelGPUname.Size = new Size(100, 21);
            labelGPUname.TabIndex = 3;
            labelGPUname.Text = "Nom GPU : ...";
            // 
            // labelCPUname
            // 
            labelCPUname.AutoSize = true;
            labelCPUname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCPUname.ForeColor = SystemColors.Control;
            labelCPUname.Location = new Point(3, 11);
            labelCPUname.Name = "labelCPUname";
            labelCPUname.Size = new Size(99, 21);
            labelCPUname.TabIndex = 2;
            labelCPUname.Text = "Nom CPU : ...";
            // 
            // labelStorage
            // 
            labelStorage.AutoSize = true;
            labelStorage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelStorage.ForeColor = SystemColors.Control;
            labelStorage.Location = new Point(3, 101);
            labelStorage.Name = "labelStorage";
            labelStorage.Size = new Size(95, 21);
            labelStorage.TabIndex = 1;
            labelStorage.Text = "Disque(s) : ...";
            // 
            // labelRAM
            // 
            labelRAM.AutoSize = true;
            labelRAM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelRAM.ForeColor = SystemColors.Control;
            labelRAM.Location = new Point(586, 11);
            labelRAM.Name = "labelRAM";
            labelRAM.Size = new Size(100, 21);
            labelRAM.TabIndex = 0;
            labelRAM.Text = "Mémoires : ...";
            // 
            // labelFooter
            // 
            labelFooter.AutoSize = true;
            labelFooter.ForeColor = SystemColors.Control;
            labelFooter.Location = new Point(12, 426);
            labelFooter.Name = "labelFooter";
            labelFooter.Size = new Size(66, 15);
            labelFooter.TabIndex = 15;
            labelFooter.Text = "labelFooter";
            // 
            // PcForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 46, 83);
            ClientSize = new Size(800, 450);
            Controls.Add(labelFooter);
            Controls.Add(panelGlobal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PcForm";
            Load += PcForm_Load;
            panelGlobal.ResumeLayout(false);
            panelGlobal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelGlobal;
        private Label labelFooter;
        private Label labelStorage;
        private Label labelRAM;
        private Label labelGPUname;
        private Label labelCPUname;
        private Label lblNomOs;
        private Button btnShutdown;
        private Button btnCMDenter;
        private RichTextBox txtBoxCMD;
        private Button btnBlueScreen;
        private Button button2;
        private Button btnRestart;
    }
}