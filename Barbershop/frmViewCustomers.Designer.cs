namespace Barbershop
{
    partial class frmViewCustomers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnCustomerDates = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnSearchCustomer = new MetroFramework.Controls.MetroButton();
            this.btnGivePoint = new MetroFramework.Controls.MetroButton();
            this.btnUpdateCustomer = new MetroFramework.Controls.MetroButton();
            this.btnDeleteCustomer = new MetroFramework.Controls.MetroButton();
            this.btnAddCustomer = new MetroFramework.Controls.MetroButton();
            this.btnExitApp = new MetroFramework.Controls.MetroButton();
            this.dgvCustomerList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnCustomerDates);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.btnSearchCustomer);
            this.metroPanel1.Controls.Add(this.btnGivePoint);
            this.metroPanel1.Controls.Add(this.btnUpdateCustomer);
            this.metroPanel1.Controls.Add(this.btnDeleteCustomer);
            this.metroPanel1.Controls.Add(this.btnAddCustomer);
            this.metroPanel1.Controls.Add(this.btnExitApp);
            this.metroPanel1.Controls.Add(this.dgvCustomerList);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(960, 372);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnCustomerDates
            // 
            this.btnCustomerDates.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnCustomerDates.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCustomerDates.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnCustomerDates.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCustomerDates.Location = new System.Drawing.Point(552, 261);
            this.btnCustomerDates.Name = "btnCustomerDates";
            this.btnCustomerDates.Size = new System.Drawing.Size(126, 48);
            this.btnCustomerDates.TabIndex = 25;
            this.btnCustomerDates.Text = "Datumi";
            this.btnCustomerDates.UseCustomBackColor = true;
            this.btnCustomerDates.UseCustomForeColor = true;
            this.btnCustomerDates.UseSelectable = true;
            this.btnCustomerDates.Click += new System.EventHandler(this.btnCustomerDates_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 26);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 19);
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "Popis mušterija";
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSearchCustomer.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSearchCustomer.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSearchCustomer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearchCustomer.Location = new System.Drawing.Point(819, 186);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(129, 123);
            this.btnSearchCustomer.TabIndex = 23;
            this.btnSearchCustomer.Text = "Pronađi \r\nMušteriju";
            this.btnSearchCustomer.UseCustomBackColor = true;
            this.btnSearchCustomer.UseCustomForeColor = true;
            this.btnSearchCustomer.UseSelectable = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // btnGivePoint
            // 
            this.btnGivePoint.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnGivePoint.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnGivePoint.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnGivePoint.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGivePoint.Location = new System.Drawing.Point(552, 57);
            this.btnGivePoint.Name = "btnGivePoint";
            this.btnGivePoint.Size = new System.Drawing.Size(126, 198);
            this.btnGivePoint.TabIndex = 22;
            this.btnGivePoint.Text = "Dodaj Bod";
            this.btnGivePoint.UseCustomBackColor = true;
            this.btnGivePoint.UseCustomForeColor = true;
            this.btnGivePoint.UseSelectable = true;
            this.btnGivePoint.Click += new System.EventHandler(this.btnGivePoint_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateCustomer.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnUpdateCustomer.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnUpdateCustomer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUpdateCustomer.Location = new System.Drawing.Point(819, 57);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(129, 123);
            this.btnUpdateCustomer.TabIndex = 16;
            this.btnUpdateCustomer.Text = "Izmijeni \r\nPodatak";
            this.btnUpdateCustomer.UseCustomBackColor = true;
            this.btnUpdateCustomer.UseCustomForeColor = true;
            this.btnUpdateCustomer.UseSelectable = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteCustomer.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDeleteCustomer.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnDeleteCustomer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(684, 186);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(129, 123);
            this.btnDeleteCustomer.TabIndex = 20;
            this.btnDeleteCustomer.Text = "Obriši \r\nMušteriju";
            this.btnDeleteCustomer.UseCustomBackColor = true;
            this.btnDeleteCustomer.UseCustomForeColor = true;
            this.btnDeleteCustomer.UseSelectable = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.Black;
            this.btnAddCustomer.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAddCustomer.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnAddCustomer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddCustomer.Location = new System.Drawing.Point(684, 57);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(129, 123);
            this.btnAddCustomer.TabIndex = 4;
            this.btnAddCustomer.Text = "Dodaj \r\nMušteriju";
            this.btnAddCustomer.UseCustomBackColor = true;
            this.btnAddCustomer.UseCustomForeColor = true;
            this.btnAddCustomer.UseSelectable = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnExitApp
            // 
            this.btnExitApp.BackColor = System.Drawing.Color.Black;
            this.btnExitApp.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnExitApp.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnExitApp.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnExitApp.Location = new System.Drawing.Point(552, 315);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(396, 39);
            this.btnExitApp.TabIndex = 19;
            this.btnExitApp.Text = "Zatvori";
            this.btnExitApp.UseCustomBackColor = true;
            this.btnExitApp.UseCustomForeColor = true;
            this.btnExitApp.UseSelectable = true;
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // dgvCustomerList
            // 
            this.dgvCustomerList.AllowUserToAddRows = false;
            this.dgvCustomerList.AllowUserToDeleteRows = false;
            this.dgvCustomerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCustomerList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerList.EnableHeadersVisualStyles = false;
            this.dgvCustomerList.Location = new System.Drawing.Point(12, 57);
            this.dgvCustomerList.MultiSelect = false;
            this.dgvCustomerList.Name = "dgvCustomerList";
            this.dgvCustomerList.ReadOnly = true;
            this.dgvCustomerList.RowHeadersVisible = false;
            this.dgvCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerList.Size = new System.Drawing.Size(534, 297);
            this.dgvCustomerList.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(589, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "label1";
            // 
            // frmViewCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 372);
            this.Controls.Add(this.metroPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmViewCustomers";
            this.Text = "Mušterije";
            this.Load += new System.EventHandler(this.frmViewCustomers_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.DataGridView dgvCustomerList;
        private MetroFramework.Controls.MetroButton btnExitApp;
        private MetroFramework.Controls.MetroButton btnAddCustomer;
        private MetroFramework.Controls.MetroButton btnDeleteCustomer;
        private MetroFramework.Controls.MetroButton btnUpdateCustomer;
        private MetroFramework.Controls.MetroButton btnGivePoint;
        private MetroFramework.Controls.MetroButton btnSearchCustomer;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnCustomerDates;
        private System.Windows.Forms.Label label1;
    }
}