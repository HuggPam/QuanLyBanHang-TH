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
using QuanLyBanHang.Reports;





namespace QuanLyBanHang.Reports
{
    public partial class frmThongKeDoanhThu : Form
    {

        QLBHDbContext context = new QLBHDbContext();
        QLBHDataSet.DanhSachDoanhThuDataTable danhSachDoanhThuDataTable = new QLBHDataSet.DanhSachDoanhThuDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net5.0-windows", "Reports");
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer(); // Bây giờ dòng này sẽ hết lỗi
            this.reportViewer.Dock = DockStyle.Fill;
            this.Controls.Add(this.reportViewer);
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            // 1. Truy vấn dữ liệu doanh thu và tính Tổng tiền hóa đơn bằng LINQ
            var danhSachDoanhThu = context.HoaDon.Select(h => new DanhSachHoaDon
            {
                ID = h.ID,
                NgayLap = h.NgayLap,
                KhachHangID = h.KhachHangID,
                HoVaTenKhachHang = h.KhachHang.HoVaTen, // Lấy từ virtual KhachHang
                NhanVienID = h.NhanVienID,
                HoVaTenNhanVien = h.NhanVien.HoVaTen,   // Lấy từ virtual NhanVien
                GhiChuHoaDon = h.GhiChuHoaDon,
                // Tính tổng tiền bằng cách Sum (Số lượng * Đơn giá) từ danh sách chi tiết
                TongTienHoaDon = h.HoaDon_ChiTiet.Sum(ct => (double?)ct.SoLuongBan * ct.DonGiaBan) ?? 0
            }).ToList();

            danhSachDoanhThuDataTable.Clear();
            foreach (var row in danhSachDoanhThu)
            {
                danhSachDoanhThuDataTable.AddDanhSachDoanhThuRow(
                    row.ID,
                    row.NhanVienID,        // Thêm cột này
                    row.HoVaTenNhanVien,
                    row.KhachHangID,       // Thêm cột này
                    row.HoVaTenKhachHang,
                    row.NgayLap,           // Đưa NgayLap về đúng vị trí số 6
                    row.GhiChuHoaDon ?? "",
                    row.XemChiTiet,        // Thêm cột này (nếu có dữ liệu)
                    row.TongTienHoaDon ?? 0
                );
            }
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DanhSachDoanhThu"; // Tên này phải khớp với tên đặt trong file .rdlc
            reportDataSource.Value = danhSachDoanhThuDataTable;

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.LocalReport.ReportPath = @"Reports\rptThongKeDoanhThu.rdlc";
            ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "(Tất cả thời gian)");
            reportViewer.LocalReport.SetParameters(reportParameter);
            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;
            reportViewer.RefreshReport();
        }

        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            var danhSachHoaDon = context.HoaDon.Select(r => new DanhSachHoaDon
            {
                ID = r.ID,
                NhanVienID = r.NhanVienID,
                HoVaTenNhanVien = r.NhanVien.HoVaTen,
                KhachHangID = r.KhachHangID,
                HoVaTenKhachHang = r.KhachHang.HoVaTen,
                NgayLap = r.NgayLap,
                GhiChuHoaDon = r.GhiChuHoaDon,
                TongTienHoaDon = r.HoaDon_ChiTiet.Sum(r => r.SoLuongBan * r.DonGiaBan)
            });
            danhSachHoaDon = danhSachHoaDon.Where(r => r.NgayLap >= dtpTuNgay.Value && r.NgayLap <= dtpDenNgay.Value);
            danhSachDoanhThuDataTable.Clear();
            foreach (var row in danhSachHoaDon)
            {
                danhSachDoanhThuDataTable.AddDanhSachDoanhThuRow(
                    row.ID,
                    row.NhanVienID,
                    row.HoVaTenNhanVien,
                    row.KhachHangID,
                    row.HoVaTenKhachHang,
                    row.NgayLap,
                    row.GhiChuHoaDon ?? "",
                    row.XemChiTiet,
                    row.TongTienHoaDon ?? 0);
            }
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DanhSachDoanhThu";
            reportDataSource.Value = danhSachDoanhThuDataTable;
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeDoanhThu.rdlc");
            ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "Từ ngày " + dtpTuNgay.Text + " - Đến ngày: " + dtpDenNgay.Text);
            reportViewer.LocalReport.SetParameters(reportParameter);
            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;
            reportViewer.RefreshReport();
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            frmThongKeDoanhThu_Load(sender, e);
        }
    }
}
