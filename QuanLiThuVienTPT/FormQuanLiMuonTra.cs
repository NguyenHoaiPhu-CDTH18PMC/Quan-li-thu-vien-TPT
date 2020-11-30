using DTO;
using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVienTPT
{
    public partial class frmQuanLiMuonTra : Form
    {
        public static int SL = 0;
        SachBUS sachBUS = new SachBUS();
        SachDTO sachDTO = new SachDTO();
        NhanVienBUS nvBUS = new NhanVienBUS();
        NhanVienDTO nvDTO = new NhanVienDTO();
        MuonTraDTO muontraDTO = new MuonTraDTO();
        MuonTraBUS muontraBUS = new MuonTraBUS();
        DocGiaBUS dgBUS = new DocGiaBUS();
        public frmQuanLiMuonTra()
        {
            InitializeComponent();
        }
        public frmQuanLiMuonTra(string nhanmanv)
        {
            InitializeComponent();
        }
        private void frmQuanLiMuonTra_Load(object sender, EventArgs e)
        {
            try
            {
                txtMaNV.Text = Constrains.NhanMaNV;

                int count = muontraBUS.DemDanhSachMuon().Count;
                count++;
                txtMaPhieuMuon.Text = (Constrains.MaMuon + count).ToString();

                cboDocGia.DataSource = dgBUS.LayDSDG();
                cboDocGia.DisplayMember = "TenDocGia";
                cboDocGia.ValueMember = "MaDocGia";
                txtMaDG.Text = cboDocGia.SelectedValue.ToString();
                txtMaNVTra.Text = Constrains.NhanMaNV;
                dtpNgMuon.Value = dtpNgayMuon.Value;
                dtpNgayTra.Value =  DateTime.Today.AddDays(5);



                List<MuonTraDTO> dsm = muontraBUS.DanhSachMuon();
                dtgvMuonTra.AutoGenerateColumns = false;
                dtgvMuonTra.DataSource = dsm;

                List<MuonTraDTO> dst = muontraBUS.LayDanhSachTra();
                dtgvDaTra.AutoGenerateColumns = false;
                dtgvDaTra.DataSource = dst;
                //------------------------------------------------------------
                List<MuonTraDTO> TimThay = new List<MuonTraDTO>();
                List<MuonTraDTO> quahan = muontraBUS.DanhSachMuon();
                dtgvQuaHan.AutoGenerateColumns = false;
                foreach (MuonTraDTO item in quahan)
                {
                    if (item.NgayTra_LucMuon < DateTime.Today.AddDays(-0.5))
                    {
                        TimThay.Add(item);
                    }
                }
                dtgvQuaHan.DataSource = TimThay;
                //---------------------------------------------------------------------
                btnMuon_Click(sender, e);
                for (int i = lbSachMuon.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    int var = lbSachMuon.SelectedIndices[i];
                    lbSachMuon.Items.RemoveAt(var);
                    nbrSoLuong.Value = lbSachMuon.Items.Count;

                }
                nbrSoLuong.Value = lbSachMuon.Items.Count;


                List<SachDTO> dms = sachBUS.DanhMucSach();

                chkListBoxThem.Items.Clear();
                foreach (SachDTO item in dms)
                {
                    chkListBoxThem.Items.Add(item.MaSach);
                }


                chkListBoxTenSach.Items.Clear();
                foreach (SachDTO item in dms)
                {
                    chkListBoxTenSach.Items.Add(item.MaSach + " - " +item.TenSach);
                }
            }
            catch(Exception Exc)
            {
                MessageBox.Show(ThongBao.LoiThaoTac, ThongBao.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void txtGoiY_TextChanged(object sender, EventArgs e)
        {
            string value = txtGoiY.Text;
            List<SachDTO> TimThay = new List<SachDTO>();
            List<SachDTO> TimThays = new List<SachDTO>();
            List<SachDTO> dms = sachBUS.DanhMucSach();

            foreach (SachDTO items in dms)
            {
                chkListBoxTenSach.Items.Clear();
                if (items.TenSach.ToLower().Contains(value.ToLower()) == true)
                {
                    TimThays.Add(items);
                }
                foreach (SachDTO itemTams in TimThays)
                {
                    chkListBoxTenSach.Items.Add(itemTams.MaSach +" - "+ itemTams.TenSach);
                }
                if (value == "")
                {
                    chkListBoxTenSach.Items.Clear();
                    foreach (SachDTO s in dms)
                    {
                        chkListBoxTenSach.Items.Add(s.MaSach + " - " + s.TenSach);
                    }

                }
            }

            foreach (SachDTO item in dms)
            {
                chkListBoxThem.Items.Clear();
                if (item.TenSach.ToLower().Contains(value.ToLower()) == true)
                {
                    TimThay.Add(item);
                }
                foreach (SachDTO itemTam in TimThay)
                {
                    chkListBoxThem.Items.Add(itemTam.MaSach);
                }
                if (value == "")
                {
                    chkListBoxThem.Items.Clear();
                    foreach (SachDTO b in dms)
                    {
                        chkListBoxThem.Items.Add(b.MaSach);
                    }

                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*if (chkListBoxThem.Items.Count > 0)
            {
                foreach (object i in chkListBoxThem.CheckedItems)
                {
                    if (nbrSoLuong.Value == 5)
                    {
                        MessageBox.Show("Không mượn quá 5");
                        return;
                    } 
                    lbSachMuon.Items.Add(i.ToString());
                    nbrSoLuong.Value++;
               
                }
            }*/
            try
            {
                chkListBoxThem.CheckOnClick = true;
                nbrSoLuong.Value = lbSachMuon.Items.Count;
                foreach (string s in chkListBoxThem.CheckedItems)
                {
                    if (lbSachMuon.Items.Count == 5)
                    {
                        MessageBox.Show(ThongBao.KhongMuonNhieu);
                        return;
                    }
                    lbSachMuon.Items.Add(s);
                    nbrSoLuong.Value = lbSachMuon.Items.Count;

                    string st;
                    for (int i = 0; i < lbSachMuon.Items.Count - 1; i++)
                    {
                        st = lbSachMuon.Items[i].ToString();

                        for (int j = i + 1; j < lbSachMuon.Items.Count; j++)
                        {
                            if (lbSachMuon.Items[j].ToString() == st)
                            {
                                lbSachMuon.Items.RemoveAt(j);
                                nbrSoLuong.Value = lbSachMuon.Items.Count;
                            }
                        }
                    }
                }
                nbrSoLuong.Value = lbSachMuon.Items.Count;
            }
            catch (Exception Exc)
            {
                MessageBox.Show(ThongBao.LoiThaoTac, ThongBao.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = lbSachMuon.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    int var = lbSachMuon.SelectedIndices[i];
                    lbSachMuon.Items.RemoveAt(var);
                    nbrSoLuong.Value = lbSachMuon.Items.Count;

                }
                nbrSoLuong.Value = lbSachMuon.Items.Count;
            }
            catch (Exception Exc)
            {
                MessageBox.Show(ThongBao.LoiThaoTac, ThongBao.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if(lbSachMuon.Items.Count == 0)
                {
                    MessageBox.Show(ThongBao.LoiDuLieu, ThongBao.ThatBai);
                    return;
                }
                if (dtpNgayMuon.Value > dtpNgayTra.Value)
                {
                    MessageBox.Show(ThongBao.LoiNgayTra, ThongBao.ThatBai);
                    return;
                }
                muontraDTO.MaPM = txtMaPhieuMuon.Text;
                muontraDTO.SLMuon = Int16.Parse(nbrSoLuong.Value.ToString());
                muontraDTO.NgayMuon = dtpNgayMuon.Value;
                muontraDTO.MaDocGia = cboDocGia.SelectedValue.ToString();
                muontraDTO.MaNV = txtMaNV.Text;
                muontraDTO.NgayTra_LucMuon = dtpNgayTra.Value;
                muontraDTO.MaCTPM = txtMaPhieuMuon.Text;
                if (muontraBUS.LapPhieuMuon(muontraDTO))
                {
                    for (int i = 0; i < lbSachMuon.Items.Count; i++)
                    {
                        muontraDTO.MaSach = lbSachMuon.Items[i].ToString();
                        if (muontraBUS.LapCTPhieuMuon(muontraDTO))
                        {
                            SachDTO cndto = new SachDTO();
                            SachBUS cnbus = new SachBUS();
                            cndto = cnbus.LaySachTheoMaSach(muontraDTO.MaSach);
                            cndto.SLTon = cndto.SLTon - 1;
                            sachBUS.CapNhatSach(cndto);
                        }
                    }
                    frmLoad A = new frmLoad();
                    A.ShowDialog();
                    MessageBox.Show(ThongBao.ThanhCong, ThongBao.ThanhCong, MessageBoxButtons.OK);
                }
                else
                {
                    frmLoad A = new frmLoad();
                    A.ShowDialog();
                    MessageBox.Show(ThongBao.ThatBai, ThongBao.ThatBai, MessageBoxButtons.OK);
                }
                frmQuanLiMuonTra_Load(sender, e);
                btnThemMoi_Click(sender, e);
            }
            catch(Exception Exc)
            {
                MessageBox.Show(ThongBao.ThatBai, ThongBao.ThatBai , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < lbSachMuon.Items.Count; i++)
                {
                    lbSachMuon.SetSelected(i, true);
                }
            }
            catch (Exception Exc)
            {
                MessageBox.Show(ThongBao.LoiThaoTac, ThongBao.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            dtpNgayMuon.Value = DateTime.Now;
            frmQuanLiMuonTra_Load(sender, e);
        }

        private void dtgvMuonTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {    
            try
            {
                if (e.RowIndex < 0) return;
                lbSachMuon.Items.Clear();
                String mapm = dtgvMuonTra.Rows[e.RowIndex].Cells[0].Value.ToString();
                String manv = dtgvMuonTra.Rows[e.RowIndex].Cells[1].Value.ToString();
                String madg = dtgvMuonTra.Rows[e.RowIndex].Cells[2].Value.ToString();
                int slmuon = Int16.Parse(dtgvMuonTra.Rows[e.RowIndex].Cells[5].Value.ToString());
                List<MuonTraDTO> sachmuon = muontraBUS.LayDSSachMuon(mapm);
                if (sachmuon.Count > 0)
                {
                    for (int i = 0; i < sachmuon.Count; i++)
                    {
                        txtMaPhieuMuon.Text = mapm;
                        txtMaPM.Text = mapm;
                        txtMaNV.Text = manv;
                        cboDocGia.SelectedValue = madg;
                        dtpNgayMuon.Value = DateTime.Parse(dtgvMuonTra.Rows[e.RowIndex].Cells[3].Value.ToString());
                        dtpNgayTra.Value = DateTime.Parse(dtgvMuonTra.Rows[e.RowIndex].Cells[4].Value.ToString());
                        nbrSoLuong.Value = slmuon;
                        lbSachMuon.Items.Add(sachmuon[i].MaSach);
                    }
                }
            }
            catch (Exception Exc)
            {
                MessageBox.Show(ThongBao.ThatBai, ThongBao.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            try
            {
                lbSachTra.Items.Clear();
                txtMaPM.Text = txtMaPhieuMuon.Text;
                tabControlMuonTra.SelectedTab = tabPageTraSach;
                for (int i = 0; i < lbSachMuon.Items.Count; i++)
                {
                    lbSachTra.Items.Add(lbSachMuon.Items[i].ToString());
                }
                nbrSlTra.Value = lbSachTra.Items.Count;
            }
            catch (Exception Exc)
            {
                MessageBox.Show(ThongBao.ThatBai, ThongBao.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmQuanLiMuonTra_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode.Equals(Keys.A))
                {
                    btnMuon_Click(sender, e);
                }
                if (e.KeyCode.Equals(Keys.R))
                {
                    btnThemMoi_Click(sender, e);
                }
            }
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            /*try
            {
                int icount = muontraBUS.DemPhieuTra().Count;
                icount++;
                muontraDTO.MaPT = Constrains.MaTra + txtMaPhieuMuon.Text + icount;
                muontraDTO.SLTra = lbSachTra.SelectedItems.Count;
                muontraDTO.NgayTra_LucTra = DateTime.Now;
                muontraDTO.MaNV = Constrains.NhanMaNV;
                muontraDTO.MaPM = txtMaPhieuMuon.Text;

                MuonTraDTO LayPM = muontraBUS.LayPhieuMuon(muontraDTO.MaPM);
                int SLMuon_PM = LayPM.SLMuon;

                List<MuonTraDTO> LayPT = muontraBUS.LayPhieuTra(muontraDTO.MaPM);
                int SLMuon_PT =0;
                for(int i=0; i< LayPT.Count ; i++)
                {
                    SLMuon_PT += LayPT[i].SLTra;
                }   
                muontraDTO.DaTra = true;
                if (chkHuHong.Checked == true)
                {
                    muontraDTO.TrinhTrang = false;
                }
                else
                    muontraDTO.TrinhTrang = true;
                muontraDTO.GhiChu = txtGhiChu.Text;
                muontraDTO.TienPhat = (Decimal)nbrTienPhat.Value;
                if (muontraBUS.LapPhieuTra(muontraDTO))
                {
                    for (int i = 0; i < lbSachTra.SelectedItems.Count; i++)
                    {
                        int count = muontraBUS.DemDanhSachTra().Count;
                        count++;
                        muontraDTO.MaCTPT = Constrains.MaTra + txtMaPhieuMuon.Text+count;
                        muontraDTO.MaSach = lbSachTra.SelectedItems[i].ToString();
                        if (muontraBUS.LapCTPhieuTra(muontraDTO))
                        {

                        }
                        if(SLMuon_PM == SLMuon_PT)
                        {
                            if (muontraBUS.CapNhatKhiTraSach(muontraDTO.MaPM))
                            {

                            }
                        }
                        
                    }

                    frmLoad A = new frmLoad();
                    A.ShowDialog();
                    MessageBox.Show(ThongBao.ThemThanhCong, ThongBao.ThanhCong, MessageBoxButtons.OK);
                }
                else
                {
                    frmLoad A = new frmLoad();
                    A.ShowDialog();
                    MessageBox.Show(ThongBao.ThemThatBai, ThongBao.ThatBai, MessageBoxButtons.OK);
                }
                frmQuanLiMuonTra_Load(sender, e);
                btnThemMoi_Click(sender, e);
            }
            catch (Exception Exc)
            {
                MessageBox.Show(ThongBao.ThatBai, ThongBao.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

            try
            {
                muontraDTO.MaPT = Constrains.MaTra + txtMaPhieuMuon.Text;
                muontraDTO.SLTra = lbSachTra.Items.Count;
                muontraDTO.NgayTra_LucTra = DateTime.Now;
                muontraDTO.MaNV = Constrains.NhanMaNV;
                muontraDTO.MaPM = txtMaPhieuMuon.Text;
                // cttra
                muontraDTO.MaCTPT = Constrains.MaTra + txtMaPhieuMuon.Text;
                muontraDTO.DaTra = true;
                if (chkHuHong.Checked == true)
                {
                    muontraDTO.TrinhTrang = false;
                }
                else
                    muontraDTO.TrinhTrang = true;
                muontraDTO.GhiChu = txtGhiChu.Text;
                muontraDTO.TienPhat = (Decimal)nbrTienPhat.Value;
                if (muontraBUS.LapPhieuTra(muontraDTO))
                {
                    for (int i = 0; i < lbSachMuon.Items.Count; i++)
                    {
                        muontraDTO.MaSach = lbSachMuon.Items[i].ToString();
                        if (muontraBUS.LapCTPhieuTra(muontraDTO))
                        {
                            if (muontraBUS.CapNhatKhiTraSach(muontraDTO.MaPM))
                            {
                                SachDTO cndto = new SachDTO();
                                SachBUS cnbus = new SachBUS();
                                cndto = cnbus.LaySachTheoMaSach(muontraDTO.MaSach);
                                cndto.SLTon = cndto.SLTon + 1;
                                sachBUS.CapNhatSach(cndto);
                            }
                        }
                    }

                    frmLoad A = new frmLoad();
                    A.ShowDialog();
                    MessageBox.Show(ThongBao.ThanhCong, ThongBao.ThanhCong, MessageBoxButtons.OK);
                }
                else
                {
                    frmLoad A = new frmLoad();
                    A.ShowDialog();
                    MessageBox.Show(ThongBao.ThatBai, ThongBao.ThatBai, MessageBoxButtons.OK);
                }
                frmQuanLiMuonTra_Load(sender, e);
                btnThemMoi_Click(sender, e);
            }
            catch (Exception Exc)
            {
                MessageBox.Show(ThongBao.ThatBai, ThongBao.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string value = txtTimKiem.Text;
                List<MuonTraDTO> TimThay = new List<MuonTraDTO>();
                List<MuonTraDTO> dms = muontraBUS.DanhSachMuon();
                foreach (MuonTraDTO item in dms)
                {
                    dtgvMuonTra.DataSource = "";
                    if (item.MaDocGia.ToLower().Contains(value.ToLower()) == true || item.MaPM.ToLower().Contains(value.ToLower()) == true)
                    {
                        TimThay.Add(item);
                    }
                    dtgvMuonTra.DataSource = TimThay;
                    if (value == "")
                    {
                        dtgvMuonTra.DataSource = dms;

                    }
                }
            }
            catch (Exception Exc)
            {
                MessageBox.Show(ThongBao.NhapChuoiKhac, ThongBao.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            chkHuHong.Checked = false;
            nbrTienPhat.Value = 0;
            txtGhiChu.ResetText();

            lbSachTra.Items.Clear();
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < lbSachTra.Items.Count; i++)
                {
                    lbSachTra.SetSelected(i, true);
                }
            }
            catch (Exception Exc)
            {
                MessageBox.Show(ThongBao.LoiThaoTac, ThongBao.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgvDaTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                lbSachTra.Items.Clear();
                string mapm = dtgvDaTra.Rows[e.RowIndex].Cells[0].Value.ToString();
                string mapt = dtgvDaTra.Rows[e.RowIndex].Cells[1].Value.ToString();
                string manv = dtgvDaTra.Rows[e.RowIndex].Cells[2].Value.ToString();
                string sltra = dtgvDaTra.Rows[e.RowIndex].Cells[4].Value.ToString();
                string ghichu = dtgvDaTra.Rows[e.RowIndex].Cells[5].Value.ToString();
                string tienphat = dtgvDaTra.Rows[e.RowIndex].Cells[6].Value.ToString();
                List<MuonTraDTO> sachtra = muontraBUS.LayDSSachTra(mapt);
                if (sachtra.Count > 0)
                {
                    txtMaPM.Text = mapm;
                    txtMaPT.Text = mapt;
                    txtMaNV.Text = manv;
                    txtGhiChu.Text = ghichu;
                    nbrTienPhat.Value = Decimal.Parse(tienphat);
                    dtpNgayTra.Value = DateTime.Parse(dtgvDaTra.Rows[e.RowIndex].Cells[3].Value.ToString());
                    nbrSlTra.Value = Int32.Parse(sltra);
                    if (nbrTienPhat.Value > 07)
                    {
                        chkHuHong.Checked = true;
                    }
                    else
                        chkHuHong.Checked = false;
                    for (int i = 0; i < sachtra.Count; i++)
                    {     
                        lbSachTra.Items.Add(sachtra[i].MaSach);  
                    }
                }
            }
            catch (Exception Exc)
            {
                //MessageBox.Show(ThongBao.ThatBai, ThongBao.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("lỗi"+Exc);
            }
        }
    }
}
