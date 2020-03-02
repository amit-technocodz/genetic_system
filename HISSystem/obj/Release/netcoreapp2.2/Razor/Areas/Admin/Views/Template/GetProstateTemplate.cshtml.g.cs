#pragma checksum "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\GetProstateTemplate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d6a6a0edd8a73677deb28fdc9a888ad22728854"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Template_GetProstateTemplate), @"mvc.1.0.view", @"/Areas/Admin/Views/Template/GetProstateTemplate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Template/GetProstateTemplate.cshtml", typeof(AspNetCore.Areas_Admin_Views_Template_GetProstateTemplate))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d6a6a0edd8a73677deb28fdc9a888ad22728854", @"/Areas/Admin/Views/Template/GetProstateTemplate.cshtml")]
    public class Areas_Admin_Views_Template_GetProstateTemplate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Helpers.PagedData<Data.Models.ProstateTemplate>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 2262, true);
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

                        <h4><a href=""/admin/template/prostatetemplate"" class=""list-group-item active"">Prostate Cancer Template</a></h4>

                        <h4><a href=""/admin/template/methyationtemplate"" class=""list-group-item "">Methyation & Autism Template</a></h4>

                        <h4><a href=""/admin/template/fatconsumptiontemplate"" class=""list-group-item "">Fat Consump");
            WriteLiteral(@"tion Template</a></h4>

                        <h4><a href=""/admin/template/fitnesstemplate"" class=""list-group-item "">Fitness Template</a></h4>

                        <h4><a href=""/admin/template/diettemplate"" class=""list-group-item "">Diet Template</a></h4>

                        <h4><a href=""/admin/template/vitamintemplate"" class=""list-group-item "">Vitamins Template</a></h4>

                        <h4><a href=""/admin/template/mineraltemplate"" class=""list-group-item"">Mineral Template</a></h4>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-md-9"">
            <table id=""userTbl"" class=""table table-hover table-bordered table-striped"">
                <thead>
                    <tr class="""">
                        <th>Gene</th>
                        <th>Have Mutation</th>
                        <th class=""numeric"">Genetic Mutation</th>
                        <th>Personal Risk Factor</th>
                        <th>Herd");
            WriteLiteral("iatery</th>\r\n                        <th class=\"numeric\">Recommendations</th>\r\n                        <th class=\"numeric\">Action</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 47 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\GetProstateTemplate.cshtml"
                     foreach (var item in Model.Data)
                    {

#line default
#line hidden
            BeginContext(2401, 64, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n");
            EndContext();
#line 51 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\GetProstateTemplate.cshtml"
                                 if (item != null && item.Gene != null)
                                {
                                    

#line default
#line hidden
            BeginContext(2610, 14, false);
#line 53 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\GetProstateTemplate.cshtml"
                               Write(item.Gene.Name);

#line default
#line hidden
            EndContext();
#line 53 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\GetProstateTemplate.cshtml"
                                                   

                                }

#line default
#line hidden
            BeginContext(2663, 71, true);
            WriteLiteral("                            </td>\r\n\r\n                            <td>\r\n");
            EndContext();
#line 59 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\GetProstateTemplate.cshtml"
                                 if (item.HaveMutation == true)
                                {
                                    

#line default
#line hidden
            BeginContext(2876, 3, true);
            WriteLiteral("Yes");
            EndContext();
#line 61 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\GetProstateTemplate.cshtml"
                                                    
                                }
                                else
                                {
                                    

#line default
#line hidden
            BeginContext(3038, 2, true);
            WriteLiteral("No");
            EndContext();
#line 65 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\GetProstateTemplate.cshtml"
                                                   
                                }

#line default
#line hidden
            BeginContext(3084, 69, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>");
            EndContext();
            BeginContext(3154, 20, false);
#line 69 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\GetProstateTemplate.cshtml"
                           Write(item.GeneticMutation);

#line default
#line hidden
            EndContext();
            BeginContext(3174, 73, true);
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3248, 23, false);
#line 71 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\GetProstateTemplate.cshtml"
                           Write(item.PersonalRiskFactor);

#line default
#line hidden
            EndContext();
            BeginContext(3271, 105, true);
            WriteLiteral("\r\n                            </td>\r\n\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3377, 15, false);
#line 75 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\GetProstateTemplate.cshtml"
                           Write(item.Hereditary);

#line default
#line hidden
            EndContext();
            BeginContext(3392, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3496, 20, false);
#line 78 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\GetProstateTemplate.cshtml"
                           Write(item.Recommendations);

#line default
#line hidden
            EndContext();
            BeginContext(3516, 158, true);
            WriteLiteral("\r\n                            </td>\r\n\r\n\r\n                            <td>\r\n                                <a href=\"#\"><i class=\"fa fa-pencil fa-md base-dark\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3674, "\"", 3708, 3);
            WriteAttributeValue("", 3684, "editProstate(\'", 3684, 14, true);
#line 83 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\GetProstateTemplate.cshtml"
WriteAttributeValue("", 3698, item.ID, 3698, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 3706, "\')", 3706, 2, true);
            EndWriteAttribute();
            BeginContext(3709, 123, true);
            WriteLiteral(" aria-hidden=\"true\"></i></a>\r\n\r\n                                <a href=\"javascript:void(0);\" class=\"fa fa-trash mrgn-l-xs\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3832, "\"", 3858, 3);
            WriteAttributeValue("", 3842, "Delete(", 3842, 7, true);
#line 85 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\GetProstateTemplate.cshtml"
WriteAttributeValue("", 3849, item.ID, 3849, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 3857, ")", 3857, 1, true);
            EndWriteAttribute();
            BeginContext(3859, 136, true);
            WriteLiteral(" data-toggle=\"tooltip\" , data-placement=\"top\" title=\"Trash\"></a>\r\n\r\n\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 90 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\GetProstateTemplate.cshtml"
                    }

#line default
#line hidden
            BeginContext(4018, 120, true);
            WriteLiteral("                </tbody>\r\n                <tfoot>\r\n                    <tr>\r\n                        <td colspan=\"11\">\r\n");
            EndContext();
#line 95 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\GetProstateTemplate.cshtml"
                             for (int i = 1; i <= Model.NumberOfPages; i++)
                            {

#line default
#line hidden
            BeginContext(4246, 54, true);
            WriteLiteral("                                <a class=\"page-number\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4300, "\"", 4331, 3);
            WriteAttributeValue("", 4310, "getprostatesearch(", 4310, 18, true);
#line 97 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\GetProstateTemplate.cshtml"
WriteAttributeValue("", 4328, i, 4328, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 4330, ")", 4330, 1, true);
            EndWriteAttribute();
            BeginContext(4332, 27, true);
            WriteLiteral(" href=\"javascript:void();\">");
            EndContext();
            BeginContext(4360, 1, false);
#line 97 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\GetProstateTemplate.cshtml"
                                                                                                            Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(4361, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 98 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\GetProstateTemplate.cshtml"
                            }

#line default
#line hidden
            BeginContext(4398, 126, true);
            WriteLiteral("                        </td>\r\n                    </tr>\r\n                </tfoot>\r\n            </table>\r\n            </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Helpers.PagedData<Data.Models.ProstateTemplate>> Html { get; private set; }
    }
}
#pragma warning restore 1591
