using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;

namespace SvelteKitSample.Model
{
    [ApiController]
    [Route("api/[controller]")]
    public class GetUserController : ControllerBase
    {
        [HttpGet("{id}")]
        public string Get(string id)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                builder.DataSource = System.Configuration.ConfigurationManager.AppSettings.Get("DBURL");
                builder.UserID = "sa";
                builder.Password = System.Configuration.ConfigurationManager.AppSettings.Get("DBPass");
                builder.InitialCatalog = "Sasy";
                builder.Encrypt = false;

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    String sql = "EXEC dbo.GetUserByEmail @email = '" + id + "'";
                    Console.WriteLine("EXEC dbo.GetUserByEmail @email = '" + id + "'");
                    List<Utenti> users = new List<Utenti>();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Utenti utente = new Utenti();
                                utente.Cf = reader.GetString(0);
                                utente.Nascita = reader.GetString(1);
                                utente.Telefono = reader.GetString(2);
                                utente.PkEmail = reader.GetString(3);
                                utente.Password = reader.GetString(4);
                                utente.Timestamp = reader.GetDateTime(5);
                                users.Add(utente);
                            }
                        }
                    }
                    return JsonConvert.SerializeObject(users);
                }
                
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            return "NOP";
        }

    }
}
