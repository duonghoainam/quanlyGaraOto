using System;
using System.Collections.ObjectModel;
using NUnit.Framework;
using QuanLyGaraOto.Model;
using QuanLyGaraOto.ViewModel;

namespace UnitTest_GaraOto
{
    [TestFixture]
    public class CheckValueWageTest
    {
        private _MainFunction _functionTest;
        private ObservableCollection<WAGE> _listWages;

        [SetUp]
        public void Setup()
        {
            _functionTest = new _MainFunction();
            _listWages = new ObservableCollection<WAGE>()
            {
                new WAGE(){ Wage_Name = "Vật Tư Việt Phát",},
                new WAGE(){ Wage_Name = "Vật Tư ABC",},
                new WAGE(){ Wage_Name = "Vật Tư Thành Công",},
            };
        }

        [Test]
        public void checkValueWageUTCID01_Test()
        {
            string name = "Vật Tư X";
            string value = "1000";
            bool add_Result = _functionTest.checkValueWage(name, value, _listWages);
            Assert.That(add_Result, Is.EqualTo(true));
        }
        [Test]
        public void checkValueWageUTCID02_Test()
        {
            string name = "Vật Tư X";
            string value = "a";
            bool add_Result = _functionTest.checkValueWage(name, value, _listWages);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueWageUTCID03_Test()
        {
            string name = "Vật Tư X";
            string value = "";
            bool add_Result = _functionTest.checkValueWage(name, value, _listWages);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueWageUTCID04_Test()
        {
            string name = "";
            string value = "1000";
            bool add_Result = _functionTest.checkValueWage(name, value, _listWages);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueWageUTCID05_Test()
        {
            string name = "Vật Tư X";
            string value = "-1000";
            bool add_Result = _functionTest.checkValueWage(name, value, _listWages);
            Assert.That(add_Result, Is.EqualTo(false));
        }
    }
}
