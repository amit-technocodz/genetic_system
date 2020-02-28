#pragma checksum "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\Template\GetMineral.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f329601d90623b220a36e0c5d9a005446c8416f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Template_GetMineral), @"mvc.1.0.view", @"/Areas/Admin/Views/Template/GetMineral.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Template/GetMineral.cshtml", typeof(AspNetCore.Areas_Admin_Views_Template_GetMineral))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f329601d90623b220a36e0c5d9a005446c8416f", @"/Areas/Admin/Views/Template/GetMineral.cshtml")]
    public class Areas_Admin_Views_Template_GetMineral : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Helpers.PagedData<GeneticSystem.Areas.Admin.Models.AddMineralViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(85, 2128, true);
            WriteLiteral(@"

    <div class=""row"">
        <div class=""col-md-3"">
            <div class=""row left-row-pad"">
                <div class=""col-md-12 col-sm-12 col-lg-12 col-xs-12"">
                    <h4><b>All Gene Template </b></h4>
                </div>
                <div class=""col-md-12 col-sm-12 col-lg-12 col-xs-12"">
                    <div id=""lookupList"" class=""scroll_text"">

                        <h4><a href=""/admin/template/metabolismtemplate"" class=""list-group-item "">Metabolism Template</a></h4>

                        <h4><a href=""/admin/template/index"" class=""list-group-item "">Epilepsy Template</a></h4>

                        <h4><a href=""/admin/template/prostatetemplate"" class=""list-group-item"">Prostate Cancer Template</a></h4>

                        <h4><a href=""/admin/template/methyationtemplate"" class=""list-group-item "">Methyation & Autism Template</a></h4>

                        <h4><a href=""/admin/template/fatconsumptiontemplate"" class=""list-group-item "">Fat Consumption ");
            WriteLiteral(@"Template</a></h4>

                        <h4><a href=""/admin/template/fitnesstemplate"" class=""list-group-item "">Fitness Template</a></h4>

                        <h4><a href=""/admin/template/diettemplate"" class=""list-group-item "">Diet Template</a></h4>

                        <h4><a href=""/admin/template/vitamintemplate"" class=""list-group-item "">Vitamins Template</a></h4>

                        <h4><a href=""/admin/template/mineraltemplate"" class=""list-group-item active"">Mineral Template</a></h4>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-md-9"">
            <table id=""userTbl"" class=""table table-hover table-bordered table-striped"">
                <thead>
                    <tr class="""">
                        <th>Elements</th>
                        <th>Effect</th>
                        <th>Effected Gene</th>
                        <th>Recommendations</th>

                        <th class=""numeric"">Action</th>");
            WriteLiteral("\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 47 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\Template\GetMineral.cshtml"
                     foreach (var item in Model.Data)
                    {

#line default
#line hidden
            BeginContext(2291, 64, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n");
            EndContext();
#line 51 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\Template\GetMineral.cshtml"
                                 if (item != null && item.Element != null)
                                {
                                    

#line default
#line hidden
            BeginContext(2503, 17, false);
#line 53 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\Template\GetMineral.cshtml"
                               Write(item.Element.Name);

#line default
#line hidden
            EndContext();
#line 53 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\Template\GetMineral.cshtml"
                                                      

                                }

#line default
#line hidden
            BeginContext(2559, 69, true);
            WriteLiteral("                            </td>\r\n                            <td>\r\n");
            EndContext();
#line 58 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\Template\GetMineral.cshtml"
                                 if (item.Effect == true)
                                {

#line default
#line hidden
            BeginContext(2726, 3, true);
            WriteLiteral("Yes");
            EndContext();
#line 59 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\Template\GetMineral.cshtml"
                                                 }
                            else
                            {
                                

#line default
#line hidden
            BeginContext(2842, 2, true);
            WriteLiteral("No");
            EndContext();
#line 62 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\Template\GetMineral.cshtml"
                                               
                            }

#line default
#line hidden
            BeginContext(2884, 71, true);
            WriteLiteral("                            </td>\r\n\r\n                            <td>\r\n");
            EndContext();
#line 67 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\Template\GetMineral.cshtml"
                                 if (item.EffectedGene != null)
                                {
                                    

#line default
#line hidden
#line 69 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\Template\GetMineral.cshtml"
                                     foreach (var item1 in item.EffectedGene)
                                    {
                                        

#line default
#line hidden
            BeginContext(3214, 15, false);
#line 71 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\Template\GetMineral.cshtml"
                                   Write(item1.Gene.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3229, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
#line 72 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\Template\GetMineral.cshtml"
                                    }

#line default
#line hidden
#line 72 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\Template\GetMineral.cshtml"
                                     
                                }

#line default
#line hidden
            BeginContext(3311, 71, true);
            WriteLiteral("\r\n\r\n                            </td>\r\n                            <td>");
            EndContext();
            BeginContext(3383, 19, false);
#line 77 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\Template\GetMineral.cshtml"
                           Write(item.Recomendations);

#line default
#line hidden
            EndContext();
            BeginContext(3402, 81, true);
            WriteLiteral("</td>\r\n\r\n\r\n\r\n                            <td>\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3483, "\"", 3539, 2);
            WriteAttributeValue("", 3490, "/admin/template/UpdateMineralTemplate?Id=", 3490, 41, true);
#line 82 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\Template\GetMineral.cshtml"
WriteAttributeValue("", 3531, item.ID, 3531, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3540, 163, true);
            WriteLiteral("><i class=\"fa fa-pencil fa-md base-dark\" aria-hidden=\"true\"></i></a>\r\n\r\n                                <a href=\"javascript:void(0);\" class=\"fa fa-trash mrgn-l-xs\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3703, "\"", 3729, 3);
            WriteAttributeValue("", 3713, "Delete(", 3713, 7, true);
#line 84 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\Template\GetMineral.cshtml"
WriteAttributeValue("", 3720, item.ID, 3720, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 3728, ")", 3728, 1, true);
            EndWriteAttribute();
            BeginContext(3730, 136, true);
            WriteLiteral(" data-toggle=\"tooltip\" , data-placement=\"top\" title=\"Trash\"></a>\r\n\r\n\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 89 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\Template\GetMineral.cshtml"
                    }

#line default
#line hidden
            BeginContext(3889, 120, true);
            WriteLiteral("                </tbody>\r\n                <tfoot>\r\n                    <tr>\r\n                        <td colspan=\"11\">\r\n");
            EndContext();
#line 94 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\Template\GetMineral.cshtml"
                             for (int i = 1; i <= Model.NumberOfPages; i++)
                            {

#line default
#line hidden
            BeginContext(4117, 54, true);
            WriteLiteral("                                <a class=\"page-number\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4171, "\"", 4201, 3);
            WriteAttributeValue("", 4181, "getmineralsearch(", 4181, 17, true);
#line 96 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\Template\GetMineral.cshtml"
WriteAttributeValue("", 4198, i, 4198, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 4200, ")", 4200, 1, true);
            EndWriteAttribute();
            BeginContext(4202, 27, true);
            WriteLiteral(" href=\"javascript:void();\">");
            EndContext();
            BeginContext(4230, 1, false);
#line 96 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\Template\GetMineral.cshtml"
                                                                                                           Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(4231, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 97 "J:\GitHub\genetic_system\HISSystem\Areas\Admin\Views\Template\GetMineral.cshtml"
                            }

#line default
#line hidden
            BeginContext(4268, 124, true);
            WriteLiteral("                        </td>\r\n                    </tr>\r\n                </tfoot>\r\n            </table>\r\n            </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Helpers.PagedData<GeneticSystem.Areas.Admin.Models.AddMineralViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
