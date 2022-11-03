using System;
using System.Collections.ObjectModel;
using NUnit.Framework;
using QuanLyGaraOto.Model;
using QuanLyGaraOto.ViewModel;
using System.Collections.Generic;

namespace UnitTest_GaraOto
{
    [TestFixture]
    public class CheckValueDetailRepairTest
    {
        private _MainFunction _functionTest;
        private List<string> _listInputContents;
        private List<string> _listInputSupplies;
        private List<string> _listInputAmounts;
        private List<string> _listInputWageTypes;
        private List<bool> _listExpectedOutputs;

        [SetUp]
        public void Setup()
        {
            _functionTest = new _MainFunction();

            _listInputContents = new List<string>()
            {
                "Thay phụ tùng",
                "",
            };
            _listInputSupplies = new List<string>()
            {
                "Bánh xe",
                "",
            };
            _listInputAmounts = new List<string>()
            {
                "2",
                "0",
                "",
            };
            _listInputWageTypes = new List<string>()
            {
                "Thay phụ tùng",
                "",
            };

            _listExpectedOutputs = new List<bool>()
            {
                true,
                false,
            };
        }

        [Test]
        public void checkValueDetailRepairUTCID01_Test()
        {
            bool add_Result = _functionTest.checkValueDetailRepair(
                _listInputContents[0],
                _listInputSupplies[0],
                _listInputAmounts[0],
                _listInputWageTypes[0]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[0]));
        }
        [Test]
        public void checkValueDetailRepairUTCID02_Test()
        {
            bool add_Result = _functionTest.checkValueDetailRepair(
                _listInputContents[1],
                _listInputSupplies[0],
                _listInputAmounts[0],
                _listInputWageTypes[0]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueDetailRepairUTCID03_Test()
        {
            bool add_Result = _functionTest.checkValueDetailRepair(
                _listInputContents[0],
                _listInputSupplies[1],
                _listInputAmounts[0],
                _listInputWageTypes[0]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueDetailRepairUTCID04_Test()
        {
            bool add_Result = _functionTest.checkValueDetailRepair(
                _listInputContents[0],
                _listInputSupplies[0],
                _listInputAmounts[1],
                _listInputWageTypes[0]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueDetailRepairUTCID05_Test()
        {
            bool add_Result = _functionTest.checkValueDetailRepair(
                _listInputContents[0],
                _listInputSupplies[0],
                _listInputAmounts[0],
                _listInputWageTypes[1]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueDetailRepairUTCID06_Test()
        {
            bool add_Result = _functionTest.checkValueDetailRepair(
                _listInputContents[1],
                _listInputSupplies[1],
                _listInputAmounts[1],
                _listInputWageTypes[1]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueDetailRepairUTCID07_Test()
        {
            bool add_Result = _functionTest.checkValueDetailRepair(
                _listInputContents[0],
                _listInputSupplies[0],
                _listInputAmounts[2],
                _listInputWageTypes[0]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueDetailRepairUTCID08_Test()
        {
            bool add_Result = _functionTest.checkValueDetailRepair(
                _listInputContents[1],
                _listInputSupplies[1],
                _listInputAmounts[2],
                _listInputWageTypes[1]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
    }
}
