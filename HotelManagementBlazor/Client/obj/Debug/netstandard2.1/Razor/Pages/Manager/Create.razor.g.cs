#pragma checksum "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\Manager\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bc818d29e6c560f5f25489b9a98d7e93c61daa9"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/manager/create")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Create</h1>\n\n<hr>\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-4");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.OpenElement(7, "form");
            __builder.AddMarkupContent(8, "\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form-group");
            __builder.AddMarkupContent(11, "\n                ");
            __builder.AddMarkupContent(12, "<label for=\"Name\" class=\"control-label\">Name</label>\n                ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "for", "Name");
            __builder.AddAttribute(15, "class", "form-control");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\Manager\Create.razor"
                                                               man.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => man.Name = __value, man.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "form-group");
            __builder.AddMarkupContent(22, "\n                ");
            __builder.AddMarkupContent(23, "<label asp-for=\"Email\" class=\"control-label\">Email</label>\n                ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "asp-for", "Email");
            __builder.AddAttribute(26, "class", "form-control");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\Manager\Create.razor"
                                                                    man.Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => man.Email = __value, man.Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "form-group");
            __builder.AddMarkupContent(33, "\n                ");
            __builder.AddMarkupContent(34, "<label asp-for=\"Location\" class=\"control-label\">Department</label>\n                ");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "asp-for", "Location");
            __builder.AddAttribute(37, "class", "form-control");
            __builder.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\Manager\Create.razor"
                                                                       man.Department

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => man.Department = __value, man.Department));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "row");
            __builder.AddMarkupContent(44, "\n                ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "col-md-4");
            __builder.AddMarkupContent(47, "\n                    ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "form-group");
            __builder.AddMarkupContent(50, "\n                        ");
            __builder.OpenElement(51, "input");
            __builder.AddAttribute(52, "type", "button");
            __builder.AddAttribute(53, "class", "btn btn-primary");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\Manager\Create.razor"
                                                                                Save

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\n                        ");
            __builder.OpenElement(57, "input");
            __builder.AddAttribute(58, "type", "button");
            __builder.AddAttribute(59, "class", "btn");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\Manager\Create.razor"
                                                                    Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\n,\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\Manager\Create.razor"
        Manager man = new Manager();
            protected override async Task OnInitializedAsync()
            {
            }
            protected async Task Save()
            {
                var response = await Http.PostAsJsonAsync("api/manager", @man);
                
               
                    await JsRuntime.InvokeVoidAsync("alert", "Saved Successfully!");
                    NavigationManager.NavigateTo("/manager");
               
            }
            void Cancel()
            {
                NavigationManager.NavigateTo("/manager");
            } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
