using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVienBUS
    {
        NhanVienDAO nhanvienDAO = new NhanVienDAO();
        public List<NhanVienDTO> DanhSachNV()
        {
            return nhanvienDAO.DanhSachNV();
        }
        public List<NhanVienDTO> DemDanhSachNV()
        {
            return nhanvienDAO.DemDanhSachNV();
        }
        public NhanVienDTO LayMKTheoTK(string TK)
        {
            return nhanvienDAO.LayMKTheoTK(TK);
        }
        public NhanVienDTO LayNhanVienTheoMa(string MaNV)
        {
            return nhanvienDAO.LayNhanVienTheoMa(MaNV);
        }
        public bool ThemNV(NhanVienDTO nv)
        {
            return nhanvienDAO.ThemNV(nv);
        }
        public bool CapNhatNV(NhanVienDTO nv)
        {
            return nhanvienDAO.CapNhatNV(nv);
        }
        public bool XoaNV(NhanVienDTO nv)
        {
            return nhanvienDAO.XoaNV(nv);
        }
    }
}
