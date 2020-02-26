using Data.Models;
using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.Interfaces;
using Repository.UnitOfWork;
using Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Services
{
    public class AppointmentService : IAppointmentService
    {
        private IUnitOfWork db;
        private ApplicationContext _context;
        public AppointmentService(IUnitOfWork db)
        {
            this.db = db;
        }

        public Appointment Add(Appointment model)
        {
            ApplicationContext _context = new ApplicationContext();
            var result = _context.Appointment.Add(model);
            var data = _context.SaveChanges();
            return model;
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Appointment GetById(long id)
        {
            return db.Appointment.Get().Where(x => x.ID == id && x.IsActive == true).Include(x => x.Doctor.PersonalInformation).Include(x => x.User.PersonalInformation).Include(x => x.Room).FirstOrDefault();
        }

        public IEnumerable<Appointment> GetAll()
        {
            var xray = db.Appointment.Get().Where(x => x.IsActive == true).Include(x => x.Doctor.PersonalInformation).Include(x=>x.User).Include(x => x.Room).ToList();
            return db.Appointment.Get().Where(x => x.IsActive == true).Include(x => x.Doctor.PersonalInformation).Include(x => x.Room).ToList();
        }

        public void Update(Appointment model)
        {
            try
            {
                db.Appointment.Update(model);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
