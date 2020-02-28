#pragma checksum "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d36d2fb0ceed86f79edcb19b46f69ecf9490b007"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ClientOrder_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ClientOrder/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/ClientOrder/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_ClientOrder_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d36d2fb0ceed86f79edcb19b46f69ecf9490b007", @"/Areas/Admin/Views/ClientOrder/Index.cshtml")]
    public class Areas_Admin_Views_ClientOrder_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Helpers.PagedData<Data.Models.ClientOrder>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\Index.cshtml"
  
    ViewData["Title"] = "Order List";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(150, 479, true);
            WriteLiteral(@"
<style>
    .footer-wrapper {
        display: none;
        float: left;
        width: 100%;
        position: absolute;
        bottom: 0;
        padding-left: 190px;
    }


    .quick-search-block {
        border: 1px solid #eaebed;
        background: #f4f5f7;
        padding: 5px;
    }
</style>
<div class=""prtm-content"">
    <div class=""prtm-page-bar"">
        <ul class=""breadcrumb"">
            <li class=""breadcrumb-item text-capitalize""><h2>");
            EndContext();
            BeginContext(630, 17, false);
#line 28 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\Index.cshtml"
                                                       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(647, 2976, true);
            WriteLiteral(@"</h2></li>
            <li class=""breadcrumb-item""><a href=""#"">Dashboard</a></li>
            <li class=""breadcrumb-item""><a href=""#"">Ui elements</a></li>
            <li class=""breadcrumb-item""><a href=""#"" class=""active"">Order List</a></li>
        </ul>
    </div>

    <div class=""table-style"">
        <div class=""row mrgn-b-sm"">
            <div class=""col-md-4 col-lg-4"">
                <div class=""btn-group"" role=""group"">
                    <button class=""btn btn-primary btn-lg"" id=""addClientOrderBtn"" type=""button""> New Order </button>
                    <button class=""btn btn-warning btn-lg cancelEvent"" id=""cancelOrderBtn"" type=""button"" style=""display: none;""> Back </button>
                    <button data-toggle=""dropdown"" class=""btn btn-lg btn-info dropdown-toggle"" type=""button""><i class=""fa fa-share-square-o"" aria-hidden=""true""></i> Export <i class=""fa fa-sort-desc"" aria-hidden=""true""></i> </button>
                </div>
            </div>
            <div class=""col-md-3"">
     ");
            WriteLiteral(@"       </div>
        </div>
        <div id=""quickSearchBlock"" class=""row mrgn-b-sm"">
            <div class=""col-md-12 col-lg-12"">
                <h5>Quick Search</h5>
                <div class=""quick-search-block"">
                    <div class=""row"">
                        <div class=""col-md-10 col-lg-10"">
                            <div class=""row"">
                                <div class=""col-md-2 col-lg-2"">
                                    Registration No:
                                    <input type=""text"" id=""registerNo"" name=""register-no"" class=""form-control"" onkeyup=""patientSearch()"" />
                                </div>
                                <div class=""col-md-2 col-lg-2"">
                                    ID No:
                                    <input type=""text"" id=""id-no"" name=""id-no"" class=""form-control"" autocomplete=""off"" onkeyup=""patientSearch()"" />
                                </div>
                                <div class=""col-md-2 co");
            WriteLiteral(@"l-lg-2"">
                                    Patient Name:
                                    <input type=""text"" id=""patientName"" name=""patient-name"" class=""form-control"" autocomplete=""off"" onkeyup=""patientSearch()"" />
                                </div>
                                <div class=""col-md-2 col-lg-2"">
                                    Birth Date:
                                    <input type=""text"" name=""birth-date"" class=""form-control datepicker"" autocomplete=""off"" onchange=""patientSearch()"" />
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""prtm-block pos-relative"">
            <div class=""prtm-block-content"">
                <div class=""table-responsive"">
                    <div id=""orderArea"" class=""unseen"">
");
            EndContext();
#line 81 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\Index.cshtml"
                          
                            await Html.RenderPartialAsync("_Index");
                        

#line default
#line hidden
            BeginContext(3748, 901, true);
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
                BeginContext(4666, 20340, true);
                WriteLiteral(@"
    <script>
        var ListHtml;

        $(document).on(""click"", "".UpdtOrdrBtn"", function () {
            ListHtml = document.getElementById('orderArea').innerHTML;
            var orderId = $(this).val();
            $.ajax({
                url: '/admin/clientOrder/updateOrder',
                type: 'GET',
                data: {
                    orderId: orderId
                },
                success: function (result) {
                    $('#orderArea').html(result);
                    loadMultiSelect();
                    document.getElementById(""postUpdatebtn"").style.display = 'block';
                    document.getElementById(""signupform"").style.display = 'none';
                                            document.getElementById(""quickSearchBlock"").hidden = true;
                        document.getElementById(""addClientOrderBtn"").style.display = 'none';
                        document.getElementById(""cancelOrderBtn"").style.display = 'block';
                  ");
                WriteLiteral(@"  document.getElementById(""postUpdatebtn"").addEventListener(""click"", function () {
                        updateOrderData();
                    });
                },
                error: function () {
                    toastr.error(""Something went wrong!"");
                }
            });
        });

        
        $(document).on(""click"", "".cancelEvent"", function () {
            document.getElementById('orderArea').innerHTML = ListHtml; 
            document.getElementById(""cancelOrderBtn"").style.display = 'none';
            document.getElementById(""addClientOrderBtn"").style.display = 'block';
            document.getElementById(""quickSearchBlock"").hidden = false;
        });

        document.getElementById(""addClientOrderBtn"").addEventListener(""click"", function () {
            orderAreaData = document.getElementById(""orderArea"").innerHTML;
            addOrderData();
        });



        function updateOrderData() {
            var formdata = new FormData($('form')");
                WriteLiteral(@".get(0));
            formdata.append(""GeneTemplateId"", $(""#TestType"").val());
            //for (var pair of formdata.entries()) {
            //    console.log(pair[0] + ', ' + pair[1]);
            //    }
            $.ajax({
                type: 'POST',
                url: ""/admin/clientorder/UpdateOrder"",
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

        function resetOrderArea() {
            document.getElementById(""orderArea"").innerHTML = orderAreaData;
        }

        function addOrderData() {
            ListHtml = document.getElementById('orderArea').innerHTML;
    ");
                WriteLiteral(@"        $.ajax({
                type: ""GET"",
                url: '/admin/clientorder/addOrder',
                success: function (result) {
                    $('#orderArea').html(result);
                    loadMultiSelect();
                   document.getElementById(""quickSearchBlock"").hidden = true;
                   document.getElementById(""addClientOrderBtn"").style.display = 'none';
                   document.getElementById(""cancelOrderBtn"").style.display = 'block';
                },
                error: function () {
                    alert(""Content load failed."");
                }
            });
        }

        function loadMultiSelect() {
            $('.tryMultiselect').chosen();
        }

        function GetTemplate() {
            var testtype = $(""#clientOrder_ClientOrder_TemplateID"").val();
            $.ajax({
                url: '/admin/clientOrder/GetTemplateData',
                type: 'get',
                data: {
                    type: test");
                WriteLiteral(@"type
                },
                success: function (result) {
                    $(""#setTemplate"").html(result);
                    $('.tryMultiselect').chosen();
                }
            });
        }

           function test() {
               var user = $(""#clientOrder_ClientOrder_UserID"").val();
        $.ajax({

            url: ""/admin/patientorder/getpatientDetails"",
            type: ""get"",
            data: { 'Id': user },
            success: function (data) {
                debugger
                $(""#clientOrder_ClientOrder_User_PatientPersonalInformation_DateOfBirth"").val(data.patientPersonalInformation.dateOfBirth);
                $(""#clientOrder_ClientOrder_User_ID"").val(user);
                $(""#clientOrder_ClientOrder_User_PatientPersonalInformation_BloodGroup_Name"").val(data.patientPersonalInformation.bloodGroup.name);
                $(""#clientOrder_ClientOrder_User_RegisterationNo"").val(data.registerationNo);
                $(""#clientOrder_ClientOr");
                WriteLiteral(@"der_User_Address"").val(data.address);
                $(""#clientOrder_ClientOrder_User_Mobile"").val(data.patientPersonalInformation.City.Name);
            },
            error: function () {
            }
        });
    }

        function saveOrderFunction() {
            var formdata = new FormData($('form').get(0));
            formdata.append(""GeneTemplateId"", $(""#TestType"").val());
            //for (var pair of formdata.entries()) {
            //    console.log(pair[0] + ', ' + pair[1]);
            //}
            $.ajax({
                type: 'POST',
                url: ""/admin/clientorder/AddOrder"",
                data: formdata,
                dataType: ""text"",
                processData: false,
                contentType: false,
                success: function (response) {
                    toastr.info('Record saved');
                    document.getElementById(""orderArea"").innerHTML = response;
                },
                error: function (xhr, status) ");
                WriteLiteral(@"{
                    toastr.error('Something went wrong');
                }
            });
        }



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
            debugger");
                WriteLiteral(@"
        });

        $(document).ready(function () {
            $(""body"").on(""click"", '.page-number', function () {
                var page = parseInt($(this).html());
                debugger
                $.ajax({
                    url: '/admin/clientorder/getOrders',
                    data: { ""page"": page },
                    success: function (data) {
                        $(""#orderArea"").html(data);
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
                debugg");
                WriteLiteral(@"er
                inpatient = $('#inPatientCheckBox').val();
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
            }
            debugger
            $.ajax({
                url: '/admin/patient/SearchPatient',
                type: 'POST',
                da");
                WriteLiteral(@"ta: model,
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
                            url: '/admin/patient/GetAppointmentReservedBy',
                            type: 'POST',
                       ");
                WriteLiteral(@"     data: { AppointmentID: AppointmentID },
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
            var id = this.id;
            var val = this.dataset.value;
            debugge");
                WriteLiteral(@"r
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
                    debugger
                    $("".modal-content"").html(result);
                    if (id == ""admission"") {
                        dynamicAdmissionFields();
                    }
                },
                error: function (xhr, status) {
                    debugger
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
                url: url,
           ");
                WriteLiteral(@"     type: 'GET',
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
                }
            });
");
                WriteLiteral(@"        };

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
                        if (data[0].buildingID) {
               ");
                WriteLiteral(@"             var markup = ""<option value='0'>Select Floor</option>"";
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
                                markup += ""<option value="" + tex");
                WriteLiteral(@"t.id + "">"" + text.name + ""</option>"";
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
            if (OutPatientType != 107) {");
                WriteLiteral(@"
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
                        $(""#PatientAdmis");
                WriteLiteral(@"sion_SpecialityID"").val(data.specialityID);
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
                        }");
                WriteLiteral(@"]
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

            var ua = window.naviga");
                WriteLiteral(@"tor.userAgent;
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
    <script src=""https://cdn.jsdelivr.net/npm/chosen-js@1.8.7/chosen.jquery.js"" integrity=""sha256-TDtzz+WOGufaQuQzqpEnnxdJQW5xrU+pzjznwBtaWs4="" crossorigin=""anonymous""></script>
");
                EndContext();
            }
            );
            BeginContext(25009, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Helpers.PagedData<Data.Models.ClientOrder>> Html { get; private set; }
    }
}
#pragma warning restore 1591
