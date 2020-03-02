#pragma checksum "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Patient\_NearestRelative.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cfd132fe4bde7d8f596570dc16d6f7ecaf6611a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Patient__NearestRelative), @"mvc.1.0.view", @"/Areas/Admin/Views/Patient/_NearestRelative.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Patient/_NearestRelative.cshtml", typeof(AspNetCore.Areas_Admin_Views_Patient__NearestRelative))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cfd132fe4bde7d8f596570dc16d6f7ecaf6611a", @"/Areas/Admin/Views/Patient/_NearestRelative.cshtml")]
    public class Areas_Admin_Views_Patient__NearestRelative : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 667, true);
            WriteLiteral(@"<div id=""NearbyFormWrapper"">
    <table class=""table table-hover table-bordered table-striped"" id=""relative-table"">
        <thead>
            <tr class="""">
                <th>Same Address</th>
                <th>Relative Name</th>
                <th class=""numeric"">Address</th>
                <th>Relation</th>
                <th>Tel</th>
                <th class=""numeric"">Comment</th>
                <th>Status</th>
                <th class=""numeric""><a href=""javascript:void(0)"" onclick=""AddField()""><i class=""fa fa-plus-circle"" aria-hidden=""true""></i></a></th>
            </tr>
        </thead>
        <tbody></tbody>
        <tfoot>
");
            EndContext();
#line 18 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Patient\_NearestRelative.cshtml"
             if (Model.PatientRelative != null && Model.PatientRelative.Count > 0)
            {
                foreach (var item in Model.PatientRelative)
                {

#line default
#line hidden
            BeginContext(871, 223, true);
            WriteLiteral("                    <tr id=\"formRow1\">\r\n                        <td>\r\n                            <div class=\"form-check\">\r\n                                <label>\r\n                                    <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("checked", " checked=\"", 1094, "\"", 1121, 1);
#line 26 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Patient\_NearestRelative.cshtml"
WriteAttributeValue("", 1104, item.SameAddress, 1104, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1122, 258, true);
            WriteLiteral(@" name=""Patient_SameAddress"" id=""Patient_SameAddress"" onchange=""DisabledAddress(this)""> <span class=""label-text""></span>
                                </label>
                            </div>
                        </td>
                        <td>");
            EndContext();
            BeginContext(1381, 111, false);
#line 30 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Patient\_NearestRelative.cshtml"
                       Write(Html.TextBox("Patient_RelativeName", item.RelativeName, new { @class = "form-control", autocomplete = "true" }));

#line default
#line hidden
            EndContext();
            BeginContext(1492, 36, true);
            WriteLiteral("</td>\r\n                        <td> ");
            EndContext();
            BeginContext(1529, 101, false);
#line 31 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Patient\_NearestRelative.cshtml"
                        Write(Html.TextBox("Patient_Address", item.Address, new { @class = "form-control", autocomplete = "true" }));

#line default
#line hidden
            EndContext();
            BeginContext(1630, 65, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1696, 159, false);
#line 33 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Patient\_NearestRelative.cshtml"
                       Write(Html.DropDownList("Patient_RelationID", new SelectList(ViewBag.Relations, "ID", "Name", item.RelationID), "Relation", new { @class = "form-control dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(1855, 61, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>");
            EndContext();
            BeginContext(1917, 105, false);
#line 35 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Patient\_NearestRelative.cshtml"
                       Write(Html.TextBox("Patient_Telephone", item.Telephone, new { @class = "form-control", autocomplete = "true" }));

#line default
#line hidden
            EndContext();
            BeginContext(2022, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2058, 101, false);
#line 36 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Patient\_NearestRelative.cshtml"
                       Write(Html.TextBox("Patient_Comment", item.Comment, new { @class = "form-control", autocomplete = "true" }));

#line default
#line hidden
            EndContext();
            BeginContext(2159, 65, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2225, 150, false);
#line 38 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Patient\_NearestRelative.cshtml"
                       Write(Html.DropDownList("Patient_StatusID", new SelectList(ViewBag.Status, "ID", "Name", item.StatusID), "Status", new { @class = "form-control dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(2375, 258, true);
            WriteLiteral(@"
                        </td>
                        <td>
                            <a href=""javascript:void(0)""><i class=""fa fa-trash"" aria-hidden=""true"" onclick=""RemoveField(this)""></i></a>
                        </td>
                    </tr>
");
            EndContext();
#line 44 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Patient\_NearestRelative.cshtml"
                }
            }
            else
            {

#line default
#line hidden
            BeginContext(2700, 445, true);
            WriteLiteral(@"                <tr id=""formRow1"">
                    <td>
                        <div class=""form-check"">
                            <label>
                                <input type=""checkbox"" name=""Patient_SameAddress"" id=""Patient_SameAddress"" onchange=""DisabledAddress(this)""> <span class=""label-text""></span>
                            </label>
                        </div>
                    </td>
                    <td>");
            EndContext();
            BeginContext(3146, 98, false);
#line 56 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Patient\_NearestRelative.cshtml"
                   Write(Html.TextBox("Patient_RelativeName", null, new { @class = "form-control", autocomplete = "true" }));

#line default
#line hidden
            EndContext();
            BeginContext(3244, 32, true);
            WriteLiteral("</td>\r\n                    <td> ");
            EndContext();
            BeginContext(3277, 93, false);
#line 57 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Patient\_NearestRelative.cshtml"
                    Write(Html.TextBox("Patient_Address", null, new { @class = "form-control", autocomplete = "true" }));

#line default
#line hidden
            EndContext();
            BeginContext(3370, 57, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3428, 142, false);
#line 59 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Patient\_NearestRelative.cshtml"
                   Write(Html.DropDownList("Patient_RelationID", new SelectList(ViewBag.Relations, "ID", "Name"), "Relation", new { @class = "form-control dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(3570, 53, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>");
            EndContext();
            BeginContext(3624, 95, false);
#line 61 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Patient\_NearestRelative.cshtml"
                   Write(Html.TextBox("Patient_Telephone", null, new { @class = "form-control", autocomplete = "true" }));

#line default
#line hidden
            EndContext();
            BeginContext(3719, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3751, 93, false);
#line 62 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Patient\_NearestRelative.cshtml"
                   Write(Html.TextBox("Patient_Comment", null, new { @class = "form-control", autocomplete = "true" }));

#line default
#line hidden
            EndContext();
            BeginContext(3844, 57, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3902, 135, false);
#line 64 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Patient\_NearestRelative.cshtml"
                   Write(Html.DropDownList("Patient_StatusID", new SelectList(ViewBag.Status, "ID", "Name"), "Status", new { @class = "form-control dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(4037, 238, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a href=\"javascript:void(0)\"><i class=\"fa fa-trash\" aria-hidden=\"true\" onclick=\"RemoveField(this)\"></i></a>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 70 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Patient\_NearestRelative.cshtml"
            }

#line default
#line hidden
            BeginContext(4290, 40, true);
            WriteLiteral("        </tfoot>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
