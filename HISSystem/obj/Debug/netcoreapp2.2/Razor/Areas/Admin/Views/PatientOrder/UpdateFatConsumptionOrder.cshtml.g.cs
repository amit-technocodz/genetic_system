#pragma checksum "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\UpdateFatConsumptionOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcea1d0d000d590af8632d88ca4b60b8f46d0043"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_PatientOrder_UpdateFatConsumptionOrder), @"mvc.1.0.view", @"/Areas/Admin/Views/PatientOrder/UpdateFatConsumptionOrder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/PatientOrder/UpdateFatConsumptionOrder.cshtml", typeof(AspNetCore.Areas_Admin_Views_PatientOrder_UpdateFatConsumptionOrder))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcea1d0d000d590af8632d88ca4b60b8f46d0043", @"/Areas/Admin/Views/PatientOrder/UpdateFatConsumptionOrder.cshtml")]
    public class Areas_Admin_Views_PatientOrder_UpdateFatConsumptionOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Data.Models.PatientOrderFatConsumption>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 1695, true);
            WriteLiteral(@"

<div class=""tab-content pad-all-sm"">
    <div id=""tab-27"" class=""tab-pane fade in active"">
        <div class=""row"">
            <div class=""panel-group panel-2"" id=""bs-collapse"">
                <div class=""panel"">
                    <div class=""panel-heading"">
                        <h4 class=""panel-title"">
                            <a data-toggle=""collapse"" data-info=""Department"" href=""#one"">
                                Fat Consumption Template
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
            WriteLiteral(@"                                   <thead>
                                                    <tr class="""">
                                                        <th class=""numeric"">ConsumptionType</th>
                                                        <th class=""numeric"">Effected Gene</th>
                                                        <th class=""numeric"">Is Effected</th>
                                                        <th class=""numeric"">Recommendations</th>
                                                    </tr>
                                                </thead>
                                                <tbody>
");
            EndContext();
#line 32 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\UpdateFatConsumptionOrder.cshtml"
                                                     foreach (var item in Model.Select((value, i) => new { i, value }))
                                                    {

#line default
#line hidden
            BeginContext(1924, 198, true);
            WriteLiteral("                                                        <tr>\r\n                                                            <td>\r\n                                                                <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 2122, "\"", 2171, 3);
            WriteAttributeValue("", 2129, "PatientOrderFatConsumptionList[", 2129, 31, true);
#line 36 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\UpdateFatConsumptionOrder.cshtml"
WriteAttributeValue("", 2160, item.i, 2160, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 2167, "].ID", 2167, 4, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2172, "\"", 2194, 1);
#line 36 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\UpdateFatConsumptionOrder.cshtml"
WriteAttributeValue("", 2180, item.value.ID, 2180, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2195, 80, true);
            WriteLiteral(" hidden>\r\n                                                                <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 2275, "\"", 2329, 3);
            WriteAttributeValue("", 2282, "PatientOrderFatConsumptionList[", 2282, 31, true);
#line 37 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\UpdateFatConsumptionOrder.cshtml"
WriteAttributeValue("", 2313, item.i, 2313, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 2320, "].OrderID", 2320, 9, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2330, "\"", 2357, 1);
#line 37 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\UpdateFatConsumptionOrder.cshtml"
WriteAttributeValue("", 2338, item.value.OrderID, 2338, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2358, 80, true);
            WriteLiteral(" hidden>\r\n                                                                <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 2438, "\"", 2493, 3);
            WriteAttributeValue("", 2445, "PatientOrderFatConsumptionList[", 2445, 31, true);
#line 38 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\UpdateFatConsumptionOrder.cshtml"
WriteAttributeValue("", 2476, item.i, 2476, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 2483, "].IsActive", 2483, 10, true);
            EndWriteAttribute();
            BeginContext(2494, 93, true);
            WriteLiteral(" value=\"True\" hidden>\r\n                                                                <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 2587, "\"", 2643, 3);
            WriteAttributeValue("", 2594, "PatientOrderFatConsumptionList[", 2594, 31, true);
#line 39 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\UpdateFatConsumptionOrder.cshtml"
WriteAttributeValue("", 2625, item.i, 2625, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 2632, "].CreatedOn", 2632, 11, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2644, "\"", 2673, 1);
#line 39 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\UpdateFatConsumptionOrder.cshtml"
WriteAttributeValue("", 2652, item.value.CreatedOn, 2652, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2674, 80, true);
            WriteLiteral(" hidden>\r\n                                                                <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 2754, "\"", 2810, 3);
            WriteAttributeValue("", 2761, "PatientOrderFatConsumptionList[", 2761, 31, true);
#line 40 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\UpdateFatConsumptionOrder.cshtml"
WriteAttributeValue("", 2792, item.i, 2792, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 2799, "].UpdatedOn", 2799, 11, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2811, "\"", 2832, 1);
#line 40 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\UpdateFatConsumptionOrder.cshtml"
WriteAttributeValue("", 2819, ViewBag.Date, 2819, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2833, 14, true);
            WriteLiteral(" hidden>\r\n\r\n\r\n");
            EndContext();
#line 43 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\UpdateFatConsumptionOrder.cshtml"
                                                                 if (item.value.ConsumptionType != null)
                                                                {
                                                                    

#line default
#line hidden
            BeginContext(3089, 378, false);
#line 45 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\UpdateFatConsumptionOrder.cshtml"
                                                               Write(Html.DropDownList("PatientOrderFatConsumptionList[" + @item.i + "].ConsumptionTypeID", new SelectList(ViewBag.ConsumptionTypes, "ID", "Name", item.value.ConsumptionTypeID), htmlAttributes: new { @class = "form-control dropdown", id = "PatientOrderFatConsumptionList[" + @item.i + "].ConsumptionTypeID", name = "PatientOrderFatConsumptionList[" + @item.i + "].ConsumptionType" }));

#line default
#line hidden
            EndContext();
#line 45 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\UpdateFatConsumptionOrder.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                                                                               
                                                                }

#line default
#line hidden
            BeginContext(3536, 135, true);
            WriteLiteral("\r\n                                                            </td>\r\n                                                            <td>\r\n");
            EndContext();
#line 50 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\UpdateFatConsumptionOrder.cshtml"
                                                                 if (item.value.EffectedGene != null)
                                                                {
                                                                    

#line default
#line hidden
            BeginContext(3910, 363, false);
#line 52 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\UpdateFatConsumptionOrder.cshtml"
                                                               Write(Html.DropDownList("PatientOrderFatConsumptionList[" + @item.i + "].EffectedGeneID", new SelectList(ViewBag.EffectedGenes, "ID", "Name", item.value.EffectedGeneID), htmlAttributes: new { @class = "form-control dropdown", id = "PatientOrderFatConsumptionList[" + @item.i + "].EffectedGeneID", name = "PatientOrderFatConsumptionList[" + @item.i + "].EffectedGene" }));

#line default
#line hidden
            EndContext();
#line 52 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\UpdateFatConsumptionOrder.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                                                                
                                                                }

#line default
#line hidden
            BeginContext(4342, 250, true);
            WriteLiteral("                                                            </td>\r\n                                                            <td>\r\n                                                                <div class=\"form-check\"><label><input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4592, "\"", 4645, 3);
            WriteAttributeValue("", 4597, "PatientOrderFatConsumptionList[", 4597, 31, true);
#line 56 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\UpdateFatConsumptionOrder.cshtml"
WriteAttributeValue("", 4628, item.i, 4628, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 4635, "].Effected", 4635, 10, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 4646, "\"", 4701, 3);
            WriteAttributeValue("", 4653, "PatientOrderFatConsumptionList[", 4653, 31, true);
#line 56 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\UpdateFatConsumptionOrder.cshtml"
WriteAttributeValue("", 4684, item.i, 4684, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 4691, "].Effected", 4691, 10, true);
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 4702, "\"", 4733, 3);
            WriteAttributeValue("", 4712, "GetID(", 4712, 6, true);
#line 56 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\UpdateFatConsumptionOrder.cshtml"
WriteAttributeValue("", 4718, item.value.ID, 4718, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 4732, ")", 4732, 1, true);
            EndWriteAttribute();
            BeginContext(4734, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(4736, 46, false);
#line 56 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\UpdateFatConsumptionOrder.cshtml"
                                                                                                                                                                                                                                                               Write(Html.Raw(item.value.Effected ? "checked" : ""));

#line default
#line hidden
            EndContext();
            BeginContext(4782, 277, true);
            WriteLiteral(@" value=""true""><span class=""label-text""></span></label></div>
                                                            </td>
                                                            <td>
                                                                <input type=""text""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5059, "\"", 5119, 3);
            WriteAttributeValue("", 5064, "PatientOrderFatConsumptionList[", 5064, 31, true);
#line 59 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\UpdateFatConsumptionOrder.cshtml"
WriteAttributeValue("", 5095, item.i, 5095, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 5102, "].Reccomendations", 5102, 17, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 5120, "\"", 5182, 3);
            WriteAttributeValue("", 5127, "PatientOrderFatConsumptionList[", 5127, 31, true);
#line 59 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\UpdateFatConsumptionOrder.cshtml"
WriteAttributeValue("", 5158, item.i, 5158, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 5165, "].Reccomendations", 5165, 17, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 5183, "\"", 5218, 1);
#line 59 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\UpdateFatConsumptionOrder.cshtml"
WriteAttributeValue("", 5191, item.value.Reccomendations, 5191, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5219, 154, true);
            WriteLiteral(" class=\"form-control\">\r\n                                                            </td>\r\n                                                        </tr>\r\n");
            EndContext();
#line 62 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\UpdateFatConsumptionOrder.cshtml"
                                                    }

#line default
#line hidden
            BeginContext(5428, 580, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Data.Models.PatientOrderFatConsumption>> Html { get; private set; }
    }
}
#pragma warning restore 1591