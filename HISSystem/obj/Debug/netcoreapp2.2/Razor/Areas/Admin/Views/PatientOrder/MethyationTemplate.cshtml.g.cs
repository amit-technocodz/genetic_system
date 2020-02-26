#pragma checksum "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\MethyationTemplate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33fdc73fb419c6289e5feb38d2387fc646d8401f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_PatientOrder_MethyationTemplate), @"mvc.1.0.view", @"/Areas/Admin/Views/PatientOrder/MethyationTemplate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/PatientOrder/MethyationTemplate.cshtml", typeof(AspNetCore.Areas_Admin_Views_PatientOrder_MethyationTemplate))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33fdc73fb419c6289e5feb38d2387fc646d8401f", @"/Areas/Admin/Views/PatientOrder/MethyationTemplate.cshtml")]
    public class Areas_Admin_Views_PatientOrder_MethyationTemplate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GeneticSystem.Areas.Admin.Models.OrderMethyationViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(66, 1771, true);
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
#line 33 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\MethyationTemplate.cshtml"
                                                     foreach (var item in Model.methyationlist.Select((value, i) => new { i, value }))
                                                    {

#line default
#line hidden
            BeginContext(2028, 120, true);
            WriteLiteral("                                                    <tr>\r\n                                                        <td>\r\n");
            EndContext();
#line 37 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\MethyationTemplate.cshtml"
                                                             if (item.value.Gene != null)
                                                            {
                                                                

#line default
#line hidden
            BeginContext(2367, 319, false);
#line 39 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\MethyationTemplate.cshtml"
                                                           Write(Html.DropDownList("PatientOrderMethyationList[" + @item.i + "].GeneID", new SelectList(ViewBag.EffectedGenes, "ID", "Name", item.value.GeneID), htmlAttributes: new { @class = "form-control dropdown", id = "PatientOrderMethyationList[" + @item.i + "].GeneID", name = "PatientOrderMethyationList[" + @item.i + "].Gene" }));

#line default
#line hidden
            EndContext();
#line 39 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\MethyationTemplate.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                
                                                            }

#line default
#line hidden
            BeginContext(2751, 244, true);
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                                <div class=\"form-check\"><label><input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2995, "\"", 3048, 3);
            WriteAttributeValue("", 3000, "PatientOrderMethyationList[", 3000, 27, true);
#line 44 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\MethyationTemplate.cshtml"
WriteAttributeValue("", 3027, item.i, 3027, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 3034, "].HaveMutation", 3034, 14, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 3049, "\"", 3104, 3);
            WriteAttributeValue("", 3056, "PatientOrderMethyationList[", 3056, 27, true);
#line 44 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\MethyationTemplate.cshtml"
WriteAttributeValue("", 3083, item.i, 3083, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 3090, "].HaveMutation", 3090, 14, true);
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 3105, "\"", 3136, 3);
            WriteAttributeValue("", 3115, "GetID(", 3115, 6, true);
#line 44 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\MethyationTemplate.cshtml"
WriteAttributeValue("", 3121, item.value.ID, 3121, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 3135, ")", 3135, 1, true);
            EndWriteAttribute();
            BeginContext(3137, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3139, 50, false);
#line 44 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\MethyationTemplate.cshtml"
                                                                                                                                                                                                                                                               Write(Html.Raw(item.value.HaveMutation ? "checked" : ""));

#line default
#line hidden
            EndContext();
            BeginContext(3189, 248, true);
            WriteLiteral(" value=\"true\"><span class=\"label-text\"></span></label></div>\r\n                                                           \r\n                                                        </td>\r\n                                                        <td>\r\n");
            EndContext();
#line 48 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\MethyationTemplate.cshtml"
                                                             if (item.value.Result != null)
                                                            {
                                                                

#line default
#line hidden
            BeginContext(3658, 196, false);
#line 50 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\MethyationTemplate.cshtml"
                                                           Write(Html.DropDownList("PatientOrderMethyationList[" + @item.i + "].Result", new SelectList(ViewBag.Result, "Value", "Text", item.value.Result), htmlAttributes: new { @class = "form-control dropdown"}));

#line default
#line hidden
            EndContext();
#line 50 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\MethyationTemplate.cshtml"
                                                                                                                                                                                                                                                                     

                                                            }

#line default
#line hidden
            BeginContext(3921, 203, true);
            WriteLiteral("                                                        </td>\r\n                                                        <td>\r\n                                                            <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4124, "\"", 4178, 3);
            WriteAttributeValue("", 4129, "PatientOrderMethyationList[", 4129, 27, true);
#line 55 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\MethyationTemplate.cshtml"
WriteAttributeValue("", 4156, item.i, 4156, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 4163, "].ResultSummary", 4163, 15, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 4179, "\"", 4235, 3);
            WriteAttributeValue("", 4186, "PatientOrderMethyationList[", 4186, 27, true);
#line 55 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\MethyationTemplate.cshtml"
WriteAttributeValue("", 4213, item.i, 4213, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 4220, "].ResultSummary", 4220, 15, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 4236, "\"", 4269, 1);
#line 55 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\MethyationTemplate.cshtml"
WriteAttributeValue("", 4244, item.value.ResultSummary, 4244, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4270, 227, true);
            WriteLiteral(" class=\"form-control\">\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4497, "\"", 4553, 3);
            WriteAttributeValue("", 4502, "PatientOrderMethyationList[", 4502, 27, true);
#line 58 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\MethyationTemplate.cshtml"
WriteAttributeValue("", 4529, item.i, 4529, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 4536, "].Recommendations", 4536, 17, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 4554, "\"", 4612, 3);
            WriteAttributeValue("", 4561, "PatientOrderMethyationList[", 4561, 27, true);
#line 58 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\MethyationTemplate.cshtml"
WriteAttributeValue("", 4588, item.i, 4588, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 4595, "].Recommendations", 4595, 17, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 4613, "\"", 4648, 1);
#line 58 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\MethyationTemplate.cshtml"
WriteAttributeValue("", 4621, item.value.Recommendations, 4621, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4649, 146, true);
            WriteLiteral(" class=\"form-control\">\r\n                                                        </td>\r\n                                                    </tr>\r\n");
            EndContext();
#line 61 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\PatientOrder\MethyationTemplate.cshtml"
                                                    }

#line default
#line hidden
            BeginContext(4850, 578, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GeneticSystem.Areas.Admin.Models.OrderMethyationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
