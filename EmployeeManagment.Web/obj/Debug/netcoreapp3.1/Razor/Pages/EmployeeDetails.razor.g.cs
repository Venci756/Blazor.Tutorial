#pragma checksum "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\EmployeeDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b1ece671ec86d7e8c2559bcce5bef177fcd3cc3"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeedetails/{id}")]
    public partial class EmployeeDetails : EmployeeDetailsBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\EmployeeDetails.razor"
 if (Employee == null )
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "    <div class=\"spinner\"></div>\r\n");
#nullable restore
#line 7 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\EmployeeDetails.razor"
}
else{ 

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row justify-content-center m-3");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-sm-8");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card");
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-header");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "h1");
            __builder.AddContent(15, 
#nullable restore
#line 13 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\EmployeeDetails.razor"
                         Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(16, " ");
            __builder.AddContent(17, 
#nullable restore
#line 13 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\EmployeeDetails.razor"
                                             Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(18, " ");
            __builder.AddContent(19, 
#nullable restore
#line 13 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\EmployeeDetails.razor"
                                                                Coordinates

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "card-body text-center");
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "img");
            __builder.AddAttribute(26, "class", "card-img-top");
            __builder.AddAttribute(27, "src", 
#nullable restore
#line 16 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\EmployeeDetails.razor"
                                                    Employee.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(28, "onmousemove", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\EmployeeDetails.razor"
                                                                                       e=>Coordinates = $"X = {e.ClientX} Y = {e.ClientY}"

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                \r\n                    ");
            __builder.OpenElement(30, "h4");
            __builder.AddContent(31, "Employee ID: ");
            __builder.AddContent(32, 
#nullable restore
#line 18 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\EmployeeDetails.razor"
                                      Employee.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenElement(34, "h4");
            __builder.AddContent(35, "Email: ");
            __builder.AddContent(36, 
#nullable restore
#line 19 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\EmployeeDetails.razor"
                                Employee.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "h4");
            __builder.AddContent(39, "Department: ");
            __builder.AddContent(40, 
#nullable restore
#line 20 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\EmployeeDetails.razor"
                                      Employee.Department == null ? "N/A" : Employee.Department.DepartmentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "class", "btn btn-primary");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\EmployeeDetails.razor"
                                                              Button_Click

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(45, 
#nullable restore
#line 21 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\EmployeeDetails.razor"
                                                                            ButtonText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "card-footer" + " text-center" + " " + (
#nullable restore
#line 23 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\EmployeeDetails.razor"
                                                     CssClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.AddMarkupContent(51, "<a href=\"/\" class=\"btn btn-primary\">Back</a>\r\n                    ");
            __builder.OpenElement(52, "a");
            __builder.AddAttribute(53, "href", 
#nullable restore
#line 25 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\EmployeeDetails.razor"
                               $"/editemployee/{Employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(54, "class", "btn btn-primary");
            __builder.AddContent(55, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.AddMarkupContent(57, "<a href=\"#\" class=\"btn btn-primary\">Delete</a>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n");
#nullable restore
#line 32 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\EmployeeDetails.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
