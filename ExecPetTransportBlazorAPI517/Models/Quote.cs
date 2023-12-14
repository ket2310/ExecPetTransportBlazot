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

        public Owner petowner { get; set; }
        public Trip trip { get; set; }

         
    }

}
