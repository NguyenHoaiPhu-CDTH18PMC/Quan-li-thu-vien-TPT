using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichSuDangNhapDTO
    {
        public int ID{ get; set; }
        public string MaNV { get; set; }
        public DateTime TGDangNhap { get; set; }
        public bool XoaLS { get; set; }
    }
}
