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
    public partial class Users : Form
    {
        UserClass u = new UserClass();
        UsersWithDb u_with_db = new UsersWithDb();
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            DataTable dt = u_with_db.select();
            dataGridView1.DataSource = dt;

            DataGridViewButtonColumn deletecolumn = new DataGridViewButtonColumn();
            deletecolumn.Name = "Delete";
            deletecolumn.Text = "Delete";
            deletecolumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(deletecolumn);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var gridsender = (DataGridView)sender;
            if (gridsender.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                try
                {
                    u.ID = int.Parse(gridsender.Rows[e.RowIndex].Cells[0].Value.ToString());
                    u.UserName = gridsender.Rows[e.RowIndex].Cells[1].Value.ToString();
                    u.FirstName = gridsender.Rows[e.RowIndex].Cells[2].Value.ToString();
                    u.LastName = gridsender.Rows[e.RowIndex].Cells[3].Value.ToString();
                    bool success = u_with_db.delete(u);

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

        private void clear()
        {
            u.ID = 0;
            u.UserName = null;
            u.FirstName = null;
            u.LastName = null;
        }

        private void newdt()
        {
            DataTable dt = u_with_db.select();
            dataGridView1.DataSource = dt;

            DataGridViewButtonColumn deletecolumn = new DataGridViewButtonColumn();
            deletecolumn.Name = "Delete";
            deletecolumn.Text = "Delete";
            deletecolumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(deletecolumn);
        }


        private void addbtn_Click(object sender, EventArgs e)
        {
            AddUser a = new AddUser();
            a.Show();
            this.Hide();
        }
    }
}
