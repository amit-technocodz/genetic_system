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
    public class TestTempController : Controller
    {
        public const int PageSize = 50;
        private readonly IHostingEnvironment _appEnvironment;
        private readonly IUnitOfService db;

        public TestTempController(IUnitOfService db, IHostingEnvironment _appEnvironment)
        {
            this.db = db;
            this._appEnvironment = _appEnvironment;
        }

        public IActionResult Index()
        {
            ViewBag.Templates = db.LookupService.GetLookUpByTypeName("TestTempType");
            List <TestTemp> testTemps = new List<TestTemp>();
            return View(testTemps);
        }

        [HttpGet]
        public IActionResult AddTemplate()
        {
            TestTempVM testTempVM = new TestTempVM();

            ViewBag.TemplateType = db.LookupService.GetLookUpByTypeName("TestTempType");
            ViewBag.SubTemplateType = db.LookupService.GetLookUpByTypeName("SubTestTempType");
            ViewBag.DropDownTypes = db.LookupService.GetLookUpByTypeName("DropDownType");

            ViewBag.TemplateField = new List<SelectListItem>
            {
              new SelectListItem{ Text="Checkbox", Value = "1" },
              new SelectListItem{ Text="Dropdown", Value = "2" },
              new SelectListItem{ Text="Textbox", Value = "3" }
            };

            return PartialView("_AddMasterTemp", testTempVM);
        }
    }
}