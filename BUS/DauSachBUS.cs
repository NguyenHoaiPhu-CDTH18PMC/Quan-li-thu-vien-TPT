using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DauSachBUS
    {
        DauSachDAO DauSachDAO = new DauSachDAO();
        public List<DauSachDTO> DanhSachDauSach()
        {
            return DauSachDAO.DanhSachDauSach();
        }
        public DauSachDTO LayDauSachTheoMa(string MaDauSach)
        {
            return DauSachDAO.LayDauSachTheoMa(MaDauSach);
        }

        public List<DauSachDTO> DemDSDS()
        {
            return DauSachDAO.DemDSDS();
        }
        public bool ThemDS(DauSachDTO dsDTO)
        {
            return DauSachDAO.ThemDS(dsDTO);
        }
        public bool CapNhatDS(DauSachDTO dsDTO)
        {
            return DauSachDAO.CapNhatDS(dsDTO);
        }
        public bool XoaDS(DauSachDTO dsDTO)
        {
            return DauSachDAO.XoaDS(dsDTO);
        }
    }
}
