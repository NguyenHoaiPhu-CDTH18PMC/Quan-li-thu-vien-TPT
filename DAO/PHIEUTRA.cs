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
    
    public partial class PHIEUTRA
    {
        public PHIEUTRA()
        {
            this.CHITIETPHIEUTRAs = new HashSet<CHITIETPHIEUTRA>();
        }
    
        public string MaPT { get; set; }
        public int SoLuongTra { get; set; }
        public Nullable<System.DateTime> NgayTra { get; set; }
        public string MaNV { get; set; }
        public string MaPM { get; set; }
        public bool XoaPhieuTra { get; set; }
    
        public virtual ICollection<CHITIETPHIEUTRA> CHITIETPHIEUTRAs { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
        public virtual PHIEUMUON PHIEUMUON { get; set; }
    }
}
