#pragma checksum "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\UpdateDietTemplate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b492723eb4a624832d7f4cc08445a10fd29e4464"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Template_UpdateDietTemplate), @"mvc.1.0.view", @"/Areas/Admin/Views/Template/UpdateDietTemplate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Template/UpdateDietTemplate.cshtml", typeof(AspNetCore.Areas_Admin_Views_Template_UpdateDietTemplate))]
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
#line 3 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\UpdateDietTemplate.cshtml"
using Data.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b492723eb4a624832d7f4cc08445a10fd29e4464", @"/Areas/Admin/Views/Template/UpdateDietTemplate.cshtml")]
    public class Areas_Admin_Views_Template_UpdateDietTemplate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GeneticSystem.Areas.Admin.Models.DietViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\UpdateDietTemplate.cshtml"
  
    ViewData["Title"] = " Update Diet Template";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(181, 571, true);
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
            BeginContext(877, 229, true);
            WriteLiteral("\r\n<form action=\"/admin/sms/addadmingroups\" method=\"post\">\r\n    <div class=\"prtm-content\">\r\n        <div class=\"prtm-page-bar\">\r\n            <ul class=\"breadcrumb\">\r\n                <li class=\"breadcrumb-item text-capitalize\"><h2>");
            EndContext();
            BeginContext(1107, 17, false);
#line 30 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\UpdateDietTemplate.cshtml"
                                                           Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(1124, 2913, true);
            WriteLiteral(@"</h2></li>
                <li class=""breadcrumb-item""><a href=""#"">Dashboard</a></li>
                <li class=""breadcrumb-item""><a href=""#"">Ui elements</a></li>
                <li class=""breadcrumb-item""><a href=""#"" class=""active""> Diet Template</a></li>
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
                                        <div id=""lookupList"" class=""scroll_text"">");
            WriteLiteral(@"

                                            <h4><a href=""/admin/template/metabolismtemplate"" class=""list-group-item "">Metabolism Template</a></h4>

                                            <h4><a href=""/admin//template/index"" class=""list-group-item "">Epilepsy Template</a></h4>

                                            <h4><a href=""/admin/template/prostatetemplate"" class=""list-group-item "">Prostate Cancer Template</a></h4>

                                            <h4><a href=""/admin/template/methyationtemplate"" class=""list-group-item "">Methyation & Autism Template</a></h4>

                                            <h4><a href=""/admin/template/fatconsumptiontemplate"" class=""list-group-item "">Fat Consumption Template</a></h4>

                                            <h4><a href=""/admin/template/fitnesstemplate"" class=""list-group-item "">Fitness Template</a></h4>

                                            <h4><a href=""/admin/template/diettemplate"" class=""list-group-item active"">D");
            WriteLiteral(@"iet Template</a></h4>

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
                                        <input type=""button"" name=""submit"" onclick=""UpdateDietTemplate();"" value=""Update"" class=""btn btn-xs btn-warning"" />
");
            EndContext();
            BeginContext(4166, 488, true);
            WriteLiteral(@"                                        <a href=""/admin/template/diettemplate"" class=""btn btn-xs btn-info"">Back</a>
                                    </div>
                                    <div class=""col-md-12 col-lg-12"">
                                        <div class=""row"">
                                            <div class=""col-md-6"">
                                                <label>Consumption Type</label>
                                                ");
            EndContext();
            BeginContext(4655, 33, false);
#line 84 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\UpdateDietTemplate.cshtml"
                                           Write(Html.HiddenFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(4688, 128, true);
            WriteLiteral("\r\n                                                <div class=\"form-group\">\r\n                                                    ");
            EndContext();
            BeginContext(4817, 178, false);
#line 86 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\UpdateDietTemplate.cshtml"
                                               Write(Html.DropDownListFor(model => model.ConsumptionTypeID, new SelectList(ViewBag.ConsumptionType, "ID", "Name"), "Select Consumption Type", new { @class = "form-control dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(4995, 330, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""col-md-6"">
                                                <label>Effected Gene</label>
                                                <div class=""form-group"">
");
            EndContext();
            BeginContext(5561, 52, true);
            WriteLiteral("                                                    ");
            EndContext();
            BeginContext(5614, 179, false);
#line 93 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\UpdateDietTemplate.cshtml"
                                               Write(Html.DropDownList("something", new SelectList(ViewBag.Gene, "ID", "Name"), htmlAttributes: new { @class = "selectpicker tryMultiselect", multiple = "multiple", @hidden = "true" }));

#line default
#line hidden
            EndContext();
            BeginContext(5793, 410, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""row"">
                                            <div class=""col-md-6"">
                                                <label> Good Effect</label>
                                                ");
            EndContext();
            BeginContext(6204, 33, false);
#line 100 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\UpdateDietTemplate.cshtml"
                                           Write(Html.HiddenFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(6237, 128, true);
            WriteLiteral("\r\n                                                <div class=\"form-group\">\r\n                                                    ");
            EndContext();
            BeginContext(6366, 70, false);
#line 102 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\UpdateDietTemplate.cshtml"
                                               Write(Html.TextAreaFor(x => x.EffectedGood, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(6436, 381, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""col-md-6"">
                                                <label> Bad Effect </label>
                                                <div class=""form-group"">
                                                    ");
            EndContext();
            BeginContext(6818, 69, false);
#line 108 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\UpdateDietTemplate.cshtml"
                                               Write(Html.TextAreaFor(x => x.EffectedBad, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(6887, 1494, true);
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
     function UpdateDietTemplate() {
        var formdata = new FormData($('form').get(0));
        i = 0;
        $(""#something option:selected"").each(function () {
            debugger
           // alert(1);
            var $this = $(this);

            formdata.append(""Gene["" + i + ""].GeneID"", $this[0].value);
            i++;
        });
        for (var pair of formdata.entries()) {
            console.log(pair[0] + ', ' + pair[1]);
        }
        debugger
        $.ajax({
            type: 'POST',
            url: ""/admin/template/updatediettemplates"",");
            WriteLiteral(@"
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
            BeginContext(8382, 36, false);
#line 162 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\UpdateDietTemplate.cshtml"
               Write(Html.Raw(Json.Serialize(Model.Gene)));

#line default
#line hidden
            EndContext();
            BeginContext(8418, 450, true);
            WriteLiteral(@";
            console.log(xray);
            if (xray != null) {
                $.each(xray, function (i, e) {
                    debugger
                    console.log(xray);
     $(""#something option[value='"" + e.geneID + ""']"").prop(""selected"", true);
            });
            }
        $(""select"").prop('class', 'selectpicker show-tick form-control');
        $(""select"").attr('data-live-search', true);
    });
     var xray = ");
            EndContext();
            BeginContext(8869, 36, false);
#line 174 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\UpdateDietTemplate.cshtml"
           Write(Html.Raw(Json.Serialize(Model.Gene)));

#line default
#line hidden
            EndContext();
            BeginContext(8905, 422, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GeneticSystem.Areas.Admin.Models.DietViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
