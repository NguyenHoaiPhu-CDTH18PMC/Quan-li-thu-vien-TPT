using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public  class MuonTraBUS
    {
       MuonTraDAO muonDAO = new MuonTraDAO();
        public List<MuonTraDTO> DanhSachMuon()
        {
            return muonDAO.DanhSachMuon();
        }
         public MuonTraDTO LayPhieuMuon(string mpm)
        {
            return muonDAO.LayPhieuMuon(mpm);
        }
         public List<MuonTraDTO> LayPhieuTra(string mpm)
         {
             return muonDAO.LayPhieuTra(mpm);
         }
        public List<MuonTraDTO> DemDanhSachMuon()
        {
            return muonDAO.DemDanhSachMuon();
        }

        public List<MuonTraDTO> DemDanhSachTra()
        {
            return muonDAO.DemDanhSachTra();
        }
        public List<MuonTraDTO> DemPhieuTra()
        {
            return muonDAO.DemPhieuTra();
        }
        public List<MuonTraDTO> LayDSSachMuon(string MaPM)
        {
            return muonDAO.LayDSSachMuon(MaPM);
        }
        public List<MuonTraDTO> LayDSSachTra(string MaPT)
        {
            return muonDAO. LayDSSachTra(MaPT);
        }
        public List<MuonTraDTO> LayDanhSachTra()
        {
            return muonDAO.LayDanhSachTra();
        }
        // muon
        public bool LapPhieuMuon(MuonTraDTO muonDTO)
        {
            return muonDAO.LapPhieuMuon(muonDTO);
        }
        public bool LapCTPhieuMuon(MuonTraDTO muonDTO)
        {
            return muonDAO.LapCTPhieuMuon(muonDTO);
        }
        // tra
        public bool LapPhieuTra(MuonTraDTO muonDTO)
        {
            return muonDAO.LapPhieuTra(muonDTO);
        }
        public bool LapCTPhieuTra(MuonTraDTO muonDTO)
        {
            return muonDAO.LapCTPhieuTra(muonDTO);
        }
        public bool CapNhatKhiTraSach(string m )
        {
            return muonDAO.CapNhatKhiTraSach(m );
        }
    }
}
