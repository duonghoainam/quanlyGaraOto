using System;
using System.Collections.ObjectModel;
using NUnit.Framework;
using QuanLyGaraOto.Model;
using QuanLyGaraOto.ViewModel;

namespace UnitTest_GaraOto
{
    [TestFixture]
    public class CheckValueSupplierTest
    {
        private _MainFunction _functionTest;
        private ObservableCollection<SUPPLIER> _listSuppliers;
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
        }
        [Test]
        public void checkValueSupplierUTCID01_Test()
        {
            string name = null;
            string phone = "0123564923";
            string email = "congtyA@gmail.com";
            bool add_Result = _functionTest.checkValueSupplier(name, phone, email, _listSuppliers);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueSupplierUTCID02_Test()
        {
            string name = "Công ty A";
            string phone = null;
            string email = "congtyA@gmail.com";
            bool add_Result = _functionTest.checkValueSupplier(name, phone, email, _listSuppliers);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueSupplierUTCID03_Test()
        {
            string name = "Công ty A";
            string phone = "0123564923";
            string email = null;
            bool add_Result = _functionTest.checkValueSupplier(name, phone, email, _listSuppliers);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueSupplierUTCID04_Test()
        {
            string name = "";
            string phone = "0123564923";
            string email = "congtyA@gmail.com";
            bool add_Result = _functionTest.checkValueSupplier(name, phone, email, _listSuppliers);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueSupplierUTCID05_Test()
        {
            string name = "Công ty A";
            string phone = "";
            string email = "congtyA@gmail.com";
            bool add_Result = _functionTest.checkValueSupplier(name, phone, email, _listSuppliers);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueSupplierUTCID06_Test()
        {
            string name = "Công ty A";
            string phone = "0123564923";
            string email = "";
            bool add_Result = _functionTest.checkValueSupplier(name, phone, email, _listSuppliers);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueSupplierUTCID07_Test()
        {
            string name = "Vật Tư ABC";
            string phone = "0123564923";
            string email = "congtyA@gmail.com";
            bool add_Result = _functionTest.checkValueSupplier(name, phone, email, _listSuppliers);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueSupplierUTCID08_Test()
        {
            string name = "Công ty A";
            string phone = "a1234";
            string email = "congtyA@gmail.com";
            bool add_Result = _functionTest.checkValueSupplier(name, phone, email, _listSuppliers);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueSupplierUTCID09_Test()
        {
            string name = "Công ty A";
            string phone = "0123564923";
            string email = "congtyA@gmail.com";
            bool add_Result = _functionTest.checkValueSupplier(name, phone, email, _listSuppliers);
            Assert.That(add_Result, Is.EqualTo(true));
        }
    }
}
