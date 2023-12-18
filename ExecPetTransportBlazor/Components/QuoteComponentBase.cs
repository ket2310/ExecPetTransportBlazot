using AutoMapper;
using ExecPetTransportBlazorAPI517.Models;
using ExecPetTransportBlazor.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExecPetTransportBlazor.Components
{
    public class QuoteComponentBase : ComponentBase
    {
        //[Inject]
        //public IQuoteService QuoteService { get; set; }
        public Quote Quote { get; set; } = new Quote();
       // public QuoteModel quoteModel { get; set; } = new QuoteModel();

        [Inject]
        public IClientTravelTypeRepository TravelTypeService { get; set; }
     //   public List<TravelType> TravelTypes { get; set; } = new List<TravelType>();
        public string TravelTypeId { get; set; }
        protected async override Task OnInitializedAsync()
        {
            //TravelTypes = (await TravelTypeService.LoadTraveltypes()).ToList();
            //Quote.petowner = new Owner();
            //Quote.trip = new Trip();
            //Mapper.Map(quoteModel, Quote);
        }
        [Inject]
        public IMapper Mapper { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected async Task HandleValidSubmit()
        {
        //    Mapper.Map(quoteModel, Quote);

            Quote result = null;

            if (Quote.QuoteId != 0)
            {
               // result = await QuoteService.UpdateQuote(Quote);
            }
            else
            {
             //   await QuoteService.CreateQuote(Quote);
            }
            if (result != null)
            {
                NavigationManager.NavigateTo("/");
            }
        }
    }
}
