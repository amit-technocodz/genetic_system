#pragma checksum "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\EditMetabolismTemplate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7719fbea46104b8caf9985bc2f5b27063d139f5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Template_EditMetabolismTemplate), @"mvc.1.0.view", @"/Areas/Admin/Views/Template/EditMetabolismTemplate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Template/EditMetabolismTemplate.cshtml", typeof(AspNetCore.Areas_Admin_Views_Template_EditMetabolismTemplate))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7719fbea46104b8caf9985bc2f5b27063d139f5b", @"/Areas/Admin/Views/Template/EditMetabolismTemplate.cshtml")]
    public class Areas_Admin_Views_Template_EditMetabolismTemplate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GeneticSystem.Areas.Admin.Models.MetabolismAddViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\EditMetabolismTemplate.cshtml"
  
    ViewData["Title"] = "Metabolism List";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(163, 242, true);
            WriteLiteral("\r\n<form action=\"/admin/template/EditMetabolismTemplate\" method=\"post\">\r\n    <div class=\"prtm-content\">\r\n        <div class=\"prtm-page-bar\">\r\n            <ul class=\"breadcrumb\">\r\n                <li class=\"breadcrumb-item text-capitalize\"><h2>");
            EndContext();
            BeginContext(406, 17, false);
#line 12 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\EditMetabolismTemplate.cshtml"
                                                           Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(423, 3426, true);
            WriteLiteral(@"</h2></li>
                <li class=""breadcrumb-item""><a href=""#"">Dashboard</a></li>
                <li class=""breadcrumb-item""><a href=""#"">Ui elements</a></li>
                <li class=""breadcrumb-item""><a href=""#"" class=""active""> Edit Metabolism</a></li>
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
                                        <div id=""lookupList"" class=""scroll_text");
            WriteLiteral(@""">

                                            <h4><a href=""/admin/template/metabolismtemplate"" class=""list-group-item active"">Metabolism Template</a></h4>

                                            <h4><a href=""/admin//template/index"" class=""list-group-item "">Epilepsy Template</a></h4>

                                            <h4><a href=""/admin/template/prostatetemplate"" class=""list-group-item "">Prostate Cancer Template</a></h4>

                                            <h4><a href=""/admin/template/methyationtemplate"" class=""list-group-item "">Methyation & Autism Template</a></h4>

                                            <h4><a href=""/admin/template/fatconsumptiontemplate"" class=""list-group-item "">Fat Consumption Template</a></h4>

                                            <h4><a href=""/admin/template/fitnesstemplate"" class=""list-group-item "">Fitness Template</a></h4>

                                            <h4><a href=""/admin/template/diettemplate"" class=""list-group-item """);
            WriteLiteral(@">Diet Template</a></h4>

                                            <h4><a href=""/admin/template/vitamintemplate"" class=""list-group-item "">Vitamins Template</a></h4>

                                            <h4><a href=""/admin/template/mineraltemplate"" class=""list-group-item "">Mineral Template</a></h4>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-md-9"">
                                <div class=""row"">
                                    <div class=""col-md-4 col-lg-4"">
                                        <input type=""button"" name=""submit"" onclick=""AddMetabolism();"" value=""Update"" class=""btn btn-xs btn-warning"" />
                                        <a href=""/admin/template/metabolismtemplate"" class=""btn btn-xs btn-info"">Back</a>
                                    </div>
                                    <div class=""col");
            WriteLiteral(@"-md-12 col-lg-12"">
                                        <div class=""row"">
                                            <div class=""col-md-6"">
                                                <label>Consumption Type</label>
                                                <div class=""form-group"">
                                                    ");
            EndContext();
            BeginContext(3850, 25, false);
#line 64 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\EditMetabolismTemplate.cshtml"
                                               Write(Html.HiddenFor(m => m.ID));

#line default
#line hidden
            EndContext();
            BeginContext(3875, 54, true);
            WriteLiteral("\r\n                                                    ");
            EndContext();
            BeginContext(3930, 170, false);
#line 65 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\EditMetabolismTemplate.cshtml"
                                               Write(Html.DropDownListFor(m => m.ConsumptionTypeID, new SelectList(ViewBag.ConsumptionType, "ID", "Name"), "Select Consumption Type", new { @class = "form-control dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(4100, 382, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""col-md-6"">
                                                <label>Effected Gene</label>
                                                <div class=""form-group"">
                                                    ");
            EndContext();
            BeginContext(4483, 161, false);
#line 71 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\EditMetabolismTemplate.cshtml"
                                               Write(Html.DropDownList("something", new SelectList(ViewBag.Gene, "ID", "Name"), htmlAttributes: new { @class = "selectpicker tryMultiselect", multiple = "multiple" }));

#line default
#line hidden
            EndContext();
            BeginContext(4644, 377, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""col-md-6"">
                                                <label>Effected</label>
                                                <div class=""form-group"">
                                                    ");
            EndContext();
            BeginContext(5022, 556, false);
#line 77 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\EditMetabolismTemplate.cshtml"
                                               Write(Html.DropDownList("Effected", new List<SelectListItem>
                                                     {
                                                          new SelectListItem{ Text="High", Value = "1" },
                                                          new SelectListItem{ Text="Medium", Value = "2" },
                                                          new SelectListItem{ Text="Low", Value = "3" },
                                                     }, "Select Effected Level", new { @class = "form-control dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(5578, 382, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""col-md-6"">
                                                <label>Recomendation</label>
                                                <div class=""form-group"">
                                                    ");
            EndContext();
            BeginContext(5961, 70, false);
#line 88 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\EditMetabolismTemplate.cshtml"
                                               Write(Html.TextBoxFor(m => m.Recomendation, new { @Class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(6031, 1958, true);
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
        $(""#something option:selected"")");
            WriteLiteral(@".each(function () {
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
            url: ""/admin/template/EditMetabolismTemplate"",
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



    $(document).ready(function () {
         var xray = ");
            EndContext();
            BeginContext(7990, 54, false);
#line 147 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\EditMetabolismTemplate.cshtml"
               Write(Html.Raw(Json.Serialize(Model.EffectedGeneMetabolism)));

#line default
#line hidden
            EndContext();
            BeginContext(8044, 413, true);
            WriteLiteral(@";
            console.log(xray);
            if (xray != null) {
                $.each(xray, function (i, e) {
                    console.log(xray);
     $(""#something option[value='"" + e.geneID + ""']"").prop(""selected"", true);
            });
            }
        $(""select"").prop('class', 'selectpicker show-tick form-control');
        $(""select"").attr('data-live-search', true);
    });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GeneticSystem.Areas.Admin.Models.MetabolismAddViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591