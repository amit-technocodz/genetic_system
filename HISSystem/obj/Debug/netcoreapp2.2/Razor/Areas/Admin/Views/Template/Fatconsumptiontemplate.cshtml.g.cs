#pragma checksum "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\Template\Fatconsumptiontemplate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42f729508032a122a889d9ceef9e3fb9e33598d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Template_Fatconsumptiontemplate), @"mvc.1.0.view", @"/Areas/Admin/Views/Template/Fatconsumptiontemplate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Template/Fatconsumptiontemplate.cshtml", typeof(AspNetCore.Areas_Admin_Views_Template_Fatconsumptiontemplate))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42f729508032a122a889d9ceef9e3fb9e33598d8", @"/Areas/Admin/Views/Template/Fatconsumptiontemplate.cshtml")]
    public class Areas_Admin_Views_Template_Fatconsumptiontemplate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Helpers.PagedData<Data.Models.FatConsumptionTemplate>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\Template\Fatconsumptiontemplate.cshtml"
  
    ViewData["Title"] = "Fat Consumption Template List";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(178, 32, true);
            WriteLiteral("<div class=\"prtm-content\">\r\n    ");
            EndContext();
            BeginContext(211, 24, false);
#line 7 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\Template\Fatconsumptiontemplate.cshtml"
Write(Html.Hidden("DeletedID"));

#line default
#line hidden
            EndContext();
            BeginContext(235, 128, true);
            WriteLiteral("\r\n    <div class=\"prtm-page-bar\">\r\n        <ul class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item text-capitalize\"><h2>");
            EndContext();
            BeginContext(364, 17, false);
#line 10 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\Template\Fatconsumptiontemplate.cshtml"
                                                       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(381, 558, true);
            WriteLiteral(@"</h2></li>
            <li class=""breadcrumb-item""><a href=""#"">Dashboard</a></li>
            <li class=""breadcrumb-item""><a href=""#"">Ui elements</a></li>
            <li class=""breadcrumb-item""><a href=""#"" class=""active"">Fat Consumption Template List</a></li>
        </ul>
    </div>
    <div class=""table-style"">
        <div class=""row mrgn-b-sm"">
            <div class=""col-md-5 col-lg-5"">
                <button onclick=""addfatconsumptiontemplate()"" class=""btn btn-xs btn-primary""><i class=""fa fa-plus"" aria-hidden=""true""></i> Add</button>
");
            EndContext();
            BeginContext(1546, 566, true);
            WriteLiteral(@"            </div>

            <div class=""col-md-7 text-right search-block"">
                <div class=""input-group pull-right"" id=""adv-search"">
                    <input type=""text"" name=""search"" id=""search1"" class=""form-control"" placeholder=""Search..."" onkeyup=""getfatconsumptionsearch(1);"" />

                </div>
            </div>

        </div>
        <div class=""prtm-block pos-relative"">
            <div class=""prtm-block-content"">
                <div class=""table-responsive"">
                    <div id=""userList"" class=""unseen"">
");
            EndContext();
#line 41 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\Template\Fatconsumptiontemplate.cshtml"
                          
                            Html.RenderPartial("GetFatConsumption");
                        

#line default
#line hidden
            BeginContext(2237, 283, true);
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
                BeginContext(2537, 8389, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        function addfatconsumptiontemplate() {
        $.ajax({
            url: '/admin/template/AddFatConsumptionTemplate',
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
        function SaveFatConsumption() {

                var data = new FormData();

        data.append(""EffectedGeneID"", $(""#EffectedGeneID"").val());
        data.append(""ConsumptionTypeID"", $(""#ConsumptionTypeID"").val());
        data.append(""Reccomendations"", $(""#Reccomendations"").val());
      
           if (document.getElementById('Effected').checked) {
                data.append('Effected', ""true"");
            }

             $.ajax({
            url: '/admin/template/AddFatCo");
                WriteLiteral(@"nsumptionTemplates',
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

        function editFatConsumption(id) {
                             $.ajax({
            url: '/ad");
                WriteLiteral(@"min/template/UpdateFatConsumptionTemplate/' + id,
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
         function UpdateFatConsumption() {
                var data = new FormData();

             
             data.append(""ID"", $(""#ID"").val());
       data.append(""EffectedGeneID"", $(""#EffectedGeneID"").val());
        data.append(""ConsumptionTypeID"", $(""#ConsumptionTypeID"").val());
        data.append(""Reccomendations"", $(""#Reccomendations"").val());
      
           if (document.getElementById('Effected').checked) {
                data.append('Effected', ""true"");
            }


             $.ajax({
            url: '/admin/template/UpdateFatConsumptionTemplates',
            data: data,
            type: 'Post',
            processData: false, ");
                WriteLiteral(@"contentType: false,
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
          //  $('#DeletedID').val(id);
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
                   // var id = $(""#DeletedID"").val();
                    $.ajax({
                        url: ");
                WriteLiteral(@"'/admin/template/deletefatconsumption?id=' + id,
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

        function getfatconsumptionsearch(i) {
            debugger
            var Page = i;
            var searchstring = $(""#search1"").val();
            $.ajax({
                        url: '/admin/template/GetFatConsumption?page=' +Page+'&searchstring='+searchstring,
                        type: 'GET',
                    success: function (result) {
                        debugger
               ");
                WriteLiteral(@"          $("".unseen"").html(result)
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
                type: 'GET',
                success: function (data) {
                    $("".modal-content"").ht");
                WriteLiteral(@"ml(data);
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

        function fnExcelReport() {
            var tab_text = ""<table border='2px'><tr bgcolor='#87AFC6'>"";
            var textRange; var j = 0;
            var tab = document.getElementById('userTbl'); // id of table

            f");
                WriteLiteral(@"or (j = 0; j < tab.rows.length; j++) {
                tab_text = tab_text + tab.rows[j].innerHTML + ""</tr>"";
            }

            tab_text = tab_text + ""</table>"";
            tab_text = tab_text.replace(/<A[^>]*>|<\/A>/g, """");//remove if u want links in your table
            tab_text = tab_text.replace(/<img[^>]*>/gi, """"); // remove if u want images in your table
            tab_text = tab_text.replace(/<input[^>]*>|<\/input>/gi, """"); // reomves input params

            var ua = window.navigator.userAgent;
            var msie = ua.indexOf(""MSIE "");

            if (msie > 0 || !!navigator.userAgent.match(/Trident.*rv\:11\./))      // If Internet Explorer
            {
                txtArea1.document.open(""txt/html"", ""replace"");
                txtArea1.document.write(tab_text);
                txtArea1.document.close();
                txtArea1.focus();
                sa = txtArea1.document.execCommand(""SaveAs"", true, ""Patients.xls"");
            }
            else           ");
                WriteLiteral("      //other browser not tested on IE 11\r\n                sa = window.open(\'data:application/vnd.ms-excel,\' + encodeURIComponent(tab_text));\r\n\r\n            return (sa);\r\n        }\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(10929, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Helpers.PagedData<Data.Models.FatConsumptionTemplate>> Html { get; private set; }
    }
}
#pragma warning restore 1591
