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
    public partial class frmViewCustomers : Form
    {
        DB_Access dba = new DB_Access();
        BindingSource bs = new BindingSource();

        public frmViewCustomers()
        {
            InitializeComponent();

            btnAddCustomer.MouseEnter += new EventHandler(btnAddCustomer_MouseEnter);
            btnUpdateCustomer.MouseEnter += new EventHandler(btnUpdateCustomer_MouseEnter);
            btnDeleteCustomer.MouseEnter += new EventHandler(btnDeleteCustomer_MouseEnter);
            btnExitApp.MouseEnter += new EventHandler(btnExitApp_MouseEnter);
            btnGivePoint.MouseEnter += new EventHandler(btnGivePoint_MouseEnter);
            btnSearchCustomer.MouseEnter += new EventHandler(btnSearchCustomer_MouseEnter);
            btnCustomerDates.MouseEnter += new EventHandler(btnCustomerDates_MouseEnter);

        }

        public void RefreshCustomers(DataSet ds)
        {
            //dohvat podataka iz tablice (dataset)
            if (ds == null)
            {
                ds = dba.ViewCustomers();
            }
            

            bs.DataSource = ds.Tables[0];

            //dohvata podataka iz dataseta i slanje na datagridview
            //dgvCustomerList.DataSource = ds.Tables["Customer"].DefaultView;
            dgvCustomerList.DataSource = bs;

            //id skriven
            dgvCustomerList.Columns[0].Visible = false;
        }

        private void frmViewCustomers_Load(object sender, EventArgs e)
        {
            this.RefreshCustomers(null);

            label1.Select();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            dba.GetSound();

            frmAddCustomer newCustomer = new frmAddCustomer(this);
            newCustomer.ShowDialog(); // .ShowDialog()  - ne može se kliknuti forma iza forme

            label1.Focus();

            //this.FormClosed += new FormClosedEventHandler(frmAddCustomer);


        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            dba.GetSound();

            if (dgvCustomerList.SelectedRows.Count == 0 || dgvCustomerList.SelectedRows.Count > 1)
            {
                MessageBox.Show("Odaberite jedan redak koji želite izmijeniti");
            }
            else
            {
                frmUpdateCustomer updateCustomer = new frmUpdateCustomer(this);

                int id = Convert.ToInt32(dgvCustomerList.SelectedRows[0].Cells[0].Value);
                string name = dgvCustomerList.SelectedRows[0].Cells[1].Value.ToString();
                string surname = dgvCustomerList.SelectedRows[0].Cells[2].Value.ToString();
                string phone = dgvCustomerList.SelectedRows[0].Cells[3].Value.ToString();

                updateCustomer.id = id;
                updateCustomer.name = name;
                updateCustomer.surname = surname;
                updateCustomer.phone = phone;

                updateCustomer.ShowDialog();

                
            }

            label1.Focus();

        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            dba.GetSound();

            if (dgvCustomerList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite redak koji želite obrisati");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Spremate se obrisati mušteriju. Jeste li sigurni?", "Upozorenje", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvCustomerList.SelectedRows[0].Cells[0].Value);
                    dba.DeleteCustomer(id);

                    this.RefreshCustomers(null);
                }
                
                                
            }

            label1.Focus();

        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            dba.GetSound();

            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.RefreshCustomers(null);
        }

        private void btnGivePoint_Click(object sender, EventArgs e)
        {
            dba.GetSound();

            if (dgvCustomerList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite mušteriju kojoj želite dodijeliti bod");
            }
            else
            {
                frmGivePoint givePoint = new frmGivePoint(this);

                int id = Convert.ToInt32(dgvCustomerList.SelectedRows[0].Cells[0].Value);
                int point = Convert.ToInt32(dgvCustomerList.SelectedRows[0].Cells[4].Value.ToString());
                //dba.GivePoint(id, point);

                givePoint.id = id;
                givePoint.point = point;

                givePoint.ShowDialog();

                

                //this.fuck(null);
            }

            label1.Focus();
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            dba.GetSound();

            frmSearchCustomer searchCustomer = new frmSearchCustomer(this);
            searchCustomer.ShowDialog();

            label1.Focus();
        }

        private void btnCustomerDates_Click(object sender, EventArgs e)
        {
            dba.GetSound();

            if (dgvCustomerList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite jedan redak koji želite izmijeniti");
            }
            else
            {
                frmViewDates viewDates = new frmViewDates();

                int id = Convert.ToInt32(dgvCustomerList.SelectedRows[0].Cells[0].Value);


                viewDates.id = id;


                viewDates.ShowDialog();

            }

            label1.Focus();

        }


        private void btnAddCustomer_MouseEnter(object sender, EventArgs e)
        {
            dba.GetHoverSound();
        }
        private void btnUpdateCustomer_MouseEnter(object sender, EventArgs e)
        {
            dba.GetHoverSound();
        }
        private void btnDeleteCustomer_MouseEnter(object sender, EventArgs e)
        {
            dba.GetHoverSound();
        }
        private void btnExitApp_MouseEnter(object sender, EventArgs e)
        {
            dba.GetHoverSound();
        }
        private void btnGivePoint_MouseEnter(object sender, EventArgs e)
        {
            dba.GetHoverSound();
        }
        private void btnSearchCustomer_MouseEnter(object sender, EventArgs e)
        {
            dba.GetHoverSound();
        }
        private void btnCustomerDates_MouseEnter(object sender, EventArgs e)
        {
            dba.GetHoverSound();
        }
        

    }
}


