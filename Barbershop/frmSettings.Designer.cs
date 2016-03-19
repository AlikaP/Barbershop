namespace Barbershop
{
    partial class frmSettings
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
            this.txtNumPoints = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnExitSettings = new MetroFramework.Controls.MetroButton();
            this.btnAcceptSettings = new MetroFramework.Controls.MetroButton();
            this.chkSound = new MetroFramework.Controls.MetroCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.chkSound);
            this.metroPanel1.Controls.Add(this.btnAcceptSettings);
            this.metroPanel1.Controls.Add(this.btnExitSettings);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.txtNumPoints);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(376, 215);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // txtNumPoints
            // 
            // 
            // 
            // 
            this.txtNumPoints.CustomButton.Image = null;
            this.txtNumPoints.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtNumPoints.CustomButton.Name = "";
            this.txtNumPoints.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNumPoints.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumPoints.CustomButton.TabIndex = 1;
            this.txtNumPoints.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumPoints.CustomButton.UseSelectable = true;
            this.txtNumPoints.CustomButton.Visible = false;
            this.txtNumPoints.Lines = new string[0];
            this.txtNumPoints.Location = new System.Drawing.Point(273, 44);
            this.txtNumPoints.MaxLength = 32767;
            this.txtNumPoints.Name = "txtNumPoints";
            this.txtNumPoints.PasswordChar = '\0';
            this.txtNumPoints.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumPoints.SelectedText = "";
            this.txtNumPoints.SelectionLength = 0;
            this.txtNumPoints.SelectionStart = 0;
            this.txtNumPoints.Size = new System.Drawing.Size(75, 23);
            this.txtNumPoints.TabIndex = 2;
            this.txtNumPoints.UseSelectable = true;
            this.txtNumPoints.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumPoints.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(227, 38);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Broj bodova potrebnih za ostvarenje \r\nprava na besplatno šišanje:";
            // 
            // btnExitSettings
            // 
            this.btnExitSettings.BackColor = System.Drawing.Color.Black;
            this.btnExitSettings.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnExitSettings.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnExitSettings.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnExitSettings.Location = new System.Drawing.Point(243, 153);
            this.btnExitSettings.Name = "btnExitSettings";
            this.btnExitSettings.Size = new System.Drawing.Size(105, 39);
            this.btnExitSettings.TabIndex = 29;
            this.btnExitSettings.Text = "Zatvori";
            this.btnExitSettings.UseCustomBackColor = true;
            this.btnExitSettings.UseCustomForeColor = true;
            this.btnExitSettings.UseSelectable = true;
            this.btnExitSettings.Click += new System.EventHandler(this.btnExitSettings_Click);
            // 
            // btnAcceptSettings
            // 
            this.btnAcceptSettings.BackColor = System.Drawing.Color.Black;
            this.btnAcceptSettings.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAcceptSettings.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnAcceptSettings.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAcceptSettings.Location = new System.Drawing.Point(132, 153);
            this.btnAcceptSettings.Name = "btnAcceptSettings";
            this.btnAcceptSettings.Size = new System.Drawing.Size(105, 39);
            this.btnAcceptSettings.TabIndex = 30;
            this.btnAcceptSettings.Text = "Primijeni";
            this.btnAcceptSettings.UseCustomBackColor = true;
            this.btnAcceptSettings.UseCustomForeColor = true;
            this.btnAcceptSettings.UseSelectable = true;
            this.btnAcceptSettings.Click += new System.EventHandler(this.btnAcceptSettings_Click);
            // 
            // chkSound
            // 
            this.chkSound.AutoSize = true;
            this.chkSound.Location = new System.Drawing.Point(286, 95);
            this.chkSound.Name = "chkSound";
            this.chkSound.Size = new System.Drawing.Size(49, 15);
            this.chkSound.TabIndex = 31;
            this.chkSound.Text = "Zvuk";
            this.chkSound.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "label1";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 215);
            this.Controls.Add(this.metroPanel1);
            this.Name = "frmSettings";
            this.Text = "Postavke";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtNumPoints;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnAcceptSettings;
        private MetroFramework.Controls.MetroButton btnExitSettings;
        private MetroFramework.Controls.MetroCheckBox chkSound;
        private System.Windows.Forms.Label label1;
    }
}