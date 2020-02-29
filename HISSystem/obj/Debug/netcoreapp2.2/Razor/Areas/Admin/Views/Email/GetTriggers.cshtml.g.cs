#pragma checksum "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Email\GetTriggers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4c6f10d39766600097039682dcc0ad4eea4f5cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Email_GetTriggers), @"mvc.1.0.view", @"/Areas/Admin/Views/Email/GetTriggers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Email/GetTriggers.cshtml", typeof(AspNetCore.Areas_Admin_Views_Email_GetTriggers))]
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
#line 2 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Email\GetTriggers.cshtml"
using Data.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4c6f10d39766600097039682dcc0ad4eea4f5cf", @"/Areas/Admin/Views/Email/GetTriggers.cshtml")]
    public class Areas_Admin_Views_Email_GetTriggers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Helpers.PagedData<Data.Models.EmailTrigger>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(79, 320, true);
            WriteLiteral(@"<div class=""table-responsive"">
    <table class=""table table-striped table-hover table-bordered"">
        <thead>
            <tr>
                <th>Trigger for</th>
                <th>Template name</th>
                <th style=""width:100px"">Action</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 13 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Email\GetTriggers.cshtml"
             foreach (var item in Model.Data)
            {

#line default
#line hidden
            BeginContext(461, 22, true);
            WriteLiteral("                <tr>\r\n");
            EndContext();
#line 16 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Email\GetTriggers.cshtml"
                     if (Convert.ToInt32(EmailTriggerType.Registeration) == Convert.ToInt32(item.TriggerName))
                    {

#line default
#line hidden
            BeginContext(618, 58, true);
            WriteLiteral("                        <td>\r\n                            ");
            EndContext();
            BeginContext(677, 41, false);
#line 19 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Email\GetTriggers.cshtml"
                       Write(EmailTriggerType.Registeration.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(718, 33, true);
            WriteLiteral("\r\n                        </td>\r\n");
            EndContext();
#line 21 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Email\GetTriggers.cshtml"
                    }

#line default
#line hidden
            BeginContext(774, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 22 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Email\GetTriggers.cshtml"
                     if (Convert.ToInt32(EmailTriggerType.Client) == Convert.ToInt32(item.TriggerName))
                    {

#line default
#line hidden
            BeginContext(902, 58, true);
            WriteLiteral("                        <td>\r\n                            ");
            EndContext();
            BeginContext(961, 34, false);
#line 25 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Email\GetTriggers.cshtml"
                       Write(EmailTriggerType.Client.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(995, 33, true);
            WriteLiteral("\r\n                        </td>\r\n");
            EndContext();
#line 27 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Email\GetTriggers.cshtml"
                    }

#line default
#line hidden
            BeginContext(1051, 26, true);
            WriteLiteral("\r\n                    <td>");
            EndContext();
            BeginContext(1078, 15, false);
#line 29 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Email\GetTriggers.cshtml"
                   Write(item.Email.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1093, 112, true);
            WriteLiteral("</td>\r\n\r\n                    <td>\r\n\r\n                        <a href=\"#\"><i class=\"fa fa-pencil fa-md base-dark\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1205, "\"", 1238, 3);
            WriteAttributeValue("", 1215, "editTrigger(\'", 1215, 13, true);
#line 33 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Email\GetTriggers.cshtml"
WriteAttributeValue("", 1228, item.ID, 1228, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1236, "\')", 1236, 2, true);
            EndWriteAttribute();
            BeginContext(1239, 124, true);
            WriteLiteral(" aria-hidden=\"true\"></i></a>\r\n\r\n                        <a href=\"#\" class=\"mrgn-l-sm\"><i class=\"fa fa-trash fa-md base-dark\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1363, "\"", 1403, 3);
            WriteAttributeValue("", 1373, "DeleteEmailTrigger(\'", 1373, 20, true);
#line 35 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Email\GetTriggers.cshtml"
WriteAttributeValue("", 1393, item.ID, 1393, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1401, "\')", 1401, 2, true);
            EndWriteAttribute();
            BeginContext(1404, 82, true);
            WriteLiteral(" aria-hidden=\"true\"></i></a>\r\n                    </td>\r\n\r\n                </tr>\r\n");
            EndContext();
#line 39 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Email\GetTriggers.cshtml"
            }

#line default
#line hidden
            BeginContext(1501, 87, true);
            WriteLiteral("        </tbody>\r\n        <tfoot>\r\n            <tr>\r\n                <td colspan=\"3\">\r\n");
            EndContext();
#line 44 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Email\GetTriggers.cshtml"
                     for (int i = 1; i <= Model.NumberOfPages; i++)
                    {

#line default
#line hidden
            BeginContext(1680, 46, true);
            WriteLiteral("                        <a class=\"page-number\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1726, "\"", 1761, 3);
            WriteAttributeValue("", 1736, "getemailtriggersearch(", 1736, 22, true);
#line 46 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Email\GetTriggers.cshtml"
WriteAttributeValue("", 1758, i, 1758, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 1760, ")", 1760, 1, true);
            EndWriteAttribute();
            BeginContext(1762, 27, true);
            WriteLiteral(" href=\"javascript:void();\">");
            EndContext();
            BeginContext(1790, 1, false);
#line 46 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Email\GetTriggers.cshtml"
                                                                                                        Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1791, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 47 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Email\GetTriggers.cshtml"
                    }

#line default
#line hidden
            BeginContext(1820, 80, true);
            WriteLiteral("                </td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Helpers.PagedData<Data.Models.EmailTrigger>> Html { get; private set; }
    }
}
#pragma warning restore 1591
