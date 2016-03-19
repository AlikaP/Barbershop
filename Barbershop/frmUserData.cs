using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barbershop
{
    public partial class frmUserData : Form
    {
        DB_Access dba = new DB_Access();

        public frmUserData()
        {
            InitializeComponent();

            btnExitSettings.MouseEnter += new EventHandler(btnExitSettings_MouseEnter);
            btnUpdateOwner.MouseEnter += new EventHandler(btnUpdateOwner_MouseEnter);
                        
        }

        


        private void frmUserData_Load(object sender, EventArgs e)
        {
            var owner = dba.GetOwnerData();

            lblCompany.Text = owner[0];
            lblName.Text = owner[1];
            lblSurname.Text = owner[2];
            lblCity.Text = owner[3];
            lblStreet.Text = owner[4];
            lblHouseNum.Text = owner[5];
            lblPostNum.Text = owner[6];

            label1.Select();
        }

        private void lblStreet_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExitSettings_Click(object sender, EventArgs e)
        {
            dba.GetSound();

            Close();
        }

        private void btnUpdateOwner_Click(object sender, EventArgs e)
        {
            dba.GetSound();

            frmUpdateOwner updateOwner = new frmUpdateOwner(this);

            var owner = dba.GetOwnerData();

            updateOwner.company = owner[0];
            updateOwner.ownerName = owner[1];
            updateOwner.ownerSurname = owner[2];
            updateOwner.city = owner[3];
            updateOwner.address = owner[4];
            updateOwner.homeNum = owner[5];
            updateOwner.postCode = owner[6];

            updateOwner.ShowDialog();

            label1.Focus();
        }

        public void RefreshUserData()
        {
            //Application.DoEvents();
            this.Close();
            


        }


        private void btnExitSettings_MouseEnter(object sender, EventArgs e)
        {
            dba.GetHoverSound();
        }
        private void btnUpdateOwner_MouseEnter(object sender, EventArgs e)
        {
            dba.GetHoverSound();
        }
    }
}
