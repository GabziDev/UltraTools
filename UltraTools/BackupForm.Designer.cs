namespace UltraTools
{
    partial class BackupForm
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
            panelBottom = new Panel();
            panelMiddle = new Panel();
            panelTop = new Panel();
            labelFooter = new Label();
            SuspendLayout();
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.FromArgb(38, 39, 70);
            panelBottom.Location = new Point(12, 300);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(776, 138);
            panelBottom.TabIndex = 20;
            // 
            // panelMiddle
            // 
            panelMiddle.BackColor = Color.FromArgb(38, 39, 70);
            panelMiddle.Location = new Point(12, 156);
            panelMiddle.Name = "panelMiddle";
            panelMiddle.Size = new Size(776, 138);
            panelMiddle.TabIndex = 19;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(38, 39, 70);
            panelTop.Location = new Point(12, 12);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(776, 138);
            panelTop.TabIndex = 18;
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
            // BackupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 46, 83);
            ClientSize = new Size(800, 450);
            Controls.Add(labelFooter);
            Controls.Add(panelBottom);
            Controls.Add(panelMiddle);
            Controls.Add(panelTop);
            Name = "BackupForm";
            Text = "BackupForm";
            Load += BackupForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelBottom;
        private Panel panelMiddle;
        private Panel panelTop;
        private Label labelFooter;
    }
}