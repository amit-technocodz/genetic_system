#pragma checksum "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Email\AddTriggerEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f9825ad8ae25fe641b3b7bb8ef1f77ee63e70f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Email_AddTriggerEmail), @"mvc.1.0.view", @"/Areas/Admin/Views/Email/AddTriggerEmail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Email/AddTriggerEmail.cshtml", typeof(AspNetCore.Areas_Admin_Views_Email_AddTriggerEmail))]
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
#line 4 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Email\AddTriggerEmail.cshtml"
using Data.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f9825ad8ae25fe641b3b7bb8ef1f77ee63e70f7", @"/Areas/Admin/Views/Email/AddTriggerEmail.cshtml")]
    public class Areas_Admin_Views_Email_AddTriggerEmail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Models.EmailTrigger>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(58, 66, true);
            WriteLiteral("\r\n<div class=\"modal-dialog modal-md\">\r\n    <!-- Modal content-->\r\n");
            EndContext();
#line 8 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Email\AddTriggerEmail.cshtml"
     using (Html.BeginForm("AddTriggerEmails", "Email", FormMethod.Post, new { enctype = "multipart/form-data", id = "createForm" }))
    {

#line default
#line hidden
            BeginContext(266, 541, true);
            WriteLiteral(@"        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                <center>
                    <h4 class=""modal-title"">
                        Trigger Email
                    </h4>
                </center>
            </div>
            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""col-md-6"">
                        <h4>Trigger Name</h4>
                        ");
            EndContext();
            BeginContext(808, 33, false);
#line 23 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Email\AddTriggerEmail.cshtml"
                   Write(Html.HiddenFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(841, 80, true);
            WriteLiteral("\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(922, 138, false);
#line 25 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Email\AddTriggerEmail.cshtml"
                       Write(Html.DropDownList("TriggerName", Html.GetEnumSelectList<EmailTriggerType>(), "Trigger to", new { @class = "form-control  chosen-select" }));

#line default
#line hidden
            EndContext();
            BeginContext(1060, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1091, 89, false);
#line 26 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Email\AddTriggerEmail.cshtml"
                       Write(Html.ValidationMessageFor(model => model.TriggerName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1180, 227, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-6\">\r\n                        <h4>Template</h4>\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(1408, 159, false);
#line 32 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Email\AddTriggerEmail.cshtml"
                       Write(Html.DropDownListFor(model => model.EmailID, new SelectList(ViewBag.AllEmails, "ID", "Name"), "Select Template", new { @class = "form-control chosen-select" }));

#line default
#line hidden
            EndContext();
            BeginContext(1567, 381, true);
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" data-dismiss=""modal"" class=""btn btn-outline-inverse"">Cancel</button>
                <button type=""submit"" class=""btn btn-warning popup-savebtn"">Save</button>
            </div>
        </div>
");
            EndContext();
#line 42 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Email\AddTriggerEmail.cshtml"
    }

#line default
#line hidden
            BeginContext(1955, 12, true);
            WriteLiteral("</div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(2385, 84, true);
            WriteLiteral("\r\n<style>\r\n    .chosen-container {\r\n        width: 100% !important;\r\n    }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Models.EmailTrigger> Html { get; private set; }
    }
}
#pragma warning restore 1591
