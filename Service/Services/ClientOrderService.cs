using Data.Models;
using Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Service.IServices;
using Microsoft.EntityFrameworkCore;
using Repository;
using Data.Helpers;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ClientOrderService : IClientOrderService
    {
        private IUnitOfWork db;
        public ClientOrderService(IUnitOfWork db)
        {
            this.db = db;
        }

        public ClientOrder AddClientOrder(ClientOrder clientOrder)
        {
            try
            {
                clientOrder.User = null;
                clientOrder.Doctor = null;
                clientOrder.IsActive = true;
                int tmpOrdr = 0;
                try
                {
                    tmpOrdr = db.ClientOrder.Get().Max(x => x.OrderNo) + 1;
                    clientOrder.OrderNo = tmpOrdr;
                    clientOrder.StatusID = 398;
                    db.ClientOrder.Insert(clientOrder);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                    clientOrder.StatusID = 398;
                    clientOrder.OrderNo = 0;
                    db.ClientOrder.Insert(clientOrder);
                }

                

                return clientOrder;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public ClientOrder GetClientOrderByID(int id)
        {
            try
            {
                var result = db.ClientOrder.Get().Where(x => x.ID == id).Include(x => x.ClientOrderData/*.Where(y => y.IsActive == true)*/).Include(x => x.Template).FirstOrDefault();

                if (result.FollowUp != null)
                    result.FollowUpArray = result.FollowUp.Split(",");

                if (result.TestType != null)
                    result.TestTypeArray = result.TestType.Split(",");

                return result;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public IEnumerable<ClientOrder> GetClientOrderList()
        {
            try
            {
                ApplicationContext context = new ApplicationContext();

                var result = context.ClientOrder.AsQueryable();
                return result.Where(x => x.IsActive == true).Include(x => x.Status).Include(x => x.User).ThenInclude(x => x.PatientPersonalInformation).ThenInclude(x => x.City).Include(x => x.Doctor).Include(x => x.Template).ThenInclude(c => c.TemplateType).OrderByDescending(x => x.ID).Take(100);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        public int GetMaxOrderNo()
        {
            try
            {
                ApplicationContext context = new ApplicationContext();
                return context.ClientOrder.Max(x => x.OrderNo);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public IQueryable<ClientOrderData> GetClientOrderDataByOrderID(int orderId)
        {
            try
            {
                ApplicationContext context = new ApplicationContext();
                return context.ClientOrderData.Where(x => x.ClientOrderID == orderId);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IQueryable<ClientOrder> SearchClientOrder(Search model)
        {
            try
            {
                ApplicationContext context = new ApplicationContext();

                var result = context.ClientOrder.Where(x => x.IsActive == true);

                if (model.ID != 0)
                    result = result.Where(x => x.ID.ToString().StartsWith(model.ID.ToString(), StringComparison.OrdinalIgnoreCase));
                if (model.OrderNo != 0)
                    result = result.Where(x => x.OrderNo.ToString().StartsWith(model.OrderNo.ToString(), StringComparison.OrdinalIgnoreCase)).Include(x => x.User);
                if (!string.IsNullOrEmpty(model.PatientName))
                    result = result.Where(x => (x.User != null) && ((x.User.EnFirstName != null) && x.User.EnFirstName.StartsWith(model.PatientName, StringComparison.OrdinalIgnoreCase) ||
                    (x.User != null) && x.User.ArFirstName != null && x.User.ArFirstName.StartsWith(model.PatientName, StringComparison.OrdinalIgnoreCase)));
                if (!string.IsNullOrEmpty(model.PatientCity))
                    result = result.Where(x => (x.User != null) && (x.User.PatientPersonalInformation != null) && (x.User.PatientPersonalInformation.City != null) &&  
                    x.User.PatientPersonalInformation.City.Name.StartsWith(model.PatientCity, StringComparison.OrdinalIgnoreCase));
                if (!string.IsNullOrEmpty(model.RegistrationNo) && !(model.RegistrationNo == "0"))
                    result = result.Where(x => (x.User != null) && x.User.RegisterationNo.StartsWith(model.RegistrationNo, StringComparison.OrdinalIgnoreCase));
                if (!string.IsNullOrEmpty(model.PatientMobile))
                    result = result.Where(x => x.User.Mobile.StartsWith(model.PatientMobile));
                if (model.BirthDate != null)
                    result = result.Where(x => (x.User != null) && (x.User.PatientPersonalInformation != null) &&
                    (x.User.PatientPersonalInformation.DateOfBirth != null) &&
                    (x.User.PatientPersonalInformation.DateOfBirth.Value.Date) == model.BirthDate.Value.Date);

                return result.Include(x => x.User).ThenInclude(x => x.PatientPersonalInformation).ThenInclude(x => x.City).Include(x => x.Doctor).Include(x => x.Status).Include(x => x.Template).ThenInclude(c => c.TemplateType).OrderByDescending(x => x.ID).Take(50);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public void RemoveClientOrderDataList(List<ClientOrderData> orderDataList)
        {
            try
            {
                ApplicationContext context = new ApplicationContext();
                context.ClientOrderData.RemoveRange(orderDataList);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public bool UpdateClientOrder(ClientOrder clientOrder)
        {
            try
            {
                clientOrder.User = null;
                clientOrder.Doctor = null;
                clientOrder.IsActive = true;
                db.ClientOrder.Update(clientOrder);
                db.ClientOrder.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteClientOrder(int orderId)
        {
            try
            {
                ClientOrder clientOrder =  db.ClientOrder.Get().Where(x => x.ID == orderId).FirstOrDefault();
                clientOrder.IsActive = false;
                db.ClientOrder.Update(clientOrder);
                db.ClientOrder.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public List<ClientOrderData> GetClientOrderDataByTempOrderID(int tempID, int orderID)
        {
            var result = db.ClientOrderData.Get().Where(x => x.TemplateID == tempID && x.ClientOrderID == orderID).ToList();

            for (int i = 0; i < result.Count(); i++)
            {
                if (result[i].GeneID != null)
                    result[i].Genes = result[i].GeneID.Split(",");
            }

            return result;
        }
    }
}
