//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyGaraOto.Model
{
    using QuanLyGaraOto.ViewModel;
    using System;
    using System.Collections.Generic;
    
    public partial class IMPORT_GOODS : BaseViewModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IMPORT_GOODS()
        {
            this.IMPORT_GOODS_DETAIL = new HashSet<IMPORT_GOODS_DETAIL>();
        }
    
        public int ImportGoods_Id { get; set; }
        private System.DateTime _ImportGoods_Date { get; set; }
        public System.DateTime ImportGoods_Date { get => _ImportGoods_Date; set { _ImportGoods_Date = value; OnPropertyChanged(); } }
        private int _ImportGoods_TotalMoney { get; set; }
        public int ImportGoods_TotalMoney { get => _ImportGoods_TotalMoney; set { _ImportGoods_TotalMoney = value; OnPropertyChanged(); } }
        private string _ImportGoods_Supplier { get; set; }
        public string ImportGoods_Supplier { get => _ImportGoods_Supplier; set { _ImportGoods_Supplier = value; OnPropertyChanged(); } }
        private string _ImportGoods_UserName { get; set; }
        public string ImportGoods_UserName { get=>_ImportGoods_UserName; set { _ImportGoods_UserName = value; OnPropertyChanged(); } }
        private int _IdUser { get; set; }
        public int IdUser { get => _IdUser; set { _IdUser = value; OnPropertyChanged(); } }
        private int _IdSupplier { get; set; }
        public int IdSupplier { get => _IdSupplier; set { _IdSupplier = value; OnPropertyChanged(); } }
    
        public virtual SUPPLIER SUPPLIER { get; set; }
        public virtual USER USER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IMPORT_GOODS_DETAIL> IMPORT_GOODS_DETAIL { get; set; }
    }
}