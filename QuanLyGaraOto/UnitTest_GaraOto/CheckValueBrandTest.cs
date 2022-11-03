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

        [SetUp]
        public void Setup() { 
            _functionTest = new _MainFunction();
            _listCarBrands = new ObservableCollection<CAR_BRAND>()
            {
                new CAR_BRAND(){ CarBrand_Name = "KIA"},
                new CAR_BRAND(){ CarBrand_Name = "Toyota"},
                new CAR_BRAND(){ CarBrand_Name = "Mazda"},

            };
        }

        [Test]
        public void checkValueBrandUTCID01_Test()
        {
            bool add_Result = _functionTest.checkValueBrand("Vinfast", _listCarBrands);
            Assert.That(add_Result, Is.EqualTo(true));
        }
        [Test]
        public void checkValueBrandUTCID02_Test()
        {
            bool add_Result = _functionTest.checkValueBrand("KIA", _listCarBrands);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueBrandUTCID03_Test()
        {
            bool add_Result = _functionTest.checkValueBrand("", _listCarBrands);
            Assert.That(add_Result, Is.EqualTo(false));
        }
    }
}
