#pragma checksum "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Email\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22aefbd86993d50a9bd90b659ba01c2f23af8b77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Email_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Email/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Email/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Email_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22aefbd86993d50a9bd90b659ba01c2f23af8b77", @"/Areas/Admin/Views/Email/Index.cshtml")]
    public class Areas_Admin_Views_Email_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Helpers.PagedData<Data.Models.Email>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Email\Index.cshtml"
  
    ViewData["Title"] = "Email List";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(144, 172, true);
            WriteLiteral("    <div class=\"prtm-content\">\r\n\r\n        <div class=\"prtm-page-bar\">\r\n            <ul class=\"breadcrumb\">\r\n                <li class=\"breadcrumb-item text-capitalize\"><h2>");
            EndContext();
            BeginContext(317, 17, false);
#line 11 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Email\Index.cshtml"
                                                           Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(334, 568, true);
            WriteLiteral(@"</h2></li>
                <li class=""breadcrumb-item""><a href=""#"">Dashboard</a></li>
                <li class=""breadcrumb-item""><a href=""#"">Ui elements</a></li>
                <li class=""breadcrumb-item""><a href=""#"" class=""active"">Email Template List</a></li>
            </ul>
        </div>
        <div class=""table-style"">
            <div class=""row mrgn-b-sm"">
                <div class=""col-md-5 col-lg-5"">
                    <button onclick=""addEmails()"" class=""btn btn-xs btn-primary""><i class=""fa fa-plus"" aria-hidden=""true""></i> Add</button>
");
            EndContext();
            BeginContext(1513, 602, true);
            WriteLiteral(@"                </div>

                <div class=""col-md-7 text-right search-block"">
                    <div class=""input-group pull-right"" id=""adv-search"">
                        <input type=""text"" name=""search"" id=""search1"" class=""form-control"" placeholder=""Search..."" onkeyup=""getemailsearch(1);"" />

                    </div>
                </div>

            </div>
            <div class=""prtm-block pos-relative"">
                <div class=""prtm-block-content"">
                    <div class=""table-responsive"">
                        <div id=""emailList"" class=""unseen"">
");
            EndContext();
#line 42 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Email\Index.cshtml"
                              
                                Html.RenderPartial("GetEmails");
                            

#line default
#line hidden
            BeginContext(2244, 3788, true);
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

<script>
   
    function addEmails() {
        $.ajax({
            url: '/admin/Email/add',
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

    function GetLogs(id, type) {
        debugger
        $.ajax({
            url: '/admin/Log/Logs?id=' + id + ""&type="" + type,
            success: function (result) {
                debugger
                $('#modalDiv').html(resu");
            WriteLiteral(@"lt);
                $('#modalDiv').modal('show');
            },
            error: function (xhr, status) {
                alert(status)
            }
        });
    }

    function TriggerEmail() {
        $.ajax({
            url: '/admin/Email/TriggerEmail',
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

    function editEmail(id) {
        $.ajax({
            url: '/admin/Email/Update/' + id,
            success: function (result) {
                debugger
                $('#modalDiv').html(result);
                $('#modalDiv').modal('show');
            },
            error: function (xhr, status) {
                alert(status)
            }
        });
    }
     


  ");
            WriteLiteral(@"   function DeleteEmail(id) {
         
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
                    //var id = $(""#DeletedID"").val();
                    $.ajax({
                        url: '/admin/email/delete?id=' + id,
                        type: 'GET',
                        success: function (data) {
                            debugger
                            swal(""Deleted!"", ""Your imaginary file has been deleted."", ""success"");
                            location.reload();
                        },
                        error: function () {
                            debugger
                  ");
            WriteLiteral(@"          swal(""Cancelled"", ""Something went wrong :)"", ""error"");
                        }
                    });
                });
    }
    function getemailsearch(i) {

        var Page = i;
        var searchstring = $(""#search1"").val();
         $.ajax({
                        url: '/admin/email/GetEmails?page=' +Page+'&searchstring='+searchstring,
                        type: 'GET',
                        success: function (result) {
                    $("".unseen"").html(result)
                },
                error: function (xhr, status) {
                    toastr.error('Something went wrong');
                }
               });
               



    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Helpers.PagedData<Data.Models.Email>> Html { get; private set; }
    }
}
#pragma warning restore 1591
