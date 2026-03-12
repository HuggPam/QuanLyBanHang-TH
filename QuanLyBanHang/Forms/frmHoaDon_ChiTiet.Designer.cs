namespace QuanLyBanHang.Forms
{
    partial class frmHoaDon_ChiTiet
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            cboKhachHang = new ComboBox();
            cboNhanVien = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtGhiChuHoaDon = new TextBox();
            groupBox2 = new GroupBox();
            numSoLuongBan = new NumericUpDown();
            numDonGiaBan = new NumericUpDown();
            cboSanPham = new ComboBox();
            btnXoa = new Button();
            btnXacNhanBan = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            dataGridView = new DataGridView();
            SanPhamID = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            DonGiaBan = new DataGridViewTextBoxColumn();
            SoLuongBan = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            btnLuuHoaDon = new Button();
            btnInHoaDon = new Button();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboKhachHang);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtGhiChuHoaDon);
            groupBox1.Location = new Point(2, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(935, 161);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(599, 41);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(305, 33);
            cboKhachHang.TabIndex = 5;
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(196, 41);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(252, 33);
            cboNhanVien.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(467, 46);
            label3.Name = "label3";
            label3.Size = new Size(126, 25);
            label3.TabIndex = 3;
            label3.Text = "Khách hàng(*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 106);
            label2.Name = "label2";
            label2.Size = new Size(147, 25);
            label2.TabIndex = 2;
            label2.Text = "Ghi chú hóa đơn:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 46);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 1;
            label1.Text = "Nhân viên lập(*):";
            // 
            // txtGhiChuHoaDon
            // 
            txtGhiChuHoaDon.Location = new Point(196, 103);
            txtGhiChuHoaDon.Name = "txtGhiChuHoaDon";
            txtGhiChuHoaDon.Size = new Size(708, 31);
            txtGhiChuHoaDon.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numSoLuongBan);
            groupBox2.Controls.Add(numDonGiaBan);
            groupBox2.Controls.Add(cboSanPham);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnXacNhanBan);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(2, 162);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(935, 336);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chi tiết hóa đơn";
            // 
            // numSoLuongBan
            // 
            numSoLuongBan.Location = new Point(429, 57);
            numSoLuongBan.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuongBan.Name = "numSoLuongBan";
            numSoLuongBan.Size = new Size(180, 31);
            numSoLuongBan.TabIndex = 8;
            numSoLuongBan.ThousandsSeparator = true;
            // 
            // numDonGiaBan
            // 
            numDonGiaBan.Location = new Point(212, 57);
            numDonGiaBan.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGiaBan.Name = "numDonGiaBan";
            numDonGiaBan.Size = new Size(180, 31);
            numDonGiaBan.TabIndex = 7;
            numDonGiaBan.ThousandsSeparator = true;
            // 
            // cboSanPham
            // 
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(24, 55);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(166, 33);
            cboSanPham.TabIndex = 6;
            cboSanPham.SelectionChangeCommitted += cboSanPham_SelectionChangeCommitted;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(792, 53);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXacNhanBan
            // 
            btnXacNhanBan.Location = new Point(634, 53);
            btnXacNhanBan.Name = "btnXacNhanBan";
            btnXacNhanBan.Size = new Size(150, 34);
            btnXacNhanBan.TabIndex = 4;
            btnXacNhanBan.Text = "Xác nhận bán";
            btnXacNhanBan.UseVisualStyleBackColor = true;
            btnXacNhanBan.Click += btnXacNhanBan_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(429, 29);
            label6.Name = "label6";
            label6.Size = new Size(142, 25);
            label6.TabIndex = 3;
            label6.Text = "Số lượng bán(*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(212, 27);
            label5.Name = "label5";
            label5.Size = new Size(132, 25);
            label5.TabIndex = 2;
            label5.Text = "Đơn giá bán(*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 27);
            label4.Name = "label4";
            label4.Size = new Size(114, 25);
            label4.TabIndex = 1;
            label4.Text = "Sản phẩm(*):";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { SanPhamID, TenSanPham, DonGiaBan, SoLuongBan, ThanhTien });
            dataGridView.Dock = DockStyle.Bottom;
            dataGridView.Location = new Point(3, 108);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(929, 225);
            dataGridView.TabIndex = 0;
            // 
            // SanPhamID
            // 
            SanPhamID.DataPropertyName = "SanPhamID";
            SanPhamID.HeaderText = "ID";
            SanPhamID.MinimumWidth = 8;
            SanPhamID.Name = "SanPhamID";
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên sản phẩm";
            TenSanPham.MinimumWidth = 8;
            TenSanPham.Name = "TenSanPham";
            // 
            // DonGiaBan
            // 
            DonGiaBan.DataPropertyName = "DonGiaBan";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            DonGiaBan.DefaultCellStyle = dataGridViewCellStyle4;
            DonGiaBan.HeaderText = "Đơn giá bán";
            DonGiaBan.MinimumWidth = 8;
            DonGiaBan.Name = "DonGiaBan";
            // 
            // SoLuongBan
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            SoLuongBan.DefaultCellStyle = dataGridViewCellStyle5;
            SoLuongBan.HeaderText = "Số lượng bán";
            SoLuongBan.MinimumWidth = 8;
            SoLuongBan.Name = "SoLuongBan";
            // 
            // ThanhTien
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = Color.Blue;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.Format = "N0";
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle6;
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 8;
            ThanhTien.Name = "ThanhTien";
            // 
            // btnLuuHoaDon
            // 
            btnLuuHoaDon.ForeColor = Color.Blue;
            btnLuuHoaDon.Location = new Point(132, 520);
            btnLuuHoaDon.Name = "btnLuuHoaDon";
            btnLuuHoaDon.Size = new Size(163, 34);
            btnLuuHoaDon.TabIndex = 2;
            btnLuuHoaDon.Text = "Lưu hóa đơn";
            btnLuuHoaDon.UseVisualStyleBackColor = true;
            btnLuuHoaDon.Click += btnLuuHoaDon_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Location = new Point(413, 520);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(112, 34);
            btnInHoaDon.TabIndex = 3;
            btnInHoaDon.Text = "in hóa đơn";
            btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.ForeColor = Color.Red;
            btnThoat.Location = new Point(661, 520);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmHoaDon_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 575);
            Controls.Add(btnThoat);
            Controls.Add(btnInHoaDon);
            Controls.Add(btnLuuHoaDon);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmHoaDon_ChiTiet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn chi tiết";
            Load += frmHoaDon_ChiTiet_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private Button btnLuuHoaDon;
        private Button btnInHoaDon;
        private Button btnThoat;
        private ComboBox cboKhachHang;
        private ComboBox cboNhanVien;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtGhiChuHoaDon;
        private NumericUpDown numSoLuongBan;
        private NumericUpDown numDonGiaBan;
        private ComboBox cboSanPham;
        private Button btnXoa;
        private Button btnXacNhanBan;
        private Label label6;
        private Label label5;
        private Label label4;
        private DataGridViewTextBoxColumn SanPhamID;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn DonGiaBan;
        private DataGridViewTextBoxColumn SoLuongBan;
        private DataGridViewTextBoxColumn ThanhTien;
    }
}