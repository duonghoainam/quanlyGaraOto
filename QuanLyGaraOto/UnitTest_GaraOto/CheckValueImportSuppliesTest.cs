using System;
using System.Collections.ObjectModel;
using NUnit.Framework;
using QuanLyGaraOto.Model;
using QuanLyGaraOto.ViewModel;

namespace UnitTest_GaraOto
{
    [TestFixture]
    public class CheckValueImportSuppliesTest
    {
        private _MainFunction _functionTest;

        [SetUp]
        public void Setup()
        {
            _functionTest = new _MainFunction();
        }

        [Test]
        public void checkValueImportSuppliesUTCID01_Test()
        {
            string importDate = "";
            string supplier = "";
            bool add_Result = _functionTest.checkValueImportSupplies(importDate, supplier);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueImportSuppliesUTCID02_Test()
        {
            string importDate = "abc";
            string supplier = "";
            bool add_Result = _functionTest.checkValueImportSupplies(importDate, supplier);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueImportSuppliesUTCID03_Test()
        {
            string importDate = DateTime.Now.ToString();
            string supplier = "";
            bool add_Result = _functionTest.checkValueImportSupplies(importDate, supplier);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueImportSuppliesUTCID04_Test()
        {
            string importDate = DateTime.Now.AddDays(-1).ToString();
            string supplier = "";
            bool add_Result = _functionTest.checkValueImportSupplies(importDate, supplier);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueImportSuppliesUTCID05_Test()
        {
            string importDate = DateTime.Now.AddDays(1).ToString();
            string supplier = "";
            bool add_Result = _functionTest.checkValueImportSupplies(importDate, supplier);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueImportSuppliesUTCID06_Test()
        {
            string importDate = "";
            string supplier = "Vật Tư ABC";
            bool add_Result = _functionTest.checkValueImportSupplies(importDate, supplier);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueImportSuppliesUTCID07_Test()
        {
            string importDate = "abc";
            string supplier = "Vật Tư ABC";
            bool add_Result = _functionTest.checkValueImportSupplies(importDate, supplier);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueImportSuppliesUTCID08_Test()
        {
            string importDate = DateTime.Now.ToString();
            string supplier = "Vật Tư ABC";
            
            bool add_Result = _functionTest.checkValueImportSupplies(importDate, supplier);
            Assert.That(add_Result, Is.EqualTo(true));
        }
        [Test]
        public void checkValueImportSuppliesUTCID09_Test()
        {
            string importDate = DateTime.Now.AddDays(-1).ToString();
            string supplier = "Vật Tư ABC";
            
            bool add_Result = _functionTest.checkValueImportSupplies(importDate, supplier);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueImportSuppliesUTCID10_Test()
        {
            string importDate = DateTime.Now.AddDays(1).ToString();
            string supplier = "Vật Tư ABC";
            
            bool add_Result = _functionTest.checkValueImportSupplies(importDate, supplier);
            Assert.That(add_Result, Is.EqualTo(false));
        }
    }
}
