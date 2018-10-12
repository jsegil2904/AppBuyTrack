using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.DataAccess.Interfaces;
using App.DataAccess.Repository;
using System.Data.Entity;
using App.Entities.Base;
using System.Linq;

namespace App.UnitTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        private readonly DbContext dbContext;
        private readonly ICustomerRepository customerRepository;
        private readonly IUnitOfWork unitOfWork;

        public CustomerRepositoryTest()
        {
            dbContext = new AppModelDB();
            customerRepository = new CustomerRepository(dbContext);
            unitOfWork = new UnitOfWork(dbContext);
        }

        [TestMethod]
        public void GetByName()
        {

            var cantidad = customerRepository.GetListByName("Emma").Count();
            Assert.IsTrue(cantidad>0, "OK");
        }
    }
}
