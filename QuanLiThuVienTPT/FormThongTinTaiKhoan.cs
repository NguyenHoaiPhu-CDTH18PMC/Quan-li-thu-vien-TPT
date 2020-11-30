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
    public partial class frmThongTinTaiKhoan : Form
    {
        NhanVienBUS nhanvienBUS = new NhanVienBUS();
        NhanVienDTO nhanvienDTO = new NhanVienDTO();
        public frmThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                Random r = new Random();
                string random = (r.Next(1, 1000)).ToString();
                nhanvienDTO.MaNV = txtMaNV.Text;
                nhanvienDTO.TenNV = txtTenNV.Text;
                nhanvienDTO.NgaySinh = dtpNgaySinh.Value;
                if (radNam.Checked == true)
                    nhanvienDTO.GioiTinh = radNam.Text;
                else
                    nhanvienDTO.GioiTinh = radNu.Text;
                nhanvienDTO.DiaChi = txtDiaChi.Text;
                nhanvienDTO.Email = txtEmail.Text;
                nhanvienDTO.Phone = txtSDT.Text;
                nhanvienDTO.MK = txtMK.Text;
                string imageName = nhanvienDTO.MaNV + random;
                if (taiXuongHinhAnh(imageName))
                {
                    nhanvienDTO.AnhDaiDien = imageName + Constrains.DuoiAnh;
                }

                nhanvienDTO.XoaNV = true;
                if (nhanvienBUS.CapNhatNV(nhanvienDTO))
                {
                    MessageBox.Show(ThongBao.CapNhatThanhCong, ThongBao.ThanhCong, MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show(ThongBao.CapNhatThatBai, ThongBao.ThatBai, MessageBoxButtons.OK);
            }
            catch (Exception Exc)
            {
                MessageBox.Show(ThongBao.LoiDuLieu, ThongBao.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        public bool taiXuongHinhAnh(string Ma)
        {

            string path = Constrains.PathImage + Ma + Constrains.DuoiAnh;
            using (MemoryStream mem = new MemoryStream())
            {
                using (FileStream fstream = new FileStream(Constrains.PathImage + Ma + Constrains.DuoiAnh, FileMode.Create, FileAccess.ReadWrite))
                {

                    Bitmap bm = new Bitmap(ptbAnhDaiDien.Image);
                    bm.Save(mem, ImageFormat.Jpeg);
                    byte[] bytes = mem.ToArray();

                    fstream.Write(bytes, 0, bytes.Length);
                }
            }
            if (File.Exists(path))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void FormThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            NhanVienDTO nv = nhanvienBUS.LayNhanVienTheoMa(Constrains.NhanMaNV);
            txtMaNV.Text = nv.MaNV;
            if (nv != null)
            {
                txtMaNV.Text = nv.MaNV;
                txtTenNV.Text = nv.TenNV;
                txtDiaChi.Text = nv.DiaChi;
                txtEmail.Text = nv.Email;
                txtSDT.Text = nv.Phone;
                txtTK.Text = nv.TK;
                txtMK.Text = nv.MK;
                if (nv.GioiTinh == "Nam")
                {
                    radNam.Checked = true;
                }
                else
                {
                    radNu.Checked = true;
                }
                dtpNgaySinh.Value = nv.NgaySinh;


                string path = Constrains.PathImage + nv.AnhDaiDien;
                if (File.Exists(path))
                {
                    // doc anh -> mang bytes
                    byte[] bytes = File.ReadAllBytes(path);
                    MemoryStream stream = new MemoryStream(bytes);
                    ptbAnhDaiDien.Image = Image.FromStream(stream);
                }
            }
        }

        public string imgLocation = "";
        private void btnLoadAnh_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = Constrains.DinhDang;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imgLocation = dialog.FileName.ToString();
                    ptbAnhDaiDien.ImageLocation = imgLocation;
                }
            }
            catch (Exception Exc)
            {
                MessageBox.Show(ThongBao.ThatBai, ThongBao.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
