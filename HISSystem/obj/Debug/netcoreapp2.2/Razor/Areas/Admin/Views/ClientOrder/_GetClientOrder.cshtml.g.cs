#pragma checksum "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "973b94341a872db73243278f956e4f563bb7a95a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"973b94341a872db73243278f956e4f563bb7a95a", @"/Areas/Admin/Views/ClientOrder/_GetClientOrder.cshtml")]
    public class Areas_Admin_Views_ClientOrder__GetClientOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GeneticSystem.Areas.Admin.Models.ClientOrderViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(62, 40, true);
            WriteLiteral("\r\n<div class=\"tab-content pad-all-sm\">\r\n");
            EndContext();
#line 4 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
     foreach (var subTemplate in Model.TemplateList.Select((value, i) => new { i, value }))
    {

#line default
#line hidden
            BeginContext(202, 12, true);
            WriteLiteral("        <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 214, "\"", 239, 3);
            WriteAttributeValue("", 219, "tab-(", 219, 5, true);
#line 6 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
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
#line 8 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
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
#line 12 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 630, subTemplate.i, 630, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(645, 39, true);
            WriteLiteral(">\r\n                                    ");
            EndContext();
            BeginContext(685, 38, false);
#line 13 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                               Write(subTemplate.value.SubTemplateType.Name);

#line default
#line hidden
            EndContext();
            BeginContext(723, 135, true);
            WriteLiteral("\r\n                                </a>\r\n                            </h4>\r\n                        </div>\r\n                        <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 858, "\"", 881, 2);
            WriteAttributeValue("", 863, "one-", 863, 4, true);
#line 17 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
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
#line 26 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                             foreach (var record in subTemplate.value.TemplateColumns)
                                                            {

#line default
#line hidden
            BeginContext(1646, 69, true);
            WriteLiteral("                                                                <th> ");
            EndContext();
            BeginContext(1716, 18, false);
#line 28 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                Write(record.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(1734, 8, true);
            WriteLiteral(" </th>\r\n");
            EndContext();
#line 29 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                            }

#line default
#line hidden
            BeginContext(1805, 186, true);
            WriteLiteral("                                                        </tr>\r\n                                                    </thead>\r\n                                                    <tbody>\r\n");
            EndContext();
#line 33 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                         foreach (var itemData in Model.ClientOrderData.Select((data, index) => new { index, data }))
                                                        {

#line default
#line hidden
            BeginContext(2201, 240, true);
            WriteLiteral("                                                            <tr data-info=\"somerandom\">\r\n                                                                <td hidden>\r\n                                                                    <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 2441, "\"", 2503, 3);
            WriteAttributeValue("", 2448, "clientOrder.ClientOrderData[", 2448, 28, true);
#line 37 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 2476, itemData.index, 2476, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2491, "].TemplateID", 2491, 12, true);
            EndWriteAttribute();
            BeginContext(2504, 34, true);
            WriteLiteral(" class=\"form-control itemDatadsbl\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2538, "\"", 2595, 1);
#line 37 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 2546, Model.ClientOrderData[itemData.index].TemplateID, 2546, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2596, 84, true);
            WriteLiteral(" hidden>\r\n                                                                    <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 2680, "\"", 2740, 3);
            WriteAttributeValue("", 2687, "clientOrder.ClientOrderData[", 2687, 28, true);
#line 38 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
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
#line 39 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
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
#line 40 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 3095, itemData.index, 3095, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 3110, "].UpdatedBy", 3110, 11, true);
            EndWriteAttribute();
            BeginContext(3122, 127, true);
            WriteLiteral(" class=\"form-control itemDatadsbl\" value=\"1\" hidden>\r\n                                                                </td>\r\n\r\n");
            EndContext();
#line 43 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                 if (Model.TemplateDataList.Count > 0)
                                                                {
                                                                    

#line default
#line hidden
#line 45 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                     foreach (var column in subTemplate.value.TemplateColumns.Select((column, p) => new { p, column }))
                                                                    {
                                                                        

#line default
#line hidden
#line 47 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                         if (itemData.data.TemplateID == subTemplate.value.ID)
                                                                        {

#line default
#line hidden
            BeginContext(3863, 128, true);
            WriteLiteral("                                                                            <td class=\"\" @*data-info=\"@itemData.value.ID\"*@>\r\n\r\n");
            EndContext();
#line 51 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                                 if (column.column.TemplateField.Name == "EffectedGene")
                                                                                {
                                                                                    

#line default
#line hidden
            BeginContext(4297, 262, false);
#line 53 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                               Write(Html.ListBox("clientOrder.ClientOrderData[" + itemData.index + "].Genes", new MultiSelectList(ViewBag.EffectedGene, "ID", "Name", Model.ClientOrderData[itemData.index].Genes), htmlAttributes: new { @class = "tryMultiselect form-control", multiple = "multiple" }));

#line default
#line hidden
            EndContext();
#line 53 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                                                                                                                                                                                                                                                                                                           
                                                                                }
                                                                                else if (column.column.TemplateField.Name == "ConsumptionType")
                                                                                {
                                                                                    

#line default
#line hidden
            BeginContext(4957, 285, false);
#line 57 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                               Write(Html.DropDownList("clientOrder.ClientOrderData[" + itemData.index + "].ConsumptionTypeID", new SelectList(ViewBag.ConsumptionType, "ID", "Name", @Model.ClientOrderData[itemData.index].ConsumptionTypeID), "Select Consumption Type", new { @class = "form-control dropdown itemDatadsbl" }));

#line default
#line hidden
            EndContext();
#line 57 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                  
                                                                                }
                                                                                else if (column.column.TemplateField.Name == "Element")
                                                                                {
                                                                                    

#line default
#line hidden
            BeginContext(5632, 257, false);
#line 61 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                               Write(Html.DropDownList("clientOrder.ClientOrderData[" + itemData.index + "].ElementID", new SelectList(ViewBag.Element, "ID", "Name", @Model.ClientOrderData[itemData.index].ElementID), "Select Element Type", new { @class = "form-control dropdown itemDatadsbl" }));

#line default
#line hidden
            EndContext();
#line 61 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                                                                                                                                                                                                                                                                                                      
                                                                                }
                                                                                else if (column.column.TemplateField.Name == "Result")
                                                                                {
                                                                                    

#line default
#line hidden
            BeginContext(6278, 252, false);
#line 65 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                               Write(Html.DropDownList("clientOrder.ClientOrderData[" + itemData.index + "].Result", new SelectList(ViewBag.Result, "Value", "Text", @Model.ClientOrderData[itemData.index].Result), "Select Result Type", new { @class = "form-control dropdown itemDatadsbl" }));

#line default
#line hidden
            EndContext();
#line 65 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                                                                                                                                                                                                                                                                                                 
                                                                                }
                                                                                else if (column.column.TemplateField.Name == "HaveMutationEffected")
                                                                                {

#line default
#line hidden
            BeginContext(6848, 121, true);
            WriteLiteral("                                                                                    <div class=\"form-check\"><label><input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 6969, "\"", 7041, 3);
            WriteAttributeValue("", 6976, "clientOrder.ClientOrderData[", 6976, 28, true);
#line 69 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 7004, itemData.index, 7004, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 7019, "].HaveMutationEffected", 7019, 22, true);
            EndWriteAttribute();
            BeginContext(7042, 37, true);
            WriteLiteral(" type=\"checkbox\" class=\"itemDatadsbl\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 7079, "\"", 7146, 1);
#line 69 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 7087, Model.ClientOrderData[itemData.index].HaveMutationEffected, 7087, 59, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7147, 71, true);
            WriteLiteral("><span class=\"label-text\">Have Mutation Effected</span></label></div>\r\n");
            EndContext();
#line 70 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                                }
                                                                                else if (column.column.TemplateField.Name == "EffectedGood")
                                                                                {

#line default
#line hidden
            BeginContext(7526, 90, true);
            WriteLiteral("                                                                                    <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 7616, "\"", 7680, 3);
            WriteAttributeValue("", 7623, "clientOrder.ClientOrderData[", 7623, 28, true);
#line 73 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 7651, itemData.index, 7651, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 7666, "].EffectedGood", 7666, 14, true);
            EndWriteAttribute();
            BeginContext(7681, 34, true);
            WriteLiteral(" class=\"form-control itemDatadsbl\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 7715, "\"", 7774, 1);
#line 73 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 7723, Model.ClientOrderData[itemData.index].EffectedGood, 7723, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7775, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 74 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                                }
                                                                                else if (column.column.TemplateField.Name == "EffectedBad")
                                                                                {

#line default
#line hidden
            BeginContext(8085, 90, true);
            WriteLiteral("                                                                                    <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 8175, "\"", 8238, 3);
            WriteAttributeValue("", 8182, "clientOrder.ClientOrderData[", 8182, 28, true);
#line 77 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 8210, itemData.index, 8210, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 8225, "].EffectedBad", 8225, 13, true);
            EndWriteAttribute();
            BeginContext(8239, 34, true);
            WriteLiteral(" class=\"form-control itemDatadsbl\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 8273, "\"", 8331, 1);
#line 77 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 8281, Model.ClientOrderData[itemData.index].EffectedBad, 8281, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8332, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 78 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                                }
                                                                                else if (column.column.TemplateField.Name == "GeneticMutation")
                                                                                {

#line default
#line hidden
            BeginContext(8646, 90, true);
            WriteLiteral("                                                                                    <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 8736, "\"", 8803, 3);
            WriteAttributeValue("", 8743, "clientOrder.ClientOrderData[", 8743, 28, true);
#line 81 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 8771, itemData.index, 8771, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 8786, "].GeneticMutation", 8786, 17, true);
            EndWriteAttribute();
            BeginContext(8804, 34, true);
            WriteLiteral(" class=\"form-control itemDatadsbl\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 8838, "\"", 8900, 1);
#line 81 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 8846, Model.ClientOrderData[itemData.index].GeneticMutation, 8846, 54, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8901, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 82 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                                }
                                                                                else if (column.column.TemplateField.Name == "PersonalRiskFactor")
                                                                                {

#line default
#line hidden
            BeginContext(9218, 90, true);
            WriteLiteral("                                                                                    <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 9308, "\"", 9378, 3);
            WriteAttributeValue("", 9315, "clientOrder.ClientOrderData[", 9315, 28, true);
#line 85 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 9343, itemData.index, 9343, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 9358, "].PersonalRiskFactor", 9358, 20, true);
            EndWriteAttribute();
            BeginContext(9379, 34, true);
            WriteLiteral(" class=\"form-control itemDatadsbl\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 9413, "\"", 9478, 1);
#line 85 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 9421, Model.ClientOrderData[itemData.index].PersonalRiskFactor, 9421, 57, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9479, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 86 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                                }
                                                                                else if (column.column.TemplateField.Name == "Hereditary")
                                                                                {

#line default
#line hidden
            BeginContext(9788, 90, true);
            WriteLiteral("                                                                                    <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 9878, "\"", 9940, 3);
            WriteAttributeValue("", 9885, "clientOrder.ClientOrderData[", 9885, 28, true);
#line 89 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 9913, itemData.index, 9913, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 9928, "].Hereditary", 9928, 12, true);
            EndWriteAttribute();
            BeginContext(9941, 34, true);
            WriteLiteral(" class=\"form-control itemDatadsbl\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 9975, "\"", 10032, 1);
#line 89 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 9983, Model.ClientOrderData[itemData.index].Hereditary, 9983, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(10033, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 90 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                                }
                                                                                else if (column.column.TemplateField.Name == "ResultSummary")
                                                                                {

#line default
#line hidden
            BeginContext(10345, 90, true);
            WriteLiteral("                                                                                    <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 10435, "\"", 10500, 3);
            WriteAttributeValue("", 10442, "clientOrder.ClientOrderData[", 10442, 28, true);
#line 93 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 10470, itemData.index, 10470, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 10485, "].ResultSummary", 10485, 15, true);
            EndWriteAttribute();
            BeginContext(10501, 34, true);
            WriteLiteral(" class=\"form-control itemDatadsbl\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 10535, "\"", 10595, 1);
#line 93 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 10543, Model.ClientOrderData[itemData.index].ResultSummary, 10543, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(10596, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 94 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                                }
                                                                                else if (column.column.TemplateField.Name == "Recommendations")
                                                                                {

#line default
#line hidden
            BeginContext(10910, 90, true);
            WriteLiteral("                                                                                    <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 11000, "\"", 11066, 3);
            WriteAttributeValue("", 11007, "clientOrder.ClientOrderData[", 11007, 28, true);
#line 97 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 11035, itemData.index, 11035, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 11050, "].Recommendation", 11050, 16, true);
            EndWriteAttribute();
            BeginContext(11067, 34, true);
            WriteLiteral(" class=\"form-control itemDatadsbl\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 11101, "\"", 11162, 1);
#line 97 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
WriteAttributeValue("", 11109, Model.ClientOrderData[itemData.index].Recommendation, 11109, 53, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(11163, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 98 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                                }

#line default
#line hidden
            BeginContext(11249, 83, true);
            WriteLiteral("                                                                            </td>\r\n");
            EndContext();
#line 100 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                        }

#line default
#line hidden
#line 100 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                         
                                                                    }

#line default
#line hidden
#line 101 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                                     
                                                                }

#line default
#line hidden
            BeginContext(11545, 67, true);
            WriteLiteral("                                                            </tr>\r\n");
            EndContext();
#line 104 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
                                                        }

#line default
#line hidden
            BeginContext(11671, 460, true);
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
#line 117 "E:\GeneticSystem Unified\GC 21.2.20 J\GeneticSystem\HISSystem\Areas\Admin\Views\ClientOrder\_GetClientOrder.cshtml"
    }

#line default
#line hidden
            BeginContext(12138, 6, true);
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