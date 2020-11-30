using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TacGiaBUS
    {
        TacGiaDAO TacGiaDAO = new TacGiaDAO();
        public List<TacGiaDTO> DanhSachTG()
        {
            return TacGiaDAO.DanhSachTG();
        }
        public List<TacGiaDTO> DemDanhSachTG()
        {
            return TacGiaDAO.DemDanhSachTG();
        }
        public TacGiaDTO LayTacGiaTheoMa(string MaTacGia)
        {
            return TacGiaDAO.LayTacGiaTheoMa(MaTacGia);
        }
        public bool ThemTG(TacGiaDTO tgDTO)
        {
            return TacGiaDAO.ThemTG(tgDTO);
        }
        public bool CapNhatTG(TacGiaDTO tgDTO)
        {
            return TacGiaDAO.CapNhatTG(tgDTO);
        }
        public bool XoaTG(TacGiaDTO tgDTO)
        {
            return TacGiaDAO.XoaTG(tgDTO);
        }
    }
}
