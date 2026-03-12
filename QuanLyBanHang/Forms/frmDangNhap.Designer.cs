namespace QuanLyBanHang.Forms
{
    partial class frmDangNhap
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            btnHuyBo = new Button();
            btnDangNhap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(257, 30);
            label1.Name = "label1";
            label1.Size = new Size(161, 32);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 86);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên dăng nhập:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(246, 141);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(246, 159);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '.';
            txtMatKhau.Size = new Size(185, 23);
            txtMatKhau.TabIndex = 3;
            txtMatKhau.TextChanged += textBox1_TextChanged;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(246, 104);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(185, 23);
            txtTenDangNhap.TabIndex = 4;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(356, 202);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(75, 23);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(246, 202);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(75, 23);
            btnDangNhap.TabIndex = 7;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 250);
            Controls.Add(btnDangNhap);
            Controls.Add(btnHuyBo);
            Controls.Add(txtTenDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += frmDangNhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button btnHuyBo;
        public TextBox txtMatKhau;
        public TextBox txtTenDangNhap;
        private Button btnDangNhap;
    }
}