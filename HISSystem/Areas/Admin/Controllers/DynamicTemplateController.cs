using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Models;
using GeneticSystem.Areas.Admin.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Service.UnitOfServices;

namespace GeneticSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DynamicTemplateController : Controller
    {
        public const int PageSize = 50;
        private readonly IHostingEnvironment _appEnvironment;
        private readonly IUnitOfService db;

        public DynamicTemplateController(IUnitOfService db, IHostingEnvironment _appEnvironment)
        {
            this.db = db;
            this._appEnvironment = _appEnvironment;
        }
        public IActionResult Index()
        {
                var templateList = db.DynamicTemplateService.GetAllTemplates().ToList();
                ViewBag.Templates = templateList.Select(x => x.TemplateType?.Name + ">>" + x.SubTemplateType.Name ?? "");
                List<Template> templates = new List<Template>();
                return View(templates);
        }
        [HttpGet]
        public IActionResult AddTemplate()
        {
            AddDynamicTemplate dynamicTemplate = new AddDynamicTemplate();
            var LookupList = db.LookupService.GetLookups();
            ViewBag.TemplateType = LookupList.Where(x => x.Type == "TemplateType");
            ViewBag.SubTemplateType = LookupList.Where(x => x.Type == "SubTemplateType");
            ViewBag.TemplateField = LookupList.Where(x => x.Type == "TemplateField");
            return PartialView("_AddTemplate", dynamicTemplate);
        }

        [HttpPost]
        public IActionResult AddTemplate(AddDynamicTemplate dynamicTemplate)
        {
            Template template = new Template
            {
                CreatedOn = DateTime.UtcNow,
                UpdatedBy = 1,
                AddedBy = 1,
                TemplateTypeID = dynamicTemplate.Template.TemplateTypeID,
                SubTemplateTypeID = dynamicTemplate.Template.SubTemplateTypeID,
                IsActive = true,
                TemplateColumns = dynamicTemplate.TemplateColumns
            };

            var result = db.DynamicTemplateService.AddTemplate(template);
            var templateId = result.ID;


            AddDynamicTemplate passDynamicTemplate = new AddDynamicTemplate();
            passDynamicTemplate.Template = db.DynamicTemplateService.GetTemplateByID(templateId);
            ViewBag.TemplateID = templateId;

            ViewBag.EffectedGene = db.LookupService.GetLookUpByTypeName("Gene");
            ViewBag.Element = db.LookupService.GetLookUpByTypeName("Element");
            ViewBag.ConsumptionType = db.LookupService.GetLookUpByTypeName("ConsumptionType");
            ViewBag.FeederType = db.LookupService.GetLookUpByTypeName("FeederType");
            ViewBag.Result = new List<SelectListItem>
            {
              new SelectListItem{ Text="High", Value = "1" },
              new SelectListItem{ Text="Medium", Value = "2" },
              new SelectListItem{ Text="Low", Value = "3" }
            };

            return PartialView("_AddTemplateData", passDynamicTemplate);
        }

        [HttpGet]
        public IActionResult UpdateTemplate(int ID)
        {
            AddDynamicTemplate dynamicTemplate = new AddDynamicTemplate();

            ViewBag.TemplateType = db.LookupService.GetLookUpByTypeName("TemplateType");
            ViewBag.SubTemplateType = db.LookupService.GetLookUpByTypeName("SubTemplateType");
            ViewBag.TemplateField = db.LookupService.GetLookUpByTypeName("TemplateField");
            ViewBag.TemplateID = ID;
            dynamicTemplate.Template = db.DynamicTemplateService.GetTemplateByID(ID);

            //dynamicTemplate.Template.ID = getTemplate.ID;
            //dynamicTemplate.Template.IsActive = getTemplate.IsActive;
            //dynamicTemplate.Template.SubTemplateType = getTemplate.SubTemplateType;
            //dynamicTemplate.Template.SubTemplateTypeID = getTemplate.SubTemplateTypeID;
            //dynamicTemplate.Template.TemplateColumns = getTemplate.TemplateColumns;
            //dynamicTemplate.Template.TemplateType = getTemplate.TemplateType;
            //dynamicTemplate.Template.TemplateTypeID = getTemplate.TemplateTypeID;
            //dynamicTemplate.Template.UpdatedBy = getTemplate.UpdatedBy;

            return PartialView("_UpdateTemplate", dynamicTemplate);
        }



        [HttpPost]
        public IActionResult UpdateTemplate(AddDynamicTemplate dynamicTemplate)
        {

            var newDynamicTemplate = new AddDynamicTemplate();
            newDynamicTemplate = dynamicTemplate;
            newDynamicTemplate.Template.ID = dynamicTemplate.Template.ID;

            db.DynamicTemplateService.DeleteTemplateColumnsByID(dynamicTemplate.Template.ID);
            db.DynamicTemplateService.InsertTemplateColumn(dynamicTemplate.TemplateColumns);

            AddDynamicTemplate passDynamicTemplate = new AddDynamicTemplate();
            passDynamicTemplate.Template = db.DynamicTemplateService.GetTemplateByID(dynamicTemplate.Template.ID);
            passDynamicTemplate.TemplateDataList = db.DynamicTemplateService.GetTemplateDataID(dynamicTemplate.Template.ID);
            ViewBag.TemplateID = passDynamicTemplate.Template.ID;

            ViewBag.EffectedGene = db.LookupService.GetLookUpByTypeName("Gene");
            ViewBag.Element = db.LookupService.GetLookUpByTypeName("Element");
            ViewBag.ConsumptionType = db.LookupService.GetLookUpByTypeName("ConsumptionType");
            ViewBag.FeederType = db.LookupService.GetLookUpByTypeName("FeederType");

            ViewBag.Result = new List<SelectListItem>
            {
              new SelectListItem{ Text="High", Value = "1" },
              new SelectListItem{ Text="Medium", Value = "2" },
              new SelectListItem{ Text="Low", Value = "3" }
            };

            return PartialView("_GetTemplateDetail", passDynamicTemplate);
        }



        [HttpGet]
        public IActionResult GetDynamicTemplate(string temptype, string subtemptype)
        {
            AddDynamicTemplate dynamicTemplate = new AddDynamicTemplate();
            var LookupList = db.LookupService.GetLookups();

            dynamicTemplate.Template = db.DynamicTemplateService.GetTemplateByName(temptype, subtemptype);
            dynamicTemplate.TemplateDataList = db.DynamicTemplateService.GetTemplateDataID(dynamicTemplate.Template.ID);

            ViewBag.TemplateID = dynamicTemplate.Template.ID;

            ViewBag.TestTypes = db.LookupService.GetLookUpByTypeName("TemplateType");
            ViewBag.EffectedGene = db.LookupService.GetLookUpByTypeName("Gene");
            ViewBag.Element = db.LookupService.GetLookUpByTypeName("Element");
            ViewBag.ConsumptionType = db.LookupService.GetLookUpByTypeName("ConsumptionType");
            ViewBag.FeederType = db.LookupService.GetLookUpByTypeName("FeederType");

            ViewBag.Result = new List<SelectListItem>
            {
              new SelectListItem{ Text="High", Value = "1" },
              new SelectListItem{ Text="Medium", Value = "2" },
              new SelectListItem{ Text="Low", Value = "3" }
            };

            return PartialView("_GetTemplateDetail", dynamicTemplate);
        }

        [HttpGet]
        public IActionResult AddTemplateData(int templateId)
        {
            AddDynamicTemplate dynamicTemplate = new AddDynamicTemplate();
            var LookupList = db.LookupService.GetLookups();
            dynamicTemplate.Template = db.DynamicTemplateService.GetTemplateByID(templateId);

            ViewBag.TemplateID = dynamicTemplate.Template.ID;

            ViewBag.EffectedGene = db.LookupService.GetLookUpByTypeName("Gene");
            ViewBag.Element = db.LookupService.GetLookUpByTypeName("Element");
            ViewBag.ConsumptionType = db.LookupService.GetLookUpByTypeName("ConsumptionType");
            ViewBag.FeederType = db.LookupService.GetLookUpByTypeName("FeederType");

            ViewBag.Result = new List<SelectListItem>
            {
              new SelectListItem{ Text="High", Value = "1" },
              new SelectListItem{ Text="Medium", Value = "2" },
              new SelectListItem{ Text="Low", Value = "3" }
            };

            return PartialView("_AddTemplateData", dynamicTemplate);
        }

        //[HttpPost]
        //public bool AddTemplateDetail(AddDynamicTemplate dynamicTemplate)
        //{
        //    TemplateData templateData = dynamicTemplate.TemplateData;

        //    if (templateData.Genes != null)
        //    templateData.GeneID = string.Join(',', dynamicTemplate.TemplateData.Genes);
        //    templateData.IsActive = true;
        //    templateData.AddedBy = 1;
        //    templateData.UpdatedBy = 1;

        //    bool result = db.DynamicTemplateService.SaveTemplateData(templateData);

        //    return result;
        //}
        [HttpPost]
        public bool AddTemplateDetail(AddDynamicTemplate dynamicTemplate)
        {
            try
            {

            
            TemplateData templateData = dynamicTemplate.TemplateData;

            if (templateData.Genes != null)
            templateData.GeneID = string.Join(',', dynamicTemplate.TemplateData.Genes);
            templateData.IsActive = true;
            templateData.AddedBy = 1;
            templateData.UpdatedBy = 1;

            var result = db.DynamicTemplateService.SaveTemplateData(templateData);

                //AddDynamicTemplate passDynamicTemplate = new AddDynamicTemplate();
                //passDynamicTemplate.Template = db.DynamicTemplateService.GetTemplateByID(dynamicTemplate.TemplateData.TemplateID);
                //passDynamicTemplate.TemplateDataList = db.DynamicTemplateService.GetTemplateDataID(passDynamicTemplate.Template.ID);
                //ViewBag.TemplateID = passDynamicTemplate.Template.ID;

                //ViewBag.EffectedGene = db.LookupService.GetLookUpByTypeName("Gene");
                //ViewBag.Element = db.LookupService.GetLookUpByTypeName("Element");
                //ViewBag.ConsumptionType = db.LookupService.GetLookUpByTypeName("ConsumptionType");
                //ViewBag.FeederType = db.LookupService.GetLookUpByTypeName("FeederType");

                //ViewBag.Result = new List<SelectListItem>
                //{
                //  new SelectListItem{ Text="High", Value = "1" },
                //  new SelectListItem{ Text="Medium", Value = "2" },
                //  new SelectListItem{ Text="Low", Value = "3" }
                //};

                //dynamicTemplate.Template = db.DynamicTemplateService.GetTemplateByName("General", "Epilepsy");
                //dynamicTemplate.TemplateDataList = db.DynamicTemplateService.GetTemplateDataID(dynamicTemplate.Template.ID);

                //ViewBag.TemplateID = dynamicTemplate.Template.ID;

                //ViewBag.TestTypes = db.LookupService.GetLookUpByTypeName("TemplateType");
                //ViewBag.EffectedGene = db.LookupService.GetLookUpByTypeName("Gene");
                //ViewBag.Element = db.LookupService.GetLookUpByTypeName("Element");
                //ViewBag.ConsumptionType = db.LookupService.GetLookUpByTypeName("ConsumptionType");
                //ViewBag.FeederType = db.LookupService.GetLookUpByTypeName("FeederType");

                //ViewBag.Result = new List<SelectListItem>
                //{
                //  new SelectListItem{ Text="High", Value = "1" },
                //  new SelectListItem{ Text="Medium", Value = "2" },
                //  new SelectListItem{ Text="Low", Value = "3" }
                //};

                //return PartialView("_GetTemplateDetail", dynamicTemplate);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }



        [HttpPost]
        public bool UpdateTemplateData(AddDynamicTemplate dynamicTemplate)
        {
            TemplateData templateData = dynamicTemplate.TemplateData;

            if (templateData.Genes != null)
                templateData.GeneID = string.Join(',', dynamicTemplate.TemplateData.Genes);

            templateData.IsActive = true;
            templateData.AddedBy = 1;
            templateData.UpdatedBy = 1;

            bool result = db.DynamicTemplateService.UpdateTemplateData(templateData);

            return result;
        }

        [HttpGet]
        public bool DeleteTemplateData(int id)
        {
            bool result = db.DynamicTemplateService.RemoveTemplateDataByID(id);
            return result;
        }

        [HttpGet]
        public IActionResult SearchTemplate(string searchQuery)
        {
            if (searchQuery != null)
            {
                var templateList = db.DynamicTemplateService.SearchTemplate(searchQuery).ToList();
                ViewBag.Templates = templateList.Select(x => x.TemplateType?.Name + ">>" + x.SubTemplateType.Name ?? "");
                List<Template> templates = new List<Template>();
                return View("_SearchMasterTemplate", templates);
            }
            else
            {
                var templateList = db.DynamicTemplateService.GetAllTemplates().ToList();
                ViewBag.Templates = templateList.Select(x => x.TemplateType?.Name + ">>" + x.SubTemplateType.Name ?? "");
                List<Template> templates = new List<Template>();
                return View(templates);
            }
        }
    }
}