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
            panel3 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(38, 39, 70);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(776, 138);
            panel3.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(38, 39, 70);
            panel1.Location = new Point(12, 156);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 138);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(38, 39, 70);
            panel2.Location = new Point(12, 300);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 138);
            panel2.TabIndex = 17;
            // 
            // PcForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 46, 83);
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "PcForm";
            Text = "PcForm";
            Load += PcForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel1;
        private Panel panel2;
    }
}