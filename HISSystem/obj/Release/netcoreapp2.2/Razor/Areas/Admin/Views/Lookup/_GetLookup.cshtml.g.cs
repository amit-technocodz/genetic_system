#pragma checksum "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Lookup\_GetLookup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e744c9e4c4735fc9636a0c83892100c5c49174fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Lookup__GetLookup), @"mvc.1.0.view", @"/Areas/Admin/Views/Lookup/_GetLookup.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Lookup/_GetLookup.cshtml", typeof(AspNetCore.Areas_Admin_Views_Lookup__GetLookup))]
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
#line 2 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Lookup\_GetLookup.cshtml"
using Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e744c9e4c4735fc9636a0c83892100c5c49174fe", @"/Areas/Admin/Views/Lookup/_GetLookup.cshtml")]
    public class Areas_Admin_Views_Lookup__GetLookup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Models.Lookup>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 912, true);
            WriteLiteral(@"
<form action=""/admin/lookup/GetLookup"" method=""post"" id=""editLookUp"">
    <div class=""prtm-content"">
        <div class=""row mrgn-b-sm"">
            <div class=""col-md-4 col-lg-4"">
                <input type=""submit"" name=""submit"" value=""Update"" class=""btn btn-warning"" />
                <input type=""button"" name=""submit"" value=""Back"" class=""btn btn-info"" />
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
                                    ");
            EndContext();
            BeginContext(960, 25, false);
#line 23 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Lookup\_GetLookup.cshtml"
                               Write(Html.HiddenFor(m => m.ID));

#line default
#line hidden
            EndContext();
            BeginContext(985, 176, true);
            WriteLiteral("\r\n                                    <div class=\"form-group\">\r\n                                        <label for=\"Type\">Type</label>\r\n                                        ");
            EndContext();
            BeginContext(1162, 85, false);
#line 26 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Lookup\_GetLookup.cshtml"
                                   Write(Html.TextBoxFor(m => m.Type, null, new { @Class = "form-control", @readonly = true }));

#line default
#line hidden
            EndContext();
            BeginContext(1247, 224, true);
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"form-group\">\r\n                                        <label for=\"TypeID\">TypeID</label>\r\n                                        ");
            EndContext();
            BeginContext(1472, 87, false);
#line 30 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Lookup\_GetLookup.cshtml"
                                   Write(Html.TextBoxFor(m => m.TypeID, null, new { @Class = "form-control", @readonly = true }));

#line default
#line hidden
            EndContext();
            BeginContext(1559, 220, true);
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"form-group\">\r\n                                        <label for=\"Name\">Name</label>\r\n                                        ");
            EndContext();
            BeginContext(1780, 89, false);
#line 34 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Lookup\_GetLookup.cshtml"
                                   Write(Html.TextBoxFor(m => m.Name, null, new { @Class = "form-control", autocomplete = "off" }));

#line default
#line hidden
            EndContext();
            BeginContext(1869, 229, true);
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"form-group\">\r\n                                        <label for=\"IsActive\">Is Active</label>\r\n                                        ");
            EndContext();
            BeginContext(2099, 95, false);
#line 38 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Lookup\_GetLookup.cshtml"
                                   Write(Html.CheckBoxFor(m => m.IsActive, new { @checked = "checked", style = "right:0px !important" }));

#line default
#line hidden
            EndContext();
            BeginContext(2194, 263, true);
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
