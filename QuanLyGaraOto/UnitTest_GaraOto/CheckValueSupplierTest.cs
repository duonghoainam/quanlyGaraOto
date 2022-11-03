using System;
using System.Collections.ObjectModel;
using NUnit.Framework;
using QuanLyGaraOto.Model;
using QuanLyGaraOto.ViewModel;
using System.Collections.Generic;

namespace UnitTest_GaraOto
{
    [TestFixture]
    public class CheckValueSupplierTest
    {
        private _MainFunction _functionTest;
        private ObservableCollection<SUPPLIER> _listSuppliers;
        private List<string> _listInputNames;
        private List<string> _listInputPhones;
        private List<string> _listInputEmails;
        private List<bool> _listExpectedOutputs;

        [SetUp]
        public void Setup()
        {
            _functionTest = new _MainFunction();
            _listSuppliers = new ObservableCollection<SUPPLIER>()
            {
                new SUPPLIER(){ Supplier_Name = "Vật Tư Việt Phát",},
                new SUPPLIER(){ Supplier_Name = "Vật Tư ABC",},
                new SUPPLIER(){ Supplier_Name = "Vật Tư Thành Công",},

            };

            _listInputNames = new List<string>()
            {
                null,
                "",
                "Công ty A",
                "Vật Tư ABC",
            };
            _listInputPhones = new List<string>()
            {
                null,
                "",
                "a1234",
                "1234564923",
            };
            _listInputEmails = new List<string>()
            {
                null,
                "",
                "congtyA@gmail.com",
            };

            _listExpectedOutputs = new List<bool>()
            {
                true,
                false,
            };
        }
        [Test]
        public void checkValueSupplierUTCID01_Test()
        {
            bool add_Result = _functionTest.checkValueSupplier(
                    _listInputNames[0],
                    _listInputPhones[3],
                    _listInputEmails[2],
                    _listSuppliers
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueSupplierUTCID02_Test()
        {
            bool add_Result = _functionTest.checkValueSupplier(
                    _listInputNames[2],
                    _listInputPhones[0],
                    _listInputEmails[2],
                    _listSuppliers
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueSupplierUTCID03_Test()
        {
            bool add_Result = _functionTest.checkValueSupplier(
                    _listInputNames[2],
                    _listInputPhones[3],
                    _listInputEmails[0],
                    _listSuppliers
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueSupplierUTCID04_Test()
        {
            bool add_Result = _functionTest.checkValueSupplier(
                    _listInputNames[1],
                    _listInputPhones[3],
                    _listInputEmails[2],
                    _listSuppliers
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueSupplierUTCID05_Test()
        {
            bool add_Result = _functionTest.checkValueSupplier(
                    _listInputNames[2],
                    _listInputPhones[1],
                    _listInputEmails[2],
                    _listSuppliers
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueSupplierUTCID06_Test()
        {
            bool add_Result = _functionTest.checkValueSupplier(
                    _listInputNames[2],
                    _listInputPhones[3],
                    _listInputEmails[1],
                    _listSuppliers
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueSupplierUTCID07_Test()
        {
            bool add_Result = _functionTest.checkValueSupplier(
                    _listInputNames[3],
                    _listInputPhones[3],
                    _listInputEmails[2],
                    _listSuppliers
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueSupplierUTCID08_Test()
        {
            bool add_Result = _functionTest.checkValueSupplier(
                    _listInputNames[2],
                    _listInputPhones[2],
                    _listInputEmails[2],
                    _listSuppliers
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueSupplierUTCID09_Test()
        {
            bool add_Result = _functionTest.checkValueSupplier(
                    _listInputNames[2],
                    _listInputPhones[3],
                    _listInputEmails[2],
                    _listSuppliers
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[0]));
        }
    }
}
