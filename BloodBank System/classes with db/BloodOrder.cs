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
    class BloodOrder
    {

        static string dbconnection = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;


        public DataTable select()
        {
            SqlConnection connection = new SqlConnection(dbconnection);
            DataTable dt = new DataTable();
            try
            {
                string query = "Select blood_order.ID, FirstName, LastName, NationalNumber, MobileNumber, bloodgroup.BloodGroup, Units, OrderStatus, OrderDate from blood_order join bloodgroup on blood_order.BloodGroup = bloodgroup.ID";
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

        public bool insert(BloodOrderClass d)
        {
            bool inserted = false;
            SqlConnection connection = new SqlConnection(dbconnection);
            try
            {
                string query = "INSERT INTO BLOOD_ORDER(NationalNumber, FirstName, LastName, BloodGroup, Units, MobileNumber, OrderStatus, OrderDate) VALUES (@national_num, @first_name, @last_name,@blood_group, @units, @mobile_num, @order_status, @order_date)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@national_num", d.NationalNumber);
                cmd.Parameters.AddWithValue("@first_name", d.FirstName);
                cmd.Parameters.AddWithValue("@last_name", d.LastName);
                cmd.Parameters.AddWithValue("@blood_group", d.BloodGroup);
                cmd.Parameters.AddWithValue("@units", d.Units);
                cmd.Parameters.AddWithValue("@mobile_num", d.MobileNumber);
                cmd.Parameters.AddWithValue("@order_status", d.OrderStatus);
                cmd.Parameters.AddWithValue("@order_date", d.OrderDate);

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

        public bool update(BloodOrderClass d)
        {
            bool updated = false;
            SqlConnection connection = new SqlConnection(dbconnection);
            try
            {
                string query = "Update BLOOD_ORDER SET NationalNumber=@national_num, FirstName=@first_name, LastName=@last_name, BloodGroup=@blood_group, Units=@units, MobileNumber=@mobile_num, OrderStatus=@order_status, OrderDate=@order_date)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@national_num", d.NationalNumber);
                cmd.Parameters.AddWithValue("@first_name", d.FirstName);
                cmd.Parameters.AddWithValue("@last_name", d.LastName);
                cmd.Parameters.AddWithValue("@blood_group", d.BloodGroup);
                cmd.Parameters.AddWithValue("@units", d.Units);
                cmd.Parameters.AddWithValue("@mobile_num", d.MobileNumber);
                cmd.Parameters.AddWithValue("@order_status", d.OrderStatus);
                cmd.Parameters.AddWithValue("@order_date", d.OrderDate);

                connection.Open();

                int rowsnum = cmd.ExecuteNonQuery();

                if (rowsnum > 0)
                {
                    updated = true;
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
            return updated;
        }

        public bool delete(BloodOrderClass d)
        {
            bool deleted = false;
            SqlConnection connection = new SqlConnection(dbconnection);
            try
            {
                string query = "DELETE FROM BLOOD_ORDER WHERE ID=@order_id";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("order_id", d.ID);
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

        public DataTable searchbyid(string s)
        {
            SqlConnection connection = new SqlConnection(dbconnection);
            DataTable dt = new DataTable();
            try
            {
                string query = "Select blood_order.ID, FirstName, LastName, NationalNumber, MobileNumber, bloodgroup.BloodGroup, Units, OrderStatus, OrderDate from blood_order join bloodgroup on blood_order.BloodGroup = bloodgroup.ID where blood_order.ID = '" + s + "'";
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

        public DataTable searchbybloodgroup(string s)
        {
            SqlConnection connection = new SqlConnection(dbconnection);
            DataTable dt = new DataTable();
            try
            {
                string query = "Select blood_order.ID, FirstName, LastName, NationalNumber, MobileNumber, bloodgroup.BloodGroup, Units, OrderStatus, OrderDate from blood_order join bloodgroup on blood_order.BloodGroup = bloodgroup.ID where blood_order.BloodGroup = '" + s + "'";
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

    }
}
