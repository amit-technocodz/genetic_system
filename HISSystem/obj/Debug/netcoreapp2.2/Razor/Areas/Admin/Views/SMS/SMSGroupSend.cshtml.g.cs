#pragma checksum "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\SMSGroupSend.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f66ac2623a570ad8e83dd023eb4916b222de660"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SMS_SMSGroupSend), @"mvc.1.0.view", @"/Areas/Admin/Views/SMS/SMSGroupSend.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/SMS/SMSGroupSend.cshtml", typeof(AspNetCore.Areas_Admin_Views_SMS_SMSGroupSend))]
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
#line 3 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\SMSGroupSend.cshtml"
using Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f66ac2623a570ad8e83dd023eb4916b222de660", @"/Areas/Admin/Views/SMS/SMSGroupSend.cshtml")]
    public class Areas_Admin_Views_SMS_SMSGroupSend : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GeneticSystem.Areas.Admin.Models.SendSMSGroupModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\SMSGroupSend.cshtml"
  
    ViewData["Title"] = "Send SMS";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(171, 136, true);
            WriteLiteral("<style>\r\n    .border-left {\r\n        border-left: 1px solid black;\r\n    }\r\n\r\n    .mg-t {\r\n        margin-top: 10PX;\r\n    }\r\n</style>\r\n\r\n");
            EndContext();
#line 18 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\SMSGroupSend.cshtml"
 using (Html.BeginForm("SendSMSToGroup", "SMS", FormMethod.Post))
{

#line default
#line hidden
            BeginContext(377, 170, true);
            WriteLiteral("    <div class=\"prtm-content\">\r\n        <div class=\"prtm-page-bar\">\r\n            <ul class=\"breadcrumb\">\r\n                <li class=\"breadcrumb-item text-capitalize\"><h2>");
            EndContext();
            BeginContext(548, 17, false);
#line 23 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\SMSGroupSend.cshtml"
                                                           Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(565, 1160, true);
            WriteLiteral(@"</h2></li>
                <li class=""breadcrumb-item""><a href=""#"">Dashboard</a></li>
                <li class=""breadcrumb-item""><a href=""#"">Ui elements</a></li>
                <li class=""breadcrumb-item""><a href=""#"" class=""active""> Send To Group</a></li>
            </ul>
        </div>
        <div class=""col-md-4 col-lg-4"">
            <input type=""submit"" name=""submit"" value=""Send"" class=""btn btn-xs btn-danger"" />
            <a href=""/admin/sms/smsgroups"" class=""btn btn-xs btn-info"">Back</a>
        </div>
        <div class=""form-style"">
            <div class=""row"">
                <div class=""col-md-12 col-lg-12"">
                    <div class=""prtm-block pos-relative"">
                        <div class=""row"">
                            <div class=""col-md-12 col-lg-12"">
                                <div class=""row"">
                                   
                                    <div class=""col-md-3 col-lg-5"">
                                        <div class=""form-");
            WriteLiteral("group\">\r\n                                            <label for=\"Department\">Group</label>\r\n                                            ");
            EndContext();
            BeginContext(1726, 145, false);
#line 44 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\SMSGroupSend.cshtml"
                                       Write(Html.DropDownListFor(m => m.GroupID, new SelectList(ViewBag.Groups, "ID", "GroupName"), "Select Group", new { @class = "form-control dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(1871, 357, true);
            WriteLiteral(@"
                                        </div>
                                    </div>
                                    <div class=""col-md-3 col-lg-5"">
                                        <div class=""form-group"">
                                            <label for=""Department"">Client</label>
                                            ");
            EndContext();
            BeginContext(2229, 148, false);
#line 50 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\SMSGroupSend.cshtml"
                                       Write(Html.DropDownListFor(m => m.UserID, new SelectList(ViewBag.Clients, "ID", "EnFirstName"), "Select Client", new { @class = "form-control dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(2377, 424, true);
            WriteLiteral(@"
                                        </div>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-md-10"">
                                        <div class=""form-group"">
                                            <label>Message</label>
                                            ");
            EndContext();
            BeginContext(2802, 71, false);
#line 58 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\SMSGroupSend.cshtml"
                                       Write(Html.TextAreaFor(m => m.Message,5, 20, new { @Class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2873, 302, true);
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
");
            EndContext();
#line 69 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\SMSGroupSend.cshtml"
}

#line default
#line hidden
            BeginContext(3178, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3197, 322, true);
                WriteLiteral(@"
    <script>
    $(document).ready(function () {
            var items = ""<option value='0'>Select</option>"";
            $('#FloorID').html(items);
            $('#RoomID').html(items);
        });
    $(document).ready(function () {
            $('#BuildingID').change(function () {
                var url = '");
                EndContext();
                BeginContext(3520, 17, false);
#line 80 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\SMSGroupSend.cshtml"
                      Write(Url.Content("~/"));

#line default
#line hidden
                EndContext();
                BeginContext(3537, 746, true);
                WriteLiteral(@"' + ""Admin/Bed/GetFloor"";
                var ddlsource = ""#BuildingID"";
                console.log($(ddlsource).children(""option:selected"").val());
                $.getJSON(url, { BuildingID: $(ddlsource).children(""option:selected"").val() }, function (data) {
                    var items = '';
                    $('#FloorID').empty();
                    $.each(data, function (i, floor) {
                        items += ""<option value='"" + floor.value + ""'>"" + floor.text + ""</option>"";
                    });
                    $('#FloorID').html(items);
                })
            });
        });

        $(document).ready(function () {
            $('#FloorID').change(function () {
                var url = '");
                EndContext();
                BeginContext(4284, 17, false);
#line 96 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\SMS\SMSGroupSend.cshtml"
                      Write(Url.Content("~/"));

#line default
#line hidden
                EndContext();
                BeginContext(4301, 658, true);
                WriteLiteral(@"' + ""Admin/Bed/GetRoom"";
                var ddlsource = ""#FloorID"";
                console.log($(ddlsource).children(""option:selected"").val());
                debugger
                $.getJSON(url, { FloorID: $(ddlsource).children(""option:selected"").val() }, function (data) {
                    var items = '';
                    $('#RoomID').empty();
                    $.each(data, function (i, room) {
                        items += ""<option value='"" + room.value + ""'>"" + room.text + ""</option>"";
                    });
                    $('#RoomID').html(items);
                });
            });
        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(4962, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GeneticSystem.Areas.Admin.Models.SendSMSGroupModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
