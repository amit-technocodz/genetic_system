#pragma checksum "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec2123450e0a2b9d6f0723c3070e5919859003de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ClientOrder_AddClientOrder), @"mvc.1.0.view", @"/Areas/Admin/Views/ClientOrder/AddClientOrder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/ClientOrder/AddClientOrder.cshtml", typeof(AspNetCore.Areas_Admin_Views_ClientOrder_AddClientOrder))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec2123450e0a2b9d6f0723c3070e5919859003de", @"/Areas/Admin/Views/ClientOrder/AddClientOrder.cshtml")]
    public class Areas_Admin_Views_ClientOrder_AddClientOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GeneticSystem.Areas.Admin.Models.ClientOrderViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
  
    //ViewData["Title"] = "Add Order";
    //Layout = "~/Views/Shared/_Admin.cshtml";
    ViewBag.CurrentDate = DateTime.UtcNow;
    ViewBag.DueDate = DateTime.UtcNow.AddDays(21);

#line default
#line hidden
            BeginContext(255, 426, true);
            WriteLiteral(@"
<form id=""encounterForm"">
    <fieldset id=""form-fieldset"">
        <div class=""col-md-12"">

            <div class=""row"">
                <div class=""col-md-12 col-lg-12"">
                    <div class=""prtm-block pos-relative"">
                        <div class=""prtm-page-bar"">
                            <ul class=""breadcrumb"">
                                <li class=""breadcrumb-item text-capitalize""><h2>");
            EndContext();
            BeginContext(682, 17, false);
#line 19 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                                                           Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(699, 1117, true);
            WriteLiteral(@"</h2></li>
                                <li class=""breadcrumb-item""><a href=""#"">Registeration</a></li>
                                <li class=""breadcrumb-item""><a href=""#"">Orders</a></li>
                                <li class=""breadcrumb-item""><a href=""#"" class=""active""> New Order</a></li>
                            </ul>
                        </div>


                        <div class=""tab-content pad-all-sm"">

                            <div id=""tab-26"" class="" row tab-pane fade in "">
                                hghgcgh
                            </div>
                            <div id=""tab-27"" class=""tab-pane fade in active"">
                                <div class=""row"">
                                    <div class=""col-md-10"">
                                        <div class=""row"">
                                            <div class=""col-md-3"">
                                                <div class=""form-group"">
                                     ");
            WriteLiteral("               <label>Order No.</label>\r\n                                                    ");
            EndContext();
            BeginContext(1817, 104, false);
#line 39 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                               Write(Html.TextBox("clientOrder.ClientOrder.OrderNo", null, new { @Class = "form-control", @readonly = true }));

#line default
#line hidden
            EndContext();
            BeginContext(1921, 385, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""col-md-3"">
                                                <div class=""form-group"">
                                                    <label>Patient Name</label>
                                                    ");
            EndContext();
            BeginContext(2307, 180, false);
#line 45 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                               Write(Html.DropDownList("clientOrder.ClientOrder.UserID", new SelectList(ViewBag.Clients, "ID", "ArFirstName"), "Select", new { @Class = "form-control dropdown", @onchange = "test();" }));

#line default
#line hidden
            EndContext();
            BeginContext(2487, 490, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""row"">
                                            <div class=""col-md-3"">
                                                <div class=""form-group"">
                                                    <label>Order Date</label>
                                                    ");
            EndContext();
            BeginContext(2978, 124, false);
#line 53 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                               Write(Html.TextBox("clientOrder.ClientOrder.OrderDate", (DateTime)ViewBag.CurrentDate, new { @class = "form-control datepicker" }));

#line default
#line hidden
            EndContext();
            BeginContext(3102, 380, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""col-md-3"">
                                                <div class=""form-group"">
                                                    <label>Regn No</label>
                                                    ");
            EndContext();
            BeginContext(3483, 123, false);
#line 59 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                               Write(Html.TextBox("clientOrder.ClientOrder.User.RegisterationNo", null, new { @Class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(3606, 488, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""row"">
                                            <div class=""col-md-3"">
                                                <div class=""form-group"">
                                                    <label>Due Date</label>
                                                    ");
            EndContext();
            BeginContext(4095, 123, false);
#line 67 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                               Write(Html.TextBox("clientOrder.ClientOrder.OrderDueDate", (DateTime)ViewBag.DueDate, new { @Class = "form-control datepicker" }));

#line default
#line hidden
            EndContext();
            BeginContext(4218, 382, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""col-md-3"">
                                                <div class=""form-group"">
                                                    <label>Test Type</label>
                                                    ");
            EndContext();
            BeginContext(4601, 186, false);
#line 73 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                               Write(Html.DropDownList("clientOrder.ClientOrder.TemplateID", new SelectList(ViewBag.Templates, "ID", "Name"), "Select", new { @Class = "form-control dropdown", @onchange = "GetTemplate();" }));

#line default
#line hidden
            EndContext();
            BeginContext(4787, 1699, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                        </div>
                                        <br />
                                        <div class=""row"">
                                            <div class=""col-md-5"">
                                                <input type=""button"" name=""button"" value=""Save"" onclick=""saveOrderFunction();"" class=""btn btn-xs btn-primary"" id=""signupform"" />
                                                <input type=""button"" name=""submit"" value=""Update"" class=""btn btn-xs btn-warning"" disabled />
                                                <input type=""button"" name=""submit"" value=""History"" class=""btn btn-xs btn-info"" disabled />
                                                <input type=""button"" name=""submit"" value=""Attachment"" class=""btn btn-xs btn-warning"" disabled />
                                                <input type=""button"" name=""submit"" va");
            WriteLiteral(@"lue=""Reminder"" class=""btn btn-xs btn-info"" disabled />
                                            </div>
                                        </div>
                                        <br />
                                        <div class=""col-md-12"" id=""setTemplate"">
                                        </div>
                                        <div class=""row"">
                                            <div class=""col-md-8"">
                                                <div class=""form-group"">
                                                    <h4 id=""summary-Name"">Summary</h4>
                                                    ");
            EndContext();
            BeginContext(6487, 86, false);
#line 94 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                               Write(Html.TextArea("clientOrder.ClientOrder.OrderSummary", new { @Class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(6573, 490, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""row"">
                                            <div class=""col-md-8"">
                                                <div class=""form-group"">
                                                    <h4>Follow Up Needed</h4>
                                                    ");
            EndContext();
            BeginContext(7064, 203, false);
#line 102 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                               Write(Html.ListBox("clientOrder.ClientOrder.FollowUpArray", new MultiSelectList(ViewBag.EffectedGene, "ID", "Name", null), htmlAttributes: new { @class = "tryMultiselect form-control", multiple = "multiple" }));

#line default
#line hidden
            EndContext();
            BeginContext(7267, 415, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""row"">
                                            <div class=""col-md-8"">
                                                <div class=""form-group"">
                                                    <h4>");
            EndContext();
            BeginContext(7707, 69, true);
            WriteLiteral(" TestName </h4>\r\n                                                    ");
            EndContext();
            BeginContext(7777, 200, false);
#line 110 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                               Write(Html.ListBox("clientOrder.ClientOrder.TestTypeArray", new MultiSelectList(ViewBag.TestTypes, "ID", "Name", null), htmlAttributes: new { @class = "tryMultiselect form-control", multiple = "multiple" }));

#line default
#line hidden
            EndContext();
            BeginContext(7977, 487, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""row"">
                                            <div class=""col-md-8"">
                                                <div class=""form-group"">
                                                    <h4>Assign Doctor</h4>
                                                    ");
            EndContext();
            BeginContext(8465, 182, false);
#line 118 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                               Write(Html.DropDownList("clientOrder.ClientOrder.DoctorID", new SelectList(ViewBag.Clients, "ID", "ArFirstName"), "Select", new { @Class = "form-control dropdown", @onchange = "test();" }));

#line default
#line hidden
            EndContext();
            BeginContext(8647, 1297, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""col-md-2"">
                                        <div class=""profile-box-r"">
                                            <div class=""row mrgn-all-xs"">
                                                <div class=""col-md-12"">
                                                    <div class=""pro-pic"">
                                                        <img src=""/assets/img/user-1.jpg"" alt="""">

                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""row"">
                                                <div class=""col-md-12"">

                                                    <div class=");
            WriteLiteral(@"""form-group"">
                                                        <label>
                                                            Birthdate
                                                        </label>
                                                        ");
            EndContext();
            BeginContext(9945, 145, false);
#line 140 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                                   Write(Html.TextBox("clientOrder.ClientOrder.User.PatientPersonalInformation.DateOfBirth",null, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(10090, 274, true);
            WriteLiteral(@"
                                                    </div>
                                                    <div class=""form-group"">
                                                        <label>ID No</label>
                                                        ");
            EndContext();
            BeginContext(10365, 109, false);
#line 144 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                                   Write(Html.TextBox("clientOrder.ClientOrder.User.ID",null, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(10474, 62, true);
            WriteLiteral("\r\n                                                    </div>\r\n");
            EndContext();
            BeginContext(10887, 211, true);
            WriteLiteral("                                                    <div class=\"form-group\">\r\n                                                        <label>City</label>\r\n                                                        ");
            EndContext();
            BeginContext(11099, 143, false);
#line 152 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                                   Write(Html.TextBox("clientOrder.ClientOrder.User.PatientPersonalInformation.City.Name", null,new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(11242, 276, true);
            WriteLiteral(@"
                                                    </div>
                                                    <div class=""form-group"">
                                                        <label>Address</label>
                                                        ");
            EndContext();
            BeginContext(11519, 114, false);
#line 156 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                                   Write(Html.TextBox("clientOrder.ClientOrder.User.Address",null, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(11633, 275, true);
            WriteLiteral(@"
                                                    </div>
                                                    <div class=""form-group"">
                                                        <label>Mobile</label>
                                                        ");
            EndContext();
            BeginContext(11909, 113, false);
#line 160 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                                   Write(Html.TextBox("clientOrder.ClientOrder.User.Mobile", null,new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(12022, 277, true);
            WriteLiteral(@"
                                                    </div>
                                                    <div class=""form-group"">
                                                        <label>Blood GR</label>
                                                        ");
            EndContext();
            BeginContext(12300, 149, false);
#line 164 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                                   Write(Html.TextBox("clientOrder.ClientOrder.User.PatientPersonalInformation.BloodGroup.Name",null, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(12449, 62, true);
            WriteLiteral("\r\n                                                    </div>\r\n");
            EndContext();
            BeginContext(13218, 2963, true);
            WriteLiteral(@"                                                </div>
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
    </fieldset>
</form>
<script>




                function test() {
                    debugger

            var user = $(""#PatientID"").val();
         //   alert(user);
            $.ajax({

                url: ""/admin/patientorder/getpatientDetails"",
                type: ""get"",
                data: { 'Id': user },
                success: function (data) {
                    console.log(data);
                    $(""#User_PatientPersonalInformation_DateOfBirth"").val(data.patientPersonalInformation.dateOfBirth);
                    $(""#User_ID"").val(user);
                    $(""#User_Regist");
            WriteLiteral(@"erationNo"").val(data.registerationNo);
                    $(""#User_Address"").val(data.address);

                    $(""#User_Mobile"").val(data.mobile);
                     $(""#User_PatientPersonalInformation_BloodGroup_Name"").val(data.patientPersonalInformation.bloodGroup.name);
                },
                error: function () {
                }
            });
        }
        var objfill;


        //$('select').selectpicker();
        function Uncheck(data) {
            var test = $(data).attr(""data-info"");
            if ($(data).prop(""checked"")) {
                document.getElementById(test).removeAttribute('readonly');
            }
            else {
               document.getElementById(test).setAttribute('readonly',true);
            }
        }
        function enabletextbox(data) {
            var test = $(data).attr(""data-info"");
            var test1 = $(data).attr(""datainfo1"");
            if ($(data).prop(""checked"")) {
                document.getElementB");
            WriteLiteral(@"yId(test).removeAttribute('readonly');
                document.getElementById(test1).removeAttribute('readonly');
            }
            else {
                document.getElementById(test).setAttribute('readonly', true);
                document.getElementById(test1).setAttribute('readonly',true);
            }

        }
        function showdetail() {
            $(""#detail-div"").toggle();
        }
        function autocomplete(data) {
        $('.autocomplete').autocomplete({
            source: '/admin/patientOrder/AutoCompleteNameWithID',
            minLength: 0,
            select: function (event, ui) {
                $(""#hiddenUserID"").val(ui.item.id);
            },
        }).focus(function () {
            $('.autocomplete').autocomplete(""search"");
        });
    }
    $('.autocomplete').autocomplete(""option"", ""appendTo"", "".eventInsForm"");

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GeneticSystem.Areas.Admin.Models.ClientOrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
