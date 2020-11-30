using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string TK { get; set; }
        public string MK { get; set; }
        public string Quyen { get; set; }
        public string AnhDaiDien { get; set; }
        public bool XoaNV { get; set; }
    }
}
