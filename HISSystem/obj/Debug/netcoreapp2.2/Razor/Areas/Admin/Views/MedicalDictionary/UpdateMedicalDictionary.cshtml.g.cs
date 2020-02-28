#pragma checksum "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\MedicalDictionary\UpdateMedicalDictionary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "004b0e0d9c3afcdf7b94f5fdec701adfc7564cf0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_MedicalDictionary_UpdateMedicalDictionary), @"mvc.1.0.view", @"/Areas/Admin/Views/MedicalDictionary/UpdateMedicalDictionary.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/MedicalDictionary/UpdateMedicalDictionary.cshtml", typeof(AspNetCore.Areas_Admin_Views_MedicalDictionary_UpdateMedicalDictionary))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"004b0e0d9c3afcdf7b94f5fdec701adfc7564cf0", @"/Areas/Admin/Views/MedicalDictionary/UpdateMedicalDictionary.cshtml")]
    public class Areas_Admin_Views_MedicalDictionary_UpdateMedicalDictionary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Models.MedicalDictionary>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/avatar.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("user_img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\MedicalDictionary\UpdateMedicalDictionary.cshtml"
  
    ViewData["Title"] = "Update Medical Dictionary";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(145, 534, true);
            WriteLiteral(@"
<style>
    .location {
        width: 400px;
        height: 200px;
        padding: 50px;
        border: 1px solid silver;
    }

    #map-canvas {
        height: 300px;
        width: 600px;
        background-color: #CCC;
    }
</style>

<form asp-action=""Add"" class=""form-elments1"" role=""form"" method=""post"" enctype=""multipart/form-data"">
    <div class=""prtm-content"">
        <div class=""prtm-page-bar"">
            <ul class=""breadcrumb"">
                <li class=""breadcrumb-item text-capitalize""><h2>");
            EndContext();
            BeginContext(680, 17, false);
#line 26 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\MedicalDictionary\UpdateMedicalDictionary.cshtml"
                                                           Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(697, 1104, true);
            WriteLiteral(@"</h2></li>
                <li class=""breadcrumb-item""><a href=""#"">Dashboard</a></li>
                <li class=""breadcrumb-item""><a href=""#"">Ui elements</a></li>
                <li class=""breadcrumb-item""><a href=""#"" class=""active""> New Patient</a></li>
            </ul>
        </div>
        <div class=""row mrgn-b-sm"">
            <div class=""col-md-5 col-lg-5"">
                <input type=""submit"" name=""submit"" value=""Save"" class=""btn btn-xs btn-primary"" onclick=""saveOrderFunction();"" />
                <input type=""button"" name=""Update"" value=""Update"" class=""btn btn-xs btn-warning"" disabled />
                <input type=""button"" name=""History"" value=""History"" class=""btn btn-xs btn-info"" />
            </div>
        </div>

        <div class=""row mrgn-b-sm"">
            <div class=""col-md-12 col-lg-12"">
                <div class=""row"">
                    <div class=""col-md-10 col-lg-10"">
                        <div class=""row"">
                            <div class=""col-md-2 col");
            WriteLiteral("-lg-2\">\r\n                                Type:\r\n                                ");
            EndContext();
            BeginContext(1802, 138, false);
#line 47 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\MedicalDictionary\UpdateMedicalDictionary.cshtml"
                           Write(Html.DropDownListFor(m => m.TypeID, new SelectList(ViewBag.Types, "ID", "Name"), "Select Types", new { @class = "form-control dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(1940, 173, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-md-2 col-lg-2\">\r\n                                En Name:\r\n                                ");
            EndContext();
            BeginContext(2114, 115, false);
#line 51 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\MedicalDictionary\UpdateMedicalDictionary.cshtml"
                           Write(Html.TextBoxFor(m => m.EnName, null, new { @Class = "form-control", autocomplete = "true", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(2229, 173, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-md-2 col-lg-2\">\r\n                                Ar Name:\r\n                                ");
            EndContext();
            BeginContext(2403, 115, false);
#line 55 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\MedicalDictionary\UpdateMedicalDictionary.cshtml"
                           Write(Html.TextBoxFor(m => m.ArName, null, new { @Class = "form-control", autocomplete = "true", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(2518, 367, true);
            WriteLiteral(@"
                            </div>
                            <div class=""row"">
                                <div class=""col-md-8 col-lg-2"">
                                    <input type=""file"" name=""file"" multiple onchange=""show(this,1)"" style=""display:none;"" id=""fileimage"" />
                                    <div id=""display-img"" class=""img-div"">
");
            EndContext();
#line 61 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\MedicalDictionary\UpdateMedicalDictionary.cshtml"
                                         if (Model.ImagePath != null)
                                        {

#line default
#line hidden
            BeginContext(2999, 48, true);
            WriteLiteral("                                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3047, "\"", 3069, 1);
#line 63 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\MedicalDictionary\UpdateMedicalDictionary.cshtml"
WriteAttributeValue("", 3053, Model.ImagePath, 3053, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3070, 31, true);
            WriteLiteral(" alt=\"Image\" id=\"user_img\" />\r\n");
            EndContext();
#line 64 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\MedicalDictionary\UpdateMedicalDictionary.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(3233, 44, true);
            WriteLiteral("                                            ");
            EndContext();
            BeginContext(3277, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "004b0e0d9c3afcdf7b94f5fdec701adfc7564cf09976", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3340, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 68 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\MedicalDictionary\UpdateMedicalDictionary.cshtml"
                                        }

#line default
#line hidden
            BeginContext(3385, 1573, true);
            WriteLiteral(@"                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>

        <div class=""prtm-page-bar"">
            <div class=""form-style"">
                <div class=""row mrgn-b-sm"">
                    <div class=""row"">
                        <div class=""col-md-12 col-lg-12"">
                            <div>
                                <div class=""line-slide-tab"">
                                    <ul class=""nav nav-tabs"">
                                        <li class=""active""> <a data-toggle=""tab"" href=""#tab-26"" aria-expanded=""false""><i class=""fa fa-address-card"" aria-hidden=""true""></i> Info</a> </li>
                                    </ul>
                                    <div class=""tab-content pad-all-lg"">
                                        <div id=""tab-26"" class="" row tab-pane fade in active"">
 ");
            WriteLiteral(@"                                           <div class=""col-md-12 col-lg-12"">
                                                <div class=""row"">
                                                    <div class=""row mrgn-b-xs"">
                                                        <div class=""col-md-4"">
                                                            <div class=""col-md-10"">
                                                                <div class=""form-group"">
                                                                    ");
            EndContext();
            BeginContext(4959, 25, false);
#line 97 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\MedicalDictionary\UpdateMedicalDictionary.cshtml"
                                                               Write(Html.HiddenFor(m => m.ID));

#line default
#line hidden
            EndContext();
            BeginContext(4984, 175, true);
            WriteLiteral("\r\n                                                                    <label for=\"Type\">Telephone</label>\r\n                                                                    ");
            EndContext();
            BeginContext(5160, 72, false);
#line 99 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\MedicalDictionary\UpdateMedicalDictionary.cshtml"
                                                               Write(Html.TextBoxFor(m => m.Telephone, null, new { @Class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(5232, 492, true);
            WriteLiteral(@"
                                                                </div>
                                                            </div>
                                                            <div class=""col-md-10"">
                                                                <div class=""form-group"">
                                                                    <label for=""Type"">Telephone 2</label>
                                                                    ");
            EndContext();
            BeginContext(5725, 73, false);
#line 105 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\MedicalDictionary\UpdateMedicalDictionary.cshtml"
                                                               Write(Html.TextBoxFor(m => m.Telephone2, null, new { @Class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(5798, 487, true);
            WriteLiteral(@"
                                                                </div>
                                                            </div>
                                                            <div class=""col-md-10"">
                                                                <div class=""form-group"">
                                                                    <label for=""Type"">Mobile</label>
                                                                    ");
            EndContext();
            BeginContext(6286, 69, false);
#line 111 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\MedicalDictionary\UpdateMedicalDictionary.cshtml"
                                                               Write(Html.TextBoxFor(m => m.Mobile, null, new { @Class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(6355, 489, true);
            WriteLiteral(@"
                                                                </div>
                                                            </div>
                                                            <div class=""col-md-10"">
                                                                <div class=""form-group"">
                                                                    <label for=""Type"">Mobile 2</label>
                                                                    ");
            EndContext();
            BeginContext(6845, 70, false);
#line 117 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\MedicalDictionary\UpdateMedicalDictionary.cshtml"
                                                               Write(Html.TextBoxFor(m => m.Mobile2, null, new { @Class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(6915, 486, true);
            WriteLiteral(@"
                                                                </div>
                                                            </div>
                                                            <div class=""col-md-10"">
                                                                <div class=""form-group"">
                                                                    <label for=""Type"">Email</label>
                                                                    ");
            EndContext();
            BeginContext(7402, 68, false);
#line 123 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\MedicalDictionary\UpdateMedicalDictionary.cshtml"
                                                               Write(Html.TextBoxFor(m => m.Email, null, new { @Class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(7470, 485, true);
            WriteLiteral(@"
                                                                </div>
                                                            </div>
                                                            <div class=""col-md-10"">
                                                                <div class=""form-group"">
                                                                    <label for=""Type"">City</label>
                                                                    ");
            EndContext();
            BeginContext(7956, 137, false);
#line 129 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\MedicalDictionary\UpdateMedicalDictionary.cshtml"
                                                               Write(Html.DropDownListFor(m => m.CityID, new SelectList(ViewBag.City, "ID", "Name"), "Select Types", new { @class = "form-control dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(8093, 490, true);
            WriteLiteral(@"

                                                                </div>
                                                            </div>
                                                            <div class=""col-md-10"">
                                                                <div class=""form-group"">
                                                                    <label for=""Type"">Address</label>
                                                                    ");
            EndContext();
            BeginContext(8584, 70, false);
#line 136 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\MedicalDictionary\UpdateMedicalDictionary.cshtml"
                                                               Write(Html.TextBoxFor(m => m.Address, null, new { @Class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(8654, 422, true);
            WriteLiteral(@"
                                                                </div>
                                                            </div>
                                                            <div class=""col-md-10"">
                                                                <div class=""form-group"">
                                                                    <label for=""Type"">Specialty</label>
");
            EndContext();
            BeginContext(9993, 147, true);
            WriteLiteral("                                                                    <div>\r\n                                                                        ");
            EndContext();
            BeginContext(10141, 166, false);
#line 149 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\MedicalDictionary\UpdateMedicalDictionary.cshtml"
                                                                   Write(Html.DropDownList("something", new SelectList(ViewBag.Specialty, "ID", "Name"), htmlAttributes: new { @class = "selectpicker tryMultiselect", multiple = "multiple" }));

#line default
#line hidden
            EndContext();
            BeginContext(10307, 564, true);
            WriteLiteral(@"

                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div class=""col-md-10"">
                                                                <div class=""form-group"">
                                                                    <label for=""Type"">Class</label>
                                                                    ");
            EndContext();
            BeginContext(10872, 139, false);
#line 157 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\MedicalDictionary\UpdateMedicalDictionary.cshtml"
                                                               Write(Html.DropDownListFor(m => m.ClassID, new SelectList(ViewBag.Class, "ID", "Name"), "Select Class", new { @class = "form-control dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(11011, 371, true);
            WriteLiteral(@"
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class=""col-md-4"">
                                                            <div class=""col-md-10"">
");
            EndContext();
            BeginContext(11706, 64, true);
            WriteLiteral("                                                                ");
            EndContext();
            BeginContext(11771, 80, false);
#line 166 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\MedicalDictionary\UpdateMedicalDictionary.cshtml"
                                                           Write(Html.TextBoxFor(m => m.Latitude, new { @Class = "form-control", id = "mapLat" }));

#line default
#line hidden
            EndContext();
            BeginContext(11851, 66, true);
            WriteLiteral("\r\n                                                                ");
            EndContext();
            BeginContext(11918, 81, false);
#line 167 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\MedicalDictionary\UpdateMedicalDictionary.cshtml"
                                                           Write(Html.TextBoxFor(m => m.Longitude, new { @Class = "form-control", id = "mapLng" }));

#line default
#line hidden
            EndContext();
            BeginContext(11999, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(12265, 746, true);
            WriteLiteral(@"                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div id=""map-canvas"">
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




");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(13028, 592, true);
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-select/1.13.1/css/bootstrap-select.css"" />
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.bundle.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-select/1.13.1/js/bootstrap-select.min.js""></script>




    <script type=""text/javascript"" src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyDUakSTaXSqDmWWAhpmhqKFuKtYKkIcvWw""></script>
");
                EndContext();
                BeginContext(13810, 956, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(""#display-img"").click(function () {
            $(""#fileimage"").click();
        });

        function show(input, id) {
            if (input.files && input.files[0]) {
                var filerdr = new FileReader();
                filerdr.onload = function (e) {
                    if (id == 1) {
                        $('#user_img').attr('src', e.target.result);
                    }
                    else {
                        $('#user_sign').attr('src', e.target.result);
                    }
                }
                filerdr.readAsDataURL(input.files[0]);
            }
        }
    </script>


    <script>
        //function loadChosen() {
        //    $('.tryMultiselect').chosen();
        //}


        //$(document).ready(function () {
        //    loadChosen();
        //});

        $(document).ready(function () {
         var xray = ");
                EndContext();
                BeginContext(14767, 58, false);
#line 238 "E:\Genetic\genetic_system\HISSystem\Areas\Admin\Views\MedicalDictionary\UpdateMedicalDictionary.cshtml"
               Write(Html.Raw(Json.Serialize(Model.MedicalDictionarySpecialty)));

#line default
#line hidden
                EndContext();
                BeginContext(14825, 2084, true);
                WriteLiteral(@";
            console.log(xray);
            if (xray != null) {
                $.each(xray, function (i, e) {
                    console.log(xray);
                    $(""#something option[value='"" + e.specialtyID + ""']"").prop(""selected"", true);
                    debugger
            });
            }
        $(""select"").prop('class', 'selectpicker show-tick form-control');
        $(""select"").attr('data-live-search', true);
    });






        initialize();
        function initialize() {
            var mlat = document.getElementById(""mapLat"").value;
            var mlng = document.getElementById(""mapLng"").value;

            var myLatLng = new google.maps.LatLng(mlat, mlng),
                myOptions = {
                    zoom: 5,
                    center: myLatLng,
                    mapTypeId: google.maps.MapTypeId.ROADMAP
                },
                map = new google.maps.Map(document.getElementById('map-canvas'), myOptions),
                marker = new g");
                WriteLiteral(@"oogle.maps.Marker({
                    position: myLatLng,
                    map: map
                });

            marker.setMap(map);
        };


        function saveOrderFunction() {
            var formdata = new FormData($('form').get(0));
            formdata.append(""GeneTemplateId"", $(""#TestType"").val());
            for (var pair of formdata.entries()) {
                console.log(pair[0] + ', ' + pair[1]);
            }

            $.ajax({
                type: 'POST',
                url: ""/admin/medicaldictionary/UpdateMedicalDictionary"",
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
       ");
                WriteLiteral("     });\r\n        }\r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Models.MedicalDictionary> Html { get; private set; }
    }
}
#pragma warning restore 1591
