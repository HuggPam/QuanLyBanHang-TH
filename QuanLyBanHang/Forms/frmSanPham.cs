using Microsoft.EntityFrameworkCore.ChangeTracking;
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
using ClosedXML.Excel;
namespace QuanLyBanHang.Forms
{
    public partial class frmSanPham : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        bool xuLyThem = false;
        int id;
        string imagesFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Images\\");
        public frmSanPham()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            cboHangSanXuat.Enabled = giaTri;
            cboLoaiSanPham.Enabled = giaTri;
            txtTenSanPham.Enabled = giaTri;
            numSoLuong.Enabled = giaTri;
            numDonGia.Enabled = giaTri;
            txtMoTa.Enabled = giaTri;
            picHinhAnh.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnDoiAnh.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }
        public void LayLoaiSanPhamVaoComboBox()
        {
            cboLoaiSanPham.DataSource = context.LoaiSanPham.ToList();
            cboLoaiSanPham.ValueMember = "ID";
            cboLoaiSanPham.DisplayMember = "TenLoai";
        }
        public void LayHangSanXuatVaoComboBox()
        {
            // Tương tự LayLoaiSanPhamVaoComboBox()
            cboHangSanXuat.DataSource = context.HangSanXuat.ToList();
            cboHangSanXuat.ValueMember = "ID";
            cboHangSanXuat.DisplayMember = "TenHangSanXuat";

        }
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            BatTatChucNang(false);
            LayHangSanXuatVaoComboBox();
            LayLoaiSanPhamVaoComboBox();

            List<DanhSachSanPham> sp = new List<DanhSachSanPham>();
            sp = context.SanPham.Select(r => new DanhSachSanPham
            {
                ID = r.ID,
                LoaiSanPhamID = r.LoaiSanPhamID,
                TenLoai = r.LoaiSanPham.TenLoai,
                HangSanXuatID = r.HangSanXuatID,
                TenHangSanXuat = r.HangSanXuat.TenHangSanXuat,
                TenSanPham = r.TenSanPham,
                SoLuong = r.SoLuong,
                DonGia = r.DonGia,
                HinhAnh = r.HinhAnh,
            }).ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = sp;

            cboLoaiSanPham.DataBindings.Clear();
            cboLoaiSanPham.DataBindings.Add("SelectedValue", bindingSource, "LoaiSanPhamID", false, DataSourceUpdateMode.Never);

            cboHangSanXuat.DataBindings.Clear();
            cboHangSanXuat.DataBindings.Add("SelectedValue", bindingSource, "HangSanXuatID", false, DataSourceUpdateMode.Never);

            txtTenSanPham.DataBindings.Clear();
            txtTenSanPham.DataBindings.Add("Text", bindingSource, "TenSanPham", false, DataSourceUpdateMode.Never);

            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", bindingSource, "MoTa", false, DataSourceUpdateMode.Never);

            numSoLuong.DataBindings.Clear();
            numSoLuong.DataBindings.Add("Value", bindingSource, "SoLuong", false, DataSourceUpdateMode.Never);

            numDonGia.DataBindings.Clear();
            numDonGia.DataBindings.Add("Value", bindingSource, "DonGia", false, DataSourceUpdateMode.Never);

            picHinhAnh.DataBindings.Clear();
            Binding hinhAnh = new Binding("ImageLocation", bindingSource, "HinhAnh");
            hinhAnh.Format += (s, e) =>
            {
                if (e.Value != null)
                    e.Value = Path.Combine(imagesFolder, e.Value.ToString());
                else
                    e.Value = null;
            };

            picHinhAnh.DataBindings.Add(hinhAnh);

            dataGridView.DataSource = bindingSource;

        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "HinhAnh")
            {
                if (e.Value != null)
                {
                    string imagePath = Path.Combine(imagesFolder, e.Value.ToString());
                    if (File.Exists(imagePath))
                    {
                        Image image = Image.FromFile(imagePath);
                        image = new Bitmap(image, 24, 24);

                        e.Value = image;
                    }
                    else
                    {
                        e.Value = null;
                    }
                }
                else
                {
                    e.Value = null;
                }

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            cboLoaiSanPham.Text = "";
            cboHangSanXuat.Text = "";
            txtTenSanPham.Clear();
            txtMoTa.Clear();
            numSoLuong.Value = 0;
            numDonGia.Value = 0;
            picHinhAnh.Image = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            BatTatChucNang(true);
            xuLyThem = false;
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["SanPhamID"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(cboLoaiSanPham.Text))
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(cboHangSanXuat.Text))
            {
                MessageBox.Show("Vui lòng chọn hãng sản xuất.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(txtTenSanPham.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numSoLuong.Value <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numDonGia.Value <= 0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (xuLyThem)
                {
                    SanPham sp = new SanPham();
                    sp.LoaiSanPhamID = Convert.ToInt32(cboLoaiSanPham.SelectedValue);
                    sp.HangSanXuatID = Convert.ToInt32(cboHangSanXuat.SelectedValue);
                    sp.SoLuong = Convert.ToInt32(numSoLuong.Value);
                    sp.DonGia = Convert.ToInt32(numDonGia.Value);
                    sp.TenSanPham = txtTenSanPham.Text;
                    sp.MoTa = txtMoTa.Text;
                    context.SanPham.Add(sp);

                    context.SaveChanges();

                }
                else
                {
                    SanPham sp = context.SanPham.Find(id);
                    if (sp != null)
                    {
                        sp.LoaiSanPhamID = cboLoaiSanPham.SelectedIndex;
                        sp.HangSanXuatID = cboHangSanXuat.SelectedIndex;
                        sp.SoLuong = Convert.ToInt32(numSoLuong.Text);
                        sp.DonGia = Convert.ToInt32(numDonGia.Text);
                        sp.TenSanPham = txtTenSanPham.Text;
                        sp.MoTa = txtMoTa.Text;
                        context.SanPham.Update(sp);
                    }
                    context.SaveChanges();
                }
                frmSanPham_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmSanPham_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Cập nhật hình ảnh sản phẩm";
            openFileDialog.Filter = "Tập tin hình ảnh|*.jpg;*jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                string ext = Path.GetExtension(openFileDialog.FileName);
                string fileSavePath = Path.Combine(imagesFolder, fileName + ext);
                //File.Copy(openFileDialog.FileName, fileSavePath, true);

                if (Directory.Exists(fileSavePath))
                {
                    Directory.CreateDirectory(imagesFolder);
                }
                File.Copy(openFileDialog.FileName, fileSavePath, true);

                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["SanPhamID"].Value.ToString());
                SanPham sp = context.SanPham.Find(id);
                if (sp != null)
                {
                    sp.HinhAnh = fileName + ext;
                    context.SanPham.Update(sp);
                }

                context.SaveChanges();
                frmSanPham_Load(sender, e);
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu Sản phẩm từ Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet = workbook.Worksheet(1);
                        bool firstRow = true;
                        string readRange = "1:1";
                        foreach (IXLRow row in worksheet.RowsUsed())
                        {
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                    table.Columns.Add(cell.Value.ToString());
                                firstRow = false;
                            }
                            else
                            {
                                table.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Rows[table.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }
                        if (table.Rows.Count > 0)
                        {
                            foreach (DataRow r in table.Rows)
                            {
                                SanPham sp = new SanPham();
                                sp.TenSanPham = r["TenSanPham"].ToString();
                                sp.SoLuong = Convert.ToInt32(r["SoLuong"]);
                                sp.DonGia = Convert.ToInt32(r["DonGia"]);
                                sp.MoTa = r["MoTa"].ToString();

                                // Tìm ID dựa vào tên trong Excel
                                string tenLoai = r["TenLoai"].ToString();
                                var loai = context.LoaiSanPham.FirstOrDefault(x => x.TenLoai == tenLoai);
                                if (loai != null) sp.LoaiSanPhamID = loai.ID;

                                string tenHang = r["TenHangSanXuat"].ToString();
                                var hang = context.HangSanXuat.FirstOrDefault(x => x.TenHangSanXuat == tenHang);
                                if (hang != null) sp.HangSanXuatID = hang.ID;

                                context.SanPham.Add(sp);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " sản phẩm.", "Thành công");
                            frmSanPham_Load(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất danh sách sản phẩm ra Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xlsx";
            saveFileDialog.FileName = "SanPham_" + DateTime.Now.ToString("ddMMyyyy") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[] {
                new DataColumn("ID", typeof(int)),
                new DataColumn("TenSanPham", typeof(string)),
                new DataColumn("TenLoai", typeof(string)),
                new DataColumn("TenHangSanXuat", typeof(string)),
                new DataColumn("SoLuong", typeof(int)),
                new DataColumn("DonGia", typeof(int)),
                new DataColumn("MoTa", typeof(string))
            });

                    // Lấy dữ liệu bao gồm cả thông tin từ bảng liên kết
                    var dsSanPham = context.SanPham.Select(s => new {
                        s.ID,
                        s.TenSanPham,
                        TenLoai = s.LoaiSanPham.TenLoai,
                        TenHang = s.HangSanXuat.TenHangSanXuat,
                        s.SoLuong,
                        s.DonGia,
                        s.MoTa
                    }).ToList();

                    foreach (var sp in dsSanPham)
                    {
                        table.Rows.Add(sp.ID, sp.TenSanPham, sp.TenLoai, sp.TenHang, sp.SoLuong, sp.DonGia, sp.MoTa);
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "DanhSachSanPham");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
