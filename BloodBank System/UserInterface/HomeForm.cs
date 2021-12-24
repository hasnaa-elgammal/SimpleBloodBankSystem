using A_life.classes_with_db;
using A_life.UserInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_life
{
    public partial class Home : Form
    {
        Donation d = new Donation();
        public Home()
        {
            InitializeComponent();
        }

        private void adddonation_Click(object sender, EventArgs e)
        {
            AddDonationForm add_donation = new AddDonationForm();
            add_donation.Show();
            this.Hide();
        }

        private void addorder_Click(object sender, EventArgs e)
        {
            AddOrder add_order = new AddOrder();
            add_order.Show();
            this.Hide();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }


        private void dONATIONSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Donations d = new Donations();
            d.Show();
            this.Hide();
        }

        private void bLOODORDERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orders d = new Orders();
            d.Show();
            this.Hide();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            u.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            bloodcount();
        }

        private void bloodcount()
        {
            opositivenum.Text = d.bloodgroupcount("O+");
            onegativenum.Text = d.bloodgroupcount("O-");
            apositivenum.Text = d.bloodgroupcount("A+");
            anegativenum.Text = d.bloodgroupcount("A-");
            bpositivenum.Text = d.bloodgroupcount("B+");
            bnegativenum.Text = d.bloodgroupcount("B-");
            abpositivenum.Text = d.bloodgroupcount("AB+");
            abnegativenum.Text = d.bloodgroupcount("AB-");
        }
    }
}
