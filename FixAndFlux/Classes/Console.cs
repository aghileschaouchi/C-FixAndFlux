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
    class Console
    {
        public int ConsoleId { get; set; }
        public string ConsoleName { get; set; }
        public string Problem { get; set; }
        public bool Fixed { get; set; }
        public int ClientId { get; set; }

        static string _connexionString = ConfigurationManager.ConnectionStrings["costr"].ConnectionString;

        public DataTable Select() 
        {
            string connexionString = "Data Source=.;Initial Catalog=ConsoleDB;Integrated Security=True";
            SqlConnection connexion = new SqlConnection(connexionString);
            DataTable dataTable = new DataTable();
            try
            {
                String sqlQuery = "SELECT * FROM FFConsole";
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

        public bool Insert(Console console)
        {
            bool result = false;
            string connexionString = "Data Source=.;Initial Catalog=ConsoleDB;Integrated Security=True";
            SqlConnection connexion = new SqlConnection(connexionString);
            try
            {
                string sqlQuery = "INSERT INTO FFConsole (ConsoleName, Problem, Fixed, ClientId) VALUES (@ConsoleName, @Problem, @Fixed, @ClientId)";
                SqlCommand command = new SqlCommand(sqlQuery, connexion);
                command.Parameters.AddWithValue("@ConsoleName", console.ConsoleName);
                command.Parameters.AddWithValue("@Problem", console.Problem);
                command.Parameters.AddWithValue("@Fixed", console.Fixed);
                command.Parameters.AddWithValue("@ClientId", console.ClientId);

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
        public bool Update(Console console)
        {
            bool result = false;
            SqlConnection connexion = new SqlConnection(_connexionString);

            try
            {
                string sqlQuery = "UPDATE FFConsole SET ConsoleName=@ConsoleName, Problem=@Problem, Fixed=@Fixed, ClientId=@ClientId WHERE ConsoleId=@ConsoleId";
                SqlCommand command = new SqlCommand(sqlQuery, connexion);
                command.Parameters.AddWithValue("@ConsoleName", console.ConsoleName);
                command.Parameters.AddWithValue("@Problem", console.Problem);
                command.Parameters.AddWithValue("@Fixed", console.Fixed);
                command.Parameters.AddWithValue("@ClientId", console.ConsoleId);
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

        public bool Delete(Console console)
        {
            bool result = false;
            SqlConnection connexion = new SqlConnection(_connexionString);
            try
            {
                string sqlQuery = "DELETE FROM FFConsole WHERE ConsoleId=@ConsoleId";
                SqlCommand command = new SqlCommand(sqlQuery, connexion);
                command.Parameters.AddWithValue("@ConsoleId", console.ConsoleId);
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
