using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SachBUS
    {
        SachDAO bookDAO = new SachDAO();

        public List<SachDTO> DanhMucSach()
        {
            return bookDAO.DanhMucSach();
        }
        public List<SachDTO> HetSach()
        {
            return bookDAO.HetSach();
        }
        public List<SachDTO> DemDanhMucSach()
        {
            return bookDAO.DemDanhMucSach();
        }

        public SachDTO LaySachTheoMaSach(string MaSach)
        {
            return bookDAO.LaySachTheoMaSach(MaSach);
        }
         public List<SachDTO> LaySachTheoDauSach(string DauSach)
        {
            return bookDAO.LaySachTheoDauSach(DauSach);
        }
        public bool ThemSach(SachDTO bookDTO)
        {
            return bookDAO.ThemSach(bookDTO);
        }
        public bool CapNhatSach(SachDTO bookDTO)
        {
            return bookDAO.CapNhatSach(bookDTO);
        }

        public bool XoaSach(SachDTO bookDTO)
        {
            return bookDAO.XoaSach(bookDTO);
        }
    }
}
