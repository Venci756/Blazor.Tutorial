#pragma checksum "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\ChildComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62d082b7a14c8fe3003057f7987b747ed853480d"
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
    public partial class ChildComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "input");
            __builder.AddAttribute(1, "id", "firstName");
            __builder.AddMultipleAttributes(2, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 1 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\ChildComponent.razor"
                                   InputAttributes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "value", 
#nullable restore
#line 1 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\ChildComponent.razor"
                                                            Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 4 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\ChildComponent.razor"
 
    [Parameter]
    public Dictionary<string,object> InputAttributes { get; set; } = 
        new Dictionary<string, object>()
        {
            {"required","required"},
            {"placeholder","Child Component Placeholder"},
            {"size","100"},
            {"maxLength","15"}
        };
    [Parameter]
    public string Value { get; set; } = "Child Value";
    // [Parameter]
    // public string Required { get; set; } = "required";
    //
    // [Parameter]
    // public string MaxLength { get; set; } = "15";
    // [Parameter]
    // public string Size { get; set; } = "25";
    // [Parameter]
    // public string Placeholder { get; set; } = "Child Component Placeholder";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
