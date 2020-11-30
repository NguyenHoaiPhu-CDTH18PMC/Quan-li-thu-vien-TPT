using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TheDAO
    {
        static string ChuoiKetNoi = @"Data Source=DESKTOP-V17RVFI\MSSQLSERVERPHU;Initial Catalog=QuanLiThuVienTPT;Integrated Security=True";
        readonly SqlConnection conn = new SqlConnection(ChuoiKetNoi);
        public List<TheDTO> DSTHE()
        {
           
            List<TheDTO> Thes = new List<TheDTO>();

            // Khởi tạo câu truy vấn
            string sql = "SELECT * FROM THE ";

            conn.Open();

            // Khởi tạo đối tượng truy vấn
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Thực thi câu truy vấn
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                TheDTO the = new TheDTO();

                the.MaThe = reader.GetString(0);
                the.NgayBatDau = reader.GetDateTime(1);
                the.NgayKetThuc = reader.GetDateTime(2);
                the.MaDocGia = reader.GetString(3);

                Thes.Add(the);
            }
            conn.Close();
            return Thes;
        }
    }
}
