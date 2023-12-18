using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExecPetTransportBlazorAPI517.Models
{
    public class Quote
    {
        public int QuoteId { get; set; }

        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CellNumber { get; set; }
        public string Instructions { get; set; }


    }

}
