using System;
using System.Collections.ObjectModel;
using NUnit.Framework;
using QuanLyGaraOto.Model;
using QuanLyGaraOto.ViewModel;

namespace UnitTest_GaraOto
{
    [TestFixture]
    public class CheckValueDetailRepairTest
    {
        private _MainFunction _functionTest;

        [SetUp]
        public void Setup()
        {
            _functionTest = new _MainFunction();   
        }

        [Test]
        public void checkValueDetailRepairUTCID01_Test()
        {
            string name = "Thay phụ tùng";
            string supplies = "Bánh xe";
            string amount = "1";
            string wage = "Thay phụ tùng";
            _MainFunction functionTest = new _MainFunction();
            bool add_Result = functionTest.checkValueDetailRepair(name, supplies, amount, wage);
            Assert.That(add_Result, Is.EqualTo(true));
        }
        [Test]
        public void checkValueDetailRepairUTCID02_Test()
        {
            string name = "";
            string supplies = "Bánh xe";
            string amount = "1";
            string wage = "Thay phụ tùng";
            _MainFunction functionTest = new _MainFunction();
            bool add_Result = functionTest.checkValueDetailRepair(name, supplies, amount, wage);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueDetailRepairUTCID03_Test()
        {
            string name = "Thay phụ tùng";
            string supplies = "";
            string amount = "1";
            string wage = "Thay phụ tùng";
            _MainFunction functionTest = new _MainFunction();
            bool add_Result = functionTest.checkValueDetailRepair(name, supplies, amount, wage);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueDetailRepairUTCID04_Test()
        {
            string name = "Thay phụ tùng";
            string supplies = "Bánh xe";
            string amount = "0";
            string wage = "Thay phụ tùng";
            _MainFunction functionTest = new _MainFunction();
            bool add_Result = functionTest.checkValueDetailRepair(name, supplies, amount, wage);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueDetailRepairUTCID05_Test()
        {
            string name = "Thay phụ tùng";
            string supplies = "Bánh xe";
            string amount = "1";
            string wage = "";
            _MainFunction functionTest = new _MainFunction();
            bool add_Result = functionTest.checkValueDetailRepair(name, supplies, amount, wage);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueDetailRepairUTCID06_Test()
        {
            string name = "";
            string supplies = "";
            string amount = "0";
            string wage = "";
            _MainFunction functionTest = new _MainFunction();
            bool add_Result = functionTest.checkValueDetailRepair(name, supplies, amount, wage);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueDetailRepairUTCID07_Test()
        {
            string name = "Thay phụ tùng";
            string supplies = "Bánh xe";
            string amount = "";
            string wage = "Thay phụ tùng";
            _MainFunction functionTest = new _MainFunction();
            bool add_Result = functionTest.checkValueDetailRepair(name, supplies, amount, wage);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueDetailRepairUTCID08_Test()
        {
            string name = "";
            string supplies = "";
            string amount = "";
            string wage = "";
            _MainFunction functionTest = new _MainFunction();
            bool add_Result = functionTest.checkValueDetailRepair(name, supplies, amount, wage);
            Assert.That(add_Result, Is.EqualTo(false));
        }
    }
}
