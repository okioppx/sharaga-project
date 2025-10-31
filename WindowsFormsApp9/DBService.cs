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
        public List<Client> GetAllClients()
        {
            var clients = new List<Client>();
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Clients";
                SqlCommand command = new SqlCommand(query, connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clients.Add(new Client()
                        {
                            ClientId = reader.GetInt32(0),
                            FirstName = reader.GetString(1),
                            LastName = reader.GetString(2),
                            Phone = reader.GetString(3),
                            ClientType = reader.GetString(4),

                        });
                    }
                }
                return clients;
            }
        }
        public List<Agent> GetAllAgents()
        {
            var agents = new List<Agent>();
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Agents";
                SqlCommand command = new SqlCommand(query, connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        agents.Add(new Agent()
                        {
                            AgentId = reader.GetInt32(0),
                            FirstName = reader.GetString(1),
                            LastName = reader.GetString(2),
                            Phone = reader.GetString(3)
                        });
                    }
                }
            }
            return agents;
        }

        public void AddViewing(Viewing viewing)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"INSERT INTO Viewings (PropertyId, ClientId, AgentId, ScheduledDate, ClientFeedback) VALUES (@PropertyId, @ClientId, @AgentId, @ScheduledDate, @ClientFeedback)";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PropertyId", viewing.PropertyId);
                    command.Parameters.AddWithValue("@ClientId", viewing.ClientId);
                    command.Parameters.AddWithValue("@AgentId", viewing.AgentId);
                    command.Parameters.AddWithValue("@ScheduledDate", viewing.ScheduledDate);
                    command.Parameters.AddWithValue("@ClientFeedback", viewing.ClientFeedback);
                    command.ExecuteNonQuery();
                }
            } 
        }
        public List<Viewing> GetViewingsByProperty(int propertyId)
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
                                ClientFeedback = reader.GetString(5)
                            });
                        }
                    }
                }
            return viewings;
        }   
    
                            
    }
}