using Data.DTO;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Repository.UnitOfWork;
using Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Service.Services
{
    public class FollowUpService
    {
        private IUnitOfWork db;
        public FollowUpService(IUnitOfWork db)
        {
            this.db = db;
        }

        public List<FollowUpByDocConv> AddMessage(FollowUpByDocConv conv)
        {
            conv.CreatedOn = DateTime.UtcNow;
            conv.IsActive = true;
            db.FollowUpByDocConv.Insert(conv);

            return db.FollowUpByDocConv.Get().Where(x => x.IsActive == true).ToList();
        }

        public List<FollowUpByDocConv> GetByDocConvs(int orderID)
        {
            return db.FollowUpByDocConv.Get().Where(x => x.IsActive == true && x.OrderID == orderID).ToList();
        }
    }
}
