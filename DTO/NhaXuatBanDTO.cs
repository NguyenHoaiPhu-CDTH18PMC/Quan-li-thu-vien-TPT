using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaXuatBanDTO
    {
        public string MaNXB { get; set; }
        public string TenNXB { get; set; }       
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public bool XoaNXB { get; set; }
    }
}
