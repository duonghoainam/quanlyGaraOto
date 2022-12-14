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
        private Regex _regexVietnameseWithNumber;
        private Regex _regexVietnamese;
        private Regex _regexAmount;
        private Regex _regexPhone;
        private Regex _regexText;
        private Regex _regexEmail;

        public _MainFunction()
        {
            _regexVietnameseWithNumber = new Regex(@"^[0-9a-zA-Z_ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ ]+$");
            _regexVietnamese = new Regex(@"^[a-zA-Z_ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ ]+$");
            _regexAmount = new Regex(@"^[1-9][0-9]*$");
            _regexPhone = new Regex(@"^[0-9]+$");
            _regexText = new Regex(@"^[0-9a-zA-Z -]+$");
            _regexEmail = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
        }

        public bool checkValueBrand(string name, 
            ObservableCollection<CAR_BRAND> list)

        {
            if (string.IsNullOrEmpty(name))
            {
                return false;
            }
            if (!_regexText.IsMatch(name)) return false;
            foreach (CAR_BRAND brand in list)
            {
                if (brand.CarBrand_Name == name) return false;
            }
            return true;
        }
        public bool checkValueSupplies(string name, string price,
            ObservableCollection<SUPPLIES> list)
        {
            if (string.IsNullOrEmpty(name) 
                || string.IsNullOrEmpty(price)){
                return false;
            }

            if (!this._regexAmount.IsMatch(price)
                || !this._regexVietnameseWithNumber.IsMatch(name)) return false;

            foreach (SUPPLIES supplies in list)
            {
                if ( supplies.Supplies_Name.ToLower() == name.ToLower()) return false;
            }
            return true;
        }
        public bool checkValueSupplier(string name, string phone, string email,
            ObservableCollection<SUPPLIER> list)
        {
            if (string.IsNullOrEmpty(name) 
                || string.IsNullOrEmpty(phone)
                || string.IsNullOrEmpty(email)) return false;
            if (!this._regexPhone.IsMatch(phone) 
                || !this._regexVietnameseWithNumber.IsMatch(name)
                || !this._regexEmail.IsMatch(email)) return false;
            foreach (SUPPLIER item in list)
            {
                if (item.Supplier_Name.ToLower() == name.ToLower()) return false;
            }
            return true;
        }
        public bool checkValueWage(string name, string price,
            ObservableCollection<WAGE> list)
        {
            if (string.IsNullOrEmpty(name)
                || string.IsNullOrEmpty(price)) return false;

            if (!this._regexPhone.IsMatch(price)
                || !this._regexVietnameseWithNumber.IsMatch(name)) return false;

            foreach (WAGE item in list)
            {
                if (item.Wage_Name.ToLower() == name.ToLower()) return false;
            }
            return true;
        }
        public bool checkValueReception(string name, string phone, 
            string address, string brand, string receptionDate, string LicensePlate)
        {
            if (string.IsNullOrEmpty(name)
                    || string.IsNullOrEmpty(phone)
                    || string.IsNullOrEmpty(address)
                    || string.IsNullOrEmpty(brand)
                    || string.IsNullOrEmpty(receptionDate)
                    || string.IsNullOrEmpty(LicensePlate)) {
                return false;
            }

            if (!_regexPhone.IsMatch(phone)) return false;
            
            DateTime result = DateTime.Now;
            if (!DateTime.TryParse(receptionDate, out result)) return false;
            if (DateTime.Compare(result, DateTime.Today) != 0)
            {
                return false;
            }
            return true;
        }
        public bool checkValueEmployee(string accountName, string name,
            string role, string birthDate, string cmnd, string phone, string address,
            ObservableCollection<USER> listUser, ObservableCollection<USER_INFO> listUserInfo)
        {
            if (string.IsNullOrEmpty(accountName)
                || string.IsNullOrEmpty(name)
                || string.IsNullOrEmpty(role)
                || string.IsNullOrEmpty(birthDate)
                || string.IsNullOrEmpty(cmnd)
                || string.IsNullOrEmpty(phone)
                || string.IsNullOrEmpty(address)
                )
            {
                return false;
            }

            if (!this._regexPhone.IsMatch(phone) 
                || !this._regexText.IsMatch(accountName)
                || !this._regexVietnamese.IsMatch(name)
                || !this._regexVietnameseWithNumber.IsMatch(role)
                || !this._regexText.IsMatch(cmnd)
                )
            {
                return false;
            }

            UnicodeConvert unicode = new UnicodeConvert();

            DateTime result = DateTime.Today;
            if (!DateTime.TryParse(birthDate, out result)) return false;
            if (DateTime.Compare(result, DateTime.Today.AddYears(-18)) > 0
                || DateTime.Compare(result, DateTime.Today) >= 0)
            {
                return false;
            }

            foreach (USER item in listUser)
            {
                string a = unicode.RemoveUnicode(item.UserName).ToLower();
                string b = unicode.RemoveUnicode(accountName).ToLower();
                if (a == b) return false;
            }
            foreach (USER_INFO item in listUserInfo)
            {
                if ((item.UserInfo_CMND.ToLower() == cmnd.ToLower())) return false;
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
            DateTime result = DateTime.Today;
            if (!DateTime.TryParse(importDate, out result)) return false;
            if (DateTime.Compare(result, DateTime.Today) != 0) return false;
            
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

            return this._regexAmount.IsMatch(price) 
                && this._regexAmount.IsMatch(amount) 
                && this._regexVietnameseWithNumber.IsMatch(name);
        }
    }
   
}
