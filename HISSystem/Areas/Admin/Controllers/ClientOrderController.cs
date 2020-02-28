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
using MoreLinq.Extensions;
using Service.UnitOfServices;
namespace GeneticSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ClientOrderController : Controller
    {
        public const int PageSize = 10;
        private readonly IHostingEnvironment _appEnvironment;
        private readonly IUnitOfService db;

        public ClientOrderController(IUnitOfService db, IHostingEnvironment _appEnvironment)
        {
            this.db = db;
            this._appEnvironment = _appEnvironment;
        }
        public IActionResult Index()
        {
            var clientOrderList = db.ClientOrderService.GetClientOrderList();
            var clientOrders = new PagedData<ClientOrder>();
            clientOrders.Data = (clientOrderList).Take(PageSize);
            //clientOrders.Data = clientOrderList;
            clientOrders.NumberOfPages = Convert.ToInt32(Math.Ceiling((double)clientOrderList.Count() / PageSize));
            return View(clientOrders);
        }


        public IActionResult getOrders(int page)
        {
            var clientOrderList = db.ClientOrderService.GetClientOrderList();
            var clientOrders = new PagedData<ClientOrder>();
            clientOrders.Data = (clientOrderList).Skip(PageSize * (page - 1)).Take(PageSize);
            //clientOrders.Data = clientOrderList;
            clientOrders.NumberOfPages = Convert.ToInt32(Math.Ceiling((double)clientOrderList.Count() / PageSize));
            return PartialView("_Index",clientOrders);
        }

        [HttpGet]
        public IActionResult AddOrder()
        {
            ViewBag.Doctors = db.UserService.GetByRole(3);
            ViewBag.Clients = db.UserService.GetPatients().OrderByDescending(x => x.AddedDate);
            ViewBag.Templates = db.DynamicTemplateService.GetAllTemplates().Select(x => new { x.ID, x.TemplateType.Name }).DistinctBy(x => x.Name);
            ViewBag.TestTypes = db.LookupService.GetLookUpByTypeName("TemplateType");
            ViewBag.EffectedGene = db.LookupService.GetLookUpByTypeName("Gene");

            return PartialView("AddClientOrder");
        }


        [HttpPost]
        public IActionResult AddOrder(ClientOrderViewModel clientOrder)
        {
            try
            {
                if (clientOrder.ClientOrder.FollowUpArray != null)
                    clientOrder.ClientOrder.FollowUp = string.Join(',', clientOrder.ClientOrder.FollowUpArray);

                if (clientOrder.ClientOrder.TestTypeArray != null)
                    clientOrder.ClientOrder.TestType = string.Join(',', clientOrder.ClientOrder.TestTypeArray);

                for (int i = 0; i < clientOrder.ClientOrderData.Count(); i++)
                {
                    if (clientOrder.ClientOrderData[i].Genes != null)
                        clientOrder.ClientOrderData[i].GeneID = string.Join(',', clientOrder.ClientOrderData[i].Genes);
                }
                ClientOrder order = clientOrder.ClientOrder;
                order.ClientOrderData = clientOrder.ClientOrderData;

                db.ClientOrderService.AddClientOrder(order);
                var clientOrderList = db.ClientOrderService.GetClientOrderList();
                var clientOrders = new PagedData<ClientOrder>();
                clientOrders.Data = (clientOrderList).Take(PageSize);
                //clientOrders.Data = clientOrderList;
                clientOrders.NumberOfPages = Convert.ToInt32(Math.Ceiling((double)clientOrderList.Count() / PageSize));
                return PartialView("_Index", clientOrders);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public IActionResult UpdateOrder(int orderId)
        {
            ClientOrderViewModel viewModel = new ClientOrderViewModel();
            List<ClientOrderData> clientOrderDatas = new List<ClientOrderData>();
            
            ClientOrder clientOrder = db.ClientOrderService.GetClientOrderByID(orderId);
            viewModel.ClientOrder = clientOrder;

            ViewBag.TestTypes = db.LookupService.GetLookUpByTypeName("TemplateType"); 
            ViewBag.EffectedGene = db.LookupService.GetLookUpByTypeName("Gene");
            ViewBag.Element = db.LookupService.GetLookUpByTypeName("Element");
            ViewBag.ConsumptionType = db.LookupService.GetLookUpByTypeName("ConsumptionType");
            ViewBag.FeederType = db.LookupService.GetLookUpByTypeName("FeederType");

            viewModel.TemplateList = db.DynamicTemplateService.GetAllTemplates().Where(x => x.TemplateTypeID == clientOrder.Template.TemplateTypeID).ToList();
            
            for(int i = 0; i < viewModel.TemplateList.Count(); i++)
            {
                clientOrderDatas.AddRange(db.ClientOrderService.GetClientOrderDataByTempOrderID(viewModel.TemplateList[i].ID, clientOrder.ID));
            }

            viewModel.ClientOrderData = clientOrderDatas;

            ViewBag.Doctors = db.UserService.GetByRole(3);
            ViewBag.Clients = db.UserService.GetPatients().OrderByDescending(x => x.AddedDate);
            ViewBag.Templates = db.DynamicTemplateService.GetAllTemplates().Select(x => new { x.ID, x.TemplateType.Name }).DistinctBy(x => x.Name);


            ViewBag.Result = new List<SelectListItem>
            {
              new SelectListItem{ Text="High", Value = "1" },
              new SelectListItem{ Text="Medium", Value = "2" },
              new SelectListItem{ Text="Low", Value = "3" }
            };


            return PartialView("AddClientOrder", viewModel);
        }
        [HttpPost]
        public IActionResult UpdateOrder(ClientOrderViewModel clientOrder)
        {
            if (clientOrder.ClientOrder.FollowUpArray != null)
                clientOrder.ClientOrder.FollowUp = string.Join(',', clientOrder.ClientOrder.FollowUpArray);

            if (clientOrder.ClientOrder.TestTypeArray != null)
                clientOrder.ClientOrder.TestType = string.Join(',', clientOrder.ClientOrder.TestTypeArray);

            for (int i = 0; i < clientOrder.ClientOrderData.Count(); i++)
            {
                if (clientOrder.ClientOrderData[i].Genes != null)
                    clientOrder.ClientOrderData[i].GeneID = string.Join(',', clientOrder.ClientOrderData[i].Genes);
            }
            ClientOrder order = clientOrder.ClientOrder;
            order.ClientOrderData = clientOrder.ClientOrderData;

            List<ClientOrderData> previousData = db.ClientOrderService.GetClientOrderDataByOrderID(order.ID).ToList();
            db.ClientOrderService.RemoveClientOrderDataList(previousData);

            bool result = db.ClientOrderService.UpdateClientOrder(order);
            var clientOrderList = db.ClientOrderService.GetClientOrderList();

            PagedData<ClientOrder> clientOrders = new PagedData<ClientOrder>
            {
                Data = (clientOrderList).Take(PageSize),
                NumberOfPages = Convert.ToInt32(Math.Ceiling((double)clientOrderList.Count() / PageSize))
            };

            return PartialView("_Index", clientOrders);
        }

        [HttpGet]
        public IActionResult GetTemplateData(int type)
        {
            if (type != 0)
            {
                ClientOrderViewModel viewModel = new ClientOrderViewModel();
                var tmpID = db.DynamicTemplateService.GetAllTemplates().Where(x => x.ID == type).FirstOrDefault();
                viewModel.TemplateList = db.DynamicTemplateService.GetAllTemplateByTempID(tmpID.TemplateTypeID).ToList() ;
                ViewBag.Doctors = db.UserService.GetByRole(3);
                ViewBag.Clients = db.UserService.GetPatients().OrderByDescending(x => x.AddedDate);
                ViewBag.Templates = db.DynamicTemplateService.GetAllTemplates().Select(x => new { x.ID, x.TemplateType.Name }).DistinctBy(x => x.Name);
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

                List<TemplateData> templateDatas = new List<TemplateData>();
                for(int i = 0; i < viewModel.TemplateList.Count(); i++)
                {
                    templateDatas.AddRange(db.DynamicTemplateService.GetTemplateDataID(viewModel.TemplateList[i].ID));
                }

                viewModel.TemplateDataList = templateDatas;

                return PartialView("_GetOrderTemplate", viewModel);
            }
            else
                return null;
        }
    }
}