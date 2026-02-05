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

namespace QuanLyBanHang.Forms
{
    public partial class frmKhachHang : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        bool xuLyThem = false;
        int id;
        public frmKhachHang()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtHoVaTen.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            List<KhachHang> kh = new List<KhachHang>();
            kh = context.KhachHang.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = kh;

            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoTen", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);

            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            txtHoVaTen.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["KhachHangID"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoVaTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên khách hàng?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (xuLyThem)
                {
                    KhachHang kh = new KhachHang();
                    kh.HoTen = txtHoVaTen.Text;
                    kh.DiaChi = txtDiaChi.Text;
                    kh.DienThoai = txtDienThoai.Text;

                    context.KhachHang.Add(kh);
                    context.SaveChanges();
                }
                else
                {
                    KhachHang kh = context.KhachHang.Find(id);
                    if (kh != null)
                    {
                        kh.HoTen = txtHoVaTen.Text;
                        kh.DiaChi = txtDiaChi.Text;
                        kh.DienThoai = txtDienThoai.Text;
                        context.KhachHang.Update(kh);
                        context.SaveChanges();
                    }
                }
                frmKhachHang_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["KhachHangID"].Value.ToString());
            KhachHang kh = context.KhachHang.Find(id);
            if (kh != null)
            {
                context.KhachHang.Remove(kh);
            }
            context.SaveChanges();
            frmKhachHang_Load(sender, e);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traLoi = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traLoi == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
