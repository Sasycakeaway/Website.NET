using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace SvelteKitSample.Model
{
    [ApiController]
    [Route("api/[controller]")]
    [Consumes("application/x-www-form-urlencoded")]
    public class AddOrderController : ControllerBase
    {
        [HttpPost]
        [Consumes("application/x-www-form-urlencoded")]
        public string Post([FromForm] IFormCollection value)
        {
            Console.WriteLine(value["totale"]);
            var key = System.Configuration.ConfigurationManager.AppSettings.Get("DecryptionKey");
            Guid id = Guid.Parse(value["id"]);
            string nome = AesOperation.EncryptString(key, value["nome"]);
            string cognome = AesOperation.EncryptString(key, value["cognome"]);
            string indirizzo = AesOperation.EncryptString(key, value["indirizzo"]);
            string cap = AesOperation.EncryptString(key, value["cap"]);
            string domicilio = AesOperation.EncryptString(key, value["domicilio"]);
            string email = value["email"];
            int totale = int.Parse(value["totale"]);
            string cart = value["cart"];
            DateTime timestamp = new DateTime();
        
                try
                {
                    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                    builder.DataSource = "149.102.141.16";
                    builder.UserID = "sa";
                    builder.Password = "Pintotto1!";
                    builder.InitialCatalog = "Sasy";
                    builder.Encrypt = false;
                    using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                    {
                        connection.Open();

                        String sql = $"EXEC dbo.AddOrder '{id}', '{nome}', '{cognome}', '{indirizzo}', '{cap}', '{domicilio}', '{email}', '{totale}', '{cart}', '{timestamp}'";
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                return "1";
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
