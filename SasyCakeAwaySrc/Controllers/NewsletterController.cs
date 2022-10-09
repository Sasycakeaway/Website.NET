using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SvelteKitSample.Model;

namespace SvelteKitSample.Controllers
{
    [Route("api/[controller]/{email}/{token}")]
    [ApiController]
    public class NewsletterController : ControllerBase
    {
        [HttpGet]
        public string Delete(string email, string token)
        {
            try
            {
                using(var db = new SasyContext())
                {
                    var email_to_delete = db.Utentis.Where(e => e.PkEmail == email).SingleOrDefault();
                    if (email_to_delete != null)
                    {
                        var token_to_delete = db.Newsletters.Where(e => e.PkToken == Guid.Parse(token))
                            .Where(e => e.FkEmail == email).SingleOrDefault();

                        if(token_to_delete != null)
                        {
                            email_to_delete.News = false;

                            db.Utentis.Attach(email_to_delete).Property(e => e.News).IsModified = true;
                            db.Newsletters.Remove(token_to_delete);
                            db.SaveChanges();
                        }

                    }
                }
                return "Sei stato rimosso dalla newsletter correttamente!";
            }catch (Exception ex)
            {
                Console.WriteLine(ex);
                return "C'è stato un errore durante la rimozione del tuo account dalla newsletter, contattare Sasy";
            }
        }
    }
}
