namespace QuanLyBanHang.Forms
{
    partial class frmSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTenSanPham = new TextBox();
            label3 = new Label();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXuat = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            label2 = new Label();
            groupBox1 = new GroupBox();
            cboHangSanXuat = new ComboBox();
            cboLoaiSanPham = new ComboBox();
            numDonGia = new NumericUpDown();
            numSoLuong = new NumericUpDown();
            txtMoTa = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            btnNhap = new Button();
            btnTimKiem = new Button();
            btnSua = new Button();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            picHinhAnh = new PictureBox();
            btnDoiAnh = new Button();
            SanPhamID = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            TenHangSanXuat = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            SuspendLayout();
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(117, 81);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(334, 23);
            txtTenSanPham.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 84);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 6;
            label3.Text = "Tên sản phẩm (*):";
            // 
            // btnThoat
            // 
            btnThoat.ForeColor = Color.Black;
            btnThoat.Location = new Point(444, 171);
            btnThoat.Name = "btnThoat";
            btnThoat.RightToLeft = RightToLeft.No;
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.ForeColor = Color.Black;
            btnHuyBo.Location = new Point(359, 171);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.RightToLeft = RightToLeft.No;
            btnHuyBo.Size = new Size(75, 23);
            btnHuyBo.TabIndex = 5;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(274, 171);
            btnLuu.Name = "btnLuu";
            btnLuu.RightToLeft = RightToLeft.No;
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXuat
            // 
            btnXuat.ForeColor = Color.Black;
            btnXuat.Location = new Point(699, 171);
            btnXuat.Name = "btnXuat";
            btnXuat.RightToLeft = RightToLeft.No;
            btnXuat.Size = new Size(75, 23);
            btnXuat.TabIndex = 5;
            btnXuat.Text = "Xuất ...";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(189, 171);
            btnXoa.Name = "btnXoa";
            btnXoa.RightToLeft = RightToLeft.No;
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(19, 171);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 54);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 0;
            label2.Text = "Hãng sản xuất (*):";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboHangSanXuat);
            groupBox1.Controls.Add(cboLoaiSanPham);
            groupBox1.Controls.Add(numDonGia);
            groupBox1.Controls.Add(numSoLuong);
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(19, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(479, 157);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(117, 50);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(106, 23);
            cboHangSanXuat.TabIndex = 10;
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(117, 21);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(106, 23);
            cboLoaiSanPham.TabIndex = 10;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(339, 50);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(112, 23);
            numDonGia.TabIndex = 9;
            numDonGia.ThousandsSeparator = true;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(339, 21);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(112, 23);
            numSoLuong.TabIndex = 8;
            numSoLuong.ThousandsSeparator = true;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(117, 110);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(334, 23);
            txtMoTa.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 113);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 6;
            label6.Text = "Mô tả sản phẩm:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(245, 58);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 0;
            label5.Text = "Đơn giá (*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(245, 29);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 0;
            label4.Text = "Số lượng (*):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 25);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Phân loại (*):";
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(614, 171);
            btnNhap.Name = "btnNhap";
            btnNhap.RightToLeft = RightToLeft.No;
            btnNhap.Size = new Size(75, 23);
            btnNhap.TabIndex = 4;
            btnNhap.Text = "Nhập ...";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(529, 171);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(104, 171);
            btnSua.Name = "btnSua";
            btnSua.RightToLeft = RightToLeft.No;
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 214);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 307);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { SanPhamID, TenLoai, TenHangSanXuat, TenSanPham, SoLuong, DonGia, HinhAnh });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 19);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(794, 285);
            dataGridView.TabIndex = 0;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(529, 12);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(100, 153);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 10;
            picHinhAnh.TabStop = false;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Location = new Point(635, 12);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.RightToLeft = RightToLeft.No;
            btnDoiAnh.Size = new Size(75, 23);
            btnDoiAnh.TabIndex = 4;
            btnDoiAnh.Text = "Đổi ảnh...";
            btnDoiAnh.UseVisualStyleBackColor = true;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // SanPhamID
            // 
            SanPhamID.DataPropertyName = "ID";
            SanPhamID.HeaderText = "ID";
            SanPhamID.Name = "SanPhamID";
            // 
            // TenLoai
            // 
            TenLoai.DataPropertyName = "TenLoai";
            TenLoai.HeaderText = "Phân loại";
            TenLoai.Name = "TenLoai";
            // 
            // TenHangSanXuat
            // 
            TenHangSanXuat.DataPropertyName = "TenHangSanXuat";
            TenHangSanXuat.HeaderText = "Hãng sản xuất";
            TenHangSanXuat.Name = "TenHangSanXuat";
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên sản phẩm";
            TenSanPham.Name = "TenSanPham";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số lượng";
            SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn giá";
            DonGia.Name = "DonGia";
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "HinhAnh";
            HinhAnh.HeaderText = "Hình ảnh";
            HinhAnh.Name = "HinhAnh";
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 521);
            Controls.Add(picHinhAnh);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(btnThem);
            Controls.Add(btnXuat);
            Controls.Add(btnThoat);
            Controls.Add(btnDoiAnh);
            Controls.Add(btnNhap);
            Controls.Add(btnSua);
            Controls.Add(btnTimKiem);
            Controls.Add(btnHuyBo);
            Controls.Add(btnXoa);
            Controls.Add(btnLuu);
            Name = "frmSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sản phẩm";
            Load += frmSanPham_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtTenSanPham;
        private Label label3;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXuat;
        private Button btnXoa;
        private Button btnThem;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private TextBox txtDienThoai;
        private TextBox txtHoVaTen;
        private Label label5;
        private Label label4;
        private Label label1;
        private Button btnNhap;
        private Button btnTimKiem;
        private Button btnSua;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private PictureBox picHinhAnh;
        private Button btnDoiAnh;
        private TextBox txtMoTa;
        private Label label6;
        private ComboBox cboHangSanXuat;
        private ComboBox cboLoaiSanPham;
        private NumericUpDown numDonGia;
        private NumericUpDown numSoLuong;
        private DataGridViewTextBoxColumn SanPhamID;
        private DataGridViewTextBoxColumn TenLoai;
        private DataGridViewTextBoxColumn TenHangSanXuat;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn HinhAnh;
    }
}