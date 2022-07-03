using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace SvelteKitSample.Model
{
    [ApiController]
    [Route("api/[controller]")]
    [Consumes("application/x-www-form-urlencoded")]
    public class AdduserController : ControllerBase
    {
        [HttpPost]
        [Consumes("application/x-www-form-urlencoded")]
        public string Post([FromForm] IFormCollection value)
        {
            var key = System.Configuration.ConfigurationManager.AppSettings.Get("DecryptionKey");
            string cf = AesOperation.EncryptString(key,value["cf"]);
            string nascita = AesOperation.EncryptString(key, value["nascita"]);
            string telefono = AesOperation.EncryptString(key, value["telefono"]);
            string email = value["email"];
            string password = value["password"];
            string timestamp = value["timestamp"];
            if(cf == null || nascita == null || telefono == null || email == null || password == null || timestamp == null)
            {
                return "0";
            }
            else
            {
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

                        String sql = $"EXEC dbo.Adduser '{cf}', '{nascita}', '{telefono}', '{email}', '{password}', '{timestamp}'";
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
}
