#pragma checksum "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Manager\Delete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "124bcb37d36a4c251da51623e0aec158032ef7e1"
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
#line 2 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Manager\Delete.razor"
using HotelManagement.Shared;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/manager/Delete/{Id:int}")]
    public partial class Delete : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Delete Person</h2>\r\n");
#nullable restore
#line 7 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Manager\Delete.razor"
 if (man != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Are you sure you want to delete this person with Name: ");
            __builder.OpenElement(3, "b");
#nullable restore
#line 9 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Manager\Delete.razor"
__builder.AddContent(4, man.Name);

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, " + ");
#nullable restore
#line 9 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Manager\Delete.razor"
__builder.AddContent(6, man.Email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n                ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row");
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "table");
            __builder.AddAttribute(12, "class", "table");
            __builder.AddMarkupContent(13, "\r\n                        ");
            __builder.OpenElement(14, "tr");
            __builder.AddMarkupContent(15, "\r\n                            ");
            __builder.AddMarkupContent(16, "<td>Name</td>\r\n                            ");
            __builder.OpenElement(17, "td");
#nullable restore
#line 14 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Manager\Delete.razor"
__builder.AddContent(18, man.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.OpenElement(21, "tr");
            __builder.AddMarkupContent(22, "\r\n                            ");
            __builder.AddMarkupContent(23, "<td>Email</td>\r\n                            ");
            __builder.OpenElement(24, "td");
#nullable restore
#line 18 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Manager\Delete.razor"
__builder.AddContent(25, man.Email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.OpenElement(28, "tr");
            __builder.AddMarkupContent(29, "\r\n                            ");
            __builder.AddMarkupContent(30, "<td>Specialisation</td>\r\n                            ");
            __builder.OpenElement(31, "td");
#nullable restore
#line 22 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Manager\Delete.razor"
__builder.AddContent(32, man.Department);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.CloseElement();
#nullable restore
#line 26 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Manager\Delete.razor"
                      }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "row");
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "col-md-4");
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "form-group");
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "type", "button");
            __builder.AddAttribute(47, "class", "btn btn-primary");
            __builder.AddAttribute(48, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Manager\Delete.razor"
                                                                    Deleted

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "value", "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.OpenElement(51, "input");
            __builder.AddAttribute(52, "type", "button");
            __builder.AddAttribute(53, "class", "btn");
            __builder.AddAttribute(54, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Manager\Delete.razor"
                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Manager\Delete.razor"
        [Parameter]
            public int Id { get; set; }
            Manager man = new Manager();
            protected override async Task OnInitializedAsync()
            {
                man = await Http.GetFromJsonAsync<Manager>("api/manager/" + Id);
            }
            protected async Task Deleted()
            {
                var response = await Http.DeleteAsync("api/manager/" + Id);
                
                    await JsRuntime.InvokeVoidAsync("alert", "Deleted Successfully!");
                    NavigationManager.NavigateTo("/Manager");
                
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
