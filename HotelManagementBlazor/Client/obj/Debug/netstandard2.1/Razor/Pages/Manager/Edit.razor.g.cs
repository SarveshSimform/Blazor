#pragma checksum "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\Manager\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "026960827581b829be255421bf7e3d5f23f8a95b"
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
#nullable restore
#line 2 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\Manager\Edit.razor"
using HotelManagement.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/manager/Edit/{Id:int}")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Edit Person</h2>\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-6");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-group");
            __builder.AddMarkupContent(9, "\n            ");
            __builder.AddMarkupContent(10, "<label for=\"FirstName\"> Name *</label>\n            ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "form", "FirstName");
            __builder.AddAttribute(13, "class", "form-control");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\Manager\Edit.razor"
                                                                 man.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => man.Name = __value, man.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col-md-6");
            __builder.AddMarkupContent(21, "\n        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "form-group");
            __builder.AddMarkupContent(24, "\n            ");
            __builder.AddMarkupContent(25, "<label for=\"Email\"> Email *</label>\n            ");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "form", "Email");
            __builder.AddAttribute(28, "class", "form-control");
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\Manager\Edit.razor"
                                                             man.Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => man.Email = __value, man.Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "row");
            __builder.AddMarkupContent(37, "\n    ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "col-md-4");
            __builder.AddMarkupContent(40, "\n        ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "form-group");
            __builder.AddMarkupContent(43, "\n            ");
            __builder.OpenElement(44, "input");
            __builder.AddAttribute(45, "type", "button");
            __builder.AddAttribute(46, "class", "btn btn-primary");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\Manager\Edit.razor"
                                                                    Save

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n            ");
            __builder.OpenElement(50, "input");
            __builder.AddAttribute(51, "type", "button");
            __builder.AddAttribute(52, "class", "btn");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\Manager\Edit.razor"
                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\Manager\Edit.razor"
        [Parameter]
            public int Id { get; set; }
            Manager man = new Manager();
            protected override async Task OnInitializedAsync()
            {
                man = await Http.GetFromJsonAsync<Manager>("api/manager/" + Id);
            }
            protected async Task Save()
            {
                var response = await Http.PutAsJsonAsync("api/manager/" + Id, @man);
                
                    await JsRuntime.InvokeVoidAsync("alert", "Updated Successfully!");
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