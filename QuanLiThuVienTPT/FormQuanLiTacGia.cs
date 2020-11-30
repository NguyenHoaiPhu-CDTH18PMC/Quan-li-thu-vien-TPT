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
    public partial class frmQuanLiTacGia : Form
    {
        TacGiaBUS tgBUS = new TacGiaBUS();
        TacGiaDTO tgDTO = new TacGiaDTO();
        public frmQuanLiTacGia()
        {
            InitializeComponent();
        }

        private void frmQuanLiTacGia_Load(object sender, EventArgs e)
        {
            int count = tgBUS.DemDanhSachTG().Count;
            count++;
            txtMaTG.Text = (Constrains.MaTacGia + count).ToString();
            List<TacGiaDTO> tg = tgBUS.DanhSachTG();
            dtgvTacGia.AutoGenerateColumns = false;
            dtgvTacGia.DataSource = tg;
        }

        private void dtgvTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                String matacgia = dtgvTacGia.Rows[e.RowIndex].Cells[0].Value.ToString();
                String tentacgia = dtgvTacGia.Rows[e.RowIndex].Cells[1].Value.ToString();
                String email = dtgvTacGia.Rows[e.RowIndex].Cells[2].Value.ToString();
                String diachi = dtgvTacGia.Rows[e.RowIndex].Cells[3].Value.ToString();
                TacGiaDTO tacgia = tgBUS.LayTacGiaTheoMa(matacgia);

                if (tacgia != null)
                {
                    txtMaTG.Text = tacgia.MaTacGia;
                    txtTenTG.Text = tacgia.HoTen;
                    txtEmail.Text = tacgia.Email;
                    txtDiaChi.Text = tacgia.DiaChi;
                }
            }
            catch (Exception Exc)
            {
                MessageBox.Show(ThongBao.LoiThaoTac, ThongBao.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            int count = tgBUS.DemDanhSachTG().Count;
            count++;
            txtMaTG.Text = (Constrains.MaTacGia + count).ToString();
            txtDiaChi.ResetText();
            txtChuoiTK.ResetText();
            txtTenTG.ResetText();
            txtEmail.ResetText();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                tgDTO.MaTacGia = txtMaTG.Text;
                tgDTO.HoTen = txtTenTG.Text;
                tgDTO.Email = txtEmail.Text;
                tgDTO.DiaChi = txtDiaChi.Text;
                tgDTO.XoaTacGia = true;
                if (tgBUS.ThemTG(tgDTO))
                {

                    Constrains.A.ShowDialog();
                    MessageBox.Show(ThongBao.ThemThanhCong, ThongBao.ThanhCong, MessageBoxButtons.OK);

                }
                else
                {
                    MessageBox.Show(ThongBao.ThemThatBai, ThongBao.ThatBai, MessageBoxButtons.OK);
                }
                frmQuanLiTacGia_Load(sender, e);
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
                tgDTO.MaTacGia = txtMaTG.Text;
                if (tgBUS.XoaTG(tgDTO))
                {
                    Constrains.A.ShowDialog();
                    MessageBox.Show(ThongBao.XoaThanhCong, ThongBao.ThanhCong, MessageBoxButtons.OK);

                }
                else
                {
                    MessageBox.Show(ThongBao.XoaThatBai, ThongBao.ThatBai, MessageBoxButtons.OK);
                }
                frmQuanLiTacGia_Load(sender, e);
                btnThemMoi_Click(sender, e);
            }
            catch (Exception Exc)
            {
                MessageBox.Show(ThongBao.LoiDuLieu, ThongBao.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                tgDTO.MaTacGia = txtMaTG.Text;
                tgDTO.HoTen = txtTenTG.Text;
                tgDTO.Email = txtEmail.Text;
                tgDTO.DiaChi = txtDiaChi.Text;
                if (tgBUS.CapNhatTG(tgDTO))
                {
                    Constrains.A.ShowDialog();
                    MessageBox.Show(ThongBao.CapNhatThanhCong, ThongBao.ThanhCong, MessageBoxButtons.OK);
                }
                else
                {
                    Constrains.A.ShowDialog();
                    MessageBox.Show(ThongBao.CapNhatThatBai, ThongBao.ThatBai, MessageBoxButtons.OK);
                }
                frmQuanLiTacGia_Load(sender, e);
                btnThemMoi_Click(sender, e);
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
                List<TacGiaDTO> TimThay = new List<TacGiaDTO>();
                List<TacGiaDTO> dms = tgBUS.DanhSachTG();
                foreach (TacGiaDTO item in dms)
                {
                    dtgvTacGia.DataSource = "";
                    if (item.MaTacGia.ToLower().Contains(value.ToLower()) == true || item.HoTen.ToLower().Contains(value.ToLower()) == true)
                    {
                        TimThay.Add(item);
                    }
                    dtgvTacGia.DataSource = TimThay;
                    if (value == "")
                    {
                        dtgvTacGia.DataSource = dms;

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
