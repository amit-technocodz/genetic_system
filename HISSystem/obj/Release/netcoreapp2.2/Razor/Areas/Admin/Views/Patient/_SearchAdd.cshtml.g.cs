#pragma checksum "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Patient\_SearchAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cac8f0c7c6e39b99e5f27679121f3565d4314a38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Patient__SearchAdd), @"mvc.1.0.view", @"/Areas/Admin/Views/Patient/_SearchAdd.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Patient/_SearchAdd.cshtml", typeof(AspNetCore.Areas_Admin_Views_Patient__SearchAdd))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cac8f0c7c6e39b99e5f27679121f3565d4314a38", @"/Areas/Admin/Views/Patient/_SearchAdd.cshtml")]
    public class Areas_Admin_Views_Patient__SearchAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Helpers.PagedData<Data.Models.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 1299, true);
            WriteLiteral(@"    <div class="""">
        <button type=""button"" class=""close"" id=""close-div"" onclick=""closediv();"">×</button>
        <input type=""text"" id=""searchinappointment"" class=""form-control"" onkeyup=""patientsearch(1);"" style=""display:none"" />
        <div class=""table-style"">
            <div class=""prtm-block pos-relative"">
                <div class=""prtm-block-content"">
                    <div class=""table-responsive"">
                        <div class=""unseen"">
                            <table class=""table table-hover table-bordered table-striped"" id=""myTable"">
                                <thead>
                                    <tr>
                                        <th>Reg No</th>
                                        <th class=""numeric"">Name</th>
                                        <th class=""numeric"">ID</th>
                                        <th class=""numeric"">Birth Date</th>
                                        <th class=""numeric"">Mobile No</th>
             ");
            WriteLiteral(@"                           <th class=""numeric"">Full Address</th>
                                        <th class=""numeric"">Action</th>
                                    </tr>
                                </thead>
                                <tbody id=""test"">
");
            EndContext();
#line 23 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Patient\_SearchAdd.cshtml"
                                     if (Model.Data != null)
                                    {
                                        foreach (var item in Model.Data)
                                        {

#line default
#line hidden
            BeginContext(1566, 102, true);
            WriteLiteral("                                            <tr>\r\n                                                <td>");
            EndContext();
            BeginContext(1669, 20, false);
#line 28 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Patient\_SearchAdd.cshtml"
                                               Write(item.RegisterationNo);

#line default
#line hidden
            EndContext();
            BeginContext(1689, 113, true);
            WriteLiteral("</td>\r\n                                                <td>\r\n                                                    ");
            EndContext();
            BeginContext(1803, 16, false);
#line 30 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Patient\_SearchAdd.cshtml"
                                               Write(item.EnFirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1819, 7, true);
            WriteLiteral(" &nbsp;");
            EndContext();
            BeginContext(1827, 17, false);
#line 30 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Patient\_SearchAdd.cshtml"
                                                                       Write(item.EnSecondName);

#line default
#line hidden
            EndContext();
            BeginContext(1844, 6, true);
            WriteLiteral("&nbsp;");
            EndContext();
            BeginContext(1851, 16, false);
#line 30 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Patient\_SearchAdd.cshtml"
                                                                                               Write(item.EnThirdName);

#line default
#line hidden
            EndContext();
            BeginContext(1867, 109, true);
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>");
            EndContext();
            BeginContext(1977, 7, false);
#line 32 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Patient\_SearchAdd.cshtml"
                                               Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(1984, 61, true);
            WriteLiteral("</td>\r\n                                                <td>\r\n");
            EndContext();
#line 34 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Patient\_SearchAdd.cshtml"
                                                     if (item.PatientPersonalInformation != null && item.PatientPersonalInformation.DateOfBirth != null)
                                                    {
                                                        

#line default
#line hidden
            BeginContext(2311, 72, false);
#line 36 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Patient\_SearchAdd.cshtml"
                                                   Write(item.PatientPersonalInformation.DateOfBirth.Value.ToString("MM/dd/yyyy"));

#line default
#line hidden
            EndContext();
#line 36 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Patient\_SearchAdd.cshtml"
                                                                                                                                 
                                                    }

#line default
#line hidden
            BeginContext(2440, 161, true);
            WriteLiteral("                                                </td>\r\n                                                <td>\r\n                                                    ");
            EndContext();
            BeginContext(2602, 11, false);
#line 40 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Patient\_SearchAdd.cshtml"
                                               Write(item.Mobile);

#line default
#line hidden
            EndContext();
            BeginContext(2613, 163, true);
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
            EndContext();
            BeginContext(2777, 12, false);
#line 43 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Patient\_SearchAdd.cshtml"
                                               Write(item.Address);

#line default
#line hidden
            EndContext();
            BeginContext(2789, 163, true);
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
            EndContext();
            BeginContext(2953, 125, false);
#line 46 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Patient\_SearchAdd.cshtml"
                                               Write(Html.ActionLink("Update", "update", "patient", new { id = item.ID }, new { @class = "btn btn-xs btn-success action-button" }));

#line default
#line hidden
            EndContext();
            BeginContext(3078, 108, true);
            WriteLiteral("\r\n                                                </td>\r\n                                            </tr>\r\n");
            EndContext();
#line 49 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Patient\_SearchAdd.cshtml"
                                        }
                                    }

#line default
#line hidden
            BeginContext(3268, 186, true);
            WriteLiteral("\r\n                                </tbody>\r\n                                <tfoot>\r\n                                    <tr>\r\n                                        <td colspan=\"17\">\r\n");
            EndContext();
#line 56 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Patient\_SearchAdd.cshtml"
                                             for (int i = 1; i <= Model.NumberOfPages; i++)
                                            {

#line default
#line hidden
            BeginContext(3594, 97, true);
            WriteLiteral("                                                <a class=\"page-number\" href=\"javascript:void(0);\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3691, "\"", 3718, 3);
            WriteAttributeValue("", 3701, "searchfilter(", 3701, 13, true);
#line 58 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Patient\_SearchAdd.cshtml"
WriteAttributeValue("", 3714, i, 3714, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 3716, ");", 3716, 2, true);
            EndWriteAttribute();
            BeginContext(3719, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3721, 1, false);
#line 58 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Patient\_SearchAdd.cshtml"
                                                                                                                         Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(3722, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 59 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Patient\_SearchAdd.cshtml"
                                            }

#line default
#line hidden
            BeginContext(3775, 704, true);
            WriteLiteral(@"                                        </td>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Helpers.PagedData<Data.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
