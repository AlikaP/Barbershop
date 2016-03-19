using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barbershop
{
    public partial class frmSettings : Form
    {
        DB_Access dba = new DB_Access();

        int numPoints;

        public frmSettings()
        {
            InitializeComponent();

            btnAcceptSettings.MouseEnter += new EventHandler(btnAcceptSettings_MouseEnter);
            btnExitSettings.MouseEnter += new EventHandler(btnExitSettings_MouseEnter);
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            label1.Select();
        }

        private void btnAcceptSettings_Click(object sender, EventArgs e)
        {
            dba.GetSound();

            if (String.IsNullOrEmpty(txtNumPoints.Text))
            {
                //MessageBox.Show("Polje ne smije biti prazno");
                //txtNumPoints.Focus();  

                numPoints = dba.GetPoint();
            }
            else
            {
                numPoints = Int32.Parse(txtNumPoints.Text);
            }
            
                var sound = 0;
                
                if (chkSound.Checked) { sound = 1; }

                dba.SetNumPoints(numPoints, sound);

                MessageBox.Show("Postavke izmijenjene");

                Close();
            

            label1.Focus();
        }

        private void btnExitSettings_Click(object sender, EventArgs e)
        {
            dba.GetSound();

            Close();
        }

        private void btnAcceptSettings_MouseEnter(object sender, EventArgs e)
        {
            dba.GetHoverSound();
        }
        private void btnExitSettings_MouseEnter(object sender, EventArgs e)
        {
            dba.GetHoverSound();
        }
    }
}
