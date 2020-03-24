using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Models;
using GeneticSystem.Areas.Admin.Models;
using GeneticSystem.Areas.Admin.Models.FollowUp;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MoreLinq;
using Service.UnitOfServices;

namespace GeneticSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FollowUpController : Controller
    {
        public const int PageSize = 50;
        private readonly IHostingEnvironment _appEnvironment;
        private readonly IUnitOfService db;
        public FollowUpController(IUnitOfService db, IHostingEnvironment _appEnvironment)
        {
            this.db = db;
            this._appEnvironment = _appEnvironment;

        }

        public IActionResult Index(int? id)
        {
            FollowUpVM followUpVM = new FollowUpVM
            {
                patientList = db.UserService.GetPatients().Select(x => new SelectListItem { 
                Value = x.ID.ToString(),
                Text = ((x.EnFirstName ?? "") + " " + (x.EnSecondName ?? "") + " " + (x.EnThirdName ?? ""))
                }).ToList()
            };

            if(id != null)
            {
                followUpVM.User = db.UserService.GetPatient(Convert.ToInt32(id));
                var result = db.ClientOrderService.GetClientOrdersByUserID(Convert.ToInt32(id));
                followUpVM.ClientOrderList.Data = (result).Take(PageSize);
                followUpVM.ClientOrderList.NumberOfPages = Convert.ToInt32(Math.Ceiling((double)result.Count() / PageSize));
            }

            return View(followUpVM);
        }

        public IActionResult GetClientOrders(int userID)
        {
            FollowUpVM followUpVM = new FollowUpVM();
            var result = db.ClientOrderService.GetClientOrdersByUserID(Convert.ToInt32(userID)).ToList(); ;

            followUpVM.ClientOrderList = new Data.Helpers.PagedData<Data.Models.ClientOrder>();
            followUpVM.ClientOrderList.Data = (result).Take(PageSize);
            followUpVM.ClientOrderList.NumberOfPages = Convert.ToInt32(Math.Ceiling((double)result.Count() / PageSize));

            return PartialView("_GetOrder", followUpVM);
        }

        [HttpGet]
        public IActionResult GetOrderData(int orderId)
        {
            FollowUpVM followUpVM = new FollowUpVM();
            ClientOrderViewModel viewModel = new ClientOrderViewModel();
            List<ClientOrderData> clientOrderDatas = new List<ClientOrderData>();

            ClientOrder clientOrder = db.ClientOrderService.GetClientOrderByID(orderId);
            viewModel.ClientOrder = clientOrder;
            ViewBag.FollowUp = db.LookupService.GetLookUpByTypeName("FollowUpType");
            ViewBag.TestTypes = db.LookupService.GetLookUpByTypeName("TestTempType");
            ViewBag.EffectedGene = db.LookupService.GetLookUpByTypeName("Gene");
            ViewBag.FollowUp = db.LookupService.GetLookUpByTypeName("FollowUpType");
            ViewBag.Element = db.LookupService.GetLookUpByTypeName("Element");
            ViewBag.ConsumptionType = db.LookupService.GetLookUpByTypeName("ConsumptionType");
            ViewBag.FeederType = db.LookupService.GetLookUpByTypeName("FeederType");

            viewModel.TemplateList = db.DynamicTemplateService.GetAllTemplates().Where(x => x.TemplateTypeID == clientOrder.Template.TemplateTypeID).ToList();

            for (int i = 0; i < viewModel.TemplateList.Count(); i++)
            {
                clientOrderDatas.AddRange(db.ClientOrderService.GetClientOrderDataByTempOrderID(viewModel.TemplateList[i].ID, clientOrder.ID));
            }

            viewModel.ClientOrderData = clientOrderDatas;

            ViewBag.Doctors = db.UserService.GetByRole(3).Select(x => new { ID = x.ID, Name = x.EnFirstName + " " + x.EnThirdName });
            ViewBag.Clients = db.UserService.GetPatients().Select(x => new { ID = x.ID, Name = x.EnFirstName + " " + x.EnThirdName });
            ViewBag.Templates = db.DynamicTemplateService.GetAllTemplates().Select(x => new { x.ID, x.TemplateType.Name }).DistinctBy(x => x.Name);
            ViewBag.Result = new List<SelectListItem>
            {
              new SelectListItem{ Text="High", Value = "1" },
              new SelectListItem{ Text="Medium", Value = "2" },
              new SelectListItem{ Text="Low", Value = "3" }
            };

            followUpVM.ClientOrderViewModel = viewModel;
            followUpVM.FollowUpByDocConvList = db.FollowUpService.GetByDocConvs(viewModel.ClientOrder.ID);
            return PartialView("_GetTempOrder", followUpVM);
        }

        [HttpGet]
        public bool CloseOrder(int orderId)
        {
            db.ClientOrderService.CloseClientOrderByID(orderId);
            return true;
        }

        [HttpPost]
        public IActionResult AddFollowUpSummary (FollowUpByDocConv followUpByDoc)
        {
            FollowUpVM followUpVM = new FollowUpVM();
            int? senderID = Convert.ToInt32(HttpContext.Request.Cookies["ID"]);
            followUpByDoc.SenderID =  senderID != null ? Convert.ToInt32(senderID) : 1;
            followUpVM.FollowUpByDocConvList = db.FollowUpService.AddMessage(followUpByDoc);
            return PartialView("_FollowUpByDocMessage", followUpVM);
        }
    }
}
