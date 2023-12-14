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
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
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
            panelGlobal.Controls.Add(button6);
            panelGlobal.Controls.Add(button5);
            panelGlobal.Controls.Add(button4);
            panelGlobal.Controls.Add(button3);
            panelGlobal.Controls.Add(button2);
            panelGlobal.Controls.Add(button1);
            panelGlobal.Controls.Add(lblNomOs);
            panelGlobal.Controls.Add(labelGPUname);
            panelGlobal.Controls.Add(labelCPUname);
            panelGlobal.Controls.Add(labelStorage);
            panelGlobal.Controls.Add(labelRAM);
            panelGlobal.Location = new Point(12, 12);
            panelGlobal.Name = "panelGlobal";
            panelGlobal.Size = new Size(776, 420);
            panelGlobal.TabIndex = 15;
            // 
            // button6
            // 
            button6.Location = new Point(286, 336);
            button6.Name = "button6";
            button6.Size = new Size(85, 23);
            button6.TabIndex = 10;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(286, 307);
            button5.Name = "button5";
            button5.Size = new Size(85, 23);
            button5.TabIndex = 9;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(286, 278);
            button4.Name = "button4";
            button4.Size = new Size(85, 23);
            button4.TabIndex = 8;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(286, 249);
            button3.Name = "button3";
            button3.Size = new Size(85, 23);
            button3.TabIndex = 7;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(286, 220);
            button2.Name = "button2";
            button2.Size = new Size(85, 23);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(286, 191);
            button1.Name = "button1";
            button1.Size = new Size(85, 23);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblNomOs
            // 
            lblNomOs.AutoSize = true;
            lblNomOs.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomOs.ForeColor = SystemColors.Control;
            lblNomOs.Location = new Point(286, 46);
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
            labelStorage.Location = new Point(3, 4);
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
            labelRAM.Location = new Point(3, 165);
            labelRAM.Name = "labelRAM";
            labelRAM.Size = new Size(100, 21);
            labelRAM.TabIndex = 0;
            labelRAM.Text = "Mémoires : ...";
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
        private Button button1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}