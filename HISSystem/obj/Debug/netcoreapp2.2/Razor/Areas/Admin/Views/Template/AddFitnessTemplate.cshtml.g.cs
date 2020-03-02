#pragma checksum "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\AddFitnessTemplate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69b69cd66e75701f7e4c0d601ef29d04f3cf432d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Template_AddFitnessTemplate), @"mvc.1.0.view", @"/Areas/Admin/Views/Template/AddFitnessTemplate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Template/AddFitnessTemplate.cshtml", typeof(AspNetCore.Areas_Admin_Views_Template_AddFitnessTemplate))]
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
#line 3 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\AddFitnessTemplate.cshtml"
using Data.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69b69cd66e75701f7e4c0d601ef29d04f3cf432d", @"/Areas/Admin/Views/Template/AddFitnessTemplate.cshtml")]
    public class Areas_Admin_Views_Template_AddFitnessTemplate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GeneticSystem.Areas.Admin.Models.AddFitnessViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\AddFitnessTemplate.cshtml"
  
    ViewData["Title"] = "Fitness Template";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(182, 369, true);
            WriteLiteral(@"


<style>
    .border-left {
        border-left: 1px solid black;
    }

    .mg-t {
        margin-top: 10PX;
    }
</style>

<form action=""/admin/sms/addadmingroups"" method=""post"">
    <div class=""prtm-content"">
        <div class=""prtm-page-bar"">
            <ul class=""breadcrumb"">
                <li class=""breadcrumb-item text-capitalize""><h2>");
            EndContext();
            BeginContext(552, 17, false);
#line 25 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\AddFitnessTemplate.cshtml"
                                                           Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(569, 2913, true);
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

                                            <h4><a href=""/admin/template/mineraltemplate"" class=""list-group-item "">Mineral Template</a></h4>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-md-9"">
                                <!-- Modal content-->
                                <div class=""row"">
                                    <div class=""col-md-4 col-lg-4"">
                                        <input type=""button"" name=""submit"" onclick=""AddFitnessTemplate();"" value=""Save"" class=""btn btn-xs btn-primary"" />
");
            EndContext();
            BeginContext(3611, 491, true);
            WriteLiteral(@"                                        <a href=""/admin/template/fitnesstemplate"" class=""btn btn-xs btn-info"">Back</a>
                                    </div>
                                    <div class=""col-md-12 col-lg-12"">
                                        <div class=""row"">
                                            <div class=""col-md-6"">
                                                <label>Consumption Type</label>
                                                ");
            EndContext();
            BeginContext(4103, 33, false);
#line 78 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\AddFitnessTemplate.cshtml"
                                           Write(Html.HiddenFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(4136, 128, true);
            WriteLiteral("\r\n                                                <div class=\"form-group\">\r\n                                                    ");
            EndContext();
            BeginContext(4265, 178, false);
#line 80 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\AddFitnessTemplate.cshtml"
                                               Write(Html.DropDownListFor(model => model.ConsumptionTypeID, new SelectList(ViewBag.ConsumptionType, "ID", "Name"), "Select Consumption Type", new { @class = "form-control dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(4443, 330, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""col-md-6"">
                                                <label>Effected Gene</label>
                                                <div class=""form-group"">
");
            EndContext();
            BeginContext(5009, 52, true);
            WriteLiteral("                                                    ");
            EndContext();
            BeginContext(5062, 161, false);
#line 87 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\AddFitnessTemplate.cshtml"
                                               Write(Html.DropDownList("something", new SelectList(ViewBag.Gene, "ID", "Name"), htmlAttributes: new { @class = "selectpicker tryMultiselect", multiple = "multiple" }));

#line default
#line hidden
            EndContext();
            BeginContext(5223, 410, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""row"">
                                            <div class=""col-md-6"">
                                                <label> Good Effect</label>
                                                ");
            EndContext();
            BeginContext(5634, 33, false);
#line 94 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\AddFitnessTemplate.cshtml"
                                           Write(Html.HiddenFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(5667, 128, true);
            WriteLiteral("\r\n                                                <div class=\"form-group\">\r\n                                                    ");
            EndContext();
            BeginContext(5796, 70, false);
#line 96 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\AddFitnessTemplate.cshtml"
                                               Write(Html.TextAreaFor(x => x.EffectedGood, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(5866, 381, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""col-md-6"">
                                                <label> Bad Effect </label>
                                                <div class=""form-group"">
                                                    ");
            EndContext();
            BeginContext(6248, 69, false);
#line 102 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\Template\AddFitnessTemplate.cshtml"
                                               Write(Html.TextAreaFor(x => x.EffectedBad, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(6317, 2328, true);
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

</form>

<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-select/1.13.1/css/bootstrap-select.css"" />
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.bundle.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-select/1.13.1/js/bootstrap-select.min.js""></script>

<script>
    $(document).ready(function () {
       
        $(""select"").prop('class', 'selectpicker show-tick form-control');
        $(""select"").attr('data-live-search', tru");
            WriteLiteral(@"e);
    });
    $('select').selectpicker('show');
    $('.selectpicker').selectpicker('render');
    $('.select').selectpicker('show');
    //$('select').selectpicker();
    //$('#something').multiselect()
    function AddFitnessTemplate() {
        var formdata = new FormData($('form').get(0));
        i = 0;
        $("".tryMultiselect option:selected"").each(function () {
            debugger
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
            url: ""/admin/template/addfitnesstemplates"",
            data: formdata,
            dataType: ""json"",
            processData: false,
            contentType: false,
            success: function (response) {
                console.log(response);
                toas");
            WriteLiteral(@"tr.info('Record saved');
            },
            error: function (xhr, status) {
                toastr.error('Something went wrong');
            }
        });


    }


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
