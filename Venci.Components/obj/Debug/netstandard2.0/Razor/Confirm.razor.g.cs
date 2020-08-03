#pragma checksum "C:\MyJavaProjects\Blazor\BlazorTutorial\Venci.Components\Confirm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3502a2b83faec5f29707edb35096b0ed95679f99"
// <auto-generated/>
#pragma warning disable 1591
namespace Venci.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\MyJavaProjects\Blazor\BlazorTutorial\Venci.Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
    public partial class Confirm : ConfirmBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 3 "C:\MyJavaProjects\Blazor\BlazorTutorial\Venci.Components\Confirm.razor"
 if (ShowConfirmation)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "modal fade show d-block");
            __builder.AddAttribute(3, "id", "exampleModal");
            __builder.AddAttribute(4, "tabindex", "-1");
            __builder.AddAttribute(5, "role", "dialog");
            __builder.AddAttribute(6, "aria-labelledby", "exampleModalLabel");
            __builder.AddAttribute(7, "aria-hidden", "true");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "modal-dialog");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "modal-content");
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "modal-header");
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "h5");
            __builder.AddAttribute(19, "class", "modal-title");
            __builder.AddAttribute(20, "id", "exampleModalLabel");
            __builder.AddContent(21, 
#line 9 "C:\MyJavaProjects\Blazor\BlazorTutorial\Venci.Components\Confirm.razor"
                                                                    ConfirmationTitle

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "type", "button");
            __builder.AddAttribute(25, "class", "close");
            __builder.AddAttribute(26, "data-dismiss", "modal");
            __builder.AddAttribute(27, "aria-label", "Close");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 11 "C:\MyJavaProjects\Blazor\BlazorTutorial\Venci.Components\Confirm.razor"
                                      ()=>OnConfirmationChange(false)

#line default
#line hidden
            ));
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.AddMarkupContent(30, "<span aria-hidden=\"true\">&times;</span>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "modal-body");
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.AddContent(36, 
#line 16 "C:\MyJavaProjects\Blazor\BlazorTutorial\Venci.Components\Confirm.razor"
                     ConfirmationMessage

#line default
#line hidden
            );
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "modal-footer");
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "type", "button");
            __builder.AddAttribute(44, "class", "btn btn-secondary");
            __builder.AddAttribute(45, "data-dismiss", "modal");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 20 "C:\MyJavaProjects\Blazor\BlazorTutorial\Venci.Components\Confirm.razor"
                                      ()=>OnConfirmationChange(false)

#line default
#line hidden
            ));
            __builder.AddContent(47, 
#line 20 "C:\MyJavaProjects\Blazor\BlazorTutorial\Venci.Components\Confirm.razor"
                                                                        ConfirmationButtonCancel

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                    ");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "type", "button");
            __builder.AddAttribute(51, "class", "btn btn-primary");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 22 "C:\MyJavaProjects\Blazor\BlazorTutorial\Venci.Components\Confirm.razor"
                                      ()=>OnConfirmationChange(true)

#line default
#line hidden
            ));
            __builder.AddContent(53, 
#line 22 "C:\MyJavaProjects\Blazor\BlazorTutorial\Venci.Components\Confirm.razor"
                                                                       ConfirmationButtonConfirm

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
#line 27 "C:\MyJavaProjects\Blazor\BlazorTutorial\Venci.Components\Confirm.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591