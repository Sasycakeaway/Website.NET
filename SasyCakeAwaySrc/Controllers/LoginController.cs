using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Microsoft.AspNetCore.Http;
namespace SvelteKitSample.Model
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        public class test {
            public string email;
            public string password;
        }
        [HttpPost]
        public string Post([FromForm] IFormCollection request)
        {
            try{
            string password = request["password"];
            string email = request["email"];
            using (var context = new SasyContext())
            {
                Utenti user = (from Utenti in context.Utentis where Utenti.PkEmail == email select Utenti).First();
                if(user.Password == password)
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            }catch{
                return "0";
            }

        }
    }
}
