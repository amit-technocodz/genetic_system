using Data.Models;
using Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Service.IServices;
using Microsoft.EntityFrameworkCore;
using Repository;

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
                db.ClientOrder.Insert(clientOrder);

                return clientOrder;
            }
            catch(Exception ex)
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
                    
                if(result.TestType != null)
                    result.TestTypeArray = result.TestType.Split(",");
                
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public IQueryable<ClientOrder> GetClientOrderList()
        {
            try
            {
                ApplicationContext context = new ApplicationContext();
                return context.ClientOrder.OrderByDescending(x => x.ID).Take(50).Include(x =>x.Doctor).Include(x => x.User).AsNoTracking();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public IQueryable<ClientOrderData> GetClientOrderDataByOrderID (int orderId)
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

        public void RemoveClientOrderDataList(List<ClientOrderData> orderDataList)
        {
            try
            {
                ApplicationContext context = new ApplicationContext();
                context.ClientOrderData.RemoveRange(orderDataList);
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
                db.ClientOrder.Update(clientOrder);
                db.ClientOrder.SaveChanges();

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public List<ClientOrderData> GetClientOrderDataByTempOrderID(int tempID, int orderID)
        {
           var result =  db.ClientOrderData.Get().Where(x => x.TemplateID == tempID && x.ClientOrderID == orderID).ToList();

            for (int i = 0; i < result.Count(); i++)
            {
                if (result[i].GeneID != null)
                    result[i].Genes = result[i].GeneID.Split(",");
            }

            return result;
        }
    }
}
