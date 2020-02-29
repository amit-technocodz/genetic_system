#pragma checksum "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Bed\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96b9c5466046dcb8f89374edb263fd4bf30fc8b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Bed_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Bed/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Bed/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Bed_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96b9c5466046dcb8f89374edb263fd4bf30fc8b3", @"/Areas/Admin/Views/Bed/Index.cshtml")]
    public class Areas_Admin_Views_Bed_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HISSystem.Areas.Admin.Models.BedIndexModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Bed\Index.cshtml"
  
    ViewData["Title"] = "Bed List";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(140, 40, true);
            WriteLiteral("    <div class=\"prtm-content\">\r\n        ");
            EndContext();
            BeginContext(181, 24, false);
#line 7 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Bed\Index.cshtml"
   Write(Html.Hidden("DeletedID"));

#line default
#line hidden
            EndContext();
            BeginContext(205, 1424, true);
            WriteLiteral(@"
        <div class=""prtm-page-bar"">
            <ul class=""breadcrumb"">
                <li class=""breadcrumb-item text-capitalize""><h2>Bed Management</h2></li>
                <li class=""breadcrumb-item""><a href=""#"">Settings</a></li>
                <li class=""breadcrumb-item""><a href=""#"">Bed</a></li>
                <li class=""breadcrumb-item""><a href=""#"" class=""active"">Bed List</a></li>
            </ul>
        </div>

        <div class=""table-style"">
            <div class=""col-md-4 col-lg-4"">
                <div class=""btn-group btn-group-justified mrgn-b-xs"">
                    <a class=""btn btn-xs btn-primary"" href=""/Admin/Bed/Add""><i class=""fa fa-plus"" aria-hidden=""true""></i> Add </a>
                    
                    <a class=""btn btn-xs btn-warning"" href=""/admin/patient/History/"" id=""update-patient""><i class=""fa fa-history"" aria-hidden=""true""></i> History </a>


                </div>
            </div>
            <div class=""row mrgn-b-sm"">
                <div cla");
            WriteLiteral(@"ss=""col-md-12 col-lg-12"">
                    <h5>ADD BED</h5>
                    <div class=""quick-search-block"">
                        <div class=""row"">
                            <div class=""col-md-10 col-lg-10"">
                                <div id=""searchDiv"" class=""row"">
                                    <div class=""col-md-2 col-lg-2"">
                                        ");
            EndContext();
            BeginContext(1630, 167, false);
#line 35 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Bed\Index.cshtml"
                                   Write(Html.DropDownListFor(m => m.bed.BuildingID, new SelectList(ViewBag.Building, "ID", "Name"), "Select building", new { @class = "form-control dropdown searchDropDown" }));

#line default
#line hidden
            EndContext();
            BeginContext(1797, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2056, 153, true);
            WriteLiteral("                                    </div>\r\n                                    <div class=\"col-md-2 col-lg-2\">\r\n                                        ");
            EndContext();
            BeginContext(2210, 157, false);
#line 40 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Bed\Index.cshtml"
                                   Write(Html.DropDownListFor(m => m.bed.FloorID, new SelectList(string.Empty, "ID", "Name"), "Select floor", new { @class = "form-control dropdown searchDropDown" }));

#line default
#line hidden
            EndContext();
            BeginContext(2367, 155, true);
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"col-md-2 col-lg-2\">\r\n                                        ");
            EndContext();
            BeginContext(2523, 155, false);
#line 43 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Bed\Index.cshtml"
                                   Write(Html.DropDownListFor(m => m.bed.RoomID, new SelectList(string.Empty, "ID", "Name"), "Select room", new { @class = "form-control dropdown searchDropDown" }));

#line default
#line hidden
            EndContext();
            BeginContext(2678, 823, true);
            WriteLiteral(@"
                                    </div>
                                    <div class=""col-md-2 col-lg-2"">
                                        <div class=""form-check"">
                                            <label> <input type=""checkbox"" id=""IsActive"" name=""IsActive""><span class=""label-text""> IsActive</span></label>
                                        </div>
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
                        <div id=""bedList"" class=""unseen"">
");
            EndContext();
#line 61 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Bed\Index.cshtml"
                              
                                Html.RenderPartial("_Index");
                            

#line default
#line hidden
            BeginContext(3627, 232, true);
            WriteLiteral("                        </div>\r\n                        <div class=\"col-sm-12 col-md-12 col-lg-4\">\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3879, 1146, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $(""body"").on(""click"", '.page-number', function () {
                var page = parseInt($(this).html());
                debugger
                $.ajax({
                    url: '/admin/bed/_index',
                    data: { ""page"": page },
                    success: function (data) {
                        debugger
                        $("".unseen"").html(data);
                        debugger
                    }
                });
            });
        });

        function RefreshPage() {
            var page = parseInt($('.page-number').html());
                debugger
                $.ajax({
                    url: '/admin/bed/_index',
                    data: { ""page"": page },
                    success: function (data) {
                        debugger
                        $("".unseen"").html(data);
                        debugger
                    }
                });
        }

 ");
                WriteLiteral("       $(document).ready(function () {\r\n            $(\'#bed_BuildingID\').change(function () {\r\n                var url = \'");
                EndContext();
                BeginContext(5026, 17, false);
