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
    class Donation
    {

        static string dbconnection = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public DataTable select()
        {
            SqlConnection connection = new SqlConnection(dbconnection);
            DataTable dt = new DataTable();
            try
            {
                string query = "Select donation.ID, FirstName, LastName, NationalNumber, MobileNumber, City, bloodgroup.BloodGroup, DonationDate from donation join bloodgroup on donation.BloodGroup = bloodgroup.ID";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                connection.Open();
                adapter.Fill(dt);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public bool insert(DonationClass d)
        {
            bool inserted = false;
            SqlConnection connection = new SqlConnection(dbconnection);
            try
            {
                string query = "INSERT INTO DONATION(NationalNumber, FirstName, LastName, City, BloodGroup, MobileNumber, DonationDate) VALUES (@national_num, @first_name, @last_name, @city, @blood_group, @mobile_num, @donation_date)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@national_num", d.NationalNumber);
                cmd.Parameters.AddWithValue("@first_name", d.FirstName);
                cmd.Parameters.AddWithValue("@last_name", d.LastName);
                cmd.Parameters.AddWithValue("@city", d.City);
                cmd.Parameters.AddWithValue("@blood_group", d.BloodGroup);
                cmd.Parameters.AddWithValue("@mobile_num", d.MobileNumber);
                cmd.Parameters.AddWithValue("@donation_date", d.DonationDate);

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

        public bool update(DonationClass d)
        {
            bool updated = false;
            SqlConnection connection = new SqlConnection(dbconnection);
            try
            {
                string query = "Update DONATION SET NationalNumber=@national_num, FirstName=@first_name, LastName=@last_name, City=@city, BloodGroup=@blood_group, MobileNumber=@mobile_num, DonationDate=@donation_date)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@national_num", d.NationalNumber);
                cmd.Parameters.AddWithValue("@first_name", d.FirstName);
                cmd.Parameters.AddWithValue("@last_name", d.LastName);
                cmd.Parameters.AddWithValue("@city", d.City);
                cmd.Parameters.AddWithValue("@blood_group", d.BloodGroup);
                cmd.Parameters.AddWithValue("@mobile_num", d.MobileNumber);
                cmd.Parameters.AddWithValue("@donation_date", d.DonationDate);

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

        public bool delete(DonationClass d)
        {
            bool deleted = false;
            SqlConnection connection = new SqlConnection(dbconnection);
            try
            {
                string query = "DELETE FROM DONATION WHERE ID=@donation_id";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("donation_id", d.ID);
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
                string query = "Select donation.ID, FirstName, LastName, NationalNumber, MobileNumber, City, bloodgroup.BloodGroup, DonationDate from donation join bloodgroup on donation.BloodGroup = bloodgroup.ID where donation.ID = '" + s + "'";
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
                string query = "Select donation.ID, FirstName, LastName, NationalNumber, MobileNumber, City, bloodgroup.BloodGroup, DonationDate from donation join bloodgroup on donation.BloodGroup = bloodgroup.ID where donation.Bloodgroup = '" + s + "'";
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

        public string bloodgroupcount(string s)
        {
            SqlConnection connection = new SqlConnection(dbconnection);
            string count = "0";
            try
            {
                string query = "Select donation.ID, FirstName, LastName, NationalNumber, MobileNumber, City, bloodgroup.BloodGroup, DonationDate from donation join bloodgroup on donation.BloodGroup = bloodgroup.ID where bloodgroup.BloodGroup = '" + s + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                connection.Open();
                adapter.Fill(dt);
                count = dt.Rows.Count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
            finally
            {
                connection.Close();
            }
            return count;
        }
    }
}
