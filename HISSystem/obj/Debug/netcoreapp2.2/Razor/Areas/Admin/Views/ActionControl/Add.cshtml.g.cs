#pragma checksum "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ActionControl\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa77c9bd6733354263dc9936bea7b585c4921f80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ActionControl_Add), @"mvc.1.0.view", @"/Areas/Admin/Views/ActionControl/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/ActionControl/Add.cshtml", typeof(AspNetCore.Areas_Admin_Views_ActionControl_Add))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa77c9bd6733354263dc9936bea7b585c4921f80", @"/Areas/Admin/Views/ActionControl/Add.cshtml")]
    public class Areas_Admin_Views_ActionControl_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Models.ActionControl>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ActionControl\Add.cshtml"
 using (Html.BeginForm("Add", "ActionControl", FormMethod.Post))
{

#line default
#line hidden
            BeginContext(105, 469, true);
            WriteLiteral(@"    <div class=""modal-header"">
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
        <h4 class=""modal-title"">Add Action Control</h4>
        <div asp-validation-summary=""All"" class=""text-danger""></div>
    </div>
    <div class=""modal-body"">
        <div class=""row"">
            <div class=""col-md-6"">
                <div class=""form-group"">
                    <label>Name</label>
                    ");
            EndContext();
            BeginContext(575, 59, false);
#line 15 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ActionControl\Add.cshtml"
               Write(Html.TextBox("Name", null, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(634, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(657, 62, false);
#line 16 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ActionControl\Add.cshtml"
               Write(Html.ValidationMessage("Name", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(719, 175, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <div class=\"form-check\">\r\n                        <label>\r\n                            ");
            EndContext();
            BeginContext(895, 31, false);
#line 21 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ActionControl\Add.cshtml"
                       Write(Html.CheckBox("IsActive", null));

#line default
#line hidden
            EndContext();
            BeginContext(926, 125, true);
            WriteLiteral(" <span class=\"label-text\">IsActive</span>\r\n                        </label>\r\n                    </div>\r\n                    ");
            EndContext();
            BeginContext(1052, 66, false);
#line 24 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ActionControl\Add.cshtml"
               Write(Html.ValidationMessage("IsActive", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1118, 299, true);
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
#line 34 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ActionControl\Add.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Models.ActionControl> Html { get; private set; }
    }
}
#pragma warning restore 1591
