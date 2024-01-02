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
            buttonClearHistoriqueFirefox = new Button();
            buttonClearCacheFirefox = new Button();
            labelFirefox = new Label();
            buttonClearCookiesFirefox = new Button();
            panelGlobal.SuspendLayout();
            SuspendLayout();
            // 
            // labelFooter
            // 
            labelFooter.AutoSize = true;
            labelFooter.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelFooter.ForeColor = SystemColors.Control;
            labelFooter.Location = new Point(15, 426);
            labelFooter.Name = "labelFooter";
            labelFooter.Size = new Size(66, 15);
            labelFooter.TabIndex = 0;
            labelFooter.Text = "labelFooter";
            // 
            // panelGlobal
            // 
            panelGlobal.BackColor = Color.FromArgb(38, 39, 70);
            panelGlobal.Controls.Add(buttonClearCookiesFirefox);
            panelGlobal.Controls.Add(buttonClearHistoriqueFirefox);
            panelGlobal.Controls.Add(buttonClearCacheFirefox);
            panelGlobal.Controls.Add(labelFirefox);
            panelGlobal.Location = new Point(12, 15);
            panelGlobal.Name = "panelGlobal";
            panelGlobal.Size = new Size(776, 408);
            panelGlobal.TabIndex = 19;
            // 
            // buttonClearHistoriqueFirefox
            // 
            buttonClearHistoriqueFirefox.Location = new Point(17, 121);
            buttonClearHistoriqueFirefox.Name = "buttonClearHistoriqueFirefox";
            buttonClearHistoriqueFirefox.Size = new Size(117, 23);
            buttonClearHistoriqueFirefox.TabIndex = 22;
            buttonClearHistoriqueFirefox.Text = "Vider Historique";
            buttonClearHistoriqueFirefox.UseVisualStyleBackColor = true;
            buttonClearHistoriqueFirefox.Click += buttonClearHistoriqueFirefox_Click;
            // 
            // buttonClearCacheFirefox
            // 
            buttonClearCacheFirefox.Location = new Point(17, 63);
            buttonClearCacheFirefox.Name = "buttonClearCacheFirefox";
            buttonClearCacheFirefox.Size = new Size(117, 23);
            buttonClearCacheFirefox.TabIndex = 21;
            buttonClearCacheFirefox.Text = "Vider Cache";
            buttonClearCacheFirefox.UseVisualStyleBackColor = true;
            buttonClearCacheFirefox.Click += buttonClearCacheFirefox_Click;
            // 
            // labelFirefox
            // 
            labelFirefox.AutoSize = true;
            labelFirefox.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelFirefox.ForeColor = Color.MediumSlateBlue;
            labelFirefox.Location = new Point(31, 19);
            labelFirefox.Name = "labelFirefox";
            labelFirefox.Size = new Size(93, 32);
            labelFirefox.TabIndex = 20;
            labelFirefox.Text = "Firefox";
            // 
            // buttonClearCookiesFirefox
            // 
            buttonClearCookiesFirefox.Location = new Point(17, 92);
            buttonClearCookiesFirefox.Name = "buttonClearCookiesFirefox";
            buttonClearCookiesFirefox.Size = new Size(117, 23);
            buttonClearCookiesFirefox.TabIndex = 23;
            buttonClearCookiesFirefox.Text = "Vider Cookies";
            buttonClearCookiesFirefox.UseVisualStyleBackColor = true;
            buttonClearCookiesFirefox.Click += buttonClearCookiesFirefox_Click;
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
        private Button buttonClearCookiesFirefox;
    }
}