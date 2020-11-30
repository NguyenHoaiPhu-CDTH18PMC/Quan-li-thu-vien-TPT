using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuanLiThuVienTPT
{
    public partial class frmTrangChu : Form
    {
        public string NhanTK = null;
        public string NhanMNV = null;
        public string NhanAnhDaiDien = null;
        public static int Quyen = -1;
        SachBUS sachBUS = new SachBUS();
        public frmTrangChu()
        {
            InitializeComponent();
        }
        public frmTrangChu(string manv, string tennv , string anhdaidien)
        {
            InitializeComponent();
            this.NhanMNV = manv;
            this.NhanTK = tennv;
            this.NhanAnhDaiDien = Constrains.PathImage + anhdaidien;
        }
        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            Time_Clock.Start();
            lblMNV.Text = NhanMNV;
            lblTenNV.Text = NhanTK;
            if (File.Exists(NhanAnhDaiDien))
            {
                // doc anh -> mang bytes
                byte[] bytes = File.ReadAllBytes(NhanAnhDaiDien);
                MemoryStream stream = new MemoryStream(bytes);
                ptbAnhDaiDien.Image = Image.FromStream(stream);              
            }
            if (!String.IsNullOrEmpty(this.NhanTK))
            {
                this.btnDangNhap.Visible = false;
                if(Quyen == 1)
                {
                    this.NhanVienItem.Enabled = false;
                    this.XoaLSItem.Enabled = false;
                }
            }
            else
            {
                this.btnLichSuDangNhap.Visible = false;
                this.btnRefreshData.Visible = false;
                this.btnBaoCao.Visible = false;
                this.btnSuCo.Visible = false;
                this.btnDangXuat.Visible = false;
                this.MuonTraItem.Enabled = false;
                this.SachItem.Enabled = false;
                this.DocGiaItem.Enabled = false;
                this.ItemXemThem.Enabled = false;
                this.TimSachItem.Enabled = false;
                this.TimDocGiaItem.Enabled = false;
                this.TimSachMuonItem.Enabled = false;
                this.ThongTinTKItem.Enabled = false;                 
                this.NhanVienItem.Enabled = false;
                ptbAnhDaiDien.Visible = false;
                this.XoaLSItem.Enabled = false;
            }
            SachBUS sachBUS = new SachBUS();
            int count = sachBUS.HetSach().Count;
            if (count > 0)
            {
                btnSuCo.BackColor = Color.Blue;
            }
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap dn = new frmDangNhap();
            dn.ShowDialog();
            this.Close();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show(ThongBao.DangXuat, ThongBao.DXuat, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                this.lblMNV.Text = "";
                this.lblTenNV.Text = "";
                this.btnDangXuat.Visible = false;
                this.btnLichSuDangNhap.Visible = false;
                this.btnRefreshData.Visible = false;
                this.btnBaoCao.Visible = false;
                this.btnSuCo.Visible = false;
                this.btnDangNhap.Visible = true;
                this.MuonTraItem.Enabled = false;
                this.SachItem.Enabled = false;
                this.DocGiaItem.Enabled = false;
                this.ItemXemThem.Enabled = false;
                this.TimDocGiaItem.Enabled = false;
                this.TimSachMuonItem.Enabled = false;
                this.ThongTinTKItem.Enabled = false;
                this.TimSachItem.Enabled = false;
                this.NhanVienItem.Enabled = false;
                ptbAnhDaiDien.Visible = false;
                this.XoaLSItem.Enabled = false;
            }
            else
            {

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show(ThongBao.Thoat, ThongBao.ThoatCT, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                MessageBox.Show(ThongBao.TamBiet, ThongBao.Chao, MessageBoxButtons.OK);
                //this.Close();
                Application.Exit();
            }
        }

        private void MuonTraItem_Click(object sender, EventArgs e)
        {
            frmQuanLiMuonTra A = new frmQuanLiMuonTra();
            A.ShowDialog();
        }

        private void SachItem_Click(object sender, EventArgs e)
        {
            frmQuanLiSach A = new frmQuanLiSach();
            A.ShowDialog();
        }

        private void DocGiaItem_Click(object sender, EventArgs e)
        {
            frmQuanLiDocGia A = new frmQuanLiDocGia();
            A.ShowDialog();
        }

        private void NhanVienItem_Click(object sender, EventArgs e)
        {
            frmQuanLiNhanVien A = new frmQuanLiNhanVien();
            A.ShowDialog();
        }

        private void btnLichSuDangNhap_Click(object sender, EventArgs e)
        {
            frmLichSuDangNhap A = new frmLichSuDangNhap();
            A.ShowDialog();
        }

        private void btnSuCo_Click(object sender, EventArgs e)
        {
            string SachHet = string.Empty;
            int count = sachBUS.HetSach().Count;
            List<SachDTO> dms = sachBUS.HetSach();
            foreach (SachDTO item in dms)
            {
                SachHet = SachHet + item.TenSach + "\n";
            }
            if(count > 0)
            {
                MessageBox.Show("Sách: \n" + SachHet +"\n"+"Đã hết", ThongBao.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(ThongBao.KhongSuCo, ThongBao.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void Time_Clock_Tick(object sender, EventArgs e)
        {
            btnTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnRefreshData_Click(object sender, EventArgs e)
        {
            int count = sachBUS.HetSach().Count;
            if (count > 0)
            {
                btnSuCo.BackColor = Color.Blue;
            }
            else
            {
                btnSuCo.BackColor = Color.Pink;
            }
        }

        private void frmTrangChu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode.Equals(Keys.R))
                {
                    btnRefreshData_Click(sender, e);
                }
                if (e.KeyCode.Equals(Keys.W))
                {
                    btnSuCo_Click(sender, e);
                }
                if (e.KeyCode.Equals(Keys.S))
                {
                   SachItem_Click( sender,  e);
                }
                if (e.KeyCode.Equals(Keys.D))
                {
                    DocGiaItem_Click(sender, e);
                }
                if (e.KeyCode.Equals(Keys.M))
                {
                    MuonTraItem_Click(sender, e);
                }
                if (e.KeyCode.Equals(Keys.N))
                {
                    NhanVienItem_Click(sender, e);
                }
            }
        }

        private void ThongTinTKItem_Click(object sender, EventArgs e)
        {
            frmThongTinTaiKhoan A = new frmThongTinTaiKhoan();
            A.ShowDialog();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ItemTaccGia_Click(object sender, EventArgs e)
        {
            frmQuanLiTacGia A = new frmQuanLiTacGia();
            A.ShowDialog();
        }

        private void ItemNXB_Click(object sender, EventArgs e)
        {
            frmQuanLiNXB A = new frmQuanLiNXB();
            A.ShowDialog();

        }

        private void ItemDauSach_Click(object sender, EventArgs e)
        {
            frmQuanLiDauSach A = new frmQuanLiDauSach();
            A.ShowDialog();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            frmChonBaoCao A = new frmChonBaoCao();
            A.ShowDialog();
        }

        private void XoaLSItem_Click(object sender, EventArgs e)
        {
            LichSuDangNhapBUS a = new LichSuDangNhapBUS();
            if (a.XoaLichSu()) 
            {
                MessageBox.Show(ThongBao.ThanhCong, ThongBao.ThanhCong);
            }
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TacVuItem.Text = "Action";
            this.TimKiemItem.Text = "Search";
            this.HeThongItem.Text = "System";
            this.NgonNguItem.Text = "Languages";
            this.ItemNXB.Text = "Publishing company";
            this.ItemDauSach.Text = "Title";
            this.ItemTaccGia.Text = "Author";
            this.MuonTraItem.Text = "Manager borrowed and returned";
            this.SachItem.Text = "Book management";
            this.DocGiaItem.Text = "Read reader management";
            this.ItemXemThem.Text = "More";
            this.TimDocGiaItem.Text = "Find readers";
            this.TimSachMuonItem.Text = "Find book";
            this.ThongTinTKItem.Text = "Account";
            this.TimSachItem.Text = "Find book";
            this.NhanVienItem.Text ="Employee management";

            this.XoaLSItem.Text = "Delete history";
        }

        private void vietnameseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TacVuItem.Text = "Tác vụ";
            this.TimKiemItem.Text = "Tìm kiếm";
            this.HeThongItem.Text = "Hệ thống ";
            this.NgonNguItem.Text = "Ngôn ngữ";
            this.ItemNXB.Text = "Quản lí NXB";
            this.ItemDauSach.Text = "Quản lí đầu sách";
            this.ItemTaccGia.Text = "Quản lí tác giả";
            this.MuonTraItem.Text = "Quản lí mượn trả";
            this.SachItem.Text = "Quản lí sách";
            this.DocGiaItem.Text = "Quản lí đọc giả";
            this.ItemXemThem.Text = "Xem thêm";
            this.TimDocGiaItem.Text = "Tìm độc giả";
            this.TimSachMuonItem.Text = "Tìm sách mượn";
            this.ThongTinTKItem.Text = "Thông tin tài khoản";
            this.TimSachItem.Text = "Tìm sách";
            this.NhanVienItem.Text ="Quản lí nhân viên";

            this.XoaLSItem.Text = "Delete history";
        }

        private void HuongDanSuDungItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ThongBao.SuDung, ThongBao.HDSuDung);
        }
    }
}
