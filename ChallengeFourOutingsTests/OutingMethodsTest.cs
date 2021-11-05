using ChallengeFourOutingsLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChallengeFourOutingsTests
{
    [TestClass]
    public class OutingMethodsTest
    {
        OutingRepo _outingRepo = new OutingRepo();
        Outing _testOuting = new Outing();

        [TestInitialize]

        public void Arrange()
        {
            _testOuting = new Outing(EventType.AmusementPark, 100, DateTime.Today, 150m, 15000m);
            _outingRepo.AddOuting(_testOuting);
        }

        [TestMethod]
        public void Test_AddOuting()
        {
            Outing outing = new Outing();
            OutingRepo outingRepo = new OutingRepo();

            bool success = outingRepo.AddOuting(outing);

            Assert.IsTrue(success);
        }
        [TestMethod]
        public void Test_OutingList()
        { 
                int intialCount = _outingRepo.OutingList().Count;
                Assert.AreEqual(intialCount, 1);
                Assert.AreNotEqual(intialCount, 2);
           
        }
    }
}
