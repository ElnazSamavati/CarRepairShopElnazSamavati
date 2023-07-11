using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRepairShopAccounting
{
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }

        private void customers_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
            this.Hide();
        }

        private void Panel_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("آیا میخواهید خارج شوید؟","اخطار",MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
                e.Cancel = true;
            else
                Application.Exit();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cars_Click(object sender, EventArgs e)
        {
            Car c = new Car();
            c.Show();
            this.Hide();
        }
    }
}
