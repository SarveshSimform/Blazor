// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HotelManagement.Client.Pages.Staff
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
#line 5 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Staff\Index.razor"
using HotelManagement.Client.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Staff\Index.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Staff\Index.razor"
           [Authorize(Roles = "Manager, Staff")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/Staff")]
    public partial class Index : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Staff\Index.razor"
       
    Staff[] staffList;



    protected override async Task OnInitializedAsync()
    {



        var customStateProvider = (CustomAuthenticationstateProvider)authStateProvider;
        var token = await customStateProvider.GetToken();
        if (!string.IsNullOrWhiteSpace(token))
        {
            Http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);
            staffList = await Http.GetFromJsonAsync<Staff[]>("/api/staff/");
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
