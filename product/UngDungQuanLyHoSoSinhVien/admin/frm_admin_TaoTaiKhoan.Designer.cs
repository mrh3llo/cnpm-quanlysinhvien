namespace UngDungQuanLyHoSoSinhVien.admin
{
    partial class frm_admin_TaoTaiKhoan
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
            lb_TieuDe = new Label();
            cmb_TonGiao = new ComboBox();
            cmb_DanToc = new ComboBox();
            tb_Email = new TextBox();
            lb_TonGiao = new Label();
            cmb_GioiTinh = new ComboBox();
            lb_GioiTinh = new Label();
            lb_DanToc = new Label();
            lb_Email = new Label();
            tb_SDT = new TextBox();
            lb_SDT = new Label();
            tb_HoTen = new TextBox();
            lb_HoTen = new Label();
            lb_NgaySinh = new Label();
            date_NgaySinh = new DateTimePicker();
            lb_SoCCCD = new Label();
            tb_SoCCCD = new TextBox();
            lb_DiaChi = new Label();
            tb_DiaChi = new TextBox();
            lb_NoiSinh = new Label();
            cmb_NoiSinh = new ComboBox();
            grb_QueQuan = new GroupBox();
            lb_QQ_TinhThanh = new Label();
            cmb_QQ_XaPhuong = new ComboBox();
            cmb_QQ_TinhThanh = new ComboBox();
            lb_QQ_XaPhuong = new Label();
            lb_KhoaTruong = new Label();
            lb_Lop = new Label();
            lb_TrangThai = new Label();
            cmb_Nganh = new ComboBox();
            cmb_KhoaTruong = new ComboBox();
            cmb_Lop = new ComboBox();
            cmb_TrangThai = new ComboBox();
            btn_XacNhan = new Button();
            btn_NhapLai = new Button();
            btn_Thoat = new Button();
            tb_NienKhoa = new TextBox();
            lb_NienKhoa = new Label();
            lb_Nganh = new Label();
            grb_QueQuan.SuspendLayout();
            SuspendLayout();
            // 
            // lb_TieuDe
            // 
            lb_TieuDe.AutoSize = true;
            lb_TieuDe.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_TieuDe.ForeColor = SystemColors.ControlText;
            lb_TieuDe.Location = new Point(246, 9);
            lb_TieuDe.Name = "lb_TieuDe";
            lb_TieuDe.Size = new Size(279, 54);
            lb_TieuDe.TabIndex = 0;
            lb_TieuDe.Text = "Tạo tài khoản";
            // 
            // cmb_TonGiao
            // 
            cmb_TonGiao.FormattingEnabled = true;
            cmb_TonGiao.Items.AddRange(new object[] { "Nam", "Nữ" });
            cmb_TonGiao.Location = new Point(110, 372);
            cmb_TonGiao.Name = "cmb_TonGiao";
            cmb_TonGiao.Size = new Size(185, 28);
            cmb_TonGiao.TabIndex = 11;
            // 
            // cmb_DanToc
            // 
            cmb_DanToc.FormattingEnabled = true;
            cmb_DanToc.Items.AddRange(new object[] { "Nam", "Nữ" });
            cmb_DanToc.Location = new Point(110, 338);
            cmb_DanToc.Name = "cmb_DanToc";
            cmb_DanToc.Size = new Size(185, 28);
            cmb_DanToc.TabIndex = 10;
            // 
            // tb_Email
            // 
            tb_Email.Location = new Point(89, 171);
            tb_Email.Name = "tb_Email";
            tb_Email.Size = new Size(304, 27);
            tb_Email.TabIndex = 9;
            // 
            // lb_TonGiao
            // 
            lb_TonGiao.AutoSize = true;
            lb_TonGiao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_TonGiao.Location = new Point(13, 372);
            lb_TonGiao.Name = "lb_TonGiao";
            lb_TonGiao.Size = new Size(91, 28);
            lb_TonGiao.TabIndex = 8;
            lb_TonGiao.Text = "Tôn giáo:";
            // 
            // cmb_GioiTinh
            // 
            cmb_GioiTinh.FormattingEnabled = true;
            cmb_GioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cmb_GioiTinh.Location = new Point(109, 104);
            cmb_GioiTinh.Name = "cmb_GioiTinh";
            cmb_GioiTinh.Size = new Size(185, 28);
            cmb_GioiTinh.TabIndex = 4;
            // 
            // lb_GioiTinh
            // 
            lb_GioiTinh.AutoSize = true;
            lb_GioiTinh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_GioiTinh.Location = new Point(12, 104);
            lb_GioiTinh.Name = "lb_GioiTinh";
            lb_GioiTinh.Size = new Size(91, 28);
            lb_GioiTinh.TabIndex = 1;
            lb_GioiTinh.Text = "Giới tính:";
            // 
            // lb_DanToc
            // 
            lb_DanToc.AutoSize = true;
            lb_DanToc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_DanToc.Location = new Point(13, 337);
            lb_DanToc.Name = "lb_DanToc";
            lb_DanToc.Size = new Size(84, 28);
            lb_DanToc.TabIndex = 7;
            lb_DanToc.Text = "Dân tộc:";
            // 
            // lb_Email
            // 
            lb_Email.AutoSize = true;
            lb_Email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Email.Location = new Point(12, 171);
            lb_Email.Name = "lb_Email";
            lb_Email.Size = new Size(63, 28);
            lb_Email.TabIndex = 6;
            lb_Email.Text = "Email:";
            // 
            // tb_SDT
            // 
            tb_SDT.Location = new Point(146, 138);
            tb_SDT.Name = "tb_SDT";
            tb_SDT.Size = new Size(247, 27);
            tb_SDT.TabIndex = 5;
            // 
            // lb_SDT
            // 
            lb_SDT.AutoSize = true;
            lb_SDT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_SDT.Location = new Point(12, 138);
            lb_SDT.Name = "lb_SDT";
            lb_SDT.Size = new Size(132, 28);
            lb_SDT.TabIndex = 2;
            lb_SDT.Text = "Số điện thoại:";
            // 
            // tb_HoTen
            // 
            tb_HoTen.Location = new Point(89, 71);
            tb_HoTen.Name = "tb_HoTen";
            tb_HoTen.Size = new Size(304, 27);
            tb_HoTen.TabIndex = 3;
            // 
            // lb_HoTen
            // 
            lb_HoTen.AutoSize = true;
            lb_HoTen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_HoTen.Location = new Point(12, 71);
            lb_HoTen.Name = "lb_HoTen";
            lb_HoTen.Size = new Size(75, 28);
            lb_HoTen.TabIndex = 0;
            lb_HoTen.Text = "Họ tên:";
            // 
            // lb_NgaySinh
            // 
            lb_NgaySinh.AutoSize = true;
            lb_NgaySinh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_NgaySinh.Location = new Point(12, 204);
            lb_NgaySinh.Name = "lb_NgaySinh";
            lb_NgaySinh.Size = new Size(103, 28);
            lb_NgaySinh.TabIndex = 12;
            lb_NgaySinh.Text = "Ngày sinh:";
            // 
            // date_NgaySinh
            // 
            date_NgaySinh.Location = new Point(117, 204);
            date_NgaySinh.Name = "date_NgaySinh";
            date_NgaySinh.Size = new Size(276, 27);
            date_NgaySinh.TabIndex = 14;
            // 
            // lb_SoCCCD
            // 
            lb_SoCCCD.AutoSize = true;
            lb_SoCCCD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_SoCCCD.Location = new Point(12, 237);
            lb_SoCCCD.Name = "lb_SoCCCD";
            lb_SoCCCD.Size = new Size(92, 28);
            lb_SoCCCD.TabIndex = 15;
            lb_SoCCCD.Text = "Số CCCD:";
            // 
            // tb_SoCCCD
            // 
            tb_SoCCCD.Location = new Point(110, 237);
            tb_SoCCCD.Name = "tb_SoCCCD";
            tb_SoCCCD.Size = new Size(283, 27);
            tb_SoCCCD.TabIndex = 16;
            // 
            // lb_DiaChi
            // 
            lb_DiaChi.AutoSize = true;
            lb_DiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_DiaChi.Location = new Point(12, 270);
            lb_DiaChi.Name = "lb_DiaChi";
            lb_DiaChi.Size = new Size(75, 28);
            lb_DiaChi.TabIndex = 17;
            lb_DiaChi.Text = "Địa chỉ:";
            // 
            // tb_DiaChi
            // 
            tb_DiaChi.Location = new Point(89, 270);
            tb_DiaChi.Name = "tb_DiaChi";
            tb_DiaChi.Size = new Size(304, 27);
            tb_DiaChi.TabIndex = 18;
            // 
            // lb_NoiSinh
            // 
            lb_NoiSinh.AutoSize = true;
            lb_NoiSinh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_NoiSinh.Location = new Point(12, 303);
            lb_NoiSinh.Name = "lb_NoiSinh";
            lb_NoiSinh.Size = new Size(88, 28);
            lb_NoiSinh.TabIndex = 19;
            lb_NoiSinh.Text = "Nơi sinh:";
            // 
            // cmb_NoiSinh
            // 
            cmb_NoiSinh.FormattingEnabled = true;
            cmb_NoiSinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cmb_NoiSinh.Location = new Point(109, 303);
            cmb_NoiSinh.Name = "cmb_NoiSinh";
            cmb_NoiSinh.Size = new Size(185, 28);
            cmb_NoiSinh.TabIndex = 20;
            // 
            // grb_QueQuan
            // 
            grb_QueQuan.Controls.Add(lb_QQ_TinhThanh);
            grb_QueQuan.Controls.Add(cmb_QQ_XaPhuong);
            grb_QueQuan.Controls.Add(cmb_QQ_TinhThanh);
            grb_QueQuan.Controls.Add(lb_QQ_XaPhuong);
            grb_QueQuan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grb_QueQuan.Location = new Point(466, 71);
            grb_QueQuan.Name = "grb_QueQuan";
            grb_QueQuan.Size = new Size(282, 125);
            grb_QueQuan.TabIndex = 22;
            grb_QueQuan.TabStop = false;
            grb_QueQuan.Text = "Quê quán:";
            // 
            // lb_QQ_TinhThanh
            // 
            lb_QQ_TinhThanh.AutoSize = true;
            lb_QQ_TinhThanh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_QQ_TinhThanh.Location = new Point(6, 37);
            lb_QQ_TinhThanh.Name = "lb_QQ_TinhThanh";
            lb_QQ_TinhThanh.Size = new Size(108, 28);
            lb_QQ_TinhThanh.TabIndex = 25;
            lb_QQ_TinhThanh.Text = "Tỉnh thành:";
            // 
            // cmb_QQ_XaPhuong
            // 
            cmb_QQ_XaPhuong.FormattingEnabled = true;
            cmb_QQ_XaPhuong.Items.AddRange(new object[] { "Nam", "Nữ" });
            cmb_QQ_XaPhuong.Location = new Point(120, 71);
            cmb_QQ_XaPhuong.Name = "cmb_QQ_XaPhuong";
            cmb_QQ_XaPhuong.Size = new Size(151, 36);
            cmb_QQ_XaPhuong.TabIndex = 24;
            // 
            // cmb_QQ_TinhThanh
            // 
            cmb_QQ_TinhThanh.FormattingEnabled = true;
            cmb_QQ_TinhThanh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cmb_QQ_TinhThanh.Location = new Point(120, 29);
            cmb_QQ_TinhThanh.Name = "cmb_QQ_TinhThanh";
            cmb_QQ_TinhThanh.Size = new Size(151, 36);
            cmb_QQ_TinhThanh.TabIndex = 23;
            // 
            // lb_QQ_XaPhuong
            // 
            lb_QQ_XaPhuong.AutoSize = true;
            lb_QQ_XaPhuong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_QQ_XaPhuong.Location = new Point(6, 79);
            lb_QQ_XaPhuong.Name = "lb_QQ_XaPhuong";
            lb_QQ_XaPhuong.Size = new Size(113, 28);
            lb_QQ_XaPhuong.TabIndex = 22;
            lb_QQ_XaPhuong.Text = "Xã phường:";
            // 
            // lb_KhoaTruong
            // 
            lb_KhoaTruong.AutoSize = true;
            lb_KhoaTruong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_KhoaTruong.Location = new Point(466, 199);
            lb_KhoaTruong.Name = "lb_KhoaTruong";
            lb_KhoaTruong.Size = new Size(61, 28);
            lb_KhoaTruong.TabIndex = 23;
            lb_KhoaTruong.Text = "Khoa:";
            // 
            // lb_Lop
            // 
            lb_Lop.AutoSize = true;
            lb_Lop.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Lop.Location = new Point(466, 267);
            lb_Lop.Name = "lb_Lop";
            lb_Lop.Size = new Size(49, 28);
            lb_Lop.TabIndex = 25;
            lb_Lop.Text = "Lớp:";
            // 
            // lb_TrangThai
            // 
            lb_TrangThai.AutoSize = true;
            lb_TrangThai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_TrangThai.Location = new Point(466, 301);
            lb_TrangThai.Name = "lb_TrangThai";
            lb_TrangThai.Size = new Size(102, 28);
            lb_TrangThai.TabIndex = 26;
            lb_TrangThai.Text = "Trạng thái:";
            // 
            // cmb_Nganh
            // 
            cmb_Nganh.FormattingEnabled = true;
            cmb_Nganh.Location = new Point(548, 233);
            cmb_Nganh.Name = "cmb_Nganh";
            cmb_Nganh.Size = new Size(200, 28);
            cmb_Nganh.TabIndex = 27;
            // 
            // cmb_KhoaTruong
            // 
            cmb_KhoaTruong.FormattingEnabled = true;
            cmb_KhoaTruong.Location = new Point(548, 199);
            cmb_KhoaTruong.Name = "cmb_KhoaTruong";
            cmb_KhoaTruong.Size = new Size(200, 28);
            cmb_KhoaTruong.TabIndex = 28;
            // 
            // cmb_Lop
            // 
            cmb_Lop.FormattingEnabled = true;
            cmb_Lop.Location = new Point(548, 267);
            cmb_Lop.Name = "cmb_Lop";
            cmb_Lop.Size = new Size(200, 28);
            cmb_Lop.TabIndex = 29;
            // 
            // cmb_TrangThai
            // 
            cmb_TrangThai.FormattingEnabled = true;
            cmb_TrangThai.Location = new Point(573, 301);
            cmb_TrangThai.Name = "cmb_TrangThai";
            cmb_TrangThai.Size = new Size(175, 28);
            cmb_TrangThai.TabIndex = 30;
            // 
            // btn_XacNhan
            // 
            btn_XacNhan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_XacNhan.Location = new Point(12, 419);
            btn_XacNhan.Name = "btn_XacNhan";
            btn_XacNhan.Size = new Size(132, 52);
            btn_XacNhan.TabIndex = 31;
            btn_XacNhan.Text = "Xác nhận";
            btn_XacNhan.UseVisualStyleBackColor = true;
            // 
            // btn_NhapLai
            // 
            btn_NhapLai.BackColor = SystemColors.ControlLight;
            btn_NhapLai.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_NhapLai.Location = new Point(150, 419);
            btn_NhapLai.Name = "btn_NhapLai";
            btn_NhapLai.Size = new Size(132, 52);
            btn_NhapLai.TabIndex = 32;
            btn_NhapLai.Text = "Nhập lại";
            btn_NhapLai.UseVisualStyleBackColor = false;
            // 
            // btn_Thoat
            // 
            btn_Thoat.BackColor = Color.Red;
            btn_Thoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Thoat.ForeColor = Color.White;
            btn_Thoat.Location = new Point(616, 419);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(132, 52);
            btn_Thoat.TabIndex = 33;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = false;
            // 
            // tb_NienKhoa
            // 
            tb_NienKhoa.Location = new Point(573, 335);
            tb_NienKhoa.Name = "tb_NienKhoa";
            tb_NienKhoa.Size = new Size(175, 27);
            tb_NienKhoa.TabIndex = 35;
            // 
            // lb_NienKhoa
            // 
            lb_NienKhoa.AutoSize = true;
            lb_NienKhoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_NienKhoa.Location = new Point(466, 335);
            lb_NienKhoa.Name = "lb_NienKhoa";
            lb_NienKhoa.Size = new Size(105, 28);
            lb_NienKhoa.TabIndex = 34;
            lb_NienKhoa.Text = "Niên khóa:";
            // 
            // lb_Nganh
            // 
            lb_Nganh.AutoSize = true;
            lb_Nganh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Nganh.Location = new Point(466, 233);
            lb_Nganh.Name = "lb_Nganh";
            lb_Nganh.Size = new Size(75, 28);
            lb_Nganh.TabIndex = 36;
            lb_Nganh.Text = "Ngành:";
            // 
            // frm_admin_TaoTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 483);
            Controls.Add(lb_Nganh);
            Controls.Add(tb_NienKhoa);
            Controls.Add(lb_NienKhoa);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_NhapLai);
            Controls.Add(btn_XacNhan);
            Controls.Add(cmb_TrangThai);
            Controls.Add(cmb_Lop);
            Controls.Add(cmb_KhoaTruong);
            Controls.Add(cmb_Nganh);
            Controls.Add(lb_TrangThai);
            Controls.Add(lb_Lop);
            Controls.Add(lb_KhoaTruong);
            Controls.Add(grb_QueQuan);
            Controls.Add(cmb_NoiSinh);
            Controls.Add(lb_NoiSinh);
            Controls.Add(tb_DiaChi);
            Controls.Add(lb_DiaChi);
            Controls.Add(tb_SoCCCD);
            Controls.Add(lb_SoCCCD);
            Controls.Add(date_NgaySinh);
            Controls.Add(lb_NgaySinh);
            Controls.Add(cmb_TonGiao);
            Controls.Add(cmb_DanToc);
            Controls.Add(lb_TieuDe);
            Controls.Add(tb_Email);
            Controls.Add(tb_HoTen);
            Controls.Add(lb_TonGiao);
            Controls.Add(lb_HoTen);
            Controls.Add(cmb_GioiTinh);
            Controls.Add(lb_SDT);
            Controls.Add(lb_GioiTinh);
            Controls.Add(tb_SDT);
            Controls.Add(lb_DanToc);
            Controls.Add(lb_Email);
            Name = "frm_admin_TaoTaiKhoan";
            Text = "Tạo tài khoản";
            grb_QueQuan.ResumeLayout(false);
            grb_QueQuan.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_TieuDe;
        private Label lb_HoTen;
        private Label lb_GioiTinh;
        private Label lb_SDT;
        private TextBox tb_HoTen;
        private TextBox tb_SDT;
        private Label lb_Email;
        private TextBox tb_Email;
        private Label lb_TonGiao;
        private Label lb_DanToc;
        private ComboBox cmb_TonGiao;
        private ComboBox cmb_DanToc;
        private Label lb_NgaySinh;
        private DateTimePicker date_NgaySinh;
        private Label lb_SoCCCD;
        private TextBox tb_SoCCCD;
        private Label lb_DiaChi;
        private TextBox tb_DiaChi;
        private Label lb_NoiSinh;
        private ComboBox cmb_NoiSinh;
        private Label lb_NienKhoa;
        private GroupBox grb_QueQuan;
        private ComboBox cmb_QQ_XaPhuong;
        private ComboBox cmb_QQ_TinhThanh;
        private Label lb_QQ_XaPhuong;
        private Label lb_QQ_TinhThanh;
        public ComboBox cmb_GioiTinh;
        private Label lb_KhoaTruong;
        private Label label3;
        private Label lb_Lop;
        private Label lb_TrangThai;
        private ComboBox cmb_Nganh;
        private ComboBox cmb_KhoaTruong;
        private ComboBox cmb_Lop;
        private ComboBox cmb_TrangThai;
        private Button btn_XacNhan;
        private Button btn_NhapLai;
        private Button btn_Thoat;
        private TextBox tb_NienKhoa;
        private Label lb_Nganh;
    }
}