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
    public partial class AddOrder : Form
    {
        BloodOrderClass d_class = new BloodOrderClass();
        BloodOrder d_withdb = new BloodOrder();
        int blood_group_id;
        public AddOrder()
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

        private void addorderbtn_Click(object sender, EventArgs e)
        {
            if (firstname_txt.Text!="" && lastname_txt.Text != "" && comboBox1.SelectedItem != null && comboBox2.SelectedItem != null && numericUpDown1.Value != 0)
            {
                try
                {
                    d_class.FirstName = firstname_txt.Text;
                    d_class.LastName = lastname_txt.Text;
                    d_class.NationalNumber = nationalnum_txt.Text;
                    d_class.MobileNumber = mobilenum_txt.Text;
                    d_class.BloodGroup = blood_group_id;
                    d_class.Units = (int)numericUpDown1.Value;
                    d_class.OrderStatus = comboBox2.SelectedItem.ToString();
                    d_class.OrderDate = DateTime.Now.Date;

                    bool success = d_withdb.insert(d_class);

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
            }else
            {
                MessageBox.Show("Please Fill All Fields");
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "A+")
            {
                blood_group_id = 2;
            }
            else if (comboBox1.SelectedItem == "A-")
            {
                blood_group_id = 3;
            }
            else if (comboBox1.SelectedItem == "B+")
            {
                blood_group_id = 4;
            }
            else if (comboBox1.SelectedItem == "B-")
            {
                blood_group_id = 5;
            }
            else if (comboBox1.SelectedItem == "O+")
            {
                blood_group_id = 6;
            }
            else if (comboBox1.SelectedItem == "O-")
            {
                blood_group_id = 7;
            }
            else if (comboBox1.SelectedItem == "AB+")
            {
                blood_group_id = 8;
            }
            else if (comboBox1.SelectedItem == "AB-")
            {
                blood_group_id = 9;
            }

        }

        private void clear()
        {
            firstname_txt.Text = "";
            lastname_txt.Text = "";
            nationalnum_txt.Text = "";
            mobilenum_txt.Text = "";
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            numericUpDown1.Value = 0;


        }

    }
}
