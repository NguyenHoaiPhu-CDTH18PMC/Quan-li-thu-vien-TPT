using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO 
{
    public class SachDAO
    {
        /*static string ChuoiKetNoi = @"Data Source=DESKTOP-V17RVFI;Initial Catalog=QuanLiThuVienTPT;Integrated Security=True";
        readonly SqlConnection conn = new SqlConnection(ChuoiKetNoi);

        public List<SachDTO> DanhMucSach()
        {
           
            List<SachDTO> Sachs = new List<SachDTO>();

            // Khởi tạo câu truy vấn
            string sql = "SELECT * FROM SACH WHERE XoaSach = 1 ";

            conn.Open();

            // Khởi tạo đối tượng truy vấn
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Thực thi câu truy vấn
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                SachDTO book = new SachDTO();

                book.MaSach = reader.GetString(0);
                book.TenSach = reader.GetString(1);
                book.MaTacGia = reader.GetString(2);
                book.MaDauSach = reader.GetString(3);
                book.MaNXB = reader.GetString(4);
                book.NamXB = reader.GetInt32(5);
                book.GiaTien = reader.GetDecimal(6);
                book.SLTon = reader.GetInt32(7);
                book.XoaSach = reader.GetBoolean(8);
                Sachs.Add(book);
            }
            conn.Close();
            return Sachs;
        }
        public SachDTO LaySachTheoMaSach(string MaSach)
        {
           
            SachDTO Sachs = new SachDTO();
            SachDTO book = new SachDTO();
            // Khởi tạo câu truy vấn
            string sql = String.Format("SELECT * FROM SACH WHERE MaSach= '{0}' AND XoaSach = 1", MaSach);

            conn.Open();

            // Khởi tạo đối tượng truy vấn
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Thực thi câu truy vấn
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                book.MaSach = reader.GetString(0);
                book.TenSach = reader.GetString(1);
                book.MaTacGia = reader.GetString(2);
                book.MaDauSach = reader.GetString(3);
                book.MaNXB = reader.GetString(4);
                book.NamXB = reader.GetInt32(5);
                book.GiaTien = reader.GetDecimal(6);
                book.SLTon = reader.GetInt32(7);
                book.XoaSach = reader.GetBoolean(8);
            }
            conn.Close();
            return book;
        }
        public bool ThemSach(SachDTO book)
        {

            // Khởi tạo câu truy vấn
            string sql = "INSERT INTO SACH(MaSach , TenSach , MaTacGia , MaTheLoai , MaNXB , NamXB , GiaTien , SLTon , XoaSach) VALUES('{0}', N'{1}', N'{2}', N'{3}', N'{4}', '{5}', '{6}', '{7}' , '{8}')"; // Thêm N'{1}' để nhập chữ có dấu
            string sqlFormat = string.Format(sql, book.MaSach , book.TenSach, book.MaTacGia, book.MaDauSach, book.MaNXB, book.NamXB, book.GiaTien, book.SLTon, book.XoaSach);

            conn.Open();

            // Khởi tạo đối tượng truy vấn
            SqlCommand cmd = new SqlCommand(sqlFormat, conn);
            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            conn.Close();
            return false;
            

        }
        public bool XoaSach(SachDTO book)
        {

            // Khởi tạo câu truy vấn
            string sql = "UPDATE SACH SET XoaSach = 0 WHERE MaSach = '{0}' ";
            string sqlFormat = string.Format(sql, book.MaSach);
            conn.Open();

            // Khởi tạo đối tượng truy vấn
            SqlCommand cmd = new SqlCommand(sqlFormat, conn);
            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            conn.Close();
            return false;    
        }*/

        QuanLiThuVienTPTEntities db = new QuanLiThuVienTPTEntities();
        public List<SachDTO> DanhMucSach()
        {
            List<SachDTO> query = db.SACHes.Where(s => s.XoaSach == true).Select(p => new SachDTO
            {
                MaSach = p.MaSach,
                TenSach = p.TenSach,
                MaTacGia = p.MaTacGia,
                MaDauSach = p.MaDauSach,
                MaNXB = p.MaNXB,
                NamXB = p.NamXB,
                GiaTien = p.GiaTien,
                SLTon = p.SLTon
            }).ToList();
            return query;
        }
        public List<SachDTO> HetSach()
        {
            List<SachDTO> query = db.SACHes.Where(s => s.XoaSach == true && s.SLTon==0).Select(p => new SachDTO
            {
                MaSach = p.MaSach,
                TenSach = p.TenSach,
                MaTacGia = p.MaTacGia,
                MaDauSach = p.MaDauSach,
                MaNXB = p.MaNXB,
                NamXB = p.NamXB,
                GiaTien = p.GiaTien,
                SLTon = p.SLTon
            }).ToList();
            return query;
        }
        public List<SachDTO> DemDanhMucSach()
        {
            List<SachDTO> query = db.SACHes.Select(p => new SachDTO
            {
                MaSach = p.MaSach,
                TenSach = p.TenSach,
                MaTacGia = p.MaTacGia,
                MaDauSach = p.MaDauSach,
                MaNXB = p.MaNXB,
                NamXB = p.NamXB,
                GiaTien = p.GiaTien,
                SLTon = p.SLTon
            }).ToList();
            return query;
        }
        public SachDTO LaySachTheoMaSach(string MaSach)
        {
            List<SachDTO> query = db.SACHes.Where(s => s.XoaSach == true && s.MaSach == MaSach).Select(p => new SachDTO
            {
                MaSach = p.MaSach,
                TenSach = p.TenSach,
                MaTacGia = p.MaTacGia,
                MaDauSach = p.MaDauSach,
                MaNXB = p.MaNXB,
                NamXB = p.NamXB,
                GiaTien = p.GiaTien,
                SLTon = p.SLTon
            }).ToList();
            return query[0];
        }
        public List<SachDTO> LaySachTheoDauSach(string DauSach)
        {
            List<SachDTO> query = db.SACHes.Where(s => s.XoaSach == true && s.MaDauSach == DauSach).Select(p => new SachDTO
            {
                MaSach = p.MaSach,
                TenSach = p.TenSach,
                MaTacGia = p.MaTacGia,
                MaDauSach = p.MaDauSach,
                MaNXB = p.MaNXB,
                NamXB = p.NamXB,
                GiaTien = p.GiaTien,
                SLTon = p.SLTon
            }).ToList();
            return query;
        }
        public bool ThemSach(SachDTO p)
        {
            SACH sach = new SACH
            {
                MaSach = p.MaSach,
                TenSach = p.TenSach,
                MaTacGia = p.MaTacGia,
                MaDauSach = p.MaDauSach,
                MaNXB = p.MaNXB,
                NamXB = p.NamXB,
                GiaTien = p.GiaTien,
                SLTon = p.SLTon,
                XoaSach = true
            };

            db.SACHes.Add(sach);
            db.SaveChanges();

            return true;
        }
        public bool CapNhatSach(SachDTO bookDTO)
        {
            SACH sach = (db.SACHes.Where(p => p.MaSach == bookDTO.MaSach && p.XoaSach==true).Select(s => s)).ToList()[0];
            sach.TenSach = bookDTO.TenSach;
            sach.MaTacGia = bookDTO.MaTacGia;
            sach.MaDauSach = bookDTO.MaDauSach;
            sach.MaNXB = bookDTO.MaNXB;
            sach.NamXB = bookDTO.NamXB;
            sach.GiaTien = bookDTO.GiaTien;
            sach.SLTon = bookDTO.SLTon;

            db.SaveChanges();

            return true;
        }
        public bool XoaSach(SachDTO bookDTO)
        {
            SACH sach = (db.SACHes.Where(p => p.MaSach == bookDTO.MaSach).Select(s => s)).ToList()[0];
            sach.XoaSach = false;
            db.SaveChanges();

            return true;
        }
       
    }
}
