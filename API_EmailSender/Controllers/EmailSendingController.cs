using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuoteEmailer;

namespace API_EmailSender.Controllers
{
    [Produces("application/json")]
    [Route("api/EmailSending")]
    public class EmailSendingController : Controller
    {
        // GET: api/EmailSending
        [HttpGet]
        public Models.Email_DTO Get()
        {
            var email = new Models.Email_DTO("Example@example.com", "Firstname Lastname");
            return email;
        }

        // POST: api/EmailSending
        [HttpPost]
        public IActionResult Post([FromBody]Models.Email_DTO email_dto)
        {
            var email = new Models.Email(email_dto);
            var qf = new QuoteFetcher();
            var q = qf.GetQuote();
            var wf = new WikipediaFetcher();
            var wp = wf.GetWikipediaPage(q.author);
            var qdto = new Models.Quote_DTO(q.quote, q.author);
            var wdto = new Models.WikiPage_DTO(wp.wikiText);
            EmailSender.SendEmailWithSmtp(email, qdto, wdto);
            return Json("Email sent to " + email_dto.Address);
        }
    }
}
