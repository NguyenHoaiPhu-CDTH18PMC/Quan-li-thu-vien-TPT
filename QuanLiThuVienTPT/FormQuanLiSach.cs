using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVienTPT
{
    public partial class frmQuanLiSach : Form
    {
        // Tạo các biến truy xuất vào lớp BUS và đối tượng DTO để truy xuất dữ liệu
        SachBUS sachBUS = new SachBUS();
        SachDTO sachDTO = new SachDTO();
        NhaXuatBanBUS nxbBUS = new NhaXuatBanBUS();
        NhaXuatBanDTO nxbDTO = new NhaXuatBanDTO();
        DauSachBUS dsBUS = new DauSachBUS();
        DauSachDTO dsDTO = new DauSachDTO();
        TacGiaBUS tacgiaBUS = new TacGiaBUS();
        TacGiaDTO tacgiaDTO = new TacGiaDTO();
        frmLoad A = new frmLoad();
        public frmQuanLiSach()
        {
            InitializeComponent();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                sachDTO.MaSach = txtMaSach.Text;
                sachDTO.TenSach = txtTenSach.Text;
                sachDTO.MaTacGia = cboMaTG.SelectedValue.ToString();
                sachDTO.MaDauSach = cboMaDauSach.SelectedValue.ToString();
                sachDTO.MaNXB = cboMaNXB.SelectedValue.ToString();
                sachDTO.NamXB = Int16.Parse(txtNamXB.Text);
                sachDTO.GiaTien = Decimal.Parse(nbrGiaTien.Value.ToString());
                sachDTO.SLTon = Int16.Parse(nbrSLTon.Value.ToString());
                sachDTO.XoaSach = true;
                if (sachBUS.ThemSach(sachDTO))
                {

                    A.ShowDialog();
                    MessageBox.Show(ThongBao.ThemThanhCong, ThongBao.ThanhCong, MessageBoxButtons.OK);

                }
                else
                {
                    A.ShowDialog();
                    MessageBox.Show(ThongBao.ThemThatBai, ThongBao.ThatBai, MessageBoxButtons.OK);
                }
                /*frmQuanLiSach F2 = new frmQuanLiSach();
                this.Hide();
                F2.ShowDialog();
                this.Close();*/
                frmQuanLiSach_Load(sender, e);
                btnThemMoi_Click(sender, e);
            }
            catch (Exception Exc)
            {
                MessageBox.Show(ThongBao.LoiDuLieu, ThongBao.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                sachDTO.MaSach = txtMaSach.Text;
                if (sachBUS.XoaSach(sachDTO))
                {
                    A.ShowDialog();
                    MessageBox.Show(ThongBao.XoaThanhCong, ThongBao.ThanhCong, MessageBoxButtons.OK);

                }
                else
                {
                    A.ShowDialog();
                    MessageBox.Show(ThongBao.XoaThatBai, ThongBao.ThatBai, MessageBoxButtons.OK);
                }
                /*frmQuanLiSach F2 = new frmQuanLiSach();
                this.Hide();
                F2.ShowDialog();
                this.Close();*/
                frmQuanLiSach_Load(sender, e);
                btnThemMoi_Click(sender, e);
            }
            catch (Exception Exc)
            {
                MessageBox.Show(ThongBao.LoiDuLieu, ThongBao.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                sachDTO.MaSach = txtMaSach.Text;
                sachDTO.TenSach = txtTenSach.Text;
                sachDTO.MaTacGia = cboMaTG.SelectedValue.ToString();
                sachDTO.MaDauSach = cboMaDauSach.SelectedValue.ToString();
                sachDTO.MaNXB = cboMaNXB.SelectedValue.ToString();
                sachDTO.NamXB = Int16.Parse(txtNamXB.Text);
                sachDTO.GiaTien = Decimal.Parse(nbrGiaTien.Value.ToString());
                sachDTO.SLTon = Int16.Parse(nbrSLTon.Value.ToString());
                if (sachBUS.CapNhatSach(sachDTO))
                {
                    A.ShowDialog();
                    MessageBox.Show(ThongBao.CapNhatThanhCong, ThongBao.ThanhCong, MessageBoxButtons.OK);
                }
                else
                {
                    A.ShowDialog();
                    MessageBox.Show(ThongBao.CapNhatThatBai, ThongBao.ThatBai, MessageBoxButtons.OK);
                }
                /*frmQuanLiSach F2 = new frmQuanLiSach();
                this.Hide();
                F2.ShowDialog();
                this.Close();*/
                frmQuanLiSach_Load(sender, e);
                btnThemMoi_Click(sender, e);
            }
            catch (Exception Exc)
            {
                MessageBox.Show(ThongBao.LoiDuLieu, ThongBao.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmQuanLiSach_Load(object sender, EventArgs e)
        {
            int count = sachBUS.DemDanhMucSach().Count;
            count++;
            txtMaSach.Text = (Constrains.MaSach + count).ToString();
            cboMaNXB.DataSource = nxbBUS.LayDSNXB();
            cboMaNXB.DisplayMember = "TenNXB";
            cboMaNXB.ValueMember = "MaNXB";
            cboMaTG.DataSource = tacgiaBUS.DanhSachTG();
            cboMaTG.DisplayMember = "HoTen";
            cboMaTG.ValueMember = "MaTacGia";
            cboMaDauSach.DataSource = dsBUS.DanhSachDauSach();
            cboMaDauSach.DisplayMember = "TenDauSach";
            cboMaDauSach.ValueMember = "MaDauSach";
            List<SachDTO> dms = sachBUS.DanhMucSach();
            dtgvSach.AutoGenerateColumns = false;
            dtgvSach.DataSource = dms;
           
            /*DataGridViewComboBoxColumn NXBcbo = (DataGridViewComboBoxColumn)colMaNXB;
            NXBcbo.DataSource = nxbBUS.LayDSNXB();
            NXBcbo.DisplayMember = "TenNXB";
            NXBcbo.ValueMember = "MaNXB";*/
        }      

        private void dtgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                String masach = dtgvSach.Rows[e.RowIndex].Cells[0].Value.ToString();
                String tensach = dtgvSach.Rows[e.RowIndex].Cells[1].Value.ToString();
                String matacgia = dtgvSach.Rows[e.RowIndex].Cells[2].Value.ToString();
                String madausach = dtgvSach.Rows[e.RowIndex].Cells[3].Value.ToString();
                String manxb = dtgvSach.Rows[e.RowIndex].Cells[4].Value.ToString();
                SachDTO sach = sachBUS.LaySachTheoMaSach(masach);
                TacGiaDTO tg = tacgiaBUS.LayTacGiaTheoMa(matacgia);
                DauSachDTO dausach = dsBUS.LayDauSachTheoMa(madausach);
                NhaXuatBanDTO nxb = nxbBUS.LayNXBTheoMa(manxb);
                if (sach != null)
                {
                    txtMaSach.Text = sach.MaSach;
                    txtTenSach.Text = sach.TenSach;
                    cboMaTG.SelectedValue = tg.MaTacGia;
                    cboMaDauSach.SelectedValue = dausach.MaDauSach;
                    cboMaNXB.SelectedValue = sach.MaNXB;
                    txtNamXB.Text = sach.NamXB.ToString();
                    nbrGiaTien.Value = sach.GiaTien;
                    nbrSLTon.Value = sach.SLTon;
                }
            }
            catch (Exception Exc)
            {
                MessageBox.Show(ThongBao.LoiThaoTac, ThongBao.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKIem_Click(object sender, EventArgs e)
        {
            frmTimKiemSach A = new frmTimKiemSach();
            A.ShowDialog();
        }

    

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            int count = sachBUS.DemDanhMucSach().Count;
            count++;
            txtMaSach.Text = (Constrains.MaSach + count).ToString();
            txtTenSach.ResetText();
            txtNamXB.ResetText();
            nbrGiaTien.Value = 0;
            nbrSLTon.Value = 0;
        }

        private void btnThemTG_Click(object sender, EventArgs e)
        {
            frmQuanLiTacGia A = new frmQuanLiTacGia();
            A.ShowDialog();
        }

        private void btnThemDS_Click(object sender, EventArgs e)
        {
            frmQuanLiDauSach A = new frmQuanLiDauSach();
            A.ShowDialog();
        }

        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            frmQuanLiNXB A = new frmQuanLiNXB();
            A.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string value = txtTimKiem.Text;
                List<SachDTO> TimThay = new List<SachDTO>();
                List<SachDTO> dms = sachBUS.DanhMucSach();
                foreach (SachDTO item in dms)
                {
                    dtgvSach.DataSource = "";
                    if (item.TenSach.ToLower().Contains(value.ToLower()) == true || item.MaSach.ToLower().Contains(value.ToLower()) == true || item.MaTacGia.ToLower().Contains(value.ToLower()) == true || item.MaDauSach.ToLower().Contains(value.ToLower()) == true || item.MaNXB.ToLower().Contains(value.ToLower()) == true )
                    {
                        TimThay.Add(item);
                    }
                    dtgvSach.DataSource = TimThay;
                    if (value == "")
                    {
                        dtgvSach.DataSource = dms;

                    }
                }
            }
            catch(Exception Exc)
            {
                MessageBox.Show(ThongBao.NhapChuoiKhac);
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
