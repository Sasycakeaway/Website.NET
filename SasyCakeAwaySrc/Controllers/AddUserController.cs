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
                    using (var db = new SasyContext())
                    {
                        var user = new Utenti();
                        user.Cf = cf;
                        user.Nascita = nascita;
                        user.Telefono = telefono;
                        user.PkEmail = email;
                        user.Password = password;
                        user.Timestamp = DateTime.Parse(timestamp);
                        db.Add(user);
                        db.SaveChanges();
                        return "1";
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    return "0";
                }
            }
           
       
        }

    }
}
