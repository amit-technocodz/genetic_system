#pragma checksum "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Template\AddVitaminTemplate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9a9938873c153d594da733b272223c4dbf3a29a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Template_AddVitaminTemplate), @"mvc.1.0.view", @"/Areas/Admin/Views/Template/AddVitaminTemplate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Template/AddVitaminTemplate.cshtml", typeof(AspNetCore.Areas_Admin_Views_Template_AddVitaminTemplate))]
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
#line 3 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Template\AddVitaminTemplate.cshtml"
using Data.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9a9938873c153d594da733b272223c4dbf3a29a", @"/Areas/Admin/Views/Template/AddVitaminTemplate.cshtml")]
    public class Areas_Admin_Views_Template_AddVitaminTemplate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GeneticSystem.Areas.Admin.Models.VitaminViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Template\AddVitaminTemplate.cshtml"
  
    ViewData["Title"] = " Add Vitamin Template";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(184, 369, true);
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
            BeginContext(554, 17, false);
#line 25 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Template\AddVitaminTemplate.cshtml"
                                                           Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(571, 2917, true);
            WriteLiteral(@"</h2></li>
                <li class=""breadcrumb-item""><a href=""#"">Dashboard</a></li>
                <li class=""breadcrumb-item""><a href=""#"">Ui elements</a></li>
                <li class=""breadcrumb-item""><a href=""#"" class=""active""> Add Vitamin Template</a></li>
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
                                        <div id=""lookupList"" class=""scroll");
            WriteLiteral(@"_text"">

                                            <h4><a href=""/admin/template/metabolismtemplate"" class=""list-group-item "">Metabolism Template</a></h4>

                                            <h4><a href=""/admin//template/index"" class=""list-group-item "">Epilepsy Template</a></h4>

                                            <h4><a href=""/admin/template/prostatetemplate"" class=""list-group-item "">Prostate Cancer Template</a></h4>

                                            <h4><a href=""/admin/template/methyationtemplate"" class=""list-group-item "">Methyation & Autism Template</a></h4>

                                            <h4><a href=""/admin/template/fatconsumptiontemplate"" class=""list-group-item "">Fat Consumption Template</a></h4>

                                            <h4><a href=""/admin/template/fitnesstemplate"" class=""list-group-item "">Fitness Template</a></h4>

                                            <h4><a href=""/admin/template/diettemplate"" class=""list-group-item "">");
            WriteLiteral(@"Diet Template</a></h4>

                                            <h4><a href=""/admin/template/vitamintemplate"" class=""list-group-item active"">Vitamins Template</a></h4>

                                            <h4><a href=""/admin/template/mineraltemplate"" class=""list-group-item "">Mineral Template</a></h4>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-md-9"">
                                <!-- Modal content-->
                                <div class=""row"">
                                    <div class=""col-md-4 col-lg-4"">
                                        <input type=""button"" name=""submit"" onclick=""AddVitaminTemplate();"" value=""Save"" class=""btn btn-xs btn-primary"" />
");
            EndContext();
            BeginContext(3617, 486, true);
            WriteLiteral(@"                                        <a href=""/admin/template/vitamintemplate"" class=""btn btn-xs btn-info"">Back</a>
                                    </div>
                                    <div class=""col-md-12 col-lg-12"">
                                        <div class=""row"">
                                            <div class=""col-md-6"">
                                                <label>Feeder Type</label>
                                                ");
            EndContext();
            BeginContext(4104, 33, false);
#line 78 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Template\AddVitaminTemplate.cshtml"
                                           Write(Html.HiddenFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(4137, 128, true);
            WriteLiteral("\r\n                                                <div class=\"form-group\">\r\n                                                    ");
            EndContext();
            BeginContext(4266, 168, false);
#line 80 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Template\AddVitaminTemplate.cshtml"
                                               Write(Html.DropDownListFor(model => model.FeederTypeID, new SelectList(ViewBag.ConsumptionType, "ID", "Name"), "Select Feeder Type", new { @class = "form-control dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(4434, 330, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""col-md-6"">
                                                <label>Effected Gene</label>
                                                <div class=""form-group"">
");
            EndContext();
            BeginContext(5000, 52, true);
            WriteLiteral("                                                    ");
            EndContext();
            BeginContext(5053, 161, false);
#line 87 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Template\AddVitaminTemplate.cshtml"
                                               Write(Html.DropDownList("something", new SelectList(ViewBag.Gene, "ID", "Name"), htmlAttributes: new { @class = "selectpicker tryMultiselect", multiple = "multiple" }));

#line default
#line hidden
            EndContext();
            BeginContext(5214, 491, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""row"">
                                            <div class=""col-md-6"">
                                                <label>Recommendations</label>
                                                <div class=""form-group"">
                                                    ");
            EndContext();
            BeginContext(5706, 73, false);
#line 95 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\Template\AddVitaminTemplate.cshtml"
                                               Write(Html.TextAreaFor(x => x.Recommendations, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(5779, 325, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""form-group pad-tb-md"">
                                                <div class=""form-check"">
                                                    <label>
");
            EndContext();
            BeginContext(6225, 2720, true);
            WriteLiteral(@"                                                        <input type=""checkbox"" name=""Effect"" id=""Effect"" value=""true""><span class=""label-text"">Is Effected</span>
                                                    </label>
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
<script src=""https://cdnjs.cloudflare.com/ajax/libs/boo");
            WriteLiteral(@"tstrap-select/1.13.1/js/bootstrap-select.min.js""></script>

<script>
    $(document).ready(function () {

        $(""select"").prop('class', 'selectpicker show-tick form-control');
        $(""select"").attr('data-live-search', true);
    });
    $('select').selectpicker('show');
    $('.selectpicker').selectpicker('render');
    $('.select').selectpicker('show');
    //$('select').selectpicker();
    //$('#something').multiselect()
    function AddVitaminTemplate() {
        var formdata = new FormData($('form').get(0));
        i = 0;

        $("".tryMultiselect option:selected"").each(function () {
            debugger
            var $this = $(this);

            formdata.append(""EffectedGeneVitamins["" + i + ""].GeneID"", $this[0].value);
            i++;
        });
        if (document.getElementById('Effect').checked) {
                  //alert(1)
                formdata.append('Effect', ""true"");
            }
        for (var pair of formdata.entries()) {
            console.l");
            WriteLiteral(@"og(pair[0] + ', ' + pair[1]);
        }
        debugger
        $.ajax({
            type: 'POST',
            url: ""/admin/template/addvitamintemplates"",
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GeneticSystem.Areas.Admin.Models.VitaminViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
