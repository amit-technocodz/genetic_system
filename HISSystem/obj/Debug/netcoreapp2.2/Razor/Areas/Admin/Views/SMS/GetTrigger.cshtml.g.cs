#pragma checksum "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\GetTrigger.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7693f12017eeb4116d3d4b77d855d7186cdc3264"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SMS_GetTrigger), @"mvc.1.0.view", @"/Areas/Admin/Views/SMS/GetTrigger.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/SMS/GetTrigger.cshtml", typeof(AspNetCore.Areas_Admin_Views_SMS_GetTrigger))]
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
#line 2 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\GetTrigger.cshtml"
using Data.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7693f12017eeb4116d3d4b77d855d7186cdc3264", @"/Areas/Admin/Views/SMS/GetTrigger.cshtml")]
    public class Areas_Admin_Views_SMS_GetTrigger : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Helpers.PagedData<Data.Models.SMSTrigger>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(77, 320, true);
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
#line 13 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\GetTrigger.cshtml"
             foreach (var item in Model.Data)
            {

#line default
#line hidden
            BeginContext(459, 22, true);
            WriteLiteral("                <tr>\r\n");
            EndContext();
#line 16 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\GetTrigger.cshtml"
                     if (Convert.ToInt32(SMSTriggerType.Registeration) == Convert.ToInt32(item.TriggerName))
                    {

#line default
#line hidden
            BeginContext(614, 58, true);
            WriteLiteral("                        <td>\r\n                            ");
            EndContext();
            BeginContext(673, 39, false);
#line 19 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\GetTrigger.cshtml"
                       Write(SMSTriggerType.Registeration.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(712, 33, true);
            WriteLiteral("\r\n                        </td>\r\n");
            EndContext();
#line 21 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\GetTrigger.cshtml"
                    }

#line default
#line hidden
            BeginContext(768, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 22 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\GetTrigger.cshtml"
                     if (Convert.ToInt32(SMSTriggerType.Client) == Convert.ToInt32(item.TriggerName))
                    {

#line default
#line hidden
            BeginContext(894, 58, true);
            WriteLiteral("                        <td>\r\n                            ");
            EndContext();
            BeginContext(953, 34, false);
#line 25 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\GetTrigger.cshtml"
                       Write(EmailTriggerType.Client.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(987, 33, true);
            WriteLiteral("\r\n                        </td>\r\n");
            EndContext();
#line 27 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\GetTrigger.cshtml"
                    }

#line default
#line hidden
            BeginContext(1043, 26, true);
            WriteLiteral("\r\n                    <td>");
            EndContext();
            BeginContext(1070, 13, false);
#line 29 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\GetTrigger.cshtml"
                   Write(item.SMS.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1083, 112, true);
            WriteLiteral("</td>\r\n\r\n                    <td>\r\n\r\n                        <a href=\"#\"><i class=\"fa fa-pencil fa-md base-dark\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1195, "\"", 1228, 3);
            WriteAttributeValue("", 1205, "editTrigger(\'", 1205, 13, true);
#line 33 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\GetTrigger.cshtml"
WriteAttributeValue("", 1218, item.ID, 1218, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1226, "\')", 1226, 2, true);
            EndWriteAttribute();
            BeginContext(1229, 124, true);
            WriteLiteral(" aria-hidden=\"true\"></i></a>\r\n\r\n                        <a href=\"#\" class=\"mrgn-l-sm\"><i class=\"fa fa-trash fa-md base-dark\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1353, "\"", 1393, 3);
            WriteAttributeValue("", 1363, "DeleteEmailTrigger(\'", 1363, 20, true);
#line 35 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\GetTrigger.cshtml"
WriteAttributeValue("", 1383, item.ID, 1383, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1391, "\')", 1391, 2, true);
            EndWriteAttribute();
            BeginContext(1394, 82, true);
            WriteLiteral(" aria-hidden=\"true\"></i></a>\r\n                    </td>\r\n\r\n                </tr>\r\n");
            EndContext();
#line 39 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\GetTrigger.cshtml"
            }

#line default
#line hidden
            BeginContext(1491, 87, true);
            WriteLiteral("        </tbody>\r\n        <tfoot>\r\n            <tr>\r\n                <td colspan=\"3\">\r\n");
            EndContext();
#line 44 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\GetTrigger.cshtml"
                     for (int i = 1; i <= Model.NumberOfPages; i++)
                    {

#line default
#line hidden
            BeginContext(1670, 46, true);
            WriteLiteral("                        <a class=\"page-number\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1716, "\"", 1749, 3);
            WriteAttributeValue("", 1726, "getSMStriggersearch(", 1726, 20, true);
#line 46 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\GetTrigger.cshtml"
WriteAttributeValue("", 1746, i, 1746, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 1748, ")", 1748, 1, true);
            EndWriteAttribute();
            BeginContext(1750, 27, true);
            WriteLiteral(" href=\"javascript:void();\">");
            EndContext();
            BeginContext(1778, 1, false);
#line 46 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\GetTrigger.cshtml"
                                                                                                      Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1779, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 47 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\GetTrigger.cshtml"
                    }

#line default
#line hidden
            BeginContext(1808, 80, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Helpers.PagedData<Data.Models.SMSTrigger>> Html { get; private set; }
    }
}
#pragma warning restore 1591