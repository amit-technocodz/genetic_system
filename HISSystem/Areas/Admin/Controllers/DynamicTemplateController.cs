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
            ViewBag.Templates = templateList.Select(x => x.TemplateType?.Name + ">>" + x.SubTemplateType.Name?? ""); 
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
        public bool AddTemplate(AddDynamicTemplate dynamicTemplate)
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
            bool result = db.DynamicTemplateService.AddTemplate(template);
            return result;
        }

        [HttpGet]
        public IActionResult GetDynamicTemplate(string temptype, string subtemptype)
        {
            AddDynamicTemplate dynamicTemplate = new AddDynamicTemplate();
            var LookupList = db.LookupService.GetLookups();
            dynamicTemplate.Template = new Template();
            dynamicTemplate.Template = db.DynamicTemplateService.GetTemplateByName(temptype, subtemptype);
            dynamicTemplate.TemplateDataList = db.DynamicTemplateService.GetTemplateDataID(dynamicTemplate.Template.ID);
            ViewBag.TemplateID = dynamicTemplate.Template.ID;
            ViewBag.TemplateID = dynamicTemplate.Template.ID;
            ViewBag.EffectedGene = LookupList.Where(x => x.Type == "Gene");
            ViewBag.Element = LookupList.Where(x => x.Type == "Element");
            ViewBag.ConsumptionType = LookupList.Where(x => x.Type == "ConsumptionType");
            ViewBag.FeederType = LookupList.Where(x => x.Type == "FeederType");
            ViewBag.TestTypes = LookupList.Where(x => x.Type == "TemplateType");
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
            dynamicTemplate.Template = new Template();
            dynamicTemplate.Template = db.DynamicTemplateService.GetTemplateByID(templateId);

            ViewBag.TemplateID = dynamicTemplate.Template.ID;
            ViewBag.EffectedGene = LookupList.Where(x => x.Type == "Gene");
            ViewBag.Element = LookupList.Where(x => x.Type == "Element");
            ViewBag.ConsumptionType = LookupList.Where(x => x.Type == "ConsumptionType");
            ViewBag.FeederType = LookupList.Where(x => x.Type == "FeederType");
            ViewBag.Result = new List<SelectListItem>
            {
              new SelectListItem{ Text="High", Value = "1" },
              new SelectListItem{ Text="Medium", Value = "2" },
              new SelectListItem{ Text="Low", Value = "3" }
            };

            return PartialView("_AddTemplateData", dynamicTemplate);
        }

        [HttpPost]
        public bool AddTemplateDetail(AddDynamicTemplate dynamicTemplate)
        {
            TemplateData templateData = dynamicTemplate.TemplateData;

            if (templateData.Genes != null)
            templateData.GeneID = string.Join(',', dynamicTemplate.TemplateData.Genes);
            templateData.IsActive = true;
            templateData.AddedBy = 1;
            templateData.UpdatedBy = 1;

            bool result = db.DynamicTemplateService.SaveTemplateData(templateData);

            return result;
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

    }
}