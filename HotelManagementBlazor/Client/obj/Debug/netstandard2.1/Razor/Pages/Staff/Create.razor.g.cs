#pragma checksum "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\Staff\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c08328bad28869046efe55f0769387c60b9e88bf"
// <auto-generated/>
#pragma warning disable 1591
namespace HotelManagement.Client.Pages.Staff
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/staff/create")]
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
#line 16 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\Staff\Create.razor"
                                                               staff.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => staff.Name = __value, staff.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "form-group");
            __builder.AddMarkupContent(22, "\n                ");
            __builder.AddMarkupContent(23, "<label asp-for=\"JoiningDate\" class=\"control-label\">Joining Date</label>\n                ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "asp-for", "JoiningDate");
            __builder.AddAttribute(26, "class", "form-control");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\Staff\Create.razor"
                                                                          staff.JoiningDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => staff.JoiningDate = __value, staff.JoiningDate));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "form-group");
            __builder.AddMarkupContent(33, "\n                ");
            __builder.AddMarkupContent(34, "<label asp-for=\"BirthDate\" class=\"control-label\">BirthDate</label>\n                ");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "asp-for", "BirthDate");
            __builder.AddAttribute(37, "class", "form-control");
            __builder.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\Staff\Create.razor"
                                                                        staff.BirthDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => staff.BirthDate = __value, staff.BirthDate));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "form-group");
            __builder.AddMarkupContent(44, "\n                ");
            __builder.AddMarkupContent(45, "<label asp-for=\"ShiftTime\" class=\"control-label\">ShiftTime</label>\n                ");
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "asp-for", "ShiftTime");
            __builder.AddAttribute(48, "class", "form-control");
            __builder.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\Staff\Create.razor"
                                                                       staff.ShiftTime

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => staff.ShiftTime = __value, staff.ShiftTime));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n            ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "row");
            __builder.AddMarkupContent(55, "\n                ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "col-md-4");
            __builder.AddMarkupContent(58, "\n                    ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "form-group");
            __builder.AddMarkupContent(61, "\n                        ");
            __builder.OpenElement(62, "input");
            __builder.AddAttribute(63, "type", "button");
            __builder.AddAttribute(64, "class", "btn btn-primary");
            __builder.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\Staff\Create.razor"
                                                                                Save

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\n                        ");
            __builder.OpenElement(68, "input");
            __builder.AddAttribute(69, "type", "button");
            __builder.AddAttribute(70, "class", "btn");
            __builder.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\Staff\Create.razor"
                                                                    Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\sarvesh\Downloads\Blazor-CRUD-Hospital-system--main\Blazor-CRUD-Hospital-system--main\Client\Pages\Staff\Create.razor"
        Staff staff = new Staff();
            protected override async Task OnInitializedAsync()
            {
            }
            protected async Task Save()
            {
                var response = await Http.PostAsJsonAsync("api/staff", staff);
               
                    await JsRuntime.InvokeVoidAsync("alert", "Saved Successfully!");
                    NavigationManager.NavigateTo("/staff");
                
            }
            void Cancel()
            {
                NavigationManager.NavigateTo("/staff");
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