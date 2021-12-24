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
    public partial class Login : Form
    {
        UsersWithDb userslogin = new UsersWithDb();
        public Login()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if(userslogin.login(this.username_txt.Text, this.password_txt.Text))
            {
                Home h = new Home();
                h.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Login! Please try again.", "Login error");
            }
        }
    }
}
