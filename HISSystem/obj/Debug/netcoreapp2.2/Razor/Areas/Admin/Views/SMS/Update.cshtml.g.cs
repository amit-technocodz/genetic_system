#pragma checksum "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d2a67799d469fb0ecd7a779f085c910e181eeba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SMS_Update), @"mvc.1.0.view", @"/Areas/Admin/Views/SMS/Update.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/SMS/Update.cshtml", typeof(AspNetCore.Areas_Admin_Views_SMS_Update))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d2a67799d469fb0ecd7a779f085c910e181eeba", @"/Areas/Admin/Views/SMS/Update.cshtml")]
    public class Areas_Admin_Views_SMS_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Models.SMS>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(28, 66, true);
            WriteLiteral("\r\n<div class=\"modal-dialog modal-lg\">\r\n    <!-- Modal content-->\r\n");
            EndContext();
#line 7 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\Update.cshtml"
     using (Html.BeginForm("Update", "SMS", FormMethod.Post, new { enctype = "multipart/form-data", id = "createForm" }))
    {

#line default
#line hidden
            BeginContext(224, 509, true);
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
                                ");
            EndContext();
            BeginContext(734, 25, false);
#line 19 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\Update.cshtml"
                           Write(Html.HiddenFor(x => x.ID));

#line default
#line hidden
            EndContext();
            BeginContext(759, 143, true);
            WriteLiteral("\r\n                                <h4>Name</h4>\r\n                                <div class=\"form-group\">\r\n                                    ");
            EndContext();
            BeginContext(903, 97, false);
#line 22 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\Update.cshtml"
                               Write(Html.TextBoxFor(model => model.Name, new { @class = "form-control", placeholder = "Name. . . " }));

#line default
#line hidden
            EndContext();
            BeginContext(1000, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(1039, 82, false);
#line 23 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\Update.cshtml"
                               Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1121, 298, true);
            WriteLiteral(@"
                                </div>
                            </div>
                            
                    </div>
                    <div class=""col-md-12"">
                        <h4>Body</h4>
                        <div class=""form-group"">
                            ");
            EndContext();
            BeginContext(1420, 84, false);
#line 31 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\Update.cshtml"
                       Write(Html.TextAreaFor(model => model.Body, new { @class = "form-control", @rows = "20" }));

#line default
#line hidden
            EndContext();
            BeginContext(1504, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1535, 82, false);
#line 32 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\Update.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1617, 401, true);
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
            </div>
");
            EndContext();
#line 43 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\Update.cshtml"
    }

#line default
#line hidden
            BeginContext(2025, 15, true);
            WriteLiteral("</div>\r\n\r\n<link");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2040, "\"", 2112, 1);
#line 46 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\Update.cshtml"
WriteAttributeValue("", 2047, Url.Content("https://fonts.googleapis.com/css?family=Open+Sans"), 2047, 65, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2113, 43, true);
            WriteLiteral(" rel=\'stylesheet\' type=\'text/css\'>\r\n<script");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2156, "\"", 2214, 1);
#line 47 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\Update.cshtml"
WriteAttributeValue("", 2162, Url.Content("~/assets/Themes/ckeditor/ckeditor.js"), 2162, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2215, 88, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Models.SMS> Html { get; private set; }
    }
}
#pragma warning restore 1591