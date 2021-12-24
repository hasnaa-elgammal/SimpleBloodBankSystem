using A_life.classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_life.classes_with_db
{
    class UsersWithDb
    {
        static string dbconnection = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public bool login(string username, string password)
        {
            SqlConnection connection = new SqlConnection(dbconnection);
            DataTable dt = new DataTable();
            try
            {
                string query = "Select UserName, password from SystemUsers where Username = '" + username + "' and password = '" + password + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                connection.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
            finally
            {
                connection.Close();
            }
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }

        public DataTable select()
        {
            SqlConnection connection = new SqlConnection(dbconnection);
            DataTable dt = new DataTable();
            try
            {
                string query = "Select ID, UserName, FirstName, LastName from SystemUsers";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                connection.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public bool insert(UserClass d)
        {
            bool inserted = false;
            SqlConnection connection = new SqlConnection(dbconnection);
            try
            {
                string query = "INSERT INTO SystemUsers(UserName, FirstName, LastName, password) VALUES (@user_name, @first_name, @last_name, @password)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@user_name", d.UserName);
                cmd.Parameters.AddWithValue("@first_name", d.FirstName);
                cmd.Parameters.AddWithValue("@last_name", d.LastName);
                cmd.Parameters.AddWithValue("@password", d.password);

                connection.Open();

                int rowsnum = cmd.ExecuteNonQuery();

                if (rowsnum > 0)
                {
                    inserted = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
            finally
            {
                connection.Close();
            }
            return inserted;
        }

        public bool delete(UserClass d)
        {
            bool deleted = false;
            SqlConnection connection = new SqlConnection(dbconnection);
            try
            {
                string query = "DELETE FROM SystemUsers WHERE ID=@user_id";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("user_id", d.ID);
                connection.Open();

                int rowsnum = cmd.ExecuteNonQuery();

                if (rowsnum > 0)
                {
                    deleted = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
            finally
            {
                connection.Close();
            }
            return deleted;
        }
    }
}
