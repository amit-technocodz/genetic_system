#pragma checksum "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Settings\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e0fd1eb9401763898ca468b875db2c930df97cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Settings_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Settings/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Settings/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Settings_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e0fd1eb9401763898ca468b875db2c930df97cf", @"/Areas/Admin/Views/Settings/Index.cshtml")]
    public class Areas_Admin_Views_Settings_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GeneticSystem.Areas.Admin.Models.ImagesViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Settings\Index.cshtml"
  
    ViewData["Title"] = "Login Background";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(155, 334, true);
            WriteLiteral(@"<style>
    .file-upload input[type='file'] {
        display: none;
    }

    .rounded-lg {
        border-radius: 1rem;
    }

    .custom-file-label.rounded-pill {
        border-radius: 50rem;
    }

        .custom-file-label.rounded-pill::after {
            border-radius: 0 50rem 50rem 0;
        }
</style>
");
            EndContext();
#line 23 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Settings\Index.cshtml"
 using (Html.BeginForm("Add", "Settings", FormMethod.Post, new { enctype="multipart/form-data"}))
{

#line default
#line hidden
            BeginContext(591, 1153, true);
            WriteLiteral(@"    <div class=""prtm-content"">
        <div class=""prtm-page-bar"">
            <ul class=""breadcrumb"">
                <li class=""breadcrumb-item text-capitalize""><h2>Image Settings</h2></li>
                <li class=""breadcrumb-item""><a href=""#"" class=""active"">Upload Area</a></li>
            </ul>
        </div>

        <div class=""table-style"">
            <div class=""col-md-4 col-lg-4"">
                <div class=""btn-group btn-group-justified mrgn-b-xs"">
                </div>
            </div>
            <div class=""row mrgn-b-sm"">
                <div class=""col-md-12 col-lg-12"">
                    <h5>ADD Image</h5>
                    <div class=""quick-search-block"">
                        <div class=""row"">
                            <div class=""col-md-10 col-lg-10"">
                                <div id=""searchDiv"" class=""row"">
                                    <div class=""col-md-3 col-lg-3"">
                                        <label for=""Type"">
                ");
            WriteLiteral("                            Image For\r\n                                        </label>\r\n                                        ");
            EndContext();
            BeginContext(1745, 136, false);
#line 49 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Settings\Index.cshtml"
                                   Write(Html.DropDownListFor(m => m.ImageType, new SelectList(ViewBag.ImagesForList, "ID", "Name"), "-Select-", new { @Class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1881, 876, true);
            WriteLiteral(@"
                                    </div>
                                    <div class=""col-md-5 col-lg-5"">
                                        <div id=""ImgDiv"" class=""btn-group btn-group-justified mrgn-b-xs"">
                                            <label for=""fileUpload"" class=""file-upload btn btn-primary btn-block rounded-pill shadow"">
                                                <i class=""fa fa-upload mr-2""></i> Click to browse...
                                                <input id=""fileUpload"" name=""file"" type=""file"" disabled>
                                            </label>
                                        </div>
                                    </div>
                                    <button class=""btn btn-xs btn-warning "" type=""submit""><i class=""fa fa-pencil-square-o"" aria-hidden=""true""></i>  Save </button>
");
            EndContext();
            BeginContext(2880, 1115, true);
            WriteLiteral(@"                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""prtm-block pos-relative"">
                <div class=""prtm-block-content"">
                    <div class=""table-responsive"">
                        <div id=""imagepreview"" class=""unseen"">
                            <div class=""row py-4"">
                                <div class=""col-lg-6 mx-auto"">
                                    <p class=""font-italic text-white text-center"">The image uploaded will be rendered below.</p>
                                    <div class=""image-area mt-4""><img id=""imageResult"" src=""#"" alt="""" class=""img-fluid rounded shadow-sm mx-auto d-block""></div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-12 col-md-12 col-lg-4"">
                        </div>
         ");
            WriteLiteral("           </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 86 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Settings\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3998, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(4017, 1484, true);
                WriteLiteral(@"
    <script>
            document.getElementById(""fileUpload"").addEventListener(""change"", function () {
                readURL(fileUpload);
            });

            document.getElementById(""ImgDiv"").addEventListener(""click"", function () {
                var ImageType = document.getElementById(""ImageType"");
                var ImgId = ImageType.options[ImageType.selectedIndex].value;
                if (ImgId == null || ImgId == 0) {
                    alert('select image type first.')
                    return false;
                }
            });

            document.getElementById(""ImageType"").addEventListener(""change"", function () {
                var Input = document.getElementById(""fileUpload"");
                var ImgId = this.options[this.selectedIndex].value;
                if (ImgId == null || ImgId == 0) {
                    Input.disabled = true;
                    return false;
                } else {
                    Input.disabled = false;
            ");
                WriteLiteral(@"    }
            });

            function readURL(input) {
                if (input.files && input.files[0]) {
                    var reader = new FileReader();

                    reader.onload = function (e) {
                        $('#imageResult')
                            .attr('src', e.target.result);
                    };
                    reader.readAsDataURL(input.files[0]);
                }
            }
    </script>
");
                EndContext();
            }
            );
            BeginContext(5504, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GeneticSystem.Areas.Admin.Models.ImagesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591