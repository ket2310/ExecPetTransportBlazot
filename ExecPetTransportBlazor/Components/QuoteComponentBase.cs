using AutoMapper;
using ExecPetTransportBlazor.Services;
using ExecPetTransportBlazorAPI517.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExecPetTransportBlazor.Components
{
    public class QuoteComponentBase : ComponentBase
    {
        [Inject]
        public IQuoteService QuoteService{ get; set; }

        private Quote Quote { get; set; } = new Quote();

        public QuoteModel quoteModel { get; set; } = new QuoteModel();

        [Parameter]
        public string Id { get; set; }

        [Inject]
        public IMapper Mapper { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        //protected async override Task OnInitializedAsync()
        //{
        //    int.TryParse(Id, out int QuoteId);

        //    if (QuoteId != 0)
        //    {
        //        Quote = await QuoteService.GetQuote(int.Parse(Id));
        //    }
        //    else
        //    {
        //        Quote = new Quote
        //        {
        //            DepartmentId = 1,
        //            DateOfBrith = DateTime.Now,
        //            PhotoPath = "images/nophoto.jpg"
        //        };
        //    }

        //    Departments = (await DepartmentService.GetDepartments()).ToList();
        //    Mapper.Map(Quote, QuoteModel);
        //}

        protected async Task HandleValidSubmit()
        {
            Mapper.Map(quoteModel, Quote);

            Quote result = null;

            if (Quote.QuoteId != 0)
            {
                //result = await QuoteService.UpdateQuote(Quote);
            }
            else
            {
               await QuoteService.CreateQuote(Quote);
            }
            if (result != null)
            {
                NavigationManager.NavigateTo("/");
            }
        }
    }
}
