#pragma checksum "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25c8a9c2ed6d2b570e2401e421104faa246c0698"
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
#line 6 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\Login.razor"
using HotelManagement.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\Login.razor"
using HotelManagement.Client.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\Login.razor"
using System.Net;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-lg-4 offset-lg-4 pt-4 pb-4 border");
            __builder.AddMarkupContent(5, "\n        ");
            __builder.AddMarkupContent(6, "<div class=\"mb-3 text-center\">\n            <h3>Login</h3>\n        </div>\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "mb-3");
            __builder.AddMarkupContent(9, "\n            ");
            __builder.AddMarkupContent(10, "<label>UserName</label>\n            ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "class", "form-control");
            __builder.AddAttribute(13, "placeholder", "UserName");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\Login.razor"
                          loginRequest.Username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => loginRequest.Username = __value, loginRequest.Username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "mb-3");
            __builder.AddMarkupContent(20, "\n            ");
            __builder.AddMarkupContent(21, "<label>Password</label>\n            ");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "type", "password");
            __builder.AddAttribute(24, "class", "form-control");
            __builder.AddAttribute(25, "placeholder", "Password");
            __builder.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\Login.razor"
                          loginRequest.Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => loginRequest.Password = __value, loginRequest.Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n        ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "mb-3 d-grid gap-2");
            __builder.AddMarkupContent(32, "\n            ");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\Login.razor"
                              Authenticate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "class", "btn btn-primary");
            __builder.AddContent(36, "Login");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\Login.razor"
       
    private LoginRequest loginRequest = new LoginRequest();

    private async Task Authenticate()
    {
        var loginResponse = await httpClient.PostAsJsonAsync<LoginRequest>("/api/Account/Login", loginRequest);
        if(loginResponse.IsSuccessStatusCode)
        {
            var userSession = await loginResponse.Content.ReadFromJsonAsync<UserSession>();
            var customStateProvider = (CustomAuthenticationstateProvider)authStateProvider;
            await customStateProvider.UpdateAuthenticationState(userSession);
            navManager.NavigateTo("/", true);
        }
        else if(loginResponse.StatusCode == HttpStatusCode.Unauthorized)
        {
            await js.InvokeVoidAsync("alert", "Invalid UserName and Password");
            return;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591