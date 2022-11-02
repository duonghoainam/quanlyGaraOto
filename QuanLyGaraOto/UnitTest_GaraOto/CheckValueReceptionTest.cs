using System;
using System.Collections.ObjectModel;
using NUnit.Framework;
using QuanLyGaraOto.Model;
using QuanLyGaraOto.ViewModel;

namespace UnitTest_GaraOto
{
    [TestFixture]
    public class CheckValueReceptionTest
    {
        private _MainFunction _functionTest;

        [SetUp]
        public void Setup()
        {
            _functionTest = new _MainFunction();
        }

        [Test]
        public void checkValueReceptionUTCID01_Test()
        {
            string name = "Dat";
            string phone = "099554499";
            string address = "Tien Giang";
            string brand = "Toyota";
            string receptionDate = "10/21/2021";
            string licensePlate = "55-XX-0000";
            bool add_Result = _functionTest.checkValueReception(name, phone,
             address, brand, receptionDate, licensePlate);
            Assert.That(add_Result, Is.EqualTo(true));
        }
        [Test]
        public void checkValueReceptionUTCID02_Test()
        {
            string name = "";
            string phone = "099554499";
            string address = "Tien Giang";
            string brand = "Toyota";
            string receptionDate = "10/21/2021";
            string licensePlate = "55-XX-0000";
            bool add_Result = _functionTest.checkValueReception(name, phone,
             address, brand, receptionDate, licensePlate);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueReceptionUTCID03_Test()
        {
            string name = "Dat";
            string phone = "099554499";
            string address = "Tien Giang";
            string brand = "Toyota";
            string receptionDate = "10/21/2021";
            string licensePlate = "";
            bool add_Result = _functionTest.checkValueReception(name, phone,
             address, brand, receptionDate, licensePlate);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueReceptionUTCID04_Test()
        {
            string name = "Dat";
            string phone = "099554499";
            string address = "Tien Giang";
            string brand = "";
            string receptionDate = "10/21/2021";
            string licensePlate = "55-XX-0000";
            bool add_Result = _functionTest.checkValueReception(name, phone,
             address, brand, receptionDate, licensePlate);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueReceptionUTCID05_Test()
        {
            string name = "Dat";
            string phone = "099554499";
            string address = "";
            string brand = "Toyota";
            string receptionDate = "10/21/2021";
            string licensePlate = "55-XX-0000";
            bool add_Result = _functionTest.checkValueReception(name, phone,
             address, brand, receptionDate, licensePlate);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueReceptionUTCID06_Test()
        {
            string name = "Dat";
            string phone = "";
            string address = "Tien Giang";
            string brand = "Toyota";
            string receptionDate = "10/21/2021";
            string licensePlate = "55-XX-0000";
            bool add_Result = _functionTest.checkValueReception(name, phone,
             address, brand, receptionDate, licensePlate);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueReceptionUTCID07_Test()
        {
            string name = "Dat";
            string phone = "09cxsxsx";
            string address = "Tien Giang";
            string brand = "Toyota";
            string receptionDate = "10/21/2021";
            string licensePlate = "55-XX-0000";
            bool add_Result = _functionTest.checkValueReception(name, phone,
             address, brand, receptionDate, licensePlate);
            Assert.That(add_Result, Is.EqualTo(false));
        }

        [Test]
        public void checkValueReceptionUTCID08_Test()
        {
            string name = "Dat";
            string phone = "099554499";
            string address = "Tien Giang";
            string brand = "Toyota";
            string receptionDate = "";
            string licensePlate = "55-XX-0000";
            bool add_Result = _functionTest.checkValueReception(name, phone,
             address, brand, receptionDate, licensePlate);
            Assert.That(add_Result, Is.EqualTo(false));
        }

        [Test]
        public void checkValueReceptionUTCID09_Test()
        {
            string name = "Dat";
            string phone = "099554499";
            string address = "Tien Giang";
            string brand = "Toyota";
            string receptionDate = "abc";
            string licensePlate = "55-XX-0000";
            bool add_Result = _functionTest.checkValueReception(name, phone,
             address, brand, receptionDate, licensePlate);
            Assert.That(add_Result, Is.EqualTo(false));
        }
    }
}
