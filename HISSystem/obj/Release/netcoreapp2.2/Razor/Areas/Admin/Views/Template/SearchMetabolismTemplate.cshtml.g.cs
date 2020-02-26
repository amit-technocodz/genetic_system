#pragma checksum "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\SearchMetabolismTemplate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c0bf8cc3a4711aa78f7411f201a1f040217f4b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Template_SearchMetabolismTemplate), @"mvc.1.0.view", @"/Areas/Admin/Views/Template/SearchMetabolismTemplate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Template/SearchMetabolismTemplate.cshtml", typeof(AspNetCore.Areas_Admin_Views_Template_SearchMetabolismTemplate))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c0bf8cc3a4711aa78f7411f201a1f040217f4b5", @"/Areas/Admin/Views/Template/SearchMetabolismTemplate.cshtml")]
    public class Areas_Admin_Views_Template_SearchMetabolismTemplate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Helpers.PagedData<GeneticSystem.Areas.Admin.Models.MetabolismAddViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\SearchMetabolismTemplate.cshtml"
  
    ViewData["Title"] = "Metabolism Template List";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(194, 156, true);
            WriteLiteral("<div class=\"prtm-content\">\r\n\r\n    <div class=\"prtm-page-bar\">\r\n        <ul class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item text-capitalize\"><h2>");
            EndContext();
            BeginContext(351, 17, false);
#line 10 "E:\Projects\GeneticSystem\19-02-2020\GeneticSystem\GeneticSystem\HISSystem\Areas\Admin\Views\Template\SearchMetabolismTemplate.cshtml"
                                                       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(368, 939, true);
            WriteLiteral(@"</h2></li>
            <li class=""breadcrumb-item""><a href=""#"">Dashboard</a></li>
            <li class=""breadcrumb-item""><a href=""#"">Ui elements</a></li>
            <li class=""breadcrumb-item""><a href=""#"" class=""active"">Metabolism Template List</a></li>
        </ul>
    </div>
    <div class=""table-style"">
        <div class=""row mrgn-b-sm"">
            <div class=""col-md-5 col-lg-5"">
                <a href=""/admin/template/addmetabolismtemplate"" class=""btn btn-xs btn-primary""><i class=""fa fa-plus"" aria-hidden=""true""></i> Add</a>
            </div>
            <div class=""col-md-7 text-right search-block"">
                <div class=""input-group pull-right"" id=""adv-search"">
                    <input type=""text"" name=""search"" id=""search1"" class=""form-control"" placeholder=""Search..."" onkeyup=""getepilepsysearch(1);"" />
                </div>
            </div>
        </div>
        
    </div>
</div>

");
            EndContext();
            BeginContext(9161, 2072, true);
            WriteLiteral(@"<script>

    function Delete(id) {
        debugger
        alert(""check"")
        $.ajax({
            url: '/admin/template/DeleteMetabolismTemplate?id=' + id,
            type: 'GET',
            success: function (data) {
                debugger
                location.reload();
            },
            error: function () {
                debugger
                swal(""Cancelled"", ""Something went wrong :)"", ""error"");
            }
        });
    };




    function Edit(id) {
        debugger

        $.ajax({
            url: '/admin/template/EditMetabolismTemplate?id=' + id,
            type: 'GET',
            success: function (data) {
                debugger
                location.reload();
            },
            error: function () {
                debugger
                swal(""Cancelled"", ""Something went wrong :)"", ""error"");
            }
        });
    };

    function UpdateEpilepsyTemplate() {
        var data = new FormData();

        d");
            WriteLiteral(@"ata.append(""GeneID"", $(""#GeneID"").val());
        data.append(""ID"", $(""#ID"").val());
        data.append(""GeneticMutation"", $(""#GeneticMutation"").val());
        data.append(""PersonalRiskFactor"", $(""#PersonalRiskFactor"").val());
        data.append(""Hereditary"", $(""#Hereditary"").val());
        data.append(""Recommendations"", $(""#Recommendations"").val());
        if (document.getElementById('HaveMutation').checked) {
            data.append('HaveMutation', ""true"");
        }

        $.ajax({
            url: '/admin/template/EditMetabolismTemplate',
            data: data,
            type: 'Post',
            processData: false, contentType: false,
            success: function (result) {
                if (result) {
                    alert('Data Saved !')
                    $('#modalDiv').modal('hide');
                    window.location.reload();
                }
            },
            error: function (xhr, status) {
                alert(status)
            }
        });");
            WriteLiteral("\r\n\r\n\r\n\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Helpers.PagedData<GeneticSystem.Areas.Admin.Models.MetabolismAddViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
