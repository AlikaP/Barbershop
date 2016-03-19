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
    public partial class frmAddCustomer : Form
    {
        DB_Access dba = new DB_Access();

        public frmAddCustomer()
        {
            InitializeComponent();
        }


        frmViewCustomers _owner;
        public frmAddCustomer(frmViewCustomers owner)
        {
            InitializeComponent();
            _owner = owner;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddCustomer_FormClosing);

            btnInsert.MouseEnter += new EventHandler(btnInsert_MouseEnter);
            btnExitAdd.MouseEnter += new EventHandler(btnExitAdd_MouseEnter);
        }

        private void frmAddCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.RefreshCustomers(null);
        }



        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            label1.Select();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            dba.GetSound();

            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtSurname.Text))
            {
                MessageBox.Show("Polja za ime i prezime ne smiju ostati prazna");
                txtName.Focus();
                txtSurname.Focus();
            }
            else
            {
                dba.AddNewCustomer(txtName.Text, txtSurname.Text, txtPhone.Text);
                MessageBox.Show("Nova mušterija dodana");

                Close();
            }

            label1.Focus();

        }

        private void btnExitAdd_Click(object sender, EventArgs e)
        {
            dba.GetSound();

            Close();

        }


        private void btnInsert_MouseEnter(object sender, EventArgs e)
        {
            dba.GetHoverSound();
        }
        private void btnExitAdd_MouseEnter(object sender, EventArgs e)
        {
            dba.GetHoverSound();
        }
    }
}
