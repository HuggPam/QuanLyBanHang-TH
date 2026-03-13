using Microsoft.Reporting.WinForms;
using QuanLyBanHang.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyBanHang.Reports.QLBHDataSet;

namespace QuanLyBanHang.Reports
{
    public partial class frmThongKeDoanhThu : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        QLBHDataSet.DoanhThuDataTable doanhThuDataTable = new QLBHDataSet.DoanhThuDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net5.0-windows", "Reports");
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;

        public frmThongKeDoanhThu()
        {
            InitializeComponent();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer.Dock = DockStyle.Fill;
            this.Controls.Add(this.reportViewer);
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            var danhSachDoanhThu = context.HoaDon_ChiTiet.Select(r => new DanhSachHoaDon_ChiTiet
            {
                ID = r.ID,
                HoaDonID = r.HoaDonID,
                SanPhamID = r.SanPhamID,
                TenSanPham = r.SanPham.TenSanPham,
                SoLuongBan = r.SoLuongBan,
                DonGiaBan = r.DonGiaBan,
            }).ToList();

            doanhThuDataTable.Clear();
            foreach (var row in danhSachDoanhThu)
            {
                doanhThuDataTable.AddDoanhThuRow(
                    row.ID,
                    row.HoaDonID,
                    row.SanPhamID,
                    row.TenSanPham,
                    row.SoLuongBan,
                    row.DonGiaBan
                );

                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DoanhThu";
                reportDataSource.Value = doanhThuDataTable;

                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(reportDataSource);
                //reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeSanPham.rdlc");
                reportViewer.LocalReport.ReportPath = @"Reports\rptThongKeDoanhThu.rdlc";

                reportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer.ZoomMode = ZoomMode.Percent;
                reportViewer.ZoomPercent = 100;

                reportViewer.RefreshReport();
            }
        }
    }
}
