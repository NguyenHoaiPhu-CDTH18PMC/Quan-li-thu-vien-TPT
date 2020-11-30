using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LichSuDangNhapDAO
    {
        static string ChuoiKetNoi = @"Data Source=DESKTOP-V17RVFI\MSSQLSERVERPHU;Initial Catalog=QuanLiThuVienTPT;Integrated Security=True";
        readonly SqlConnection conn = new SqlConnection(ChuoiKetNoi);

        public List<LichSuDangNhapDTO> DanhSachTruyCap()
        {
            
            List<LichSuDangNhapDTO> LichSus = new List<LichSuDangNhapDTO>();

            // Khởi tạo câu truy vấn
            string sql = "SELECT * FROM LICHSUDANGNHAP WHERE XoaLS = 1";

            conn.Open();

            // Khởi tạo đối tượng truy vấn
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Thực thi câu truy vấn
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                LichSuDangNhapDTO history = new LichSuDangNhapDTO();
                history.ID = reader.GetInt32(0);
                history.MaNV = reader.GetString(1);
                history.TGDangNhap = reader.GetDateTime(2);
                history.XoaLS = reader.GetBoolean(3);
                LichSus.Add(history);
            }
            conn.Close();
            return LichSus;
        }
        public bool LuuLichSu(LichSuDangNhapDTO history)
        {

            // Khởi tạo câu truy vấn
            string sql = "INSERT INTO LICHSUDANGNHAP (MaNV , TGDangNhap , XoaLS) VALUES('{0}', GETDATE() , '{1}')"; // Thêm N'{1}' để nhập chữ có dấu
            string sqlFormat = string.Format(sql, history.MaNV , history.XoaLS);
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
         public bool XoaLichSu()
        {

            // Khởi tạo câu truy vấn
            string sql = " DELETE  FROM LICHSUDANGNHAP"; // Thêm N'{1}' để nhập chữ có dấu
            conn.Open();
            // Khởi tạo đối tượng truy vấn
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            conn.Close();
            return false;
        }
        
    }
}
