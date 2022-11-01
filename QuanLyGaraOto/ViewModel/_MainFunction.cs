using QuanLyGaraOto.Convert;
using QuanLyGaraOto.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuanLyGaraOto.ViewModel
{
    public class _MainFunction
    {
        public bool checkValueBrand(string name, 
            ObservableCollection<CAR_BRAND> list)

        {
            if (string.IsNullOrEmpty(name.Trim()))
            {
                return false;
            }
            //foreach (CAR_BRAND brand in list)
            //{
            //    if (brand.CarBrand_Name == name) return false;
            //}
            return true;
        }
        public bool checkValueSupplies(string name, string price, 
            ObservableCollection<SUPPLIES> list)
        {
            // Kiểm tra null
            if (string.IsNullOrEmpty(name.Trim()) || string.IsNullOrEmpty(price.Trim())){
                return false;
            }

            // Kiểm tra là số
            Regex regex = new Regex(@"^[0-9]+$");
            if (!regex.IsMatch(price) && !string.IsNullOrEmpty(price)) return false;

            // Kiểm tra trùng
            foreach (SUPPLIES supplies in list)
            {
                if ( supplies.Supplies_Name == name) return false;
            }
            return true;
        }
        public bool checkValueSupplier(string name, string phone, string email,
            ObservableCollection<SUPPLIER> list)
        {
            // Kiểm tra null
            if (string.IsNullOrEmpty(name.Trim()) || string.IsNullOrEmpty(phone.Trim())
                || string.IsNullOrEmpty(email.Trim())) {
                return false;
            }

            // Kiểm tra là số
            //Regex regex = new Regex(@"^[0-9]+$");
            //if (!regex.IsMatch(phone) && !string.IsNullOrEmpty(phone)) return false;

            // Kiểm tra trùng
            foreach (SUPPLIER item in list)
            {
                if (item.Supplier_Name == name) return false;
            }
            return true;
        }
        public bool checkValueWage(string name, string price,
            ObservableCollection<WAGE> list)
        {
            // Kiểm tra null
            if (string.IsNullOrEmpty(name.Trim())
                || string.IsNullOrEmpty(price.Trim()))
            {
                return false;
            }

            
            // Kiểm tra là số
            //Regex regex = new Regex(@"^[0-9]+$");
            //if (!regex.IsMatch(price) && !string.IsNullOrEmpty(price)) return false;

            // Kiểm tra trùng
            foreach (WAGE item in list)
            {
                if (item.Wage_Name == name) return false;
            }
            return true;
        }
        public bool checkValueReception(string name, string phone, 
            string address, string brand, string receptionDate, string LicensePlate)
        {
            // Kiểm tra null
            if (string.IsNullOrEmpty(name)
                    || string.IsNullOrEmpty(phone)
                    || string.IsNullOrEmpty(address)
                    || string.IsNullOrEmpty(brand)
                    || string.IsNullOrEmpty(receptionDate)
                    || string.IsNullOrEmpty(LicensePlate)) {
                return false;
            }

            // Kiểm tra là số
            Regex regex = new Regex(@"^[0-9]+$");
            if (!regex.IsMatch(phone) && !string.IsNullOrEmpty(phone)) return false;
            try
            {
                DateTime result = DateTime.Now;
                if (!DateTime.TryParse(receptionDate, out result)) return false;
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool checkValueRepair(string idReception, string repairDate)
        {
            // Kiểm tra null
            if (string.IsNullOrEmpty(idReception)
                    || string.IsNullOrEmpty(repairDate))
            {
                return false;
            }
            try
            {
                DateTime result = DateTime.Now;
                if (!DateTime.TryParse(repairDate, out result)) return false;
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool checkValueDetailRepair(string name, string supplies,
            string amount, string wage)
        {
            // Kiểm tra null
            if (string.IsNullOrEmpty(name)
                    || string.IsNullOrEmpty(name)
                    || string.IsNullOrEmpty(supplies)
                    || string.IsNullOrEmpty(amount)
                    || string.IsNullOrEmpty(wage))
            {
                return false;
            }

            // Kiểm tra là số
            Regex regex = new Regex(@"^[0-9]+$");
            if (!regex.IsMatch(amount) && !string.IsNullOrEmpty(amount)) return false;
            return true;
        }
        public bool checkValueReceipt(string money, string receiptDate,string email)
        {
            if (string.IsNullOrEmpty(money)
                    || string.IsNullOrEmpty(receiptDate)
                    || string.IsNullOrEmpty(email))
            {
                return false;
            }

            // Kiểm tra là số
            Regex regex = new Regex(@"^[0-9]+$");
            if (!regex.IsMatch(money) && !string.IsNullOrEmpty(money)) return false;
            return true;
        }
        public bool checkValueEmployee(string accountName, string name,
            string role, string birthDate, string cmnd, string phone, string address,
            ObservableCollection<USER> listUser, ObservableCollection<USER_INFO> listUserInfo)
        {
            // Kiểm tra null
            if (string.IsNullOrEmpty(accountName)
                    || string.IsNullOrEmpty(name)
                    || string.IsNullOrEmpty(role)
                    || string.IsNullOrEmpty(birthDate)
                    || string.IsNullOrEmpty(cmnd)
                    || string.IsNullOrEmpty(phone)
                    || string.IsNullOrEmpty(address))
            {
                return false;
            }

            // Kiểm tra là số
            Regex regex = new Regex(@"^[0-9]+$");
            if (!regex.IsMatch(phone) && !string.IsNullOrEmpty(phone)) return false;

            UnicodeConvert unicode = new UnicodeConvert(); 
            // Kiểm tra trùng tên tài khoản
            foreach (USER item in listUser)
            {
                string a = unicode.RemoveUnicode(item.UserName).ToLower();
                string b = unicode.RemoveUnicode(accountName).ToLower();
                if (a == b) return false;
            }
            // Kiểm tra trùng nhân viên
            foreach (USER_INFO item in listUserInfo)
            {
                if ((item.UserInfo_Name == name) &&
                    (item.UserInfo_CMND == cmnd)) return false;
            }
            return true;
        }
        public bool checkValueImportSupplies(string importDate, string supplier)
        {
            if (string.IsNullOrEmpty(importDate)
                   || string.IsNullOrEmpty(supplier))
            {
                return false;
            }
            try
            {
                DateTime result = DateTime.Now;
                if (!DateTime.TryParse(importDate, out result)) return false;
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool checkValueDetailImportSupplies(string name, string price, string amount)
        {
            if (string.IsNullOrEmpty(name)
                   || string.IsNullOrEmpty(price)
                   || string.IsNullOrEmpty(amount))
            {
                return false;
            }
            Regex regex = new Regex(@"^[0-9]+$");
            if (!regex.IsMatch(price) && !string.IsNullOrEmpty(price)) return false;
            if (!regex.IsMatch(amount) && !string.IsNullOrEmpty(amount)) return false;
            return true;
        }
    }
   
}
