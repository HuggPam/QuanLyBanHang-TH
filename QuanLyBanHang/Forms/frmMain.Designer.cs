namespace QuanLyBanHang.Forms
{
    partial class frmMain
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
            menuStrip = new MenuStrip();
            mnuHeThong = new ToolStripMenuItem();
            mnuDangNhap = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            mnuDoiMatKhau = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuThoat = new ToolStripMenuItem();
            mnuQuanLy = new ToolStripMenuItem();
            mnuLoaiSanPham = new ToolStripMenuItem();
            mnuHangSanXuat = new ToolStripMenuItem();
            mnuSanPham = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            mnuKhachHang = new ToolStripMenuItem();
            mnuNhanVien = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            mnuHoaDon = new ToolStripMenuItem();
            mnuBaoCaoThongKe = new ToolStripMenuItem();
            mnuThongKeSanPham = new ToolStripMenuItem();
            mnuThongKeDoanhThu = new ToolStripMenuItem();
            mnuTroGiup = new ToolStripMenuItem();
            mnuHuongDanSuDung = new ToolStripMenuItem();
            mnuThongTinPhanMem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblLienKet = new ToolStripStatusLabel();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuQuanLy, mnuBaoCaoThongKe, mnuTroGiup });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip";
            menuStrip.ItemClicked += menuStrip1_ItemClicked;
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuDangNhap, mnuDangXuat, mnuDoiMatKhau, toolStripSeparator1, mnuThoat });
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(69, 20);
            mnuHeThong.Text = "&Hệ thống";
            // 
            // mnuDangNhap
            // 
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.ShortcutKeyDisplayString = "";
            mnuDangNhap.Size = new Size(180, 22);
            mnuDangNhap.Text = "Đăng &nhập...";
            mnuDangNhap.Click += mnuDangNhap_Click;
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(180, 22);
            mnuDangXuat.Text = "Đăng &xuất...";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // 
            // mnuDoiMatKhau
            // 
            mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            mnuDoiMatKhau.Size = new Size(180, 22);
            mnuDoiMatKhau.Text = "Đổi &mật khẩu";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuThoat.Size = new Size(180, 22);
            mnuThoat.Text = "&Thoát";
            mnuThoat.Click += thoátToolStripMenuItem_Click;
            // 
            // mnuQuanLy
            // 
            mnuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { mnuLoaiSanPham, mnuHangSanXuat, mnuSanPham, toolStripSeparator3, mnuKhachHang, mnuNhanVien, toolStripSeparator2, mnuHoaDon });
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Size = new Size(60, 20);
            mnuQuanLy.Text = "&Quản lý";
            // 
            // mnuLoaiSanPham
            // 
            mnuLoaiSanPham.Name = "mnuLoaiSanPham";
            mnuLoaiSanPham.Size = new Size(173, 22);
            mnuLoaiSanPham.Text = "&Loại sản phẩm...";
            mnuLoaiSanPham.Click += mnuSanPham_Click;
            // 
            // mnuHangSanXuat
            // 
            mnuHangSanXuat.Name = "mnuHangSanXuat";
            mnuHangSanXuat.Size = new Size(173, 22);
            mnuHangSanXuat.Text = "&Hãng sản xuất...";
            mnuHangSanXuat.Click += mnuHangSanXuat_Click;
            // 
            // mnuSanPham
            // 
            mnuSanPham.Name = "mnuSanPham";
            mnuSanPham.Size = new Size(173, 22);
            mnuSanPham.Text = "&Sản phẩm...";
            mnuSanPham.Click += mnuSanPham_Click_1;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(170, 6);
            // 
            // mnuKhachHang
            // 
            mnuKhachHang.Name = "mnuKhachHang";
            mnuKhachHang.Size = new Size(173, 22);
            mnuKhachHang.Text = "&Khách hàng...";
            mnuKhachHang.Click += mnuKhachHang_Click;
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Size = new Size(173, 22);
            mnuNhanVien.Text = "&Nhân viên...";
            mnuNhanVien.Click += mnuNhanVien_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(170, 6);
            // 
            // mnuHoaDon
            // 
            mnuHoaDon.Name = "mnuHoaDon";
            mnuHoaDon.Size = new Size(173, 22);
            mnuHoaDon.Text = "Hó&a đơn bán hàng";
            mnuHoaDon.Click += mnuHoaDon_Click;
            // 
            // mnuBaoCaoThongKe
            // 
            mnuBaoCaoThongKe.DropDownItems.AddRange(new ToolStripItem[] { mnuThongKeSanPham, mnuThongKeDoanhThu });
            mnuBaoCaoThongKe.Name = "mnuBaoCaoThongKe";
            mnuBaoCaoThongKe.Size = new Size(121, 20);
            mnuBaoCaoThongKe.Text = "&Báo cáo - Thống kê";
            mnuBaoCaoThongKe.Click += báoCáoThốngKêToolStripMenuItem_Click;
            // 
            // mnuThongKeSanPham
            // 
            mnuThongKeSanPham.Name = "mnuThongKeSanPham";
            mnuThongKeSanPham.Size = new Size(193, 22);
            mnuThongKeSanPham.Text = "Thống kê &sản phẩm... ";
            // 
            // mnuThongKeDoanhThu
            // 
            mnuThongKeDoanhThu.Name = "mnuThongKeDoanhThu";
            mnuThongKeDoanhThu.Size = new Size(193, 22);
            mnuThongKeDoanhThu.Text = "Thống kê &doanh thu... ";
            // 
            // mnuTroGiup
            // 
            mnuTroGiup.DropDownItems.AddRange(new ToolStripItem[] { mnuHuongDanSuDung, mnuThongTinPhanMem });
            mnuTroGiup.Name = "mnuTroGiup";
            mnuTroGiup.Size = new Size(62, 20);
            mnuTroGiup.Text = "&Trợ giúp";
            // 
            // mnuHuongDanSuDung
            // 
            mnuHuongDanSuDung.Name = "mnuHuongDanSuDung";
            mnuHuongDanSuDung.ShortcutKeys = Keys.Shift | Keys.F1;
            mnuHuongDanSuDung.Size = new Size(231, 22);
            mnuHuongDanSuDung.Text = "&Hướng dẫn sử dụng";
            // 
            // mnuThongTinPhanMem
            // 
            mnuThongTinPhanMem.Name = "mnuThongTinPhanMem";
            mnuThongTinPhanMem.Size = new Size(231, 22);
            mnuThongTinPhanMem.Text = "&Thông tin phần mềm... ";
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { lblTrangThai, toolStripStatusLabel1, lblLienKet });
            statusStrip.Location = new Point(0, 428);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(800, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "statusStrip";
            // 
            // lblTrangThai
            // 
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(98, 17);
            lblTrangThai.Text = "Chưa đăng nhập.";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(624, 17);
            toolStripStatusLabel1.Spring = true;
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // lblLienKet
            // 
            lblLienKet.IsLink = true;
            lblLienKet.Name = "lblLienKet";
            lblLienKet.Size = new Size(63, 17);
            lblLienKet.Text = "© 2024 FIT";
            lblLienKet.TextAlign = ContentAlignment.MiddleRight;
            lblLienKet.Click += lblLienKet_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý bán hàng";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuBaoCaoThongKe;
        private ToolStripMenuItem mnuTroGiup;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblTrangThai;
        private ToolStripStatusLabel lblLienKet;
        private ToolStripMenuItem mnuDangNhap;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripMenuItem mnuDoiMatKhau;
        private ToolStripMenuItem mnuQuanLy;
        private ToolStripMenuItem mnuLoaiSanPham;
        private ToolStripMenuItem mnuHangSanXuat;
        private ToolStripMenuItem mnuSanPham;
        private ToolStripMenuItem mnuKhachHang;
        private ToolStripMenuItem mnuNhanVien;
        private ToolStripMenuItem mnuHoaDon;
        private ToolStripMenuItem mnuThongKeSanPham;
        private ToolStripMenuItem mnuThongKeDoanhThu;
        private ToolStripMenuItem mnuHuongDanSuDung;
        private ToolStripMenuItem mnuThongTinPhanMem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuThoat;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}