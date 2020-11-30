using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace QuanLiThuVienTPT
{
    public partial class frmChonBaoCao : Form
    {
        DauSachBUS dsBUS = new DauSachBUS();
        public frmChonBaoCao()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if(radTatCa.Checked)
            {
                FormXemBaoCao A = new FormXemBaoCao();
                A.TatCaSach();
                A.ShowDialog();
            }
            if(radTheoDauSach.Checked)
            {
                FormXemBaoCao C = new FormXemBaoCao();
                C.TheoDauSach((DauSachDTO)cboDS.SelectedItem);
                C.ShowDialog();
            }
            if (radNhomDS.Checked)
            {
                FormXemBaoCao A = new FormXemBaoCao();
                A.NhomDauSach();
                A.ShowDialog();
            }
            if (radPhat.Checked)
            {
                FormXemBaoCao A = new FormXemBaoCao();
                A.PhieuPhat();
                A.ShowDialog();
            }
        }

        private void frmChonBaoCao_Load(object sender, EventArgs e)
        {
            cboDS.DisplayMember = "TenDauSach";
            cboDS.ValueMember = "MaDauSach";
            cboDS.DataSource = dsBUS.DanhSachDauSach();
        }
    }
}
