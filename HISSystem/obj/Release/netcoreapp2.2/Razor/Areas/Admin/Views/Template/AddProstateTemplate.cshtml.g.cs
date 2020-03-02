#pragma checksum "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\AddProstateTemplate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e72d248798a7862d71695d39982494b9e38afd1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Template_AddProstateTemplate), @"mvc.1.0.view", @"/Areas/Admin/Views/Template/AddProstateTemplate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Template/AddProstateTemplate.cshtml", typeof(AspNetCore.Areas_Admin_Views_Template_AddProstateTemplate))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e72d248798a7862d71695d39982494b9e38afd1a", @"/Areas/Admin/Views/Template/AddProstateTemplate.cshtml")]
    public class Areas_Admin_Views_Template_AddProstateTemplate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Models.ProstateTemplate>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 66, true);
            WriteLiteral("\r\n<div class=\"modal-dialog modal-lg\">\r\n    <!-- Modal content-->\r\n");
            EndContext();
#line 5 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\AddProstateTemplate.cshtml"
     using (Html.BeginForm("AddProstateTemplate", "SMS", FormMethod.Post, new { enctype = "multipart/form-data", id = "createForm" }))
    {

#line default
#line hidden
            BeginContext(246, 630, true);
            WriteLiteral(@"        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                <center><h4 class=""modal-title""> Prostate Template</h4></center>
            </div>
            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <label>Gene</label>
                                <div class=""form-group"">
                                    ");
            EndContext();
            BeginContext(877, 144, false);
#line 19 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\AddProstateTemplate.cshtml"
                               Write(Html.DropDownListFor(model => model.GeneID, new SelectList(ViewBag.Gene, "ID", "Name"), "Select Gene", new { @class = "form-control dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(1021, 293, true);
            WriteLiteral(@"

                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <label>Genetic Mutation</label>

                                <div class=""form-group"">
                                    ");
            EndContext();
            BeginContext(1315, 119, false);
#line 27 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\AddProstateTemplate.cshtml"
                               Write(Html.TextBoxFor(model => model.GeneticMutation, new { @class = "form-control", placeholder = "GeneticMutation. . . " }));

#line default
#line hidden
            EndContext();
            BeginContext(1434, 368, true);
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <label>Personal Risk Factor</label>
                                <div class=""form-group"">
                                    ");
            EndContext();
            BeginContext(1803, 127, false);
#line 35 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\AddProstateTemplate.cshtml"
                               Write(Html.TextBoxFor(model => model.PersonalRiskFactor, new { @class = "form-control", placeholder = "Personal Risk Factor. . . " }));

#line default
#line hidden
            EndContext();
            BeginContext(1930, 285, true);
            WriteLiteral(@"

                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <label>Herdiatery</label>
                                <div class=""form-group"">
                                    ");
            EndContext();
            BeginContext(2216, 109, false);
#line 42 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\AddProstateTemplate.cshtml"
                               Write(Html.TextBoxFor(model => model.Hereditary, new { @class = "form-control", placeholder = "Herdiatery. . . " }));

#line default
#line hidden
            EndContext();
            BeginContext(2325, 367, true);
            WriteLiteral(@"

                                </div>
                            </div>
                        </div>
                        <div class=""row"">

                            <div class=""col-md-6"">
                                <label>Recommendations</label>
                                <div class=""form-group"">
                                    ");
            EndContext();
            BeginContext(2693, 119, false);
#line 52 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\AddProstateTemplate.cshtml"
                               Write(Html.TextBoxFor(model => model.Recommendations, new { @class = "form-control", placeholder = "Recommendations. . . " }));

#line default
#line hidden
            EndContext();
            BeginContext(2812, 938, true);
            WriteLiteral(@"

                                </div>
                            </div>
                            <div class=""form-group pad-tb-md"">
                                <div class=""form-check"">
                                    <label>
                                        <input type=""checkbox"" name=""HaveMutation"" id=""HaveMutation""><span class=""label-text"">Have Mutation</span>
                                    </label>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" data-dismiss=""modal"" class=""btn btn-outline-inverse"">Cancel</button>
                    <button type=""button"" onclick=""SaveProstate();"" class=""btn btn-success popup-savebtn"">Save</button>
                </div>
            </div>
        </div>
");
            EndContext();
#line 72 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\AddProstateTemplate.cshtml"
    }

#line default
#line hidden
            BeginContext(3757, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Models.ProstateTemplate> Html { get; private set; }
    }
}
#pragma warning restore 1591
