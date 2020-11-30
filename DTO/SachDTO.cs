using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SachDTO
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string MaTacGia { get; set; }
        public string MaDauSach { get; set; }
        public string MaNXB { get; set; }
        public int NamXB { get; set; }
        public Decimal GiaTien { get; set; }
        public int SLTon { get; set; }
        public bool XoaSach { get; set; }
    }
}
