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
    public partial class frmLichSuDangNhap : Form
    {
        LichSuDangNhapBUS historyBUS = new LichSuDangNhapBUS();
        LichSuDangNhapDTO historyDTO = new LichSuDangNhapDTO();
        public frmLichSuDangNhap()
        {
            InitializeComponent();
        }

        private void frmLichSuDangNhap_Load(object sender, EventArgs e)
        {
            List<LichSuDangNhapDTO> ls = historyBUS.DanhSachTruyCap();
            dtgvLichSu.AutoGenerateColumns = false;
            dtgvLichSu.DataSource = ls;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
