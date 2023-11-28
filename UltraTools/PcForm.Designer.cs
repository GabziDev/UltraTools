namespace UltraTools {
    partial class PcForm {
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
            panelTop = new Panel();
            labelGPUname = new Label();
            labelCPUname = new Label();
            labelStorage = new Label();
            labelRAM = new Label();
            panelMiddle = new Panel();
            btnRestart = new Button();
            btnShutdown = new Button();
            panelBottom = new Panel();
            lblterminale = new Label();
            btnStart = new Button();
            rtboxEntreTerminale = new RichTextBox();
            labelFooter = new Label();
            panelTop.SuspendLayout();
            panelMiddle.SuspendLayout();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(38, 39, 70);
            panelTop.Controls.Add(labelGPUname);
            panelTop.Controls.Add(labelCPUname);
            panelTop.Controls.Add(labelStorage);
            panelTop.Controls.Add(labelRAM);
            panelTop.Location = new Point(12, 12);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(776, 138);
            panelTop.TabIndex = 15;
            // 
            // labelGPUname
            // 
            labelGPUname.AutoSize = true;
            labelGPUname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelGPUname.ForeColor = SystemColors.Control;
            labelGPUname.Location = new Point(286, 25);
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
            labelCPUname.Location = new Point(286, 4);
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
            labelStorage.Location = new Point(0, 25);
            labelStorage.Name = "labelStorage";
            labelStorage.Size = new Size(166, 21);
            labelStorage.TabIndex = 1;
            labelStorage.Text = "Stockage Libre (OS) : ...";
            // 
            // labelRAM
            // 
            labelRAM.AutoSize = true;
            labelRAM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelRAM.ForeColor = SystemColors.Control;
            labelRAM.Location = new Point(0, 4);
            labelRAM.Name = "labelRAM";
            labelRAM.Size = new Size(112, 21);
            labelRAM.TabIndex = 0;
            labelRAM.Text = "R.A.M. Libre : ...";
            // 
            // panelMiddle
            // 
            panelMiddle.BackColor = Color.FromArgb(38, 39, 70);
            panelMiddle.Controls.Add(btnRestart);
            panelMiddle.Controls.Add(btnShutdown);
            panelMiddle.Location = new Point(12, 156);
            panelMiddle.Name = "panelMiddle";
            panelMiddle.Size = new Size(776, 138);
            panelMiddle.TabIndex = 16;
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(621, 111);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(135, 23);
            btnRestart.TabIndex = 1;
            btnRestart.Text = "Redemarrer";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // btnShutdown
            // 
            btnShutdown.Location = new Point(620, 84);
            btnShutdown.Name = "btnShutdown";
            btnShutdown.Size = new Size(136, 23);
            btnShutdown.TabIndex = 0;
            btnShutdown.Text = "Eteindre";
            btnShutdown.UseVisualStyleBackColor = true;
            btnShutdown.Click += btnShutdown_Click;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.FromArgb(38, 39, 70);
            panelBottom.Controls.Add(lblterminale);
            panelBottom.Controls.Add(btnStart);
            panelBottom.Controls.Add(rtboxEntreTerminale);
            panelBottom.Location = new Point(12, 300);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(776, 138);
            panelBottom.TabIndex = 17;
            // 
            // lblterminale
            // 
            lblterminale.AutoSize = true;
            lblterminale.ForeColor = SystemColors.Control;
            lblterminale.Location = new Point(286, 5);
            lblterminale.Name = "lblterminale";
            lblterminale.Size = new Size(89, 15);
            lblterminale.TabIndex = 2;
            lblterminale.Text = "acces terminale";
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Black;
            btnStart.ForeColor = SystemColors.Control;
            btnStart.Location = new Point(620, 21);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(156, 111);
            btnStart.TabIndex = 1;
            btnStart.Text = "Entre simple";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // rtboxEntreTerminale
            // 
            rtboxEntreTerminale.Location = new Point(3, 21);
            rtboxEntreTerminale.Name = "rtboxEntreTerminale";
            rtboxEntreTerminale.Size = new Size(615, 111);
            rtboxEntreTerminale.TabIndex = 0;
            rtboxEntreTerminale.Text = "entre terminale";
            // 
            // labelFooter
            // 
            labelFooter.AutoSize = true;
            labelFooter.Location = new Point(0, 435);
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
            Controls.Add(panelBottom);
            Controls.Add(panelMiddle);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PcForm";
            Load += PcForm_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelMiddle.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTop;
        private Panel panelMiddle;
        private Panel panelBottom;
        private Label labelFooter;
        private Label labelStorage;
        private Label labelRAM;
        private Button btnRestart;
        private Button btnShutdown;
        private Label lblterminale;
        private Button btnStart;
        private RichTextBox rtboxEntreTerminale;
        private Label labelGPUname;
        private Label labelCPUname;
    }
}