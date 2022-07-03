using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace SvelteKitSample.Model
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeleteRequestController : ControllerBase
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

                    String sql = "EXEC dbo.RemoveRequest @uuid = '" + id + "'";
                    List<Utenti> users = new List<Utenti>();
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
            return "NOP";
        }

    }
}
