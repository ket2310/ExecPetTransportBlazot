using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExecPetTransportBlazorAPI517.Models
{
    public class QuoteModel
    {
        public Owner petowner { get; set; }
        public Trip trip { get; set; }
    }
}
