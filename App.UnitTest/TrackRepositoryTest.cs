using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using App.DataAccess.Interfaces;
using App.DataAccess.Repository;
using System.Linq;

namespace App.UnitTest
{
    /// <summary>
    /// Summary description for TrackRepositoryTest
    /// </summary>
    [TestClass]
    public class TrackRepositoryTest
    {

        private readonly DbContext dbContext;
        private readonly ITrackRepository trackRepository;
        private readonly IUnitOfWork unitOfWork;
        public TrackRepositoryTest()
        {
            dbContext = new AppModelDB();
            trackRepository = new TrackRepository(dbContext);
            unitOfWork = new UnitOfWork(dbContext);
        }

       // private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void GetTracksByName()
        {

            var cantidad = trackRepository.GetTracksByName("What").Count();
            Assert.IsTrue(cantidad > 0, "OK");
        }
    }
}
