#pragma checksum "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Template\GeneTemplateLookup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1995154463811f555b937f0e5901c0118b207499"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Template_GeneTemplateLookup), @"mvc.1.0.view", @"/Areas/Admin/Views/Template/GeneTemplateLookup.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Template/GeneTemplateLookup.cshtml", typeof(AspNetCore.Areas_Admin_Views_Template_GeneTemplateLookup))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1995154463811f555b937f0e5901c0118b207499", @"/Areas/Admin/Views/Template/GeneTemplateLookup.cshtml")]
    public class Areas_Admin_Views_Template_GeneTemplateLookup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Template\GeneTemplateLookup.cshtml"
  
    ViewData["Title"] = "Gene Template";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(97, 2911, true);
            WriteLiteral(@"<style>
    .modal-dialog {
        width: 520px;
        margin: 30px auto;
    }

    .modal-body {
        position: relative;
        padding: 10px;
        font-size: 14px;
        max-height: 450px;
        overflow: auto;
        overflow-x: hidden;
    }

    .col-md-6 {
        width: 50%;
        padding-top: 10px;
    }

    .scroll_text {
    height: 500px;
    overflow: auto;
    padding: 0px 23px 0 0;
}
</style>
<div class=""prtm-content"">
    <div class=""prtm-page-bar"">
        <ul class=""breadcrumb"">
            <li class=""breadcrumb-item text-capitalize""><h2>Gene Template</h2></li>
            <li class=""breadcrumb-item""><a href=""#"">Settings</a></li>
            <li class=""breadcrumb-item""><a href=""#"" class=""active"">Gene Template</a></li>
        </ul>
    </div>
    <div class="""">
        <div class=""row"">
            <div class=""col-md-12 col-lg-12 col-xs-12"">
                <div class=""prtm-full-block p-10"">
                    <div class=""row"">
     ");
            WriteLiteral(@"                   <div class=""col-md-3"">
                            <div class=""row left-row-pad"">
                                <div class=""col-md-12 col-sm-12 col-lg-12 col-xs-12"">
                                    <h4><b>All Gene Template</b></h4>
                                </div>
                                <div class=""col-md-12 col-sm-12 col-lg-12 col-xs-12"">
                                    <div id=""lookupList"" class=""scroll_text"">

                                        <h4><a href=""/admin/template/metabolismtemplate"" class=""list-group-item "">Metabolism Template</a></h4>

                                        <h4><a href=""/admin//template/index"" class=""list-group-item "">Epilepsy Template</a></h4>

                                        <h4><a href=""/admin/template/prostatetemplate"" class=""list-group-item "">Prostate Cancer Template</a></h4>

                                        <h4><a href=""/admin/template/methyationtemplate"" class=""list-group-item "">Methyation & A");
            WriteLiteral(@"utism Template</a></h4>

                                        <h4><a href=""/admin/template/fatconsumptiontemplate"" class=""list-group-item "">Fat Consumption Template</a></h4>

                                        <h4><a href=""/admin/template/fitnesstemplate"" class=""list-group-item "">Fitness Template</a></h4>

                                        <h4><a href=""/admin/template/diettemplate"" class=""list-group-item "">Diet Template</a></h4>

                                        <h4><a href=""/admin/template/vitamintemplate"" class=""list-group-item "">Vitamins Template</a></h4>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591