namespace Barbershop
{
    partial class frmViewDates
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCustomerDates = new System.Windows.Forms.DataGridView();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnExitDate = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDates)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustomerDates
            // 
            this.dgvCustomerDates.AllowUserToAddRows = false;
            this.dgvCustomerDates.AllowUserToDeleteRows = false;
            this.dgvCustomerDates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerDates.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCustomerDates.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerDates.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCustomerDates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerDates.EnableHeadersVisualStyles = false;
            this.dgvCustomerDates.Location = new System.Drawing.Point(21, 58);
            this.dgvCustomerDates.MultiSelect = false;
            this.dgvCustomerDates.Name = "dgvCustomerDates";
            this.dgvCustomerDates.ReadOnly = true;
            this.dgvCustomerDates.RowHeadersVisible = false;
            this.dgvCustomerDates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerDates.Size = new System.Drawing.Size(248, 252);
            this.dgvCustomerDates.TabIndex = 3;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.dgvCustomerDates);
            this.metroPanel1.Controls.Add(this.btnExitDate);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(290, 387);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnExitDate
            // 
            this.btnExitDate.BackColor = System.Drawing.Color.Black;
            this.btnExitDate.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnExitDate.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnExitDate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnExitDate.Location = new System.Drawing.Point(164, 326);
            this.btnExitDate.Name = "btnExitDate";
            this.btnExitDate.Size = new System.Drawing.Size(105, 39);
            this.btnExitDate.TabIndex = 32;
            this.btnExitDate.Text = "Zatvori";
            this.btnExitDate.UseCustomBackColor = true;
            this.btnExitDate.UseCustomForeColor = true;
            this.btnExitDate.UseSelectable = true;
            this.btnExitDate.Click += new System.EventHandler(this.btnExitDate_Click_1);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(21, 26);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 33;
            this.metroLabel1.Text = "Datumi";
            // 
            // frmViewDates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 387);
            this.Controls.Add(this.metroPanel1);
            this.Name = "frmViewDates";
            this.Text = "Datumi";
            this.Load += new System.EventHandler(this.frmViewDates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDates)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomerDates;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnExitDate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}