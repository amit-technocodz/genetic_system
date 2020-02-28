using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Helpers;
using Data.Models;
using GeneticSystem.Areas.Admin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.UnitOfServices;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace GeneticSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MedicalDictionaryController : Controller
    {
        public const int PageSize = 5;
        private readonly IUnitOfService db;
        private readonly IHostingEnvironment _appEnvironment;
        public MedicalDictionaryController(IUnitOfService db, IHostingEnvironment _appEnvironment)
        {
            this.db = db;
            this._appEnvironment = _appEnvironment;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var medicalDictionaryList = new PagedData<MedicalDictionary>();

            var getmedicalDictionaryList = db.MedicalDictionaryService.GetMedicalDictionary().ToList();

            ViewBag.City = db.CityService.GetAll().ToList();
            medicalDictionaryList.Data = getmedicalDictionaryList;
            medicalDictionaryList.Data = (getmedicalDictionaryList).Take(PageSize);
            medicalDictionaryList.NumberOfPages = Convert.ToInt32(Math.Ceiling((double)getmedicalDictionaryList.Count() / PageSize));
            return View(medicalDictionaryList);
        }

        [HttpGet]
        public IActionResult GetMedicalDictionary()
        {
            var medicalDictionaryList = new PagedData<MedicalDictionary>();

            var getmedicalDictionaryList = db.MedicalDictionaryService.GetMedicalDictionary().ToList();

            medicalDictionaryList.Data = getmedicalDictionaryList;
            medicalDictionaryList.Data = (getmedicalDictionaryList).Take(PageSize);
            medicalDictionaryList.NumberOfPages = Convert.ToInt32(Math.Ceiling((double)getmedicalDictionaryList.Count() / PageSize));
            return View(medicalDictionaryList);
        }

        [HttpGet]
        public IActionResult AddMedicalDictionary()
        {
            var getLookupsList = db.LookupService.GetLookups().ToList();
            ViewBag.Types = getLookupsList.Where(x => x.Type == "Type").ToList();
            ViewBag.Specialty = getLookupsList.Where(x => x.Type == "Specialty").ToList();
            ViewBag.Class = getLookupsList.Where(x => x.Type == "Class").ToList();
            ViewBag.City = db.CityService.GetAll().ToList();

            return View();
        }
        [HttpPost]
        public IActionResult AddMedicalDictionary(MedicalDictionaryViewModel medicalDictionaryViewModel, IFormFile file)
        {
            var addmedicalDictionary = new MedicalDictionary();
            var currentDate = DateTime.UtcNow;

            addmedicalDictionary.ID = 0;
            addmedicalDictionary.EnName = medicalDictionaryViewModel.EnName;
            addmedicalDictionary.ArName = medicalDictionaryViewModel.ArName;
            addmedicalDictionary.Email = medicalDictionaryViewModel.Email;
            addmedicalDictionary.Address = medicalDictionaryViewModel.Address;
            addmedicalDictionary.CityID = medicalDictionaryViewModel.CityID;
            addmedicalDictionary.CreatedOn = currentDate;
            addmedicalDictionary.UpdatedOn = currentDate;
            addmedicalDictionary.Mobile = medicalDictionaryViewModel.Mobile;
            addmedicalDictionary.Mobile2 = medicalDictionaryViewModel.Mobile2;
            addmedicalDictionary.Telephone= medicalDictionaryViewModel.Telephone;
            addmedicalDictionary.Telephone2 = medicalDictionaryViewModel.Telephone2;
            addmedicalDictionary.TypeID = medicalDictionaryViewModel.TypeID;
            addmedicalDictionary.IsActive = true;
            addmedicalDictionary.ClassID = medicalDictionaryViewModel.ClassID;
            addmedicalDictionary.Latitude= medicalDictionaryViewModel.Latitude;
            addmedicalDictionary.Longitude= medicalDictionaryViewModel.Longitude;

            if (file != null)
            {
                var path = Path.Combine(_appEnvironment.WebRootPath, "Uploaded", file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyToAsync(stream);
                    addmedicalDictionary.ImagePath = "/uploaded/" + file.FileName;
                }
            }
            var addmedicalDictionaryData = db.MedicalDictionaryService.AddMedicalDictionary(addmedicalDictionary);
            var getmedicalDictionaryID = addmedicalDictionaryData.ID;

            if(medicalDictionaryViewModel.Specialty != null)
            {

            
            var medicalDictionarySpeciality = medicalDictionaryViewModel.Specialty.Select((p, i) => new MedicalDictionarySpecialty
            {
                ID = 0,
                IsActive = true,
                UpdatedOn = currentDate,
                CreatedOn = currentDate,
                MedicalDictionaryID = getmedicalDictionaryID,
                SpecialtyID = int.Parse(p)
            }).ToList();
                db.MedicalDictionaryService.AddMedicalDictionaryService(medicalDictionarySpeciality);
            }

           

            return Json(true);
        }

        public IActionResult DeleteMedicalDictionary(int id)
        {
            db.MedicalDictionaryService.Delete(id);
            return Json(true);
        }

        public IActionResult UpdateMedicalDictionary(int id)
        {
            var getLookupsList = db.LookupService.GetLookups().ToList();

            ViewBag.Types = getLookupsList.Where(x => x.Type == "Type").ToList();
            ViewBag.Specialty = getLookupsList.Where(x => x.Type == "Specialty").ToList();
            ViewBag.Class = getLookupsList.Where(x => x.Type == "Class").ToList();
            ViewBag.City = db.CityService.GetAll().ToList();
            var currentDate = DateTime.UtcNow;

            var model = db.MedicalDictionaryService.GetMedicalDictionaryById(id);
            //model.Specialty = new string[model.MedicalDictionarySpecialty.Count()];

            model.Specialty = new string[1];
            model.Specialty[0] = "0";

            //for (var i = 0; i < model.MedicalDictionarySpecialty.Count(); i++)
            //{
            //    model.Specialty[i] = model.MedicalDictionarySpecialty[i].SpecialtyID.ToString();
            //}

            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateMedicalDictionary(MedicalDictionaryViewModel medicalDictionaryViewModel, IFormFile file)
        {
            var addmedicalDictionary = new MedicalDictionary();
            var currentDate = DateTime.UtcNow;

            addmedicalDictionary.ID = medicalDictionaryViewModel.ID;
            addmedicalDictionary.EnName = medicalDictionaryViewModel.EnName;
            addmedicalDictionary.ArName = medicalDictionaryViewModel.ArName;
            addmedicalDictionary.Email = medicalDictionaryViewModel.Email;
            addmedicalDictionary.Address = medicalDictionaryViewModel.Address;
            addmedicalDictionary.CityID = medicalDictionaryViewModel.CityID;
            addmedicalDictionary.CreatedOn = currentDate;
            addmedicalDictionary.UpdatedOn = currentDate;
            addmedicalDictionary.Mobile = medicalDictionaryViewModel.Mobile;
            addmedicalDictionary.Mobile2 = medicalDictionaryViewModel.Mobile2;
            addmedicalDictionary.Telephone = medicalDictionaryViewModel.Telephone;
            addmedicalDictionary.Telephone2 = medicalDictionaryViewModel.Telephone2;
            addmedicalDictionary.TypeID = medicalDictionaryViewModel.TypeID;
            addmedicalDictionary.IsActive = true;
            addmedicalDictionary.ClassID = medicalDictionaryViewModel.ClassID;
            addmedicalDictionary.Latitude = medicalDictionaryViewModel.Latitude;
            addmedicalDictionary.Longitude = medicalDictionaryViewModel.Longitude;

            if (file != null)
            {
                var path = Path.Combine(_appEnvironment.WebRootPath, "Uploaded", file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyToAsync(stream);
                    addmedicalDictionary.ImagePath = "/uploaded/" + file.FileName;
                }
            }


            //if (model.File != null)
            //{
            //    var path = Path.Combine(_appEnvironment.WebRootPath, "Uploaded", model.File.FileName);

            //    using (var stream = new FileStream(path, FileMode.Create))
            //    {
            //        model.File.CopyToAsync(stream);
            //        usermodel.ImagePath = "/uploaded/" + model.File.FileName;
            //    }
            //}

            var addmedicalDictionaryData = db.MedicalDictionaryService.UpdatMedicalDictionary(addmedicalDictionary);
            var getmedicalDictionaryID = addmedicalDictionaryData.ID;

            db.MedicalDictionaryService.DeleteMedicalDictionarySpecialty(getmedicalDictionaryID);

            if(medicalDictionaryViewModel.Specialty != null)
            {
                var medicalDictionarySpeciality = medicalDictionaryViewModel.Specialty.Select((p, i) => new MedicalDictionarySpecialty
                {
                    ID = 0,
                    IsActive = true,
                    UpdatedOn = currentDate,
                    CreatedOn = currentDate,
                    MedicalDictionaryID = medicalDictionaryViewModel.ID,
                    SpecialtyID = int.Parse(p)
                }).ToList();

                db.MedicalDictionaryService.AddMedicalDictionaryService(medicalDictionarySpeciality);
            }

            return Json(true);
        }

        //Added this 228
        [HttpGet]
        public IActionResult SearchEnName(int page, string searchstringen, string searchstringar)
        {
            var searchList = new PagedData<MedicalDictionary>();
            var medicalDictionaryList = db.MedicalDictionaryService.GetMedicalDictionary().Where(x => x.IsActive == true).ToList();

            if (searchstringen != null)
            {
                var searchstring = searchstringen;
                if (!string.IsNullOrEmpty(searchstring))
                {
                    medicalDictionaryList = medicalDictionaryList.Where(x => x.EnName != null && x.EnName.Contains(searchstring.ToString(), StringComparison.OrdinalIgnoreCase)
                    || (x.ArName != null && x.ArName.Contains(searchstring, StringComparison.OrdinalIgnoreCase))).ToList();
                }
            }
            else if (searchstringar != null)
            {
                var searchstring = searchstringar;
                if (!string.IsNullOrEmpty(searchstring))
                {
                    medicalDictionaryList = medicalDictionaryList.Where(x => x.EnName != null && x.EnName.Contains(searchstring.ToString(), StringComparison.OrdinalIgnoreCase)
                    || (x.ArName != null && x.ArName.Contains(searchstring, StringComparison.OrdinalIgnoreCase))).ToList();
                }
            }


            searchList.Data = (medicalDictionaryList).Skip(PageSize * (page - 1)).Take(PageSize);
            searchList.NumberOfPages = Convert.ToInt32(Math.Ceiling((double)medicalDictionaryList.Count() / PageSize));

            ViewBag.City = db.CityService.GetAll().ToList();

            return PartialView("GetMedicalDictionary", searchList);
        }
    }
}