using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLiThuVienTPT
{
    public partial class frmQuanLiDauSach : Form
    {
        DauSachBUS dsBUS = new DauSachBUS();
        DauSachDTO dsDTO = new DauSachDTO();
        public frmQuanLiDauSach()
        {
            InitializeComponent();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            int count = dsBUS.DemDSDS().Count;
            count++;
            txtMaDS.Text = (Constrains.MaDauSach + count).ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                dsDTO.MaDauSach = txtMaDS.Text;
                dsDTO.TenDauSach = txtTenDS.Text;
                dsDTO.MaTheLoai = cboTheLoai.SelectedValue.ToString();
                dsDTO.XoaTheLoai = true;
                if (dsBUS.ThemDS(dsDTO))
                {

                    Constrains.A.ShowDialog();
                    MessageBox.Show(ThongBao.ThemThanhCong, ThongBao.ThanhCong, MessageBoxButtons.OK);

                }
                else
                {
                    MessageBox.Show(ThongBao.ThemThatBai, ThongBao.ThatBai, MessageBoxButtons.OK);
                }
                frmQuanLiDauSach_Load(sender, e);
                btnThemMoi_Click(sender, e);
            }
            catch (Exception Exc)
            {
                MessageBox.Show(ThongBao.LoiThaoTac, ThongBao.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                dsDTO.MaDauSach = txtMaDS.Text;
                dsDTO.TenDauSach = txtTenDS.Text;
                dsDTO.MaTheLoai = cboTheLoai.SelectedValue.ToString();
                if (dsBUS.CapNhatDS(dsDTO))
                {
                    Constrains.A.ShowDialog();
                    MessageBox.Show(ThongBao.CapNhatThanhCong, ThongBao.ThanhCong, MessageBoxButtons.OK);
                }
                else
                {
                    Constrains.A.ShowDialog();
                    MessageBox.Show(ThongBao.CapNhatThatBai, ThongBao.ThatBai, MessageBoxButtons.OK);
                }
                frmQuanLiDauSach_Load(sender, e);
                btnThemMoi_Click(sender, e);
            }
            catch (Exception Exc)
            {
                MessageBox.Show(ThongBao.LoiDuLieu, ThongBao.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                dsDTO.MaDauSach = txtMaDS.Text;
                if (dsBUS.XoaDS(dsDTO))
                {
                    Constrains.A.ShowDialog();
                    MessageBox.Show(ThongBao.XoaThanhCong, ThongBao.ThanhCong, MessageBoxButtons.OK);

                }
                else
                {
                    MessageBox.Show(ThongBao.XoaThatBai, ThongBao.ThatBai, MessageBoxButtons.OK);
                }
                frmQuanLiDauSach_Load(sender, e);
                btnThemMoi_Click(sender, e);
            }
            catch (Exception Exc)
            {
                MessageBox.Show(ThongBao.LoiDuLieu, ThongBao.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmQuanLiDauSach_Load(object sender, EventArgs e)
        {
            int count = dsBUS.DemDSDS().Count;
            count++;
            txtMaDS.Text = (Constrains.MaDauSach + count).ToString();
            cboTheLoai.DataSource = dsBUS.DanhSachDauSach();
            cboTheLoai.DisplayMember = "TenTheLoai";
            cboTheLoai.ValueMember = "MaTheLoai";
            List<DauSachDTO> ds = dsBUS.DanhSachDauSach();
            dtgvDauSach.AutoGenerateColumns = false;
            dtgvDauSach.DataSource = ds;
        }

        private void dtgvDauSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                string mads = dtgvDauSach.Rows[e.RowIndex].Cells[0].Value.ToString();
                string tends = dtgvDauSach.Rows[e.RowIndex].Cells[1].Value.ToString();
                string matl = dtgvDauSach.Rows[e.RowIndex].Cells[2].Value.ToString();
                DauSachDTO ds = dsBUS.LayDauSachTheoMa(mads);

                if (ds != null)
                {
                    txtMaDS.Text = ds.MaDauSach;
                    txtTenDS.Text = ds.TenDauSach;
                    cboTheLoai.SelectedValue = ds.MaTheLoai;
                }
            }
            catch (Exception Exc)
            {
                MessageBox.Show(ThongBao.LoiDuLieu, ThongBao.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtChuoiTK_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string value = txtChuoiTK.Text;
                List<DauSachDTO> TimThay = new List<DauSachDTO>();
                List<DauSachDTO> dms = dsBUS.DanhSachDauSach();
                foreach (DauSachDTO item in dms)
                {
                    dtgvDauSach.DataSource = "";
                    if (item.MaDauSach.ToLower().Contains(value.ToLower()) == true || item.TenDauSach.ToLower().Contains(value.ToLower()) == true)
                    {
                        TimThay.Add(item);
                    }
                    dtgvDauSach.DataSource = TimThay;
                    if (value == "")
                    {
                        dtgvDauSach.DataSource = dms;

                    }
                }
            }
            catch (Exception Exc)
            {
                MessageBox.Show(ThongBao.NhapChuoiKhac);
            }
        }
    }
}
