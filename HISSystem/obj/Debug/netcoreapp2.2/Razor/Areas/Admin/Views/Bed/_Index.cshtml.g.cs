#pragma checksum "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Bed\_Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36ce0d42ef0b203532cb129493bf13664166ae4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Bed__Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Bed/_Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Bed/_Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Bed__Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36ce0d42ef0b203532cb129493bf13664166ae4f", @"/Areas/Admin/Views/Bed/_Index.cshtml")]
    public class Areas_Admin_Views_Bed__Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HISSystem.Areas.Admin.Models.BedIndexModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 333, true);
            WriteLiteral(@"
<table class=""table table-hover table-bordered table-striped"">
    <thead>
        <tr>
            <th class=""numeric"">Bed Number</th>
            <th class=""numeric"">Bed Name</th>
            <th class=""numeric"">Status</th>
            <th class=""numeric"" colspan=""2"">Action</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 13 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Bed\_Index.cshtml"
         foreach (var item in Model.PagedBed.Data)
        {

#line default
#line hidden
            BeginContext(447, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(486, 14, false);
#line 16 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Bed\_Index.cshtml"
               Write(item.BedNumber);

#line default
#line hidden
            EndContext();
            BeginContext(500, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(528, 9, false);
#line 17 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Bed\_Index.cshtml"
               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(537, 76, true);
            WriteLiteral("</td>\r\n                <td></td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(614, 173, false);
#line 20 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Bed\_Index.cshtml"
               Write(Html.ActionLink("", "GetBed", "Bed", new { id = item.ID }, new { @Class = "fa fa-pencil", id = @item.ID, data_toggle = "tooltip", data_placement = "top", title = "Update" }));

#line default
#line hidden
            EndContext();
            BeginContext(787, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(997, 79, true);
            WriteLiteral("                    <a href=\"javascript:void(0);\" class=\"fa fa-trash mrgn-l-xs\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1076, "\"", 1102, 3);
            WriteAttributeValue("", 1086, "Detele(", 1086, 7, true);
#line 22 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Bed\_Index.cshtml"
WriteAttributeValue("", 1093, item.ID, 1093, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1101, ")", 1101, 1, true);
            EndWriteAttribute();
            BeginContext(1103, 108, true);
            WriteLiteral(" data-toggle=\"tooltip\" , data-placement=\"top\" title=\"Trach\"></a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 25 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Bed\_Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1222, 71, true);
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <tr>\r\n            <td colspan=\"6\">\r\n");
            EndContext();
#line 30 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Bed\_Index.cshtml"
                 for (int i = 1; i <= Model.PagedBed.NumberOfPages; i++)
                {

#line default
#line hidden
            BeginContext(1386, 68, true);
            WriteLiteral("                    <a class=\"page-number\" href=\"javascript:void()\">");
            EndContext();
            BeginContext(1455, 1, false);
#line 32 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Bed\_Index.cshtml"
                                                               Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1456, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 33 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Bed\_Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1481, 56, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n    </tfoot>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HISSystem.Areas.Admin.Models.BedIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
