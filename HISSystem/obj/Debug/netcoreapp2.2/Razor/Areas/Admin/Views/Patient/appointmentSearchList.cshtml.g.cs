#pragma checksum "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Patient\appointmentSearchList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce2f38fe00a99c8a5cf8fdd4a403260173a7248c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Patient_appointmentSearchList), @"mvc.1.0.view", @"/Areas/Admin/Views/Patient/appointmentSearchList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Patient/appointmentSearchList.cshtml", typeof(AspNetCore.Areas_Admin_Views_Patient_appointmentSearchList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce2f38fe00a99c8a5cf8fdd4a403260173a7248c", @"/Areas/Admin/Views/Patient/appointmentSearchList.cshtml")]
    public class Areas_Admin_Views_Patient_appointmentSearchList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Helpers.PagedData<Data.Models.Appointment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 902, true);
            WriteLiteral(@"   
        <div class="""">
            <button type=""button"" class=""close"" id=""close-div"" onclick=""closediv1();"">×</button>
            <div class=""row "">
                <div class=""col-lg-3""><label>Advance Search</label>  <input type=""text""   id=""searchinappointment1"" class=""form-control "" onkeyup="""" /></div>
                <div class=""col-lg-2"">
                    <label>Start Date</label>
                    <input type=""text"" id=""searchstartdate"" class=""datepicker form-control "" />
                </div>
                <div class=""col-lg-2"">
                    <label>End Date</label>
                    <input type=""text"" id=""searchenddate"" class="" datepicker form-control"" />
                </div>
                <div class=""col-lg-5 mrgn-b-xs"">
                    <button class=""btn btn-primary btn-xs"" type=""button"" onclick=""appointmentsearch(1);"">Search</button>
");
            EndContext();
            BeginContext(1007, 159, true);
            WriteLiteral("                    <button class=\"btn btn-xs btn-info\" onclick=\"fnExcelReport()\" type=\"button\"><i class=\"fa fa-share-square-o\" aria-hidden=\"true\"></i> Export ");
            EndContext();
            BeginContext(1220, 12, true);
            WriteLiteral(" </button>\r\n");
            EndContext();
            BeginContext(1637, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1658, 49, false);
#line 25 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Patient\appointmentSearchList.cshtml"
               Write(Html.Hidden("appstatusid", (int)ViewBag.StatusId));

#line default
#line hidden
            EndContext();
            BeginContext(1707, 1286, true);
            WriteLiteral(@"
                    <button class=""btn btn-danger btn-xs"" type=""button"" onclick=""printDiv()""><i class=""fa fa-print"" aria-hidden=""true""></i>Print</button>
                </div>
            </div>

            <br />

            <div class=""table-style"">
                <div class=""prtm-block pos-relative"">
                    <div class=""prtm-block-content"">
                        <div class=""table-responsive"">
                            <div class=""unseen"">
                                <table class=""table table-hover table-bordered table-striped"" id=""appointmentTbl"">
                                    <thead>
                                        <tr>
                                            <th>AppointmentID</th>
                                            <th class=""numeric"">DoctorName</th>
                                            <th class=""numeric"">PatientName</th>
                                            <th class=""numeric"">PatientReg</th>
                          ");
            WriteLiteral(@"                  <th class=""numeric"">Date</th>
                                            <th class=""numeric"">Time</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
            EndContext();
#line 49 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Patient\appointmentSearchList.cshtml"
                                         if (Model.Data != null)
                                        {
                                            foreach (var item in Model.Data)
                                            {

#line default
#line hidden
            BeginContext(3227, 110, true);
            WriteLiteral("                                                <tr>\r\n                                                    <td>");
            EndContext();
            BeginContext(3338, 7, false);
#line 54 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Patient\appointmentSearchList.cshtml"
                                                   Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(3345, 121, true);
            WriteLiteral("</td>\r\n                                                    <td>\r\n                                                        ");
            EndContext();
            BeginContext(3467, 23, false);
#line 56 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Patient\appointmentSearchList.cshtml"
                                                   Write(item.Doctor.EnFirstName);

#line default
#line hidden
            EndContext();
            BeginContext(3490, 7, true);
            WriteLiteral(" &nbsp;");
            EndContext();
            BeginContext(3498, 24, false);
#line 56 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Patient\appointmentSearchList.cshtml"
                                                                                  Write(item.Doctor.EnSecondName);

#line default
#line hidden
            EndContext();
            BeginContext(3522, 6, true);
            WriteLiteral("&nbsp;");
            EndContext();
            BeginContext(3529, 23, false);
#line 56 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Patient\appointmentSearchList.cshtml"
                                                                                                                 Write(item.Doctor.EnThirdName);

#line default
#line hidden
            EndContext();
            BeginContext(3552, 175, true);
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
            EndContext();
            BeginContext(3728, 21, false);
#line 59 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Patient\appointmentSearchList.cshtml"
                                                   Write(item.User.EnFirstName);

#line default
#line hidden
            EndContext();
            BeginContext(3749, 7, true);
            WriteLiteral(" &nbsp;");
            EndContext();
            BeginContext(3757, 22, false);
#line 59 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Patient\appointmentSearchList.cshtml"
                                                                                Write(item.User.EnSecondName);

#line default
#line hidden
            EndContext();
            BeginContext(3779, 6, true);
            WriteLiteral("&nbsp;");
            EndContext();
            BeginContext(3786, 21, false);
#line 59 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Patient\appointmentSearchList.cshtml"
                                                                                                             Write(item.User.EnThirdName);

#line default
#line hidden
            EndContext();
            BeginContext(3807, 175, true);
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
            EndContext();
            BeginContext(3983, 25, false);
#line 62 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Patient\appointmentSearchList.cshtml"
                                                   Write(item.User.RegisterationNo);

#line default
#line hidden
            EndContext();
            BeginContext(4008, 175, true);
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
            EndContext();
            BeginContext(4184, 40, false);
#line 65 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Patient\appointmentSearchList.cshtml"
                                                   Write(item.StartDate.Value.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(4224, 175, true);
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
            EndContext();
            BeginContext(4400, 40, false);
#line 68 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Patient\appointmentSearchList.cshtml"
                                                   Write(item.StartDate.Value.ToShortTimeString());

#line default
#line hidden
            EndContext();
            BeginContext(4440, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4510, 116, true);
            WriteLiteral("\r\n                                                    </td>\r\n                                                </tr>\r\n");
            EndContext();
#line 73 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Patient\appointmentSearchList.cshtml"
                                            }
                                        }

#line default
#line hidden
            BeginContext(4716, 202, true);
            WriteLiteral("\r\n                                    </tbody>\r\n                                    <tfoot>\r\n                                        <tr>\r\n                                            <td colspan=\"17\">\r\n");
            EndContext();
#line 80 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Patient\appointmentSearchList.cshtml"
                                                 for (int i = 1; i <= Model.NumberOfPages; i++)
                                                {

#line default
#line hidden
            BeginContext(5066, 101, true);
            WriteLiteral("                                                    <a class=\"page-number\" href=\"javascript:void(0);\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5167, "\"", 5195, 3);
            WriteAttributeValue("", 5177, "patientsearch(", 5177, 14, true);
#line 82 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Patient\appointmentSearchList.cshtml"
WriteAttributeValue("", 5191, i, 5191, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 5193, ");", 5193, 2, true);
            EndWriteAttribute();
            BeginContext(5196, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(5198, 1, false);
#line 82 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Patient\appointmentSearchList.cshtml"
                                                                                                                              Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(5199, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 83 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Patient\appointmentSearchList.cshtml"
                                                }

#line default
#line hidden
            BeginContext(5256, 2452, true);
            WriteLiteral(@"                                            </td>
                                        </tr>
                                    </tfoot>
                                </table>
                            </div>
                        </div>
                        <div class=""col-sm-12 col-md-12 col-lg-4"">
                        </div>
                    </div>
                </div>
            </div>
        </div>
    
<!-- Modal -->
<div class=""modal fade"" id=""exampleModalCenter"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">

        <div class=""modal-content"">

        </div>
    </div>
</div>
<script>
    $('#searchstartdate').datepicker({
                    format: ""yyyy-mm-dd"",
                    autoclose: true,
                    }).on('changeDate', function (ev) {
                    $(this).datepicker('hide');

                    }).keydown(func");
            WriteLiteral(@"tion (event) {
                    if (event.which == 9)
                    $(this).datepicker(""hide"");

                    });
     $('#searchenddate').datepicker({
                    format: ""yyyy-mm-dd"",
                    autoclose: true,
                    }).on('changeDate', function (ev) {
                    $(this).datepicker('hide');

                    }).keydown(function (event) {
                    if (event.which == 9)
                    $(this).datepicker(""hide"");

                    });

    //$(""body"").on(""click"", ""#pdfExport"", function () {
    //    debugger
    //    html2canvas($('#appointmentTbl')[0], {
         
    //        onrendered: function (canvas) {
    //               debugger
    //                var data = canvas.toDataURL();
    //                var docDefinition = {
    //                    content: [{
    //                        image: data,
    //                        width: 500
    //                    }]
    //             ");
            WriteLiteral(@"   };
    //                pdfMake.createPdf(docDefinition).download(""Table.pdf"");
    //            }
    //        });
    //    });
   
    function printDiv() {
        var divToPrint = document.getElementById('appointmentTbl');
        newWin = window.open("""");
        newWin.document.write(divToPrint.outerHTML);
        newWin.print();
        newWin.close();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Helpers.PagedData<Data.Models.Appointment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
