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
            labelStorage = new Label();
            labelRAM = new Label();
            panelMiddle = new Panel();
            panelBottom = new Panel();
            labelFooter = new Label();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(38, 39, 70);
            panelTop.Controls.Add(labelStorage);
            panelTop.Controls.Add(labelRAM);
            panelTop.Location = new Point(12, 12);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(776, 138);
            panelTop.TabIndex = 15;
            // 
            // labelStorage
            // 
            labelStorage.AutoSize = true;
            labelStorage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelStorage.ForeColor = SystemColors.Control;
            labelStorage.Location = new Point(3, 25);
            labelStorage.Name = "labelStorage";
            labelStorage.Size = new Size(87, 21);
            labelStorage.TabIndex = 1;
            labelStorage.Text = "label stockage";
            // 
            // labelRAM
            // 
            labelRAM.AutoSize = true;
            labelRAM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelRAM.ForeColor = SystemColors.Control;
            labelRAM.Location = new Point(3, 4);
            labelRAM.Name = "labelRAM";
            labelRAM.Size = new Size(102, 21);
            labelRAM.TabIndex = 0;
            labelRAM.Text = "label ram";
            // 
            // panelMiddle
            // 
            panelMiddle.BackColor = Color.FromArgb(38, 39, 70);
            panelMiddle.Location = new Point(12, 156);
            panelMiddle.Name = "panelMiddle";
            panelMiddle.Size = new Size(776, 138);
            panelMiddle.TabIndex = 16;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.FromArgb(38, 39, 70);
            panelBottom.Location = new Point(12, 300);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(776, 138);
            panelBottom.TabIndex = 17;
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
    }
}