using NUnit.Framework;
using QuanLyGaraOto.Model;
using QuanLyGaraOto.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace UnitTest_GaraOto
{
    [TestFixture]
    public class CheckValueBrandTest
    {
        private _MainFunction _functionTest;
        private ObservableCollection<CAR_BRAND> _listCarBrands;
        private List<string> _listInputNames;
        private List<bool> _listExpectedOutputs;

        [SetUp]
        public void Setup() { 
            _functionTest = new _MainFunction();
            _listCarBrands = new ObservableCollection<CAR_BRAND>()
            {
                new CAR_BRAND(){ CarBrand_Name = "KIA"},
                new CAR_BRAND(){ CarBrand_Name = "Toyota"},
                new CAR_BRAND(){ CarBrand_Name = "Mazda"},

            };
            _listInputNames = new List<string>()
            {
                "Vinfast",
                "KIA",
                "&#%",
                "",
                null,
            };
            _listExpectedOutputs = new List<bool>() { 
                true,
                false ,
            };
        }

        [Test]
        public void checkValueBrandUTCID01_Test()
        {
            bool add_Result = _functionTest.checkValueBrand(
                    _listInputNames[0],
                    _listCarBrands
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[0]));
        }
        [Test]
        public void checkValueBrandUTCID02_Test()
        {
            bool add_Result = _functionTest.checkValueBrand(
                    _listInputNames[1],
                    _listCarBrands
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueBrandUTCID03_Test()
        {
            bool add_Result = _functionTest.checkValueBrand(
                    _listInputNames[2],
                    _listCarBrands
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueBrandUTCID04_Test()
        {
            bool add_Result = _functionTest.checkValueBrand(
                    _listInputNames[3],
                    _listCarBrands
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueBrandUTCID05_Test()
        {
            bool add_Result = _functionTest.checkValueBrand(
                    _listInputNames[4],
                    _listCarBrands
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
    }
}
