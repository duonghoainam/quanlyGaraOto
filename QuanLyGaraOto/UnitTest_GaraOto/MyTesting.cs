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
        public void checkValueBrand_Test()
        {
            _MainFunction functionTest = new _MainFunction();
            ObservableCollection<CAR_BRAND> list = new ObservableCollection<CAR_BRAND>()
            {
                new CAR_BRAND(){ CarBrand_Name = "KIA"},
                new CAR_BRAND(){ CarBrand_Name = "ASD"},
                new CAR_BRAND(){ CarBrand_Name = "BBB"},

            };
            bool add_Result = functionTest.checkValueBrand("KIA",list);
            Assert.That(add_Result, Is.EqualTo(true));
        }
        [Test]
        public void checkValueSupplies_Test()
        {
            ObservableCollection<SUPPLIES> list = new ObservableCollection<SUPPLIES>()
            {
                new SUPPLIES(){ Supplies_Name = "Bánh Xe",},
                new SUPPLIES(){ Supplies_Name = "Kính Hậu",},
                new SUPPLIES(){ Supplies_Name = "Nắp Capo",},
            };
            string name = "Vô Lăng";
            string price = "10000";
            _MainFunction functionTest = new _MainFunction();
            bool add_Result = functionTest.checkValueSupplies(name, price, list);
            Assert.That(add_Result, Is.EqualTo(true));
        }
        [Test]
        public void checkValueSupplier_Test()
        {
            ObservableCollection<SUPPLIER> list = new ObservableCollection<SUPPLIER>()
            {
                new SUPPLIER(){ Supplier_Name = "Vật Tư Việt Phát",},
                new SUPPLIER(){ Supplier_Name = "Vật Tư ABC",},
                new SUPPLIER(){ Supplier_Name = "Vật Tư Thành Công",},
            };
            string name = "Vật Tư X";
            string phone = "098777";
            string email = "datn";
            _MainFunction functionTest = new _MainFunction();
            bool add_Result = functionTest.checkValueSupplier(name, phone, email, list);
            Assert.That(add_Result, Is.EqualTo(true));
        }
        [Test]
        public void checkValueWage_Test()
        {
            ObservableCollection<WAGE> list = new ObservableCollection<WAGE>()
            {
                new WAGE(){ Wage_Name = "Vật Tư Việt Phát",},
                new WAGE(){ Wage_Name = "Vật Tư ABC",},
                new WAGE(){ Wage_Name = "Vật Tư Thành Công",},
            };
            string name = "Vật Tư X";
            string value = "";
            _MainFunction functionTest = new _MainFunction();
            bool add_Result = functionTest.checkValueWage(name, value, list);
            Assert.That(add_Result, Is.EqualTo(true));
        }
        [Test]
        public void checkValueReception_Test()
        {
            string name = "Vật Tư X";
            string phone = "09999";
            string address = "TG";
            string brand = "Toyota";
            string receptionDate = "07/26/2021";
            string LicensePlate = "DASD2121";
            _MainFunction functionTest = new _MainFunction();
            bool add_Result = functionTest.checkValueReception(name,  phone,
             address,  brand,  receptionDate,  LicensePlate);
            Assert.That(add_Result, Is.EqualTo(true));
        }
        [Test]
        public void checkValueRepair_Test()
        {
            string idReception = "1";
            string repairDate = "08/11/2021";
            _MainFunction functionTest = new _MainFunction();
            bool add_Result = functionTest.checkValueRepair(idReception, repairDate );
            Assert.That(add_Result, Is.EqualTo(true));
        }
        [Test]
        public void checkValueDetailRepair_Test()
        {
            string name = "Thay phụ tùng";
            string supplies = "Bánh xe";
            string amount = "1";
            string wage = "350000";
            _MainFunction functionTest = new _MainFunction();
            bool add_Result = functionTest.checkValueDetailRepair( name, supplies, amount, wage);
            Assert.That(add_Result, Is.EqualTo(true));
        }
        [Test]
        public void checkValueReceipt_Test()
        {
            string money = "1330000";
            string receiptDate = "08/11/2021";
            string email = "datn@gmail.com";
            _MainFunction functionTest = new _MainFunction();
            bool add_Result = functionTest.checkValueReceipt(money, receiptDate, email);
            Assert.That(add_Result, Is.EqualTo(true));
        }
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
        [Test]
        public void checkValueImportSupplies_Test()
        {
            string importDate = "08/11/2021";
            string supplier = "Vật Tư ABC";
            _MainFunction functionTest = new _MainFunction();
            bool add_Result = functionTest.checkValueImportSupplies( importDate, supplier);
            Assert.That(add_Result, Is.EqualTo(true));
        }
        [Test]
        public void checkValueDetailImportSupplies_Test()
        {
            string name = "Sơn XY";
            string price = "250000";
            string amount = "3";
            _MainFunction functionTest = new _MainFunction();
            bool add_Result = functionTest.checkValueDetailImportSupplies(name, price, amount);
            Assert.That(add_Result, Is.EqualTo(true));
        }
    }
}
