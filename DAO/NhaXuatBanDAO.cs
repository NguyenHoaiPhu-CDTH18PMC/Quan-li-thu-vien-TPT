using System;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    public class NhaXuatBanDAO
    {
        /*static string ChuoiKetNoi = @"Data Source=DESKTOP-V17RVFI\MSSQLSERVERPHU;Initial Catalog=QuanLiThuVienTPT;Integrated Security=True";
        readonly SqlConnection conn = new SqlConnection(ChuoiKetNoi);
        public List<NhaXuatBanDTO> LayDSNXB()
        {
            
            List<NhaXuatBanDTO> NXBs = new List<NhaXuatBanDTO>();

        // Khởi tạo câu truy vấn
        string sql = "SELECT * FROM NHAXUATBAN";

        conn.Open();

            // Khởi tạo đối tượng truy vấn
            SqlCommand cmd = new SqlCommand(sql, conn);

        // Thực thi câu truy vấn
        SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                NhaXuatBanDTO NXB = new NhaXuatBanDTO();
                NXB.MaNXB= reader.GetString(0);
                NXB.TenNXB = reader.GetString(1);
                NXB.DiaChi = reader.GetString(2);
                NXB.Email = reader.GetString(3);
                NXBs.Add(NXB);
            }
            conn.Close();
            return NXBs;
        }
        public NhaXuatBanDTO LayNXBTheoMa(string MaNXB)
        {
            NhaXuatBanDTO NXBs = new NhaXuatBanDTO();
            NhaXuatBanDTO NXB = new NhaXuatBanDTO();
            string sql = String.Format("SELECT * FROM NHAXUATBAN WHERE MaNXB= '{0}'", MaNXB);

            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                NXB.MaNXB = reader.GetString(0);
                NXB.TenNXB = reader.GetString(1);
                NXB.DiaChi = reader.GetString(2);
                NXB.Email = reader.GetString(3);
            }
            conn.Close();
            return NXB;
        }*/

        QuanLiThuVienTPTEntities db = new QuanLiThuVienTPTEntities();
        public List<NhaXuatBanDTO> LayDSNXB()
        {
            List<NhaXuatBanDTO> query = db.NHAXUATBANs.Where(s => s.XoaNXB == true).Select(u => new NhaXuatBanDTO
            {
                MaNXB = u.MaNXB,
                TenNXB = u.TenNXB,
                DiaChi = u.DiaChi,
                Email = u.Email, 
            }).ToList();
            return query;
        }
        public List<NhaXuatBanDTO> DemDSNXB()
        {
            List<NhaXuatBanDTO> query = db.NHAXUATBANs.Select(u => new NhaXuatBanDTO
            {
                MaNXB = u.MaNXB,
                TenNXB = u.TenNXB,
                DiaChi = u.DiaChi,
                Email = u.Email, 
            }).ToList();
            return query;
        }

        public NhaXuatBanDTO LayNXBTheoMa(string MaNXB)
        {
            List<NhaXuatBanDTO> query = db.NHAXUATBANs.Where(s => s.XoaNXB == true && s.MaNXB == MaNXB).Select(u => new NhaXuatBanDTO
            {
                MaNXB = u.MaNXB,
                TenNXB = u.TenNXB,
                DiaChi = u.DiaChi,
                Email = u.Email, 
            }).ToList();
            return query[0];
        }
        public bool ThemNXB(NhaXuatBanDTO u)
        {
            NHAXUATBAN nxb = new NHAXUATBAN
            {
                MaNXB = u.MaNXB,
                TenNXB = u.TenNXB,
                DiaChi = u.DiaChi,
                Email = u.Email, 
                XoaNXB = true
            };

            db.NHAXUATBANs.Add(nxb);
            db.SaveChanges();
            return true;
        }
        public bool XoaNXB(NhaXuatBanDTO nxbDTO)
        {
            NHAXUATBAN nxb = (db.NHAXUATBANs.Where(p => p.MaNXB == nxbDTO.MaNXB).Select(s => s)).ToList()[0];
            nxb.XoaNXB = false;
            db.SaveChanges();

            return true;
        }
        public bool CapNhatNXB(NhaXuatBanDTO nxbDTO)
        {
            NHAXUATBAN nxb = (db.NHAXUATBANs.Where(p => p.MaNXB== nxbDTO.MaNXB && p.XoaNXB == true).Select(s => s)).ToList()[0];
            nxb.TenNXB = nxbDTO.TenNXB;
            nxb.DiaChi = nxbDTO.DiaChi;
            nxb.Email = nxbDTO.Email;

            db.SaveChanges();

            return true;
        }
    }
}
