using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TheLoaiBUS
    {
        TheLoaiDAO LoaiDAO = new TheLoaiDAO();
        public List<TheLoaiDTO> DanhSachTL()
        {
            return LoaiDAO.DanhSachTL();
        }
        public TheLoaiDTO LayTheLoaiTheoMa(string MaTheLoai)
        {
            return LoaiDAO.LayTheLoaiTheoMa(MaTheLoai);
        }
    }
}
