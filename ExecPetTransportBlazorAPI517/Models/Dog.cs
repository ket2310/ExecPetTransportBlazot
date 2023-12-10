﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExecPetTransportBlazorAPI517.Models
{
    public class Dog
    {
        public int DogId { get; set; }

        public string Breed { get; set; }

        public int Quantity { get; set; }

        public int Age { get; set; }

        public int Weight { get; set; }

        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
 
    }
}
