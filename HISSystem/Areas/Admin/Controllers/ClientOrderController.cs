using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Helpers;
using Data.Models;
using GeneticSystem.Areas.Admin.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Service.UnitOfServices;
namespace GeneticSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ClientOrderController : Controller
    {
        public const int PageSize = 50;
        private readonly IHostingEnvironment _appEnvironment;
        private readonly IUnitOfService db;

        public ClientOrderController(IUnitOfService db, IHostingEnvironment _appEnvironment)
        {
            this.db = db;
            this._appEnvironment = _appEnvironment;
        }
        public IActionResult Index()
        {
            var clientOrders = new PagedData<ClientOrder>();
            var clientOrderList = db.ClientOrderService.GetClientOrderList();
            clientOrders.Data = (clientOrderList).Take(PageSize);
            clientOrders.NumberOfPages = Convert.ToInt32(Math.Ceiling((double)clientOrderList.Count() / PageSize));
            return View(clientOrders);
        }

        [HttpGet]
        public IActionResult AddOrder()
        {
            var LookupList = db.LookupService.GetLookupList().ToEnumerable();
            ViewBag.Clients = db.UserService.GetAll();
            ViewBag.Templates = db.DynamicTemplateService.GetAllTemplates().Select(x => x.TemplateType).Distinct().ToList();
            ViewBag.TestTypes = LookupList.Where(x => x.Type == "TemplateType");
            ViewBag.EffectedGene = LookupList.Where(x => x.Type == "Gene");

            return PartialView("AddClientOrder");
        }


        [HttpPost]
        public IActionResult AddOrder(ClientOrderViewModel clientOrder)
        {
            if(clientOrder.ClientOrder.FollowUpArray != null)
                clientOrder.ClientOrder.FollowUp = string.Join(',', clientOrder.ClientOrder.FollowUpArray);

            if(clientOrder.ClientOrder.TestTypeArray!= null)
                clientOrder.ClientOrder.TestType = string.Join(',', clientOrder.ClientOrder.TestTypeArray);

            for (int i = 0; i < clientOrder.ClientOrderData.Count(); i++)
            {
                if(clientOrder.ClientOrderData[i].Genes != null)
                    clientOrder.ClientOrderData[i].GeneID = string.Join(',', clientOrder.ClientOrderData[i].Genes);
            }
            ClientOrder order = clientOrder.ClientOrder;
            order.ClientOrderData = clientOrder.ClientOrderData;

            return PartialView("AddClientOrder");
        }

        [HttpGet]
        public IActionResult UpdateOrder(int id)
        {
            ClientOrderViewModel viewModel = new ClientOrderViewModel();
            List<ClientOrderData> clientOrderDatas = new List<ClientOrderData>();
            
            ClientOrder clientOrder = db.ClientOrderService.GetClientOrderByID(id);
            var LookupList = db.LookupService.GetLookupList().ToEnumerable();
            viewModel.TemplateList = db.DynamicTemplateService.GetAllTemplates().Where(x => x.TemplateTypeID == clientOrder.TemplateID).ToList();
            
            foreach (var item in viewModel.TemplateList)
            {
                clientOrderDatas.AddRange(db.ClientOrderService.GetClientOrderDataByTempOrderID(item.ID, clientOrder.ID));
            }
            viewModel.ClientOrderData = clientOrderDatas;

            ViewBag.Clients = db.UserService.GetAll();
            ViewBag.Templates = db.DynamicTemplateService.GetAllTemplates().Select(x => x.TemplateType).Distinct().ToList();
            ViewBag.TestTypes = LookupList.Where(x => x.Type == "TemplateType");
            ViewBag.EffectedGene = LookupList.Where(x => x.Type == "Gene");

            return PartialView("_GetClientOrder", clientOrder);
        }

        [HttpGet]
        public IActionResult GetTemplateData(int type)
        {
            if (type != 0)
            {
                ClientOrderViewModel viewModel = new ClientOrderViewModel();
                viewModel.TemplateList = db.DynamicTemplateService.GetAllTemplates().Where(x => x.TemplateTypeID == type).ToList();
                ViewBag.Clients = db.UserService.GetAll();
                ViewBag.Templates = db.DynamicTemplateService.GetAllTemplates().Select(x => x.TemplateType).Distinct().ToList();
                var LookupList = db.LookupService.GetLookups();
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

                List<TemplateData> templateDatas = new List<TemplateData>();
                foreach(var item in viewModel.TemplateList)
                {
                    templateDatas.AddRange(db.DynamicTemplateService.GetTemplateDataID(item.ID));
                }

                viewModel.TemplateDataList = templateDatas;

                return PartialView("_GetOrderTemplate", viewModel);
            }
            else
                return null;
        }
    }
}