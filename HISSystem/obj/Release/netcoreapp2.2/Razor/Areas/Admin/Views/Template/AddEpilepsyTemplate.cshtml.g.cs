#pragma checksum "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\AddEpilepsyTemplate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f5174437ec53e12f2998fc8a38d6594c780d3c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Template_AddEpilepsyTemplate), @"mvc.1.0.view", @"/Areas/Admin/Views/Template/AddEpilepsyTemplate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Template/AddEpilepsyTemplate.cshtml", typeof(AspNetCore.Areas_Admin_Views_Template_AddEpilepsyTemplate))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f5174437ec53e12f2998fc8a38d6594c780d3c9", @"/Areas/Admin/Views/Template/AddEpilepsyTemplate.cshtml")]
    public class Areas_Admin_Views_Template_AddEpilepsyTemplate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Models.EpilepsyTemplate>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(39, 66, true);
            WriteLiteral("\r\n<div class=\"modal-dialog modal-lg\">\r\n    <!-- Modal content-->\r\n");
            EndContext();
#line 6 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\AddEpilepsyTemplate.cshtml"
     using (Html.BeginForm("AddEpilpsyTemplates", "SMS", FormMethod.Post, new { enctype = "multipart/form-data", id = "createForm" }))
    {

#line default
#line hidden
            BeginContext(248, 624, true);
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
            BeginContext(873, 144, false);
#line 20 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\AddEpilepsyTemplate.cshtml"
                               Write(Html.DropDownListFor(model => model.GeneID, new SelectList(ViewBag.Gene, "ID", "Name"), "Select Gene", new { @class = "form-control dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(1017, 358, true);
            WriteLiteral(@"
                                 
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <label>Genetic Mutation</label>
                                
                                <div class=""form-group"">
                                    ");
            EndContext();
            BeginContext(1376, 119, false);
#line 28 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\AddEpilepsyTemplate.cshtml"
                               Write(Html.TextBoxFor(model => model.GeneticMutation, new { @class = "form-control", placeholder = "GeneticMutation. . . " }));

#line default
#line hidden
            EndContext();
            BeginContext(1495, 378, true);
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
            BeginContext(1874, 127, false);
#line 37 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\AddEpilepsyTemplate.cshtml"
                                   Write(Html.TextBoxFor(model => model.PersonalRiskFactor, new { @class = "form-control", placeholder = "Personal Risk Factor. . . " }));

#line default
#line hidden
            EndContext();
            BeginContext(2001, 289, true);
            WriteLiteral(@"

                                    </div>
                            </div>
                            <div class=""col-md-6"">
                                <label>Herdiatery</label>
                                <div class=""form-group"">
                                    ");
            EndContext();
            BeginContext(2291, 109, false);
#line 44 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\AddEpilepsyTemplate.cshtml"
                               Write(Html.TextBoxFor(model => model.Hereditary, new { @class = "form-control", placeholder = "Herdiatery. . . " }));

#line default
#line hidden
            EndContext();
            BeginContext(2400, 399, true);
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
            BeginContext(2800, 119, false);
#line 54 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\AddEpilepsyTemplate.cshtml"
                                       Write(Html.TextBoxFor(model => model.Recommendations, new { @class = "form-control", placeholder = "Recommendations. . . " }));

#line default
#line hidden
            EndContext();
            BeginContext(2919, 239, true);
            WriteLiteral("\r\n\r\n                                        </div>\r\n</div>\r\n                                <div class=\"form-group pad-tb-md\">\r\n                                    <div class=\"form-check\">\r\n                                        <label>\r\n");
            EndContext();
            BeginContext(3267, 719, true);
            WriteLiteral(@"                                            <input type=""checkbox"" name=""HaveMutation"" id=""HaveMutation""><span class=""label-text"">Have Mutation</span>
                                        </label>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                <div class=""modal-footer"">
                    <button type=""button"" data-dismiss=""modal"" class=""btn btn-outline-inverse"">Cancel</button>
                    <button type=""button"" onclick=""SaveEpilepsy();"" class=""btn btn-success popup-savebtn"">Save</button>
                </div>
            </div>
        </div>
");
            EndContext();
#line 75 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\AddEpilepsyTemplate.cshtml"
    }

#line default
#line hidden
            BeginContext(3993, 17, true);
            WriteLiteral("</div>\r\n\r\n\r\n<link");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4010, "\"", 4082, 1);
#line 79 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\AddEpilepsyTemplate.cshtml"
WriteAttributeValue("", 4017, Url.Content("https://fonts.googleapis.com/css?family=Open+Sans"), 4017, 65, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4083, 43, true);
            WriteLiteral(" rel=\'stylesheet\' type=\'text/css\'>\r\n<script");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4126, "\"", 4184, 1);
#line 80 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\AddEpilepsyTemplate.cshtml"
WriteAttributeValue("", 4132, Url.Content("~/assets/Themes/ckeditor/ckeditor.js"), 4132, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4185, 88, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Models.EpilepsyTemplate> Html { get; private set; }
    }
}
#pragma warning restore 1591