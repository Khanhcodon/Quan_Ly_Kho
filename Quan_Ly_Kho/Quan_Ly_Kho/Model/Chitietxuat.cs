//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quan_Ly_Kho.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Chitietxuat
    {
        public string maPX { get; set; }
        public string maHH { get; set; }
        public Nullable<int> soLuong { get; set; }
        public Nullable<decimal> thanhTien { get; set; }
    
        public virtual HangHoa HangHoa { get; set; }
        public virtual PhieuXuat PhieuXuat { get; set; }
    }
}
