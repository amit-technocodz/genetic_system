#pragma checksum "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ViewControl\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e06c7f4a469ebff301c8b2ba7da3932951dcb431"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ViewControl_Add), @"mvc.1.0.view", @"/Areas/Admin/Views/ViewControl/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/ViewControl/Add.cshtml", typeof(AspNetCore.Areas_Admin_Views_ViewControl_Add))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e06c7f4a469ebff301c8b2ba7da3932951dcb431", @"/Areas/Admin/Views/ViewControl/Add.cshtml")]
    public class Areas_Admin_Views_ViewControl_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Models.ViewControl>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ViewControl\Add.cshtml"
 using (Html.BeginForm("Add", "ViewControl", FormMethod.Post))
{

#line default
#line hidden
            BeginContext(99, 467, true);
            WriteLiteral(@"    <div class=""modal-header"">
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
        <h4 class=""modal-title"">Add View Control</h4>
        <div asp-validation-summary=""All"" class=""text-danger""></div>
    </div>
    <div class=""modal-body"">
        <div class=""row"">
            <div class=""col-md-6"">
                <div class=""form-group"">
                    <label>Name</label>
                    ");
            EndContext();
            BeginContext(567, 59, false);
#line 14 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ViewControl\Add.cshtml"
               Write(Html.TextBox("Name", null, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(626, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(649, 62, false);
#line 15 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ViewControl\Add.cshtml"
               Write(Html.ValidationMessage("Name", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(711, 175, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <div class=\"form-check\">\r\n                        <label>\r\n                            ");
            EndContext();
            BeginContext(887, 31, false);
#line 20 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ViewControl\Add.cshtml"
                       Write(Html.CheckBox("IsActive", null));

#line default
#line hidden
            EndContext();
            BeginContext(918, 125, true);
            WriteLiteral(" <span class=\"label-text\">IsActive</span>\r\n                        </label>\r\n                    </div>\r\n                    ");
            EndContext();
            BeginContext(1044, 66, false);
#line 23 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ViewControl\Add.cshtml"
               Write(Html.ValidationMessage("IsActive", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1110, 184, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                <div class=\"form-group\">\r\n                    <label>Uri</label>\r\n                    ");
            EndContext();
            BeginContext(1295, 58, false);
#line 29 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ViewControl\Add.cshtml"
               Write(Html.TextBox("Uri", null, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1353, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1376, 61, false);
#line 30 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ViewControl\Add.cshtml"
               Write(Html.ValidationMessage("Uri", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1437, 286, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
    <div class=""modal-footer"">
        <button type=""button"" data-dismiss=""modal"" class=""btn btn-outline-inverse"">Close</button>
        <button type=""submit"" class=""btn btn-primary"">Save</button>
    </div>
");
            EndContext();
#line 39 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ViewControl\Add.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Models.ViewControl> Html { get; private set; }
    }
}
#pragma warning restore 1591
