#pragma checksum "E:\New folder\progetund\EmployeeManagementModels\EmployeeManagment.Web\Pages\EmployeeList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5531ebee1b02998665fa069eb40bc952f98b012"
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
#line 1 "E:\New folder\progetund\EmployeeManagementModels\EmployeeManagment.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\New folder\progetund\EmployeeManagementModels\EmployeeManagment.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\New folder\progetund\EmployeeManagementModels\EmployeeManagment.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\New folder\progetund\EmployeeManagementModels\EmployeeManagment.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\New folder\progetund\EmployeeManagementModels\EmployeeManagment.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\New folder\progetund\EmployeeManagementModels\EmployeeManagment.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\New folder\progetund\EmployeeManagementModels\EmployeeManagment.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\New folder\progetund\EmployeeManagementModels\EmployeeManagment.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\New folder\progetund\EmployeeManagementModels\EmployeeManagment.Web\_Imports.razor"
using EmployeeManagment.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\New folder\progetund\EmployeeManagementModels\EmployeeManagment.Web\_Imports.razor"
using EmployeeManagment.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\New folder\progetund\EmployeeManagementModels\EmployeeManagment.Web\_Imports.razor"
using EmployeeManagementModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\New folder\progetund\EmployeeManagementModels\EmployeeManagment.Web\_Imports.razor"
using PragimTech.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\New folder\progetund\EmployeeManagementModels\EmployeeManagment.Web\Pages\EmployeeList.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class EmployeeList : EmployeeListBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "Selected Employee Count - ");
            __builder.AddContent(2, 
#nullable restore
#line 7 "E:\New folder\progetund\EmployeeManagementModels\EmployeeManagment.Web\Pages\EmployeeList.razor"
                               SelectedEmployeesCount

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, " List");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "checkbox");
            __builder.AddAttribute(7, "id", "showFooter");
            __builder.AddAttribute(8, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "E:\New folder\progetund\EmployeeManagementModels\EmployeeManagment.Web\Pages\EmployeeList.razor"
                                              ShowFooter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ShowFooter = __value, ShowFooter));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.AddMarkupContent(11, "<label for=\"showFooter\"> Show Footer</label>");
#nullable restore
#line 10 "E:\New folder\progetund\EmployeeManagementModels\EmployeeManagment.Web\Pages\EmployeeList.razor"
 if (Employees == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "<div class=\"spinner\"></div>");
#nullable restore
#line 13 "E:\New folder\progetund\EmployeeManagementModels\EmployeeManagment.Web\Pages\EmployeeList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card-deck");
#nullable restore
#line 17 "E:\New folder\progetund\EmployeeManagementModels\EmployeeManagment.Web\Pages\EmployeeList.razor"
     foreach (var employee in Employees)

    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<EmployeeManagment.Web.Pages.DisplayEmployee>(15);
            __builder.AddAttribute(16, "Employee", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<EmployeeManagementModels.Employee>(
#nullable restore
#line 20 "E:\New folder\progetund\EmployeeManagementModels\EmployeeManagment.Web\Pages\EmployeeList.razor"
                                   employee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "ShowFooter", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "E:\New folder\progetund\EmployeeManagementModels\EmployeeManagment.Web\Pages\EmployeeList.razor"
                                                         ShowFooter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "OnEmployeeSelection", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 21 "E:\New folder\progetund\EmployeeManagementModels\EmployeeManagment.Web\Pages\EmployeeList.razor"
                                              EmployeeSelectionChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(19, "OnEmployeeDeleted", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 22 "E:\New folder\progetund\EmployeeManagementModels\EmployeeManagment.Web\Pages\EmployeeList.razor"
                                            EmployeeDeleted

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 23 "E:\New folder\progetund\EmployeeManagementModels\EmployeeManagment.Web\Pages\EmployeeList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 25 "E:\New folder\progetund\EmployeeManagementModels\EmployeeManagment.Web\Pages\EmployeeList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
