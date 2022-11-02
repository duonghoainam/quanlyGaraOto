using System;
using System.Collections.ObjectModel;
using NUnit.Framework;
using QuanLyGaraOto.Model;
using QuanLyGaraOto.ViewModel;

namespace UnitTest_GaraOto
{
    [TestFixture]
    public class MyTesting
    {
       
        [Test]
        public void checkValueEmployee_Test()
        {
            ObservableCollection<USER> listUser = new ObservableCollection<USER>()
            {
                new USER(){ UserName = "dat"},
                new USER(){ UserName = "kiet"},
                new USER(){ UserName = "nam"},
            };
            ObservableCollection<USER_INFO> listUserInfo = new ObservableCollection<USER_INFO>()
            {
                new USER_INFO(){ UserInfo_Name ="dat", UserInfo_CMND = "111" },
                new USER_INFO(){ UserInfo_Name ="kiet", UserInfo_CMND = "222"},
                new USER_INFO(){ UserInfo_Name ="nam", UserInfo_CMND = "333"},
            };
            string accountName = "dat";
            string name = "Đạt Nguyễn";
            string role = "Quản lý";
            string birthDate = "07/26/2001";
            string cmnd = "312302304";
            string phone = "09776576";
            string address = "Tien giang";
            _MainFunction functionTest = new _MainFunction();
            bool add_Result = functionTest.checkValueEmployee(accountName, name,
            role, birthDate, cmnd, phone, address,
            listUser, listUserInfo);
            Assert.That(add_Result, Is.EqualTo(true));
        }        
        
        
    }
}
