using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System.Data;

namespace SvelteKitSample.Model
{
    [ApiController]
    [Route("api/[controller]")]
    public class GetOrdersByPassController : ControllerBase
    {
        [HttpPost]
        public string Get([FromForm] IFormCollection request)
        {
            var key = System.Configuration.ConfigurationManager.AppSettings.Get("DecryptionKey");
            string email = request["email"];
            string password = request["password"];

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

                    String sql = $"EXEC dbo.GetOrderByEmail '{email}'";
                    List<Ordini> ordini = new List<Ordini>();
                    using (var context = new SasyContext())
                    {
                        var query = context.Utentis
                                           .Where(s => s.PkEmail == email)
                                           .FirstOrDefault<Utenti>();
                        if (query.Password == password)
                        {
                
 
                            using (SqlCommand command = new SqlCommand(sql, connection))
                            {
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        Ordini order = new Ordini();
                                        order.PkId = reader.GetInt64(0);
                                        order.Nome = AesOperation.DecryptString(key,reader.GetString(1));
                                        order.Cognome = AesOperation.DecryptString(key, reader.GetString(2));
                                        order.Indirizzo = AesOperation.DecryptString(key, reader.GetString(3));
                                        order.Cap = AesOperation.DecryptString(key, reader.GetString(4));
                                        order.Domicilio = AesOperation.DecryptString(key, reader.GetString(5));
                                        order.FkEmail = reader.GetString(6);
                                        order.Totale = reader.GetInt16(7);
                                        order.Cart = reader.GetString(8);
                                        order.Timestamp = reader.GetDateTime(9);
                                        ordini.Add(order);
                                    }
                                }
                                return JsonConvert.SerializeObject(ordini);
                            }
                            
                        }
                        else
                        {
                            return "0";
                        }
                    }
                    

                }

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return "0";
            }
        }

    }
}
