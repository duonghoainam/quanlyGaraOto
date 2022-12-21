using System;
using System.Collections.ObjectModel;
using NUnit.Framework;
using QuanLyGaraOto.Model;
using QuanLyGaraOto.ViewModel;
using System.Collections.Generic;

namespace UnitTest_GaraOto
{
    [TestFixture]
    public class CheckValueSuppliesTest
    {
        private _MainFunction _functionTest;
        private ObservableCollection<SUPPLIES> _listSupplies;
        private List<string> _listInputNames;
        private List<string> _listInputPrices;
        private List<bool> _listExpectedOutputs;

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

            _listInputNames = new List<string>()
            {
                "Bánh xe loại 2",
                "Bánh xe",
                "!@#$%",
                null,
            };
            _listInputPrices = new List<string>()
            {
                "200000",
                "zxcvbnm",
                null,
            };

            _listExpectedOutputs = new List<bool>()
            {
                true,
                false,
            };
        }

        [Test]
        public void checkValueSuppliesUTCID01_Test()
        {
            bool add_Result = _functionTest.checkValueSupplies(
                    _listInputNames[0],
                    _listInputPrices[0], 
                    _listSupplies
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[0]));
        }
        [Test]
        public void checkValueSuppliesUTCID02_Test()
        {
            bool add_Result = _functionTest.checkValueSupplies(
                    _listInputNames[1],
                    _listInputPrices[0],
                    _listSupplies
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueSuppliesUTCID03_Test()
        {
            bool add_Result = _functionTest.checkValueSupplies(
                    _listInputNames[2],
                    _listInputPrices[0],
                    _listSupplies
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueSuppliesUTCID04_Test()
        {
            bool add_Result = _functionTest.checkValueSupplies(
                    _listInputNames[3],
                    _listInputPrices[0],
                    _listSupplies
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueSuppliesUTCID05_Test()
        {
            bool add_Result = _functionTest.checkValueSupplies(
                    _listInputNames[0],
                    _listInputPrices[1],
                    _listSupplies
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueSuppliesUTCID06_Test()
        {
            bool add_Result = _functionTest.checkValueSupplies(
                    _listInputNames[0],
                    _listInputPrices[2],
                    _listSupplies
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
    }
}
