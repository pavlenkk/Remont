using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Remont
{
    public class DatabaseManager
    {
        private string connectionString;

        public DatabaseManager()
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["RepairDB"].ConnectionString;
        }

        public DataTable GetUsers()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM users";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    DataTable dt = new DataTable();
                    using (var reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                    return dt;
                }
            }
        }

        public DataTable GetRemont()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM requests";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    DataTable dt = new DataTable();
                    using (var reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                    return dt;
                }
            }
        }

        public void Delete(int requestId)
        {
            string query = "DELETE FROM requests WHERE request_id = @RequestId;";

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RequestId", requestId);
                    command.ExecuteNonQuery();
                }
            }
        }


        public void AddTask(DateTime DateAdded, string Equipment, string FaultType, string ProblemDescription, string Client, string Status)
        {
            string query = @"
        INSERT INTO requests (dateadded, equipment, faulttype, problemdescription, client, status)
        VALUES (@DateAdded, @Equipment, @FaultType, @ProblemDescription, @Client, @Status);";

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DateAdded", DateAdded);
                    command.Parameters.AddWithValue("@Equipment", Equipment);
                    command.Parameters.AddWithValue("@FaultType", FaultType);
                    command.Parameters.AddWithValue("@ProblemDescription", ProblemDescription);
                    command.Parameters.AddWithValue("@Client", Client);
                    command.Parameters.AddWithValue("@Status", Status);

                    command.ExecuteNonQuery();
                }
            }
        }


        public void Update(int RequestId, string ProblemDescription, string Client, string Status)
        {
            string query = @"
        UPDATE requests
        SET problemdescription = @ProblemDescription,
            client = @Client,
            status = @Status
        WHERE requestid = @RequestId;";

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProblemDescription", ProblemDescription);
                    command.Parameters.AddWithValue("@Client", Client);
                    command.Parameters.AddWithValue("@Status", Status);
                    command.Parameters.AddWithValue("@RequestId", RequestId);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
