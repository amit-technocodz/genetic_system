#pragma checksum "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b02fa2e9c80091137525643d34bdd6aa82908744"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b02fa2e9c80091137525643d34bdd6aa82908744", @"/Areas/Admin/Views/ClientOrder/AddClientOrder.cshtml")]
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
            BeginContext(255, 977, true);
            WriteLiteral(@"
<form id=""encounterForm"">
    <fieldset id=""form-fieldset"">
        <div class=""col-md-12"">
            <div class=""row"">
                <div class=""col-md-12 col-lg-12"">
                    <div class=""prtm-block pos-relative"">
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
                                                    <label>Order No.</label>
                                                    ");
            EndContext();
            BeginContext(1233, 127, false);
#line 27 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                               Write(Html.TextBox("clientOrder.ClientOrder.OrderNo", Model?.ClientOrder?.OrderNo, new { @Class = "form-control", @readonly = true }));

#line default
#line hidden
            EndContext();
            BeginContext(1360, 385, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""col-md-3"">
                                                <div class=""form-group"">
                                                    <label>Patient Name</label>
                                                    ");
            EndContext();
            BeginContext(1746, 208, false);
#line 33 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                               Write(Html.DropDownList("clientOrder.ClientOrder.UserID", new SelectList(ViewBag.Clients, "ID", "ArFirstName", Model?.ClientOrder?.UserID), "Select", new { @Class = "form-control dropdown", @onchange = "test();" }));

#line default
#line hidden
            EndContext();
            BeginContext(1954, 490, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""row"">
                                            <div class=""col-md-3"">
                                                <div class=""form-group"">
                                                    <label>Created By</label>
                                                    ");
            EndContext();
            BeginContext(2445, 142, false);
#line 41 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                               Write(Html.TextBox("clientOrder.ClientOrder.CreatedBy", Model?.ClientOrder?.CreatedBy, new { @class = "form-control datepicker", @readonly = true }));

#line default
#line hidden
            EndContext();
            BeginContext(2587, 385, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""col-md-3"">
                                                <div class=""form-group"">
                                                    <label>Created Date</label>
                                                    ");
            EndContext();
            BeginContext(2973, 170, false);
#line 47 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                               Write(Html.TextBox("clientOrder.ClientOrder.CreatedOn", Model?.ClientOrder?.CreatedOn ?? (DateTime)ViewBag.CurrentDate, new { @Class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(3143, 490, true);
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
            BeginContext(3634, 175, false);
#line 55 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                               Write(Html.TextBox("clientOrder.ClientOrder.OrderDate", Model?.ClientOrder?.OrderDate ?? (DateTime)ViewBag.CurrentDate, new { @class = "form-control datepicker", @readonly = true }));

#line default
#line hidden
            EndContext();
            BeginContext(3809, 380, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""col-md-3"">
                                                <div class=""form-group"">
                                                    <label>Regn No</label>
                                                    ");
            EndContext();
            BeginContext(4190, 160, false);
#line 61 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                               Write(Html.TextBox("clientOrder.ClientOrder.User.RegisterationNo", Model?.ClientOrder?.User?.RegisterationNo, new { @Class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(4350, 488, true);
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
            BeginContext(4839, 159, false);
#line 69 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                               Write(Html.TextBox("clientOrder.ClientOrder.OrderDueDate", Model?.ClientOrder?.OrderDueDate ?? (DateTime)ViewBag.DueDate, new { @Class = "form-control datepicker" }));

#line default
#line hidden
            EndContext();
            BeginContext(4998, 382, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""col-md-3"">
                                                <div class=""form-group"">
                                                    <label>Test Type</label>
                                                    ");
            EndContext();
            BeginContext(5381, 218, false);
#line 75 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                               Write(Html.DropDownList("clientOrder.ClientOrder.TemplateID", new SelectList(ViewBag.Templates, "ID", "Name", Model?.ClientOrder?.TemplateID), "Select", new { @Class = "form-control dropdown", @onchange = "GetTemplate();" }));

#line default
#line hidden
            EndContext();
            BeginContext(5599, 1329, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                        </div>
                                        <br />
                                        <div class=""row"">
                                            <div class=""col-md-5"">
                                                <input type=""button"" name=""button"" value=""Save"" onclick=""saveOrderFunction();"" class=""btn btn-xs btn-primary"" id=""signupform"" />
                                                <input type=""button"" name=""submit"" id=""postUpdatebtn"" value=""Update"" class=""btn btn-xs btn-warning"" disabled />
                                                <input type=""button"" name=""submit"" value=""History"" class=""btn btn-xs btn-info"" disabled />
                                                <input type=""button"" name=""submit"" value=""Attachment"" class=""btn btn-xs btn-warning"" disabled />
                                                <input type=""butto");
            WriteLiteral(@"n"" name=""submit"" value=""Reminder"" class=""btn btn-xs btn-info"" disabled />
                                            </div>
                                        </div>
                                        <br />
                                        <div class=""col-md-12"" id=""setTemplate"">
");
            EndContext();
#line 91 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                             if (Model != null)
                                            {
                                                {
                                                    await Html.RenderPartialAsync("_GetClientOrder");
                                                }
                                            }

#line default
#line hidden
            BeginContext(7292, 391, true);
            WriteLiteral(@"
                                        </div>
                                        <div class=""row"">
                                            <div class=""col-md-8"">
                                                <div class=""form-group"">
                                                    <h4 id=""summary-Name"">Summary</h4>
                                                    ");
            EndContext();
            BeginContext(7684, 120, false);
#line 103 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                               Write(Html.TextArea("clientOrder.ClientOrder.OrderSummary", Model?.ClientOrder?.OrderSummary, new { @Class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(7804, 490, true);
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
            BeginContext(8295, 232, false);
#line 111 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                               Write(Html.ListBox("clientOrder.ClientOrder.FollowUpArray", new MultiSelectList(ViewBag.EffectedGene, "ID", "Name", Model?.ClientOrder?.FollowUpArray), htmlAttributes: new { @class = "tryMultiselect form-control", multiple = "multiple" }));

#line default
#line hidden
            EndContext();
            BeginContext(8527, 415, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""row"">
                                            <div class=""col-md-8"">
                                                <div class=""form-group"">
                                                    <h4>");
            EndContext();
            BeginContext(8967, 69, true);
            WriteLiteral(" TestName </h4>\r\n                                                    ");
            EndContext();
            BeginContext(9037, 229, false);
#line 119 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                               Write(Html.ListBox("clientOrder.ClientOrder.TestTypeArray", new MultiSelectList(ViewBag.TestTypes, "ID", "Name", Model?.ClientOrder?.TestTypeArray), htmlAttributes: new { @class = "tryMultiselect form-control", multiple = "multiple" }));

#line default
#line hidden
            EndContext();
            BeginContext(9266, 487, true);
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
            BeginContext(9754, 212, false);
#line 127 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                               Write(Html.DropDownList("clientOrder.ClientOrder.DoctorID", new SelectList(ViewBag.Doctors, "ID", "ArFirstName", Model?.ClientOrder?.DoctorID), "Select", new { @Class = "form-control dropdown", @onchange = "test();" }));

#line default
#line hidden
            EndContext();
            BeginContext(9966, 1297, true);
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
            BeginContext(11264, 200, false);
#line 149 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                                   Write(Html.TextBox("clientOrder.ClientOrder.User.PatientPersonalInformation.DateOfBirth", Model?.ClientOrder?.User?.PersonalInformation?.DateOfBirth, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(11464, 274, true);
            WriteLiteral(@"
                                                    </div>
                                                    <div class=""form-group"">
                                                        <label>ID No</label>
                                                        ");
            EndContext();
            BeginContext(11739, 132, false);
#line 153 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                                   Write(Html.TextBox("clientOrder.ClientOrder.User.ID", Model?.ClientOrder?.UserID, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(11871, 62, true);
            WriteLiteral("\r\n                                                    </div>\r\n");
            EndContext();
            BeginContext(12284, 211, true);
            WriteLiteral("                                                    <div class=\"form-group\">\r\n                                                        <label>City</label>\r\n                                                        ");
            EndContext();
            BeginContext(12496, 197, false);
#line 161 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                                   Write(Html.TextBox("clientOrder.ClientOrder.User.PatientPersonalInformation.City.Name", Model?.ClientOrder?.User?.PersonalInformation?.City?.Name, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(12693, 276, true);
            WriteLiteral(@"
                                                    </div>
                                                    <div class=""form-group"">
                                                        <label>Address</label>
                                                        ");
            EndContext();
            BeginContext(12970, 144, false);
#line 165 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                                   Write(Html.TextBox("clientOrder.ClientOrder.User.Address", Model?.ClientOrder?.User?.Address, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(13114, 275, true);
            WriteLiteral(@"
                                                    </div>
                                                    <div class=""form-group"">
                                                        <label>Mobile</label>
                                                        ");
            EndContext();
            BeginContext(13390, 142, false);
#line 169 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                                   Write(Html.TextBox("clientOrder.ClientOrder.User.Mobile", Model?.ClientOrder?.User?.Mobile, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(13532, 277, true);
            WriteLiteral(@"
                                                    </div>
                                                    <div class=""form-group"">
                                                        <label>Blood GR</label>
                                                        ");
            EndContext();
            BeginContext(13810, 216, false);
#line 173 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\AddClientOrder.cshtml"
                                                   Write(Html.TextBox("clientOrder.ClientOrder.User.PatientPersonalInformation.BloodGroup.Name", Model?.ClientOrder?.User?.PatientPersonalInformation?.BloodGroup?.Name, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
            EndContext();
            BeginContext(14026, 62, true);
            WriteLiteral("\r\n                                                    </div>\r\n");
            EndContext();
            BeginContext(14795, 1875, true);
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

    var objfill;


    //$('select').selectpicker();
    function Uncheck(data) {
        var test = $(data).attr(""data-info"");
        if ($(data).prop(""checked"")) {
            document.getElementById(test).removeAttribute('readonly');
        }
        else {
            document.getElementById(test).setAttribute('readonly', true);
        }
    }
    function enabletextbox(data) {
        var test = $(data).attr(""data-info"");
        var test1 = $(data).attr(""datainfo1"");
        if ($(data).prop(""checked"")) {
            document.getElementById(test).removeAttri");
            WriteLiteral(@"bute('readonly');
            document.getElementById(test1).removeAttribute('readonly');
        }
        else {
            document.getElementById(test).setAttribute('readonly', true);
            document.getElementById(test1).setAttribute('readonly', true);
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
