﻿using System;
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

        public  IActionResult Index()
        {
            TestTempVM testTemp = new TestTempVM();
            testTemp.DropDown = db.TestTempService.GetTestTemps().Select(x => new DropDownVM { ID = x.ID, Name = x.TestTempType.Name + ">>" + x.SubTestTempType.Name });
            return View(testTemp);
        }

        [HttpGet]
        public IActionResult AddTemplate()
        {
            TestTempVM testTempVM = new TestTempVM();

            ViewBag.TemplateType = db.LookupService.GetLookUpByTypeName("TestTempType");
            ViewBag.SubTemplateType = db.LookupService.GetLookUpByTypeName("SubTestTempType");
            ViewBag.DropDownType = db.LookupService.GetLookUpByTypeName("DropDownType");

            ViewBag.TemplateField = new List<SelectListItem>
            {
              new SelectListItem{ Text="Checkbox", Value = "1" },
              new SelectListItem{ Text="Dropdown", Value = "2" },
              new SelectListItem{ Text="Textbox", Value = "3" }
            };

            return PartialView("_AddMasterTemp", testTempVM);
        }
        [HttpPost]
        public bool AddTemplate(TestTempVM testTempVM)
        {
            try
            {
                TestTemp addtemp = testTempVM.TestTemp;
                db.TestTempService.AddTestTemp(addtemp);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        [HttpGet]
        public IActionResult GetDynamicTemplate(int tempID)
        {
            TestTempVM testTemp = new TestTempVM
            {
                TestTemp = db.TestTempService.GetTemplateById(tempID)
            };
            testTemp.TestTempDataList = db.TestTempService.GetTempDataByTempId(testTemp.TestTemp.ID).ToList();

            ViewBag.Result = new List<SelectListItem>
            {
              new SelectListItem{ Text="High", Value = "1" },
              new SelectListItem{ Text="Medium", Value = "2" },
              new SelectListItem{ Text="Low", Value = "3" }
            };
            ViewBag.EffectedGene = db.LookupService.GetLookUpByTypeName("Gene");
            ViewBag.Element = db.LookupService.GetLookUpByTypeName("Element");
            ViewBag.ConsumptionType = db.LookupService.GetLookUpByTypeName("ConsumptionType");
            ViewBag.FeederType = db.LookupService.GetLookUpByTypeName("FeederType");

            var listwithIndex = testTemp.TestTempDataList.Select((value, index) => new { index, value }).ToList();

            var TestTempDataCols = testTemp.TestTempDataList.Select(x => x.TestTempColID).Distinct().ToList();
            int tempColCount = TestTempDataCols.Count();
            testTemp.expData = new List<TestTempData>[testTemp.TestTempDataList.Count() / tempColCount];
            for (int i = 0; i < testTemp.TestTempDataList.Count()/ tempColCount; i++){
                
                testTemp.expData[i] = listwithIndex.Where(x => (x.index >= (i * tempColCount) && x.index < ((i + 1) * tempColCount))).Select(x => x.value).ToList();
            }

            Console.WriteLine(testTemp.expData);

            return PartialView("_GetTempDetail", testTemp);
        }

        [HttpGet]
        public IActionResult AddTemplateData(int templateId)
        {
            TestTempVM testTemp = new TestTempVM();

            testTemp.TestTemp = db.TestTempService.GetTemplateById(templateId);

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

            return PartialView("_AddTempData", testTemp);
        }

        [HttpPost]
        public bool AddTemplateDetail(TestTempVM testTempVM)
        {
            try
            {
                List<TestTempData> templateData = testTempVM.TestTempDataList;

                foreach(var item in templateData)
                {
                    if(item.multiSelect != null)
                        item.StringValue = string.Join(',', item.multiSelect);
                }
                bool result = db.TestTempService.SaveTemplDataList(templateData);
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        [HttpPost]
        public bool UpdateTemplateData(TestTempVM testTempVM)
        {
            List<TestTempData> testTempData = testTempVM.TestTempDataList;

            db.TestTempService.UpdateTemplateDataList(testTempVM.TestTempDataList);

            return true;
        }

        [HttpPost]
        public bool DeleteTemplateData(TestTempVM testTempVM)
        {
            List<TestTempData> testTempData = testTempVM.TestTempDataList;
            db.TestTempService.DeleteTemplateDataList(testTempVM.TestTempDataList);
            return true;
        }

        [HttpGet]
        public IActionResult SearchTemplate(string searchQuery)
        {
            TestTempVM testTemp = new TestTempVM();

            if (searchQuery != null)
            {
                testTemp.DropDown = db.TestTempService.SearchTemplate(searchQuery).Select(x => new DropDownVM { ID = x.ID, Name = x.TestTempType.Name + ">>" + x.SubTestTempType.Name });
                return View("_SearchMasterTemp", testTemp);
            }
            else
            {
                testTemp.DropDown = db.TestTempService.GetTestTemps().Select(x => new DropDownVM { ID = x.ID, Name = x.TestTempType.Name + ">>" + x.SubTestTempType.Name });
                return View("_SearchMasterTemp", testTemp);
            }
        }
        [HttpGet]
        public IActionResult UpdateTemplate(int ID)
        {
            TestTempVM testTempVM = new TestTempVM();

            ViewBag.TemplateType = db.LookupService.GetLookUpByTypeName("TestTempType");
            ViewBag.SubTemplateType = db.LookupService.GetLookUpByTypeName("SubTestTempType");
            ViewBag.DropDownType = db.LookupService.GetLookUpByTypeName("DropDownType");

            ViewBag.TemplateField = new List<SelectListItem>
            {
              new SelectListItem{ Text="Checkbox", Value = "1" },
              new SelectListItem{ Text="Dropdown", Value = "2" },
              new SelectListItem{ Text="Textbox", Value = "3" }
            };
            ViewBag.TemplateID = ID;

            testTempVM.TestTemp = db.TestTempService.GetTemplateById(ID);

            return PartialView("_UpdateTemp", testTempVM);
        }
    }
}