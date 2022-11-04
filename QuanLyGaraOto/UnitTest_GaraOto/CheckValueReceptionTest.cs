using System;
using System.Collections.ObjectModel;
using NUnit.Framework;
using QuanLyGaraOto.Model;
using QuanLyGaraOto.ViewModel;
using System.Collections.Generic;

namespace UnitTest_GaraOto
{
    [TestFixture]
    public class CheckValueReceptionTest
    {
        private _MainFunction _functionTest;
        private List<string> _listInputNames;
        private List<string> _listInputPhones;
        private List<string> _listInputAddresses;
        private List<string> _listInputBrands;
        private List<string> _listInputReceptionDates;
        private List<string> _listInputLicensePlates;
        private List<bool> _listExpectedOutputs;

        [SetUp]
        public void Setup()
        {
            _functionTest = new _MainFunction();

            _listInputNames = new List<string>()
            {
                "Luan",
                "",
            };
            _listInputPhones = new List<string>()
            {
                "099554499",
                "",
                "09cxsxsx",
            };
            _listInputAddresses = new List<string>()
            {
                "Tien Giang",
                "",
            };
            _listInputBrands = new List<string>()
            {
                "Toyota",
                "",
            };
            _listInputReceptionDates = new List<string>()
            {
                DateTime.Now.ToString(),
                "",
                "abc",
            };
            _listInputLicensePlates = new List<string>()
            {
                "55-XX-0000",
                "",
            };

            _listExpectedOutputs = new List<bool>()
            {
                true,
                false,
            };
        }

        [Test]
        public void checkValueReceptionUTCID01_Test()
        {
            bool result = _functionTest.checkValueReception(
                _listInputNames[0],
                _listInputPhones[0],
                _listInputAddresses[0],
                _listInputBrands[0],
                _listInputReceptionDates[0],
                _listInputLicensePlates[0]
                );
            Assert.That(result, Is.EqualTo(_listExpectedOutputs[0]));
        }
        [Test]
        public void checkValueReceptionUTCID02_Test()
        {
            bool result = _functionTest.checkValueReception(
                _listInputNames[1],
                _listInputPhones[0],
                _listInputAddresses[0],
                _listInputBrands[0],
                _listInputReceptionDates[0],
                _listInputLicensePlates[0]
                );
            Assert.That(result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueReceptionUTCID03_Test()
        {
            bool result = _functionTest.checkValueReception(
                _listInputNames[0],
                _listInputPhones[0],
                _listInputAddresses[0],
                _listInputBrands[0],
                _listInputReceptionDates[0],
                _listInputLicensePlates[1]
                );
            Assert.That(result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueReceptionUTCID04_Test()
        {
            bool result = _functionTest.checkValueReception(
                _listInputNames[0],
                _listInputPhones[0],
                _listInputAddresses[0],
                _listInputBrands[1],
                _listInputReceptionDates[0],
                _listInputLicensePlates[0]
                );
            Assert.That(result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueReceptionUTCID05_Test()
        {
            bool result = _functionTest.checkValueReception(
                _listInputNames[0],
                _listInputPhones[0],
                _listInputAddresses[1],
                _listInputBrands[0],
                _listInputReceptionDates[0],
                _listInputLicensePlates[0]
                );
            Assert.That(result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueReceptionUTCID06_Test()
        {
            bool result = _functionTest.checkValueReception(
                _listInputNames[0],
                _listInputPhones[1],
                _listInputAddresses[0],
                _listInputBrands[0],
                _listInputReceptionDates[0],
                _listInputLicensePlates[0]
                );
            Assert.That(result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueReceptionUTCID07_Test()
        {
            bool result = _functionTest.checkValueReception(
                _listInputNames[0],
                _listInputPhones[2],
                _listInputAddresses[0],
                _listInputBrands[0],
                _listInputReceptionDates[0],
                _listInputLicensePlates[0]
                );
            Assert.That(result, Is.EqualTo(_listExpectedOutputs[1]));
        }

        [Test]
        public void checkValueReceptionUTCID08_Test()
        {
            bool result = _functionTest.checkValueReception(
                _listInputNames[0],
                _listInputPhones[0],
                _listInputAddresses[0],
                _listInputBrands[0],
                _listInputReceptionDates[1],
                _listInputLicensePlates[0]
                );
            Assert.That(result, Is.EqualTo(_listExpectedOutputs[1]));
        }

        [Test]
        public void checkValueReceptionUTCID09_Test()
        {
            bool result = _functionTest.checkValueReception(
                _listInputNames[0],
                _listInputPhones[0],
                _listInputAddresses[0],
                _listInputBrands[0],
                _listInputReceptionDates[2],
                _listInputLicensePlates[0]
                );
            Assert.That(result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueReceptionUTCID10_Test()
        {
            bool result = _functionTest.checkValueReception(
                _listInputNames[1],
                _listInputPhones[1],
                _listInputAddresses[1],
                _listInputBrands[1],
                _listInputReceptionDates[1],
                _listInputLicensePlates[1]
                );
            Assert.That(result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueReceptionUTCID11_Test()
        {
            bool result = _functionTest.checkValueReception(
                _listInputNames[1],
                _listInputPhones[2],
                _listInputAddresses[1],
                _listInputBrands[1],
                _listInputReceptionDates[1],
                _listInputLicensePlates[1]
                );
            Assert.That(result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueReceptionUTCID12_Test()
        {
            bool result = _functionTest.checkValueReception(
                _listInputNames[1],
                _listInputPhones[1],
                _listInputAddresses[1],
                _listInputBrands[1],
                _listInputReceptionDates[2],
                _listInputLicensePlates[1]
                );
            Assert.That(result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueReceptionUTCID13_Test()
        {
            bool result = _functionTest.checkValueReception(
                _listInputNames[1],
                _listInputPhones[2],
                _listInputAddresses[1],
                _listInputBrands[1],
                _listInputReceptionDates[2],
                _listInputLicensePlates[1]
                );
            Assert.That(result, Is.EqualTo(_listExpectedOutputs[1]));
        }
    }
}
