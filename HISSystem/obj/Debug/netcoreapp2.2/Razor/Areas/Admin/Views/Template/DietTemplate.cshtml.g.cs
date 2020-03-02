#pragma checksum "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\DietTemplate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "006ecf3e84bd74905258230b59ef15dba795121c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Template_DietTemplate), @"mvc.1.0.view", @"/Areas/Admin/Views/Template/DietTemplate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Template/DietTemplate.cshtml", typeof(AspNetCore.Areas_Admin_Views_Template_DietTemplate))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"006ecf3e84bd74905258230b59ef15dba795121c", @"/Areas/Admin/Views/Template/DietTemplate.cshtml")]
    public class Areas_Admin_Views_Template_DietTemplate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Helpers.PagedData<GeneticSystem.Areas.Admin.Models.DietViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\DietTemplate.cshtml"
      
        ViewData["Title"] = "Diet Template List";
        Layout = "~/Views/Shared/_Admin.cshtml";
    

#line default
#line hidden
            BeginContext(197, 172, true);
            WriteLiteral("    <div class=\"prtm-content\">\r\n\r\n        <div class=\"prtm-page-bar\">\r\n            <ul class=\"breadcrumb\">\r\n                <li class=\"breadcrumb-item text-capitalize\"><h2>");
            EndContext();
            BeginContext(370, 17, false);
#line 11 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\DietTemplate.cshtml"
                                                           Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(387, 574, true);
            WriteLiteral(@"</h2></li>
                <li class=""breadcrumb-item""><a href=""#"">Dashboard</a></li>
                <li class=""breadcrumb-item""><a href=""#"">Ui elements</a></li>
                <li class=""breadcrumb-item""><a href=""#"" class=""active"">Diet Template List</a></li>
            </ul>
        </div>
        <div class=""table-style"">
            <div class=""row mrgn-b-sm"">
                <div class=""col-md-5 col-lg-5"">
                    <a href=""/admin/template/AddDietTemplate"" class=""btn btn-xs btn-primary""><i class=""fa fa-plus"" aria-hidden=""true""></i> Add</a>
");
            EndContext();
            BeginContext(1596, 600, true);
            WriteLiteral(@"                </div>

                <div class=""col-md-7 text-right search-block"">
                    <div class=""input-group pull-right"" id=""adv-search"">
                        <input type=""text"" name=""search"" id=""search1"" class=""form-control"" placeholder=""Search..."" onkeyup=""getdietsearch(1);"" />

                    </div>
                </div>

            </div>
            <div class=""prtm-block pos-relative"">
                <div class=""prtm-block-content"">
                    <div class=""table-responsive"">
                        <div id=""userList"" class=""unseen"">
");
            EndContext();
#line 42 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\DietTemplate.cshtml"
                              
                                Html.RenderPartial("GetDiet");
                            

#line default
#line hidden
            BeginContext(2323, 331, true);
            WriteLiteral(@"                        </div>
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
                BeginContext(2675, 3977, true);
                WriteLiteral(@"
        <script type=""text/javascript"">
        function addefitnesstemplate(){
        $.ajax({
            url: '/admin/template/AddDietTemplate',
            contentType: 'application/json; charse=utf-8',
            type: 'get',
            success: function (result) {
                $('#modalDiv').html(result);
                $('#modalDiv').modal('show');
            },
            error: function (xhr, status) {
                alert(status)
            }
        });
        }
        function Delete(id) {
            debugger
         //   $('#DeletedID').val(id);
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
                    debu");
                WriteLiteral(@"gger
                   // var id = $(""#DeletedID"").val();
                    $.ajax({
                        url: '/admin/template/DeleteDietTemplate?id=' + id,
                        type: 'GET',
                        success: function (data) {
                            debugger
                            swal(""Deleted!"", ""Your imaginary file has been deleted."", ""success"");
                            location.reload();
                        },
                        error: function () {
                            debugger
                            swal(""Cancelled"", ""Something went wrong :)"", ""error"");
                        }
                    });
                });
        }

        function getdietsearch(i) {
            debugger
            var Page = i;
            var searchstring = $(""#search1"").val();
            $.ajax({
                        url: '/admin/template/Getdiet?page=' +Page+'&searchstring='+searchstring,
                        type: 'GET',
 ");
                WriteLiteral(@"                   success: function (result) {
                        debugger
                         $("".unseen"").html(result)
                          },
                        error: function (xhr, status) {
                            toastr.error('Something went wrong');
                        }
                       });



        }

        function GetLogTable(id) {
            debugger
            $.ajax({
                url: '/admin/user/History?id=' + id+'&tableName=user',
                type: 'GET',
                success: function (data) {
                    $("".modal-content"").html(data);
                    $(""#exampleModalCenter"").modal().toggle();
                },
                error: function () {
                    toastr.error('Something went wrong');
                }
            });
        }

        function GetAttachment(id) {
             $.ajax({
                url: '/admin/user/Attachment?id='+id+'&tableName=user',
                ty");
                WriteLiteral(@"pe: 'GET',
                success: function (data) {
                    $("".modal-content"").html(data);
                    $(""#exampleModalCenter"").modal().toggle();
                },
                error: function () {
                    toastr.error('Something went wrong');
                }
            });
        }
        $(""body"").on(""click"", ""#pdfExport"", function () {
            html2canvas($('#userTbl')[0], {
                onrendered: function (canvas) {
                    var data = canvas.toDataURL();
                    var docDefinition = {
                        content: [{
                            image: data,
                            width: 500
                        }]
                    };
                    pdfMake.createPdf(docDefinition).download(""Table.pdf"");
                }
            });
        });
        </script>
    ");
                EndContext();
            }
            );
            BeginContext(6655, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Helpers.PagedData<GeneticSystem.Areas.Admin.Models.DietViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
