#pragma checksum "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\User\ChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95a82576db4e721f5d7bfc958618e88bec750b80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_ChangePassword), @"mvc.1.0.view", @"/Areas/Admin/Views/User/ChangePassword.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/User/ChangePassword.cshtml", typeof(AspNetCore.Areas_Admin_Views_User_ChangePassword))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95a82576db4e721f5d7bfc958618e88bec750b80", @"/Areas/Admin/Views/User/ChangePassword.cshtml")]
    public class Areas_Admin_Views_User_ChangePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HISSystem.Models.ChangePassword>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 425, true);
            WriteLiteral(@"
    <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLongTitle"">Change password</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
            <span aria-hidden=""true"">&times;</span>
        </button>
    </div>
    <div class=""modal-body"">
        <div class=""row mrgn-b-sm"">
            <div class=""col-md-6"">
                <label>Email: &nbsp; ");
            EndContext();
            BeginContext(466, 11, false);
#line 12 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\User\ChangePassword.cshtml"
                                Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(477, 105, true);
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                <label>UserName:&nbsp; ");
            EndContext();
            BeginContext(583, 14, false);
#line 15 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\User\ChangePassword.cshtml"
                                  Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(597, 173, true);
            WriteLiteral("</label>\r\n            </div>\r\n        </div>\r\n        <div class=\"row mrgn-b-sm\">\r\n            <div class=\"col-md-12\">\r\n                    <label>Current Password</label>\r\n");
            EndContext();
            BeginContext(872, 302, true);
            WriteLiteral(@"                <input type=""text"" name=""CurrentPassword"" id=""CurrentPassword"" class=""form-control"" />
                <span id=""pass"" style=""color:red;""></span>
            </div>
        </div>

        <div class=""row mrgn-b-sm"">
            <div class=""col-md-12 mrgn-b-sm"">
                ");
            EndContext();
            BeginContext(1175, 25, false);
#line 29 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\User\ChangePassword.cshtml"
           Write(Html.HiddenFor(m => m.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1200, 71, true);
            WriteLiteral("\r\n                    <label>New Password</label>\r\n                    ");
            EndContext();
            BeginContext(1272, 74, false);
#line 31 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\User\ChangePassword.cshtml"
               Write(Html.TextBoxFor(m => m.NewPassword, null, new { @Class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1346, 132, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-12\">\r\n                    <label>Confirm Password</label>\r\n                    ");
            EndContext();
            BeginContext(1479, 78, false);
#line 35 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\User\ChangePassword.cshtml"
               Write(Html.TextBoxFor(m => m.ConfirmPassword, null, new { @Class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1557, 298, true);
            WriteLiteral(@"
            </div>
        </div>

    </div>
    <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
        <button type=""button"" class=""btn btn-primary"" onclick=""savechangepassword();"">Save changes</button>
    </div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HISSystem.Models.ChangePassword> Html { get; private set; }
    }
}
#pragma warning restore 1591
