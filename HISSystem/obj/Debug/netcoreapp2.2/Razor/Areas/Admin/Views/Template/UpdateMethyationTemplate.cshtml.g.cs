#pragma checksum "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Template\UpdateMethyationTemplate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "659f7a2168d40a9eaf50eff23aa5f089274c69d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Template_UpdateMethyationTemplate), @"mvc.1.0.view", @"/Areas/Admin/Views/Template/UpdateMethyationTemplate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Template/UpdateMethyationTemplate.cshtml", typeof(AspNetCore.Areas_Admin_Views_Template_UpdateMethyationTemplate))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"659f7a2168d40a9eaf50eff23aa5f089274c69d1", @"/Areas/Admin/Views/Template/UpdateMethyationTemplate.cshtml")]
    public class Areas_Admin_Views_Template_UpdateMethyationTemplate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Models.MethyationTemplate>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(41, 66, true);
            WriteLiteral("\r\n<div class=\"modal-dialog modal-lg\">\r\n    <!-- Modal content-->\r\n");
            EndContext();
#line 6 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Template\UpdateMethyationTemplate.cshtml"
     using (Html.BeginForm("AddMethayationTemplates", "template", FormMethod.Post, new { enctype = "multipart/form-data", id = "createForm" }))
    {

#line default
#line hidden
            BeginContext(259, 649, true);
            WriteLiteral(@"        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                <center><h4 class=""modal-title"">Update Methyation And Autism Template</h4></center>
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
            BeginContext(909, 23, false);
#line 20 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Template\UpdateMethyationTemplate.cshtml"
                               Write(Html.HiddenFor(x=>x.ID));

#line default
#line hidden
            EndContext();
            BeginContext(932, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(971, 144, false);
#line 21 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Template\UpdateMethyationTemplate.cshtml"
                               Write(Html.DropDownListFor(model => model.GeneID, new SelectList(ViewBag.Gene, "ID", "Name"), "Select Gene", new { @class = "form-control dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(1115, 490, true);
            WriteLiteral(@"

                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <label>Result</label>

                                <div class=""form-group"">
                                    <select class=""form-control dropdown"" id=""Result"" name=""Result"">
                                        <option value=""""> Select Result </option>
                                        <option value=""1"" ");
            EndContext();
            BeginContext(1607, 29, false);
#line 31 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Template\UpdateMethyationTemplate.cshtml"
                                                      Write(Model.Result==1?"selected":"");

#line default
#line hidden
            EndContext();
            BeginContext(1637, 75, true);
            WriteLiteral("> High</option>\r\n                                        <option value=\"2\" ");
            EndContext();
            BeginContext(1714, 29, false);
#line 32 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Template\UpdateMethyationTemplate.cshtml"
                                                      Write(Model.Result==2?"selected":"");

#line default
#line hidden
            EndContext();
            BeginContext(1744, 78, true);
            WriteLiteral("> Medium </option>\r\n                                        <option value=\"3\" ");
            EndContext();
            BeginContext(1824, 29, false);
#line 33 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Template\UpdateMethyationTemplate.cshtml"
                                                      Write(Model.Result==3?"selected":"");

#line default
#line hidden
            EndContext();
            BeginContext(1854, 426, true);
            WriteLiteral(@">Low </option>
                                    </select>

                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <label>Result  Summary</label>
                                <div class=""form-group"">
                                    ");
            EndContext();
            BeginContext(2281, 117, false);
#line 43 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Template\UpdateMethyationTemplate.cshtml"
                               Write(Html.TextAreaFor(model => model.ResultSummary, new { @class = "form-control", placeholder = "Result Summary. . . " }));

#line default
#line hidden
            EndContext();
            BeginContext(2398, 290, true);
            WriteLiteral(@"

                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <label>Recommendations</label>
                                <div class=""form-group"">
                                    ");
            EndContext();
            BeginContext(2689, 120, false);
#line 50 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Template\UpdateMethyationTemplate.cshtml"
                               Write(Html.TextAreaFor(model => model.Recommendations, new { @class = "form-control", placeholder = "Recommendations. . . " }));

#line default
#line hidden
            EndContext();
            BeginContext(2809, 326, true);
            WriteLiteral(@"

                                </div>
                            </div>
                        </div>
                        <div class=""row"">


                            <div class=""form-group pad-tb-md"">
                                <div class=""form-check"">
                                    <label>
");
            EndContext();
            BeginContext(3240, 101, true);
            WriteLiteral("                                        <input type=\"checkbox\" name=\"HaveMutation\" id=\"HaveMutation\" ");
            EndContext();
            BeginContext(3343, 41, false);
#line 62 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Template\UpdateMethyationTemplate.cshtml"
                                                                                                 Write(Model.HaveMutation == true ? "checked":"");

#line default
#line hidden
            EndContext();
            BeginContext(3385, 597, true);
            WriteLiteral(@"><span class=""label-text"">Have Mutation</span>
                                    </label>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" data-dismiss=""modal"" class=""btn btn-outline-inverse"">Cancel</button>
                    <button type=""button"" onclick=""UpdateMethayation();"" class=""btn btn-danger popup-savebtn"">Update</button>
                </div>
            </div>
        </div>
");
            EndContext();
#line 75 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Template\UpdateMethyationTemplate.cshtml"
    }

#line default
#line hidden
            BeginContext(3989, 17, true);
            WriteLiteral("</div>\r\n\r\n\r\n<link");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4006, "\"", 4078, 1);
#line 79 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Template\UpdateMethyationTemplate.cshtml"
WriteAttributeValue("", 4013, Url.Content("https://fonts.googleapis.com/css?family=Open+Sans"), 4013, 65, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4079, 43, true);
            WriteLiteral(" rel=\'stylesheet\' type=\'text/css\'>\r\n<script");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4122, "\"", 4180, 1);
#line 80 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Template\UpdateMethyationTemplate.cshtml"
WriteAttributeValue("", 4128, Url.Content("~/assets/Themes/ckeditor/ckeditor.js"), 4128, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4181, 88, true);
            WriteLiteral(" type=\"text/javascript\"></script>\r\n<script>\r\n\t//CKEDITOR.replace(\"Body\");\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Models.MethyationTemplate> Html { get; private set; }
    }
}
#pragma warning restore 1591
