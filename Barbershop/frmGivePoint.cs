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
    public partial class frmGivePoint : Form
    {
        public int id;
        public int point;

        DB_Access dba = new DB_Access();

        public frmGivePoint()
        {
            InitializeComponent();
        }

        frmViewCustomers _owner;
        public frmGivePoint (frmViewCustomers owner)
        {
            InitializeComponent();
            _owner = owner;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGivePoint_FormClosing);

            btnAddPoint.MouseEnter += new EventHandler(btnAddPoint_MouseEnter);
            btnExitPoint.MouseEnter += new EventHandler(btnExitPoint_MouseEnter);
        }

        private void frmGivePoint_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.RefreshCustomers(null);
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmGivePoint_Load(object sender, EventArgs e)
        {
            label1.Select();
        }

        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            dba.GetSound();

            var date = metroDateTime1.Value;

            dba.GivePoint(id, point, date);

            Close();
        }

        private void btnExitPoint_Click(object sender, EventArgs e)
        {
            dba.GetSound();

            Close();
        }


        private void btnAddPoint_MouseEnter(object sender, EventArgs e)
        {
            dba.GetHoverSound();
        }
        private void btnExitPoint_MouseEnter(object sender, EventArgs e)
        {
            dba.GetHoverSound();
        }
    }
}
