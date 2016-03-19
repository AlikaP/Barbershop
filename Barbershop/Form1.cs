using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barbershop
{
    public partial class Form1 : Form
    {
        DB_Access dba = new DB_Access();
        
        public Form1()
        {
            InitializeComponent();
            btnViewCustomers.MouseEnter += new EventHandler(btnViewCustomers_MouseEnter);
            btnUserData.MouseEnter += new EventHandler(btnUserData_MouseEnter);
            btnSettings.MouseEnter += new EventHandler(btnSettings_MouseEnter);
            btnExitApp.MouseEnter += new EventHandler(btnExitApp_MouseEnter);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Select();
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            dba.GetSound();

            Application.Exit();
        }



        private void btnViewCustomers_Click(object sender, EventArgs e)
        {
            dba.GetSound();

            frmViewCustomers viewCustomer = new frmViewCustomers();
            viewCustomer.ShowDialog();

            label1.Focus();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            dba.GetSound();

            frmSettings userSettings = new frmSettings();
            userSettings.ShowDialog();

            label1.Focus();
        }

        private void btnUserData_Click(object sender, EventArgs e)
        {
            dba.GetSound();


            frmUserData userData = new frmUserData();
            userData.ShowDialog();

            label1.Focus();
        }



        private void btnUserData_MouseEnter(object sender, EventArgs e)
        {
            dba.GetHoverSound();
        }
        private void btnViewCustomers_MouseEnter(object sender, EventArgs e)
        {
            dba.GetHoverSound();
        }
        private void btnSettings_MouseEnter(object sender, EventArgs e)
        {
            dba.GetHoverSound();
        }
        private void btnExitApp_MouseEnter(object sender, EventArgs e)
        {
            dba.GetHoverSound();
        }

    }
}
