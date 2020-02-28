#pragma checksum "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\MedicalDictionary\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78e6b6375d1a0cd49986515005d51ae3000582db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_MedicalDictionary_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/MedicalDictionary/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/MedicalDictionary/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_MedicalDictionary_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78e6b6375d1a0cd49986515005d51ae3000582db", @"/Areas/Admin/Views/MedicalDictionary/Index.cshtml")]
    public class Areas_Admin_Views_MedicalDictionary_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Helpers.PagedData<Data.Models.MedicalDictionary>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(62, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\MedicalDictionary\Index.cshtml"
  
    ViewData["Title"] = "Medical Dictionary";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(166, 34, true);
            WriteLiteral("\r\n<div class=\"prtm-content\">\r\n    ");
            EndContext();
            BeginContext(201, 24, false);
#line 10 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\MedicalDictionary\Index.cshtml"
Write(Html.Hidden("DeletedID"));

#line default
#line hidden
            EndContext();
            BeginContext(225, 128, true);
            WriteLiteral("\r\n    <div class=\"prtm-page-bar\">\r\n        <ul class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item text-capitalize\"><h2>");
            EndContext();
            BeginContext(354, 17, false);
#line 13 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\MedicalDictionary\Index.cshtml"
                                                       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(371, 2980, true);
            WriteLiteral(@"</h2></li>
            <li class=""breadcrumb-item""><a href=""#"">Dashboard</a></li>
            <li class=""breadcrumb-item""><a href=""#"">Ui elements</a></li>
            <li class=""breadcrumb-item""><a href=""#"" class=""active"">Medical Dictionary</a></li>
        </ul>
    </div>

    <div class=""table-style"">
        <div class=""row mrgn-b-sm"">
            <div class=""col-md-4 col-lg-4"">
                <div class=""btn-group btn-group-justified mrgn-b-xs"">
                    <a class=""btn btn-xs  btn-primary"" href=""/admin/medicaldictionary/addmedicaldictionary""><i class=""fa fa-plus"" aria-hidden=""true""></i> New </a>
                    <a class=""btn btn-xs  btn-warning"" href=""/admin/patient/upate/"" id=""update-patient""><i class=""fa fa-pencil-square-o"" aria-hidden=""true""></i> Update </a>
                    <div class=""btn-group"">
                        <button data-toggle=""dropdown"" class=""btn btn-xs btn-info dropdown-toggle"" type=""button""><i class=""fa fa-share-square-o"" aria-hidden=""true""></i> Expor");
            WriteLiteral(@"t <i class=""fa fa-sort-desc"" aria-hidden=""true""></i> </button>
                    </div>

                </div>
            </div>
            <div class=""col-md-3"">
            </div>
        </div>
        <div class=""row mrgn-b-sm"">
            <div class=""col-md-12 col-lg-12"">
                <h5>Quick Search</h5>
                <div class=""quick-search-block"">
                    <div class=""row"">
                        <div class=""col-md-10 col-lg-10"">
                            <div class=""row"">
                                <div class=""col-md-2 col-lg-2"">
                                    Type:
                                    <select class=""form-control"" id=""typeID"" name=""typeName"">
                                        <option value="""">Select Type</option>
                                        <option value="""">Doctors</option>
                                        <option value="""">Hospitals</option>
                                        <option value="""">Insur");
            WriteLiteral(@"ance</option>
                                        <option value="""">Pharmacies</option>
                                    </select>
                                </div>
                                <div class=""col-md-2 col-lg-2"">
                                    En Name:
                                    <input type=""text"" name=""enNameID"" id=""search1"" class=""form-control"" placeholder=""Search..."" onkeyup=""getEnName(1);"" />
                                </div>
                                <div class=""col-md-2 col-lg-2"">
                                    Ar Name:
                                    <input type=""text"" id=""search2"" name=""arname"" class=""form-control"" autocomplete=""off"" onkeyup=""getEnName(1)"" />
                                </div>
                                <div class=""col-md-2 col-lg-2"">
                                    City:
                                    ");
            EndContext();
            BeginContext(3352, 182, false);
#line 62 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\MedicalDictionary\Index.cshtml"
                               Write(Html.DropDownList("CityNames", new SelectList(ViewBag.City, "ID", "Name"), "Select City", new { @Class = "form-control dropdown", onchange = "patientSearch()", @id = "CityNamesID" }));

#line default
#line hidden
            EndContext();
            BeginContext(3534, 395, true);
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""prtm-block pos-relative"">
            <div class=""prtm-block-content"">
                <div class=""table-responsive"">
                    <div id=""userList"" class=""unseen"">
");
            EndContext();
#line 74 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\MedicalDictionary\Index.cshtml"
                          
                            Html.RenderPartial("GetMedicalDictionary");
                        

#line default
#line hidden
            BeginContext(4057, 275, true);
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Modal -->
    <div class=""add-modal"">
        <div id=""modalDiv"" class=""modal fade"" role=""dialog"">
        </div>
    </div>
    <!---End Model--->
</div>

");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(4349, 1998, true);
                WriteLiteral(@"
<script>
    function Detele(id) {
            $('#DeletedID').val(id);
            swal({
                title: ""Are you sure?"",
                text: ""Are you sure you want to delete this record!"",
                type: ""warning"",
                showCancelButton: true,
                confirmButtonClass: ""btn-warning"",
                confirmButtonText: ""Yes, delete it!"",
                closeOnConfirm: false
            },
                function () {
                    debugger
                    var id = $(""#DeletedID"").val();
                    $.ajax({
                        url: '/admin/medicaldictionary/DeleteMedicalDictionary?id=' + id,
                        type: 'GET',
                        success: function (data) {
                            debugger
                            swal(""Deleted!"", ""Your imaginary file has been deleted."", ""success"");
                            location.reload();
                        },
                        error: function ");
                WriteLiteral(@"() {
                            debugger
                            swal(""Cancelled"", ""Something went wrong :)"", ""error"");
                        }
                    });
                });
    }

    function getEnName(i) {
            debugger
            var Page = i;
        var searchstringen = $(""#search1"").val();
        var searchstringar = $(""#search2"").val();

            $.ajax({
                        url: '/admin/medicaldictionary/SearchEnName?page=' +Page+'&searchstringen='+searchstringen+'&searchstringar='+searchstringar,
                        type: 'GET',
                    success: function (result) {
                        debugger
                         $("".unseen"").html(result)
                          },
                        error: function (xhr, status) {
                            toastr.error('Something went wrong');
                        }
                       });



    }

</script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Helpers.PagedData<Data.Models.MedicalDictionary>> Html { get; private set; }
    }
}
#pragma warning restore 1591