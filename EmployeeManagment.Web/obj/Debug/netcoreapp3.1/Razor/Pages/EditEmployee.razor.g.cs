#pragma checksum "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\EditEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff5d5e7bc49ba7888bd942b49f3124285869ef4f"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/editemployee/{id}")]
    public partial class EditEmployee : EditEmployeeBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 4 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\EditEmployee.razor"
                  Employee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.AddMarkupContent(6, "<h3>Edit Employee</h3>\r\n    <hr>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group row");
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.AddMarkupContent(12, "<label for=\"firstName\" class=\"col-sm-2 col-form-label\">\r\n            First Name\r\n        </label>\r\n        ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "col-sm-10");
                __builder2.AddMarkupContent(15, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "id", "firstName");
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "placeholder", "First Name");
                __builder2.AddAttribute(20, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\EditEmployee.razor"
                                    Employee.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.FirstName = __value, Employee.FirstName))));
                __builder2.AddAttribute(22, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n            ");
                __Blazor.EmployeeManagment.Web.Pages.EditEmployee.TypeInference.CreateValidationMessage_0(__builder2, 24, 25, 
#nullable restore
#line 16 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\EditEmployee.razor"
                                      ()=>Employee.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n    ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group row");
                __builder2.AddMarkupContent(31, "\r\n        ");
                __builder2.AddMarkupContent(32, "<label for=\"lastName\" class=\"col-sm-2 col-form-label\">\r\n            Last Name\r\n        </label>\r\n        ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "col-sm-10");
                __builder2.AddMarkupContent(35, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(36);
                __builder2.AddAttribute(37, "id", "lastName");
                __builder2.AddAttribute(38, "class", "form-control");
                __builder2.AddAttribute(39, "placeholder", "Last Name");
                __builder2.AddAttribute(40, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\EditEmployee.razor"
                                    Employee.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.LastName = __value, Employee.LastName))));
                __builder2.AddAttribute(42, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\r\n            ");
                __Blazor.EmployeeManagment.Web.Pages.EditEmployee.TypeInference.CreateValidationMessage_1(__builder2, 44, 45, 
#nullable restore
#line 26 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\EditEmployee.razor"
                                      ()=>Employee.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(46, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n    ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "form-group row");
                __builder2.AddMarkupContent(51, "\r\n        ");
                __builder2.AddMarkupContent(52, "<label for=\"email\" class=\"col-sm-2 col-form-label\">\r\n            Email\r\n        </label>\r\n        ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "col-sm-10");
                __builder2.AddMarkupContent(55, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(56);
                __builder2.AddAttribute(57, "id", "email");
                __builder2.AddAttribute(58, "class", "form-control");
                __builder2.AddAttribute(59, "placeholder", "Email");
                __builder2.AddAttribute(60, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\EditEmployee.razor"
                                    Employee.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.Email = __value, Employee.Email))));
                __builder2.AddAttribute(62, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(63, "\r\n            ");
                __Blazor.EmployeeManagment.Web.Pages.EditEmployee.TypeInference.CreateValidationMessage_2(__builder2, 64, 65, 
#nullable restore
#line 36 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\EditEmployee.razor"
                                      ()=>Employee.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(66, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n    ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "form-group row");
                __builder2.AddMarkupContent(71, "\r\n        ");
                __builder2.AddMarkupContent(72, "<label for=\"department\" class=\"col-sm-2 col-form-label\">\r\n            Department\r\n        </label>\r\n        ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "col-sm-10");
                __builder2.AddMarkupContent(75, "\r\n            ");
                __Blazor.EmployeeManagment.Web.Pages.EditEmployee.TypeInference.CreateCustomInputSelect_3(__builder2, 76, 77, "department", 78, "form-control", 79, 
#nullable restore
#line 44 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\EditEmployee.razor"
                                                            Employee.DepartmentId

#line default
#line hidden
#nullable disable
                , 80, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.DepartmentId = __value, Employee.DepartmentId)), 81, () => Employee.DepartmentId, 82, (__builder3) => {
                    __builder3.AddMarkupContent(83, "\r\n");
#nullable restore
#line 45 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\EditEmployee.razor"
                 foreach (var dept in Departments)
                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(84, "                    ");
                    __builder3.OpenElement(85, "option");
                    __builder3.AddAttribute(86, "value", 
#nullable restore
#line 47 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\EditEmployee.razor"
                                    dept.DepartmentId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(87, 
#nullable restore
#line 47 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\EditEmployee.razor"
                                                        dept.DepartmentName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(88, "\r\n");
#nullable restore
#line 48 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\EditEmployee.razor"
                }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(89, "            ");
                }
                );
                __builder2.AddMarkupContent(90, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n    ");
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "form-group row");
                __builder2.AddMarkupContent(95, "\r\n        ");
                __builder2.AddMarkupContent(96, "<label for=\"department\" class=\"col-sm-2 col-form-label\">\r\n            Gender\r\n        </label>\r\n        ");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "col-sm-10");
                __builder2.AddMarkupContent(99, "\r\n            ");
                __Blazor.EmployeeManagment.Web.Pages.EditEmployee.TypeInference.CreateInputSelect_4(__builder2, 100, 101, "gender", 102, "form-control", 103, 
#nullable restore
#line 57 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\EditEmployee.razor"
                                                  Employee.Gender

#line default
#line hidden
#nullable disable
                , 104, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.Gender = __value, Employee.Gender)), 105, () => Employee.Gender, 106, (__builder3) => {
                    __builder3.AddMarkupContent(107, "\r\n");
#nullable restore
#line 58 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\EditEmployee.razor"
                 foreach (var gender in Enum.GetValues(typeof(Gender)))
                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(108, "                    ");
                    __builder3.OpenElement(109, "option");
                    __builder3.AddAttribute(110, "value", 
#nullable restore
#line 60 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\EditEmployee.razor"
                                    gender

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(111, 
#nullable restore
#line 60 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\EditEmployee.razor"
                                             gender

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(112, "\r\n");
#nullable restore
#line 61 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\EditEmployee.razor"
                }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(113, "            ");
                }
                );
                __builder2.AddMarkupContent(114, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\r\n    ");
                __builder2.OpenElement(117, "div");
                __builder2.AddAttribute(118, "class", "form-group row");
                __builder2.AddMarkupContent(119, "\r\n        ");
                __builder2.AddMarkupContent(120, "<label for=\"dateOfBirth\" class=\"col-sm-2 col-form-label\">\r\n            Date Of Birth\r\n        </label>\r\n        ");
                __builder2.OpenElement(121, "div");
                __builder2.AddAttribute(122, "class", "col-sm-10");
                __builder2.AddMarkupContent(123, "\r\n            ");
                __Blazor.EmployeeManagment.Web.Pages.EditEmployee.TypeInference.CreateInputDate_5(__builder2, 124, 125, 
#nullable restore
#line 70 "C:\MyJavaProjects\Blazor\BlazorTutorial\EmployeeManagment.Web\Pages\EditEmployee.razor"
                                    Employee.DateOfBirth

#line default
#line hidden
#nullable disable
                , 126, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.DateOfBirth = __value, Employee.DateOfBirth)), 127, () => Employee.DateOfBirth);
                __builder2.AddMarkupContent(128, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.EmployeeManagment.Web.Pages.EditEmployee
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateCustomInputSelect_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Venci.Components.CustomInputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
