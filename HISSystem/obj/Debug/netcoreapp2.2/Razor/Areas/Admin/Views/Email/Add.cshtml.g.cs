#pragma checksum "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Email\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ded7e668d96b599062b7626870a092fbbba2347d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Email_Add), @"mvc.1.0.view", @"/Areas/Admin/Views/Email/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Email/Add.cshtml", typeof(AspNetCore.Areas_Admin_Views_Email_Add))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ded7e668d96b599062b7626870a092fbbba2347d", @"/Areas/Admin/Views/Email/Add.cshtml")]
    public class Areas_Admin_Views_Email_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Models.Email>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 66, true);
            WriteLiteral("\r\n<div class=\"modal-dialog modal-lg\">\r\n    <!-- Modal content-->\r\n");
            EndContext();
#line 5 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Email\Add.cshtml"
     using (Html.BeginForm("Add", "Email", FormMethod.Post, new { enctype = "multipart/form-data", id = "createForm" }))
    {

#line default
#line hidden
            BeginContext(221, 618, true);
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
                                <h4>Name</h4>
                                <div class=""form-group"">
                                    ");
            EndContext();
            BeginContext(840, 97, false);
#line 19 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Email\Add.cshtml"
                               Write(Html.TextBoxFor(model => model.Name, new { @class = "form-control", placeholder = "Name. . . " }));

#line default
#line hidden
            EndContext();
            BeginContext(937, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(976, 82, false);
#line 20 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Email\Add.cshtml"
                               Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1058, 274, true);
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <h4>Subject</h4>
                                <div class=""form-group"">
                                    ");
            EndContext();
            BeginContext(1333, 103, false);
#line 26 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Email\Add.cshtml"
                               Write(Html.TextBoxFor(model => model.Subject, new { @class = "form-control", placeholder = "Subject . . ." }));

#line default
#line hidden
            EndContext();
            BeginContext(1436, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(1475, 85, false);
#line 27 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Email\Add.cshtml"
                               Write(Html.ValidationMessageFor(model => model.Subject, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1560, 300, true);
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-12"">
                        <h4>Body</h4>
                        <div class=""form-group"">
                            ");
            EndContext();
            BeginContext(1861, 84, false);
#line 35 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Email\Add.cshtml"
                       Write(Html.TextAreaFor(model => model.Body, new { @class = "form-control", @rows = "30" }));

#line default
#line hidden
            EndContext();
            BeginContext(1945, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1976, 82, false);
#line 36 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Email\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2058, 381, true);
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" data-dismiss=""modal"" class=""btn btn-outline-inverse"">Cancel</button>
                <button type=""submit"" class=""btn btn-success popup-savebtn"">Save</button>
            </div>
        </div>
");
            EndContext();
#line 46 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Email\Add.cshtml"
    }

#line default
#line hidden
            BeginContext(2446, 15, true);
            WriteLiteral("</div>\r\n\r\n<link");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2461, "\"", 2533, 1);
#line 49 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Email\Add.cshtml"
WriteAttributeValue("", 2468, Url.Content("https://fonts.googleapis.com/css?family=Open+Sans"), 2468, 65, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2534, 43, true);
            WriteLiteral(" rel=\'stylesheet\' type=\'text/css\'>\r\n<script");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2577, "\"", 2635, 1);
#line 50 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Email\Add.cshtml"
WriteAttributeValue("", 2583, Url.Content("~/assets/Themes/ckeditor/ckeditor.js"), 2583, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2636, 88, true);
            WriteLiteral(" type=\"text/javascript\"></script>\r\n<script>\r\n\tCKEDITOR.replace(\"Body\");\r\n</script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Models.Email> Html { get; private set; }
    }
}
#pragma warning restore 1591
