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
                return db.ClientOrder.Get().Where(x => x.ID == id).Include(x => x.ClientOrderData.Where(y => y.IsActive == true)).FirstOrDefault();
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
                var list = db.ClientOrder.Get().ToList();
                var anotherList = context.ClientOrder.ToList();
                var xray = anotherList;
                return list;
            }
            catch (Exception ex)
            {
                return null;
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
