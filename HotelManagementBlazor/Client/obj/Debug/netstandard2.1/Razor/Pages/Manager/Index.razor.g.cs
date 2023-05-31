#pragma checksum "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Manager\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e22e35e104c68d675012450463f2c8adf5c342c6"
// <auto-generated/>
#pragma warning disable 1591
namespace HotelManagement.Client.Pages.Manager
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\_Imports.razor"
using HotelManagement.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\_Imports.razor"
using HotelManagement.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\_Imports.razor"
using HotelManagement.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Manager\Index.razor"
using HotelManagement.Client.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Manager\Index.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Manager\Index.razor"
           [Authorize(Roles = "Manager")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/manager")]
    public partial class Index : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Manager Data</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>\r\n    <a href=\"/manager/Create\">Create</a>\r\n</p>\r\n\r\n");
#nullable restore
#line 16 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Manager\Index.razor"
 if (manList == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p> ");
#nullable restore
#line 18 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Manager\Index.razor"
                           }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.AddMarkupContent(6, "<thead>\r\n        <tr>\r\n            <th>ID</th>\r\n            <th>Name</th>\r\n            <th>Email</th>\r\n            <th>Department</th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(7, "tbody");
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 31 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Manager\Index.razor"
         foreach (var man in manList)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "tr");
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "td");
#nullable restore
#line 34 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Manager\Index.razor"
__builder.AddContent(12, man.Id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "td");
#nullable restore
#line 35 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Manager\Index.razor"
__builder.AddContent(15, man.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "td");
#nullable restore
#line 36 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Manager\Index.razor"
__builder.AddContent(18, man.Email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.OpenElement(20, "td");
#nullable restore
#line 37 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Manager\Index.razor"
__builder.AddContent(21, man.Department);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.OpenElement(23, "td");
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.OpenElement(25, "a");
            __builder.AddAttribute(26, "href", "/manager/edit/" + (
#nullable restore
#line 39 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Manager\Index.razor"
                                man.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(27, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "  |\r\n        ");
            __builder.OpenElement(29, "a");
            __builder.AddAttribute(30, "href", "/manager/delete/" + (
#nullable restore
#line 40 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Manager\Index.razor"
                                  man.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Manager\Index.razor"
     }

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
            __builder.CloseElement();
#nullable restore
#line 44 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Manager\Index.razor"
        }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Manager\Index.razor"
        IEnumerable<Manager> manList;

            protected override async Task OnInitializedAsync()
            {
                var customStateProvider = (CustomAuthenticationstateProvider)authStateProvider;
                var token = await customStateProvider.GetToken();
                if (!string.IsNullOrWhiteSpace(token))
                {
                    Http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);
                    manList = await Http.GetFromJsonAsync<IEnumerable<Manager>>("/api/manager/").ConfigureAwait(false);
                }
                else
                {
                    navManager.NavigateTo("/login");
                }

                // manList = await Http.GetFromJsonAsync<IEnumerable<Manager>>("/api/manager/").ConfigureAwait(false);
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
