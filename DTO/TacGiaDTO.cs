using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TacGiaDTO
    {
        public string MaTacGia { get; set; }

        public string HoTen { get; set; }

        public string Email { get; set; }

        public string DiaChi { get; set; }

        public bool XoaTacGia { get; set; }
    }
}
