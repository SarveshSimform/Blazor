#pragma checksum "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Guest\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "274eda9f6298226d39b85494612c48e46d2fafa3"
// <auto-generated/>
#pragma warning disable 1591
namespace HotelManagement.Client.Pages.Guest
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
#line 2 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Guest\Edit.razor"
using HotelManagement.Shared;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/Guest/Edit/{Id:int}")]
    public partial class Edit : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Edit Person</h2>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-6");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-group");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, "<label for=\"FirstName\"> First Name *</label>\r\n            ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "form", "FirstName");
            __builder.AddAttribute(13, "class", "form-control");
            __builder.AddAttribute(14, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Guest\Edit.razor"
                                                                 guest.FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => guest.FirstName = __value, guest.FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col-md-6");
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "form-group");
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.AddMarkupContent(25, "<label for=\"LastName\"> Last Name *</label>\r\n            ");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "form", "LastName");
            __builder.AddAttribute(28, "class", "form-control");
            __builder.AddAttribute(29, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Guest\Edit.razor"
                                                                guest.LastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => guest.LastName = __value, guest.LastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "col-md-6");
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "form-group");
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.AddMarkupContent(40, "<label for=\"BirthDate\"> Birth Date *</label>\r\n            ");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "form", "BirthDate");
            __builder.AddAttribute(43, "class", "form-control");
            __builder.AddAttribute(44, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Guest\Edit.razor"
                                                                 guest.BirthDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => guest.BirthDate = __value, guest.BirthDate));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n\r\n    ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "col-md-6");
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "form-group");
            __builder.AddMarkupContent(54, "\r\n            ");
            __builder.AddMarkupContent(55, "<label for=\"Mobile\"> Mobile *</label>\r\n            ");
            __builder.OpenElement(56, "input");
            __builder.AddAttribute(57, "form", "Mobile");
            __builder.AddAttribute(58, "class", "form-control");
            __builder.AddAttribute(59, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Guest\Edit.razor"
                                                              guest.Mobile

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => guest.Mobile = __value, guest.Mobile));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n    ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "col-md-6");
            __builder.AddMarkupContent(66, "\r\n        ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "form-group");
            __builder.AddMarkupContent(69, "\r\n            ");
            __builder.AddMarkupContent(70, "<label for=\"Address\"> Address *</label>\r\n            ");
            __builder.OpenElement(71, "input");
            __builder.AddAttribute(72, "form", "Address");
            __builder.AddAttribute(73, "class", "form-control");
            __builder.AddAttribute(74, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Guest\Edit.razor"
                                                               guest.Address

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(75, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => guest.Address = __value, guest.Address));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "row");
            __builder.AddMarkupContent(82, "\r\n    ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "col-md-4");
            __builder.AddMarkupContent(85, "\r\n        ");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "form-group");
            __builder.AddMarkupContent(88, "\r\n            ");
            __builder.OpenElement(89, "input");
            __builder.AddAttribute(90, "type", "button");
            __builder.AddAttribute(91, "class", "btn btn-primary");
            __builder.AddAttribute(92, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Guest\Edit.razor"
                                                                    Save

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(93, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n            ");
            __builder.OpenElement(95, "input");
            __builder.AddAttribute(96, "type", "button");
            __builder.AddAttribute(97, "class", "btn");
            __builder.AddAttribute(98, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Guest\Edit.razor"
                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(99, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\sarvesh\Documents\Blazor\HotelManagementBlazor\Client\Pages\Guest\Edit.razor"
        [Parameter]
            public int Id { get; set; }
            Guest guest = new Guest();
            protected override async Task OnInitializedAsync()
            {
                guest = await Http.GetFromJsonAsync<Guest>("api/guest/" + Id);
            }
            protected async Task Save()
            {
                var response = await Http.PutAsJsonAsync("api/guest/" + Id, guest);
                
                    await JsRuntime.InvokeVoidAsync("alert", "Updated Successfully!");
                    NavigationManager.NavigateTo("/Guest");
                
            }
            void Cancel()
            {
                NavigationManager.NavigateTo("/Guest");
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
