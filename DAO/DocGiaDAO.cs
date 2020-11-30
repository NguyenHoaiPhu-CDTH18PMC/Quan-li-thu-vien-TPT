using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DocGiaDAO
    {
        /*static string ChuoiKetNoi = @"Data Source=DESKTOP-V17RVFI;Initial Catalog=QuanLiThuVienTPT;Integrated Security=True";
        readonly SqlConnection conn = new SqlConnection(ChuoiKetNoi);
        public List<DocGiaDTO> LayDSDG()
        {
            List<DocGiaDTO> docgias = new List<DocGiaDTO>();

            // Khởi tạo câu truy vấn
            string sql = "SELECT * FROM DOCGIA WHERE XoaDocGia = 1";

            conn.Open();

            // Khởi tạo đối tượng truy vấn
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Thực thi câu truy vấn
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DocGiaDTO docgia = new DocGiaDTO();
                docgia.MaDocGia = reader.GetString(0);
                docgia.TenDocGia = reader.GetString(1);
                docgia.GioiTinh = reader.GetString(2);
                docgia.DiaChi = reader.GetString(3);
                docgia.Email = reader.GetString(4);
                docgia.Phone = reader.GetString(5);
                docgia.Khoa = reader.GetString(6);
                docgia.Lop = reader.GetString(7);
                docgia.XoaDocGia = reader.GetBoolean(8);
                docgias.Add(docgia);
            }
            conn.Close();
            return docgias;
        }
        public DocGiaDTO LayDGTheoMa(string MaDocGia)
        {
            
            DocGiaDTO docgia = new DocGiaDTO();

            // Khởi tạo câu truy vấn
            string sql = String.Format("SELECT * FROM DOCGIA WHERE MaDocGia= '{0}' AND XoaDocGia = 1 ", MaDocGia);
            conn.Open();

            // Khởi tạo đối tượng truy vấn
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Thực thi câu truy vấn
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                docgia.MaDocGia = reader.GetString(0);
                docgia.TenDocGia = reader.GetString(1);
                docgia.GioiTinh = reader.GetString(2);
                docgia.DiaChi = reader.GetString(3);
                docgia.Email = reader.GetString(4);
                docgia.Phone = reader.GetString(5);
                docgia.Khoa = reader.GetString(6);
                docgia.Lop = reader.GetString(7);
                docgia.XoaDocGia = reader.GetBoolean(8);
            }
            conn.Close();
            return docgia;
        }*/
        QuanLiThuVienTPTEntities db = new QuanLiThuVienTPTEntities();
        public List<DocGiaDTO> LayDSDG()
        {
            List<DocGiaDTO> query = db.DOCGIAs.Where(s => s.XoaDocGia == true).Select(u => new DocGiaDTO
            {
                MaDocGia = u.MaDocGia,
                TenDocGia = u.TenDocGia,
                GioiTinh = u.GioiTinh,
                DiaChi = u.DiaChi,
                Email = u.Email,
                Phone = u.Phone,
                Khoa = u.Khoa,
                Lop = u.Lop,
            }).ToList();
            return query;
        }

        public DocGiaDTO LayDGTheoMa(string MaDocGia)
        {
            List<DocGiaDTO> query = db.DOCGIAs.Where(s => s.XoaDocGia == true && s.MaDocGia == MaDocGia).Select(u => new DocGiaDTO
            {
                MaDocGia = u.MaDocGia,
                TenDocGia = u.TenDocGia,
                GioiTinh = u.GioiTinh,
                DiaChi = u.DiaChi,
                Email = u.Email,
                Phone = u.Phone,
                Khoa = u.Khoa,
                Lop = u.Lop,
            }).ToList();
            return query[0];
        }
        public bool ThemDG(DocGiaDTO p)
        {
                DOCGIA dg = new DOCGIA
            {
                MaDocGia=p.MaDocGia,
                TenDocGia=p.TenDocGia,
                GioiTinh=p.GioiTinh,
                DiaChi=p.DiaChi,
                Email=p.Email,
                Phone=p.Phone,
                Khoa=p.Khoa,
                Lop=p.Lop,
                XoaDocGia=p.XoaDocGia
            };

            db.DOCGIAs.Add(dg);
            db.SaveChanges();
            return true;
        }
        public bool XoaDG(DocGiaDTO dgDTO)
        {
            DOCGIA dg = (db.DOCGIAs.Where(p => p.MaDocGia == dgDTO.MaDocGia).Select(s => s)).ToList()[0];
            dg.XoaDocGia = false;
            db.SaveChanges();

            return true;
        }
        public bool CapNhatDG(DocGiaDTO dgDTO)
        {
            DOCGIA dg = (db.DOCGIAs.Where(p => p.MaDocGia == dgDTO.MaDocGia && p.XoaDocGia == true).Select(s => s)).ToList()[0];
            dg.TenDocGia = dgDTO.TenDocGia;
            dg.GioiTinh = dgDTO.GioiTinh;
            dg.DiaChi = dgDTO.DiaChi;
            dg.Email = dgDTO.Email;
            dg.Phone = dgDTO.Phone;
            dg.Khoa = dgDTO.Khoa;
            dg.Lop = dgDTO.Lop;

            db.SaveChanges();

            return true;
        }
    }
}
