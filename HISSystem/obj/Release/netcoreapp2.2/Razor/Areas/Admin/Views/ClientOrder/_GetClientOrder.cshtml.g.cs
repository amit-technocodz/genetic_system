#pragma checksum "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35d3156fdb484904656a08521f9766440ee9d49a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ClientOrder__GetClientOrder), @"mvc.1.0.view", @"/Areas/Admin/Views/ClientOrder/_GetClientOrder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/ClientOrder/_GetClientOrder.cshtml", typeof(AspNetCore.Areas_Admin_Views_ClientOrder__GetClientOrder))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35d3156fdb484904656a08521f9766440ee9d49a", @"/Areas/Admin/Views/ClientOrder/_GetClientOrder.cshtml")]
    public class Areas_Admin_Views_ClientOrder__GetClientOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GeneticSystem.Areas.Admin.Models.ClientOrderViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(62, 40, true);
            WriteLiteral("\r\n<div class=\"tab-content pad-all-sm\">\r\n");
            EndContext();
#line 4 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
     foreach (var subTemplate in Model.TemplateList.Select((value, i) => new { i, value }))
    {

#line default
#line hidden
            BeginContext(202, 12, true);
            WriteLiteral("        <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 214, "\"", 239, 3);
            WriteAttributeValue("", 219, "tab-(", 219, 5, true);
#line 6 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 224, subTemplate.i, 224, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 238, ")", 238, 1, true);
            EndWriteAttribute();
            BeginContext(240, 114, true);
            WriteLiteral(" class=\"tab-pane fade in active\">\r\n            <div class=\"row\">\r\n                <div class=\"panel-group panel-2\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 354, "\"", 386, 3);
            WriteAttributeValue("", 359, "bs-collapse(", 359, 12, true);
#line 8 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 371, subTemplate.i, 371, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 385, ")", 385, 1, true);
            EndWriteAttribute();
            BeginContext(387, 231, true);
            WriteLiteral(">\r\n                    <div class=\"panel\">\r\n                        <div class=\"panel-heading\">\r\n                            <h4 class=\"panel-title\">\r\n                                <a data-toggle=\"collapse\" data-info=\"Department\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 618, "\"", 644, 2);
            WriteAttributeValue("", 625, "#one-", 625, 5, true);
#line 12 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 630, subTemplate.i, 630, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(645, 39, true);
            WriteLiteral(">\r\n                                    ");
            EndContext();
            BeginContext(685, 38, false);
#line 13 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                               Write(subTemplate.value.SubTemplateType.Name);

#line default
#line hidden
            EndContext();
            BeginContext(723, 135, true);
            WriteLiteral("\r\n                                </a>\r\n                            </h4>\r\n                        </div>\r\n                        <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 858, "\"", 881, 2);
            WriteAttributeValue("", 863, "one-", 863, 4, true);
#line 17 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 867, subTemplate.i, 867, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(882, 581, true);
            WriteLiteral(@" class=""panel-collapse collapse"">
                            <div class=""panel-body"">
                                <div class=""row"">
                                    <div class=""col-md-12"">
                                        <div class=""table-responsive"">
                                            <div>
                                                <table id=""userTbl"" class=""table table-hover table-bordered table-striped"">
                                                    <thead>
                                                        <tr class="""">
");
            EndContext();
#line 26 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                             foreach (var record in subTemplate.value.TemplateColumns)
                                                            {

#line default
#line hidden
            BeginContext(1646, 69, true);
            WriteLiteral("                                                                <th> ");
            EndContext();
            BeginContext(1716, 18, false);
#line 28 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                Write(record.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(1734, 8, true);
            WriteLiteral(" </th>\r\n");
            EndContext();
#line 29 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                            }

#line default
#line hidden
            BeginContext(1805, 186, true);
            WriteLiteral("                                                        </tr>\r\n                                                    </thead>\r\n                                                    <tbody>\r\n");
            EndContext();
#line 33 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                         foreach (var itemData in Model.ClientOrderData.Select((data, index) => new { index, data }))
                                                        {

#line default
#line hidden
            BeginContext(2201, 240, true);
            WriteLiteral("                                                            <tr data-info=\"somerandom\">\r\n                                                                <td hidden>\r\n                                                                    <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 2441, "\"", 2503, 3);
            WriteAttributeValue("", 2448, "clientOrder.ClientOrderData[", 2448, 28, true);
#line 37 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 2476, itemData.index, 2476, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2491, "].TemplateID", 2491, 12, true);
            EndWriteAttribute();
            BeginContext(2504, 34, true);
            WriteLiteral(" class=\"form-control itemDatadsbl\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2538, "\"", 2595, 1);
#line 37 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 2546, Model.ClientOrderData[itemData.index].TemplateID, 2546, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2596, 84, true);
            WriteLiteral(" hidden>\r\n                                                                    <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 2680, "\"", 2740, 3);
            WriteAttributeValue("", 2687, "clientOrder.ClientOrderData[", 2687, 28, true);
#line 38 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 2715, itemData.index, 2715, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2730, "].IsActive", 2730, 10, true);
            EndWriteAttribute();
            BeginContext(2741, 131, true);
            WriteLiteral(" class=\"form-control itemDatadsbl\" value=\"true\" hidden>\r\n                                                                    <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 2872, "\"", 2931, 3);
            WriteAttributeValue("", 2879, "clientOrder.ClientOrderData[", 2879, 28, true);
#line 39 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 2907, itemData.index, 2907, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2922, "].AddedBy", 2922, 9, true);
            EndWriteAttribute();
            BeginContext(2932, 128, true);
            WriteLiteral(" class=\"form-control itemDatadsbl\" value=\"1\" hidden>\r\n                                                                    <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 3060, "\"", 3121, 3);
            WriteAttributeValue("", 3067, "clientOrder.ClientOrderData[", 3067, 28, true);
#line 40 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 3095, itemData.index, 3095, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 3110, "].UpdatedBy", 3110, 11, true);
            EndWriteAttribute();
            BeginContext(3122, 127, true);
            WriteLiteral(" class=\"form-control itemDatadsbl\" value=\"1\" hidden>\r\n                                                                </td>\r\n\r\n");
            EndContext();
#line 43 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                 if (Model.ClientOrderData.Count > 0)
                                                                {
                                                                    

#line default
#line hidden
#line 45 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                     foreach (var column in subTemplate.value.TemplateColumns.Select((column, p) => new { p, column }))
                                                                    {
                                                                        

#line default
#line hidden
#line 47 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                         if (itemData.data.TemplateID == subTemplate.value.ID)
                                                                        {

#line default
#line hidden
            BeginContext(3862, 128, true);
            WriteLiteral("                                                                            <td class=\"\" @*data-info=\"@itemData.value.ID\"*@>\r\n\r\n");
            EndContext();
#line 51 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                                 if (column.column.TemplateField.Name == "EffectedGene")
                                                                                {
                                                                                    

#line default
#line hidden
            BeginContext(4296, 262, false);
#line 53 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                               Write(Html.ListBox("clientOrder.ClientOrderData[" + itemData.index + "].Genes", new MultiSelectList(ViewBag.EffectedGene, "ID", "Name", Model.ClientOrderData[itemData.index].Genes), htmlAttributes: new { @class = "tryMultiselect form-control", multiple = "multiple" }));

#line default
#line hidden
            EndContext();
#line 53 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                                                                                                                                                                                                                                                                                                           
                                                                                }
                                                                                else if (column.column.TemplateField.Name == "ConsumptionType")
                                                                                {
                                                                                    

#line default
#line hidden
            BeginContext(4956, 285, false);
#line 57 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                               Write(Html.DropDownList("clientOrder.ClientOrderData[" + itemData.index + "].ConsumptionTypeID", new SelectList(ViewBag.ConsumptionType, "ID", "Name", @Model.ClientOrderData[itemData.index].ConsumptionTypeID), "Select Consumption Type", new { @class = "form-control dropdown itemDatadsbl" }));

#line default
#line hidden
            EndContext();
#line 57 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                  
                                                                                }
                                                                                else if (column.column.TemplateField.Name == "Element")
                                                                                {
                                                                                    

#line default
#line hidden
            BeginContext(5631, 257, false);
#line 61 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                               Write(Html.DropDownList("clientOrder.ClientOrderData[" + itemData.index + "].ElementID", new SelectList(ViewBag.Element, "ID", "Name", @Model.ClientOrderData[itemData.index].ElementID), "Select Element Type", new { @class = "form-control dropdown itemDatadsbl" }));

#line default
#line hidden
            EndContext();
#line 61 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                                                                                                                                                                                                                                                                                                      
                                                                                }
                                                                                else if (column.column.TemplateField.Name == "Result")
                                                                                {
                                                                                    

#line default
#line hidden
            BeginContext(6277, 252, false);
#line 65 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                               Write(Html.DropDownList("clientOrder.ClientOrderData[" + itemData.index + "].Result", new SelectList(ViewBag.Result, "Value", "Text", @Model.ClientOrderData[itemData.index].Result), "Select Result Type", new { @class = "form-control dropdown itemDatadsbl" }));

#line default
#line hidden
            EndContext();
#line 65 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                                                                                                                                                                                                                                                                                                 
                                                                                }
                                                                                else if (column.column.TemplateField.Name == "HaveMutationEffected")
                                                                                {

#line default
#line hidden
            BeginContext(6847, 121, true);
            WriteLiteral("                                                                                    <div class=\"form-check\"><label><input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 6968, "\"", 7040, 3);
            WriteAttributeValue("", 6975, "clientOrder.ClientOrderData[", 6975, 28, true);
#line 69 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 7003, itemData.index, 7003, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 7018, "].HaveMutationEffected", 7018, 22, true);
            EndWriteAttribute();
            BeginContext(7041, 37, true);
            WriteLiteral(" type=\"checkbox\" class=\"itemDatadsbl\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 7078, "\"", 7145, 1);
#line 69 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 7086, Model.ClientOrderData[itemData.index].HaveMutationEffected, 7086, 59, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7146, 71, true);
            WriteLiteral("><span class=\"label-text\">Have Mutation Effected</span></label></div>\r\n");
            EndContext();
#line 70 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                                }
                                                                                else if (column.column.TemplateField.Name == "EffectedGood")
                                                                                {

#line default
#line hidden
            BeginContext(7525, 90, true);
            WriteLiteral("                                                                                    <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 7615, "\"", 7679, 3);
            WriteAttributeValue("", 7622, "clientOrder.ClientOrderData[", 7622, 28, true);
#line 73 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 7650, itemData.index, 7650, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 7665, "].EffectedGood", 7665, 14, true);
            EndWriteAttribute();
            BeginContext(7680, 34, true);
            WriteLiteral(" class=\"form-control itemDatadsbl\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 7714, "\"", 7773, 1);
#line 73 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 7722, Model.ClientOrderData[itemData.index].EffectedGood, 7722, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7774, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 74 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                                }
                                                                                else if (column.column.TemplateField.Name == "EffectedBad")
                                                                                {

#line default
#line hidden
            BeginContext(8084, 90, true);
            WriteLiteral("                                                                                    <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 8174, "\"", 8237, 3);
            WriteAttributeValue("", 8181, "clientOrder.ClientOrderData[", 8181, 28, true);
#line 77 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 8209, itemData.index, 8209, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 8224, "].EffectedBad", 8224, 13, true);
            EndWriteAttribute();
            BeginContext(8238, 34, true);
            WriteLiteral(" class=\"form-control itemDatadsbl\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 8272, "\"", 8330, 1);
#line 77 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 8280, Model.ClientOrderData[itemData.index].EffectedBad, 8280, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8331, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 78 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                                }
                                                                                else if (column.column.TemplateField.Name == "GeneticMutation")
                                                                                {

#line default
#line hidden
            BeginContext(8645, 90, true);
            WriteLiteral("                                                                                    <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 8735, "\"", 8802, 3);
            WriteAttributeValue("", 8742, "clientOrder.ClientOrderData[", 8742, 28, true);
#line 81 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 8770, itemData.index, 8770, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 8785, "].GeneticMutation", 8785, 17, true);
            EndWriteAttribute();
            BeginContext(8803, 34, true);
            WriteLiteral(" class=\"form-control itemDatadsbl\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 8837, "\"", 8899, 1);
#line 81 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 8845, Model.ClientOrderData[itemData.index].GeneticMutation, 8845, 54, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8900, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 82 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                                }
                                                                                else if (column.column.TemplateField.Name == "PersonalRiskFactor")
                                                                                {

#line default
#line hidden
            BeginContext(9217, 90, true);
            WriteLiteral("                                                                                    <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 9307, "\"", 9377, 3);
            WriteAttributeValue("", 9314, "clientOrder.ClientOrderData[", 9314, 28, true);
#line 85 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 9342, itemData.index, 9342, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 9357, "].PersonalRiskFactor", 9357, 20, true);
            EndWriteAttribute();
            BeginContext(9378, 34, true);
            WriteLiteral(" class=\"form-control itemDatadsbl\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 9412, "\"", 9477, 1);
#line 85 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 9420, Model.ClientOrderData[itemData.index].PersonalRiskFactor, 9420, 57, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9478, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 86 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                                }
                                                                                else if (column.column.TemplateField.Name == "Hereditary")
                                                                                {

#line default
#line hidden
            BeginContext(9787, 90, true);
            WriteLiteral("                                                                                    <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 9877, "\"", 9939, 3);
            WriteAttributeValue("", 9884, "clientOrder.ClientOrderData[", 9884, 28, true);
#line 89 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 9912, itemData.index, 9912, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 9927, "].Hereditary", 9927, 12, true);
            EndWriteAttribute();
            BeginContext(9940, 34, true);
            WriteLiteral(" class=\"form-control itemDatadsbl\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 9974, "\"", 10031, 1);
#line 89 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 9982, Model.ClientOrderData[itemData.index].Hereditary, 9982, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(10032, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 90 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                                }
                                                                                else if (column.column.TemplateField.Name == "ResultSummary")
                                                                                {

#line default
#line hidden
            BeginContext(10344, 90, true);
            WriteLiteral("                                                                                    <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 10434, "\"", 10499, 3);
            WriteAttributeValue("", 10441, "clientOrder.ClientOrderData[", 10441, 28, true);
#line 93 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 10469, itemData.index, 10469, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 10484, "].ResultSummary", 10484, 15, true);
            EndWriteAttribute();
            BeginContext(10500, 34, true);
            WriteLiteral(" class=\"form-control itemDatadsbl\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 10534, "\"", 10594, 1);
#line 93 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 10542, Model.ClientOrderData[itemData.index].ResultSummary, 10542, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(10595, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 94 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                                }
                                                                                else if (column.column.TemplateField.Name == "Recommendations")
                                                                                {

#line default
#line hidden
            BeginContext(10909, 90, true);
            WriteLiteral("                                                                                    <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 10999, "\"", 11065, 3);
            WriteAttributeValue("", 11006, "clientOrder.ClientOrderData[", 11006, 28, true);
#line 97 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 11034, itemData.index, 11034, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 11049, "].Recommendation", 11049, 16, true);
            EndWriteAttribute();
            BeginContext(11066, 34, true);
            WriteLiteral(" class=\"form-control itemDatadsbl\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 11100, "\"", 11161, 1);
#line 97 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 11108, Model.ClientOrderData[itemData.index].Recommendation, 11108, 53, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(11162, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 98 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                                }

#line default
#line hidden
            BeginContext(11248, 83, true);
            WriteLiteral("                                                                            </td>\r\n");
            EndContext();
#line 100 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                        }

#line default
#line hidden
#line 100 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                         
                                                                    }

#line default
#line hidden
#line 101 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                     
                                                                }

#line default
#line hidden
            BeginContext(11544, 67, true);
            WriteLiteral("                                                            </tr>\r\n");
            EndContext();
#line 104 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                        }

#line default
#line hidden
            BeginContext(11670, 460, true);
            WriteLiteral(@"                                                    </tbody>
                                                </table>
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
#line 117 "E:\GeneticGit\GeneticGit\genetic_system\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
    }

#line default
#line hidden
            BeginContext(12137, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GeneticSystem.Areas.Admin.Models.ClientOrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
