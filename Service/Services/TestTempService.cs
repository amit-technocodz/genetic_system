using Data.Models;
using Microsoft.EntityFrameworkCore;
using Repository.UnitOfWork;
using Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class TestTempService : ITestTempService
    {
        private IUnitOfWork db;
        public TestTempService(IUnitOfWork db)
        {
            this.db = db;
        }

        public bool AddTestTemp(TestTemp testTemp)
        {
            try
            {
                db.TestTemp.Insert(testTemp);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        //public async Task<List<TestTemp>> GetTestTempsAsync()
        //{
        //    return await db.TestTemp.Get().Include(x => x.TestTempType).Include(x => x.SubTestTempType).ToListAsync();
        //}

        public IEnumerable<TestTemp> GetTestTemps()
        {
            return db.TestTemp.Get().Include(x => x.TestTempType).Include(x => x.SubTestTempType).AsNoTracking();
        }

        public TestTemp GetTemplateById(int tempId)
        {
            return db.TestTemp.Get().Where(x => x.ID == tempId).Include(x => x.TestTempType).Include(x => x.SubTestTempType).Include(x => x.TestTempCols).ThenInclude(t => t.DataSource).Include(x => x.TestTempCols).ThenInclude(t => t.TempColType).FirstOrDefault();
        }

        public IEnumerable<TestTempData> GetTempDataByTempId(int tempId)
        {
            return db.TestTempData.Get().Where(x => x.TestTempID == tempId && x.IsActive == true);
        }

        public bool SaveTemplDataList(List<TestTempData> tempDatas)
        {
            try
            {
                db.TestTempData.InsertList(tempDatas);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
        public bool UpdateTemplateDataList(List<TestTempData> templateData)
        {
            try
            {
                db.TestTempData.UpdateList(templateData);
                db.TestTemplateData.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                //return false;
            }
        }

    }
}
