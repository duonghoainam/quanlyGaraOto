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
    using System;
    using System.Collections.Generic;
    
    public partial class RECEIPT
    {
        public int Receipt_Id { get; set; }
        public System.DateTime ReceiptDate { get; set; }
        public int MoneyReceived { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int IdReception { get; set; }
    
        public virtual RECEPTION RECEPTION { get; set; }
    }
}
