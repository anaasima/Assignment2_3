#pragma checksum "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42ee1c4ee970ed27616cc1bc4286e43dc491a446"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment_2.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\_Imports.razor"
using Assignment_2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\_Imports.razor"
using Assignment_2.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "﻿");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.AddMarkupContent(4, "<a class=\"navbar-brand\" href>Assignment1</a>\n    ");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "navbar-toggler");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(8, "\n        <span class=\"navbar-toggler-icon\"></span>\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n\n");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", 
#nullable restore
#line 8 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(14, "\n    ");
            __builder.OpenElement(15, "ul");
            __builder.AddAttribute(16, "class", "nav flex-column");
            __builder.AddMarkupContent(17, "\n        ");
            __builder.OpenElement(18, "li");
            __builder.AddAttribute(19, "class", "nav-item px-3");
            __builder.AddMarkupContent(20, "\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(21);
            __builder.AddAttribute(22, "class", "nav-link");
            __builder.AddAttribute(23, "href", "");
            __builder.AddAttribute(24, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(26, "\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n        ");
            __builder.OpenElement(29, "li");
            __builder.AddAttribute(30, "class", "nav-item px-3");
            __builder.AddMarkupContent(31, "\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(32);
            __builder.AddAttribute(33, "class", "nav-link");
            __builder.AddAttribute(34, "href", "ViewAdults");
            __builder.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(36, "\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> View\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(37, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(39);
            __builder.AddAttribute(40, "Policy", "SecurityLevel1");
            __builder.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(42, "\n            ");
                __builder2.OpenElement(43, "li");
                __builder2.AddAttribute(44, "class", "nav-item px-3");
                __builder2.AddMarkupContent(45, "\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(46);
                __builder2.AddAttribute(47, "class", "nav-link");
                __builder2.AddAttribute(48, "href", "AddAdult");
                __builder2.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(50, "\n                    <span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Add\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(53, "\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(54);
            __builder.AddAttribute(55, "Policy", "SecurityLevel1");
            __builder.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(57, "\n        ");
                __builder2.OpenElement(58, "li");
                __builder2.AddAttribute(59, "class", "nav-item px-3");
                __builder2.AddMarkupContent(60, "\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(61);
                __builder2.AddAttribute(62, "class", "nav-link");
                __builder2.AddAttribute(63, "href", "EditAdult");
                __builder2.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(65, "\n                <span class=\"oi oi-brush\" aria-hidden=\"true\"></span> Edit\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(66, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(68, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
