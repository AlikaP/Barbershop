namespace Barbershop
{
    partial class Form1
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnUserData = new MetroFramework.Controls.MetroButton();
            this.btnExitApp = new MetroFramework.Controls.MetroButton();
            this.btnViewCustomers = new MetroFramework.Controls.MetroButton();
            this.btnSettings = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnUserData);
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.Controls.Add(this.btnExitApp);
            this.metroPanel1.Controls.Add(this.btnViewCustomers);
            this.metroPanel1.Controls.Add(this.btnSettings);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(595, 282);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnUserData
            // 
            this.btnUserData.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnUserData.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnUserData.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnUserData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUserData.Location = new System.Drawing.Point(449, 117);
            this.btnUserData.Name = "btnUserData";
            this.btnUserData.Size = new System.Drawing.Size(129, 94);
            this.btnUserData.TabIndex = 20;
            this.btnUserData.Text = "Korisnički \r\npodaci";
            this.btnUserData.UseCustomBackColor = true;
            this.btnUserData.UseCustomForeColor = true;
            this.btnUserData.UseSelectable = true;
            this.btnUserData.Click += new System.EventHandler(this.btnUserData_Click);
            // 
            // btnExitApp
            // 
            this.btnExitApp.BackColor = System.Drawing.Color.Black;
            this.btnExitApp.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnExitApp.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnExitApp.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnExitApp.Location = new System.Drawing.Point(449, 217);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(129, 47);
            this.btnExitApp.TabIndex = 18;
            this.btnExitApp.Text = "Izlaz";
            this.btnExitApp.UseCustomBackColor = true;
            this.btnExitApp.UseCustomForeColor = true;
            this.btnExitApp.UseSelectable = true;
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // btnViewCustomers
            // 
            this.btnViewCustomers.BackColor = System.Drawing.SystemColors.Control;
            this.btnViewCustomers.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnViewCustomers.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnViewCustomers.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnViewCustomers.Location = new System.Drawing.Point(314, 12);
            this.btnViewCustomers.Name = "btnViewCustomers";
            this.btnViewCustomers.Size = new System.Drawing.Size(129, 252);
            this.btnViewCustomers.TabIndex = 17;
            this.btnViewCustomers.Text = "Prikaži \r\nPopis";
            this.btnViewCustomers.UseCustomBackColor = true;
            this.btnViewCustomers.UseCustomForeColor = true;
            this.btnViewCustomers.UseSelectable = true;
            this.btnViewCustomers.Click += new System.EventHandler(this.btnViewCustomers_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSettings.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSettings.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSettings.Location = new System.Drawing.Point(449, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(129, 99);
            this.btnSettings.TabIndex = 14;
            this.btnSettings.Text = "Postavke";
            this.btnSettings.UseCustomBackColor = true;
            this.btnSettings.UseCustomForeColor = true;
            this.btnSettings.UseSelectable = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Barbershop.Properties.Resources.scissors_and_comb_318_57231;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 282);
            this.Controls.Add(this.metroPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Frizerski salon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnViewCustomers;
        private MetroFramework.Controls.MetroButton btnSettings;
        private MetroFramework.Controls.MetroButton btnExitApp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnUserData;
        private System.Windows.Forms.Label label1;
    }
}

