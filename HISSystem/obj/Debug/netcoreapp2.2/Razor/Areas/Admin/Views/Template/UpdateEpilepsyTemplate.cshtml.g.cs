#pragma checksum "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Template\UpdateEpilepsyTemplate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01a6694162df44523c5a9dd74da028bb5d826f00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Template_UpdateEpilepsyTemplate), @"mvc.1.0.view", @"/Areas/Admin/Views/Template/UpdateEpilepsyTemplate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Template/UpdateEpilepsyTemplate.cshtml", typeof(AspNetCore.Areas_Admin_Views_Template_UpdateEpilepsyTemplate))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01a6694162df44523c5a9dd74da028bb5d826f00", @"/Areas/Admin/Views/Template/UpdateEpilepsyTemplate.cshtml")]
    public class Areas_Admin_Views_Template_UpdateEpilepsyTemplate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Models.EpilepsyTemplate>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(41, 66, true);
            WriteLiteral("\r\n<div class=\"modal-dialog modal-lg\">\r\n    <!-- Modal content-->\r\n");
            EndContext();
#line 7 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Template\UpdateEpilepsyTemplate.cshtml"
     using (Html.BeginForm("AddEpilpsyTemplates", "SMS", FormMethod.Post, new { enctype = "multipart/form-data", id = "createForm" }))
    {

#line default
#line hidden
            BeginContext(250, 624, true);
            WriteLiteral(@"        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                <center><h4 class=""modal-title"">New Template</h4></center>
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
            BeginContext(875, 144, false);
#line 21 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Template\UpdateEpilepsyTemplate.cshtml"
                               Write(Html.DropDownListFor(model => model.GeneID, new SelectList(ViewBag.Gene, "ID", "Name"), "Select Gene", new { @class = "form-control dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(1019, 229, true);
            WriteLiteral("\r\n\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-md-6\">\r\n                                <label>Genetic Mutation</label>\r\n                                ");
            EndContext();
            BeginContext(1249, 23, false);
#line 27 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Template\UpdateEpilepsyTemplate.cshtml"
                           Write(Html.HiddenFor(x=>x.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1272, 96, true);
            WriteLiteral("\r\n                                <div class=\"form-group\">\r\n                                    ");
            EndContext();
            BeginContext(1369, 119, false);
#line 29 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Template\UpdateEpilepsyTemplate.cshtml"
                               Write(Html.TextBoxFor(model => model.GeneticMutation, new { @class = "form-control", placeholder = "GeneticMutation. . . " }));

#line default
#line hidden
            EndContext();
            BeginContext(1488, 370, true);
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
            BeginContext(1859, 127, false);
#line 38 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Template\UpdateEpilepsyTemplate.cshtml"
                               Write(Html.TextBoxFor(model => model.PersonalRiskFactor, new { @class = "form-control", placeholder = "Personal Risk Factor. . . " }));

#line default
#line hidden
            EndContext();
            BeginContext(1986, 285, true);
            WriteLiteral(@"

                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <label>Herdiatery</label>
                                <div class=""form-group"">
                                    ");
            EndContext();
            BeginContext(2272, 109, false);
#line 45 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Template\UpdateEpilepsyTemplate.cshtml"
                               Write(Html.TextBoxFor(model => model.Hereditary, new { @class = "form-control", placeholder = "Herdiatery. . . " }));

#line default
#line hidden
            EndContext();
            BeginContext(2381, 367, true);
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
            BeginContext(2749, 119, false);
#line 55 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Template\UpdateEpilepsyTemplate.cshtml"
                               Write(Html.TextBoxFor(model => model.Recommendations, new { @class = "form-control", placeholder = "Recommendations. . . " }));

#line default
#line hidden
            EndContext();
            BeginContext(2868, 247, true);
            WriteLiteral("\r\n\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"form-group pad-tb-md\">\r\n                                <div class=\"form-check\">\r\n                                    <label>\r\n");
            EndContext();
            BeginContext(3220, 101, true);
            WriteLiteral("                                        <input type=\"checkbox\" name=\"HaveMutation\" id=\"HaveMutation\" ");
            EndContext();
            BeginContext(3323, 43, false);
#line 63 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Template\UpdateEpilepsyTemplate.cshtml"
                                                                                                 Write(Model.HaveMutation == true ? "checked" : "");

#line default
#line hidden
            EndContext();
            BeginContext(3367, 602, true);
            WriteLiteral(@"><span class=""label-text"">Have Mutation</span>
                                    </label>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" data-dismiss=""modal"" class=""btn btn-outline-inverse"">Cancel</button>
                    <button type=""button"" onclick=""UpdateEpilepsyTemplate();"" class=""btn btn-danger popup-savebtn"">Update</button>
                </div>
            </div>
        </div>
");
            EndContext();
#line 76 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Template\UpdateEpilepsyTemplate.cshtml"
    }

#line default
#line hidden
            BeginContext(3976, 17, true);
            WriteLiteral("</div>\r\n\r\n\r\n<link");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3993, "\"", 4065, 1);
#line 80 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Template\UpdateEpilepsyTemplate.cshtml"
WriteAttributeValue("", 4000, Url.Content("https://fonts.googleapis.com/css?family=Open+Sans"), 4000, 65, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4066, 43, true);
            WriteLiteral(" rel=\'stylesheet\' type=\'text/css\'>\r\n<script");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4109, "\"", 4167, 1);
#line 81 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Template\UpdateEpilepsyTemplate.cshtml"
WriteAttributeValue("", 4115, Url.Content("~/assets/Themes/ckeditor/ckeditor.js"), 4115, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4168, 90, true);
            WriteLiteral(" type=\"text/javascript\"></script>\r\n<script>\r\n\t//CKEDITOR.replace(\"Body\");\r\n</script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Models.EpilepsyTemplate> Html { get; private set; }
    }
}
#pragma warning restore 1591
