using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DauSachDAO
    {
        /*static string ChuoiKetNoi = @"Data Source=DESKTOP-V17RVFI\MSSQLSERVERPHU;Initial Catalog=QuanLiThuVienTPT;Integrated Security=True";
        readonly SqlConnection conn = new SqlConnection(ChuoiKetNoi);
        public List<DauSachDTO> DanhSachDauSach()
        {

            List<DauSachDTO> DauSachs = new List<DauSachDTO>();

            // Khởi tạo câu truy vấn
            string sql = "SELECT * FROM DAUSACH ";

            conn.Open();

            // Khởi tạo đối tượng truy vấn
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Thực thi câu truy vấn
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DauSachDTO ds = new DauSachDTO();

                ds.MaDauSach = reader.GetString(0);
                ds.TenDauSach = reader.GetString(1);
                ds.MaTheLoai = reader.GetString(2);
                DauSachs.Add(ds);
            }
            conn.Close();
            return DauSachs;
        }
        public DauSachDTO LayDauSachTheoMa(string MaDauSach)
        {

            DauSachDTO DauSachs = new DauSachDTO();
            DauSachDTO ds = new DauSachDTO();
            // Khởi tạo câu truy vấn
            string sql = String.Format("SELECT * FROM DAUSACH WHERE MaDauSach= '{0}'", MaDauSach);

            conn.Open();

            // Khởi tạo đối tượng truy vấn
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Thực thi câu truy vấn
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {


                ds.MaDauSach = reader.GetString(0);
                ds.TenDauSach = reader.GetString(1);
                ds.MaTheLoai = reader.GetString(2);
            }
            conn.Close();
            return ds;
        }*/

        QuanLiThuVienTPTEntities db = new QuanLiThuVienTPTEntities();
        public List<DauSachDTO> DanhSachDauSach()
        {
            List<DauSachDTO> query = db.DAUSACHes.Where(s => s.XoaDauSach == true).Select(u => new DauSachDTO
            {
                MaDauSach = u.MaDauSach,
                TenDauSach = u.TenDauSach,
                MaTheLoai = u.MaTheLoai,
            }).ToList();
            return query;
        }
        public List<DauSachDTO> DemDSDS()
        {
            List<DauSachDTO> query = db.DAUSACHes.Select(u => new DauSachDTO
            {
                MaDauSach = u.MaDauSach,
                TenDauSach = u.TenDauSach,
                MaTheLoai = u.MaTheLoai,
            }).ToList();
            return query;
        }

        public DauSachDTO LayDauSachTheoMa(string MaDauSach)
        {
            List<DauSachDTO> query = db.DAUSACHes.Where(s => s.XoaDauSach == true && s.MaDauSach == MaDauSach).Select(u => new DauSachDTO
            {
                MaDauSach = u.MaDauSach,
                TenDauSach = u.TenDauSach,
                MaTheLoai = u.MaTheLoai,
            }).ToList();
            return query[0];
        }
        public bool ThemDS(DauSachDTO u)
        {
            DAUSACH ds = new DAUSACH();

                ds.MaDauSach = u.MaDauSach;
                ds.TenDauSach = u.TenDauSach;
                ds.MaTheLoai = u.MaTheLoai;
                ds.XoaDauSach = true;

            db.DAUSACHes.Add(ds);
            db.SaveChanges();
            return true;
        }
        public bool XoaDS(DauSachDTO dsDTO)
        {
            DAUSACH nxb = (db.DAUSACHes.Where(p => p.MaDauSach == dsDTO.MaDauSach).Select(s => s)).ToList()[0];
            nxb.XoaDauSach = false;
            db.SaveChanges();

            return true;
        }
        public bool CapNhatDS(DauSachDTO dsDTO)
        {
            DAUSACH ds = (db.DAUSACHes.Where(p => p.MaDauSach == dsDTO.MaDauSach && p.XoaDauSach == true).Select(s => s)).ToList()[0];
            ds.TenDauSach = dsDTO.TenDauSach;
            ds.MaTheLoai = dsDTO.MaTheLoai;
            db.SaveChanges();

            return true;
        }
    }
}
