using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
   
    public class DocGiaBUS
    {
        DocGiaDAO docgiaDAO = new DocGiaDAO();
        public List<DocGiaDTO> LayDSDG()
        {
            return docgiaDAO.LayDSDG();        
        }
        public DocGiaDTO LayDGTheoMa(string MaDocGia)
        {
            return docgiaDAO.LayDGTheoMa(MaDocGia);
        }
        public bool ThemDG(DocGiaDTO dgDTO)
        {
            return docgiaDAO.ThemDG(dgDTO);
        }
        public bool CapNhatDG(DocGiaDTO dgDTO)
        {
            return docgiaDAO.CapNhatDG(dgDTO);
        }
        public bool XoaDG(DocGiaDTO dgDTO)
        {
            return docgiaDAO.XoaDG(dgDTO);
        }
    }
}
