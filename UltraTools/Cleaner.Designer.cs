namespace UltraTools
{
    partial class Cleaner
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
            labelFooter = new Label();
            panelGlobal = new Panel();
            buttonClearCacheFirefox = new Button();
            labelFirefox = new Label();
            buttonClearHistoriqueFirefox = new Button();
            panelGlobal.SuspendLayout();
            SuspendLayout();
            // 
            // labelFooter
            // 
            labelFooter.AutoSize = true;
            labelFooter.ForeColor = SystemColors.Control;
            labelFooter.Location = new Point(12, 438);
            labelFooter.Name = "labelFooter";
            labelFooter.Size = new Size(66, 15);
            labelFooter.TabIndex = 0;
            labelFooter.Text = "labelFooter";
            // 
            // panelGlobal
            // 
            panelGlobal.BackColor = Color.FromArgb(38, 39, 70);
            panelGlobal.Controls.Add(buttonClearHistoriqueFirefox);
            panelGlobal.Controls.Add(buttonClearCacheFirefox);
            panelGlobal.Controls.Add(labelFirefox);
            panelGlobal.Location = new Point(12, 15);
            panelGlobal.Name = "panelGlobal";
            panelGlobal.Size = new Size(776, 420);
            panelGlobal.TabIndex = 19;
            // 
            // buttonClearCacheFirefox
            // 
            buttonClearCacheFirefox.Location = new Point(3, 42);
            buttonClearCacheFirefox.Name = "buttonClearCacheFirefox";
            buttonClearCacheFirefox.Size = new Size(108, 23);
            buttonClearCacheFirefox.TabIndex = 21;
            buttonClearCacheFirefox.Text = "Vider Cache";
            buttonClearCacheFirefox.UseVisualStyleBackColor = true;
            buttonClearCacheFirefox.Click += buttonClearCacheFirefox_Click;
            // 
            // labelFirefox
            // 
            labelFirefox.AutoSize = true;
            labelFirefox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelFirefox.ForeColor = SystemColors.Control;
            labelFirefox.Location = new Point(0, 0);
            labelFirefox.Name = "labelFirefox";
            labelFirefox.Size = new Size(71, 28);
            labelFirefox.TabIndex = 20;
            labelFirefox.Text = "Firefox";
            // 
            // buttonClearHistoriqueFirefox
            // 
            buttonClearHistoriqueFirefox.Location = new Point(3, 71);
            buttonClearHistoriqueFirefox.Name = "buttonClearHistoriqueFirefox";
            buttonClearHistoriqueFirefox.Size = new Size(108, 23);
            buttonClearHistoriqueFirefox.TabIndex = 22;
            buttonClearHistoriqueFirefox.Text = "Vider Historique";
            buttonClearHistoriqueFirefox.UseVisualStyleBackColor = true;
            buttonClearHistoriqueFirefox.Click += buttonClearHistoriqueFirefox_Click;
            // 
            // Cleaner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 46, 83);
            ClientSize = new Size(800, 450);
            Controls.Add(panelGlobal);
            Controls.Add(labelFooter);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Cleaner";
            Load += Cleaner_Load;
            panelGlobal.ResumeLayout(false);
            panelGlobal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFooter;
        private Panel panelGlobal;
        private Label labelFirefox;
        private Button buttonClearCacheFirefox;
        private Button buttonClearHistoriqueFirefox;
    }
}