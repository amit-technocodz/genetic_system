#pragma checksum "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\UpdateFitnessTemplate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a824bfdbc280b50c5f6a6fa8c8429c9f57ad9f7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Template_UpdateFitnessTemplate), @"mvc.1.0.view", @"/Areas/Admin/Views/Template/UpdateFitnessTemplate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Template/UpdateFitnessTemplate.cshtml", typeof(AspNetCore.Areas_Admin_Views_Template_UpdateFitnessTemplate))]
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
#line 4 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\UpdateFitnessTemplate.cshtml"
using Data.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a824bfdbc280b50c5f6a6fa8c8429c9f57ad9f7d", @"/Areas/Admin/Views/Template/UpdateFitnessTemplate.cshtml")]
    public class Areas_Admin_Views_Template_UpdateFitnessTemplate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GeneticSystem.Areas.Admin.Models.AddFitnessViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\UpdateFitnessTemplate.cshtml"
  
    ViewData["Title"] = " Update Fitness Template";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(192, 571, true);
            WriteLiteral(@"

}
<style>
    .border-left {
        border-left: 1px solid black;
    }

    .mg-t {
        margin-top: 10PX;
    }
</style>
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-select/1.13.1/css/bootstrap-select.css"" />
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.bundle.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-select/1.13.1/js/bootstrap-select.min.js""></script>
");
            EndContext();
            BeginContext(888, 229, true);
            WriteLiteral("\r\n<form action=\"/admin/sms/addadmingroups\" method=\"post\">\r\n    <div class=\"prtm-content\">\r\n        <div class=\"prtm-page-bar\">\r\n            <ul class=\"breadcrumb\">\r\n                <li class=\"breadcrumb-item text-capitalize\"><h2>");
            EndContext();
            BeginContext(1118, 17, false);
