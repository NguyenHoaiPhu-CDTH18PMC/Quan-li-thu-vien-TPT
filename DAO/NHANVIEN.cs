//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class NHANVIEN
    {
        public NHANVIEN()
        {
            this.LICHSUDANGNHAPs = new HashSet<LICHSUDANGNHAP>();
            this.PHIEUMUONs = new HashSet<PHIEUMUON>();
            this.PHIEUTRAs = new HashSet<PHIEUTRA>();
        }
    
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public System.DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string TK { get; set; }
        public string MK { get; set; }
        public string Quyen { get; set; }
        public string AnhDaiDien { get; set; }
        public bool XoaNV { get; set; }
    
        public virtual ICollection<LICHSUDANGNHAP> LICHSUDANGNHAPs { get; set; }
        public virtual ICollection<PHIEUMUON> PHIEUMUONs { get; set; }
        public virtual ICollection<PHIEUTRA> PHIEUTRAs { get; set; }
    }
}
