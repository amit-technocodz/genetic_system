#pragma checksum "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1d510f159b62367357658fbabf9c698807dfa57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_PatientOrder_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/PatientOrder/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/PatientOrder/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_PatientOrder_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1d510f159b62367357658fbabf9c698807dfa57", @"/Areas/Admin/Views/PatientOrder/Index.cshtml")]
    public class Areas_Admin_Views_PatientOrder_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Helpers.PagedData<Data.Models.PatientOrder>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\Index.cshtml"
  
    ViewData["Title"] = "Order List";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(151, 1945, true);
            WriteLiteral(@"
<style>

    .ui-autocomplete {
        z-index: 2147483647;
        max-height: 200px;
        overflow-y: auto;
        overflow-x: hidden;
        padding-right: 20px;
        float: left;
        display: none;
        min-width: 160px;
        width: 160px;
        padding: 4px 0;
        margin: 2px 0 0 0;
        list-style: none;
        background-color: #ffffff;
        border-color: #ccc;
        border-color: rgba(0, 0, 0, 0.2);
        border-style: solid;
        border-width: 1px;
        -webkit-border-radius: 2px;
        -moz-border-radius: 2px;
        border-radius: 2px;
        -webkit-box-shadow: 0 5px 10px rgba(0, 0, 0, 0.2);
        -moz-box-shadow: 0 5px 10px rgba(0, 0, 0, 0.2);
        box-shadow: 0 5px 10px rgba(0, 0, 0, 0.2);
        -webkit-background-clip: padding-box;
        -moz-background-clip: padding;
        background-clip: padding-box;
        *border-right-width: 2px;
        *border-bottom-width: 2px;
    }

    .quick-search-block {");
            WriteLiteral(@"
        border: 1px solid #eaebed;
        background: #f4f5f7;
        padding: 5px;
    }

    .prtm-footer {
        padding: 15px 0 5px;
        background-color: #fff;
    }

    .breadcrumb {
        padding: 2px 0px;
        list-style: none;
        background-color: #fff;
        border-radius: 0px;
    }

    .bed-box {
        border-radius: 7px;
        padding: 2px 5px;
        height: auto;
        text-align: center;
        float: left;
        margin-right: 2px;
        margin-bottom: 2px;
    }

        .bed-box img {
            width: 15px;
        }

    p.bed-title {
        font-size: 10px;
        font-weight: 600;
        color: #fff;
        margin: 0;
        margin-top: 1px;
    }
</style>
<div class=""prtm-content"">
    <div class=""prtm-page-bar"">
        <ul class=""breadcrumb"">
            <li class=""breadcrumb-item text-capitalize""><h2>");
            EndContext();
            BeginContext(2097, 17, false);
#line 84 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\Index.cshtml"
                                                       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(2114, 1070, true);
            WriteLiteral(@"</h2></li>
            <li class=""breadcrumb-item""><a href=""#"">Dashboard</a></li>
            <li class=""breadcrumb-item""><a href=""#"">Ui elements</a></li>
            <li class=""breadcrumb-item""><a href=""#"" class=""active"">Order List</a></li>
        </ul>
    </div>

    <div class=""table-style"">
        <div class=""row mrgn-b-sm"">
            <div class=""col-md-4 col-lg-4"">
                <div class=""btn-group btn-group-justified mrgn-b-xs"">
                    <a class=""btn btn-xs  btn-primary"" href=""/admin/patientorder/addpatientorder""><i class=""fa fa-plus"" aria-hidden=""true""></i> New </a>
                    <a class=""btn btn-xs  btn-warning"" href=""/admin/patient/upate/"" id=""update-patient""><i class=""fa fa-pencil-square-o"" aria-hidden=""true""></i> Update </a>
                    <div class=""btn-group"">
                        <button data-toggle=""dropdown"" class=""btn btn-xs btn-info dropdown-toggle"" type=""button""><i class=""fa fa-share-square-o"" aria-hidden=""true""></i> Export <i class=""fa fa-");
            WriteLiteral("sort-desc\" aria-hidden=\"true\"></i> </button>\r\n");
            EndContext();
            BeginContext(3484, 74, true);
            WriteLiteral("                    </div>\r\n\r\n                </div>\r\n            </div>\r\n");
            EndContext();
            BeginContext(4047, 284, true);
            WriteLiteral(@"            <div class=""col-md-3"">
            </div>
        </div>
        <div class=""row mrgn-b-sm"">
            <div class=""col-md-12 col-lg-12"">
                <h5>Quick Search</h5>
                <div class=""quick-search-block"">
                    <div class=""row"">
");
            EndContext();
            BeginContext(6237, 2309, true);
            WriteLiteral(@"                        <div class=""col-md-10 col-lg-10"">
                            <div class=""row"">
                                <div class=""col-md-2 col-lg-2"">
                                    Order No:
                                    <input type=""text"" id=""registerNo"" name=""register-no"" class=""form-control"" onkeyup=""patientSearch()"" />
                                </div>
                                <div class=""col-md-2 col-lg-2"">
                                    ID No:
                                    <input type=""text"" id=""id-no"" name=""id-no"" class=""form-control"" autocomplete=""off"" onkeyup=""patientSearch()"" />
                                </div>
                                <div class=""col-md-2 col-lg-2"">
                                    Patient Name:
                                    <input type=""text"" id=""patientName"" name=""patient-name"" class=""form-control"" autocomplete=""off"" onkeyup=""patientSearch()"" />
                                </div>
         ");
            WriteLiteral(@"                       <div class=""col-md-2 col-lg-2"">
                                    Patient Mobile:
                                    <input type=""text"" id=""patientMobile"" name=""patient-mobile"" class=""form-control"" autocomplete=""off"" onkeyup=""patientSearch()"" />
                                </div>
                                <div class=""col-md-2 col-lg-2"">
                                    Patient City:
                                    <input type=""text"" id=""patientCity"" name=""patient-city"" class=""form-control"" autocomplete=""off"" onkeyup=""patientSearch()"" />
                                </div>
                                <div class=""col-md-2 col-lg-2"">
                                    Birth Date:
                                    <input type=""text"" name=""birth-date"" class=""form-control datepicker"" autocomplete=""off"" onchange=""patientSearch()"" />
                                </div>

                            </div>
                        </div>
            ");
            WriteLiteral(@"        </div>
                </div>
            </div>
        </div>

        <div class=""prtm-block pos-relative"">
            <div class=""prtm-block-content"">
                <div class=""table-responsive"">
                    <div class=""unseen"">
");
            EndContext();
#line 185 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\PatientOrder\Index.cshtml"
                          
                            Html.RenderPartial("GetOrder");
                        

#line default
#line hidden
            BeginContext(8662, 901, true);
            WriteLiteral(@"                    </div>
                    <div class=""col-sm-12 col-md-12 col-lg-4"">
                    </div>
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
<!---End Model--->
<!--filter bed Modal -->
<div class=""modal fade"" id=""exampleModalCenter1"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg modal-dialog-centered"" role=""document"">
        <div class=""modal-content"" id=""allocate-bed-model"">

        </div>
    </div>
</div>
<!---filter bed End Model--->


");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(9580, 14040, true);
                WriteLiteral(@"
    <script>
        $('.datepicker').datepicker({
            format: ""dd-mm-yyyy"",
            autoclose: true,
        }).on('changeDate', function (ev) {
            $(this).datepicker('hide');

        }).keydown(function (event) {
            if (event.which == 9)
                $('.datepicker').datepicker(""hide"");

        });

        $(document).ready(function () {
            $('#registerNo').autocomplete({
                source: '/admin/patient/autocompletereg'
            });
            debugger
        });

        $(document).ready(function () {
            $('#patientName').autocomplete({
                source: '/admin/patient/autocompletename'
            });
            debugger
        });
        $(document).ready(function () {
            $('#id-no').autocomplete({
                source: '/admin/patient/autocompleteid'
            });
            debugger
        });

        $(document).ready(function () {
            $(""body"").on(""click"", '.page-n");
                WriteLiteral(@"umber', function () {
                var page = parseInt($(this).html());
                debugger
                $.ajax({
                    url: '/admin/patient/getpatients',
                    data: { ""page"": page },
                    success: function (data) {
                        debugger
                        $("".unseen"").html(data);
                        debugger
                    },
                    error: function (xhr, status) {
                        toastr.error('Something went wrong');
                    }
                });
            });
        });

            function GetID(id) {
            debugger
            $(""#update-patient"").attr(""href"", ""/admin/patientorder/updateorder/"" + id);
        }

        function patientSearch() {

            var inpatient;
            var outpatient;
            var appointmentToday;

            if ($('#inPatientCheckBox').prop(""checked"") == true) {
                debugger
                inpatient = ");
                WriteLiteral(@"$('#inPatientCheckBox').val();
            }

            if ($('#outPatientCheckBox').prop(""checked"") == true) {
                outpatient = $('#outPatientCheckBox').val();
            }

            if ($('#appointmentTodayCheckBox').prop(""checked"") == true) {

                appointmentToday = $('#appointmentTodayCheckBox').val();
            }

            var model = {
                InPatient: inpatient,
                OutPatient: outpatient,
                appointmentToday: appointmentToday,
                RegistrationNo: $('input[name=""register-no""]').val(),
                ID: $('#id-no').val(),
                PatientName: $('input[name=""patient-name""]').val(),
                BirthDate: $('input[name=""birth-date""]').val(),
                Status: $('select[name=""status""]').text(),
                PatientMobile: $('#patientMobile').val(),
                PatientCity: $('#patientCity').val()
            }
            debugger
            $.ajax({
                url: '");
                WriteLiteral(@"/admin/patient/SearchPatient',
                type: 'POST',
                data: model,
                success: function (result) {
                    $("".unseen"").html(result)
                },
                error: function (xhr, status) {
                    toastr.error('Something went wrong');
                }
            });

        };

        function dynamicAdmissionFields() {
            var TypeID = $(""#TypeID"").val();
            if (TypeID != null) {
                if (TypeID == 66 || TypeID == 63) {
                    $(""#RefferedByDrop"").show();
                    $(""#ReservedByBox"").hide();
                    $(""#AppointmentBox"").hide();
                } else if (TypeID == 69) {
                    $(""#AppointmentBox"").show();
                    var AppointmentID = $(""#AppointmentID"").val();
                    if (AppointmentID != 0 && AppointmentID != null) {
                        $.ajax({
                            url: '/admin/patient/GetAppointmen");
                WriteLiteral(@"tReservedBy',
                            type: 'POST',
                            data: { AppointmentID: AppointmentID },
                            success: function (result) {
                                debugger
                                $(""#ReservedBy"").val(result);
                            },
                            error: function (xhr, status) {
                                toastr.error('Something went wrong');
                            }
                        });
                    } else {
                        $(""#ReservedBy"").val("""");
                    }
                    $(""#ReservedByBox"").show();
                    $(""#RefferedByDrop"").hide();
                } else {
                    $(""#ReservedByBox"").hide();
                    $(""#RefferedByDrop"").hide();
                    $(""#AppointmentBox"").hide();
                }
            }
        }


        $('.action-button').click(function () {
            debugger
            ");
                WriteLiteral(@"var id = this.id;
            var val = this.dataset.value;
            debugger
            if (val) {
                url = '/admin/patient/' + id + ""?id="" + val;
            }
            else {
                url = '/admin/patient/' + id
            }
            $.ajax({
                url: url,
                type: 'GET',
                success: function (result) {
                    $("".modal-content"").html(result);
                    if (id == ""admission"") {
                        dynamicAdmissionFields();
                    }
                },
                error: function (xhr, status) {
                    toastr.error('Something went wrong');
                }
            });
        });





        function GetType(event) {
            var id = event.id;
            url = '/admin/patient/'

            if (id == 'AdmissionTypeID') {
                url = url + 'FillTypeDropDown?id=' + event.value;
            }
            $.ajax({
                u");
                WriteLiteral(@"rl: url,
                type: 'GET',
                success: function (data) {
                    if (data.length > 0) {
                        if (data[0].typeID) {
                            $(""#TypeID"").prop(""disabled"", false);
                            var ddldist = $('#TypeID');
                            var markup = ""<option value='0'>Select "" + data[0].type.toLowerCase() + "" type</option>"";
                            $.each(data, function (val, text) {
                                markup += ""<option value="" + text.id + "">"" + text.name + ""</option>"";
                            });
                            $(""#TypeID"").html(markup).show();
                        }
                    }
                    $(""#ReservedByBox"").hide();
                    $(""#RefferedByDrop"").hide();
                    $(""#AppointmentBox"").hide();
                },
                error: function (xhr, status) {
                    toastr.error('Something went wrong');
               ");
                WriteLiteral(@" }
            });
        };

        function GetBuilding(event) {
            var id = event.id;
            var selectRoom = ""<option value='0'>Select Room</option>"";
            var selectBed = ""<option value='0'>Select Bed</option>"";
            url = '/admin/patient/'

            if (id == 'BuildingID') {
                url = url + 'FillFloorDropDown?BuildingID=' + event.value;
            }
            if (id == 'FloorID') {
                url = url + 'FillRoomDropDown?FloorID=' + event.value;
            }
            if (id == 'RoomID') {
                url = url + 'FillBedDropDown?RoomID=' + event.value;
            }
            if (id == 'AdmissionTypeID') {
                debugger
                url = url + 'FillTypeDropDown?id=' + event.value;
            }
            $.ajax({
                url: url,
                type: 'GET',
                success: function (data) {
                    if (data.length > 0) {
                        if (data[0].buildingI");
                WriteLiteral(@"D) {
                            var markup = ""<option value='0'>Select Floor</option>"";
                            var selectRoom = ""<option value='0'>Select Room</option>"";
                            var selectBed = ""<option value='0'>Select Bed</option>"";
                            if (data.length > 0) {
                                $.each(data, function (val, text) {
                                    markup += ""<option value="" + text.id + "">"" + text.name + ""</option>"";
                                });
                            }
                            $(""#FloorID"").html(markup).show();
                            $(""#RoomID"").html(selectRoom).show();
                            $(""#BedID"").html(selectBed).show();
                        }
                        if (data[0].floorID) {
                            var markup = ""<option value='0'>Select Room</option>"";
                            $.each(data, function (val, text) {
                                markup += """);
                WriteLiteral(@"<option value="" + text.id + "">"" + text.name + ""</option>"";
                            });
                            $(""#RoomID"").html(markup).show();
                            $(""#BedID"").html(selectBed).show();
                        }
                        if (data[0].roomID) {
                            var markup = ""<option value='0'>Select Bed</option>"";
                            $.each(data, function (val, text) {
                                markup += ""<option value="" + text.id + "">"" + text.name + ""</option>"";
                            });
                            $(""#BedID"").html(markup).show();
                        }
                    }
                },
                error: function (xhr, status) {
                    toastr.error('Something went wrong');
                }
            });
        };

        $(document).on(""change"", ""#PatientAdmission_OutPatientTypeID"", function () {
            var OutPatientType = $(this).val();
            if (OutP");
                WriteLiteral(@"atientType != 107) {
                $('#appointReserveWrapper').show();
            } else {
                $('#appointReserveWrapper').hide();
            }
        });

        $(document).on(""change"", ""#TypeID"", function () {
            dynamicAdmissionFields();

        });

        $(document).on(""change"", ""#AppointmentID"", function () {
            dynamicAdmissionFields();
        });

        $(document).on(""change"", ""#PatientAdmission_AppointmentID"", function () {
            var AppointmentID = $(this).val();
            if (AppointmentID != 0 || AppointmentID != null) {

                $.ajax({
                    type: ""GET"",
                    url: '/admin/Patient/GetAppointmentID',
                    data: { AppointmentID: AppointmentID },
                    success: function (data) {
                        console.log(data);
                        debugger
                        $(""#PatientAdmission_DepartmentID"").val(data.departmentID);
                   ");
                WriteLiteral(@"     $(""#PatientAdmission_SpecialityID"").val(data.specialityID);
                        $(""#PatientAdmission_PurposeID"").val(data.purposeID);
                        $(""#Appointment_CreatedBy"").val(data.createdBy);
                        $(""#PatientAdmission_DoctorID"").val(data.doctor.id);
                        $(""#PatientAdmission_RoomID"").val(data.roomID);
                        $(""#PatientAdmission_Note"").val(data.note);
                    },

                    error: function () {
                        alert(""Not able to get appointment details!."");
                    }
                });
            }
        });
        $(""body"").on(""click"", ""#pdfExport"", function () {
            html2canvas($('#patientTbl')[0], {
                onrendered: function (canvas) {
                    var data = canvas.toDataURL();
                    var docDefinition = {
                        content: [{
                            image: data,
                            width: 500
  ");
                WriteLiteral(@"                      }]
                    };
                    pdfMake.createPdf(docDefinition).download(""Table.pdf"");
                }
            });
        });

        function fnExcelReport() {
            var tab_text = ""<table border='2px'><tr bgcolor='#87AFC6'>"";
            var textRange; var j = 0;
            tab = document.getElementById('patientTbl'); // id of table
            $(""#hiddenTable"").html(tab);
            console.log($(""#hiddenTable"").html());
            debugger

            for (j = 0; j < tab.rows.length; j++) {
                tab_text = tab_text + tab.rows[j].innerHTML + ""</tr>"";
            }

            tab_text = tab_text + ""</table>"";
            tab_text = tab_text.replace(/<A[^>]*>|<\/A>/g, """");//remove if u want links in your table
            tab_text = tab_text.replace(/<img[^>]*>/gi, """"); // remove if u want images in your table
            tab_text = tab_text.replace(/<input[^>]*>|<\/input>/gi, """"); // reomves input params

           ");
                WriteLiteral(@" var ua = window.navigator.userAgent;
            var msie = ua.indexOf(""MSIE "");

            if (msie > 0 || !!navigator.userAgent.match(/Trident.*rv\:11\./))      // If Internet Explorer
            {
                txtArea1.document.open(""txt/html"", ""replace"");
                txtArea1.document.write(tab_text);
                txtArea1.document.close();
                txtArea1.focus();
                sa = txtArea1.document.execCommand(""SaveAs"", true, ""Patients.xls"");
            }
            else                 //other browser not tested on IE 11
                sa = window.open('data:application/vnd.ms-excel,' + encodeURIComponent(tab_text));

            return (sa);
        }
    </script>
");
                EndContext();
            }
            );
            BeginContext(23623, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Helpers.PagedData<Data.Models.PatientOrder>> Html { get; private set; }
    }
}
#pragma warning restore 1591
