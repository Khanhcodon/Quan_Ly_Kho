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
    
    public partial class HangHoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HangHoa()
        {
            this.Chitietnhaps = new HashSet<Chitietnhap>();
            this.Chitietxuats = new HashSet<Chitietxuat>();
        }
    
        public string maHH { get; set; }
        public string tenHH { get; set; }
        public string maNCC { get; set; }
        public Nullable<int> soluong { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chitietnhap> Chitietnhaps { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chitietxuat> Chitietxuats { get; set; }
        public virtual NCC NCC { get; set; }
    }
}