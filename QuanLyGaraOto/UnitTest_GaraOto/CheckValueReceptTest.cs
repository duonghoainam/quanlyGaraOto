using System;
using System.Collections.ObjectModel;
using NUnit.Framework;
using QuanLyGaraOto.Model;
using QuanLyGaraOto.ViewModel;
using System.Collections.Generic;

namespace UnitTest_GaraOto
{
    [TestFixture]
    public class CheckValueReceptTest
    {
        private _MainFunction _functionTest;
        private List<string> _listInputMoneys;
        private List<string> _listInputReceptDates;
        private List<string> _listInputEmails;
        private List<bool> _listExpectedOutputs;

        [SetUp]
        public void Setup()
        {
            _functionTest = new _MainFunction();

            _listInputMoneys = new List<string>()
            {
                "10000",
                "9999",
                "10001",
                "",
                "asd",
                "-20000",
            };
            _listInputReceptDates = new List<string>()
            {
                DateTime.Now.AddDays(1).ToString(),
                DateTime.Now.ToString(),
                DateTime.Now.AddDays(-1).ToString(),
                "",
                "dasd",
            };
            _listInputEmails = new List<string>()
            {
                "datnguyen@gmail.com",
                "",
                null,
            };

            _listExpectedOutputs = new List<bool>()
            {
                true,
                false,
            };
        }

        [Test]
        public void checkValueReceiptUTCID01_Test()
        {
            bool add_Result = _functionTest.checkValueReceipt(
                _listInputMoneys[0],
                _listInputReceptDates[0],
                _listInputEmails[0]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[0]));
        }
        [Test]
        public void checkValueReceiptUTCID02_Test()
        {
            bool add_Result = _functionTest.checkValueReceipt(
                _listInputMoneys[0],
                _listInputReceptDates[0],
                _listInputEmails[1]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[0]));
        }
        [Test]
        public void checkValueReceiptUTCID03_Test()
        {
            bool add_Result = _functionTest.checkValueReceipt(
                _listInputMoneys[0],
                _listInputReceptDates[0],
                _listInputEmails[2]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[0]));
        }
        [Test]
        public void checkValueReceiptUTCID04_Test()
        {
            bool add_Result = _functionTest.checkValueReceipt(
                _listInputMoneys[0],
                _listInputReceptDates[1],
                _listInputEmails[0]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[0]));
        }
        [Test]
        public void checkValueReceiptUTCID05_Test()
        {
            bool add_Result = _functionTest.checkValueReceipt(
                _listInputMoneys[1],
                _listInputReceptDates[0],
                _listInputEmails[0]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueReceiptUTCID06_Test()
        {
            bool add_Result = _functionTest.checkValueReceipt(
                _listInputMoneys[2],
                _listInputReceptDates[0],
                _listInputEmails[0]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueReceiptUTCID07_Test()
        {
            bool add_Result = _functionTest.checkValueReceipt(
                _listInputMoneys[3],
                _listInputReceptDates[0],
                _listInputEmails[0]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueReceiptUTCID08_Test()
        {
            bool add_Result = _functionTest.checkValueReceipt(
                _listInputMoneys[4],
                _listInputReceptDates[0],
                _listInputEmails[0]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueReceiptUTCID09_Test()
        {
            bool add_Result = _functionTest.checkValueReceipt(
                 _listInputMoneys[5],
                 _listInputReceptDates[0],
                 _listInputEmails[0]
                 );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueReceiptUTCID10_Test()
        {
            bool add_Result = _functionTest.checkValueReceipt(
                _listInputMoneys[0],
                _listInputReceptDates[2],
                _listInputEmails[0]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueReceiptUTCID11_Test()
        {
            bool add_Result = _functionTest.checkValueReceipt(
                _listInputMoneys[0],
                _listInputReceptDates[3],
                _listInputEmails[0]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueReceiptUTCID12_Test()
        {
            bool add_Result = _functionTest.checkValueReceipt(
                _listInputMoneys[0],
                _listInputReceptDates[4],
                _listInputEmails[0]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueReceiptUTCID13_Test()
        {
            bool add_Result = _functionTest.checkValueReceipt(
                _listInputMoneys[1],
                _listInputReceptDates[2],
                _listInputEmails[1]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueReceiptUTCID14_Test()
        {
            bool add_Result = _functionTest.checkValueReceipt(
                _listInputMoneys[1],
                _listInputReceptDates[2],
                _listInputEmails[2]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueReceiptUTCID15_Test()
        {
            bool add_Result = _functionTest.checkValueReceipt(
                _listInputMoneys[2],
                _listInputReceptDates[2],
                _listInputEmails[2]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueReceiptUTCID16_Test()
        {
            bool add_Result = _functionTest.checkValueReceipt(
                _listInputMoneys[3],
                _listInputReceptDates[3],
                _listInputEmails[2]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueReceiptUTCID17_Test()
        {
            bool add_Result = _functionTest.checkValueReceipt(
                _listInputMoneys[4],
                _listInputReceptDates[4],
                _listInputEmails[2]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueReceiptUTCID18_Test()
        {
            bool add_Result = _functionTest.checkValueReceipt(
                _listInputMoneys[5],
                _listInputReceptDates[4],
                _listInputEmails[2]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
        [Test]
        public void checkValueReceiptUTCID19_Test()
        {
            bool add_Result = _functionTest.checkValueReceipt(
                _listInputMoneys[4],
                _listInputReceptDates[2],
                _listInputEmails[2]
                );
            Assert.That(add_Result, Is.EqualTo(_listExpectedOutputs[1]));
        }
    }
}
