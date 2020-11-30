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
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVienTPT
{
    public partial class frmQuanLiNhanVien : Form
    {

        NhanVienBUS nhanvienBUS = new NhanVienBUS();
        NhanVienDTO nhanvienDTO = new NhanVienDTO();
        public frmQuanLiNhanVien()
        {
            InitializeComponent();
        }

        private void frmQuanLiNhanVien_Load(object sender, EventArgs e)
        {
            int count = nhanvienBUS.DemDanhSachNV().Count;
            count++;
            txtMaNV.Text = (Constrains.MaNV + count).ToString();
            List<NhanVienDTO> nv = nhanvienBUS.DanhSachNV();
            dtgvNhanVien.AutoGenerateColumns = false;
            dtgvNhanVien.DataSource = nv;
        }

        private void dtgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                String manv = dtgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                NhanVienDTO nv = nhanvienBUS.LayNhanVienTheoMa(manv);
                if (nv != null)
                {
                    txtMaNV.Text = nv.MaNV;
                    txtTenNV.Text = nv.TenNV;
                    txtDiaChi.Text = nv.DiaChi;
                    txtEmail.Text = nv.Email;
                    txtSDT.Text = nv.Phone;
                    txtTK.Text = nv.TK;
                    txtMK.Text = nv.MK.ConvertMD5();
                    if (dtgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString() == "Nam")
                    {
                        radNam.Checked = true;
                    }
                    else
                    {
                        radNu.Checked = true;
                    }
                    dtpNgaySinh.Value = DateTime.Parse(dtgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString());


                    string path = Constrains.PathImage + nv.AnhDaiDien;
                    txtt.Text = path.ToString();
                    if (File.Exists(path))
                    {
                        // doc anh -> mang bytes
                        byte[] bytes = File.ReadAllBytes(path);
                        MemoryStream stream = new MemoryStream(bytes);
                        ptbAnhDaiDien.Image = Image.FromStream(stream);
                        txtt.Text = path.ToString();
                    }
                }
            }
            catch (Exception Exc)
            {
                MessageBox.Show(ThongBao.LoiThaoTac, ThongBao.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string imgLocation = "";
        //Mo thu muc chon anh
        private void btnLoadAnh_Click(object sender, EventArgs e)
        {          
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = Constrains.DinhDang;
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                ptbAnhDaiDien.ImageLocation = imgLocation;
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

        private void btnThem_Click(object sender, EventArgs e)
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
                nhanvienDTO.TK = txtTK.Text;
                nhanvienDTO.MK = txtMK.Text.ConvertMD5();
                nhanvienDTO.Quyen = Constrains.QuyenThemNV;

                string imageName = nhanvienDTO.MaNV + random;
                if (taiXuongHinhAnh(imageName))
                {
                    nhanvienDTO.AnhDaiDien = imageName + Constrains.DuoiAnh;
                }

                /*byte[] img = null;
                FileStream fs;
                fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader Bin = new BinaryReader(fs);
                img = Bin.ReadBytes((int)fs.Length);

                nhanvienDTO.AnhDaiDien = ;*/

                nhanvienDTO.XoaNV = true;
                if (nhanvienBUS.ThemNV(nhanvienDTO))
                {
                    MessageBox.Show(ThongBao.ThemThanhCong, ThongBao.ThanhCong, MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show(ThongBao.ThemThatBai, ThongBao.ThatBai, MessageBoxButtons.OK);
                frmQuanLiNhanVien F2 = new frmQuanLiNhanVien();
                this.Hide();
                F2.ShowDialog();
                this.Close();
            }
            catch (Exception Exc)
            {
                MessageBox.Show(ThongBao.LoiDuLieu, ThongBao.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private byte[] converImgToByte()
        {
            FileStream fs;
            fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }
        private Image ByteToImg(string byteString)
        {
            byte[] imgBytes = Convert.FromBase64String(byteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                nhanvienDTO.MaNV = txtMaNV.Text;
                nhanvienDTO.XoaNV = true;
                if (nhanvienBUS.XoaNV(nhanvienDTO))
                {
                    MessageBox.Show(ThongBao.XoaThanhCong, ThongBao.ThanhCong, MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show(ThongBao.XoaThatBai, ThongBao.ThatBai, MessageBoxButtons.OK);
                frmQuanLiNhanVien F2 = new frmQuanLiNhanVien();
                this.Hide();
                F2.ShowDialog();
                this.Close();
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

        private void btnSua_Click(object sender, EventArgs e)
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
                nhanvienDTO.TK = txtTK.Text;
                nhanvienDTO.MK = txtMK.Text.ConvertMD5();
                string imageName = nhanvienDTO.MaNV + random;
                if (taiXuongHinhAnh(imageName))
                {
                    nhanvienDTO.AnhDaiDien = imageName + Constrains.DuoiAnh;
                }

                /*byte[] img = null;
                FileStream fs;
                fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader Bin = new BinaryReader(fs);
                img = Bin.ReadBytes((int)fs.Length);

                nhanvienDTO.AnhDaiDien = ;*/

                nhanvienDTO.XoaNV = true;
                if (nhanvienBUS.CapNhatNV(nhanvienDTO))
                {
                    MessageBox.Show(ThongBao.CapNhatThanhCong, ThongBao.ThanhCong, MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show(ThongBao.CapNhatThatBai, ThongBao.ThatBai, MessageBoxButtons.OK);
                frmQuanLiNhanVien_Load(sender, e);
            }
            catch (Exception Exc)
            {
                MessageBox.Show(ThongBao.LoiDuLieu, ThongBao.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            int count = nhanvienBUS.DemDanhSachNV().Count;
            count++;
            txtMaNV.Text = (Constrains.MaNV + count).ToString();
            txtDiaChi.ResetText();
            txtEmail.ResetText();
            txtMK.ResetText();
            txtSDT.ResetText();
            txtTenNV.ResetText();
            txtTK.ResetText();

        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
