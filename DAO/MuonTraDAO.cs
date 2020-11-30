using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MuonTraDAO
    {
        static string ChuoiKetNoi = @"Data Source=DESKTOP-V17RVFI\MSSQLSERVERPHU;Initial Catalog=QuanLiThuVienTPT;Integrated Security=True";
        readonly SqlConnection conn = new SqlConnection(ChuoiKetNoi);

        /*public List<MuonTraDTO> DanhSachMuon()
        {
           
            List<MuonTraDTO> Muons = new List<MuonTraDTO>();

            // Khởi tạo câu truy vấn
            string sql = "SELECT * FROM MUONTRA ";

            conn.Open();

            // Khởi tạo đối tượng truy vấn
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Thực thi câu truy vấn
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                MuonTraDTO muon = new MuonTraDTO();

                muon.MaMuonTra = reader.GetString(0);
                muon.MaThe = reader.GetString(1);
                muon.SLMuon = reader.GetInt32(2);
                muon.NgayMuon = reader.GetDateTime(3);
                muon.MaNV = reader.GetString(4);
                Muons.Add(muon);
            }
            conn.Close();
            return Muons;
        }
        public MuonTraDTO LaySachTheoMaSach(string MaMuonTra)
        {
            
            MuonTraDTO Muons = new MuonTraDTO();
            MuonTraDTO muon = new MuonTraDTO();
            // Khởi tạo câu truy vấn
            string sql = String.Format("SELECT * FROM MUONTRA WHERE MaMuonTra = '{0}'", MaMuonTra);

            conn.Open();

            // Khởi tạo đối tượng truy vấn
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Thực thi câu truy vấn
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                muon.MaMuonTra = reader.GetString(0);
                muon.MaThe = reader.GetString(1);
                muon.SLMuon = reader.GetInt32(2);
                muon.NgayMuon = reader.GetDateTime(3);
                muon.MaNV = reader.GetString(4);
            }
            conn.Close();
            return muon;
        }*/
        QuanLiThuVienTPTEntities db = new QuanLiThuVienTPTEntities();
        public List<MuonTraDTO> DanhSachMuon()
        {
            List<MuonTraDTO> DSMuon = new List<MuonTraDTO>();
            var  query = (from s in db.PHIEUMUONs
                         join c in db.CHITIETPHIEUMUONs on s.MaPM equals c.MaCTPM 
                         where s.XoaPM == true 
                         select new 
                         {
                            s,
                            s.MaPM,
                            s.MaDocGia,
                            s.MaNV,
                            s.NgayMuon,
                            s.NgayTra,
                            s.SoLuongMuon,
                         }).Distinct().ToList();
            foreach (var muon in query)
            {
                MuonTraDTO muonDTO = new MuonTraDTO()
                {
                    MaPM = muon.s.MaPM,
                    MaDocGia=muon.MaDocGia,
                    MaNV=muon.MaNV,
                    NgayMuon=muon.NgayMuon,
                    NgayTra_LucMuon=muon.NgayTra,
                    SLMuon = muon.SoLuongMuon,
                };
                DSMuon.Add(muonDTO);
            }
            return DSMuon;
        }
        public MuonTraDTO LayPhieuMuon(string mpm)
        {
            List<MuonTraDTO> query = db.PHIEUMUONs.Where(s => s.XoaPM == true && s.MaPM == mpm).Select(p => new MuonTraDTO
            {
                MaPM = p.MaPM,              
                SLMuon = p.SoLuongMuon
            }).ToList();
            return query[0];
        }
        public List<MuonTraDTO> LayPhieuTra(string mpm)
        {
            List<MuonTraDTO> query = db.PHIEUTRAs.Where(s => s.MaPM == mpm).Select(p => new MuonTraDTO
            {
                SLMuon = p.SoLuongTra
            }).ToList();
            return query;
        }
        public List<MuonTraDTO> DemDanhSachMuon()
        {
            List<MuonTraDTO> DSMuon = new List<MuonTraDTO>();
            var query = (from s in db.PHIEUMUONs
                         join c in db.CHITIETPHIEUMUONs on s.MaPM equals c.MaCTPM
                         select new
                         {
                             s,
                             s.MaPM,
                             s.MaDocGia,
                             s.MaNV,
                             s.NgayMuon,
                             s.NgayTra,
                             s.SoLuongMuon,
                         }).Distinct().ToList();
            foreach (var muon in query)
            {
                MuonTraDTO muonDTO = new MuonTraDTO()
                {
                    MaPM = muon.s.MaPM,
                    MaDocGia = muon.MaDocGia,
                    MaNV = muon.MaNV,
                    NgayMuon = muon.NgayMuon,
                    NgayTra_LucMuon = muon.NgayTra,
                    SLMuon = muon.SoLuongMuon,
                };
                DSMuon.Add(muonDTO);
            }
            return DSMuon;
        }

        // Phu met roi dung sai nua ma 
        public List<MuonTraDTO> LayDanhSachTra()
        {
            List<MuonTraDTO> DSTra = new List<MuonTraDTO>();
            var query = (from s in db.PHIEUTRAs
                         join c in db.CHITIETPHIEUTRAs on s.MaPT equals c.MaCTPT
                         select new
                         {
                             s,
                             s.MaPT,
                             s.MaNV,
                             s.NgayTra,
                             s.SoLuongTra,
                             s.MaPM,
                             //c.MaSach,
                             c.TinhTrang,
                             c.GhiChu,
                             c.TienPhat,
                         }).Distinct().ToList();
            foreach (var muon in query)
            {
                MuonTraDTO muonDTO = new MuonTraDTO()
                {
                    MaPT = muon.MaPT,
                    //MaSach = muon.MaSach,
                    MaPM = muon.s.MaPM,
                    MaNV = muon.MaNV,
                    NgayTra_LucTra = muon.NgayTra,
                    SLTra = muon.SoLuongTra,
                    TienPhat = muon.TienPhat,
                    TrinhTrang = muon.TinhTrang,
                    GhiChu = muon.GhiChu
                };
                DSTra.Add(muonDTO);
            }
            return DSTra;
        }

        public List<MuonTraDTO> DemDanhSachTra()
        {
            List<MuonTraDTO> query = db.CHITIETPHIEUTRAs.Select(p => new MuonTraDTO
            {
                MaCTPM = p.MaCTPT,
            }).ToList();
            return query;
        }
        public List<MuonTraDTO> DemPhieuTra()
        {
            List<MuonTraDTO> query = db.PHIEUTRAs.Select(p => new MuonTraDTO
            {
                MaPT = p.MaPT,
            }).ToList();
            return query;
        }
        public bool LapPhieuMuon(MuonTraDTO p)
        {
            PHIEUMUON pm = new PHIEUMUON
            {
               MaPM = p.MaPM,
               SoLuongMuon = p.SLMuon,
               NgayMuon = p.NgayMuon,
               MaDocGia = p.MaDocGia,
               MaNV = p.MaNV,
               XoaPM = true,
               NgayTra = p.NgayTra_LucMuon
            };
            db.PHIEUMUONs.Add(pm);
            db.SaveChanges();
            return true;
        }
        public bool LapCTPhieuMuon(MuonTraDTO p)
        {       
            CHITIETPHIEUMUON ctpm = new CHITIETPHIEUMUON
            {
                MaCTPM = p.MaCTPM,
                MaSach = p.MaSach,
                NgayMuon = p.NgayMuon,
                XoaCTPM = true
            };
            db.CHITIETPHIEUMUONs.Add(ctpm);
            db.SaveChanges();

            return true;
        }
        public List<MuonTraDTO> LayDSSachMuon(string MaPM)
        {
            List<MuonTraDTO> query = db.CHITIETPHIEUMUONs.Where(s => s.MaCTPM == MaPM).Select(p => new MuonTraDTO
            {
                MaCTPM = p.MaCTPM,
                MaSach =p.MaSach,
                NgayMuon=p.NgayMuon
            }).ToList();
            return query;
        }

        public List<MuonTraDTO> LayDSSachTra(string MaPT)
        {
            List<MuonTraDTO> query = db.CHITIETPHIEUTRAs.Where(s => s.MaCTPT == MaPT).Select(p => new MuonTraDTO
            {
                MaCTPT = p.MaCTPT,
                MaSach = p.MaSach,
            }).ToList();
            return query;
        }

        // tra

        public bool LapPhieuTra(MuonTraDTO p)
        {
            PHIEUTRA pt = new PHIEUTRA();
                pt.MaPT = p.MaPT;
                pt.SoLuongTra = p.SLTra;
                pt.NgayTra = p.NgayTra_LucTra;
                pt.MaNV = p.MaNV;
                pt.MaPM = p.MaPM;
                pt.XoaPhieuTra = true;             
            db.PHIEUTRAs.Add(pt);
            db.SaveChanges();
            return true;
        }
        public bool LapCTPhieuTra(MuonTraDTO p)
        {
            CHITIETPHIEUTRA ctpt = new CHITIETPHIEUTRA
            {
               MaCTPT =p.MaCTPT,
               MaSach=p.MaSach,
               DaTra=true,
               TinhTrang=true,
               GhiChu=p.GhiChu,
               TienPhat = p.TienPhat,
               XoaCTPT = true,
            };
            db.CHITIETPHIEUTRAs.Add(ctpt);
            db.SaveChanges();

            return true;
        }


        public bool CapNhatKhiTraSach(string m )
        {
            PHIEUMUON muon = (db.PHIEUMUONs.Where(p => p.MaPM == m ).Select(s => s)).ToList()[0];
            muon.XoaPM = false;
            db.SaveChanges();

            return true;
        }
    }
}


