#pragma checksum "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\SmsConfig.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "327506faaf9eee710a95f94deead93be14d4936c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SMS_SmsConfig), @"mvc.1.0.view", @"/Areas/Admin/Views/SMS/SmsConfig.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/SMS/SmsConfig.cshtml", typeof(AspNetCore.Areas_Admin_Views_SMS_SmsConfig))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"327506faaf9eee710a95f94deead93be14d4936c", @"/Areas/Admin/Views/SMS/SmsConfig.cshtml")]
    public class Areas_Admin_Views_SMS_SmsConfig : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Models.SMSConfig>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\SmsConfig.cshtml"
  
    ViewData["Title"] = "SMS Config";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(128, 801, true);
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
#line 56 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\SmsConfig.cshtml"
 using (Html.BeginForm("AddApiKey", "SMS", FormMethod.Post))
{

#line default
#line hidden
            BeginContext(1106, 170, true);
            WriteLiteral("    <div class=\"prtm-content\">\r\n        <div class=\"prtm-page-bar\">\r\n            <ul class=\"breadcrumb\">\r\n                <li class=\"breadcrumb-item text-capitalize\"><h2>");
            EndContext();
            BeginContext(1277, 17, false);
#line 61 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\SmsConfig.cshtml"
                                                           Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(1294, 378, true);
            WriteLiteral(@"</h2></li>
                <li class=""breadcrumb-item""><a href=""#"">Dashboard</a></li>
                <li class=""breadcrumb-item""><a href=""#"">Ui elements</a></li>
                <li class=""breadcrumb-item""><a href=""#"" class=""active""> SMS Config</a></li>
            </ul>
        </div>
        <div class=""row mrgn-b-sm"">
            <div class=""col-md-12 col-lg-12"">
");
            EndContext();
#line 69 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\SmsConfig.cshtml"
                 if (Model.ID <= 0)
                {

#line default
#line hidden
            BeginContext(1726, 97, true);
            WriteLiteral("<input type=\"submit\" name=\"submit\" value=\"Save\" class=\"btn btn-xs btn-primary\" id=\"signupform\" />");
            EndContext();
#line 70 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\SmsConfig.cshtml"
                                                                                                                  }
                else
                {

#line default
#line hidden
            BeginContext(1867, 105, true);
            WriteLiteral("                    <input type=\"submit\" name=\"submit\" value=\"Update\" class=\"btn btn-xs btn-warning\" />\r\n");
            EndContext();
#line 74 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\SmsConfig.cshtml"


                }

#line default
#line hidden
            BeginContext(1995, 815, true);
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
                                        <div class=""col-md-10 col-lg-10"">
                                            
                                            <div class=""form-group"">
                                                <label>Api Key</label>
                                                ");
            EndContext();
            BeginContext(2811, 89, false);
#line 94 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\SmsConfig.cshtml"
                                           Write(Html.TextBoxFor(x => x.ApiKey, new { @class = "form-control" ,onchange="GetBalance();" }));

#line default
#line hidden
            EndContext();
            BeginContext(2900, 1474, true);
            WriteLiteral(@"
                                            </div>
                                           


                                            <div class=""form-group"">
                                                <label>Jawwal Balance</label>
                                               <input type=""text"" class=""form-control"" id=""jawwal"" name=""jawwal"" readonly />
                                            </div>
                                            <div class=""form-group"">
                                                <label for=""Gender"">Wataniya Balance </label>
                                                <input type=""text"" class=""form-control"" id=""watania"" name=""watania"" readonly />
                                            </div>
                                            <div class=""form-group"">
                                                <label for=""Gender"">International Balance</label>

                                                <input type=""text"" class=""for");
            WriteLiteral(@"m-control"" id=""international"" name=""international"" readonly />
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
#line 126 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\SmsConfig.cshtml"

}

#line default
#line hidden
            BeginContext(4379, 70, true);
            WriteLiteral("\r\n\r\n<!-- Modal -->\r\n<!---End Model--->\r\n<!--filter bed Modal -->\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4466, 629, true);
                WriteLiteral(@"
<script>
    $(document).ready(function () {
        var api = $(""#ApiKey"").val();
        debugger
        if(api != """") {
            GetBalance();
                }




    });
    function GetBalance() {
        var api =$(""#ApiKey"").val();
         $.ajax({
        type: 'Get',
        url: ""/admin/sms/GetApiBalance?ApiKey=""+api,
        success: function (response) {
            console.log(response);
            $(""#jawwal"").val(response[0]);
            $(""#watania"").val(response[1]);
            $(""#international"").val(response[2]);
        }
    });


    }
   
    

</script>

");
                EndContext();
            }
            );
            BeginContext(5098, 10, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Models.SMSConfig> Html { get; private set; }
    }
}
#pragma warning restore 1591
