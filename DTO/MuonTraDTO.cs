using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MuonTraDTO
    {
        public string MaPM { get; set; }

        public string MaDocGia { get; set; }

        public int SLMuon { get; set; }

        public int SLTra { get; set; }

        public bool? TrinhTrang { get; set; }

        public string GhiChu { get; set; }

        public Decimal? TienPhat { get; set; }

        public DateTime NgayMuon { get; set; }

        public DateTime NgayTra_LucMuon { get; set; }

        public DateTime? NgayTra_LucTra { get; set; }

        public string MaNV { get; set; }

        public string MaCTPM { get; set; }

        public string MaCTPT { get; set; }

        public string MaPT { get; set; }

        public string MaSach { get; set; }

        public bool? DaTra { get; set; }
    }
}
