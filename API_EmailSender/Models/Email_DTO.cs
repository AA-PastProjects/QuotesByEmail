using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_EmailSender.Models
{
    public class Email_DTO
    {
        public Email_DTO(string a, string n)
        {
            Address = a;
            NameOfReceiver = n;
        }

        /// <summary>
        /// The email address.
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Name of email recipient.
        /// </summary>
        public string NameOfReceiver { get; set; }

    }
}
