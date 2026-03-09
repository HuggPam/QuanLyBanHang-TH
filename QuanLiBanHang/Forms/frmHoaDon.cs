using ClosedXML.Excel;
using QuanLiBanHang.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiBanHang.Forms
{
    public partial class frmHoaDon : Form
    {
        QLBHDbContext context = new QLBHDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        int id;
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            List<DanhSachHoaDon> hd = new List<DanhSachHoaDon>();
            hd = context.HoaDon.Select(r => new DanhSachHoaDon
            {
                ID = r.ID,
                NhanVienID = r.NhanVienID,
                HoVaTenNhanVien = r.NhanVien.HoVaTen,
                KhachHangID = r.KhachHangID,
                HoVaTenKhachHang = r.KhachHang.HoVaTen,
                NgayLap = r.NgayLap,
                GhiChuHoaDon = r.GhiChuHoaDon,
                TongTienHoaDon = r.HoaDon_ChiTiet.Sum(r => r.SoLuongBan * r.DonGiaBan),
                XemChiTiet = "Xem chi tiết"
            }).ToList();
            dataGridView.DataSource = hd;
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet())
            {
                chiTiet.ShowDialog();
                frmHoaDon_Load(sender, e);
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet(id))
            {
                chiTiet.ShowDialog();
                frmHoaDon_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa hóa đơn số " + dataGridView.CurrentRow.Cells["ID"].Value.ToString() + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                HoaDon hd = context.HoaDon.Find(id);
                if (hd != null)
                {
                    context.HoaDon.Remove(hd);
                }
                context.SaveChanges();
                frmHoaDon_Load(sender, e);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu Hóa đơn ra Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xlsx";
            saveFileDialog.FileName = "HoaDon_" + DateTime.Now.ToString("ddMMyyyy") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        // --- SHEET 1: DANH SÁCH HÓA ĐƠN ---
                        DataTable dtHoaDon = new DataTable();
                        dtHoaDon.Columns.AddRange(new DataColumn[] {
                    new DataColumn("Mã HĐ", typeof(int)),
                    new DataColumn("Tên Nhân Viên", typeof(string)),
                    new DataColumn("Tên Khách Hàng", typeof(string)),
                    new DataColumn("Ngày Lập", typeof(DateTime)),
                    new DataColumn("Tổng Tiền", typeof(double)),
                    new DataColumn("Ghi Chú", typeof(string))
                });

                        // Truy vấn dữ liệu sử dụng lớp DanhSachHoaDon để lấy đầy đủ thông tin tên
                        var dsHoaDon = context.HoaDon.Select(r => new DanhSachHoaDon
                        {
                            ID = r.ID,
                            HoVaTenNhanVien = r.NhanVien.HoVaTen,
                            HoVaTenKhachHang = r.KhachHang.HoVaTen,
                            NgayLap = r.NgayLap,
                            GhiChuHoaDon = r.GhiChuHoaDon,
                            // Tính tổng tiền trực tiếp từ danh sách chi tiết
                            TongTienHoaDon = r.HoaDon_ChiTiet.Sum(ct => ct.SoLuongBan * ct.DonGiaBan)
                        }).ToList();

                        foreach (var hd in dsHoaDon)
                        {
                            dtHoaDon.Rows.Add(hd.ID, hd.HoVaTenNhanVien, hd.HoVaTenKhachHang, hd.NgayLap, hd.TongTienHoaDon, hd.GhiChuHoaDon);
                        }
                        var sheetHD = wb.Worksheets.Add(dtHoaDon, "HoaDon");
                        sheetHD.Columns().AdjustToContents(); // Tự động giãn cột

                        // --- SHEET 2: CHI TIẾT HÓA ĐƠN ---
                        DataTable dtChiTiet = new DataTable();
                        dtChiTiet.Columns.AddRange(new DataColumn[] {
                    new DataColumn("Mã HĐ", typeof(int)),
                    new DataColumn("Tên Sản Phẩm", typeof(string)),
                    new DataColumn("Số Lượng", typeof(int)),
                    new DataColumn("Đơn Giá", typeof(int)),
                    new DataColumn("Thành Tiền", typeof(double))
                });

                        var dsChiTiet = context.HoaDon_ChiTiet.Select(ct => new {
                            ct.HoaDonID,
                            TenSP = ct.SanPham.TenSanPham,
                            ct.SoLuongBan,
                            ct.DonGiaBan,
                            ThanhTien = ct.SoLuongBan * ct.DonGiaBan
                        }).ToList();

                        foreach (var ct in dsChiTiet)
                        {
                            dtChiTiet.Rows.Add(ct.HoaDonID, ct.TenSP, ct.SoLuongBan, ct.DonGiaBan, ct.ThanhTien);
                        }
                        var sheetCT = wb.Worksheets.Add(dtChiTiet, "HoaDon_ChiTiet");
                        sheetCT.Columns().AdjustToContents();

                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Xuất báo cáo hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTailai_Click(object sender, EventArgs e)
        {
            frmHoaDon_Load(sender, e);
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu Hóa đơn từ Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        // Nhập dữ liệu từ sheet mang tên "HoaDon"
                        var worksheet = workbook.Worksheet("HoaDon");
                        var rows = worksheet.RangeUsed().RowsUsed().Skip(1); // Bỏ qua dòng tiêu đề

                        foreach (var row in rows)
                        {
                            HoaDon hd = new HoaDon();
                            // Lưu ý: Cột ID tự tăng trong DB nên không nhập từ Excel
                            hd.NhanVienID = int.Parse(row.Cell(2).Value.ToString());
                            hd.KhachHangID = int.Parse(row.Cell(3).Value.ToString());
                            hd.NgayLap = DateTime.Parse(row.Cell(4).Value.ToString());
                            hd.GhiChuHoaDon = row.Cell(5).Value.ToString();

                            context.HoaDon.Add(hd);
                        }
                        context.SaveChanges();
                        MessageBox.Show("Nhập dữ liệu hóa đơn thành công!", "Thông báo");
                        frmHoaDon_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi nhập file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
