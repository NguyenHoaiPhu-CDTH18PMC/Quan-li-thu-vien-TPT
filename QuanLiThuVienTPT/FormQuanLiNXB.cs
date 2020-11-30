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
    public partial class frmQuanLiNXB : Form
    {
        NhaXuatBanDTO nxbDTO = new NhaXuatBanDTO();
        NhaXuatBanBUS nxbBUS = new NhaXuatBanBUS();

        public frmQuanLiNXB()
        {
            InitializeComponent();
        }

        private void frmQuanLiNXB_Load(object sender, EventArgs e)
        {
            int count = nxbBUS.DemDSNXB().Count;
            count++;
            txtMaNXB.Text = (Constrains.MaNXB + count).ToString();
            List<NhaXuatBanDTO> tg = nxbBUS.LayDSNXB();
            dtgvNXB.AutoGenerateColumns = false;
            dtgvNXB.DataSource = tg;
        }

        private void dtgvNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                String manxb = dtgvNXB.Rows[e.RowIndex].Cells[0].Value.ToString();
                NhaXuatBanDTO nxb = nxbBUS.LayNXBTheoMa(manxb);

                if (nxb != null)
                {
                    txtMaNXB.Text = nxb.MaNXB;
                    txtTenNXB.Text = nxb.TenNXB;
                    txtEmail.Text = nxb.Email;
                    txtDiaChi.Text = nxb.DiaChi;
                }
            }
            catch (Exception Exc)
            {
                MessageBox.Show(ThongBao.LoiThaoTac, ThongBao.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            int count = nxbBUS.DemDSNXB().Count;
            count++;
            txtMaNXB.Text = (Constrains.MaNXB + count).ToString();
            txtDiaChi.ResetText();
            txtChuoiTK.ResetText();
            txtTenNXB.ResetText();
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
                nxbDTO.MaNXB = txtMaNXB.Text;
                nxbDTO.TenNXB = txtTenNXB.Text;
                nxbDTO.DiaChi = txtDiaChi.Text;
                nxbDTO.Email = txtEmail.Text;
                nxbDTO.XoaNXB = true;
                if (nxbBUS.ThemNXB(nxbDTO))
                {

                    Constrains.A.ShowDialog();
                    MessageBox.Show(ThongBao.ThemThanhCong, ThongBao.ThanhCong, MessageBoxButtons.OK);

                }
                else
                {
                    MessageBox.Show(ThongBao.ThemThatBai, ThongBao.ThatBai, MessageBoxButtons.OK);
                }
                frmQuanLiNXB_Load(sender, e);
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
                nxbDTO.MaNXB = txtMaNXB.Text;
                if (nxbBUS.XoaNXB(nxbDTO))
                {
                    Constrains.A.ShowDialog();
                    MessageBox.Show(ThongBao.XoaThanhCong, ThongBao.ThanhCong, MessageBoxButtons.OK);

                }
                else
                {
                    MessageBox.Show(ThongBao.XoaThatBai, ThongBao.ThatBai, MessageBoxButtons.OK);
                }
                frmQuanLiNXB_Load(sender, e);
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
                nxbDTO.MaNXB = txtMaNXB.Text;
                nxbDTO.TenNXB = txtTenNXB.Text;
                nxbDTO.DiaChi = txtDiaChi.Text;
                nxbDTO.Email = txtEmail.Text;
                if (nxbBUS.CapNhatNXB(nxbDTO))
                {
                    Constrains.A.ShowDialog();
                    MessageBox.Show(ThongBao.CapNhatThanhCong, ThongBao.ThanhCong, MessageBoxButtons.OK);
                }
                else
                {
                    Constrains.A.ShowDialog();
                    MessageBox.Show(ThongBao.CapNhatThatBai, ThongBao.ThatBai, MessageBoxButtons.OK);
                }
                frmQuanLiNXB_Load(sender, e);
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
                List<NhaXuatBanDTO> TimThay = new List<NhaXuatBanDTO>();
                List<NhaXuatBanDTO> dms = nxbBUS.LayDSNXB();
                foreach ( NhaXuatBanDTO item in dms)
                {
                    dtgvNXB.DataSource = "";
                    if (item.MaNXB.ToLower().Contains(value.ToLower()) == true || item.TenNXB.ToLower().Contains(value.ToLower()) == true )
                    {
                        TimThay.Add(item);
                    }
                    dtgvNXB.DataSource = TimThay;
                    if (value == "")
                    {
                        dtgvNXB.DataSource = dms;

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
