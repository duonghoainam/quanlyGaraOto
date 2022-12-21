using System;
using System.Collections.ObjectModel;
using NUnit.Framework;
using QuanLyGaraOto.Model;
using QuanLyGaraOto.ViewModel;
using System.Collections.Generic;

namespace UnitTest_GaraOto
{
    [TestFixture]
    public class CheckValueEmployeeTest
    {
        private ObservableCollection<USER> _listUsers;
        private ObservableCollection<USER_INFO> _listUsersInfo;
        private _MainFunction _functionTest;
        private List<string> _listInputAccountNames;
        private List<string> _listInputNames;
        private List<string> _listInputRoles;
        private List<string> _listInputBirthDates;
        private List<string> _listInputCMNDs;
        private List<string> _listInputPhones;
        private List<string> _listInputAddresses;
        private List<bool> _listOuputs;

        [SetUp]
        public void Setup()
        {
            _listUsers = new ObservableCollection<USER>()
            {
                new USER(){ UserName = "luan"},
                new USER(){ UserName = "nhi"},
                new USER(){ UserName = "nam"},
            };
            _listUsersInfo = new ObservableCollection<USER_INFO>()
            {
                new USER_INFO(){ UserInfo_Name ="luan", UserInfo_CMND = "111" },
                new USER_INFO(){ UserInfo_Name ="nhi", UserInfo_CMND = "222"},
                new USER_INFO(){ UserInfo_Name ="nam", UserInfo_CMND = "333"},
            };

            _functionTest = new _MainFunction();

            _listInputAccountNames = new List<string>()
            {
                "lethanhluan",
                "nam",
                "!@#$%",
                null,
            };
            _listInputNames = new List<string>()
            {
                "Lê Thành Luân",
                "!@#$%",
                null,
            };
            _listInputRoles = new List<string>()
            {
                "Nhân viên loại 1",
                "!@#$%",
                null,
            };
            _listInputBirthDates = new List<string>()
            {
                "02/13/2001",
                DateTime.Today.AddDays(-1800).ToString(),
                DateTime.Today.AddDays(2000).ToString(),
                "abc",
                null,
            };
            _listInputCMNDs = new List<string>()
            {
                "0123456789",
                "111",
                "zxcvbnm",
                null,
            };
            _listInputPhones = new List<string>()
            {
                "0987654321",
                "adfgqw9",
                null,
            };
            _listInputAddresses = new List<string>()
            {
                "Cà Mau",
                null,
            };

            _listOuputs = new List<bool>()
            {
                true,
                false,
            };
        }

