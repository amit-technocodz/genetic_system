using Repository.UnitOfWork;
using Service.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class TestTempService : ITestTempService
    {
        private IUnitOfWork db;
        public TestTempService(IUnitOfWork db)
        {
            this.db = db;
        }
    }
}
