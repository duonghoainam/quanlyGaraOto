using System;
using System.Collections.ObjectModel;
using NUnit.Framework;
using QuanLyGaraOto.Model;
using QuanLyGaraOto.ViewModel;

namespace UnitTest_GaraOto
{
    [TestFixture]
    public class CheckValueReceiptTest
    {
        private _MainFunction _functionTest;

        [SetUp]
        public void Setup()
        {
            _functionTest = new _MainFunction();
        }

        [Test]
        public void checkValueReceiptUTCID01_Test()
        {
            string money = "10000";
            string receiptDate = "12/12/2022";
            string email = "datnguyen@gmail.com";
            bool add_Result = _functionTest.checkValueReceipt(money, receiptDate, email);
            Assert.That(add_Result, Is.EqualTo(true));
        }
        [Test]
        public void checkValueReceiptUTCID02_Test()
        {
            string money = "10000";
            string receiptDate = "12/12/2022";
            string email = "";
            bool add_Result = _functionTest.checkValueReceipt(money, receiptDate, email);
            Assert.That(add_Result, Is.EqualTo(true));
        }
        [Test]
        public void checkValueReceiptUTCID03_Test()
        {
            string money = "10000";
            string receiptDate = "12/12/2022";
            string email = null;
            bool add_Result = _functionTest.checkValueReceipt(money, receiptDate, email);
            Assert.That(add_Result, Is.EqualTo(true));
        }
        [Test]
        public void checkValueReceiptUTCID04_Test()
        {
            string money = "10000";
            string receiptDate = DateTime.Now.ToString();
            string email = "datnguyen@gmail.com";
            bool add_Result = _functionTest.checkValueReceipt(money, receiptDate, email);
            Assert.That(add_Result, Is.EqualTo(true));
        }
        [Test]
        public void checkValueReceiptUTCID05_Test()
        {
            string money = "9999";
            string receiptDate = "12/12/2022";
            string email = "datnguyen@gmail.com";
            bool add_Result = _functionTest.checkValueReceipt(money, receiptDate, email);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueReceiptUTCID06_Test()
        {
            string money = "10001";
            string receiptDate = "12/12/2022";
            string email = "datnguyen@gmail.com";
            bool add_Result = _functionTest.checkValueReceipt(money, receiptDate, email);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueReceiptUTCID07_Test()
        {
            string money = "";
            string receiptDate = "12/12/2022";
            string email = "datnguyen@gmail.com";
            bool add_Result = _functionTest.checkValueReceipt(money, receiptDate, email);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueReceiptUTCID08_Test()
        {
            string money = "asd";
            string receiptDate = "12/12/2022";
            string email = "datnguyen@gmail.com";
            bool add_Result = _functionTest.checkValueReceipt(money, receiptDate, email);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueReceiptUTCID09_Test()
        {
            string money = "-20000";
            string receiptDate = "12/12/2022";
            string email = "datnguyen@gmail.com";
            bool add_Result = _functionTest.checkValueReceipt(money, receiptDate, email);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueReceiptUTCID10_Test()
        {
            string money = "10000";
            string receiptDate = "11/01/2022";
            string email = "datnguyen@gmail.com";
            bool add_Result = _functionTest.checkValueReceipt(money, receiptDate, email);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueReceiptUTCID11_Test()
        {
            string money = "10000";
            string receiptDate = "";
            string email = "datnguyen@gmail.com";
            bool add_Result = _functionTest.checkValueReceipt(money, receiptDate, email);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueReceiptUTCID12_Test()
        {
            string money = "10000";
            string receiptDate = "12/12/2022";
            string email = "dasd";
            bool add_Result = _functionTest.checkValueReceipt(money, receiptDate, email);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueReceiptUTCID13_Test()
        {
            string money = "9999";
            string receiptDate = "11/01/2022";
            string email = "";
            bool add_Result = _functionTest.checkValueReceipt(money, receiptDate, email);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueReceiptUTCID14_Test()
        {
            string money = "9999";
            string receiptDate = "11/01/2022";
            string email = null;
            bool add_Result = _functionTest.checkValueReceipt(money, receiptDate, email);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueReceiptUTCID15_Test()
        {
            string money = "10001";
            string receiptDate = "11/01/2022";
            string email = null;
            bool add_Result = _functionTest.checkValueReceipt(money, receiptDate, email);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueReceiptUTCID16_Test()
        {
            string money = "";
            string receiptDate = "";
            string email = null;
            bool add_Result = _functionTest.checkValueReceipt(money, receiptDate, email);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueReceiptUTCID17_Test()
        {
            string money = "asd";
            string receiptDate = "";
            string email = null;
            bool add_Result = _functionTest.checkValueReceipt(money, receiptDate, email);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueReceiptUTCID18_Test()
        {
            string money = "-20000";
            string receiptDate = "dasd";
            string email = null;
            bool add_Result = _functionTest.checkValueReceipt(money, receiptDate, email);
            Assert.That(add_Result, Is.EqualTo(false));
        }
        [Test]
        public void checkValueReceiptUTCID19_Test()
        {
            string money = "asd";
            string receiptDate = "11/01/2022";
            string email = null;
            bool add_Result = _functionTest.checkValueReceipt(money, receiptDate, email);
            Assert.That(add_Result, Is.EqualTo(false));
        }
    }
}
