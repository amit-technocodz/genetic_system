#pragma checksum "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Lookup\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c43128d48aaea0cfc22d967028c58708e2615bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Lookup_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Lookup/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Lookup/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Lookup_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c43128d48aaea0cfc22d967028c58708e2615bb", @"/Areas/Admin/Views/Lookup/Index.cshtml")]
    public class Areas_Admin_Views_Lookup_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Data.Models.Lookup>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Lookup\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(120, 1443, true);
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
</style>
<div class=""prtm-content"">
    <div class=""prtm-page-bar"">
        <ul class=""breadcrumb"">
            <li class=""breadcrumb-item text-capitalize""><h2>Lookup</h2></li>
            <li class=""breadcrumb-item""><a href=""#"">Settings</a></li>
            <li class=""breadcrumb-item""><a href=""#"">Lookup</a></li>
            <li class=""breadcrumb-item""><a href=""#"" class=""active"">Lookup List</a></li>
        </ul>
        <div class=""row"">
            <div class=""col-md-7 text-left search-block"">
                <div class=""input-group pull-right"" id=""adv-search"">
                    <label for=""search"">Search Master Lookup:</label>
                   ");
            WriteLiteral(@" <input type=""text"" name=""search"" id=""search"" class=""form-control"" placeholder=""Search Master Lookup..."" />
                </div>
            </div>
            <div class=""col-md-5""> <label for=""search"">&nbsp;</label> <br /><a href=""#"" data-info=""addMasterLookup"" class=""btn btn-xs btn-warning addMasterLookup""><i class=""fa fa-plus"" aria-hidden=""true""></i> Add Master Lookup</a></div>
        </div>
    </div>
");
            EndContext();
            BeginContext(3078, 656, true);
            WriteLiteral(@"
    <div class="""">
        <div class=""row"">
            <div class=""col-md-12 col-lg-12 col-xs-12"">
                <div class=""prtm-full-block p-10"">
                    <div class=""row"">
                        <div class=""col-md-3"">
                            <div class=""row left-row-pad"">
                                <div class=""col-md-12 col-sm-12 col-lg-12 col-xs-12"">
                                    <h5>All Lookups</h5>
                                </div>
                                <div class=""col-md-12 col-sm-12 col-lg-12 col-xs-12"">
                                    <div id=""lookupList"" class=""scroll_text"">
");
            EndContext();
#line 82 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Lookup\Index.cshtml"
                                         foreach (var item in ViewBag.Lookups)
                                        {

#line default
#line hidden
            BeginContext(3857, 84, true);
            WriteLiteral("                                            <h4><a href=\"#\" class=\"list-group-item \"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3941, "\"", 3978, 3);
            WriteAttributeValue("", 3951, "GetLookupForm(this,\'", 3951, 20, true);
#line 84 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Lookup\Index.cshtml"
WriteAttributeValue("", 3971, item, 3971, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 3976, "\')", 3976, 2, true);
            EndWriteAttribute();
            BeginContext(3979, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3981, 4, false);
#line 84 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Lookup\Index.cshtml"
                                                                                                                      Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(3985, 11, true);
            WriteLiteral("</a></h4>\r\n");
            EndContext();
#line 85 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Lookup\Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(4039, 384, true);
            WriteLiteral(@"                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-9"">
                            <div class=""row"">
                                <input type=""hidden"" id=""LKPType"" name=""Type"" />
                                <div id=""DataLookup"">
");
            EndContext();
            BeginContext(6836, 1415, true);
            WriteLiteral(@"                                </div>

                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
</div>




<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""addModal"">
    <div class=""modal-dialog"" role=""document"">
        <div id=""addModalContent"" class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Add New Lookup</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div id=""addModalBody"" class=""modal-body"">
            </div>
        </div>
    </div>
</div>
<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""addMasterModal"">
    <div class=""modal-dialog"" role=""document"">
        <div id=""masterModalContent"" class=""modal-content"">
            <div class=""modal-head");
            WriteLiteral(@"er"">
                <h5 class=""modal-title"">Add New Master Lookup</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div id=""masterModalBody"" class=""modal-body"">
            </div>
        </div>
    </div>
</div>
");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(8268, 6842, true);
                WriteLiteral(@"
    <script>

        function GetLookupForm(current, type) {
		$("".list-group-item"").removeClass('active')
		$(current).addClass('active')
		$(""#LKPType"").val(type);
		$.ajax({
			url: '/admin/lookup/GetLookupIndex?lookupName=' + type,
			contentType: 'application/json; charse=utf-8',
			type: 'get',
			success: function (result) {
				debugger
                $(""#DataLookup"").empty();
                $(""#DataLookup"").append(result);
			},
			error: function (xhr, status) {
				alert(status)
			}
		});
	}

        $(document).on(""click"", "".addMasterLookup"", function(){
                var options = {
                    ""backdrop"": ""static"",
                    keyboard: true
                };
                $.ajax({
                    type: ""GET"",
                    url: '/admin/lookup/AddMaster',
                    success: function (data) {
                        $('#masterModalBody').html(data);
                        $('#addMasterModal').modal(options);
         ");
                WriteLiteral(@"               $('#addMasterModal').modal('show');
                    },
                    error: function () {
                        alert(""Content load failed."");
                    }
                });
        });



        $(function () {
            $(""#addLookUp"").on('submit', function (e) {
                e.preventDefault()
                var dataToPost = $(this).serialize()
                $.post(""/admin/lookup/add"", dataToPost)
                    .done(function (response, status, jqxhr) {
                    })
                    .fail(function (jqxhr, status, error) {
                    })
            })
        })

        $(function () {
            $(""#editLookUp"").on('submit', function (e) {
                e.preventDefault()
                var dataToPost = $(this).serialize()
                console.log(dataToPost)
                $.post(""/admin/lookup/GetPatients"", dataToPost)
                    .done(function (response, status, jqxhr) {
            ");
                WriteLiteral(@"        })
                    .fail(function (jqxhr, status, error) {
                    })
            })
        })

        $(document).ready(function () {
            $(""body"").on(""click"", '.page-number', function () {
             
                var page = parseInt($(this).html());
                  //alert(page);
                var lookupName = $(this).closest('td').attr('id');
                $.ajax({
                    url: '/admin/lookup/_getlookupindex',
                    context: $(this),
                    data: { ""lookupName"": lookupName, ""page"": page },
                    success: function (data) {
                        debugger
                         $(""#DataLookup"").empty();
                         $(""#DataLookup"").append(data);
                    }
                });
            });
        });

        $(document).ready(function () {
            debugger
            $('.collapse.in').prev('.panel-heading').addClass('active');
            $('#accor");
                WriteLiteral(@"dion, #bs-collapse')
                .on('show.bs.collapse', function (a) {
                    var info = $(event.target).data('info');
                    var str = $(event.target).data('info').toLowerCase();
                    debugger
                    $('#'+ str + 'List').load('/admin/lookup/getlookupindex?lookupName=' + info);
                    $(a.target).closest('.panel-heading').addClass('active');
                    $(a.target).prev('.panel-heading').addClass('active');
                })
                .on('hide.bs.collapse', function (a) {
                    $(a.target).prev('.panel-heading').removeClass('active');
                });
        });


        $(document).on(""click"", "".addLookup"", function(){
                var $buttonClicked = $(this);
                var lookupName = $(this).data('info');
                var options = {
                    ""backdrop"": ""static"",
                    keyboard: true
                };
                $.ajax({
            ");
                WriteLiteral(@"        type: ""GET"",
                    url: '/admin/lookup/Add',
                    data: { lookupName: lookupName },
                    success: function (data) {
                        $('#addModalBody').html(data);
                        $('#addModal').modal(options);
                        $('#addModal').modal('show');
                    },
                    error: function () {
                        alert(""Content load failed."");
                    }
                });
        });

        function SaveMasterLookup() {
            var type = $(""#Type"").val();
            var typeid = $(""#TypeID"").val();
            var name = $(""#Name"").val();
            var Lookup = {};
            Lookup.Type = type;
            Lookup.TypeID = typeid;
            Lookup.Name = name;
            $.ajax({
                type: ""POST"",
                url: '/admin/lookup/AddNewMaster',
                data: { lookup: Lookup },
                success: function (data) {
          ");
                WriteLiteral(@"          location.reload();
                },
                error: function () {
                    alert(""Content load failed."");
                }

            });
}
        $(document).ready(function () {
            $('body').on('click', '.editLookup', function () {
                var $buttonClicked = $(this);
                var lookupID = $(this).attr('id');
                var options = {
                    ""backdrop"": ""static"",
                    keyboard: true
                };
                $.ajax({
                    type: ""GET"",
                    url: '/admin/lookup/GetLookup',
                    data: { lookupID: lookupID },
                    success: function (data) {
                        $('#addModalBody').html(data);
                        $('#addModal').modal(options);
                        $('#addModal').modal('show');
                    },
                    error: function () {
                        alert(""Content load failed."");
      ");
                WriteLiteral(@"              }
                });
            });
        });
        $(""#search"").on(""keyup"", function () {
            var search = $(this).val();
            $.ajax({
                type: ""GET"",
                url: '/admin/lookup/SearchMasterLookup',
                data: { searchQuery: search },
                success: function (data) {
                    $(""#lookupList"").empty();
                    $(""#lookupList"").append(data);
                },
                error: function () {
                    alert(""Content load failed."");
                }
            });
        });


        function getFloors() {
            debugger
            var url = '");
                EndContext();
                BeginContext(15111, 17, false);
#line 357 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\Lookup\Index.cshtml"
                  Write(Url.Content("~/"));

#line default
#line hidden
                EndContext();
                BeginContext(15128, 2115, true);
                WriteLiteral(@"' + ""Admin/Lookup/GetFloor"";
            var ddlsource = ""#BuildingsList"";
            console.log($(ddlsource).children(""option:selected"").val());
            debugger
            $.getJSON(url, { BuildingID: $(ddlsource).children(""option:selected"").val() }, function (data) {
                debugger
                $(""#ParentId"").prop(""disabled"", false);
                var items = '';
                debugger
                $('#ParentId').empty();
                debugger
                $.each(data, function (i, floor) {
                    items += ""<option value='"" + floor.value + ""'>"" + floor.text + ""</option>"";
                });
                $('#ParentId').html(items);
            });
        }

        $(document).on(""keyup"", "".detailsearch"", function(){
            debugger
            var searchString = $(this).val();
            //var lookupName = $(this).closest('div').find('a').attr('data-info');
            var lookupName = $(this).attr('data-info');
            var");
                WriteLiteral(@" element = $(this);
            debugger
            $.ajax({
                type: ""GET"",
                url: '/admin/lookup/SearchLookupDetails',
                data: { searchString: searchString, lookupName: lookupName },
                success: function (data) {
                $(""#lookupDetailList"").empty();
                $(""#lookupDetailList"").append(data);
                },
                error: function () {
                    alert(""Content load failed."");
                }
            });
        });

        $(document).on(""click"", ""#closeModal"", function () {
            debugger
             $('#addMasterModal').modal('hide');
             $('#addModal').modal('hide');
        });
        function CustomRemoteValidations() {
            var Type = $(""#Type"").val();
            $.ajax({
                type: ""GET"",
                url: '/admin/lookup/customvalidation',
                data: { type: type },
                success: function (data) {


         ");
                WriteLiteral("       }\r\n\r\n\r\n\r\n            });\r\n\r\n\r\n\r\n\r\n        }\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Data.Models.Lookup>> Html { get; private set; }
    }
}
#pragma warning restore 1591