#line 107 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Bed\Index.cshtml"
                      Write(Url.Content("~/"));

#line default
#line hidden
                EndContext();
                BeginContext(5043, 1454, true);
                WriteLiteral(@"' + ""Admin/Bed/GetFloor"";
                var ddlsource = ""#bed_BuildingID"";
                console.log($(ddlsource).children(""option:selected"").val());
                debugger
                $.getJSON(url, { BuildingID: $(ddlsource).children(""option:selected"").val() }, function (data) {
                    var items = '';
                    $('#bed_FloorID').empty();
                    $('#bed_RoomID').html(""<option value='0'>Select room</option>"");
                    debugger
                    $.each(data, function (i, floor) {
                        items += ""<option value='"" + floor.value + ""'>"" + floor.text + ""</option>"";
                    });
                    debugger
                    $('#bed_FloorID').html(items);
                    var BuildingID = ($(""#bed_BuildingID"").children(""option:selected"").val());
                    dropDownSearchModel = { ""BuildingID"": BuildingID, ""FloorID"": 0, ""RoomID"": 0 }
                    $.ajax({
                            url: ""/ad");
                WriteLiteral(@"min/bed/dynamicsearch"",
                            data: dropDownSearchModel,
                            success: function (data) {

                                $(""#bedList"").html(data);
                             }
                        })
                })
            });
        });

        $(document).ready(function () {
            $('#bed_FloorID').change(function () {
                var url = '");
                EndContext();
                BeginContext(6498, 17, false);
#line 137 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Bed\Index.cshtml"
                      Write(Url.Content("~/"));

#line default
#line hidden
                EndContext();
                BeginContext(6515, 3353, true);
                WriteLiteral(@"' + ""Admin/Bed/GetRoom"";
                var ddlsource = ""#bed_FloorID"";
                console.log($(ddlsource).children(""option:selected"").val());
                debugger
                $.getJSON(url, { FloorID: $(ddlsource).children(""option:selected"").val() }, function (data) {
                    var items = '';
                    $('#bed_RoomID').empty();
                    debugger
                    $.each(data, function (i, room) {
                        items += ""<option value='"" + room.value + ""'>"" + room.text + ""</option>"";
                    });
                    debugger
                    $('#bed_RoomID').html(items);
                });
                var BuildingID = ($(""#bed_BuildingID"").children(""option:selected"").val());
                var FloorID = ($(""#bed_FloorID"").children(""option:selected"").val());
                    dropDownSearchModel = { ""BuildingID"": BuildingID, ""FloorID"": FloorID, ""RoomID"": 0 }
                    $.ajax({
                          ");
                WriteLiteral(@"  url: ""/admin/bed/dynamicsearch"",
                            data: dropDownSearchModel,
                            success: function (data) {

                                $(""#bedList"").html(data);
                             }
                        })
            });
        });

        $(document).ready(function () {
            $('#bed_RoomID').change(function () {
                var BuildingID = ($(""#bed_BuildingID"").children(""option:selected"").val());
                var FloorID = ($(""#bed_FloorID"").children(""option:selected"").val());
                var RoomID = ($(""#bed_RoomID"").children(""option:selected"").val());
                    dropDownSearchModel = { ""BuildingID"": BuildingID, ""FloorID"": FloorID, ""RoomID"": RoomID }
                    $.ajax({
                            url: ""/admin/bed/dynamicsearch"",
                            data: dropDownSearchModel,
                            success: function (data) {

                                $(""#bedList"").html(da");
                WriteLiteral(@"ta);
                             }
                        })
            });
        });

        function Detele(id) {
            $('#DeletedID').val(id);
            swal({
                title: ""Are you sure?"",
                text: ""Are you sure you want to delete this record!"",
                type: ""warning"",
                showCancelButton: true,
                confirmButtonClass: ""btn-warning"",
                confirmButtonText: ""Yes, delete it!"",
                closeOnConfirm: false
            },
                function () {
                    debugger
                    var id = $(""#DeletedID"").val();
                    $.ajax({
                        url: '/admin/bed/delete?id=' + id,
                        type: 'GET',
                        success: function (data) {
                            debugger
                            swal(""Deleted!"", ""Your imaginary file has been deleted."", ""success"");
                            RefreshPage();
             ");
                WriteLiteral(@"           },
                        error: function () {
                            debugger
                            swal(""Cancelled"", ""Something went wrong:)"", ""error"");
                        }
                    });
                });
        }
    </script>
");
                EndContext();
            }
            );
            BeginContext(9871, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HISSystem.Areas.Admin.Models.BedIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
