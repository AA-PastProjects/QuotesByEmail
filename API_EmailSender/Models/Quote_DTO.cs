using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_EmailSender.Models
{
    public class Quote_DTO
    {
        public Quote_DTO(string q, string a) {
            Quote = q;
            Author = a;
        }

        public string Quote { get; set; }
        public string Author { get; set; }
    }
}
