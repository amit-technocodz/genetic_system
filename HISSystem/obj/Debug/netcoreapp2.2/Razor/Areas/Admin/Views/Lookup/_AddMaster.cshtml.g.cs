#pragma checksum "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Lookup\_AddMaster.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96c7a762c85fd2e1d692988f0ff5edcebd22b76b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Lookup__AddMaster), @"mvc.1.0.view", @"/Areas/Admin/Views/Lookup/_AddMaster.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Lookup/_AddMaster.cshtml", typeof(AspNetCore.Areas_Admin_Views_Lookup__AddMaster))]
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
#line 2 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Lookup\_AddMaster.cshtml"
using Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96c7a762c85fd2e1d692988f0ff5edcebd22b76b", @"/Areas/Admin/Views/Lookup/_AddMaster.cshtml")]
    public class Areas_Admin_Views_Lookup__AddMaster : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Models.Lookup>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 1118, true);
            WriteLiteral(@"
<form action=""/admin/lookup/addmaster"" method=""post"" id=""addMasterLookUp"">
    <div class=""prtm-content"">
        <div class=""row mrgn-b-sm"">
            <div class=""col-md-4 col-lg-4"">
                <input type=""button"" name=""submit"" id=""SaveLookup"" onclick=""SaveMasterLookup();"" value=""Save"" class=""btn btn-primary"" />
                <input type=""button"" id=""closeModal"" name=""submit"" value=""Back"" class=""btn btn-warning"" />
            </div>
            <div class=""col-md-4 col-lg-4"">
            </div>
            <div class=""col-md-4 col-lg-4"">
            </div>
        </div>
        <div class=""form-style"">
            <div class=""row"">
                <div class=""col-md-12 col-lg-12"">
                    <div class=""prtm-block pos-relative"">
                        <div class=""row"">
                            <div class=""col-md-8 col-lg-8"">
                                <div class=""row mrgn-l-md"">
                                    <div class=""form-group"">
                  ");
            WriteLiteral("                      <label for=\"Type\">Type</label>\r\n                                        ");
            EndContext();
            BeginContext(1166, 113, false);
#line 25 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Lookup\_AddMaster.cshtml"
                                   Write(Html.TextBoxFor(m => m.Type, null, new { @Class = "form-control", autocomplete = "off", required = "required"  }));

#line default
#line hidden
            EndContext();
            BeginContext(1279, 224, true);
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"form-group\">\r\n                                        <label for=\"TypeID\">TypeID</label>\r\n                                        ");
            EndContext();
            BeginContext(1504, 87, false);
#line 29 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Lookup\_AddMaster.cshtml"
                                   Write(Html.TextBoxFor(m => m.TypeID, null, new { @Class = "form-control", @readonly = true }));

#line default
#line hidden
            EndContext();
            BeginContext(1591, 220, true);
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"form-group\">\r\n                                        <label for=\"Name\">Name</label>\r\n                                        ");
            EndContext();
            BeginContext(1812, 112, false);
#line 33 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Lookup\_AddMaster.cshtml"
                                   Write(Html.TextBoxFor(m => m.Name, null, new { @Class = "form-control", autocomplete = "off", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(1924, 265, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</form>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Models.Lookup> Html { get; private set; }
    }
}
#pragma warning restore 1591
