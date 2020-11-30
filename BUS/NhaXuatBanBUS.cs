using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhaXuatBanBUS
    {
        NhaXuatBanDAO nxbDAO = new NhaXuatBanDAO();
        public List<NhaXuatBanDTO> LayDSNXB()
        {
            return nxbDAO.LayDSNXB();
        }
        public NhaXuatBanDTO LayNXBTheoMa(string MaNXB)
        {
            return nxbDAO.LayNXBTheoMa(MaNXB);
        }


        public List<NhaXuatBanDTO> DemDSNXB()
        {
            return nxbDAO.DemDSNXB();
        }
        public bool ThemNXB(NhaXuatBanDTO nxbDTO)
        {
            return nxbDAO.ThemNXB(nxbDTO);
        }
        public bool CapNhatNXB(NhaXuatBanDTO nxbDTO)
        {
            return nxbDAO.CapNhatNXB(nxbDTO);
        }
        public bool XoaNXB(NhaXuatBanDTO nxbDTO)
        {
            return nxbDAO.XoaNXB(nxbDTO);
        }

    }
}
