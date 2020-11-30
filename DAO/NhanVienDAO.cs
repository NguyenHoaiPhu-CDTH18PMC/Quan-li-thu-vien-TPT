using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhanVienDAO
    {
        /*static string ChuoiKetNoi = @"Data Source=DESKTOP-V17RVFI;Initial Catalog=QuanLiThuVienTPT;Integrated Security=True";
        readonly SqlConnection conn = new SqlConnection(ChuoiKetNoi);
        public List<NhanVienDTO> DanhSachNV()
        {
            List<NhanVienDTO> NhanViens = new List<NhanVienDTO>();

            // Khởi tạo câu truy vấn
            string sql = "SELECT * FROM NHANVIEN ";

            conn.Open(); 

            // Khởi tạo đối tượng truy vấn
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Thực thi câu truy vấn
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                NhanVienDTO nhanvien = new NhanVienDTO();

                nhanvien.MaNV = reader.GetString(0);
                nhanvien.TenNV = reader.GetString(1);
                nhanvien.NgaySinh = reader.GetDateTime(2);
                nhanvien.GioiTinh = reader.GetString(3);
                nhanvien.DiaChi = reader.GetString(4);
                nhanvien.Email = reader.GetString(5);
                nhanvien.Phone = reader.GetString(6);
                nhanvien.TK = reader.GetString(7);
                nhanvien.MK = reader.GetString(8);
                nhanvien.Quyen = reader.GetString(9);
                //nhanvien.AnhDaiDien = reader.
                NhanViens.Add(nhanvien);
            }
            conn.Close();
            return NhanViens;
        }
        public NhanVienDTO LayMKTheoTK(string TK)
        {
          
            NhanVienDTO nhanvien = new NhanVienDTO();

            string sql = String.Format("SELECT * FROM NHANVIEN WHERE TK = '{0}'", TK);

            conn.Open();


            SqlCommand cmd = new SqlCommand(sql, conn);


            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                nhanvien.MaNV = reader.GetString(0);
                nhanvien.TenNV = reader.GetString(1);
                nhanvien.NgaySinh = reader.GetDateTime(2);
                nhanvien.GioiTinh = reader.GetString(3);
                nhanvien.DiaChi = reader.GetString(4);
                nhanvien.Email = reader.GetString(5);
                nhanvien.Phone = reader.GetString(6);
                nhanvien.TK = reader.GetString(7);
                nhanvien.MK = reader.GetString(8);
                nhanvien.Quyen = reader.GetString(9);
            }
            conn.Close();
            return nhanvien;
        }
        public NhanVienDTO LayNhanVienTheoMa(string MaNV)
        {


            NhanVienDTO nhanvien = new NhanVienDTO();

            string sql = String.Format("SELECT * FROM NHANVIEN WHERE MaNV = '{0}'", MaNV);

            conn.Open();


            SqlCommand cmd = new SqlCommand(sql, conn);


            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                nhanvien.MaNV = reader.GetString(0);
                nhanvien.TenNV = reader.GetString(1);
                nhanvien.NgaySinh = reader.GetDateTime(2);
                nhanvien.GioiTinh = reader.GetString(3);
                nhanvien.DiaChi = reader.GetString(4);
                nhanvien.Email = reader.GetString(5);
                nhanvien.Phone = reader.GetString(6);
                nhanvien.TK = reader.GetString(7);
                nhanvien.MK = reader.GetString(8);
                nhanvien.Quyen = reader.GetString(9);
            }
            conn.Close();
            return nhanvien;
        }
        public bool ThemNV(NhanVienDTO nv)
        {

            string sql = "INSERT INTO NHANVIEN(MaNV, TenNV , NgaySinh , GioiTinh , DiaChi , Email , Phone , TK , MK , Quyen , XoaNV) VALUES('{0}', N'{1}', N'{2}', N'{3}', N'{4}', '{5}', '{6}', '{7}' , '{8}', '{9}' , '{10}')"; // Thêm N'{1}' để nhập chữ có dấu
            string sqlFormat = string.Format(sql, nv.MaNV , nv.TenNV , nv.NgaySinh.ToString("yyyy/MM/dd") , nv.GioiTinh , nv.DiaChi , nv.Email , nv.Phone , nv.TK , nv.MK, nv.Quyen  , nv.XoaNV);

            conn.Open();

            // Khởi tạo đối tượng truy vấn
            SqlCommand cmd = new SqlCommand(sqlFormat, conn);
            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            conn.Close();
            return false;
            /*string sql = "INSERT INTO NHANVIEN(MaNV, TenNV , NgaySinh , GioiTinh , DiaChi , Email , Phone , TK , MK , Quyen , AnhDaiDien, XoaNV) VALUES('{0}', N'{1}', N'{2}', N'{3}', N'{4}', '{5}', '{6}', '{7}' , '{8}', '{9}' , '{10}' , '{11}')"; // Thêm N'{1}' để nhập chữ có dấu
            string sqlFormat = string.Format(sql, nv.MaNV, nv.TenNV, nv.NgaySinh.ToString("yyyy/MM/dd"), nv.GioiTinh, nv.DiaChi, nv.Email, nv.Phone, nv.TK, nv.MK, nv.Quyen, nv.AnhDaiDien, nv.XoaNV);

            conn.Open();

            // Khởi tạo đối tượng truy vấn
            SqlCommand cmd = new SqlCommand(sqlFormat, conn);
            cmd.Parameters.Add(new SqlParameter("@img" , "{10}"));
            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            conn.Close();
            return false;
        }*/

        QuanLiThuVienTPTEntities db = new QuanLiThuVienTPTEntities();
        public List<NhanVienDTO> DanhSachNV()
        {
            List<NhanVienDTO> query = db.NHANVIENs.Where(s => s.XoaNV == true && s.MaNV.Contains("NV")).Select(p => new NhanVienDTO
            {
                MaNV =p.MaNV,
                TenNV =p.TenNV,
                NgaySinh =p.NgaySinh,
                GioiTinh = p.GioiTinh,
                DiaChi=p.DiaChi,
                Email=p.Email,
                Phone=p.Phone,
                TK=p.TK,
                MK=p.MK,
                Quyen=p.Quyen,
                AnhDaiDien=p.AnhDaiDien
            }).ToList();
            return query;
        }
        public List<NhanVienDTO> DemDanhSachNV()
        {
            List<NhanVienDTO> query = db.NHANVIENs.Select(p => new NhanVienDTO
            {
                MaNV = p.MaNV,
                TenNV = p.TenNV,
                NgaySinh = p.NgaySinh,
                GioiTinh = p.GioiTinh,
                DiaChi = p.DiaChi,
                Email = p.Email,
                Phone = p.Phone,
                TK = p.TK,
                MK = p.MK,
                Quyen = p.Quyen,
                AnhDaiDien = p.AnhDaiDien
            }).ToList();
            return query;
        }
        public NhanVienDTO LayMKTheoTK(string TK)
        {
            List<NhanVienDTO> query = db.NHANVIENs.Where(s => s.XoaNV == true && s.TK == TK).Select(p => new NhanVienDTO
            {
                MaNV = p.MaNV,
                TenNV = p.TenNV,
                NgaySinh = p.NgaySinh,
                GioiTinh = p.GioiTinh,
                DiaChi = p.DiaChi,
                Email = p.Email,
                Phone = p.Phone,
                TK = p.TK,
                MK = p.MK,
                Quyen = p.Quyen,
                AnhDaiDien=p.AnhDaiDien
            }).ToList();
           return query[0];
        }
        public NhanVienDTO LayNhanVienTheoMa(string MaNV)
        {
            List<NhanVienDTO> query = db.NHANVIENs.Where(s => s.XoaNV == true && s.MaNV == MaNV).Select(p => new NhanVienDTO
            {
                MaNV = p.MaNV,
                TenNV = p.TenNV,
                NgaySinh = p.NgaySinh,
                GioiTinh = p.GioiTinh,
                DiaChi = p.DiaChi,
                Email = p.Email,
                Phone = p.Phone,
                TK = p.TK,
                MK = p.MK,
                Quyen = p.Quyen,
                AnhDaiDien = p.AnhDaiDien
            }).ToList();
            return query[0];
        }
        public bool ThemNV(NhanVienDTO p)
        {
            NHANVIEN nv = new NHANVIEN();
                nv.MaNV = p.MaNV;
                nv.TenNV = p.TenNV;
                nv.NgaySinh = p.NgaySinh;
                nv.GioiTinh = p.GioiTinh;
                nv.DiaChi = p.DiaChi;
                nv.Email = p.Email;
                nv.Phone = p.Phone;
                nv.TK = p.TK;
                nv.MK = p.MK;
                nv.Quyen = p.Quyen;
                nv.AnhDaiDien = p.AnhDaiDien;
                nv.XoaNV = true;

            db.NHANVIENs.Add(nv);
            db.SaveChanges();

            return true;
        }
        public bool CapNhatNV(NhanVienDTO nvDTO)
        {
            NHANVIEN nv = (db.NHANVIENs.Where(p => p.MaNV == nvDTO.MaNV && p.XoaNV==true).Select(s => s)).ToList()[0];
            nv.MaNV = nvDTO.MaNV;
            nv.TenNV = nvDTO.TenNV;
            nv.NgaySinh = nvDTO.NgaySinh;
            nv.DiaChi = nvDTO.DiaChi;
            nv.Email = nvDTO.Email;
            nv.Phone = nvDTO.Phone;
            nv.TK = nvDTO.TK;
            nv.MK = nvDTO.MK;
            nv.AnhDaiDien = nvDTO.AnhDaiDien;
            db.SaveChanges();
            return true;
        }
        public bool XoaNV(NhanVienDTO nvDTO)
        {
            NHANVIEN nv = (db.NHANVIENs.Where(p => p.MaNV == nvDTO.MaNV ).Select(s => s)).ToList()[0];
            nv.XoaNV = false;
            db.SaveChanges();

            return true;
        }
    }
}
