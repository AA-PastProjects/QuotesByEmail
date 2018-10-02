using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_EmailValidator.Models
{
    public class Email_DTO
    {
        public Email_DTO(string e, bool v)
        {
            email = e;
            valid = v;
        }

        public Email_DTO(Email e)
        {
            email = e.email;
            valid = e.valid;
        }

        public string email = "notSet";
        public bool valid = false;
    }
}
