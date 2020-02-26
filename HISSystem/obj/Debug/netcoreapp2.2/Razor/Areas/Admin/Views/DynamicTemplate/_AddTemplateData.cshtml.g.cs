#pragma checksum "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\DynamicTemplate\_AddTemplateData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f8a694821bffacc3ca0507e75f16c8e11f13a46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_DynamicTemplate__AddTemplateData), @"mvc.1.0.view", @"/Areas/Admin/Views/DynamicTemplate/_AddTemplateData.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/DynamicTemplate/_AddTemplateData.cshtml", typeof(AspNetCore.Areas_Admin_Views_DynamicTemplate__AddTemplateData))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f8a694821bffacc3ca0507e75f16c8e11f13a46", @"/Areas/Admin/Views/DynamicTemplate/_AddTemplateData.cshtml")]
    public class Areas_Admin_Views_DynamicTemplate__AddTemplateData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GeneticSystem.Areas.Admin.Models.AddDynamicTemplate>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 267, true);
            WriteLiteral(@"
<form action=""/admin/lookup/addmaster"" method=""post"" id=""addTemplateDetailFrm"">
    <div class=""row"">
        <div class=""col-md-5 col-sm-5 col-xs-12"">
            <button type=""button"" class=""btn btn-xs btn-outline-warning add-btn addTemplateDetail"" data-info=""");
            EndContext();
            BeginContext(328, 18, false);
#line 6 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\DynamicTemplate\_AddTemplateData.cshtml"
                                                                                                         Write(ViewBag.TemplateID);

#line default
#line hidden
            EndContext();
            BeginContext(346, 94, true);
            WriteLiteral("\">\r\n                <i class=\"fa fa-plus\" aria-hidden=\"true\"></i>\r\n                &nbsp;Save ");
            EndContext();
            BeginContext(441, 34, false);
#line 8 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\DynamicTemplate\_AddTemplateData.cshtml"
                      Write(Model.Template?.TemplateType?.Name);

#line default
#line hidden
            EndContext();
            BeginContext(475, 4, true);
            WriteLiteral(" >> ");
            EndContext();
            BeginContext(480, 37, false);
#line 8 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\DynamicTemplate\_AddTemplateData.cshtml"
                                                             Write(Model.Template?.SubTemplateType?.Name);

#line default
#line hidden
            EndContext();
            BeginContext(517, 261, true);
            WriteLiteral(@" Data
            </button>
            <h3 id=""lName""></h3>
        </div>
        <div class=""col-md-9"">
            <table id=""userTbl"" class=""table table-hover table-bordered table-striped"">
                <thead>
                    <tr class="""">
");
            EndContext();
#line 16 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\DynamicTemplate\_AddTemplateData.cshtml"
                         foreach (var item in Model.Template.TemplateColumns)
                        {

#line default
#line hidden
            BeginContext(884, 33, true);
            WriteLiteral("                            <th> ");
            EndContext();
            BeginContext(918, 16, false);
#line 18 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\DynamicTemplate\_AddTemplateData.cshtml"
                            Write(item.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(934, 8, true);
            WriteLiteral(" </th>\r\n");
            EndContext();
#line 19 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\DynamicTemplate\_AddTemplateData.cshtml"
                        }

#line default
#line hidden
            BeginContext(969, 104, true);
            WriteLiteral("                    </tr>\r\n                </thead>\r\n                <tbody>\r\n                    <tr>\r\n");
            EndContext();
#line 24 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\DynamicTemplate\_AddTemplateData.cshtml"
                         foreach (var item in Model.Template.TemplateColumns.Select((value, i) => new { i, value }))
                        {

#line default
#line hidden
            BeginContext(1218, 103, true);
            WriteLiteral("                            <td>\r\n                                <input name=\"TemplateData.TemplateID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1321, "\"", 1347, 1);
#line 27 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\DynamicTemplate\_AddTemplateData.cshtml"
WriteAttributeValue("", 1329, Model.Template.ID, 1329, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1348, 10, true);
            WriteLiteral(" hidden>\r\n");
            EndContext();
#line 28 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\DynamicTemplate\_AddTemplateData.cshtml"
                                 if (item.value.TemplateField.Name == "EffectedGene")
                                {
                                    

#line default
#line hidden
            BeginContext(1517, 178, false);
#line 30 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\DynamicTemplate\_AddTemplateData.cshtml"
                               Write(Html.ListBox("TemplateData.Genes", new MultiSelectList(ViewBag.EffectedGene, "ID", "Name"), htmlAttributes: new { @class = "tryMultiselect form-control", multiple = "multiple" }));

#line default
#line hidden
            EndContext();
#line 30 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\DynamicTemplate\_AddTemplateData.cshtml"
                                                                                                                                                                                                                       
                                }
                                else if (item.value.TemplateField.Name == "ConsumptionType")
                                {
                                    

#line default
#line hidden
            BeginContext(1898, 175, false);
#line 34 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\DynamicTemplate\_AddTemplateData.cshtml"
                               Write(Html.DropDownList("TemplateData.ConsumptionTypeID", new SelectList(ViewBag.ConsumptionType, "ID", "Name"), "Select Consumption Type", new { @class = "form-control dropdown" }));

#line default
#line hidden
            EndContext();
#line 34 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\DynamicTemplate\_AddTemplateData.cshtml"
                                                                                                                                                                                                                    
                                }
                                else if (item.value.TemplateField.Name == "Element")
                                {
                                    

#line default
#line hidden
            BeginContext(2268, 155, false);
#line 38 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\DynamicTemplate\_AddTemplateData.cshtml"
                               Write(Html.DropDownList("TemplateData.ElementID", new SelectList(ViewBag.Element, "ID", "Name"), "Select Element Type", new { @class = "form-control dropdown" }));

#line default
#line hidden
            EndContext();
#line 38 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\DynamicTemplate\_AddTemplateData.cshtml"
                                                                                                                                                                                                
                                }
                                else if (item.value.TemplateField.Name == "Result")
                                {
                                    

#line default
#line hidden
            BeginContext(2617, 157, false);
#line 42 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\DynamicTemplate\_AddTemplateData.cshtml"
                               Write(Html.DropDownList("TemplateData.Result", new SelectList(ViewBag.EffectedGenes, "ID", "Name"), "Select Result Type", new { @class = "form-control dropdown" }));

#line default
#line hidden
            EndContext();
#line 42 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\DynamicTemplate\_AddTemplateData.cshtml"
                                                                                                                                                                                                  

                                }
                                else if (item.value.TemplateField.Name == "HaveMutationEffected")
                                {

#line default
#line hidden
            BeginContext(2947, 169, true);
            WriteLiteral("                                    <input type=\"checkbox\" name=\"TemplateData.HaveMutationEffected\" value=\"true\"><span class=\"label-text\">Have Mutation Effected</span>\r\n");
            EndContext();
#line 48 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\DynamicTemplate\_AddTemplateData.cshtml"
                                }
                                else if (item.value.TemplateField.Name == "EffectedGood")
                                {

#line default
#line hidden
            BeginContext(3277, 108, true);
            WriteLiteral("                                    <input name=\"TemplateData.EffectedGood\" class=\"form-control\" value=\"\">\r\n");
            EndContext();
#line 52 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\DynamicTemplate\_AddTemplateData.cshtml"
                                }
                                else if (item.value.TemplateField.Name == "EffectedBad")
                                {

#line default
#line hidden
            BeginContext(3545, 107, true);
            WriteLiteral("                                    <input name=\"TemplateData.EffectedBad\" class=\"form-control\" value=\"\">\r\n");
            EndContext();
#line 56 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\DynamicTemplate\_AddTemplateData.cshtml"
                                }
                                else if (item.value.TemplateField.Name == "GeneticMutation")
                                {

#line default
#line hidden
            BeginContext(3816, 111, true);
            WriteLiteral("                                    <input name=\"TemplateData.GeneticMutation\" class=\"form-control\" value=\"\">\r\n");
            EndContext();
#line 60 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\DynamicTemplate\_AddTemplateData.cshtml"
                                }
                                else if (item.value.TemplateField.Name == "PersonalRiskFactor")
                                {

#line default
#line hidden
            BeginContext(4094, 114, true);
            WriteLiteral("                                    <input name=\"TemplateData.PersonalRiskFactor\" class=\"form-control\" value=\"\">\r\n");
            EndContext();
#line 64 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\DynamicTemplate\_AddTemplateData.cshtml"
                                }
                                else if (item.value.TemplateField.Name == "Hereditary")
                                {

#line default
#line hidden
            BeginContext(4367, 106, true);
            WriteLiteral("                                    <input name=\"TemplateData.Hereditary\" class=\"form-control\" value=\"\">\r\n");
            EndContext();
#line 68 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\DynamicTemplate\_AddTemplateData.cshtml"
                                }
                                else if (item.value.TemplateField.Name == "ResultSummary")
                                {

#line default
#line hidden
            BeginContext(4635, 109, true);
            WriteLiteral("                                    <input name=\"TemplateData.ResultSummary\" class=\"form-control\" value=\"\">\r\n");
            EndContext();
#line 72 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\DynamicTemplate\_AddTemplateData.cshtml"
                                }
                                else if (item.value.TemplateField.Name == "Recommendations")
                                {

#line default
#line hidden
            BeginContext(4908, 110, true);
            WriteLiteral("                                    <input name=\"TemplateData.Recommendation\" class=\"form-control\" value=\"\">\r\n");
            EndContext();
#line 76 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\DynamicTemplate\_AddTemplateData.cshtml"
                                }

#line default
#line hidden
            BeginContext(5053, 35, true);
            WriteLiteral("                            </td>\r\n");
            EndContext();
#line 78 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\DynamicTemplate\_AddTemplateData.cshtml"
                        }

#line default
#line hidden
            BeginContext(5115, 112, true);
            WriteLiteral("                    </tr>\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</form>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GeneticSystem.Areas.Admin.Models.AddDynamicTemplate> Html { get; private set; }
    }
}
#pragma warning restore 1591
