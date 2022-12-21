using System;
using System.Collections.ObjectModel;
using NUnit.Framework;
using QuanLyGaraOto.Model;
using QuanLyGaraOto.ViewModel;
using System.Collections.Generic;

namespace UnitTest_GaraOto
{
    [TestFixture]
    public class CheckValueImportSuppliesTest
    {
        private _MainFunction _functionTest;
        private List<string> _listInputImportDates;
        private List<string> _listInputSuppliers;
        private List<bool> _listExpectedOutputs;

        [SetUp]
        public void Setup()
        {
            _functionTest = new _MainFunction();

            _listInputImportDates = new List<string>()
            {
                DateTime.Today.ToString(),
                DateTime.Today.AddDays(-1).ToString(),
                "abc",
                null,
            };
            _listInputSuppliers = new List<string>()
            {
                "Vật tư ABC",
                null,
            };

            _listExpectedOutputs = new List<bool>()
            {
                true,
                false,
            };
        }

        [Test]
        public void checkValueImportSuppliesUTCID01_Test()
        {
            bool add_Result = _functionTest.checkValueImportSupplies(
                    _listInputImportDates[0],
                    _listInputSuppliers[0]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[0]));
        }
        [Test]
        public void checkValueImportSuppliesUTCID02_Test()
        {
            bool add_Result = _functionTest.checkValueImportSupplies(
                    _listInputImportDates[1],
                    _listInputSuppliers[0]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueImportSuppliesUTCID03_Test()
        {
            bool add_Result = _functionTest.checkValueImportSupplies(
                    _listInputImportDates[2],
                    _listInputSuppliers[0]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueImportSuppliesUTCID04_Test()
        {
            bool add_Result = _functionTest.checkValueImportSupplies(
                    _listInputImportDates[3],
                    _listInputSuppliers[0]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueImportSuppliesUTCID05_Test()
        {
            bool add_Result = _functionTest.checkValueImportSupplies(
                    _listInputImportDates[0],
                    _listInputSuppliers[1]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
    }
}
