namespace UltraTools {
    partial class NetworkForm {
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
            labelIPv4Local = new Label();
            labelIPv4Public = new Label();
            labelHostName = new Label();
            panel1 = new Panel();
            labelIPv6Public = new Label();
            labelIProuter = new Label();
            labelIPv6Local = new Label();
            panel2 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            button2 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // labelIPv4Local
            // 
            labelIPv4Local.AutoSize = true;
            labelIPv4Local.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelIPv4Local.ForeColor = SystemColors.Control;
            labelIPv4Local.Location = new Point(3, 25);
            labelIPv4Local.Name = "labelIPv4Local";
            labelIPv4Local.Size = new Size(87, 21);
            labelIPv4Local.TabIndex = 8;
            labelIPv4Local.Text = "IPv4 Local :";
            // 
            // labelIPv4Public
            // 
            labelIPv4Public.AutoSize = true;
            labelIPv4Public.FlatStyle = FlatStyle.System;
            labelIPv4Public.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelIPv4Public.ForeColor = SystemColors.Control;
            labelIPv4Public.Location = new Point(318, 25);
            labelIPv4Public.Name = "labelIPv4Public";
            labelIPv4Public.Size = new Size(97, 21);
            labelIPv4Public.TabIndex = 10;
            labelIPv4Public.Text = " IPv4 Public :";
            // 
            // labelHostName
            // 
            labelHostName.AutoSize = true;
            labelHostName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelHostName.ForeColor = SystemColors.Control;
            labelHostName.Location = new Point(3, 4);
            labelHostName.Name = "labelHostName";
            labelHostName.Size = new Size(102, 21);
            labelHostName.TabIndex = 11;
            labelHostName.Text = "Nom d'Hôte :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(38, 39, 70);
            panel1.Controls.Add(labelIPv6Public);
            panel1.Controls.Add(labelIProuter);
            panel1.Controls.Add(labelIPv6Local);
            panel1.Controls.Add(labelIPv4Local);
            panel1.Controls.Add(labelHostName);
            panel1.Controls.Add(labelIPv4Public);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 74);
            panel1.TabIndex = 12;
            // 
            // labelIPv6Public
            // 
            labelIPv6Public.AutoSize = true;
            labelIPv6Public.FlatStyle = FlatStyle.System;
            labelIPv6Public.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelIPv6Public.ForeColor = SystemColors.Control;
            labelIPv6Public.Location = new Point(318, 46);
            labelIPv6Public.Name = "labelIPv6Public";
            labelIPv6Public.Size = new Size(97, 21);
            labelIPv6Public.TabIndex = 14;
            labelIPv6Public.Text = " IPv6 Public :";
            // 
            // labelIProuter
            // 
            labelIProuter.AutoSize = true;
            labelIProuter.FlatStyle = FlatStyle.System;
            labelIProuter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelIProuter.ForeColor = SystemColors.Control;
            labelIProuter.Location = new Point(318, 4);
            labelIProuter.Name = "labelIProuter";
            labelIProuter.Size = new Size(106, 21);
            labelIProuter.TabIndex = 13;
            labelIProuter.Text = " IP Passerelle :";
            // 
            // labelIPv6Local
            // 
            labelIPv6Local.AutoSize = true;
            labelIPv6Local.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelIPv6Local.ForeColor = SystemColors.Control;
            labelIPv6Local.Location = new Point(3, 46);
            labelIPv6Local.Name = "labelIPv6Local";
            labelIPv6Local.Size = new Size(87, 21);
            labelIPv6Local.TabIndex = 12;
            labelIPv6Local.Text = "IPv6 Local :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(38, 39, 70);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 138);
            panel2.TabIndex = 13;
            panel2.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(338, 78);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 2;
            button1.Text = "Scanner";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(338, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "Adresse IP...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(0, 0);
            label1.MinimumSize = new Size(775, 20);
            label1.Name = "label1";
            label1.Size = new Size(775, 32);
            label1.TabIndex = 0;
            label1.Text = "Scan Port";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(38, 39, 70);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(12, 275);
            panel3.Name = "panel3";
            panel3.Size = new Size(776, 138);
            panel3.TabIndex = 14;
            // 
            // button2
            // 
            button2.Location = new Point(338, 80);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 3;
            button2.Text = "Look Up";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(338, 35);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            textBox2.Text = "Domaine...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(-2, 0);
            label2.MinimumSize = new Size(775, 20);
            label2.Name = "label2";
            label2.Size = new Size(775, 32);
            label2.TabIndex = 1;
            label2.Text = "Whois Domain";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // NetworkForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 46, 83);
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            Name = "NetworkForm";
            Text = "NetworkForm";
            Load += NetworkForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label labelIPv4Local;
        private Label labelIPv4Public;
        private Label labelHostName;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Label labelIPv6Local;
        private Label labelIPv6Public;
        private Label labelIProuter;
    }
}