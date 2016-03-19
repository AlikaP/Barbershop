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
    public partial class frmUpdateOwner : Form
    {
        DB_Access dba = new DB_Access();

        public string company;
        public string ownerName;
        public string ownerSurname;
        public string city;
        public string address;
        public string postCode;
        public string homeNum;

        public frmUpdateOwner()
        {
            InitializeComponent();
        }

        frmUserData _owner;
        public frmUpdateOwner(frmUserData owner)
        {
            InitializeComponent();
            _owner = owner;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUserData_FormClosing);

            btnInsertOwner.MouseEnter += new EventHandler(btnInsertOwner_MouseEnter);
            btnExitInsertOwner.MouseEnter += new EventHandler(btnExitInsertOwner_MouseEnter);
        }

        private void frmUserData_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.RefreshUserData();
        }

        private void frmUpdateOwner_Load(object sender, EventArgs e)
        {
            txtOwnerName.Text = ownerName;
            txtOwnerSurname.Text = ownerSurname;
            txtCompany.Text = company;
            txtCity.Text = city;
            txtStreet.Text = address;
            txtHouseNum.Text = homeNum;
            txtPostNum.Text = postCode;

            
            label1.Select();
        }

        private void btnInsertOwner_Click(object sender, EventArgs e)
        {
            dba.GetSound();

            if (String.IsNullOrEmpty(txtOwnerName.Text) || String.IsNullOrEmpty(txtOwnerSurname.Text)
                || String.IsNullOrEmpty(txtCompany.Text)
                || String.IsNullOrEmpty(txtCity.Text)
                || String.IsNullOrEmpty(txtHouseNum.Text)
                || String.IsNullOrEmpty(txtPostNum.Text)
                || String.IsNullOrEmpty(txtStreet.Text))
            {
                MessageBox.Show("Polja ne smiju ostati prazna");               
            }
            else
            {
                dba.UpdateOwnerData(txtCompany.Text, txtOwnerName.Text,
            txtOwnerSurname.Text,
            txtCity.Text,
            txtStreet.Text,
            txtPostNum.Text,
            txtHouseNum.Text
            );

                MessageBox.Show("Podaci vlasnika uspješno nadopunjeni");

                Close();
            }

            label1.Focus();
        }

        private void btnExitInsertOwner_Click(object sender, EventArgs e)
        {
            dba.GetSound();

            Close();
        }


        private void btnInsertOwner_MouseEnter(object sender, EventArgs e)
        {
            dba.GetHoverSound();
        }
        private void btnExitInsertOwner_MouseEnter(object sender, EventArgs e)
        {
            dba.GetHoverSound();
        }
    }
}
