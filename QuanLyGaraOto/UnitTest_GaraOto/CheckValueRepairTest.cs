using System;
using System.Collections.ObjectModel;
using NUnit.Framework;
using QuanLyGaraOto.Model;
using QuanLyGaraOto.ViewModel;
using System.Collections.Generic;

namespace UnitTest_GaraOto
{
    [TestFixture]
    public class CheckValueRepairTest
    {
        private _MainFunction _functionTest;
        private List<string> _listInputIdReceptions;
        private List<string> _listInputRepairDates;
        private List<bool> _listExpectedOuputs;

        [SetUp]
        public void Setup()
        {
            _functionTest = new _MainFunction();

            _listInputIdReceptions = new List<string>()
            {
                "1",
                "",
                null
            };
            _listInputRepairDates = new List<string>()
            {
                DateTime.Now.AddDays(1).ToString(),
                "",
                DateTime.Now.AddDays(-1).ToString(),
                DateTime.Now.ToString(),
                "abc",
            };

            _listExpectedOuputs = new List<bool>()
            {
                true,
                false,
            };
        }

        [Test]
        public void checkValueRepairUTCID01_Test()
        {
            bool add_Result = _functionTest.checkValueRepair(
                _listInputIdReceptions[0], 
                _listInputRepairDates[0]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOuputs[0]));
        }
        [Test]
        public void checkValueRepairUTCID02_Test()
        {
            bool add_Result = _functionTest.checkValueRepair(
                _listInputIdReceptions[1],
                _listInputRepairDates[0]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOuputs[1]));
        }
        [Test]
        public void checkValueRepairUTCID03_Test()
        {
            bool add_Result = _functionTest.checkValueRepair(
                _listInputIdReceptions[2],
                _listInputRepairDates[0]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOuputs[1]));
        }
        [Test]
        public void checkValueRepairUTCID04_Test()
        {
            bool add_Result = _functionTest.checkValueRepair(
                _listInputIdReceptions[0],
                _listInputRepairDates[1]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOuputs[1]));
        }
        [Test]
        public void checkValueRepairUTCID05_Test()
        {
            bool add_Result = _functionTest.checkValueRepair(
                _listInputIdReceptions[1],
                _listInputRepairDates[1]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOuputs[1]));
        }
        [Test]
        public void checkValueRepairUTCID06_Test()
        {
            bool add_Result = _functionTest.checkValueRepair(
                _listInputIdReceptions[2],
                _listInputRepairDates[1]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOuputs[1]));
        }
        [Test]
        public void checkValueRepairUTCID07_Test()
        {
            bool add_Result = _functionTest.checkValueRepair(
                _listInputIdReceptions[0],
                _listInputRepairDates[2]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOuputs[1]));
        }
        [Test]
        public void checkValueRepairUTCID08_Test()
        {
            bool add_Result = _functionTest.checkValueRepair(
                _listInputIdReceptions[1],
                _listInputRepairDates[2]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOuputs[1]));
        }
        [Test]
        public void checkValueRepairUTCID09_Test()
        {
            bool add_Result = _functionTest.checkValueRepair(
                _listInputIdReceptions[2],
                _listInputRepairDates[2]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOuputs[1]));
        }
        [Test]
        public void checkValueRepairUTCID10_Test()
        {
            bool add_Result = _functionTest.checkValueRepair(
                _listInputIdReceptions[0],
                _listInputRepairDates[3]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOuputs[0]));
        }
        [Test]
        public void checkValueRepairUTCID11_Test()
        {
            bool add_Result = _functionTest.checkValueRepair(
                _listInputIdReceptions[1],
                _listInputRepairDates[3]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOuputs[1]));
        }
        [Test]
        public void checkValueRepairUTCID12_Test()
        {
            bool add_Result = _functionTest.checkValueRepair(
                _listInputIdReceptions[2],
                _listInputRepairDates[3]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOuputs[1]));
        }
        [Test]
        public void checkValueRepairUTCID13_Test()
        {
            bool add_Result = _functionTest.checkValueRepair(
                _listInputIdReceptions[0],
                _listInputRepairDates[4]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOuputs[1]));
        }
        [Test]
        public void checkValueRepairUTCID14_Test()
        {
            bool add_Result = _functionTest.checkValueRepair(
                _listInputIdReceptions[1],
                _listInputRepairDates[4]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOuputs[1]));
        }
        [Test]
        public void checkValueRepairUTCID15_Test()
        {
            bool add_Result = _functionTest.checkValueRepair(
                _listInputIdReceptions[2],
                _listInputRepairDates[4]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOuputs[1]));
        }
    }
}
