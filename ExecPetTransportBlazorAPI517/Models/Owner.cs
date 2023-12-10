using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExecPetTransportBlazorAPI517.Models
{
    public class Owner
    {
        public int OwnerId { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CellNumber { get; set; }
        public string Instructions { get; set; }
        public Cat cat { get; set; }
        public Dog dog { get; set; }
        public Quote quote { get; set; }

        public int quoteId { get; set; }
    }

}

/* // Principal (parent)
public class Blog
{
    public int Id { get; set; }
    public BlogHeader Header { get; set; } // Reference navigation to dependent
}


*/