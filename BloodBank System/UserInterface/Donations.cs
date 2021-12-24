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
    public partial class Donations : Form
    {
        DonationClass d_class = new DonationClass();
        Donation d_withdb = new Donation();
        public Donations()
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

        private void Donations_Load(object sender, EventArgs e)
        {
            DataTable dt = d_withdb.select();
            dataGridView1.DataSource = dt;

            DataGridViewButtonColumn deletecolumn = new DataGridViewButtonColumn();
            deletecolumn.Name = "Delete";
            deletecolumn.Text = "Delete";
            deletecolumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(deletecolumn);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var gridsender = (DataGridView)sender;
            if (gridsender.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                try
                {
                    d_class.ID = int.Parse(gridsender.Rows[e.RowIndex].Cells[0].Value.ToString());
                    d_class.FirstName = gridsender.Rows[e.RowIndex].Cells[1].Value.ToString();
                    d_class.LastName = gridsender.Rows[e.RowIndex].Cells[2].Value.ToString();
                    d_class.NationalNumber = gridsender.Rows[e.RowIndex].Cells[3].Value.ToString();
                    d_class.BloodGroup = bloodgroupid(gridsender.Rows[e.RowIndex].Cells[6].Value.ToString());
                    bool success = d_withdb.delete(d_class);

                    if (success)
                    {
                        MessageBox.Show("Deleted Succesfully", "Deleted");

                    }
                    else
                    {
                        MessageBox.Show("Error While Deleting, Try Again", "Error");
                    }

                    clear();
                    dataGridView1.ClearSelection();
                    dataGridView1.Columns.Clear();

                    newdt();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }

            }
        }

        private int bloodgroupid(string s)
        {
            if (s == "A+")
            {
                return 2;
            }
            else if (s == "A-")
            {
                return 3;
            }
            else if (s == "B+")
            {
                return 4;
            }
            else if (s == "B-")
            {
                return 5;
            }
            else if (s == "O+")
            {
                return 6;
            }
            else if (s == "O-")
            {
                return 7;
            }
            else if (s == "AB+")
            {
                return 8;
            }
            else if (s == "AB-")
            {
                return 9;
            }
            return 0;

        }

        private void clear()
        {
            d_class.ID = 0;
            d_class.FirstName = null;
            d_class.LastName = null;
            d_class.NationalNumber = null;
            d_class.BloodGroup = 0;
        }

        private void newdt()
        {
            DataTable dt = d_withdb.select();
            dataGridView1.DataSource = dt;

            DataGridViewButtonColumn deletecolumn = new DataGridViewButtonColumn();
            deletecolumn.Name = "Delete";
            deletecolumn.Text = "Delete";
            deletecolumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(deletecolumn);
        }

        private void showall_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.Columns.Clear();
            newdt();
            searchid_txt.Clear();
        }

        private void searchidbtn_Click(object sender, EventArgs e)
        {
            string s = searchid_txt.Text;
            if (s != null)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Columns.Clear();
                DataTable dt = d_withdb.searchbyid(s);
                dataGridView1.DataSource = dt;

                DataGridViewButtonColumn deletecolumn = new DataGridViewButtonColumn();
                deletecolumn.Name = "Delete";
                deletecolumn.Text = "Delete";
                deletecolumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(deletecolumn);
            }
            else
            {
                dataGridView1.ClearSelection();
                dataGridView1.Columns.Clear();
                newdt();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int blood_group_id =0;

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

            string s = blood_group_id.ToString();
            if (s != null)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Columns.Clear();
                DataTable dt = d_withdb.searchbybloodgroup(s);
                dataGridView1.DataSource = dt;

                DataGridViewButtonColumn deletecolumn = new DataGridViewButtonColumn();
                deletecolumn.Name = "Delete";
                deletecolumn.Text = "Delete";
                deletecolumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(deletecolumn);
            }
            else
            {
                dataGridView1.ClearSelection();
                dataGridView1.Columns.Clear();
                newdt();
            }
        }

    }
}
