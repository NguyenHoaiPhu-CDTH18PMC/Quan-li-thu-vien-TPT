using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DocGiaDTO
    {
        public string MaDocGia { get; set; }
        public string TenDocGia { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Khoa { get; set; }
        public string Lop { get; set; }
        public bool XoaDocGia { get; set; }
    }
}
