﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLiThuVienTPTEntities : DbContext
    {
        public QuanLiThuVienTPTEntities()
            : base("name=QuanLiThuVienTPTEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CHITIETPHIEUMUON> CHITIETPHIEUMUONs { get; set; }
        public virtual DbSet<CHITIETPHIEUTRA> CHITIETPHIEUTRAs { get; set; }
        public virtual DbSet<DAUSACH> DAUSACHes { get; set; }
        public virtual DbSet<DOCGIA> DOCGIAs { get; set; }
        public virtual DbSet<LICHSUDANGNHAP> LICHSUDANGNHAPs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<NHAXUATBAN> NHAXUATBANs { get; set; }
        public virtual DbSet<PHIEUMUON> PHIEUMUONs { get; set; }
        public virtual DbSet<PHIEUTRA> PHIEUTRAs { get; set; }
        public virtual DbSet<SACH> SACHes { get; set; }
        public virtual DbSet<TACGIA> TACGIAs { get; set; }
        public virtual DbSet<THELOAI> THELOAIs { get; set; }
    }
}
