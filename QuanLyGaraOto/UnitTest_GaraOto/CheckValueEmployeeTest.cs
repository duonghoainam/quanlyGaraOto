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
                new USER(){ UserName = "dat"},
                new USER(){ UserName = "kiet"},
                new USER(){ UserName = "nam"},
            };
            _listUsersInfo = new ObservableCollection<USER_INFO>()
            {
                new USER_INFO(){ UserInfo_Name ="dat", UserInfo_CMND = "111" },
                new USER_INFO(){ UserInfo_Name ="kiet", UserInfo_CMND = "222"},
                new USER_INFO(){ UserInfo_Name ="nam", UserInfo_CMND = "333"},
            };

            _functionTest = new _MainFunction();

            _listInputAccountNames = new List<string>()
            {
                "chienthuatido",
                "nam",
                "",
            };
            _listInputNames = new List<string>()
            {
                "Lê Hoàng Phú",
                "1235",
                "",
                "!@#$"
            };
            _listInputRoles = new List<string>()
            {
                "Nhân viên",
                "",
            };
            _listInputBirthDates = new List<string>()
            {
                "02/13/2001"
            };
            _listInputCMNDs = new List<string>()
            {
                "123456789",
                "asadsa",
                "",
            };
            _listInputPhones = new List<string>()
            {
                "0965558751",
                "adfgqw9",
                "",
            };
            _listInputAddresses = new List<string>()
            {
                "Cà Mau",
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
        public void checkValueEmployeeUTCID03_Test()
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
        public void checkValueEmployeeUTCID04_Test()
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
        public void checkValueEmployeeUTCID05_Test()
        {
            bool add_Result = _functionTest.checkValueEmployee(
                _listInputAccountNames[0],
                _listInputNames[3],
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
        public void checkValueEmployeeUTCID07_Test()
        {
            bool add_Result = _functionTest.checkValueEmployee(
                _listInputAccountNames[0],
                _listInputNames[0],
                _listInputRoles[0],
                _listInputBirthDates[0],
                _listInputCMNDs[1],
                _listInputPhones[1],
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
        public void checkValueEmployeeUTCID09_Test()
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
        public void checkValueEmployeeUTCID10_Test()
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
        public void checkValueEmployeeUTCID11_Test()
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
        public void checkValueEmployeeUTCID12_Test()
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
    }
}
