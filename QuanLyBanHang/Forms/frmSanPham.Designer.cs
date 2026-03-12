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
            groupBox1 = new GroupBox();
            btnXuat = new Button();
            btnDoiAnh = new Button();
            btnNhap = new Button();
            btnThoat = new Button();
            btnTimKiem = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            picHinhAnh = new PictureBox();
            numDonGia = new NumericUpDown();
            numSoLuong = new NumericUpDown();
            txtMoTa = new TextBox();
            txtTenSanPham = new TextBox();
            cboHangSanXuat = new ComboBox();
            cboLoaiSanPham = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            TenHangSanXuat = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnDoiAnh);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(numDonGia);
            groupBox1.Controls.Add(numSoLuong);
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(cboHangSanXuat);
            groupBox1.Controls.Add(cboLoaiSanPham);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(942, 290);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(832, 185);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(112, 34);
            btnXuat.TabIndex = 17;
            btnXuat.Text = "Xuất ....";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Location = new Point(832, 39);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(112, 34);
            btnDoiAnh.TabIndex = 19;
            btnDoiAnh.Text = "Đổi ảnh ...";
            btnDoiAnh.UseVisualStyleBackColor = true;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(832, 137);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(112, 34);
            btnNhap.TabIndex = 16;
            btnNhap.Text = "Nhập.....";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(722, 242);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 18;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(832, 89);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(112, 34);
            btnTimKiem.TabIndex = 15;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(594, 242);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(112, 34);
            btnHuyBo.TabIndex = 17;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = SystemColors.Highlight;
            btnLuu.Location = new Point(466, 242);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(112, 34);
            btnLuu.TabIndex = 16;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(338, 242);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(210, 242);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 14;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(82, 242);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 13;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(676, 38);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(150, 183);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 12;
            picHinhAnh.TabStop = false;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(466, 89);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(180, 31);
            numDonGia.TabIndex = 11;
            numDonGia.ThousandsSeparator = true;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(466, 38);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(180, 31);
            numSoLuong.TabIndex = 10;
            numSoLuong.ThousandsSeparator = true;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(170, 190);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(476, 31);
            txtMoTa.TabIndex = 9;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(170, 139);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(476, 31);
            txtTenSanPham.TabIndex = 8;
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(170, 87);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(182, 33);
            cboHangSanXuat.TabIndex = 7;
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(170, 30);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(182, 33);
            cboLoaiSanPham.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(371, 44);
            label6.Name = "label6";
            label6.Size = new Size(107, 25);
            label6.TabIndex = 5;
            label6.Text = "Số lượng(*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(371, 90);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 4;
            label5.Text = "Đơn giá(*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 190);
            label4.Name = "label4";
            label4.Size = new Size(146, 25);
            label4.TabIndex = 3;
            label4.Text = "Mô tả sản phẩm:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 145);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 2;
            label3.Text = "Tên sản phẩm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 90);
            label2.Name = "label2";
            label2.Size = new Size(147, 25);
            label2.TabIndex = 1;
            label2.Text = "Hãng sản xuất(*):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 44);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 0;
            label1.Text = "Phân loại (*):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(12, 294);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(944, 331);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sản phẩm";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenLoai, TenHangSanXuat, TenSanPham, SoLuong, DonGia, HinhAnh });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 27);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(938, 301);
            dataGridView.TabIndex = 0;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            // 
            // TenLoai
            // 
            TenLoai.DataPropertyName = "TenLoai";
            TenLoai.HeaderText = "Phân loại";
            TenLoai.MinimumWidth = 8;
            TenLoai.Name = "TenLoai";
            // 
            // TenHangSanXuat
            // 
            TenHangSanXuat.DataPropertyName = "TenHangSanXuat";
            TenHangSanXuat.HeaderText = "Hãng sản xuất";
            TenHangSanXuat.MinimumWidth = 8;
            TenHangSanXuat.Name = "TenHangSanXuat";
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên sản phẩm";
            TenSanPham.MinimumWidth = 8;
            TenSanPham.Name = "TenSanPham";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 8;
            SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 8;
            DonGia.Name = "DonGia";
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "HinhAnh";
            HinhAnh.HeaderText = "Hình ảnh";
            HinhAnh.MinimumWidth = 8;
            HinhAnh.Name = "HinhAnh";
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 622);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sản phẩm";
            Load += frmSanPham_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numDonGia;
        private NumericUpDown numSoLuong;
        private TextBox txtMoTa;
        private TextBox txtTenSanPham;
        private ComboBox cboHangSanXuat;
        private ComboBox cboLoaiSanPham;
        private PictureBox picHinhAnh;
        private Button btnDoiAnh;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenLoai;
        private DataGridViewTextBoxColumn TenHangSanXuat;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewImageColumn HinhAnh;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
    }
}