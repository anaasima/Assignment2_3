#pragma checksum "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b020c70a09d6a2819b1ea646b89c79a1ca3d67a"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment_2.Pages
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
#nullable restore
#line 2 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
using Assignment1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ViewAdults")]
    public partial class ViewAdults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>View adults</h3>\n\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\n    Search by adult id: ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "number");
            __builder.AddAttribute(5, "style", "width:50px");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
                                                     id

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => id = __value, id, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n\n");
            __builder.OpenElement(10, "p");
            __builder.AddMarkupContent(11, "\n    Search by first name: ");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "type", "text");
            __builder.AddAttribute(14, "style", "width:200px");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
                                                     firstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => firstName = __value, firstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n\n");
            __builder.OpenElement(19, "p");
            __builder.AddMarkupContent(20, "\n    Filter by sex:\n    ");
            __builder.OpenElement(21, "select");
            __builder.AddAttribute(22, "class", "form-control selectpicker");
            __builder.AddAttribute(23, "style", "width:100px");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
                                                      sex

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => sex = __value, sex));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(26, "\n        ");
            __builder.OpenElement(27, "option");
            __builder.AddContent(28, "Any");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n        ");
            __builder.OpenElement(30, "option");
            __builder.AddContent(31, "M");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n        ");
            __builder.OpenElement(33, "option");
            __builder.AddContent(34, "F");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n\n");
            __builder.OpenElement(38, "p");
            __builder.AddMarkupContent(39, "\n    ");
            __builder.OpenElement(40, "button");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
                      Filter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(42, " Filter ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n\n\n");
#nullable restore
#line 31 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
 if (allAdults == null) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "    ");
            __builder.AddMarkupContent(46, "<p>\n        <em>Loading...</em>\n    </p>\n");
#nullable restore
#line 35 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
} else if (!allAdults.Any()) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(47, "    ");
            __builder.AddMarkupContent(48, "<p>\n        <em>No adults in the list. Please add some.</em>\n    </p>\n");
