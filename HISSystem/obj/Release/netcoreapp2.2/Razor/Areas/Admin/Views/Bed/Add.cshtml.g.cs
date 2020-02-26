#pragma checksum "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Bed\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f46df8e0a45dc9fab1c13a3954b55a826cc80329"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Bed_Add), @"mvc.1.0.view", @"/Areas/Admin/Views/Bed/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Bed/Add.cshtml", typeof(AspNetCore.Areas_Admin_Views_Bed_Add))]
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
#line 2 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Bed\Add.cshtml"
using Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f46df8e0a45dc9fab1c13a3954b55a826cc80329", @"/Areas/Admin/Views/Bed/Add.cshtml")]
    public class Areas_Admin_Views_Bed_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Models.Bed>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Bed\Add.cshtml"
  
    ViewData["Title"] = "Add Bed";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(133, 136, true);
            WriteLiteral("<style>\r\n    .border-left {\r\n        border-left: 1px solid black;\r\n    }\r\n\r\n    .mg-t {\r\n        margin-top: 10PX;\r\n    }\r\n</style>\r\n\r\n");
            EndContext();
#line 17 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Bed\Add.cshtml"
 using (Html.BeginForm("Add", "Areas/Admin/Bed/", FormMethod.Post))
{

#line default
#line hidden
            BeginContext(341, 154, true);
            WriteLiteral("<div class=\"prtm-content\">\r\n    <div class=\"prtm-page-bar\">\r\n        <ul class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item text-capitalize\"><h2>");
            EndContext();
            BeginContext(496, 17, false);
#line 22 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Bed\Add.cshtml"
                                                       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(513, 1120, true);
            WriteLiteral(@"</h2></li>
            <li class=""breadcrumb-item""><a href=""#"">Dashboard</a></li>
            <li class=""breadcrumb-item""><a href=""#"">Ui elements</a></li>
            <li class=""breadcrumb-item""><a href=""#"" class=""active""> New Patient</a></li>
        </ul>
    </div>
    <div class=""col-md-4 col-lg-4"">
        <input type=""submit"" name=""submit"" value=""Save"" class=""btn btn-xs btn-primary"" />
        <input type=""button"" name=""submit"" value=""Update"" class=""btn btn-xs btn-warning"" />
        <a href=""/admin/bed/index"" class=""btn btn-xs btn-info"">Back</a>
    </div>
    <div class=""form-style"">
        <div class=""row"">
            <div class=""col-md-12 col-lg-12"">
                <div class=""prtm-block pos-relative"">
                    <div class=""row"">
                        <div class=""col-md-12 col-lg-12"">
                            <div class=""row"">
                                <div class=""col-md-3 col-lg-3"">
                                    <div class=""form-group"">
            ");
            WriteLiteral("                            <label for=\"ID\">ID</label>\r\n                                        ");
            EndContext();
            BeginContext(1634, 89, false);
#line 43 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Bed\Add.cshtml"
                                   Write(Html.TextBoxFor(m => m.ID, "{0:##}", new { @Class = "form-control", @Disabled = "true" }));

#line default
#line hidden
            EndContext();
            BeginContext(1723, 328, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""col-md-3 col-lg-3"">
                                    <div class=""form-group"">
                                        <label for=""Name"">BedName</label>
                                        ");
            EndContext();
            BeginContext(2052, 67, false);
#line 49 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Bed\Add.cshtml"
                                   Write(Html.TextBoxFor(m => m.Name, null, new { @Class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2119, 335, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""col-md-3 col-lg-3"">
                                    <div class=""form-group"">
                                        <label for=""BedNumber"">BedNumber</label>
                                        ");
            EndContext();
            BeginContext(2455, 72, false);
#line 55 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Bed\Add.cshtml"
                                   Write(Html.TextBoxFor(m => m.BedNumber, null, new { @Class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2527, 337, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""col-md-3 col-lg-3"">
                                    <div class=""form-group"">
                                        <label for=""Department"">Department</label>
                                        ");
            EndContext();
            BeginContext(2865, 152, false);
#line 61 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Bed\Add.cshtml"
                                   Write(Html.DropDownListFor(m => m.DepartmentID, new SelectList(ViewBag.Department, "ID", "Name"), "Department Name", new { @class = "form-control dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(3017, 420, true);
            WriteLiteral(@"
                                    </div>
                                </div>

                            </div>
                            <div class=""row"">
                                <div class=""col-md-3 col-lg-3"">
                                    <div class=""form-group"">
                                        <label for=""BuildingID"">Building</label>
                                        ");
            EndContext();
            BeginContext(3438, 144, false);
#line 70 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Bed\Add.cshtml"
                                   Write(Html.DropDownListFor(m => m.BuildingID, new SelectList(ViewBag.Building, "ID", "Name"), new { @class = "form-control dropdown searchDropDown" }));

#line default
#line hidden
            EndContext();
            BeginContext(3582, 333, true);
            WriteLiteral(@"
                                    </div>
                                </div>


                                <div class=""col-md-3 col-lg-3"">
                                    <div class=""form-group"">
                                        <label for=""FloorID"">Floor</label>
                                        ");
            EndContext();
            BeginContext(3916, 137, false);
#line 78 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Bed\Add.cshtml"
                                   Write(Html.DropDownListFor(m => m.FloorID, new SelectList(string.Empty, "ID", "Name"), new { @class = "form-control dropdown searchDropDown" }));

#line default
#line hidden
            EndContext();
            BeginContext(4053, 325, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""col-md-3 col-lg-3"">
                                    <div class=""form-group"">
                                        <label for=""Room"">Room</label>
                                        ");
            EndContext();
            BeginContext(4379, 136, false);
#line 84 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Bed\Add.cshtml"
                                   Write(Html.DropDownListFor(m => m.RoomID, new SelectList(string.Empty, "ID", "Name"), new { @class = "form-control dropdown searchDropDown" }));

#line default
#line hidden
            EndContext();
            BeginContext(4515, 1394, true);
            WriteLiteral(@"
                                    </div>
                                </div>

                            </div>

                            <div class=""row mrgn-b-sm"">
                                <div class=""col-md-3 col-lg-3"">
                                    <div class=""form-check"">
                                        <label>
                                            <input type=""checkbox"" name=""IsActive"" id=""IsActive"" checked><span class=""label-text"">Is Active</span>
                                        </label>
                                    </div>
                                </div>
                                <div class=""col-md-3 col-lg-3"">
                                    <div class=""form-group"">
                                        <div class=""form-check"">
                                            <label>
                                                <input type=""checkbox"" name=""Isolated"" id=""Isolated""> <span class=""label-text"">Isolated?<");
            WriteLiteral(@"/span>
                                            </label>
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
#line 115 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Bed\Add.cshtml"
}

#line default
#line hidden
            BeginContext(5912, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(5931, 322, true);
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
                BeginContext(6254, 17, false);
#line 126 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Bed\Add.cshtml"
                      Write(Url.Content("~/"));

#line default
#line hidden
                EndContext();
                BeginContext(6271, 746, true);
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
                BeginContext(7018, 17, false);
#line 142 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Bed\Add.cshtml"
                      Write(Url.Content("~/"));

#line default
#line hidden
                EndContext();
                BeginContext(7035, 658, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Models.Bed> Html { get; private set; }
    }
}
#pragma warning restore 1591
