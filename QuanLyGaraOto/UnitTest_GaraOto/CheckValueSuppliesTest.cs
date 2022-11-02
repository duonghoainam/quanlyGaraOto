using System;
using System.Collections.ObjectModel;
using NUnit.Framework;
using QuanLyGaraOto.Model;
using QuanLyGaraOto.ViewModel;

namespace UnitTest_GaraOto
{
    [TestFixture]
    public class CheckValueSuppliesTest
    {
        private _MainFunction _functionTest;
        private ObservableCollection<SUPPLIES> _listSupplies;

        [SetUp]
        public void Setup()
        {
            _functionTest = new _MainFunction();
            _listSupplies = new ObservableCollection<SUPPLIES>()
            {
                new SUPPLIES(){ Supplies_Name = "Bánh Xe",},
                new SUPPLIES(){ Supplies_Name = "Kính Hậu",},
                new SUPPLIES(){ Supplies_Name = "Nắp Capo",},
            };
        }

        [Test]
        public void checkValueSuppliesUTCID01_Test()
        {
            string name = "";
            string price = "10000";
            bool add_Result = _functionTest.checkValueSupplies(name, price, _listSupplies);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueSuppliesUTCID02_Test()
        {
            string name = "Bánh xe";
            string price = "a";
            bool add_Result = _functionTest.checkValueSupplies(name, price, _listSupplies);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueSuppliesUTCID03_Test()
        {
            string name = "Bánh xe";
            string price = "";
            bool add_Result = _functionTest.checkValueSupplies(name, price, _listSupplies);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueSuppliesUTCID06_Test()
        {
            string name = "Bánh xe";
            string price = "1000";
            bool add_Result = _functionTest.checkValueSupplies(name, price, _listSupplies);
            Assert.That(add_Result, Is.EqualTo(true));
        }
        [Test]
        public void checkValueSuppliesUTCID07_Test()
        {
            string name = "Bánh xe";
            string price = "-1000";
            bool add_Result = _functionTest.checkValueSupplies(name, price, _listSupplies);
            Assert.That(add_Result, Is.EqualTo(false));
        }
    }
}
