using AutoMapper;
using ExecPetTransportBlazorAPI517.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExecPetTransportBlazor.Models
{
    public class QuoteProfile : Profile
    {
        public QuoteProfile()
        {
            CreateMap<Quote, QuoteModel>();
            CreateMap<QuoteModel, Quote>();
        }
    }
}
