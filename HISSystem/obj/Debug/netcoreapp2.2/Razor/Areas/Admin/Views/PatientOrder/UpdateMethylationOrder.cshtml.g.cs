#pragma checksum "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\UpdateMethylationOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31926edac7c529e9943cbf56a6d7621790e0b11f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_PatientOrder_UpdateMethylationOrder), @"mvc.1.0.view", @"/Areas/Admin/Views/PatientOrder/UpdateMethylationOrder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/PatientOrder/UpdateMethylationOrder.cshtml", typeof(AspNetCore.Areas_Admin_Views_PatientOrder_UpdateMethylationOrder))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31926edac7c529e9943cbf56a6d7621790e0b11f", @"/Areas/Admin/Views/PatientOrder/UpdateMethylationOrder.cshtml")]
    public class Areas_Admin_Views_PatientOrder_UpdateMethylationOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Data.Models.PatientOrderMethyation>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 1771, true);
            WriteLiteral(@"

<div class=""tab-content pad-all-sm"">
    <div id=""tab-27"" class=""tab-pane fade in active"">
        <div class=""row"">
            <div class=""panel-group panel-2"" id=""bs-collapse"">
                <div class=""panel"">
                    <div class=""panel-heading"">
                        <h4 class=""panel-title"">
                            <a data-toggle=""collapse"" data-info=""Department"" href=""#one"">
                                Methyation Template
                            </a>
                        </h4>
                    </div>
                    <div id=""one"" class=""panel-collapse collapse"">
                        <div class=""panel-body"">
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <div class=""table-responsive"">
                                        <div>
                                            <table class=""table table-hover table-bordered table-striped"">
                  ");
            WriteLiteral(@"                              <thead>
                                                    <tr class="""">
                                                        <th class=""numeric"">Gene</th>
                                                        <th class=""numeric"">Have Mutation</th>
                                                        <th class=""numeric"">Result</th>
                                                        <th class=""numeric"">Result Summary</th>
                                                        <th class=""numeric"">Recommendations</th>
                                                    </tr>
                                                </thead>
                                                <tbody>
");
            EndContext();
#line 33 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\UpdateMethylationOrder.cshtml"
                                                     foreach (var item in Model.Select((value, i) => new { i, value }))
                                                    {

#line default
#line hidden
            BeginContext(1996, 198, true);
            WriteLiteral("                                                        <tr>\r\n                                                            <td>\r\n                                                                <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 2194, "\"", 2239, 3);
            WriteAttributeValue("", 2201, "PatientOrderMethyationList[", 2201, 27, true);
#line 37 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\UpdateMethylationOrder.cshtml"
WriteAttributeValue("", 2228, item.i, 2228, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 2235, "].ID", 2235, 4, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2240, "\"", 2262, 1);
#line 37 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\UpdateMethylationOrder.cshtml"
WriteAttributeValue("", 2248, item.value.ID, 2248, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2263, 80, true);
            WriteLiteral(" hidden>\r\n                                                                <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 2343, "\"", 2393, 3);
            WriteAttributeValue("", 2350, "PatientOrderMethyationList[", 2350, 27, true);
#line 38 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\UpdateMethylationOrder.cshtml"
WriteAttributeValue("", 2377, item.i, 2377, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 2384, "].OrderID", 2384, 9, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2394, "\"", 2421, 1);
#line 38 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\UpdateMethylationOrder.cshtml"
WriteAttributeValue("", 2402, item.value.OrderID, 2402, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2422, 80, true);
            WriteLiteral(" hidden>\r\n                                                                <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 2502, "\"", 2553, 3);
            WriteAttributeValue("", 2509, "PatientOrderMethyationList[", 2509, 27, true);
#line 39 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\UpdateMethylationOrder.cshtml"
WriteAttributeValue("", 2536, item.i, 2536, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 2543, "].IsActive", 2543, 10, true);
            EndWriteAttribute();
            BeginContext(2554, 93, true);
            WriteLiteral(" value=\"True\" hidden>\r\n                                                                <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 2647, "\"", 2699, 3);
            WriteAttributeValue("", 2654, "PatientOrderMethyationList[", 2654, 27, true);
#line 40 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\UpdateMethylationOrder.cshtml"
WriteAttributeValue("", 2681, item.i, 2681, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 2688, "].CreatedOn", 2688, 11, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2700, "\"", 2729, 1);
#line 40 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\UpdateMethylationOrder.cshtml"
WriteAttributeValue("", 2708, item.value.CreatedOn, 2708, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2730, 80, true);
            WriteLiteral(" hidden>\r\n                                                                <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 2810, "\"", 2862, 3);
            WriteAttributeValue("", 2817, "PatientOrderMethyationList[", 2817, 27, true);
#line 41 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\UpdateMethylationOrder.cshtml"
WriteAttributeValue("", 2844, item.i, 2844, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 2851, "].UpdatedOn", 2851, 11, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2863, "\"", 2884, 1);
#line 41 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\UpdateMethylationOrder.cshtml"
WriteAttributeValue("", 2871, ViewBag.Date, 2871, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2885, 10, true);
            WriteLiteral(" hidden>\r\n");
            EndContext();
#line 42 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\UpdateMethylationOrder.cshtml"
                                                                 if (item.value.Gene != null)
                                                                {
                                                                    

#line default
#line hidden
            BeginContext(3126, 319, false);
#line 44 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\UpdateMethylationOrder.cshtml"
                                                               Write(Html.DropDownList("PatientOrderMethyationList[" + @item.i + "].GeneID", new SelectList(ViewBag.EffectedGenes, "ID", "Name", item.value.GeneID), htmlAttributes: new { @class = "form-control dropdown", id = "PatientOrderMethyationList[" + @item.i + "].GeneID", name = "PatientOrderMethyationList[" + @item.i + "].Gene" }));

#line default
#line hidden
            EndContext();
#line 44 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\UpdateMethylationOrder.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                    
                                                                }

#line default
#line hidden
            BeginContext(3514, 252, true);
            WriteLiteral("\r\n                                                            </td>\r\n                                                            <td>\r\n                                                                <div class=\"form-check\"><label><input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3766, "\"", 3819, 3);
            WriteAttributeValue("", 3771, "PatientOrderMethyationList[", 3771, 27, true);
#line 49 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\UpdateMethylationOrder.cshtml"
WriteAttributeValue("", 3798, item.i, 3798, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 3805, "].HaveMutation", 3805, 14, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 3820, "\"", 3875, 3);
            WriteAttributeValue("", 3827, "PatientOrderMethyationList[", 3827, 27, true);
#line 49 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\UpdateMethylationOrder.cshtml"
WriteAttributeValue("", 3854, item.i, 3854, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 3861, "].HaveMutation", 3861, 14, true);
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 3876, "\"", 3907, 3);
            WriteAttributeValue("", 3886, "GetID(", 3886, 6, true);
#line 49 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\UpdateMethylationOrder.cshtml"
WriteAttributeValue("", 3892, item.value.ID, 3892, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 3906, ")", 3906, 1, true);
            EndWriteAttribute();
            BeginContext(3908, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3910, 50, false);
#line 49 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\UpdateMethylationOrder.cshtml"
                                                                                                                                                                                                                                                               Write(Html.Raw(item.value.HaveMutation ? "checked" : ""));

#line default
#line hidden
            EndContext();
            BeginContext(3960, 197, true);
            WriteLiteral(" value=\"true\"><span class=\"label-text\"></span></label></div>\r\n\r\n                                                            </td>\r\n                                                            <td>\r\n");
            EndContext();
#line 53 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\UpdateMethylationOrder.cshtml"
                                                                 if (item.value.Result != null)
                                                                {
                                                                    

#line default
#line hidden
            BeginContext(4390, 204, false);
#line 55 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\UpdateMethylationOrder.cshtml"
                                                               Write(Html.DropDownList("PatientOrderMethyationList[" + @item.i + "].Result", new SelectList(ViewBag.EffectedTypes, "Value", "Text", item.value.Result), htmlAttributes: new { @class = "form-control dropdown" }));

#line default
#line hidden
            EndContext();
#line 55 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\UpdateMethylationOrder.cshtml"
                                                                                                                                                                                                                                                                                 

                                                                }

#line default
#line hidden
            BeginContext(4665, 215, true);
            WriteLiteral("                                                            </td>\r\n                                                            <td>\r\n                                                                <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4880, "\"", 4934, 3);
            WriteAttributeValue("", 4885, "PatientOrderMethyationList[", 4885, 27, true);
#line 60 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\UpdateMethylationOrder.cshtml"
WriteAttributeValue("", 4912, item.i, 4912, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 4919, "].ResultSummary", 4919, 15, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 4935, "\"", 4991, 3);
            WriteAttributeValue("", 4942, "PatientOrderMethyationList[", 4942, 27, true);
#line 60 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\UpdateMethylationOrder.cshtml"
WriteAttributeValue("", 4969, item.i, 4969, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 4976, "].ResultSummary", 4976, 15, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 4992, "\"", 5025, 1);
#line 60 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\UpdateMethylationOrder.cshtml"
WriteAttributeValue("", 5000, item.value.ResultSummary, 5000, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5026, 239, true);
            WriteLiteral(" class=\"form-control\">\r\n                                                            </td>\r\n                                                            <td>\r\n                                                                <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5265, "\"", 5321, 3);
            WriteAttributeValue("", 5270, "PatientOrderMethyationList[", 5270, 27, true);
#line 63 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\UpdateMethylationOrder.cshtml"
WriteAttributeValue("", 5297, item.i, 5297, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 5304, "].Recommendations", 5304, 17, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 5322, "\"", 5380, 3);
            WriteAttributeValue("", 5329, "PatientOrderMethyationList[", 5329, 27, true);
#line 63 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\UpdateMethylationOrder.cshtml"
WriteAttributeValue("", 5356, item.i, 5356, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 5363, "].Recommendations", 5363, 17, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 5381, "\"", 5416, 1);
#line 63 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\UpdateMethylationOrder.cshtml"
WriteAttributeValue("", 5389, item.value.Recommendations, 5389, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5417, 154, true);
            WriteLiteral(" class=\"form-control\">\r\n                                                            </td>\r\n                                                        </tr>\r\n");
            EndContext();
#line 66 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\UpdateMethylationOrder.cshtml"
                                                    }

#line default
#line hidden
            BeginContext(5626, 580, true);
            WriteLiteral(@"                                                </tbody>
                                                <tfoot>
                                                </tfoot>
                                            </table>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- end of panel -->
                </div>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Data.Models.PatientOrderMethyation>> Html { get; private set; }
    }
}
#pragma warning restore 1591
