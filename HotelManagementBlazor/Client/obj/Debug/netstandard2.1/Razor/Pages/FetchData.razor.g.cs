#pragma checksum "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "016a7417e47f0ef8716bebdafaee80ba648d882a"
// <auto-generated/>
#pragma warning disable 1591
namespace HotelManagement.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\_Imports.razor"
using HotelManagement.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\_Imports.razor"
using HotelManagement.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\_Imports.razor"
using HotelManagement.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\FetchData.razor"
using HotelManagement.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\FetchData.razor"
using HotelManagement.Client.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\FetchData.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\FetchData.razor"
           [Authorize(Roles = "Doctor")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\n\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from the server.</p>\n\n");
#nullable restore
#line 15 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\n");
#nullable restore
#line 18 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\n        ");
            __builder.AddMarkupContent(8, "<thead>\n            <tr>\n                <th>Date</th>\n                <th>Temp. (C)</th>\n                <th>Temp. (F)</th>\n                <th>Summary</th>\n            </tr>\n        </thead>\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\n");
#nullable restore
#line 31 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\n                    ");
            __builder.OpenElement(14, "td");
#nullable restore
#line 34 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\FetchData.razor"
__builder.AddContent(15, forecast.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n                    ");
            __builder.OpenElement(17, "td");
#nullable restore
#line 35 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\FetchData.razor"
__builder.AddContent(18, forecast.TemperatureC);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n                    ");
            __builder.OpenElement(20, "td");
#nullable restore
#line 36 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\FetchData.razor"
__builder.AddContent(21, forecast.TemperatureF);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                    ");
            __builder.OpenElement(23, "td");
#nullable restore
#line 37 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\FetchData.razor"
__builder.AddContent(24, forecast.Summary);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n");
#nullable restore
#line 39 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n");
#nullable restore
#line 42 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        var customStateProvider = (CustomAuthenticationstateProvider)authStateProvider;
        var token = await customStateProvider.GetToken();
        if (!string.IsNullOrWhiteSpace(token))
        {
            Http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);
            forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
        }
        else
        {
            navManager.NavigateTo("/login");
        } 


    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
