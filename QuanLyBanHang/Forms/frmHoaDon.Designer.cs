namespace QuanLyBanHang.Forms
{
    partial class frmHoaDon
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoVaTenNhanVien = new DataGridViewTextBoxColumn();
            HoVaTenKhachHang = new DataGridViewTextBoxColumn();
            NgayLap = new DataGridViewTextBoxColumn();
            TongTienHoaDon = new DataGridViewTextBoxColumn();
            XemChiTiet = new DataGridViewLinkColumn();
            btnLapHoaDon = new Button();
            btnInHoaDon = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            btnTimKiem = new Button();
            btnXuat = new Button();
            btnTailai = new Button();
            btnNhap = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView);
            groupBox1.Location = new Point(0, 1);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(736, 215);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách hóa đơn";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTenNhanVien, HoVaTenKhachHang, NgayLap, TongTienHoaDon, XemChiTiet });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(2, 18);
            dataGridView.Margin = new Padding(2, 2, 2, 2);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(732, 195);
            dataGridView.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            // 
            // HoVaTenNhanVien
            // 
            HoVaTenNhanVien.DataPropertyName = "HoVaTenNhanVien";
            HoVaTenNhanVien.HeaderText = "Nhân viên";
            HoVaTenNhanVien.MinimumWidth = 8;
            HoVaTenNhanVien.Name = "HoVaTenNhanVien";
            // 
            // HoVaTenKhachHang
            // 
            HoVaTenKhachHang.DataPropertyName = "HoVaTenKhachHang";
            HoVaTenKhachHang.HeaderText = "Khách hàng";
            HoVaTenKhachHang.MinimumWidth = 8;
            HoVaTenKhachHang.Name = "HoVaTenKhachHang";
            // 
            // NgayLap
            // 
            NgayLap.DataPropertyName = "NgayLap";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            NgayLap.DefaultCellStyle = dataGridViewCellStyle1;
            NgayLap.HeaderText = "Ngày lập";
            NgayLap.MinimumWidth = 8;
            NgayLap.Name = "NgayLap";
            // 
            // TongTienHoaDon
            // 
            TongTienHoaDon.DataPropertyName = "TongTienHoaDon";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = Color.Blue;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.Format = "N0";
            TongTienHoaDon.DefaultCellStyle = dataGridViewCellStyle2;
            TongTienHoaDon.HeaderText = "Tổng tiền";
            TongTienHoaDon.MinimumWidth = 8;
            TongTienHoaDon.Name = "TongTienHoaDon";
            // 
            // XemChiTiet
            // 
            XemChiTiet.DataPropertyName = "XemChiTiet";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            XemChiTiet.DefaultCellStyle = dataGridViewCellStyle3;
            XemChiTiet.HeaderText = "Chi tiết";
            XemChiTiet.MinimumWidth = 8;
            XemChiTiet.Name = "XemChiTiet";
            // 
            // btnLapHoaDon
            // 
            btnLapHoaDon.ForeColor = Color.Red;
            btnLapHoaDon.Location = new Point(8, 231);
            btnLapHoaDon.Margin = new Padding(2, 2, 2, 2);
            btnLapHoaDon.Name = "btnLapHoaDon";
            btnLapHoaDon.Size = new Size(84, 25);
            btnLapHoaDon.TabIndex = 1;
            btnLapHoaDon.Text = "Lập HĐ";
            btnLapHoaDon.UseVisualStyleBackColor = true;
            btnLapHoaDon.Click += btnLapHoaDon_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Location = new Point(104, 231);
            btnInHoaDon.Margin = new Padding(2, 2, 2, 2);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(84, 25);
            btnInHoaDon.TabIndex = 2;
            btnInHoaDon.Text = "In HĐ";
            btnInHoaDon.UseVisualStyleBackColor = true;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(199, 231);
            btnSua.Margin = new Padding(2, 2, 2, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(84, 25);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.FromArgb(0, 0, 192);
            btnXoa.Location = new Point(294, 231);
            btnXoa.Margin = new Padding(2, 2, 2, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(84, 25);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(389, 231);
            btnThoat.Margin = new Padding(2, 2, 2, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(84, 25);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(484, 231);
            btnTimKiem.Margin = new Padding(2, 2, 2, 2);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(84, 25);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(580, 231);
            btnXuat.Margin = new Padding(2, 2, 2, 2);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(84, 25);
            btnXuat.TabIndex = 7;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnTailai
            // 
            btnTailai.Location = new Point(680, 233);
            btnTailai.Margin = new Padding(2, 2, 2, 2);
            btnTailai.Name = "btnTailai";
            btnTailai.Size = new Size(48, 20);
            btnTailai.TabIndex = 8;
            btnTailai.Text = "tải lại";
            btnTailai.UseVisualStyleBackColor = true;
            btnTailai.Click += btnTailai_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(554, 271);
            btnNhap.Margin = new Padding(2, 2, 2, 2);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(78, 24);
            btnNhap.TabIndex = 9;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 306);
            Controls.Add(btnNhap);
            Controls.Add(btnTailai);
            Controls.Add(btnXuat);
            Controls.Add(btnTimKiem);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnInHoaDon);
            Controls.Add(btnLapHoaDon);
            Controls.Add(groupBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn";
            Load += frmHoaDon_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView;
        private Button btnLapHoaDon;
        private Button btnInHoaDon;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnTimKiem;
        private Button btnXuat;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTenNhanVien;
        private DataGridViewTextBoxColumn HoVaTenKhachHang;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn TongTienHoaDon;
        private DataGridViewLinkColumn XemChiTiet;
        private Button btnTailai;
        private Button btnNhap;
    }
}