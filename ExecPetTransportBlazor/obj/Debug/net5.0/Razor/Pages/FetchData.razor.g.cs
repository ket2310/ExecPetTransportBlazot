#pragma checksum "C:\Users\dablu\OneDrive\source\repos\ExecPetTransportBlazor\ExecPetTransportBlazor\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68bc96504bc09a03247410fb80637afd1a685828"
// <auto-generated/>
#pragma warning disable 1591
namespace ExecPetTransportBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\dablu\OneDrive\source\repos\ExecPetTransportBlazor\ExecPetTransportBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dablu\OneDrive\source\repos\ExecPetTransportBlazor\ExecPetTransportBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dablu\OneDrive\source\repos\ExecPetTransportBlazor\ExecPetTransportBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dablu\OneDrive\source\repos\ExecPetTransportBlazor\ExecPetTransportBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dablu\OneDrive\source\repos\ExecPetTransportBlazor\ExecPetTransportBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dablu\OneDrive\source\repos\ExecPetTransportBlazor\ExecPetTransportBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dablu\OneDrive\source\repos\ExecPetTransportBlazor\ExecPetTransportBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dablu\OneDrive\source\repos\ExecPetTransportBlazor\ExecPetTransportBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dablu\OneDrive\source\repos\ExecPetTransportBlazor\ExecPetTransportBlazor\_Imports.razor"
using ExecPetTransportBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\dablu\OneDrive\source\repos\ExecPetTransportBlazor\ExecPetTransportBlazor\_Imports.razor"
using ExecPetTransportBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dablu\OneDrive\source\repos\ExecPetTransportBlazor\ExecPetTransportBlazor\Pages\FetchData.razor"
using ExecPetTransportBlazor.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>");
#nullable restore
#line 10 "C:\Users\dablu\OneDrive\source\repos\ExecPetTransportBlazor\ExecPetTransportBlazor\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 13 "C:\Users\dablu\OneDrive\source\repos\ExecPetTransportBlazor\ExecPetTransportBlazor\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>Date</th>\r\n                <th>Temp. (C)</th>\r\n                <th>Temp. (F)</th>\r\n                <th>Summary</th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 26 "C:\Users\dablu\OneDrive\source\repos\ExecPetTransportBlazor\ExecPetTransportBlazor\Pages\FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
#nullable restore
#line 29 "C:\Users\dablu\OneDrive\source\repos\ExecPetTransportBlazor\ExecPetTransportBlazor\Pages\FetchData.razor"
__builder.AddContent(9, forecast.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
#nullable restore
#line 30 "C:\Users\dablu\OneDrive\source\repos\ExecPetTransportBlazor\ExecPetTransportBlazor\Pages\FetchData.razor"
__builder.AddContent(12, forecast.TemperatureC);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
#nullable restore
#line 31 "C:\Users\dablu\OneDrive\source\repos\ExecPetTransportBlazor\ExecPetTransportBlazor\Pages\FetchData.razor"
__builder.AddContent(15, forecast.TemperatureF);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
#nullable restore
#line 32 "C:\Users\dablu\OneDrive\source\repos\ExecPetTransportBlazor\ExecPetTransportBlazor\Pages\FetchData.razor"
__builder.AddContent(18, forecast.Summary);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "C:\Users\dablu\OneDrive\source\repos\ExecPetTransportBlazor\ExecPetTransportBlazor\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Users\dablu\OneDrive\source\repos\ExecPetTransportBlazor\ExecPetTransportBlazor\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\dablu\OneDrive\source\repos\ExecPetTransportBlazor\ExecPetTransportBlazor\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
