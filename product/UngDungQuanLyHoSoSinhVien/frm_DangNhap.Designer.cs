namespace UngDungQuanLyHoSoSinhVien
{
    partial class frm_DangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb_TieuDe = new Label();
            lb_TenTaiKhoan = new Label();
            lb_MatKhau = new Label();
            tb_TenTaiKhoan = new TextBox();
            tb_MatKhau = new TextBox();
            btn_DangNhap = new Button();
            btn_NhapLai = new Button();
            SuspendLayout();
            // 
            // lb_TieuDe
            // 
            lb_TieuDe.AutoSize = true;
            lb_TieuDe.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_TieuDe.ForeColor = Color.Red;
            lb_TieuDe.Location = new Point(70, 9);
            lb_TieuDe.Name = "lb_TieuDe";
            lb_TieuDe.Size = new Size(230, 54);
            lb_TieuDe.TabIndex = 0;
            lb_TieuDe.Text = "Đăng nhập";
            lb_TieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_TenTaiKhoan
            // 
            lb_TenTaiKhoan.AutoSize = true;
            lb_TenTaiKhoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_TenTaiKhoan.Location = new Point(12, 123);
            lb_TenTaiKhoan.Name = "lb_TenTaiKhoan";
            lb_TenTaiKhoan.Size = new Size(131, 28);
            lb_TenTaiKhoan.TabIndex = 1;
            lb_TenTaiKhoan.Text = "Tên tài khoản:";
            // 
            // lb_MatKhau
            // 
            lb_MatKhau.AutoSize = true;
            lb_MatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_MatKhau.Location = new Point(12, 170);
            lb_MatKhau.Name = "lb_MatKhau";
            lb_MatKhau.Size = new Size(98, 28);
            lb_MatKhau.TabIndex = 2;
            lb_MatKhau.Text = "Mật khẩu:";
            // 
            // tb_TenTaiKhoan
            // 
            tb_TenTaiKhoan.Location = new Point(149, 127);
            tb_TenTaiKhoan.Name = "tb_TenTaiKhoan";
            tb_TenTaiKhoan.Size = new Size(213, 27);
            tb_TenTaiKhoan.TabIndex = 3;
            // 
            // tb_MatKhau
            // 
            tb_MatKhau.Location = new Point(149, 174);
            tb_MatKhau.Name = "tb_MatKhau";
            tb_MatKhau.Size = new Size(213, 27);
            tb_MatKhau.TabIndex = 4;
            // 
            // btn_DangNhap
            // 
            btn_DangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_DangNhap.Location = new Point(12, 241);
            btn_DangNhap.Name = "btn_DangNhap";
            btn_DangNhap.Size = new Size(152, 50);
            btn_DangNhap.TabIndex = 5;
            btn_DangNhap.Text = "Đăng nhập";
            btn_DangNhap.UseVisualStyleBackColor = true;
            // 
            // btn_NhapLai
            // 
            btn_NhapLai.BackColor = SystemColors.ControlLight;
            btn_NhapLai.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_NhapLai.ForeColor = SystemColors.ControlText;
            btn_NhapLai.Location = new Point(210, 241);
            btn_NhapLai.Name = "btn_NhapLai";
            btn_NhapLai.Size = new Size(152, 50);
            btn_NhapLai.TabIndex = 6;
            btn_NhapLai.Text = "Nhập lại";
            btn_NhapLai.UseVisualStyleBackColor = false;
            // 
            // frm_DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(374, 314);
            Controls.Add(btn_NhapLai);
            Controls.Add(btn_DangNhap);
            Controls.Add(tb_MatKhau);
            Controls.Add(tb_TenTaiKhoan);
            Controls.Add(lb_MatKhau);
            Controls.Add(lb_TenTaiKhoan);
            Controls.Add(lb_TieuDe);
            Name = "frm_DangNhap";
            Text = "Đăng nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_TieuDe;
        private Label lb_TenTaiKhoan;
        private Label lb_MatKhau;
        private TextBox tb_TenTaiKhoan;
        private TextBox tb_MatKhau;
        private Button btn_DangNhap;
        private Button btn_NhapLai;
    }
}