        [Test]
        public void checkValueEmployeeUTCID01_Test()
        {
            bool add_Result = _functionTest.checkValueEmployee(
                    _listInputAccountNames[0],
                    _listInputNames[0],
                    _listInputRoles[0], 
                    _listInputBirthDates[0],
                    _listInputCMNDs[0],
                    _listInputPhones[0], 
                    _listInputAddresses[0],
                    _listUsers, 
                    _listUsersInfo
                );
            Assert.That(add_Result, Is.EqualTo(_listOuputs[0]));
        }
        [Test]
        public void checkValueEmployeeUTCID02_Test()
        {
            bool add_Result = _functionTest.checkValueEmployee(
                    _listInputAccountNames[1],
                    _listInputNames[0],
                    _listInputRoles[0],
                    _listInputBirthDates[0],
                    _listInputCMNDs[0],
                    _listInputPhones[0],
                    _listInputAddresses[0],
                    _listUsers,
                    _listUsersInfo
                );
            Assert.That(add_Result, Is.EqualTo(_listOuputs[1]));
        }
        [Test]
        public void checkValueEmployeeUTCID03_Test()
        {
            bool add_Result = _functionTest.checkValueEmployee(
                    _listInputAccountNames[2],
                    _listInputNames[0],
                    _listInputRoles[0],
                    _listInputBirthDates[0],
                    _listInputCMNDs[0],
                    _listInputPhones[0],
                    _listInputAddresses[0],
                    _listUsers,
                    _listUsersInfo
                );
            Assert.That(add_Result, Is.EqualTo(_listOuputs[1]));
        }
        [Test]
        public void checkValueEmployeeUTCID04_Test()
        {
            bool add_Result = _functionTest.checkValueEmployee(
                    _listInputAccountNames[3],
                    _listInputNames[0],
                    _listInputRoles[0],
                    _listInputBirthDates[0],
                    _listInputCMNDs[0],
                    _listInputPhones[0],
                    _listInputAddresses[0],
                    _listUsers,
                    _listUsersInfo
                );
            Assert.That(add_Result, Is.EqualTo(_listOuputs[1]));
        }
        [Test]
        public void checkValueEmployeeUTCID05_Test()
        {
            bool add_Result = _functionTest.checkValueEmployee(
                    _listInputAccountNames[0],
                    _listInputNames[1],
                    _listInputRoles[0],
                    _listInputBirthDates[0],
                    _listInputCMNDs[0],
                    _listInputPhones[0],
                    _listInputAddresses[0],
                    _listUsers,
                    _listUsersInfo
                );
            Assert.That(add_Result, Is.EqualTo(_listOuputs[1]));
        }
        [Test]
        public void checkValueEmployeeUTCID06_Test()
        {
            bool add_Result = _functionTest.checkValueEmployee(
                    _listInputAccountNames[0],
                    _listInputNames[2],
                    _listInputRoles[0],
                    _listInputBirthDates[0],
                    _listInputCMNDs[0],
                    _listInputPhones[0],
                    _listInputAddresses[0],
                    _listUsers,
                    _listUsersInfo
                );
            Assert.That(add_Result, Is.EqualTo(_listOuputs[1]));
        }
        [Test]
        public void checkValueEmployeeUTCID07_Test()
        {
            bool add_Result = _functionTest.checkValueEmployee(
                    _listInputAccountNames[0],
                    _listInputNames[0],
                    _listInputRoles[1],
                    _listInputBirthDates[0],
                    _listInputCMNDs[0],
                    _listInputPhones[0],
                    _listInputAddresses[0],
                    _listUsers,
                    _listUsersInfo
                );
            Assert.That(add_Result, Is.EqualTo(_listOuputs[1]));
        }
        [Test]
        public void checkValueEmployeeUTCID08_Test()
        {
            bool add_Result = _functionTest.checkValueEmployee(
                    _listInputAccountNames[0],
                    _listInputNames[0],
                    _listInputRoles[2],
                    _listInputBirthDates[0],
                    _listInputCMNDs[0],
                    _listInputPhones[0],
                    _listInputAddresses[0],
                    _listUsers,
                    _listUsersInfo
                );
            Assert.That(add_Result, Is.EqualTo(_listOuputs[1]));
        }
        [Test]
        public void checkValueEmployeeUTCID09_Test()
        {
            bool add_Result = _functionTest.checkValueEmployee(
                    _listInputAccountNames[0],
                    _listInputNames[0],
                    _listInputRoles[0],
                    _listInputBirthDates[1],
                    _listInputCMNDs[0],
                    _listInputPhones[0],
                    _listInputAddresses[0],
                    _listUsers,
                    _listUsersInfo
                );
            Assert.That(add_Result, Is.EqualTo(_listOuputs[1]));
        }
        [Test]
        public void checkValueEmployeeUTCID10_Test()
        {
            bool add_Result = _functionTest.checkValueEmployee(
                    _listInputAccountNames[0],
                    _listInputNames[0],
                    _listInputRoles[0],
                    _listInputBirthDates[2],
                    _listInputCMNDs[0],
                    _listInputPhones[0],
                    _listInputAddresses[0],
                    _listUsers,
                    _listUsersInfo
                );
            Assert.That(add_Result, Is.EqualTo(_listOuputs[1]));
        }
        [Test]
        public void checkValueEmployeeUTCID11_Test()
        {
            bool add_Result = _functionTest.checkValueEmployee(
                    _listInputAccountNames[0],
                    _listInputNames[0],
                    _listInputRoles[0],
                    _listInputBirthDates[3],
                    _listInputCMNDs[0],
                    _listInputPhones[0],
                    _listInputAddresses[0],
                    _listUsers,
                    _listUsersInfo
                );
            Assert.That(add_Result, Is.EqualTo(_listOuputs[1]));
        }
        [Test]
        public void checkValueEmployeeUTCID12_Test()
        {
            bool add_Result = _functionTest.checkValueEmployee(
                    _listInputAccountNames[0],
                    _listInputNames[0],
                    _listInputRoles[0],
                    _listInputBirthDates[4],
                    _listInputCMNDs[0],
                    _listInputPhones[0],
                    _listInputAddresses[0],
                    _listUsers,
                    _listUsersInfo
                );
            Assert.That(add_Result, Is.EqualTo(_listOuputs[1]));
        }
        [Test]
        public void checkValueEmployeeUTCID13_Test()
        {
            bool add_Result = _functionTest.checkValueEmployee(
                    _listInputAccountNames[0],
                    _listInputNames[0],
                    _listInputRoles[0],
                    _listInputBirthDates[0],
                    _listInputCMNDs[1],
                    _listInputPhones[0],
                    _listInputAddresses[0],
                    _listUsers,
                    _listUsersInfo
                );
            Assert.That(add_Result, Is.EqualTo(_listOuputs[1]));
        }
        [Test]
        public void checkValueEmployeeUTCID14_Test()
        {
            bool add_Result = _functionTest.checkValueEmployee(
                    _listInputAccountNames[0],
                    _listInputNames[0],
                    _listInputRoles[0],
                    _listInputBirthDates[0],
                    _listInputCMNDs[2],
                    _listInputPhones[0],
                    _listInputAddresses[0],
                    _listUsers,
                    _listUsersInfo
                );
            Assert.That(add_Result, Is.EqualTo(_listOuputs[1]));
        }
        [Test]
        public void checkValueEmployeeUTCID15_Test()
        {
            bool add_Result = _functionTest.checkValueEmployee(
                _listInputAccountNames[0],
                    _listInputNames[0],
                    _listInputRoles[0],
                    _listInputBirthDates[0],
                    _listInputCMNDs[3],
                    _listInputPhones[0],
                    _listInputAddresses[0],
                    _listUsers,
                    _listUsersInfo
                );
            Assert.That(add_Result, Is.EqualTo(_listOuputs[1]));
        }
        [Test]
        public void checkValueEmployeeUTCID16_Test()
        {
            bool add_Result = _functionTest.checkValueEmployee(
                _listInputAccountNames[0],
                    _listInputNames[0],
                    _listInputRoles[0],
                    _listInputBirthDates[0],
                    _listInputCMNDs[0],
                    _listInputPhones[1],
                    _listInputAddresses[0],
                    _listUsers,
                    _listUsersInfo
                );
            Assert.That(add_Result, Is.EqualTo(_listOuputs[1]));
        }
        [Test]
        public void checkValueEmployeeUTCID17_Test()
        {
            bool add_Result = _functionTest.checkValueEmployee(
                _listInputAccountNames[0],
                    _listInputNames[0],
                    _listInputRoles[0],
                    _listInputBirthDates[0],
                    _listInputCMNDs[0],
                    _listInputPhones[2],
                    _listInputAddresses[0],
                    _listUsers,
                    _listUsersInfo
                );
            Assert.That(add_Result, Is.EqualTo(_listOuputs[1]));
        }
        [Test]
        public void checkValueEmployeeUTCID18_Test()
        {
            bool add_Result = _functionTest.checkValueEmployee(
                _listInputAccountNames[0],
                    _listInputNames[0],
                    _listInputRoles[0],
                    _listInputBirthDates[0],
                    _listInputCMNDs[0],
                    _listInputPhones[0],
                    _listInputAddresses[1],
                    _listUsers,
                    _listUsersInfo
                );
            Assert.That(add_Result, Is.EqualTo(_listOuputs[1]));
        }
    }
}
