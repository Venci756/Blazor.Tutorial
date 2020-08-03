#pragma checksum "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\DataBindingDemo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83c1bf5e19930860f31fc0d5d9a206dc7f2d01bb"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeeManagment.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\_Imports.razor"
using EmployeeManagment.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\_Imports.razor"
using EmployeeManagment.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\_Imports.razor"
using Venci.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\_Imports.razor"
using EmployeeManagement.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/databindingdemo")]
    public partial class DataBindingDemo : DataBindingDemoBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Data Binding Demo</h1>\r\n<hr>\r\n");
            __builder.AddMarkupContent(1, "<h3>One Way Data Binding</h3>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "b");
            __builder.AddContent(5, "Name : ");
            __builder.AddContent(6, 
#nullable restore
#line 9 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\DataBindingDemo.razor"
               Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "div");
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.AddMarkupContent(11, "<b>Name with salutation:</b> ");
            __builder.AddContent(12, 
#nullable restore
#line 12 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\DataBindingDemo.razor"
                                   Gender=="Male" ? $"Mr. {Name}" : $"Miss. {Name}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(13, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.OpenElement(15, "div");
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "b");
            __builder.AddContent(18, "Name :");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "value", 
#nullable restore
#line 15 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\DataBindingDemo.razor"
                            Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, " \r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n<hr>\r\n");
            __builder.AddMarkupContent(23, "<h3>Two Way Data Binding</h3>\r\n\r\n");
            __builder.OpenElement(24, "div");
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.OpenElement(26, "b");
            __builder.AddContent(27, "Name :");
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "value", 
#nullable restore
#line 21 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\DataBindingDemo.razor"
                            Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 21 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\DataBindingDemo.razor"
                                               e => { Name = e.Value.ToString();}

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, " \r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
            __builder.OpenElement(33, "div");
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.OpenElement(35, "b");
            __builder.AddContent(36, "Name :");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\DataBindingDemo.razor"
                           Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Name = __value, Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, " \r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
            __builder.OpenElement(42, "div");
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.OpenElement(44, "b");
            __builder.AddContent(45, "Name :");
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\DataBindingDemo.razor"
                           Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Name = __value, Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, " \r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n\r\n");
            __builder.OpenElement(51, "div");
            __builder.AddMarkupContent(52, "\r\n    ");
            __builder.AddMarkupContent(53, "<b>Colour :</b> ");
            __builder.OpenElement(54, "input");
            __builder.AddAttribute(55, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\DataBindingDemo.razor"
                                  Colour

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Colour = __value, Colour));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "style", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\DataBindingDemo.razor"
                  Colour

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Colour = __value, Colour));
            __builder.SetUpdatesAttributeName("style");
            __builder.AddMarkupContent(62, "\r\n    ");
            __builder.AddMarkupContent(63, "<h3>The background colour of this text changes</h3>\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591