#nullable restore
#line 39 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
} else {

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(50);
            __builder.AddAttribute(51, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(52, "\n            ");
                __builder2.OpenElement(53, "table");
                __builder2.AddAttribute(54, "class", "table");
                __builder2.AddMarkupContent(55, "\n                ");
                __builder2.AddMarkupContent(56, @"<thead>
                <tr>
                    <th>ID</th>
                    <th>First name</th>
                    <th>Last name</th>
                    <th>Job title</th>
                    <th>Hair color</th>
                    <th>Eye color</th>
                    <th>Age</th>
                    <th>Weight</th>
                    <th>Height</th>
                    <th>Sex</th>
                </tr>
                </thead>
                ");
                __builder2.OpenElement(57, "tbody");
                __builder2.AddMarkupContent(58, "\n");
#nullable restore
#line 58 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
                 foreach (var item in adultsToShow)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(59, "                    ");
                __builder2.OpenElement(60, "tr");
                __builder2.AddMarkupContent(61, "\n                        ");
                __builder2.OpenElement(62, "td");
                __builder2.AddContent(63, 
#nullable restore
#line 61 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
                             item.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\n                        ");
                __builder2.OpenElement(65, "td");
                __builder2.AddContent(66, 
#nullable restore
#line 62 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
                             item.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\n                        ");
                __builder2.OpenElement(68, "td");
                __builder2.AddContent(69, 
#nullable restore
#line 63 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
                             item.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\n                        ");
                __builder2.OpenElement(71, "td");
                __builder2.AddContent(72, 
#nullable restore
#line 64 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
                             item.JobTitle

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\n                        ");
                __builder2.OpenElement(74, "td");
                __builder2.AddContent(75, 
#nullable restore
#line 65 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
                             item.HairColor

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\n                        ");
                __builder2.OpenElement(77, "td");
                __builder2.AddContent(78, 
#nullable restore
#line 66 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
                             item.EyeColor

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\n                        ");
                __builder2.OpenElement(80, "td");
                __builder2.AddContent(81, 
#nullable restore
#line 67 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
                             item.Age

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\n                        ");
                __builder2.OpenElement(83, "td");
                __builder2.AddContent(84, 
#nullable restore
#line 68 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
                             item.Weight

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\n                        ");
                __builder2.OpenElement(86, "td");
                __builder2.AddContent(87, 
#nullable restore
#line 69 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
                             item.Height

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\n                        ");
                __builder2.OpenElement(89, "td");
                __builder2.AddContent(90, 
#nullable restore
#line 70 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
                             item.Sex

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\n");
#nullable restore
#line 72 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(93, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\n        ");
            }
            ));
            __builder.AddAttribute(96, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(97, "\n            ");
                __builder2.OpenElement(98, "table");
                __builder2.AddAttribute(99, "class", "table");
                __builder2.AddMarkupContent(100, "\n                            ");
                __builder2.AddMarkupContent(101, @"<thead>
                            <tr>
                                <th>ID</th>
                                <th>First name</th>
                                <th>Last name</th>
                                <th>Job title</th>
                                <th>Hair color</th>
                                <th>Eye color</th>
                                <th>Age</th>
                                <th>Weight</th>
                                <th>Height</th>
                                <th>Sex</th>
                                <th>Remove</th>
                            </tr>
                            </thead>
                            ");
                __builder2.OpenElement(102, "tbody");
                __builder2.AddMarkupContent(103, "\n");
#nullable restore
#line 94 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
                             foreach (var item in adultsToShow)
                            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(104, "                                ");
                __builder2.OpenElement(105, "tr");
                __builder2.AddMarkupContent(106, "\n                                    ");
                __builder2.OpenElement(107, "td");
                __builder2.AddContent(108, 
#nullable restore
#line 97 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
                                         item.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\n                                    ");
                __builder2.OpenElement(110, "td");
                __builder2.AddContent(111, 
#nullable restore
#line 98 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
                                         item.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\n                                    ");
                __builder2.OpenElement(113, "td");
                __builder2.AddContent(114, 
#nullable restore
#line 99 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
                                         item.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\n                                    ");
                __builder2.OpenElement(116, "td");
                __builder2.AddContent(117, 
#nullable restore
#line 100 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
                                         item.JobTitle

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(118, "\n                                    ");
                __builder2.OpenElement(119, "td");
                __builder2.AddContent(120, 
#nullable restore
#line 101 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
                                         item.HairColor

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(121, "\n                                    ");
                __builder2.OpenElement(122, "td");
                __builder2.AddContent(123, 
#nullable restore
#line 102 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
                                         item.EyeColor

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(124, "\n                                    ");
                __builder2.OpenElement(125, "td");
                __builder2.AddContent(126, 
#nullable restore
#line 103 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
                                         item.Age

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(127, "\n                                    ");
                __builder2.OpenElement(128, "td");
                __builder2.AddContent(129, 
#nullable restore
#line 104 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
                                         item.Weight

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\n                                    ");
                __builder2.OpenElement(131, "td");
                __builder2.AddContent(132, 
#nullable restore
#line 105 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
                                         item.Height

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(133, "\n                                    ");
                __builder2.OpenElement(134, "td");
                __builder2.AddContent(135, 
#nullable restore
#line 106 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
                                         item.Sex

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(136, "\n                                    ");
                __builder2.OpenElement(137, "td");
                __builder2.AddMarkupContent(138, "\n                                        ");
                __builder2.OpenElement(139, "button");
                __builder2.AddAttribute(140, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 108 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
                                                            () => RemoveAdult(item.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(141, "\n                                            <i class=\"oi oi-trash\" style=\"color:red\"></i>\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(142, "\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(143, "\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(144, "\n");
#nullable restore
#line 113 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(145, "                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(146, "\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(147, "\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(148, "\n");
#nullable restore
#line 118 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 120 "C:\Users\eatcl\RiderProjects\Assignment_2\Assignment_2\Pages\ViewAdults.razor"
       
    private IList<Adult> allAdults;
    private IList<Adult> adultsToShow;

    private int? id;
    private string? firstName = "";
    private string? sex = "Any";
    
    protected override async Task OnInitializedAsync()
    {
        allAdults =  await Persistence.ReadAllAdultsAsync(id, firstName, sex);
        adultsToShow = allAdults;
    }

    private async Task Filter()
    {
        allAdults =  await Persistence.ReadAllAdultsAsync(id, firstName, sex);
        adultsToShow = allAdults;
    }

    // private void FilterByAdultId(ChangeEventArgs eventArgs)
    // {
    //     id = null;
    //     try
    //     {
    //         id = int.Parse(eventArgs.Value.ToString());
    //     }
    //     catch (Exception e)
    //     {
    //     }
    //     ExecuteFilter();
    // }
    //
    // private void FilterByFirstName(ChangeEventArgs changeEventArgs)
    // {
    //     firstName = null;
    //     try
    //     {
    //         firstName = changeEventArgs.Value.ToString();
    //     }
    //     catch (Exception e)
    //     {
    //     }
    //     ExecuteFilter();
    // }
    //
    // private void FilterBySex(ChangeEventArgs changeEventArgs)
    // {
    //     sex = null;
    //     try
    //     {
    //         if (changeEventArgs.Value.ToString().Equals("Male"))
    //         {
    //             sex = "M";
    //         }
    //         else if (changeEventArgs.Value.ToString().Equals("Female"))
    //         {
    //             sex = "F";
    //         }
    //     }
    //     catch (Exception e)
    //     {
    //     }
    //     ExecuteFilter();
    // }
    //
    // private void ExecuteFilter()
    // {
    //     adultsToShow = allAdults.Where(a => (id!=null && a.Id == id || id == null) &&
    //                                         (firstName != null && a.FirstName.Contains(firstName, StringComparison.OrdinalIgnoreCase) || firstName == null || firstName.Length == 0) &&
    //                                         (sex!=null && a.Sex == sex || sex == null) ).ToList();
    // }

    private async Task RemoveAdult(int adultID)
    {
        Adult adultToRemove = allAdults.First(a => a.Id == adultID);
        await Persistence.DeleteAdultAsync(adultID);
        allAdults.Remove(adultToRemove);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService Persistence { get; set; }
    }
}
#pragma warning restore 1591