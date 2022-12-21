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
                new WAGE(){ Wage_Name = "Lau dọn",},
                new WAGE(){ Wage_Name = "Sửa chữa",},
                new WAGE(){ Wage_Name = "Thay thế phụ tùng",},
            };

            _listInputNames = new List<string>()
            {
                "Nâng cấp",
                "Lau dọn",
                "!@#$%",
                null,
            };
            _listInputValues = new List<string>()
            {
                "50000",
                "!@#$%",
                null,
            };

            _listExpectedOutputs = new List<bool>()
            {
                true,
                false,
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
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[0]));
        }
        [Test]
        public void checkValueWageUTCID02_Test()
        {
            bool add_Result = _functionTest.checkValueWage(
                    _listInputNames[1],
                    _listInputValues[0],
                    _listWages
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueWageUTCID03_Test()
        {
            bool add_Result = _functionTest.checkValueWage(
                    _listInputNames[2],
                    _listInputValues[0],
                    _listWages
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueWageUTCID04_Test()
        {
            bool add_Result = _functionTest.checkValueWage(
                    _listInputNames[3],
                    _listInputValues[0],
                    _listWages
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueWageUTCID05_Test()
        {
            bool add_Result = _functionTest.checkValueWage(
                    _listInputNames[0],
                    _listInputValues[1],
                    _listWages
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueWageUTCID06_Test()
        {
            bool add_Result = _functionTest.checkValueWage(
                    _listInputNames[0],
                    _listInputValues[2],
                    _listWages
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
    }
}
