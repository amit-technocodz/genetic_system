#pragma checksum "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Email\GetEmails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12c1980af3bfe9a5215df46c04b691829f574ae0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Email_GetEmails), @"mvc.1.0.view", @"/Areas/Admin/Views/Email/GetEmails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Email/GetEmails.cshtml", typeof(AspNetCore.Areas_Admin_Views_Email_GetEmails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12c1980af3bfe9a5215df46c04b691829f574ae0", @"/Areas/Admin/Views/Email/GetEmails.cshtml")]
    public class Areas_Admin_Views_Email_GetEmails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Helpers.PagedData<Data.Models.Email>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 338, true);
            WriteLiteral(@"<div class=""table-responsive"">
    <table class=""table table-striped table-hover table-bordered"">
        <thead>
            <tr>
                <th>Name</th>
                <th>Subject</th>
                <th>Body</th>
                <th style=""width:100px"">Action</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 13 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Email\GetEmails.cshtml"
             foreach (var item in Model.Data)
            {

#line default
#line hidden
            BeginContext(450, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(497, 9, false);
#line 16 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Email\GetEmails.cshtml"
                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(506, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(538, 12, false);
#line 17 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Email\GetEmails.cshtml"
                   Write(item.Subject);

#line default
#line hidden
            EndContext();
            BeginContext(550, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(582, 9, false);
#line 18 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Email\GetEmails.cshtml"
                   Write(item.Body);

#line default
#line hidden
            EndContext();
            BeginContext(591, 110, true);
            WriteLiteral("</td>\r\n                    <td>\r\n\r\n                        <a href=\"#\"><i class=\"fa fa-pencil fa-md base-dark\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 701, "\"", 732, 3);
            WriteAttributeValue("", 711, "editEmail(\'", 711, 11, true);
#line 21 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Email\GetEmails.cshtml"
WriteAttributeValue("", 722, item.ID, 722, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 730, "\')", 730, 2, true);
            EndWriteAttribute();
            BeginContext(733, 124, true);
            WriteLiteral(" aria-hidden=\"true\"></i></a>\r\n\r\n                        <a href=\"#\" class=\"mrgn-l-sm\"><i class=\"fa fa-trash fa-md base-dark\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 857, "\"", 890, 3);
            WriteAttributeValue("", 867, "DeleteEmail(\'", 867, 13, true);
#line 23 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Email\GetEmails.cshtml"
WriteAttributeValue("", 880, item.ID, 880, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 888, "\')", 888, 2, true);
            EndWriteAttribute();
            BeginContext(891, 82, true);
            WriteLiteral(" aria-hidden=\"true\"></i></a>\r\n                    </td>\r\n\r\n                </tr>\r\n");
            EndContext();
#line 27 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Email\GetEmails.cshtml"
            }

#line default
#line hidden
            BeginContext(988, 87, true);
            WriteLiteral("        </tbody>\r\n        <tfoot>\r\n            <tr>\r\n                <td colspan=\"5\">\r\n");
            EndContext();
#line 32 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Email\GetEmails.cshtml"
                     for (int i = 1; i <= Model.NumberOfPages; i++)
                    {

#line default
#line hidden
            BeginContext(1167, 46, true);
            WriteLiteral("                        <a class=\"page-number\"");
            EndContext();
            BeginWriteAttribute("onclick", "onclick=\"", 1213, "\"", 1240, 3);
            WriteAttributeValue("", 1222, "getemailsearch(", 1222, 15, true);
#line 34 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Email\GetEmails.cshtml"
WriteAttributeValue("", 1237, i, 1237, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 1239, ")", 1239, 1, true);
            EndWriteAttribute();
            BeginContext(1241, 27, true);
            WriteLiteral(" href=\"javascript:void();\">");
            EndContext();
            BeginContext(1269, 1, false);
#line 34 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Email\GetEmails.cshtml"
                                                                                                Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1270, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 35 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Email\GetEmails.cshtml"
                    }

#line default
#line hidden
            BeginContext(1299, 82, true);
            WriteLiteral("                </td>\r\n            </tr>\r\n        </tfoot>\r\n\r\n    </table>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Helpers.PagedData<Data.Models.Email>> Html { get; private set; }
    }
}
#pragma warning restore 1591
