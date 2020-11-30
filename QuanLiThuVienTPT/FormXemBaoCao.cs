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
using Microsoft.Reporting.WinForms;
namespace QuanLiThuVienTPT
{
    public partial class FormXemBaoCao : Form
    {
        SachBUS sBUS = new SachBUS();
        DauSachBUS dsBUS = new DauSachBUS();
        MuonTraBUS mtBUS = new MuonTraBUS();
        public FormXemBaoCao()
        {
            InitializeComponent();
        }
        public void TatCaSach()
        {
            List<SachDTO> lstSach = sBUS.DanhMucSach();
            this.rptBaoCao.LocalReport.ReportEmbeddedResource = "QuanLiThuVienTPT.rptTatCaSach.rdlc";
            this.rptBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSSach",lstSach));
            this.rptBaoCao.RefreshReport();
        }
        public void TheoDauSach(DauSachDTO DauSach)
        {
            List<SachDTO> lstDauSach = sBUS.LaySachTheoDauSach(DauSach.MaDauSach);
            this.rptBaoCao.LocalReport.ReportEmbeddedResource = "QuanLiThuVienTPT.rptTheoDauSach.rdlc";
            this.rptBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSDauSach", lstDauSach));
            this.rptBaoCao.LocalReport.SetParameters(new ReportParameter("paTenDauSach", DauSach.TenDauSach));
            this.rptBaoCao.RefreshReport();
        }
        public void NhomDauSach()
        {
            List<DauSachDTO> lstSach = dsBUS.DanhSachDauSach();
            this.rptBaoCao.LocalReport.ReportEmbeddedResource = "QuanLiThuVienTPT.rptDauSachGroup.rdlc";
            this.rptBaoCao.LocalReport.SubreportProcessing+=new SubreportProcessingEventHandler(LocalReport_SubreportProcessing);
            this.rptBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSDauSachGroup", lstSach));
            this.rptBaoCao.RefreshReport();
        }
        public void PhieuPhat()
        {
            List<SachDTO> lstDauSach = sBUS.DanhMucSach();
            this.rptBaoCao.LocalReport.ReportEmbeddedResource = "QuanLiThuVienTPT.rptPhieuPhat.rdlc";
            this.rptBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSPhat", lstDauSach));
            this.rptBaoCao.LocalReport.SetParameters(new ReportParameter("paNguoiLap", "<Tên người lập>"));
            this.rptBaoCao.LocalReport.SetParameters(new ReportParameter("paNgayLap", DateTime.Today.AddDays(-7).ToString()));
            this.rptBaoCao.RefreshReport();
        }
        void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            string madausach = e.Parameters["paMaDauSach"].Values[0];
            e.DataSources.Add(new ReportDataSource("DSSachSub", sBUS.LaySachTheoDauSach(madausach)));
        }
    }
}
