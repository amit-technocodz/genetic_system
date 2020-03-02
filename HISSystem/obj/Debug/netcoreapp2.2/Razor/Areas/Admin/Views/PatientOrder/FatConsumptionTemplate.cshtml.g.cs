#pragma checksum "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\FatConsumptionTemplate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df3b7c2d2a212f566b8b14ae7363d1d86fc89a0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_PatientOrder_FatConsumptionTemplate), @"mvc.1.0.view", @"/Areas/Admin/Views/PatientOrder/FatConsumptionTemplate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/PatientOrder/FatConsumptionTemplate.cshtml", typeof(AspNetCore.Areas_Admin_Views_PatientOrder_FatConsumptionTemplate))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df3b7c2d2a212f566b8b14ae7363d1d86fc89a0c", @"/Areas/Admin/Views/PatientOrder/FatConsumptionTemplate.cshtml")]
    public class Areas_Admin_Views_PatientOrder_FatConsumptionTemplate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GeneticSystem.Areas.Admin.Models.FatConsumptionViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(65, 1695, true);
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
#line 32 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\FatConsumptionTemplate.cshtml"
                                                     foreach (var item in Model.fatconsumptionlist.Select((value, i) => new { i, value }))
                                                    {

#line default
#line hidden
            BeginContext(1955, 128, true);
            WriteLiteral("                                                        <tr>\r\n                                                            <td>\r\n");
            EndContext();
#line 36 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\FatConsumptionTemplate.cshtml"
                                                                 if (item.value.ConsumptionType != null)
                                                                {
                                                                    

#line default
#line hidden
            BeginContext(2325, 379, false);
#line 38 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\FatConsumptionTemplate.cshtml"
                                                               Write(Html.DropDownList("PatientOrderFatConsumptionList[" + @item.i + "].ConsumptionTypeID", new SelectList(ViewBag.ConsumptionType, "ID", "Name", item.value.ConsumptionTypeID), htmlAttributes: new { @class = "form-control dropdown", id = "PatientOrderFatConsumptionList[" + @item.i + "].ConsumptionTypeID", name = "PatientOrderFatConsumptionList[" + @item.i + "].ConsumptionTypeID" }));

#line default
#line hidden
            EndContext();
#line 38 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\FatConsumptionTemplate.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                                                                                
                                                                }

#line default
#line hidden
            BeginContext(2773, 135, true);
            WriteLiteral("\r\n                                                            </td>\r\n                                                            <td>\r\n");
            EndContext();
#line 43 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\FatConsumptionTemplate.cshtml"
                                                                 if (item.value.EffectedGene != null)
                                                                {
                                                                    

#line default
#line hidden
            BeginContext(3147, 363, false);
#line 45 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\FatConsumptionTemplate.cshtml"
                                                               Write(Html.DropDownList("PatientOrderFatConsumptionList[" + @item.i + "].EffectedGeneID", new SelectList(ViewBag.EffectedGenes, "ID", "Name", item.value.EffectedGeneID), htmlAttributes: new { @class = "form-control dropdown", id = "PatientOrderFatConsumptionList[" + @item.i + "].EffectedGeneID", name = "PatientOrderFatConsumptionList[" + @item.i + "].EffectedGene" }));

#line default
#line hidden
            EndContext();
#line 45 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\FatConsumptionTemplate.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                                                                
                                                                }

#line default
#line hidden
            BeginContext(3579, 254, true);
            WriteLiteral("                                                            </td>\r\n                                                            <td>\r\n                                                                    <div class=\"form-check\"><label><input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3833, "\"", 3886, 3);
            WriteAttributeValue("", 3838, "PatientOrderFatConsumptionList[", 3838, 31, true);
#line 49 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\FatConsumptionTemplate.cshtml"
WriteAttributeValue("", 3869, item.i, 3869, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 3876, "].Effected", 3876, 10, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 3887, "\"", 3942, 3);
            WriteAttributeValue("", 3894, "PatientOrderFatConsumptionList[", 3894, 31, true);
#line 49 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\FatConsumptionTemplate.cshtml"
WriteAttributeValue("", 3925, item.i, 3925, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 3932, "].Effected", 3932, 10, true);
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 3943, "\"", 3974, 3);
            WriteAttributeValue("", 3953, "GetID(", 3953, 6, true);
#line 49 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\FatConsumptionTemplate.cshtml"
WriteAttributeValue("", 3959, item.value.ID, 3959, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 3973, ")", 3973, 1, true);
            EndWriteAttribute();
            BeginContext(3975, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3977, 46, false);
#line 49 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\FatConsumptionTemplate.cshtml"
                                                                                                                                                                                                                                                                   Write(Html.Raw(item.value.Effected ? "checked" : ""));

#line default
#line hidden
            EndContext();
            BeginContext(4023, 277, true);
            WriteLiteral(@" value=""true""><span class=""label-text""></span></label></div>
                                                            </td>
                                                            <td>
                                                                <input type=""text""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4300, "\"", 4360, 3);
            WriteAttributeValue("", 4305, "PatientOrderFatConsumptionList[", 4305, 31, true);
#line 52 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\FatConsumptionTemplate.cshtml"
WriteAttributeValue("", 4336, item.i, 4336, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 4343, "].Reccomendations", 4343, 17, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 4361, "\"", 4423, 3);
            WriteAttributeValue("", 4368, "PatientOrderFatConsumptionList[", 4368, 31, true);
#line 52 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\FatConsumptionTemplate.cshtml"
WriteAttributeValue("", 4399, item.i, 4399, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 4406, "].Reccomendations", 4406, 17, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 4424, "\"", 4459, 1);
#line 52 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\FatConsumptionTemplate.cshtml"
WriteAttributeValue("", 4432, item.value.Reccomendations, 4432, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4460, 154, true);
            WriteLiteral(" class=\"form-control\">\r\n                                                            </td>\r\n                                                        </tr>\r\n");
            EndContext();
#line 55 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\FatConsumptionTemplate.cshtml"
                                                    }

#line default
#line hidden
            BeginContext(4669, 578, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GeneticSystem.Areas.Admin.Models.FatConsumptionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
