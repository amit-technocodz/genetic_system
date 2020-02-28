#pragma checksum "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Template\AddMetabolismTemplate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "149e1d04d3b859f1affc8bc8e0619767c7329b86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Template_AddMetabolismTemplate), @"mvc.1.0.view", @"/Areas/Admin/Views/Template/AddMetabolismTemplate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Template/AddMetabolismTemplate.cshtml", typeof(AspNetCore.Areas_Admin_Views_Template_AddMetabolismTemplate))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"149e1d04d3b859f1affc8bc8e0619767c7329b86", @"/Areas/Admin/Views/Template/AddMetabolismTemplate.cshtml")]
    public class Areas_Admin_Views_Template_AddMetabolismTemplate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Models.MetabolismTemplate>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Template\AddMetabolismTemplate.cshtml"
  
    ViewData["Title"] = "Metabolism List";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(138, 241, true);
            WriteLiteral("\r\n<form action=\"/admin/template/AddMetabolismTemplate\" method=\"post\">\r\n    <div class=\"prtm-content\">\r\n        <div class=\"prtm-page-bar\">\r\n            <ul class=\"breadcrumb\">\r\n                <li class=\"breadcrumb-item text-capitalize\"><h2>");
            EndContext();
            BeginContext(380, 17, false);
#line 12 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Template\AddMetabolismTemplate.cshtml"
                                                           Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(397, 3423, true);
            WriteLiteral(@"</h2></li>
                <li class=""breadcrumb-item""><a href=""#"">Dashboard</a></li>
                <li class=""breadcrumb-item""><a href=""#"">Ui elements</a></li>
                <li class=""breadcrumb-item""><a href=""#"" class=""active""> Add Metabolism</a></li>
            </ul>
        </div>
        
        <div class=""form-style"">
            <div class=""row"">
                <div class=""col-md-12 col-lg-12"">
                    <div class=""prtm-block pos-relative"">
                        <div class=""row"">
                            <div class=""col-md-3"">
                                <div class=""row left-row-pad"">
                                    <div class=""col-md-12 col-sm-12 col-lg-12 col-xs-12"">
                                        <h4><b>All Gene Template </b></h4>
                                    </div>
                                    <div class=""col-md-12 col-sm-12 col-lg-12 col-xs-12"">
                                        <div id=""lookupList"" class=""scroll_text""");
            WriteLiteral(@">

                                            <h4><a href=""/admin/template/metabolismtemplate"" class=""list-group-item active"">Metabolism Template</a></h4>

                                            <h4><a href=""/admin//template/index"" class=""list-group-item "">Epilepsy Template</a></h4>

                                            <h4><a href=""/admin/template/prostatetemplate"" class=""list-group-item "">Prostate Cancer Template</a></h4>

                                            <h4><a href=""/admin/template/methyationtemplate"" class=""list-group-item "">Methyation & Autism Template</a></h4>

                                            <h4><a href=""/admin/template/fatconsumptiontemplate"" class=""list-group-item "">Fat Consumption Template</a></h4>

                                            <h4><a href=""/admin/template/fitnesstemplate"" class=""list-group-item "">Fitness Template</a></h4>

                                            <h4><a href=""/admin/template/diettemplate"" class=""list-group-item "">");
            WriteLiteral(@"Diet Template</a></h4>

                                            <h4><a href=""/admin/template/vitamintemplate"" class=""list-group-item "">Vitamins Template</a></h4>

                                            <h4><a href=""/admin/template/mineraltemplate"" class=""list-group-item "">Mineral Template</a></h4>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-md-9"">
                                <div class=""row"">
                                    <div class=""col-md-4 col-lg-4"">
                                        <input type=""button"" name=""submit"" onclick=""AddMetabolism();"" value=""Save"" class=""btn btn-xs btn-primary"" />
                                        <a href=""/admin/template/metabolismtemplate"" class=""btn btn-xs btn-info"">Back</a>
                                    </div>
                                    <div class=""col-md");
            WriteLiteral(@"-12 col-lg-12"">
                                        <div class=""row"">
                                            <div class=""col-md-6"">
                                                <label>Consumption Type</label>
                                                <div class=""form-group"">
                                                    ");
            EndContext();
            BeginContext(3821, 170, false);
#line 64 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Template\AddMetabolismTemplate.cshtml"
                                               Write(Html.DropDownListFor(m => m.ConsumptionTypeID, new SelectList(ViewBag.ConsumptionType, "ID", "Name"), "Select Consumption Type", new { @class = "form-control dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(3991, 382, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""col-md-6"">
                                                <label>Effected Gene</label>
                                                <div class=""form-group"">
                                                    ");
            EndContext();
            BeginContext(4374, 161, false);
#line 70 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Template\AddMetabolismTemplate.cshtml"
                                               Write(Html.DropDownList("something", new SelectList(ViewBag.Gene, "ID", "Name"), htmlAttributes: new { @class = "selectpicker tryMultiselect", multiple = "multiple" }));

#line default
#line hidden
            EndContext();
            BeginContext(4535, 377, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""col-md-6"">
                                                <label>Effected</label>
                                                <div class=""form-group"">
                                                    ");
            EndContext();
            BeginContext(4913, 556, false);
#line 76 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Template\AddMetabolismTemplate.cshtml"
                                               Write(Html.DropDownList("Effected", new List<SelectListItem>
                                                     {
                                                          new SelectListItem{ Text="High", Value = "1" },
                                                          new SelectListItem{ Text="Medium", Value = "2" },
                                                          new SelectListItem{ Text="Low", Value = "3" },
                                                     }, "Select Effected Level", new { @class = "form-control dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(5469, 382, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""col-md-6"">
                                                <label>Recomendation</label>
                                                <div class=""form-group"">
                                                    ");
            EndContext();
            BeginContext(5852, 70, false);
#line 87 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Template\AddMetabolismTemplate.cshtml"
                                               Write(Html.TextBoxFor(m => m.Recomendation, new { @Class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(5922, 1917, true);
            WriteLiteral(@"
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
    </div>
</form>
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-select/1.13.1/css/bootstrap-select.css"" />
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.bundle.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-select/1.13.1/js/bootstrap-select.min.js""></script>


<script>
    function AddMetabolism() {
        debugger
           var formdata = new FormData($('form').get(0));
        i = 0;
        $("".tryMultiselect option:se");
            WriteLiteral(@"lected"").each(function () {
            debugger
            var $this = $(this);

            formdata.append(""EffectedGeneMetabolism["" + i + ""].GeneID"", $this[0].value);
            i++;
        });
        for (var pair of formdata.entries()) {
            console.log(pair[0] + ', ' + pair[1]);
        }
        debugger
        $.ajax({
            type: 'POST',
            url: ""/admin/template/AddMetabolismTemplate"",
            data: formdata,
            dataType: ""json"",
            processData: false,
            contentType: false,
            success: function (response) {
                debugger
                console.log(response);
                toastr.info('Record saved');
            },
            error: function (xhr, status) {
                toastr.error('Something went wrong');
            }
        });


    }
    
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Models.MetabolismTemplate> Html { get; private set; }
    }
}
#pragma warning restore 1591
