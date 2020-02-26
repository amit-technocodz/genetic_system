#pragma checksum "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\AddSMSGroup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f363284676327cc46d0a9c42e1c0a00641546823"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SMS_AddSMSGroup), @"mvc.1.0.view", @"/Areas/Admin/Views/SMS/AddSMSGroup.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/SMS/AddSMSGroup.cshtml", typeof(AspNetCore.Areas_Admin_Views_SMS_AddSMSGroup))]
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
#line 3 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\AddSMSGroup.cshtml"
using Data.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f363284676327cc46d0a9c42e1c0a00641546823", @"/Areas/Admin/Views/SMS/AddSMSGroup.cshtml")]
    public class Areas_Admin_Views_SMS_AddSMSGroup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Models.GroupClientList>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\AddSMSGroup.cshtml"
  
    ViewData["Title"] = "SMS Group";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(150, 370, true);
            WriteLiteral(@"

}
<style>
    .border-left {
        border-left: 1px solid black;
    }

    .mg-t {
        margin-top: 10PX;
    }
</style>

<form action=""/admin/sms/addadmingroups"" method=""post"">
    <div class=""prtm-content"">
        <div class=""prtm-page-bar"">
            <ul class=""breadcrumb"">
                <li class=""breadcrumb-item text-capitalize""><h2>");
            EndContext();
            BeginContext(521, 17, false);
#line 25 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\AddSMSGroup.cshtml"
                                                           Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(538, 456, true);
            WriteLiteral(@"</h2></li>
                <li class=""breadcrumb-item""><a href=""#"">Dashboard</a></li>
                <li class=""breadcrumb-item""><a href=""#"">Ui elements</a></li>
                <li class=""breadcrumb-item""><a href=""#"" class=""active""> New Patient</a></li>
            </ul>
        </div>
        <div class=""col-md-4 col-lg-4"">
            <input type=""button"" name=""submit"" onclick=""AddSmsGroup();"" value=""Save"" class=""btn btn-xs btn-primary"" />
");
            EndContext();
            BeginContext(1095, 642, true);
            WriteLiteral(@"            <a href=""/admin/sms/smsgroup"" class=""btn btn-xs btn-info"">Back</a>
        </div>
        <div class=""form-style"">
            <div class=""row"">
                <div class=""col-md-12 col-lg-12"">
                    <div class=""prtm-block pos-relative"">
                        <!-- Modal content-->
                        <div class=""row"">
                            <div class=""col-md-12 col-lg-12"">
                                <div class=""row"">
                                    <div class=""col-md-6"">
                                        <label>Group Name</label>
                                        ");
            EndContext();
            BeginContext(1738, 33, false);
#line 46 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\AddSMSGroup.cshtml"
                                   Write(Html.HiddenFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1771, 468, true);
            WriteLiteral(@"
                                        <div class=""form-group"">
                                          <input type=""text"" name=""GroupName"" class=""form-control"" id=""GroupName"" />
                                        </div>
                                    </div>
                                    <div class=""col-md-6"">
                                        <label>Clients</label>
                                        <div class=""form-group"">
");
            EndContext();
            BeginContext(2467, 44, true);
            WriteLiteral("                                            ");
            EndContext();
            BeginContext(2512, 174, false);
#line 55 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\AddSMSGroup.cshtml"
                                       Write(Html.DropDownList("something", new SelectList(ViewBag.ClientList, "ID", "EnFirstName"), htmlAttributes: new { @class = "selectpicker tryMultiselect", multiple = "multiple" }));

#line default
#line hidden
            EndContext();
            BeginContext(2686, 2789, true);
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

</form>

<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-select/1.13.1/css/bootstrap-select.css"" />
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.bundle.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-select/1.13.1/js/bootstrap-select.min.js""></script>

<script>
      $(document).ready(function () {
            var PatientEncounter_ID = $(""#PatientEncounter_ID"").val();
           // alert(PatientEncounter_ID);
            if (PatientEncounter_ID > 0) {
                //alert(1);
                $(""#form-fieldset"").prop");
            WriteLiteral(@"(""disabled"", true);
                $(""#saveEncounter"").attr(""disabled"", true);

            }
            if ($(""#PatientPreAssesment_InitialMedicalAssessment_Detail"").prop(""checked"")) {
                $(""#detail-div"").show();
            }
            $(""select"").prop('class', 'selectpicker show-tick form-control');
            $(""select"").attr('data-live-search', true);          
      });
       $('select').selectpicker('show');
    $('.selectpicker').selectpicker('render');
    $('.select').selectpicker('show');
         //$('select').selectpicker();
       //$('#something').multiselect()
    function AddSmsGroup() {
        var formdata = new FormData($('form').get(0));
        i = 0;
        $(""#something option:selected"").each(function () {
            debugger
            var $this = $(this);
            
            formdata.append(""GroupClientLists[""+i+""].UserID"", $this[0].value); 
            i++;
        });
           for (var pair of formdata.entries()) {
            ");
            WriteLiteral(@"    console.log(pair[0] + ', ' + pair[1]);
        }
        debugger
         $.ajax({
                type: 'POST',
                url: ""/admin/sms/addsmsgroups"",
                data: formdata,
                dataType: ""json"",
                processData: false,
                contentType: false,
                success: function (response) {
                    console.log(response);
                    toastr.info('Record saved');
                },
                error: function (xhr, status) {
                    toastr.error('Something went wrong');
                }
            });


            }
   

</script>
<style>
    .chosen-container {
        width: 100% !important;
    }
</style>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Models.GroupClientList> Html { get; private set; }
    }
}
#pragma warning restore 1591
