#pragma checksum "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\ViewControl\Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af28df139ca70edd1acd0abb278ebc9b6f6dfa8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ViewControl_Menu), @"mvc.1.0.view", @"/Areas/Admin/Views/ViewControl/Menu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/ViewControl/Menu.cshtml", typeof(AspNetCore.Areas_Admin_Views_ViewControl_Menu))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af28df139ca70edd1acd0abb278ebc9b6f6dfa8b", @"/Areas/Admin/Views/ViewControl/Menu.cshtml")]
    public class Areas_Admin_Views_ViewControl_Menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Data.Models.ViewControl>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\ViewControl\Menu.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(132, 2076, true);
            WriteLiteral(@"<div class=""prtm-content"">
    <div class=""prtm-page-bar"">
        <ul class=""breadcrumb"">
            <li class=""breadcrumb-item text-capitalize""><h2> View Control</h2></li>
            <li class=""breadcrumb-item""><a href=""#"">Settings</a></li>
            <li class=""breadcrumb-item""><a href=""#"">Admin</a></li>
            <li class=""breadcrumb-item""><a href=""#"" class=""active"">View control list</a></li>
        </ul>
    </div>

    <div class=""table-style"">
        <div class=""row mrgn-b-sm"">
            <div class=""col-md-12 col-lg-12"">
                <div class=""quick-search-block"">
                    <div class=""row"">
                        <div class=""col-md-10 col-lg-10"">
                            <div id=""searchDiv"" class=""row"">
                                <div class=""col-md-3 col-lg-3 "">
                                    <a class=""btn btn-xs btn-primary action-button"" href=""#responsive"" data-toggle=""modal"" id=""Add""><i class=""fa fa-plus"" aria-hidden=""true""></i> Add </a>
   ");
            WriteLiteral(@"                             </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""prtm-block pos-relative"">
                    <div class=""prtm-block-content"">
                        <div class=""table-responsive"">
                            <div id=""bedList"" class=""unseen"">
                                <table class=""table table-bordered table-hover dashboard-task-infos table-bordered table-striped"">
                                    <thead>
                                        <tr>
                                            <th class=""numeric"">Name</th>

                                            <th>
                                                Uri
                                            </th>
                                            <th>Action</th>
                                        </tr>
                                    </thead>
                               ");
            WriteLiteral("     <tbody class=\"tbody\">\r\n");
            EndContext();
#line 46 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\ViewControl\Menu.cshtml"
                                         foreach (var item in Model)
                                        { 

#line default
#line hidden
            BeginContext(2322, 94, true);
            WriteLiteral("                                        <tr>\r\n                                            <td>");
            EndContext();
            BeginContext(2417, 9, false);
#line 49 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\ViewControl\Menu.cshtml"
                                           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2426, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(2482, 8, false);
#line 50 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\ViewControl\Menu.cshtml"
                                           Write(item.Uri);

#line default
#line hidden
            EndContext();
            BeginContext(2490, 207, true);
            WriteLiteral("</td>\r\n                                            <td>\r\n                                                <a href=\"#responsive\" class=\"fa fa-pencil action-button\" id=\"update\" data-toggle=\"modal\"  data-value=\"");
            EndContext();
            BeginContext(2698, 7, false);
#line 52 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\ViewControl\Menu.cshtml"
                                                                                                                                                 Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(2705, 10, true);
            WriteLiteral("\"></a>\r\n\r\n");
            EndContext();
            BeginContext(2943, 109, true);
            WriteLiteral("\r\n                                                <a href=\"javascript:void(0);\" class=\"fa fa-trash mrgn-l-xs\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3052, "\"", 3078, 3);
            WriteAttributeValue("", 3062, "Delete(", 3062, 7, true);
#line 56 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\ViewControl\Menu.cshtml"
WriteAttributeValue("", 3069, item.ID, 3069, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 3077, ")", 3077, 1, true);
            EndWriteAttribute();
            BeginContext(3079, 113, true);
            WriteLiteral(" data-toggle=\"tooltip\" , data-placement=\"top\" title=\"Trach\"></a>\r\n                                        </tr>\r\n");
            EndContext();
#line 58 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\ViewControl\Menu.cshtml"
                                        
                                        
                                        }

#line default
#line hidden
            BeginContext(3319, 601, true);
            WriteLiteral(@"                                    </tbody>
                                </table>
                            </div>
                            <div class=""col-sm-12 col-md-12 col-lg-4"">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-------Model------>

        <div id=""responsive"" class=""modal fade"" aria-hidden=""true"">
            <div class=""modal-dialog"">
                <div class=""modal-content"">

                </div>
            </div>
        </div>
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3945, 2287, true);
                WriteLiteral(@"
            <script>
                $('.action-button').click(function () {
                    debugger
                    var id = this.id;
                    var val = this.dataset.value;
                    if (val) {
                      //  alert(1);
                        url = '/admin/viewcontrol/' + id + ""?id="" + val;
                       // alert(url);
                    }
                    else {
                        url = '/admin/viewcontrol/' + id
                    }
                    $.ajax({
                        url: url,
                        type: 'GET',
                        success: function (result) {
                            debugger
                            $("".modal-content"").html(result);
                        },
                        error: function (xhr, status) {
                            debugger
                        }
                    });
                });
                function Delete(id) {
                ");
                WriteLiteral(@"    console.log(id);
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
                  //  var id = $(""#DeletedID"").val();
                    $.ajax({
                        url: '/admin/viewcontrol/delete?id=' + id,
                        type: 'GET',
                        success: function (data) {
                            debugger
                            swal(""Deleted!"", ""Your imaginary file has been deleted."", ""success"");
                            location.reload();
                        },
                        error: function () {
                            debu");
                WriteLiteral("gger\r\n                            swal(\"Cancelled\", \"Something went wrong :)\", \"error\");\r\n                        }\r\n                    });\r\n                });\r\n                }\r\n                \r\n\r\n\r\n                </script>\r\n        ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Data.Models.ViewControl>> Html { get; private set; }
    }
}
#pragma warning restore 1591
