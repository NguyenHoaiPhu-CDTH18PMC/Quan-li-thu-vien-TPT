using BUS;
using DTO;
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
    public partial class frmQuanLiDocGia : Form
    {
        DocGiaBUS docgiaBUS = new DocGiaBUS();
        DocGiaDTO docgiaDTO = new DocGiaDTO();
        TheBUS theBUS = new TheBUS();
        TheDTO theDTO = new TheDTO();
        public frmQuanLiDocGia()
        {
            InitializeComponent();
        }

        private void frmQuanLiDocGia_Load(object sender, EventArgs e)
        {
            int count = docgiaBUS.LayDSDG().Count;
            count++;
            txtMaDocGia.Text = (Constrains.MaDocGia + count).ToString();
            cboKhoa.DataSource = docgiaBUS.LayDSDG();
            //cboKhoa.DisplayMember = "Khoa";
            cboKhoa.ValueMember = "Khoa";
            cboLop.DataSource = docgiaBUS.LayDSDG();
            //cboLop.DisplayMember = "Lop";
            cboLop.ValueMember = "Lop";
            List<DocGiaDTO> dsdg = docgiaBUS.LayDSDG();
            dtgvDocGia.AutoGenerateColumns = false;
            dtgvDocGia.DataSource = dsdg;
            
        }

        private void dtgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                String madocgia = dtgvDocGia.Rows[e.RowIndex].Cells[0].Value.ToString();
                DocGiaDTO docgia = docgiaBUS.LayDGTheoMa(madocgia);
                if (docgia != null)
                {
                    txtMaDocGia.Text = docgia.MaDocGia;
                    txtTenDocGia.Text = docgia.TenDocGia;
                    if (dtgvDocGia.Rows[e.RowIndex].Cells[2].Value.ToString() == "Nam")
                        radNam.Checked = true;
                    else
                        radNu.Checked = true;
                    txtDiaChi.Text = docgia.DiaChi;
                    txtSDT.Text = docgia.Phone;
                    txtEmail.Text = docgia.Email;

                    cboKhoa.SelectedValue = docgia.Khoa;
                    cboLop.SelectedValue = docgia.Lop;
                }
            }
            catch (Exception Exc)
            {
                MessageBox.Show(ThongBao.LoiThaoTac, ThongBao.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                docgiaDTO.MaDocGia = txtMaDocGia.Text;
                docgiaDTO.TenDocGia = txtTenDocGia.Text;
                if (radNam.Checked) docgiaDTO.GioiTinh = "Nam"; else docgiaDTO.GioiTinh = "Nữ";
                docgiaDTO.Khoa = cboKhoa.SelectedValue.ToString();
                docgiaDTO.Lop = cboLop.SelectedValue.ToString();
                docgiaDTO.Phone = txtSDT.Text;
                docgiaDTO.XoaDocGia = true;
                docgiaDTO.DiaChi = txtDiaChi.Text;
                docgiaDTO.Email = txtEmail.Text;
                if (docgiaBUS.ThemDG(docgiaDTO))
                {
                    MessageBox.Show(ThongBao.ThemThanhCong, ThongBao.ThanhCong, MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show(ThongBao.ThemThatBai, ThongBao.ThatBai, MessageBoxButtons.OK);
                frmQuanLiDocGia F2 = new frmQuanLiDocGia();
                this.Hide();
                F2.ShowDialog();
                this.Close();
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
                docgiaDTO.MaDocGia = txtMaDocGia.Text;
                docgiaDTO.XoaDocGia = true;
                if (docgiaBUS.XoaDG(docgiaDTO))
                {
                    MessageBox.Show(ThongBao.XoaThanhCong, ThongBao.ThanhCong, MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show(ThongBao.XoaThatBai, ThongBao.ThatBai, MessageBoxButtons.OK);
                frmQuanLiDocGia F2 = new frmQuanLiDocGia();
                this.Hide();
                F2.ShowDialog();
                this.Close();
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
                docgiaDTO.MaDocGia = txtMaDocGia.Text;
                docgiaDTO.TenDocGia = txtTenDocGia.Text;
                if (radNam.Checked) docgiaDTO.GioiTinh = "Nam"; else docgiaDTO.GioiTinh = "Nữ";
                docgiaDTO.Khoa = cboKhoa.SelectedValue.ToString();
                docgiaDTO.Lop = cboLop.SelectedValue.ToString();
                docgiaDTO.Phone = txtSDT.Text;
                docgiaDTO.DiaChi = txtDiaChi.Text;
                docgiaDTO.Email = txtEmail.Text;
                if (docgiaBUS.CapNhatDG(docgiaDTO))
                {
                    MessageBox.Show(ThongBao.CapNhatThanhCong, ThongBao.ThanhCong, MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show(ThongBao.CapNhatThatBai, ThongBao.ThatBai, MessageBoxButtons.OK);
                frmQuanLiDocGia F2 = new frmQuanLiDocGia();
                this.Hide();
                F2.ShowDialog();
                this.Close();
            }
            catch (Exception Exc)
            {
                MessageBox.Show(ThongBao.LoiDuLieu, ThongBao.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            int count = docgiaBUS.LayDSDG().Count;
            count++;
            txtMaDocGia.Text = (Constrains.MaDocGia + count).ToString();
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
                List<DocGiaDTO> TimThay = new List<DocGiaDTO>();
                List<DocGiaDTO> dms = docgiaBUS.LayDSDG();
                foreach (DocGiaDTO item in dms)
                {
                    dtgvDocGia.DataSource = "";
                    if (item.MaDocGia.ToLower().Contains(value.ToLower()) == true || item.TenDocGia.ToLower().Contains(value.ToLower()) == true )
                    {
                        TimThay.Add(item);
                    }
                    dtgvDocGia.DataSource = TimThay;
                    if (value == "")
                    {
                        dtgvDocGia.DataSource = dms;

                    }
                }
            }
            catch (Exception Exc)
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
