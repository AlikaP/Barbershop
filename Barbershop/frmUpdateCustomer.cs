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
    public partial class frmUpdateCustomer : Form
    {
        DB_Access dba = new DB_Access();


        public frmUpdateCustomer()
        {
            InitializeComponent();
        }

        frmViewCustomers _owner;
        public frmUpdateCustomer(frmViewCustomers owner)
        {
            InitializeComponent();
            _owner = owner;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUpdateCustomer_FormClosing);

            btnExitUpdate.MouseEnter += new EventHandler(btnExitUpdate_MouseEnter);
            btnUpdate.MouseEnter += new EventHandler(btnUpdate_MouseEnter);
        }

        private void frmUpdateCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.RefreshCustomers(null);
        }

        public int id;
        public string name;
        public string surname;
        public string phone;

        public void FillById()
        {
            //
        }


        private void frmUpdateCustomer_Load(object sender, EventArgs e)
        {
            txtName.Text = name;
            txtSurname.Text = surname;
            txtPhone.Text = phone;

            label1.Select();
        }

        private void btnExitUpdate_Click(object sender, EventArgs e)
        {
            
            Close();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtSurname.Text))
            {
                MessageBox.Show("Polja za ime i prezime ne smiju ostati prazna");
                txtName.Focus();
            }
            else
            {
                dba.UpdateCustomer(txtName.Text, txtSurname.Text, txtPhone.Text, id);
                MessageBox.Show("Podaci mušterije uspješno nadopunjeni");

                Close();
            }

            label1.Focus();
        }


        private void btnExitUpdate_MouseEnter(object sender, EventArgs e)
        {
            dba.GetHoverSound();
        }
        private void btnUpdate_MouseEnter(object sender, EventArgs e)
        {
            dba.GetHoverSound();
        }
    }
}
