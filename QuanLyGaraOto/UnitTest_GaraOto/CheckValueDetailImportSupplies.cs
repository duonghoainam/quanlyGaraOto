using System;
using System.Collections.ObjectModel;
using NUnit.Framework;
using QuanLyGaraOto.Model;
using QuanLyGaraOto.ViewModel;

namespace UnitTest_GaraOto
{
    [TestFixture]
    public class CheckValueDetailImportSupplies
    {
        private _MainFunction _functionTest;

        [SetUp]
        public void Setup()
        {
            _functionTest = new _MainFunction();
        }

        [Test]
        public void checkValueDetailImportSuppliesUTCID01_Test()
        {
            string name = "";
            string price = "250000";
            string amount = "3";
            bool add_Result = _functionTest.checkValueDetailImportSupplies(name, price, amount);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueDetailImportSuppliesUTCID02_Test()
        {
            string name = "Sơn XY";
            string price = "";
            string amount = "3";
            bool add_Result = _functionTest.checkValueDetailImportSupplies(name, price, amount);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueDetailImportSuppliesUTCID03_Test()
        {
            string name = "Sơn XY";
            string price = "250000";
            string amount = "";
            bool add_Result = _functionTest.checkValueDetailImportSupplies(name, price, amount);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueDetailImportSuppliesUTCID04_Test()
        {
            string name = "Sơn XY";
            string price = "abc";
            string amount = "3";
            bool add_Result = _functionTest.checkValueDetailImportSupplies(name, price, amount);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueDetailImportSuppliesUTCID05_Test()
        {
            string name = "Sơn XY";
            string price = "10000";
            string amount = "abc";
            bool add_Result = _functionTest.checkValueDetailImportSupplies(name, price, amount);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueDetailImportSuppliesUTCID06_Test()
        {
            string name = "Sơn XY";
            string price = "-1";
            string amount = "0";
            bool add_Result = _functionTest.checkValueDetailImportSupplies(name, price, amount);
            Assert.That(add_Result, Is.EqualTo(true));
        }
        [Test]
        public void checkValueDetailImportSuppliesUTCID07_Test()
        {
            string name = "Sơn XY";
            string price = "0";
            string amount = "0";
            bool add_Result = _functionTest.checkValueDetailImportSupplies(name, price, amount);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueDetailImportSuppliesUTCID08_Test()
        {
            string name = "Sơn XY";
            string price = "10000";
            string amount = "abc";
            bool add_Result = _functionTest.checkValueDetailImportSupplies(name, price, amount);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueDetailImportSuppliesUTCID09_Test()
        {
            string name = "Sơn XY";
            string price = "10000";
            string amount = "-1";
            bool add_Result = _functionTest.checkValueDetailImportSupplies(name, price, amount);
            Assert.That(add_Result, Is.EqualTo(true));
        }
        [Test]
        public void checkValueDetailImportSuppliesUTCID10_Test()
        {
            string name = "Sơn XY";
            string price = "10000";
            string amount = "0";
            bool add_Result = _functionTest.checkValueDetailImportSupplies(name, price, amount);
            Assert.That(add_Result, Is.EqualTo(true));
        }
    }
}
