using System;
using System.Collections.ObjectModel;
using NUnit.Framework;
using QuanLyGaraOto.Model;
using QuanLyGaraOto.ViewModel;
using System.Collections.Generic;

namespace UnitTest_GaraOto
{
    [TestFixture]
    public class CheckValueWageTest
    {
        private _MainFunction _functionTest;
        private ObservableCollection<WAGE> _listWages;
        private List<string> _listInputValues;
        private List<string> _listInputNames;
        private List<bool> _listExpectedOutputs;

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

            _listInputNames = new List<string>()
            {
                "Vật tư Sơn Hà",
                "",
            };
            _listInputValues = new List<string>()
            {
                "100000",
                "a",
                "",
                "-100000",
            };

            _listExpectedOutputs = new List<bool>()
            {
                false,
                true,
            };
        }

        [Test]
        public void checkValueWageUTCID01_Test()
        {
            bool add_Result = _functionTest.checkValueWage(
                    _listInputNames[0],
                    _listInputValues[0], 
                    _listWages
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueWageUTCID02_Test()
        {
            bool add_Result = _functionTest.checkValueWage(
                    _listInputNames[0],
                    _listInputValues[1],
                    _listWages
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[0]));
        }
        [Test]
        public void checkValueWageUTCID03_Test()
        {
            bool add_Result = _functionTest.checkValueWage(
                     _listInputNames[0],
                     _listInputValues[2],
                     _listWages
                 );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[0]));
        }
        [Test]
        public void checkValueWageUTCID04_Test()
        {
            bool add_Result = _functionTest.checkValueWage(
                    _listInputNames[1],
                    _listInputValues[0],
                    _listWages
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[0]));
        }
        [Test]
        public void checkValueWageUTCID05_Test()
        {
            bool add_Result = _functionTest.checkValueWage(
                    _listInputNames[0],
                    _listInputValues[3],
                    _listWages
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[0]));
        }
    }
}
