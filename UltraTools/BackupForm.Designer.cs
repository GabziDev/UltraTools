namespace UltraTools {
    partial class BackupForm {
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
            labelFooter = new Label();
            panelGlobal = new Panel();
            labelOutput = new Label();
            labelSauvegardeDirectory = new Label();
            textBoxOutput = new TextBox();
            buttonBackup = new Button();
            textBoxDirectory = new TextBox();
            labelBackupTitle = new Label();
            buttonCancel = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            panelGlobal.SuspendLayout();
            SuspendLayout();
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
            // panelGlobal
            // 
            panelGlobal.BackColor = Color.FromArgb(38, 39, 70);
            panelGlobal.Controls.Add(buttonCancel);
            panelGlobal.Controls.Add(labelOutput);
            panelGlobal.Controls.Add(labelSauvegardeDirectory);
            panelGlobal.Controls.Add(textBoxOutput);
            panelGlobal.Controls.Add(buttonBackup);
            panelGlobal.Controls.Add(textBoxDirectory);
            panelGlobal.Controls.Add(labelBackupTitle);
            panelGlobal.Location = new Point(12, 12);
            panelGlobal.Name = "panelGlobal";
            panelGlobal.Size = new Size(776, 409);
            panelGlobal.TabIndex = 20;
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.ForeColor = Color.White;
            labelOutput.Location = new Point(320, 146);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(91, 15);
            labelOutput.TabIndex = 6;
            labelOutput.Text = "Sortie backup ...";
            // 
            // labelSauvegardeDirectory
            // 
            labelSauvegardeDirectory.AutoSize = true;
            labelSauvegardeDirectory.ForeColor = Color.White;
            labelSauvegardeDirectory.Location = new Point(320, 98);
            labelSauvegardeDirectory.Name = "labelSauvegardeDirectory";
            labelSauvegardeDirectory.Size = new Size(149, 15);
            labelSauvegardeDirectory.TabIndex = 5;
            labelSauvegardeDirectory.Text = "Répertoire à sauvegarder ...";
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(320, 164);
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(141, 23);
            textBoxOutput.TabIndex = 4;
            // 
            // buttonBackup
            // 
            buttonBackup.Location = new Point(320, 216);
            buttonBackup.Name = "buttonBackup";
            buttonBackup.Size = new Size(141, 23);
            buttonBackup.TabIndex = 3;
            buttonBackup.Text = "Faire Sauvegarde";
            buttonBackup.UseVisualStyleBackColor = true;
            buttonBackup.Click += buttonBackup_Click;
            // 
            // textBoxDirectory
            // 
            textBoxDirectory.Location = new Point(320, 116);
            textBoxDirectory.Name = "textBoxDirectory";
            textBoxDirectory.Size = new Size(141, 23);
            textBoxDirectory.TabIndex = 2;
            // 
            // labelBackupTitle
            // 
            labelBackupTitle.AutoSize = true;
            labelBackupTitle.Font = new Font("Segoe UI", 23F, FontStyle.Bold, GraphicsUnit.Point);
            labelBackupTitle.ForeColor = Color.MediumSlateBlue;
            labelBackupTitle.ImageAlign = ContentAlignment.TopCenter;
            labelBackupTitle.Location = new Point(1, 0);
            labelBackupTitle.MinimumSize = new Size(775, 20);
            labelBackupTitle.Name = "labelBackupTitle";
            labelBackupTitle.Size = new Size(775, 42);
            labelBackupTitle.TabIndex = 1;
            labelBackupTitle.Text = "Sauvegarde";
            labelBackupTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(320, 245);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(141, 23);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Annuler";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // BackupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 46, 83);
            ClientSize = new Size(800, 450);
            Controls.Add(labelFooter);
            Controls.Add(panelGlobal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "BackupForm";
            Load += BackupForm_Load;
            panelGlobal.ResumeLayout(false);
            panelGlobal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelFooter;
        private Panel panelGlobal;
        private Label labelBackupTitle;
        private Button buttonBackup;
        private TextBox textBoxDirectory;
        private TextBox textBoxOutput;
        private Label labelOutput;
        private Label labelSauvegardeDirectory;
        private Button buttonCancel;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}