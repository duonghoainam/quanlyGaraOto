using System;
using System.Collections.ObjectModel;
using NUnit.Framework;
using QuanLyGaraOto.Model;
using QuanLyGaraOto.ViewModel;
using System.Collections.Generic;

namespace UnitTest_GaraOto
{
    [TestFixture]
    public class CheckValueDetailImportSuppliesTest
    {
        private _MainFunction _functionTest;
        private List<string> _listInputNames;
        private List<string> _listInputPrices;
        private List<string> _listInputAmounts;
        private List<bool> _listExpectedOutputs;

        [SetUp]
        public void Setup()
        {
            _functionTest = new _MainFunction();

            _listInputNames = new List<string>()
            {
                "",
                "Nhớt Alpha Boost",
            };
            _listInputPrices = new List<string>()
            {
                "",
                "abc",
                "-1",
                "0",
                "10000",
            };
            _listInputAmounts = new List<string>()
            {
                "",
                "abc",
                "-1",
                "0",
            };

            _listExpectedOutputs = new List<bool>()
            {
                true,
                false,
            };
        }

        [Test]
        public void checkValueDetailImportSuppliesUTCID01_Test()
        {
            bool add_Result = _functionTest.checkValueDetailImportSupplies(
                _listInputNames[0],
                _listInputPrices[4],
                _listInputAmounts[3]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueDetailImportSuppliesUTCID02_Test()
        {
            bool add_Result = _functionTest.checkValueDetailImportSupplies(
                _listInputNames[1],
                _listInputPrices[0],
                _listInputAmounts[3]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueDetailImportSuppliesUTCID03_Test()
        {
            bool add_Result = _functionTest.checkValueDetailImportSupplies(
                _listInputNames[1],
                _listInputPrices[4],
                _listInputAmounts[0]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueDetailImportSuppliesUTCID04_Test()
        {
            bool add_Result = _functionTest.checkValueDetailImportSupplies(
                _listInputNames[1],
                _listInputPrices[1],
                _listInputAmounts[3]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueDetailImportSuppliesUTCID05_Test()
        {
            bool add_Result = _functionTest.checkValueDetailImportSupplies(
                 _listInputNames[1],
                 _listInputPrices[4],
                 _listInputAmounts[1]
                 );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueDetailImportSuppliesUTCID06_Test()
        {
            bool add_Result = _functionTest.checkValueDetailImportSupplies(
                _listInputNames[1],
                _listInputPrices[2],
                _listInputAmounts[3]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[0]));
        }
        [Test]
        public void checkValueDetailImportSuppliesUTCID07_Test()
        {
            bool add_Result = _functionTest.checkValueDetailImportSupplies(
                _listInputNames[1],
                _listInputPrices[3],
                _listInputAmounts[3]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueDetailImportSuppliesUTCID08_Test()
        {
            bool add_Result = _functionTest.checkValueDetailImportSupplies(
                _listInputNames[1],
                _listInputPrices[4],
                _listInputAmounts[1]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueDetailImportSuppliesUTCID09_Test()
        {
            bool add_Result = _functionTest.checkValueDetailImportSupplies(
                _listInputNames[1],
                _listInputPrices[4],
                _listInputAmounts[2]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[0]));
        }
        [Test]
        public void checkValueDetailImportSuppliesUTCID10_Test()
        {
            bool add_Result = _functionTest.checkValueDetailImportSupplies(
                 _listInputNames[1],
                 _listInputPrices[4],
                 _listInputAmounts[3]
                 );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[0]));
        }
    }
}
