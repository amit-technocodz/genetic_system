﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.IServices;
using HISSystem.Areas.Admin.Models;
using Data.Helpers;
using Data.Models;
using Service.UnitOfServices;
using X.PagedList;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HISSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LookupController : Controller
    {
        public const int PageSize = 3;
        private readonly IUnitOfService db;
        public LookupController(IUnitOfService db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            List<Lookup> lookupTry = new List<Lookup>();
 
            var lookupList = db.LookupService.GetLookups().Where(x => x.IsActive == true).Select(x => x.Type).Distinct().ToList();

            ViewBag.Lookups = lookupList;

            foreach (var item in lookupList)
            {
                Lookup lookup = new Lookup();
                lookup.Type = item;
                lookup.Name = item.ToLower() + "List";
                lookupTry.Add(lookup);
            }

            
            return View(lookupTry);
        }

        public IActionResult GetLookupIndex(string lookupName)
        {
            LookupIndexModel lookupIndex = new LookupIndexModel();
            lookupIndex.PagedLookups = new PagedData<Lookup>();
            lookupIndex.Lookup = new Lookup();
            ViewBag.LookupName = lookupName;

            var xray = db.LookupService.GetLookups().Where(x => x.IsActive == true).ToList();

            var result = xray.Where(x => x.Type.Equals(lookupName)).ToList();

            lookupIndex.PagedLookups.Data = result.OrderBy(x => x.ID).Take(PageSize).ToList();
            lookupIndex.PagedLookups.NumberOfPages = Convert.ToInt32(Math.Ceiling((double)result.Count() / PageSize));

            if (lookupName == "Floor")
            {
                foreach (var item in lookupIndex.PagedLookups.Data)
                {
                    item.Type = xray.Where(x => x.ID == Convert.ToInt32(item.ParentId)).FirstOrDefault().Name.ToString();
                }
            }
            else if (lookupName == "Room")
            {
                foreach (var item in lookupIndex.PagedLookups.Data)
                {
                    Lookup lookup = new Lookup();

                    lookup = xray.Where(x => x.ID == Convert.ToInt32(item.ParentId)).FirstOrDefault();

                    string grandParent = xray.Where(x => x.ID == Convert.ToInt32(lookup.ParentId)).FirstOrDefault().Name.ToString();

                    item.Type = grandParent + "/" + lookup.Name;
                }
            }

            return PartialView("_Index", lookupIndex);
        }
 
        [HttpGet]
        public IActionResult _GetLookupIndex(string lookupName, int page)
        {
            LookupIndexModel lookupIndex = new LookupIndexModel();
            lookupIndex.PagedLookups = new PagedData<Lookup>();
            lookupIndex.Lookup = new Lookup();
            ViewBag.LookupName = lookupName;

            var xray = db.LookupService.GetLookups().Where(x => x.IsActive == true).ToList();
            var result = xray.Where(x => x.Type.Contains(lookupName)).ToList();

            lookupIndex.PagedLookups.Data = result.OrderBy(x => x.ID).Skip(PageSize * (page - 1)).Take(PageSize).ToList();
            lookupIndex.PagedLookups.NumberOfPages = Convert.ToInt32(Math.Ceiling((double)result.Count() / PageSize));

            

            if (lookupName == "Floor")
            {
                foreach (var item in lookupIndex.PagedLookups.Data)
                {
                    item.Type = xray.Where(x => x.ID == Convert.ToInt32(item.ParentId)).FirstOrDefault().Name.ToString();
                }
            }
            else if (lookupName == "Room")
            {
                foreach (var item in lookupIndex.PagedLookups.Data)
                {
                    Lookup lookup = new Lookup();

                    lookup = xray.Where(x => x.ID == Convert.ToInt32(item.ParentId)).FirstOrDefault();

                    string grandParent = xray.Where(x => x.ID == Convert.ToInt32(lookup.ParentId)).FirstOrDefault().Name.ToString();

                    item.Type = grandParent + "/" + lookup.Name;
                }
            }


            return PartialView("_Index", lookupIndex);
        }
  
        [HttpGet]
        public IActionResult Add(string lookupName)
        {
            switch (lookupName)
            {
                case "Floor":
                    ViewBag.Buildings = db.LookupService.GetLookups().Where(x => x.Type == "Building").ToList();
                    break;

                case "Room":
                    ViewBag.Buildings = db.LookupService.GetLookups().Where(x => x.Type == "Building").ToList();
                    ViewBag.Floors = db.LookupService.GetLookups().Where(x => x.Type == "Floor").ToList();
                    break;
            }

            Int32 result = db.LookupService.GetLookups().Where(x => x.Type.Contains(lookupName)).ToList().Max(x => x.TypeID);
            Lookup lookup = new Lookup();
            lookup.TypeID = (++result);
            lookup.Type = lookupName;
            ViewBag.lookupName = lookupName;

            return PartialView("_Add", lookup);
        }

        [HttpGet]
        public IActionResult AddMaster()
        {
            Lookup lookup = new Lookup();
            lookup.TypeID = 1;
            lookup.Type = "";
            return PartialView("_AddMaster", lookup);
        }
        [HttpPost]
        public IActionResult AddNewMaster(Lookup lookup)
        {
            lookup.AddedDate = DateTime.UtcNow;
            lookup.IsActive = true;
            var name = lookup.Name;
            lookup.Name= name.Trim();
            db.LookupService.InsertUser(lookup);
            return Json(true);
        }

        [Area("Admin")]
        public IActionResult GetFloor(string BuildingID)
        {
            List<Lookup> floorList = new List<Lookup>();
            List<Floor> Floors = new List<Floor>();
            floorList = db.LookupService.GetLookups().Where(x => x.ParentId == BuildingID).ToList();

            foreach (var item in floorList)
            {
                Floor floor = new Floor();
                floor.ID = item.ID;
                floor.Name = item.Name;
                Floors.Add(floor);
            }

            Floors.Insert(0, new Floor { ID = 0, Name = "Select" });

            return Json(new SelectList(Floors, "ID", "Name"));
        }

        [HttpPost]
        public IActionResult Add(Lookup lookup)
        {
            lookup.IsActive = true;
            var name = lookup.Name;
            lookup.Name = name.Trim();
            lookup.AddedDate = System.DateTime.Now;
            lookup.ModifiedDate = System.DateTime.Now;
            db.LookupService.InsertUser(lookup);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int lookupID)
        {
            Lookup lookup = new Lookup();
            lookup = db.LookupService.GetLookup(lookupID);
            lookup.IsActive = false;
            db.LookupService.UpdateUser(lookup);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult GetLookup(int lookupID)
        {
            Lookup lookup = new Lookup();
            lookup = db.LookupService.GetLookup(lookupID);

            return PartialView("_GetLookup", lookup);
        }

        [HttpPost]
        public IActionResult GetLookup(Lookup lookup)
        {
            lookup.ModifiedDate = System.DateTime.Now;
            db.LookupService.UpdateUser(lookup);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult SearchMasterLookup(string searchQuery)
        {
            List<Lookup> lookupTry = new List<Lookup>();

            if (searchQuery != null)
            {
                var lookupList = db.LookupService.GetLookups().Where(x => x.Type.StartsWith(searchQuery, StringComparison.OrdinalIgnoreCase) && x.IsActive==true).Select(x => x.Type).Distinct().ToList();
                ViewBag.Lookups = lookupList;
            }
            else
            {
                var lookupList = db.LookupService.GetLookups().Where(x => x.IsActive == true).Select(x => x.Type).Distinct().ToList();
                ViewBag.Lookups = lookupList;
            }    
            

            return PartialView("search", lookupTry);
        }

        [HttpGet]
        public IActionResult SearchLookupDetails(string searchString, string lookupName)
        {
            var lookupList = db.LookupService.GetLookups().ToList();

            var searchResult = lookupList;

            if (searchString != null && lookupName != null)
            {
                searchResult = lookupList.Where(x => x.Type == lookupName && x.Name.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)).ToList();
            } 
            else if(searchString == null && lookupName != null)
            {
                searchResult = lookupList.Where(x => x.Type == lookupName).ToList();
            }

            LookupIndexModel lookupIndex = new LookupIndexModel();
            lookupIndex.PagedLookups = new PagedData<Lookup>();
            lookupIndex.Lookup = new Lookup();
            ViewBag.LookupName = lookupName;

            lookupIndex.PagedLookups.Data = searchResult.OrderBy(x => x.ID).Take(PageSize).ToList();
            lookupIndex.PagedLookups.NumberOfPages = Convert.ToInt32(Math.Ceiling((double)searchResult.Count() / PageSize));

            return PartialView("_SearchDetail", lookupIndex);
        }
        public IActionResult CustomValidation(string type)
        {

            return View();
        
        
        }

    }
}