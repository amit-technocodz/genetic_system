#pragma checksum "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ActionControl\ActionPermission.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24293a1e310e743f2f9828fb746a1064d649003f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ActionControl_ActionPermission), @"mvc.1.0.view", @"/Areas/Admin/Views/ActionControl/ActionPermission.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/ActionControl/ActionPermission.cshtml", typeof(AspNetCore.Areas_Admin_Views_ActionControl_ActionPermission))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24293a1e310e743f2f9828fb746a1064d649003f", @"/Areas/Admin/Views/ActionControl/ActionPermission.cshtml")]
    public class Areas_Admin_Views_ActionControl_ActionPermission : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Data.Models.ActionPermission>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ActionControl\ActionPermission.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(137, 868, true);
            WriteLiteral(@"<div class=""prtm-content"">
    <div class=""prtm-page-bar"">
        <ul class=""breadcrumb"">
            <li class=""breadcrumb-item text-capitalize""><h2>Role Based Permissions</h2></li>
            <li class=""breadcrumb-item""><a href=""#"">Access permission</a></li>
            <li class=""breadcrumb-item""><a href=""#"">Dashoboard</a></li>
            <li class=""breadcrumb-item""><a href=""#"" class=""active"">Admin</a></li>
        </ul>
    </div>
    <div class=""table-style"">
        <div class=""row mrgn-b-sm"">
            <div class=""col-md-12 col-lg-12"">
                <div class=""quick-search-block"">
                    <div class=""row"">
                        <div class=""col-md-10 col-lg-10"">
                            <div id=""searchDiv"" class=""row"">
                                <div class=""col-md-6"">
                                    ");
            EndContext();
            BeginContext(1006, 166, false);
#line 23 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\ActionControl\ActionPermission.cshtml"
                               Write(Html.DropDownList("RoleID", new SelectList(ViewBag.Role, "ID", "Name"), "Select Role", new { @Class = "form-control dropdown", onchange = "CheckActionAccess(this)" }));

#line default
#line hidden
            EndContext();
            BeginContext(1172, 356, true);
            WriteLiteral(@"
                                </div>
                                <div id=""actionDivData"" class=""col-md-12"" style=""margin-top:2%"">

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
            DefineSection("Scripts", async() => {
                BeginContext(1545, 1817, true);
                WriteLiteral(@"
    <script>

        //function RoleSelection(this) {

        //}


        $('.action-button').click(function () {
            debugger
            var id = this.id;
            var val = this.dataset.value;
            if (val) {
                url = '/admin/ActionControl/' + id + ""?id="" + val;
            }
            else {
                url = '/admin/ActionControl/' + id
            }
            $.ajax({
                url: url,
                type: 'GET',
                success: function (result) {
                    debugger
                    $("".modal-content"").html(result);
                },
                error: function (xhr, status) {
                    toastr.error('Something went wrong');
                }
            });
        });

        function EnableAction(id, event) {
            debugger
            var status = $(""#IsEnabled"").is(':checked');
            $.ajax({
                url: '/admin/ActionControl/UpdateActionPermission?id=' ");
                WriteLiteral(@"+ id + '&status=' + event.checked,
                type: 'POST',
                success: function (result) {
                   toastr.info('Permission updated.');
                },
                error: function (xhr, status) {
                   toastr.error('Something went wrong');
                }
            });
        }
        function CheckActionAccess(data) {
            debugger
			if (data.value == """") {
				return false;
			}
		var RoleID = data.value;
		SelectedRoleID = RoleID;
		$.ajax({
			url: ""/admin/ActionControl/CheckActionAccess/"" + RoleID,
			type: 'Get',
			success: function (result) {
				debugger;
				$(""#actionDivData"").html(result);
			},
			error: function (xhr, status) {
				alert(status)
				}
			})
		}

    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Data.Models.ActionPermission>> Html { get; private set; }
    }
}
#pragma warning restore 1591
