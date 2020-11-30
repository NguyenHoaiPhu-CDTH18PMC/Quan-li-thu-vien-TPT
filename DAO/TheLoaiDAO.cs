using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TheLoaiDAO
    {
        static string ChuoiKetNoi = @"Data Source=DESKTOP-V17RVFI\MSSQLSERVERPHU;Initial Catalog=QuanLiThuVienTPT;Integrated Security=True";
        readonly SqlConnection conn = new SqlConnection(ChuoiKetNoi);
        public List<DTO.TheLoaiDTO> DanhSachTL()
        {
            
            List<DTO.TheLoaiDTO> TheLoais = new List<DTO.TheLoaiDTO>();

            // Khởi tạo câu truy vấn
            string sql = "SELECT * FROM THELOAI ";

            conn.Open();

            // Khởi tạo đối tượng truy vấn
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Thực thi câu truy vấn
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DTO.TheLoaiDTO loai = new DTO.TheLoaiDTO();

                loai.MaTheLoai = reader.GetString(0);
                loai.TenTheLoai = reader.GetString(1);            

                TheLoais.Add(loai);
            }
            conn.Close();
            return TheLoais;
        }
        public TheLoaiDTO LayTheLoaiTheoMa(string MaTheLoai)
        {
            
            TheLoaiDTO TheLoais = new TheLoaiDTO();
            TheLoaiDTO loai = new DTO.TheLoaiDTO();
            // Khởi tạo câu truy vấn
            string sql = String.Format("SELECT * FROM THELOAI WHERE MaTheLoai= '{0}'", MaTheLoai);

            conn.Open();

            // Khởi tạo đối tượng truy vấn
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Thực thi câu truy vấn
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                

                loai.MaTheLoai = reader.GetString(0);
                loai.TenTheLoai = reader.GetString(1);
            }
            conn.Close();
            return loai;
        }
    }
}
