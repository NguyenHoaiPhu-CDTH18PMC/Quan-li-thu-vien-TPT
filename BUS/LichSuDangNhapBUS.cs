using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LichSuDangNhapBUS
    {
        LichSuDangNhapDAO LichSuDAO = new LichSuDangNhapDAO();

        public List<LichSuDangNhapDTO> DanhSachTruyCap()
        {
            return LichSuDAO.DanhSachTruyCap();
        }
        public bool LuuLichSu(LichSuDangNhapDTO LichSuDTO)
        {
            return LichSuDAO.LuuLichSu(LichSuDTO);
        }
         public bool XoaLichSu()
        {
            return LichSuDAO.XoaLichSu();
        }
    }
}
