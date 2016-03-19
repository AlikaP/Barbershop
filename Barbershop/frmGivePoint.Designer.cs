namespace Barbershop
{
    partial class frmGivePoint
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
            this.btnAddPoint = new MetroFramework.Controls.MetroButton();
            this.btnExitPoint = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroDateTime1);
            this.metroPanel1.Controls.Add(this.btnAddPoint);
            this.metroPanel1.Controls.Add(this.btnExitPoint);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(387, 211);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.BackColor = System.Drawing.Color.Black;
            this.btnAddPoint.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAddPoint.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnAddPoint.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddPoint.Location = new System.Drawing.Point(143, 146);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(105, 39);
            this.btnAddPoint.TabIndex = 34;
            this.btnAddPoint.Text = "Dodaj bod";
            this.btnAddPoint.UseCustomBackColor = true;
            this.btnAddPoint.UseCustomForeColor = true;
            this.btnAddPoint.UseSelectable = true;
            this.btnAddPoint.Click += new System.EventHandler(this.btnAddPoint_Click);
            // 
            // btnExitPoint
            // 
            this.btnExitPoint.BackColor = System.Drawing.Color.Black;
            this.btnExitPoint.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnExitPoint.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnExitPoint.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnExitPoint.Location = new System.Drawing.Point(254, 146);
            this.btnExitPoint.Name = "btnExitPoint";
            this.btnExitPoint.Size = new System.Drawing.Size(105, 39);
            this.btnExitPoint.TabIndex = 33;
            this.btnExitPoint.Text = "Odustani";
            this.btnExitPoint.UseCustomBackColor = true;
            this.btnExitPoint.UseCustomForeColor = true;
            this.btnExitPoint.UseSelectable = true;
            this.btnExitPoint.Click += new System.EventHandler(this.btnExitPoint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "label1";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.CustomFormat = "dd.MM.yyyy hh:mm";
            this.metroDateTime1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.metroDateTime1.Location = new System.Drawing.Point(143, 82);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(216, 29);
            this.metroDateTime1.TabIndex = 37;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(32, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 38;
            this.metroLabel1.Text = "Datum usluge";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(32, 27);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(142, 19);
            this.metroLabel2.TabIndex = 39;
            this.metroLabel2.Text = "Dodjela boda mušteriji";
            // 
            // frmGivePoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 211);
            this.Controls.Add(this.metroPanel1);
            this.Name = "frmGivePoint";
            this.Text = "Dodjela boda";
            this.Load += new System.EventHandler(this.frmGivePoint_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnAddPoint;
        private MetroFramework.Controls.MetroButton btnExitPoint;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}