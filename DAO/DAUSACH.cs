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
    
    public partial class DAUSACH
    {
        public DAUSACH()
        {
            this.SACHes = new HashSet<SACH>();
        }
    
        public string MaDauSach { get; set; }
        public string TenDauSach { get; set; }
        public string MaTheLoai { get; set; }
        public bool XoaDauSach { get; set; }
    
        public virtual THELOAI THELOAI { get; set; }
        public virtual ICollection<SACH> SACHes { get; set; }
    }
}
