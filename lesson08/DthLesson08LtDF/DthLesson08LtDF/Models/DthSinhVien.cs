//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DthLesson08LtDF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DthSinhVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DthSinhVien()
        {
            this.DthKetQuas = new HashSet<DthKetQua>();
        }
    
        public string MaSV { get; set; }
        public string HoSV { get; set; }
        public string TenSV { get; set; }
        public Nullable<bool> Phai { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string NoiSinh { get; set; }
        public string MaKH { get; set; }
        public Nullable<decimal> HocBong { get; set; }
        public Nullable<double> DiemTrungBinh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DthKetQua> DthKetQuas { get; set; }
        public virtual DthKhoa DthKhoa { get; set; }
    }
}