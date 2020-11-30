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
    public partial class frmDangNhap : Form
    {
        LichSuDangNhapBUS historyBUS = new LichSuDangNhapBUS();
        LichSuDangNhapDTO historyDTO = new LichSuDangNhapDTO();
        NhanVienBUS nhanvienBUS = new NhanVienBUS();
        NhanVienDTO nhanvienDTO = new NhanVienDTO();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string tk = txtUserName.Text;
                NhanVienDTO nv = nhanvienBUS.LayMKTheoTK(tk);
                List<NhanVienDTO> dsnv = nhanvienBUS.DanhSachNV();
                /*if (txtUserName.Text != "NguyenHoaiPhu" || txtPassWord.Text != "123456")
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }*/
                if (txtPassWord.Text.ConvertMD5() != nv.MK)
                {
                    MessageBox.Show(ThongBao.SaiTKMK,ThongBao.DangNhapTB, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    historyDTO.MaNV = nv.MaNV.ToString();
                    historyDTO.XoaLS = true;
                    //historyBUS.LuuLichSu(historyDTO);
                    //historyDTO.TGDangNhap = DateTime.Now.ToString("yyyy/MM/dd h:mm tt");
                    if (historyBUS.LuuLichSu(historyDTO))
                    {
                        //MessageBox.Show("Đăng nhập" , "Thành công");

                    }
                    else
                        MessageBox.Show(ThongBao.SaiTKMK, ThongBao.DangNhapTB, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    frmTrangChu formHome = new frmTrangChu(nv.MaNV, nv.TenNV, nv.AnhDaiDien);
                    Constrains.NhanMaNV = nv.MaNV;
                    /*if(nv.MaNV.Contains("NV"))
                        frmTrangChu.Quyen = 1;
                    else
                        frmTrangChu.Quyen = 0;*/

                    if (nv.Quyen == Constrains.Quyen)
                    {
                        frmTrangChu.Quyen = 0;
                    }
                    else
                        frmTrangChu.Quyen = 1;
                    formHome.ShowDialog();
                    this.Close();
                }
            }
            catch(Exception Exc)
            {
                MessageBox.Show(ThongBao.SaiTKMK, ThongBao.DangNhapTB, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
