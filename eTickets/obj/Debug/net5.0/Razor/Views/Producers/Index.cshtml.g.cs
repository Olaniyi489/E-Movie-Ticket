#pragma checksum "C:\Users\Decagon\source\repos\eTickets\eTickets\Views\Producers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dba7c192d3f542bd481ef1b1a99b8b924fcb20cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producers_Index), @"mvc.1.0.view", @"/Views/Producers/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Decagon\source\repos\eTickets\eTickets\Views\_ViewImports.cshtml"
using eTickets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Decagon\source\repos\eTickets\eTickets\Views\_ViewImports.cshtml"
using eTickets.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dba7c192d3f542bd481ef1b1a99b8b924fcb20cb", @"/Views/Producers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae36ea9afdbf4434090466b2ad951861827cd6f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Producers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Producer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\Decagon\source\repos\eTickets\eTickets\Views\Producers\Index.cshtml"
  
    ViewData["Title"] = "List of Producers";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-8 offset-md-2\">\r\n\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr class=\"text-center\">\r\n                    <th>");
#nullable restore
#line 21 "C:\Users\Decagon\source\repos\eTickets\eTickets\Views\Producers\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ProfilePictureUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 22 "C:\Users\Decagon\source\repos\eTickets\eTickets\Views\Producers\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 23 "C:\Users\Decagon\source\repos\eTickets\eTickets\Views\Producers\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Bio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>Actions</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\Decagon\source\repos\eTickets\eTickets\Views\Producers\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"align-middle\">\r\n                            <img class=\"rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 819, "\"", 848, 1);
#nullable restore
#line 32 "C:\Users\Decagon\source\repos\eTickets\eTickets\Views\Producers\Index.cshtml"
WriteAttributeValue("", 825, item.ProfilePictureUrl, 825, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 849, "\"", 869, 1);
#nullable restore
#line 32 "C:\Users\Decagon\source\repos\eTickets\eTickets\Views\Producers\Index.cshtml"
WriteAttributeValue("", 855, item.FullName, 855, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width: 150px\" />\r\n                        </td>\r\n                        <td class=\"align-middle\">\r\n                            ");
#nullable restore
#line 35 "C:\Users\Decagon\source\repos\eTickets\eTickets\Views\Producers\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"align-middle\">\r\n                            ");
#nullable restore
#line 38 "C:\Users\Decagon\source\repos\eTickets\eTickets\Views\Producers\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Bio));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </td>
                        <td class=""align-middle"">
                            <a class=""btn btn-primary""><i class=""bi bi-pencil-square""></i>Edit</a> |
                            <a class=""btn btn-info""><i class=""bi bi-eye""></i>Details</a> |
                            <a class=""btn btn-danger text-white""><i class=""bi bi-trash""></i>Delete </a>
                        </td>
                    </tr>
");
#nullable restore
#line 46 "C:\Users\Decagon\source\repos\eTickets\eTickets\Views\Producers\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Producer>> Html { get; private set; }
    }
}
#pragma warning restore 1591