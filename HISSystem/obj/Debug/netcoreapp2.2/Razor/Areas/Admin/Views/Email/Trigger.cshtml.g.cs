#pragma checksum "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Email\Trigger.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7482b4edb93253a16746ca11fd9771ae136b60fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Email_Trigger), @"mvc.1.0.view", @"/Areas/Admin/Views/Email/Trigger.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Email/Trigger.cshtml", typeof(AspNetCore.Areas_Admin_Views_Email_Trigger))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7482b4edb93253a16746ca11fd9771ae136b60fd", @"/Areas/Admin/Views/Email/Trigger.cshtml")]
    public class Areas_Admin_Views_Email_Trigger : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Helpers.PagedData<Data.Models.EmailTrigger>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Email\Trigger.cshtml"
  
    ViewData["Title"] = "Trigger";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(146, 158, true);
            WriteLiteral("\r\n<div class=\"prtm-content\">\r\n\r\n    <div class=\"prtm-page-bar\">\r\n        <ul class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item text-capitalize\"><h2>");
            EndContext();
            BeginContext(305, 17, false);
#line 11 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Email\Trigger.cshtml"
                                                       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(322, 533, true);
            WriteLiteral(@"</h2></li>
            <li class=""breadcrumb-item""><a href=""#"">Dashboard</a></li>
            <li class=""breadcrumb-item""><a href=""#"">Ui elements</a></li>
            <li class=""breadcrumb-item""><a href=""#"" class=""active"">Email Trigger List</a></li>
        </ul>
    </div>
    <div class=""table-style"">
        <div class=""row mrgn-b-sm"">
            <div class=""col-md-5 col-lg-5"">
                <button onclick=""addTriggers()"" class=""btn btn-xs btn-primary""><i class=""fa fa-plus"" aria-hidden=""true""></i> Add</button>
");
            EndContext();
            BeginContext(1462, 565, true);
            WriteLiteral(@"            </div>

            <div class=""col-md-7 text-right search-block"">
                <div class=""input-group pull-right"" id=""adv-search"">
                    <input type=""text"" name=""search"" id=""search1"" class=""form-control"" placeholder=""Search..."" onkeyup=""getemailtriggersearch(1);"" />

                </div>
            </div>

        </div>
        <div class=""prtm-block pos-relative"">
            <div class=""prtm-block-content"">
                <div class=""table-responsive"">
                    <div id=""emailList"" class=""unseen"">
");
            EndContext();
#line 42 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Email\Trigger.cshtml"
                          
                            Html.RenderPartial("GetTriggers");
                        

#line default
#line hidden
            BeginContext(2146, 5705, true);
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

<script>
    function addTriggers() {
        $.ajax({
            url: '/admin/Email/AddTriggerEmail',
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
     function editTrigger(id) {
        $.ajax({
            url: '/admin/Email/UpdateEmailTrigger/' + id,
            success: function (result) {
                debugger
                $('#modalDiv').html(result);
                $('#modalDiv').modal('show');
            ");
            WriteLiteral(@"},
            error: function (xhr, status) {
                alert(status)
            }
        });
    }
    function DeleteEmailTrigger(id) {
         
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
                        url: '/admin/email/deletetrigger?id=' + id,
                        type: 'GET',
                        success: function (data) {
                            debugger
                            swal(""Deleted!"", ""Your imaginary file has been deleted."", ""success"");
                            location.reload();
");
            WriteLiteral(@"                        },
                        error: function () {
                            debugger
                            swal(""Cancelled"", ""Something went wrong :)"", ""error"");
                        }
                    });
                });
    }
    function getemailtriggersearch(i) {

        var Page = i;
        var searchstring = $(""#search1"").val();
         $.ajax({
                        url: '/admin/email/GetTriggers?page=' +Page+'&searchstring='+searchstring,
                        type: 'GET',
                        success: function (result) {
                    $("".unseen"").html(result)
                },
                error: function (xhr, status) {
                    toastr.error('Something went wrong');
                }
               });
               



    }
    function GetLogs(id, type) {
        debugger
        $.ajax({
            url: '/admin/Log/Logs?id=' + id + ""&type="" + type,
            success: function (result) {
  ");
            WriteLiteral(@"              debugger
                $('#modalDiv').html(result);
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
               ");
            WriteLiteral(@" alert(status)
            }
        });
    }

    function DeleteEmail(id) {

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
                        swal(""Cancelled"", ""Something went wro");
            WriteLiteral(@"ng :)"", ""error"");
                    }
                });
            });
    }
    function getemailsearch(i) {

        var Page = i;
        var searchstring = $(""#search1"").val();
        $.ajax({
            url: '/admin/email/GetEmails?page=' + Page + '&searchstring=' + searchstring,
            type: 'GET',
            success: function (result) {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Helpers.PagedData<Data.Models.EmailTrigger>> Html { get; private set; }
    }
}
#pragma warning restore 1591
