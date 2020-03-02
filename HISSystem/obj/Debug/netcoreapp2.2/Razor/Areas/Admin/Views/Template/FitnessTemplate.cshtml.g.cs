#pragma checksum "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\FitnessTemplate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61abd30328edaa51db100dd379c32bd72646be0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Template_FitnessTemplate), @"mvc.1.0.view", @"/Areas/Admin/Views/Template/FitnessTemplate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Template/FitnessTemplate.cshtml", typeof(AspNetCore.Areas_Admin_Views_Template_FitnessTemplate))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61abd30328edaa51db100dd379c32bd72646be0b", @"/Areas/Admin/Views/Template/FitnessTemplate.cshtml")]
    public class Areas_Admin_Views_Template_FitnessTemplate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Helpers.PagedData<GeneticSystem.Areas.Admin.Models.FitnessTemplateViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\FitnessTemplate.cshtml"
  
    ViewData["Title"] = "Fitness Template List";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(193, 156, true);
            WriteLiteral("<div class=\"prtm-content\">\r\n\r\n    <div class=\"prtm-page-bar\">\r\n        <ul class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item text-capitalize\"><h2>");
            EndContext();
            BeginContext(350, 17, false);
#line 10 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\FitnessTemplate.cshtml"
                                                       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(367, 545, true);
            WriteLiteral(@"</h2></li>
            <li class=""breadcrumb-item""><a href=""#"">Dashboard</a></li>
            <li class=""breadcrumb-item""><a href=""#"">Ui elements</a></li>
            <li class=""breadcrumb-item""><a href=""#"" class=""active"">Epilepsy Template List</a></li>
        </ul>
    </div>
    <div class=""table-style"">
        <div class=""row mrgn-b-sm"">
            <div class=""col-md-5 col-lg-5"">
                <a href=""/admin/template/AddFitnessTemplate"" class=""btn btn-xs btn-primary""><i class=""fa fa-plus"" aria-hidden=""true""></i> Add</a>
");
            EndContext();
            BeginContext(1519, 559, true);
            WriteLiteral(@"            </div>

            <div class=""col-md-7 text-right search-block"">
                <div class=""input-group pull-right"" id=""adv-search"">
                    <input type=""text"" name=""search"" id=""search1"" class=""form-control"" placeholder=""Search..."" onkeyup=""getfitnesssearch(1);"" />

                </div>
            </div>

        </div>
        <div class=""prtm-block pos-relative"">
            <div class=""prtm-block-content"">
                <div class=""table-responsive"">
                    <div id=""userList"" class=""unseen"">
");
            EndContext();
#line 41 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\FitnessTemplate.cshtml"
                          
                            Html.RenderPartial("Getfitness");
                        

#line default
#line hidden
            BeginContext(2196, 283, true);
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
                BeginContext(2496, 7113, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        function addefitnesstemplate(){
        $.ajax({
            url: '/admin/template/AddFitnessTemplate',
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
        function SaveEpilepsy() {

                var data = new FormData();

        data.append(""GeneID"", $(""#GeneID"").val());
        data.append(""GeneticMutation"", $(""#GeneticMutation"").val());
        data.append(""PersonalRiskFactor"", $(""#PersonalRiskFactor"").val());
        data.append(""Hereditary"", $(""#Hereditary"").val());
        data.append(""Recommendations"", $(""#Recommendations"").val());
           if (document.getElementById('HaveMutation').checked) {
                data.append('HaveMutatio");
                WriteLiteral(@"n', ""true"");
            }

             $.ajax({
            url: '/admin/template/AddEpilepsyTemplates',
            data: data,
            type: 'Post',
            processData: false, contentType: false,
            success: function (result) {
                if (result) {
                    alert('Data Saved !')
                    $('#modalDiv').modal('hide');
                    window.location.reload();
                }
            },
            error: function (xhr, status) {
                alert(status)
            }
        });



        }
        function RefreshPage() {
            var page = parseInt($('.page-number').html());
            debugger
            $.ajax({
                url: '/admin/user/_index',
                data: { ""page"": page },
                success: function (data) {
                    debugger
                    $(""#userList"").html(data);
                    debugger
                }
            });
        }

        funct");
                WriteLiteral(@"ion editEpilepsy(id) {
                             $.ajax({
            url: '/admin/template/UpdateEpilepsyTemplate/' + id,
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
         function UpdateEpilepsyTemplate() {
                var data = new FormData();

             data.append(""GeneID"", $(""#GeneID"").val());
             data.append(""ID"", $(""#ID"").val());
        data.append(""GeneticMutation"", $(""#GeneticMutation"").val());
        data.append(""PersonalRiskFactor"", $(""#PersonalRiskFactor"").val());
        data.append(""Hereditary"", $(""#Hereditary"").val());
        data.append(""Recommendations"", $(""#Recommendations"").val());
           if (document.getElementById('HaveMutation').checked) {
                data.append('HaveMutation', ""true"");
      ");
                WriteLiteral(@"      }

             $.ajax({
            url: '/admin/template/UpdateEpilepsyTemplates',
            data: data,
            type: 'Post',
            processData: false, contentType: false,
            success: function (result) {
                if (result) {
                    alert('Data Saved !')
                    $('#modalDiv').modal('hide');
                    window.location.reload();
                }
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
        ");
                WriteLiteral(@"    },
                function () {
                    debugger
                   // var id = $(""#DeletedID"").val();
                    $.ajax({
                        url: '/admin/template/deleteFitnessTemplate?id=' + id,
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

        function getfitnesssearch(i) {
            debugger
            var Page = i;
            var searchstring = $(""#search1"").val();
            $.ajax({
                        url: '/admin/template/Getfitness?page=' +Page");
                WriteLiteral(@"+'&searchstring='+searchstring,
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
                url");
                WriteLiteral(@": '/admin/user/Attachment?id='+id+'&tableName=user',
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
            BeginContext(9612, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Helpers.PagedData<GeneticSystem.Areas.Admin.Models.FitnessTemplateViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