#line 31 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\UpdateFitnessTemplate.cshtml"
                                                           Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(1135, 2921, true);
            WriteLiteral(@"</h2></li>
                <li class=""breadcrumb-item""><a href=""#"">Dashboard</a></li>
                <li class=""breadcrumb-item""><a href=""#"">Ui elements</a></li>
                <li class=""breadcrumb-item""><a href=""#"" class=""active""> Fitness Template</a></li>
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
                                        <div id=""lookupList"" class=""scroll_tex");
            WriteLiteral(@"t"">

                                            <h4><a href=""/admin/template/metabolismtemplate"" class=""list-group-item "">Metabolism Template</a></h4>

                                            <h4><a href=""/admin//template/index"" class=""list-group-item "">Epilepsy Template</a></h4>

                                            <h4><a href=""/admin/template/prostatetemplate"" class=""list-group-item "">Prostate Cancer Template</a></h4>

                                            <h4><a href=""/admin/template/methyationtemplate"" class=""list-group-item "">Methyation & Autism Template</a></h4>

                                            <h4><a href=""/admin/template/fatconsumptiontemplate"" class=""list-group-item "">Fat Consumption Template</a></h4>

                                            <h4><a href=""/admin/template/fitnesstemplate"" class=""list-group-item active"">Fitness Template</a></h4>

                                            <h4><a href=""/admin/template/diettemplate"" class=""list-group-item ");
            WriteLiteral(@""">Diet Template</a></h4>

                                            <h4><a href=""/admin/template/vitamintemplate"" class=""list-group-item "">Vitamins Template</a></h4>

                                            <h4><a href=""/admin/template/vitamintemplate"" class=""list-group-item"">Mineral Template</a></h4>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-md-9"">
                                <!-- Modal content-->


                                <div class=""row"">
                                    <div class=""col-md-4 col-lg-4"">
                                        <input type=""button"" name=""submit"" onclick=""UpdateFitnessTemplate();"" value=""Update"" class=""btn btn-xs btn-warning"" />
");
            EndContext();
            BeginContext(4185, 491, true);
            WriteLiteral(@"                                        <a href=""/admin/template/fitnesstemplate"" class=""btn btn-xs btn-info"">Back</a>
                                    </div>
                                    <div class=""col-md-12 col-lg-12"">
                                        <div class=""row"">
                                            <div class=""col-md-6"">
                                                <label>Consumption Type</label>
                                                ");
            EndContext();
            BeginContext(4677, 33, false);
#line 86 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\UpdateFitnessTemplate.cshtml"
                                           Write(Html.HiddenFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(4710, 128, true);
            WriteLiteral("\r\n                                                <div class=\"form-group\">\r\n                                                    ");
            EndContext();
            BeginContext(4839, 178, false);
#line 88 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\UpdateFitnessTemplate.cshtml"
                                               Write(Html.DropDownListFor(model => model.ConsumptionTypeID, new SelectList(ViewBag.ConsumptionType, "ID", "Name"), "Select Consumption Type", new { @class = "form-control dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(5017, 330, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""col-md-6"">
                                                <label>Effected Gene</label>
                                                <div class=""form-group"">
");
            EndContext();
            BeginContext(5583, 52, true);
            WriteLiteral("                                                    ");
            EndContext();
            BeginContext(5636, 179, false);
#line 95 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\UpdateFitnessTemplate.cshtml"
                                               Write(Html.DropDownList("something", new SelectList(ViewBag.Gene, "ID", "Name"), htmlAttributes: new { @class = "selectpicker tryMultiselect", multiple = "multiple", @hidden = "true" }));

#line default
#line hidden
            EndContext();
            BeginContext(5815, 410, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""row"">
                                            <div class=""col-md-6"">
                                                <label> Good Effect</label>
                                                ");
            EndContext();
            BeginContext(6226, 33, false);
#line 102 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\UpdateFitnessTemplate.cshtml"
                                           Write(Html.HiddenFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(6259, 128, true);
            WriteLiteral("\r\n                                                <div class=\"form-group\">\r\n                                                    ");
            EndContext();
            BeginContext(6388, 70, false);
#line 104 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\UpdateFitnessTemplate.cshtml"
                                               Write(Html.TextAreaFor(x => x.EffectedGood, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(6458, 381, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""col-md-6"">
                                                <label> Bad Effect </label>
                                                <div class=""form-group"">
                                                    ");
            EndContext();
            BeginContext(6840, 69, false);
#line 110 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\UpdateFitnessTemplate.cshtml"
                                               Write(Html.TextAreaFor(x => x.EffectedBad, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(6909, 1515, true);
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



<script>
     function UpdateFitnessTemplate() {
        var formdata = new FormData($('form').get(0));
        i = 0;
        $(""#something option:selected"").each(function () {
            debugger
           // alert(1);
            var $this = $(this);

            formdata.append(""EffectedGeneFitness["" + i + ""].GeneID"", $this[0].value);
            i++;
        });
        for (var pair of formdata.entries()) {
            console.log(pair[0] + ', ' + pair[1]);
        }
        debugger
        $.ajax({
            type: 'POST',
            url: ""/admin/template/upd");
            WriteLiteral(@"atefitnesstemplates"",
            data: formdata,
            dataType: ""json"",
            processData: false,
            contentType: false,
            success: function (response) {
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
            BeginContext(8425, 51, false);
#line 164 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\UpdateFitnessTemplate.cshtml"
               Write(Html.Raw(Json.Serialize(Model.EffectedGeneFitness)));

#line default
#line hidden
            EndContext();
            BeginContext(8476, 420, true);
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
     var xray = ");
            EndContext();
            BeginContext(8897, 51, false);
#line 175 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\UpdateFitnessTemplate.cshtml"
           Write(Html.Raw(Json.Serialize(Model.EffectedGeneFitness)));

#line default
#line hidden
            EndContext();
            BeginContext(8948, 420, true);
            WriteLiteral(@";
    if (xray != null) {
        debugger
         //$('#something').selectpicker('refresh');
        }
    //$('select').selectpicker('show');
    //$('.selectpicker').selectpicker('render');
    //$('.select').selectpicker('show');
    //$('select').selectpicker();
    //$('#something').multiselect()



</script>
<style>
    .chosen-container {
        width: 100% !important;
    }
</style>


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GeneticSystem.Areas.Admin.Models.AddFitnessViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591