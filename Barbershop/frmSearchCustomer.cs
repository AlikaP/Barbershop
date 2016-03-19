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
    public partial class frmSearchCustomer : Form
    {
        DB_Access dba = new DB_Access();
        DataSet ds = null;

        public frmSearchCustomer()
        {
            InitializeComponent();
        }

        frmViewCustomers _owner;
        public frmSearchCustomer(frmViewCustomers owner)
        {
            InitializeComponent();
            _owner = owner;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSearchCustomer_FormClosing);

            btnSearch.MouseEnter += new EventHandler(btnSearch_MouseEnter);
            btnExitSearch.MouseEnter += new EventHandler(btnExitSearch_MouseEnter);
        }

        private void frmSearchCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.RefreshCustomers(ds);
        }

        private void frmSearchCustomer_Load(object sender, EventArgs e)
        {
            label1.Select();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dba.GetSound();

            if (String.IsNullOrEmpty(txtName.Text) && String.IsNullOrEmpty(txtSurname.Text))
            {
                MessageBox.Show("Oba polja ne smiju biti prazna");
                //txtName.Focus();
            }
            else
            {
                ds = dba.SearchCustomer(txtName.Text, txtSurname.Text);

                Close();
            }

            label1.Focus();

        }

        private void btnExitSearch_Click(object sender, EventArgs e)
        {
            dba.GetSound();

            Close();
        }


        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {
            dba.GetHoverSound();
        }
        private void btnExitSearch_MouseEnter(object sender, EventArgs e)
        {
            dba.GetHoverSound();
        }
    }
}
