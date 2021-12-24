using A_life.classes;
using A_life.classes_with_db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_life.UserInterface
{
    public partial class AddUser : Form
    {
        UserClass u = new UserClass();
        UsersWithDb u_withdb = new UsersWithDb();
        public AddUser()
        {
            InitializeComponent();
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

        private void adddonation_Click(object sender, EventArgs e)
        {
            if (firstname_txt.Text != "" && lastname_txt.Text != "" && username_txt.Text != "" && password_txt.Text != "")
            {
                try
                {
                    u.FirstName = firstname_txt.Text;
                    u.LastName = lastname_txt.Text;
                    u.UserName = username_txt.Text;
                    u.password = password_txt.Text;

                    bool success = u_withdb.insert(u);

                    if (success)
                    {
                        MessageBox.Show("Added Succesfully", "Added");
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Error While Adding, Try Again", "Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
            else
            {
                MessageBox.Show("Please Fill All Fields");
            }
        }

        private void clear()
        {
            firstname_txt.Text = "";
            lastname_txt.Text = "";
            username_txt.Text = "";
            password_txt.Text = "";
        }
    }
}
