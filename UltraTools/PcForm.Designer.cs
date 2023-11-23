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
            panelTop = new Panel();
            lblStockage = new Label();
            lblRam = new Label();
            panelMiddle = new Panel();
            panelBottom = new Panel();
            labelFooter = new Label();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(38, 39, 70);
            panelTop.Controls.Add(lblStockage);
            panelTop.Controls.Add(lblRam);
            panelTop.Location = new Point(12, 12);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(776, 138);
            panelTop.TabIndex = 15;
            // 
            // lblStockage
            // 
            lblStockage.AutoSize = true;
            lblStockage.Location = new Point(2, 22);
            lblStockage.Name = "lblStockage";
            lblStockage.Size = new Size(82, 15);
            lblStockage.TabIndex = 1;
            lblStockage.Text = "label stockage";
            // 
            // lblRam
            // 
            lblRam.AutoSize = true;
            lblRam.Location = new Point(4, 3);
            lblRam.Name = "lblRam";
            lblRam.Size = new Size(56, 15);
            lblRam.TabIndex = 0;
            lblRam.Text = "label ram";
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
        private Label lblStockage;
        private Label lblRam;
    }
}