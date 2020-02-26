#pragma checksum "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42e536f092e070324d30b8812ce04f0cc4068a9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ClientOrder__Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ClientOrder/_Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/ClientOrder/_Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_ClientOrder__Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42e536f092e070324d30b8812ce04f0cc4068a9e", @"/Areas/Admin/Views/ClientOrder/_Index.cshtml")]
    public class Areas_Admin_Views_ClientOrder__Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Helpers.PagedData<Data.Models.ClientOrder>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 355, true);
            WriteLiteral(@"

<table class=""table table-hover table-bordered table-striped"" id=""relative-table"">
    <thead>
        <tr class="""">
            <th>Order No</th>
            <th>Order Date</th>
            <th>Order DueDate</th>
            <th>Doctor</th>
            <th>Patient</th>
            <th>Actions</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 16 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_Index.cshtml"
         foreach (var order in Model.Data)
        {

#line default
#line hidden
            BeginContext(466, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(527, 13, false);
#line 20 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_Index.cshtml"
               Write(order.OrderNo);

#line default
#line hidden
            EndContext();
            BeginContext(540, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(608, 15, false);
#line 23 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_Index.cshtml"
               Write(order.OrderDate);

#line default
#line hidden
            EndContext();
            BeginContext(623, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(691, 18, false);
#line 26 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_Index.cshtml"
               Write(order.OrderDueDate);

#line default
#line hidden
            EndContext();
            BeginContext(709, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(777, 25, false);
#line 29 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_Index.cshtml"
               Write(order.Doctor?.EnFirstName);

#line default
#line hidden
            EndContext();
            BeginContext(802, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(804, 26, false);
#line 29 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_Index.cshtml"
                                          Write(order.Doctor?.EnSecondName);

#line default
#line hidden
            EndContext();
            BeginContext(830, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(832, 25, false);
#line 29 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_Index.cshtml"
                                                                      Write(order.Doctor?.EnThirdName);

#line default
#line hidden
            EndContext();
            BeginContext(857, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(925, 23, false);
#line 32 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_Index.cshtml"
               Write(order.User?.EnFirstName);

#line default
#line hidden
            EndContext();
            BeginContext(948, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(950, 24, false);
#line 32 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_Index.cshtml"
                                        Write(order.User?.EnSecondName);

#line default
#line hidden
            EndContext();
            BeginContext(974, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(976, 23, false);
#line 32 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_Index.cshtml"
                                                                  Write(order.User?.EnThirdName);

#line default
#line hidden
            EndContext();
            BeginContext(999, 665, true);
            WriteLiteral(@"
                </td>
                <td>
                    <a href=""javascript:void(0);"" class=""fa fa fa-pencil mrgn-l-xs fa-1x"" onclick=""editTemplateData(event)"" data-toggle=""tooltip"" , data-placement=""top"" title=""Edit""></a>
                    <a href=""javascript:void(0);"" class=""fa fa-trash mrgn-l-xs fa-1x"" onclick=""deleteTemplateData(event)"" data-toggle=""tooltip"" , data-placement=""top"" title=""Delete""></a>
                    <a href=""javascript:void(0);"" class=""fa fa-floppy-o mrgn-l-xs fa-1x"" onclick=""updateTemplateData(event)"" data-toggle=""tooltip"" , data-placement=""top"" title=""Timeline"" hidden></a>
                </td>
            </tr>
");
            EndContext();
#line 40 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1675, 72, true);
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <tr>\r\n            <td colspan=\"17\">\r\n");
            EndContext();
#line 45 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_Index.cshtml"
                 for (int i = 1; i <= Model.NumberOfPages; i++)
                {

#line default
#line hidden
            BeginContext(1831, 69, true);
            WriteLiteral("                    <a class=\"page-number\" href=\"javascript:void();\">");
            EndContext();
            BeginContext(1901, 1, false);
#line 47 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_Index.cshtml"
                                                                Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1902, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 48 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1927, 56, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Helpers.PagedData<Data.Models.ClientOrder>> Html { get; private set; }
    }
}
#pragma warning restore 1591