using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixAndFlux.Classes
{
    class Client
    {
        public int ClientId { get; set; }
        public string ClientFirstName { get; set; }
        public string ClientName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        static string _connexionString = ConfigurationManager.ConnectionStrings["costr"].ConnectionString;

        public DataTable Select()
        {
            string connexionString = "Data Source=.;Initial Catalog=ConsoleDB;Integrated Security=True";
            SqlConnection connexion = new SqlConnection(connexionString);
            DataTable dataTable = new DataTable();
            try
            {
                String sqlQuery = "SELECT * FROM FFClient";
                SqlCommand command = new SqlCommand(sqlQuery, connexion);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                connexion.Open();
                adapter.Fill(dataTable);
            }
            catch(System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
            }
            finally
            {
                connexion.Close();
            }
            return dataTable;
        }

        public bool Insert(Client client)
        {
            bool result = false;
            string connexionString = "Data Source=.;Initial Catalog=ConsoleDB;Integrated Security=True";
            SqlConnection connexion = new SqlConnection(connexionString);
            try
            {
                string sqlQuery = "INSERT INTO FFClient (ClientFirstName, ClientName, Phone, Email) VALUES (@ClientFirstName, @ClientName, @Phone, @Email)";
                SqlCommand command = new SqlCommand(sqlQuery, connexion);
                command.Parameters.AddWithValue("@ClientFirstName", client.ClientFirstName);
                command.Parameters.AddWithValue("@ClientName", client.ClientName);
                command.Parameters.AddWithValue("@Phone", client.Phone);
                command.Parameters.AddWithValue("@Email", client.Email);
                connexion.Open();
                int rows = command.ExecuteNonQuery();
                if (rows > 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch(System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
            }
            finally
            {
                connexion.Close();
            }
            return result;
        }

        public bool Update(Client client)
        {
            bool result = false;
            SqlConnection connexion = new SqlConnection(_connexionString);
            try
            {
                string sqlQuery = "UPDATE FFClient set ClientFirstName=@ClientFirstName, ClientName=@ClientName, Phone=@Phone, Email=@Email";
                SqlCommand command = new SqlCommand(sqlQuery, connexion);
                command.Parameters.AddWithValue("@ClientFirstName", client.ClientFirstName);
                command.Parameters.AddWithValue("@ClientName", client.ClientName);
                command.Parameters.AddWithValue("@Phone", client.Phone);
                command.Parameters.AddWithValue("@Email", client.Email);
                connexion.Open();
                int rows = command.ExecuteNonQuery();
                if (rows > 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
            }
            finally
            {
                connexion.Close();
            }
            return result;
        }

        public bool Delete(Client client)
        {
            bool result = false;
            SqlConnection connexion = new SqlConnection(_connexionString);
            try
            {
                string sqlQuery = "DELETE FROM FFClient WHERE ClientId=@ClientId";
                SqlCommand command = new SqlCommand(sqlQuery, connexion);
                command.Parameters.AddWithValue("@ClientId", client.ClientId);
                connexion.Open();
                int rows = command.ExecuteNonQuery();
                if (rows > 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
            }
            finally
            {
                connexion.Close();
            }
            return result;
        }
    }
}
