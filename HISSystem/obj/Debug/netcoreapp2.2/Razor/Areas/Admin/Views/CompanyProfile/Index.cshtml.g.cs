#pragma checksum "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\CompanyProfile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64dc079c132a2d95b139fa7b4fafa9f6bf8cb05d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_CompanyProfile_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/CompanyProfile/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/CompanyProfile/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_CompanyProfile_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64dc079c132a2d95b139fa7b4fafa9f6bf8cb05d", @"/Areas/Admin/Views/CompanyProfile/Index.cshtml")]
    public class Areas_Admin_Views_CompanyProfile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Models.CompanyProfile>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\CompanyProfile\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(89, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(126, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\CompanyProfile\Index.cshtml"
  
    ViewData["Title"] = "Company Profile";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(225, 801, true);
            WriteLiteral(@"<style>
    .border-left {
        border-left: 1px solid black;
    }

    .mg-t {
        margin-top: 10PX;
    }

    .modal-backdrop {
        display: none !important;
    }

    .modal-open .modal {
        width: 300px;
        margin: 0 auto;
        background-color: transparent;
    }

    .mg-b {
        margin-bottom: 10PX;
    }

    .bed-box {
        border-radius: 7px;
        padding: 5px 10px;
        height: auto;
        text-align: center;
        float: left;
        margin-right: 3px;
        margin-bottom: 3px;
    }

        .bed-box img {
            width: 25px;
        }

    p.bed-title {
        font-size: 10px;
        font-weight: 600;
        color: #fff;
        margin: 0;
        margin-top: 5px;
    }
</style>
");
            EndContext();
#line 60 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\CompanyProfile\Index.cshtml"
 using (Html.BeginForm("Add", "CompanyProfile", FormMethod.Post))
{

#line default
#line hidden
            BeginContext(1208, 154, true);
            WriteLiteral("<div class=\"prtm-content\">\r\n    <div class=\"prtm-page-bar\">\r\n        <ul class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item text-capitalize\"><h2>");
            EndContext();
            BeginContext(1363, 17, false);
#line 65 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\CompanyProfile\Index.cshtml"
                                                       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(1380, 355, true);
            WriteLiteral(@"</h2></li>
            <li class=""breadcrumb-item""><a href=""#"">Dashboard</a></li>
            <li class=""breadcrumb-item""><a href=""#"">Ui elements</a></li>
            <li class=""breadcrumb-item""><a href=""#"" class=""active""> Company Profile</a></li>
        </ul>
    </div>
    <div class=""row mrgn-b-sm"">
        <div class=""col-md-12 col-lg-12"">
");
            EndContext();
#line 73 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\CompanyProfile\Index.cshtml"
             if (Model.ID <= 0)
            {

#line default
#line hidden
            BeginContext(1781, 97, true);
            WriteLiteral("<input type=\"submit\" name=\"submit\" value=\"Save\" class=\"btn btn-xs btn-primary\" id=\"signupform\" />");
            EndContext();
#line 74 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\CompanyProfile\Index.cshtml"
                                                                                                              }
            else
            {

#line default
#line hidden
            BeginContext(1914, 101, true);
            WriteLiteral("                <input type=\"submit\" name=\"submit\" value=\"Update\" class=\"btn btn-xs btn-warning\" />\r\n");
            EndContext();
#line 78 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\CompanyProfile\Index.cshtml"


            }

#line default
#line hidden
            BeginContext(2034, 714, true);
            WriteLiteral(@"
        </div>
    </div>

    <div class=""row mg-b"">
        <div class=""col-md-12 col-lg-12"">
            <div class=""prtm-block pos-relative"">
                <div class=""line-slide-tab"">

                    <div class=""tab-content pad-all-sm"">
                        <div id=""tab-26"" class="" row tab-pane fade in active"">
                            <div class=""col-md-12 col-lg-12"">
                                <div class=""row mrgn-b-sm"">
                                    <div class=""col-md-5 col-lg-5"">
                                        <div class=""form-group"">
                                            <label>Company ID</label>
                                            ");
            EndContext();
            BeginContext(2749, 80, false);
#line 97 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\CompanyProfile\Index.cshtml"
                                       Write(Html.TextBoxFor(x => x.ID, new { @class = "form-control",@readonly="readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(2829, 231, true);
            WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"form-group\">\r\n                                            <label>Company Ar</label>\r\n                                            ");
            EndContext();
            BeginContext(3061, 70, false);
#line 101 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\CompanyProfile\Index.cshtml"
                                       Write(Html.TextBoxFor(x => x.CompanyArName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(3131, 226, true);
            WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"form-group\">\r\n                                            <label>Tel 1</label>\r\n                                            ");
            EndContext();
            BeginContext(3358, 74, false);
#line 105 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\CompanyProfile\Index.cshtml"
                                       Write(Html.TextBoxFor(x => x.Telephone1, new { @class = "form-control number" }));

#line default
#line hidden
            EndContext();
            BeginContext(3432, 232, true);
            WriteLiteral("\r\n                                        </div>\r\n\r\n\r\n\r\n                                        <div class=\"form-group\">\r\n                                            <label>Fax 1</label>\r\n                                            ");
            EndContext();
            BeginContext(3665, 68, false);
#line 112 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\CompanyProfile\Index.cshtml"
                                       Write(Html.TextBoxFor(x => x.Fax1, new { @class = "form-control number" }));

#line default
#line hidden
            EndContext();
            BeginContext(3733, 244, true);
            WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"form-group\">\r\n                                            <label for=\"Gender\">Address Ar</label>\r\n                                            ");
            EndContext();
            BeginContext(3978, 66, false);
#line 116 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\CompanyProfile\Index.cshtml"
                                       Write(Html.TextBoxFor(x => x.AddressAr, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(4044, 239, true);
            WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"form-group\">\r\n                                            <label for=\"Gender\">Email</label>\r\n                                            ");
            EndContext();
            BeginContext(4284, 62, false);
#line 120 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\CompanyProfile\Index.cshtml"
                                       Write(Html.TextBoxFor(x => x.Email, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(4346, 464, true);
            WriteLiteral(@"
                                        </div>
                                    </div>


                                    <div class=""col-md-5 col-lg-5"">
                                        <div class=""form-group"">

                                        </div>
                                        <div class=""form-group"">
                                            <label>Company En</label>
                                            ");
            EndContext();
            BeginContext(4811, 70, false);
#line 131 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\CompanyProfile\Index.cshtml"
                                       Write(Html.TextBoxFor(x => x.CompanyEnName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(4881, 226, true);
            WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"form-group\">\r\n                                            <label>Tel 2</label>\r\n                                            ");
            EndContext();
            BeginContext(5108, 74, false);
#line 135 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\CompanyProfile\Index.cshtml"
                                       Write(Html.TextBoxFor(x => x.Telephone2, new { @class = "form-control number" }));

#line default
#line hidden
            EndContext();
            BeginContext(5182, 226, true);
            WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"form-group\">\r\n                                            <label>Fax 2</label>\r\n                                            ");
            EndContext();
            BeginContext(5409, 68, false);
#line 139 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\CompanyProfile\Index.cshtml"
                                       Write(Html.TextBoxFor(x => x.Fax2, new { @class = "form-control number" }));

#line default
#line hidden
            EndContext();
            BeginContext(5477, 244, true);
            WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"form-group\">\r\n                                            <label for=\"Gender\">Address En</label>\r\n                                            ");
            EndContext();
            BeginContext(5722, 67, false);
#line 143 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\CompanyProfile\Index.cshtml"
                                       Write(Html.TextBoxFor(x => x.AddressEn, new { @class = "form-control " }));

#line default
#line hidden
            EndContext();
            BeginContext(5789, 241, true);
            WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"form-group\">\r\n                                            <label for=\"Gender\">Website</label>\r\n                                            ");
            EndContext();
            BeginContext(6031, 65, false);
#line 147 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\CompanyProfile\Index.cshtml"
                                       Write(Html.TextBoxFor(x => x.Website, new { @class = "form-control " }));

#line default
#line hidden
            EndContext();
            BeginContext(6096, 355, true);
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
    </div>
</div>
");
            EndContext();
#line 164 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\CompanyProfile\Index.cshtml"

}

#line default
#line hidden
            BeginContext(6456, 70, true);
            WriteLiteral("\r\n\r\n<!-- Modal -->\r\n<!---End Model--->\r\n<!--filter bed Modal -->\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6543, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            BeginContext(6552, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Models.CompanyProfile> Html { get; private set; }
    }
}
#pragma warning restore 1591
