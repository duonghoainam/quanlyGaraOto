using System;
using System.Collections.ObjectModel;
using NUnit.Framework;
using QuanLyGaraOto.Model;
using QuanLyGaraOto.ViewModel;

namespace UnitTest_GaraOto
{
    [TestFixture]
    public class CheckValueRepairTest
    {
        private _MainFunction _functionTest;

        [SetUp]
        public void Setup()
        {
            _functionTest = new _MainFunction();
        }

        [Test]
        public void checkValueRepairUTCID01_Test()
        {
            string idReception = "1";
            string repairDate = "08/11/2023";
            bool add_Result = _functionTest.checkValueRepair(idReception, repairDate);
            Assert.That(add_Result, Is.EqualTo(true));
        }
        [Test]
        public void checkValueRepairUTCID02_Test()
        {
            string idReception = "";
            string repairDate = "08/11/2023";
            bool add_Result = _functionTest.checkValueRepair(idReception, repairDate);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueRepairUTCID03_Test()
        {
            string idReception = null;
            string repairDate = "08/11/2023";
            bool add_Result = _functionTest.checkValueRepair(idReception, repairDate);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueRepairUTCID04_Test()
        {
            string idReception = "1";
            string repairDate = "";
            bool add_Result = _functionTest.checkValueRepair(idReception, repairDate);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueRepairUTCID05_Test()
        {
            string idReception = "";
            string repairDate = "";
            bool add_Result = _functionTest.checkValueRepair(idReception, repairDate);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueRepairUTCID06_Test()
        {
            string idReception = null;
            string repairDate = "";
            bool add_Result = _functionTest.checkValueRepair(idReception, repairDate);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueRepairUTCID07_Test()
        {
            string idReception = "1";
            string repairDate = "10/19/2021";
            bool add_Result = _functionTest.checkValueRepair(idReception, repairDate);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueRepairUTCID08_Test()
        {
            string idReception = "";
            string repairDate = "08/11/2021";
            bool add_Result = _functionTest.checkValueRepair(idReception, repairDate);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueRepairUTCID09_Test()
        {
            string idReception = null;
            string repairDate = "08/11/2021";
            bool add_Result = _functionTest.checkValueRepair(idReception, repairDate);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueRepairUTCID10_Test()
        {
            string idReception = "1";
            string repairDate = DateTime.Now.ToString();
            bool add_Result = _functionTest.checkValueRepair(idReception, repairDate);
            Assert.That(add_Result, Is.EqualTo(true));
        }
    }
}
