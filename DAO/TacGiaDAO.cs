using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TacGiaDAO
    {
        /*static string ChuoiKetNoi = @"Data Source=DESKTOP-V17RVFI\MSSQLSERVERPHU;Initial Catalog=QuanLiThuVienTPT;Integrated Security=True";
        readonly SqlConnection conn = new SqlConnection(ChuoiKetNoi);
        public List<TacGiaDTO> DanhSachTG()
        {
           
            List<TacGiaDTO> Tacgias = new List<TacGiaDTO>();

            // Khởi tạo câu truy vấn
            string sql = "SELECT * FROM TACGIA ";

            conn.Open();

            // Khởi tạo đối tượng truy vấn
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Thực thi câu truy vấn
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                TacGiaDTO tacgia = new TacGiaDTO();

                tacgia.MaTacGia = reader.GetString(0);
                tacgia.HoTen= reader.GetString(1);
                tacgia.Email = reader.GetString(2);
                tacgia.DiaChi = reader.GetString(3);

                Tacgias.Add(tacgia);
            }
            conn.Close();
            return Tacgias;
        }
        public TacGiaDTO LayTacGiaTheoMa(string MaTacGia)
        {
           
            TacGiaDTO Tacgias = new TacGiaDTO();
            TacGiaDTO tacgia = new TacGiaDTO();
            // Khởi tạo câu truy vấn
            string sql = String.Format("SELECT * FROM TACGIA WHERE MaTacGia= '{0}'", MaTacGia);

            conn.Open();

            // Khởi tạo đối tượng truy vấn
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Thực thi câu truy vấn
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                tacgia.MaTacGia = reader.GetString(0);
                tacgia.HoTen = reader.GetString(1);
                tacgia.Email = reader.GetString(2);
                tacgia.DiaChi = reader.GetString(3);
            }
            conn.Close();
            return tacgia;
        }*/

        QuanLiThuVienTPTEntities db = new QuanLiThuVienTPTEntities();
        public List<TacGiaDTO> DanhSachTG()
        {
            List<TacGiaDTO> query = db.TACGIAs.Where(s => s.XoaTacGia == true).Select(u => new TacGiaDTO
            {
                MaTacGia=u.MaTacGia,
                HoTen=u.HoTen,
                Email=u.Email,
                DiaChi=u.DiaChi,
            }).ToList();
            return query;
        }
        public List<TacGiaDTO> DemDanhSachTG()
        {
            List<TacGiaDTO> query = db.TACGIAs.Select(u => new TacGiaDTO
            {
                MaTacGia = u.MaTacGia,
                HoTen = u.HoTen,
                Email = u.Email,
                DiaChi = u.DiaChi,
            }).ToList();
            return query;
        }

        public TacGiaDTO LayTacGiaTheoMa(string MaTacGia)
        {
            List<TacGiaDTO> query = db.TACGIAs.Where(s => s.XoaTacGia == true && s.MaTacGia == MaTacGia).Select(u => new TacGiaDTO
            {
                MaTacGia = u.MaTacGia,
                HoTen = u.HoTen,
                Email = u.Email,
                DiaChi = u.DiaChi,
            }).ToList();
            return query[0];
        }
        public bool ThemTG(TacGiaDTO u)
        {
            TACGIA tg = new TACGIA
            {
                MaTacGia = u.MaTacGia,
                HoTen = u.HoTen,
                Email = u.Email,
                DiaChi = u.DiaChi,
                XoaTacGia = true
            };

            db.TACGIAs.Add(tg);
            db.SaveChanges();
            return true;
        }
        public bool XoaTG(TacGiaDTO tgDTO)
        {
            TACGIA dg = (db.TACGIAs.Where(p => p.MaTacGia == tgDTO.MaTacGia).Select(s => s)).ToList()[0];
            dg.XoaTacGia = false;
            db.SaveChanges();

            return true;
        }
        public bool CapNhatTG(TacGiaDTO tgDTO)
        {
            TACGIA tg = (db.TACGIAs.Where(p => p.MaTacGia == tgDTO.MaTacGia && p.XoaTacGia == true).Select(s => s)).ToList()[0];
            tg.HoTen = tgDTO.HoTen;
            tg.Email = tgDTO.Email;
            tg.DiaChi = tgDTO.DiaChi;

            db.SaveChanges();

            return true;
        }
    }
}
