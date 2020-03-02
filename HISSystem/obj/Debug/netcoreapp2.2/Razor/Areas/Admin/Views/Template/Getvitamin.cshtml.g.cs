#pragma checksum "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\Getvitamin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1aa465aeca9bd769bed58f63c2b83a3ee5b11f6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Template_Getvitamin), @"mvc.1.0.view", @"/Areas/Admin/Views/Template/Getvitamin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Template/Getvitamin.cshtml", typeof(AspNetCore.Areas_Admin_Views_Template_Getvitamin))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1aa465aeca9bd769bed58f63c2b83a3ee5b11f6f", @"/Areas/Admin/Views/Template/Getvitamin.cshtml")]
    public class Areas_Admin_Views_Template_Getvitamin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Helpers.PagedData<GeneticSystem.Areas.Admin.Models.VitaminViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(82, 2209, true);
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

                        <h4><a href=""/admin/template/prostatetemplate"" class=""list-group-item "">Prostate Cancer Template</a></h4>

                        <h4><a href=""/admin/template/methyationtemplate"" class=""list-group-item "">Methyation & Autism Template</a></h4>

                        <h4><a href=""/admin/template/fatconsumptiontemplate"" class=""list-group-item "">Fat Consumption T");
            WriteLiteral(@"emplate</a></h4>

                        <h4><a href=""/admin/template/fitnesstemplate"" class=""list-group-item "">Fitness Template</a></h4>

                        <h4><a href=""/admin/template/diettemplate"" class=""list-group-item "">Diet Template</a></h4>

                        <h4><a href=""/admin/template/vitamintemplate"" class=""list-group-item active"">Vitamins Template</a></h4>

                        <h4><a href=""/admin/template/mineraltemplate"" class=""list-group-item"">Mineral Template</a></h4>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-md-9"">
            <table id=""userTbl"" class=""table table-hover table-bordered table-striped"">
                <thead>
                    <tr class="""">
                        <th>Feeder Type</th>
                        <th>Effected Gene</th>
                        <th class=""numeric"">
                            Effected<br />

                        </th>
                        ");
            WriteLiteral("<th>Reccomendations</th>\r\n                        <th class=\"numeric\">Action</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 48 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\Getvitamin.cshtml"
                     foreach (var item in Model.Data)
                    {

#line default
#line hidden
            BeginContext(2369, 64, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n");
            EndContext();
#line 52 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\Getvitamin.cshtml"
                                 if (item != null && item.FeederType != null)
                                {
                                    

#line default
#line hidden
            BeginContext(2584, 20, false);
#line 54 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\Getvitamin.cshtml"
                               Write(item.FeederType.Name);

#line default
#line hidden
            EndContext();
#line 54 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\Getvitamin.cshtml"
                                                         

                                }

#line default
#line hidden
            BeginContext(2643, 71, true);
            WriteLiteral("                            </td>\r\n\r\n                            <td>\r\n");
            EndContext();
#line 60 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\Getvitamin.cshtml"
                                 foreach (var item1 in item.EffectedGeneVitamins)
                                {
                                    

#line default
#line hidden
            BeginContext(2869, 15, false);
#line 62 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\Getvitamin.cshtml"
                               Write(item1.Gene.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2884, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
#line 63 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\Getvitamin.cshtml"
                                }

#line default
#line hidden
            BeginContext(2927, 71, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
            EndContext();
#line 67 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\Getvitamin.cshtml"
                                 if (item.Effect == true)
                                {
                                    

#line default
#line hidden
            BeginContext(3134, 4, true);
            WriteLiteral(" Yes");
            EndContext();
#line 69 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\Getvitamin.cshtml"
                                                     
                                }
                                else
                                {
                                    

#line default
#line hidden
            BeginContext(3297, 3, true);
            WriteLiteral(" No");
            EndContext();
#line 73 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\Getvitamin.cshtml"
                                                    
                                }

#line default
#line hidden
            BeginContext(3344, 59, true);
            WriteLiteral("                        </td>\r\n                        <td>");
            EndContext();
            BeginContext(3404, 20, false);
#line 76 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\Getvitamin.cshtml"
                       Write(item.Recommendations);

#line default
#line hidden
            EndContext();
            BeginContext(3424, 73, true);
            WriteLiteral("</td>\r\n\r\n\r\n\r\n                        <td>\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3497, "\"", 3553, 2);
            WriteAttributeValue("", 3504, "/admin/template/UpdateVitaminTemplate?Id=", 3504, 41, true);
#line 81 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\Getvitamin.cshtml"
WriteAttributeValue("", 3545, item.ID, 3545, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3554, 159, true);
            WriteLiteral("><i class=\"fa fa-pencil fa-md base-dark\" aria-hidden=\"true\"></i></a>\r\n\r\n                            <a href=\"javascript:void(0);\" class=\"fa fa-trash mrgn-l-xs\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3713, "\"", 3739, 3);
            WriteAttributeValue("", 3723, "Delete(", 3723, 7, true);
#line 83 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\Getvitamin.cshtml"
WriteAttributeValue("", 3730, item.ID, 3730, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 3738, ")", 3738, 1, true);
            EndWriteAttribute();
            BeginContext(3740, 128, true);
            WriteLiteral(" data-toggle=\"tooltip\" , data-placement=\"top\" title=\"Trash\"></a>\r\n\r\n\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 88 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\Getvitamin.cshtml"
                }

#line default
#line hidden
            BeginContext(3887, 120, true);
            WriteLiteral("                </tbody>\r\n                <tfoot>\r\n                    <tr>\r\n                        <td colspan=\"11\">\r\n");
            EndContext();
#line 93 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\Getvitamin.cshtml"
                             for (int i = 1; i <= Model.NumberOfPages; i++)
                            {

#line default
#line hidden
            BeginContext(4115, 54, true);
            WriteLiteral("                                <a class=\"page-number\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4169, "\"", 4199, 3);
            WriteAttributeValue("", 4179, "getfitnesssearch(", 4179, 17, true);
#line 95 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\Getvitamin.cshtml"
WriteAttributeValue("", 4196, i, 4196, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 4198, ")", 4198, 1, true);
            EndWriteAttribute();
            BeginContext(4200, 27, true);
            WriteLiteral(" href=\"javascript:void();\">");
            EndContext();
            BeginContext(4228, 1, false);
#line 95 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\Getvitamin.cshtml"
                                                                                                           Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(4229, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 96 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\Getvitamin.cshtml"
                            }

#line default
#line hidden
            BeginContext(4266, 126, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Helpers.PagedData<GeneticSystem.Areas.Admin.Models.VitaminViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
