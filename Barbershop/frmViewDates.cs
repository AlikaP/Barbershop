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
    public partial class frmViewDates : Form
    {
        DB_Access dba = new DB_Access();

        public int id;

        public frmViewDates()
        {
            InitializeComponent();

            btnExitDate.MouseEnter += new EventHandler(btnExitDate_MouseEnter);
            
        }


        private void frmViewDates_Load(object sender, EventArgs e)
        {
            //dohvat podataka iz tablice (dataset)
            
            var ds = dba.ViewDates(id);

            BindingSource bs = new BindingSource();

            bs.DataSource = ds.Tables[0];

            //dohvata podataka iz dataseta i slanje na datagridview
            //dgvCustomerList.DataSource = ds.Tables["Customer"].DefaultView;
            dgvCustomerDates.DataSource = bs;

            

        }

        private void btnExitSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnExitDate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExitDate_Click_1(object sender, EventArgs e)
        {
            dba.GetSound();

            Close();
        }



        private void btnExitDate_MouseEnter(object sender, EventArgs e)
        {
            dba.GetHoverSound();
        }
        
    }
}
