using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp9.Models;

namespace WindowsFormsApp9
{
    public class DBService
    {
        private readonly string connectionString;
        public DBService(string _connectionString)
        {
            connectionString = _connectionString;
        }
        public List<Property> GetAvailableProperties()
        {
            var properties = new List<Property>();
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Properties";
                SqlCommand command = new SqlCommand(query, connection);
                using (var reader = command.ExecuteReader())

                {
                    while (reader.Read())
                    {
                        properties.Add(new Property()
                        {
                            PropertyId = reader.GetInt32(0),
                            Address = reader.GetString(1),
                            Type = reader.GetString(2),
                            Price = reader.GetDecimal(3),
                            Area = reader.GetDecimal(4),
                            IsAvailable = reader.GetBoolean(5)
                        });
                    }
                }
                return properties;
            }
        }
        public void AddProperty(Property property)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"INSERT INTO Properties (Address, Type, Price, Area, IsAvailable) VALUES (@Address, @Type, @Price, @Area, @IsAvailable)";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Address", property.Address);
                    command.Parameters.AddWithValue("@Type", property.Type);
                    command.Parameters.AddWithValue("@Price", property.Price);
                    command.Parameters.AddWithValue("@Area", property.Area);
                    command.Parameters.AddWithValue("@IsAvailable", property.IsAvailable);
                    command.ExecuteNonQuery();
                }
            }
        }
        public List<Viewing> GetViewings()
        {
            var viewings = new List<Viewing>();
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Viewings";
                SqlCommand command = new SqlCommand(query, connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        viewings.Add(new Viewing()
                        {
                            ViewingId = reader.GetInt32(0),
                            PropertyId = reader.GetInt32(1),
                            ClientId = reader.GetInt32(2),
                            AgentId = reader.GetInt32(3),
                            ScheduledDate = reader.GetDateTime(4),
                            
                        });
                    }
                }
                return viewings;
            }
        }
    }
}







        
