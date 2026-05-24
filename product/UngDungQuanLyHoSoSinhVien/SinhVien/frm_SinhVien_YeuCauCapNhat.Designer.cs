namespace UngDungQuanLyHoSoSinhVien.SinhVien
{
    partial class frm_SinhVien_YeuCauCapNhat
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
            file_AnhDaiDien = new OpenFileDialog();
            btn_Thoat = new Button();
            btn_NhapLai = new Button();
            btn_XacNhan = new Button();
            tb_DiaChi = new TextBox();
            lb_DiaChi = new Label();
            tb_Email = new TextBox();
            lb_SDT = new Label();
            tb_SDT = new TextBox();
            lb_Email = new Label();
            lb_TieuDe = new Label();
            lb_LyDoCapNhat = new Label();
            rtb_LyDoCapNhat = new RichTextBox();
            SuspendLayout();
            // 
            // file_AnhDaiDien
            // 
            file_AnhDaiDien.FileName = "openFileDialog1";
            // 
            // btn_Thoat
            // 
            btn_Thoat.BackColor = Color.Red;
            btn_Thoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Thoat.ForeColor = Color.White;
            btn_Thoat.Location = new Point(453, 332);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(132, 52);
            btn_Thoat.TabIndex = 144;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = false;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // btn_NhapLai
            // 
            btn_NhapLai.BackColor = SystemColors.ControlLight;
            btn_NhapLai.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_NhapLai.Location = new Point(150, 332);
            btn_NhapLai.Name = "btn_NhapLai";
            btn_NhapLai.Size = new Size(132, 52);
            btn_NhapLai.TabIndex = 143;
            btn_NhapLai.Text = "Nhập lại";
            btn_NhapLai.UseVisualStyleBackColor = false;
            btn_NhapLai.Click += btn_NhapLai_Click;
            // 
            // btn_XacNhan
            // 
            btn_XacNhan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_XacNhan.Location = new Point(12, 332);
            btn_XacNhan.Name = "btn_XacNhan";
            btn_XacNhan.Size = new Size(132, 52);
            btn_XacNhan.TabIndex = 142;
            btn_XacNhan.Text = "Xác nhận";
            btn_XacNhan.UseVisualStyleBackColor = true;
            btn_XacNhan.Click += btn_XacNhan_Click;
            // 
            // tb_DiaChi
            // 
            tb_DiaChi.Location = new Point(150, 154);
            tb_DiaChi.Name = "tb_DiaChi";
            tb_DiaChi.Size = new Size(304, 27);
            tb_DiaChi.TabIndex = 128;
            // 
            // lb_DiaChi
            // 
            lb_DiaChi.AutoSize = true;
            lb_DiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_DiaChi.Location = new Point(12, 154);
            lb_DiaChi.Name = "lb_DiaChi";
            lb_DiaChi.Size = new Size(75, 28);
            lb_DiaChi.TabIndex = 127;
            lb_DiaChi.Text = "Địa chỉ:";
            // 
            // tb_Email
            // 
            tb_Email.Location = new Point(150, 121);
            tb_Email.Name = "tb_Email";
            tb_Email.Size = new Size(304, 27);
            tb_Email.TabIndex = 120;
            // 
            // lb_SDT
            // 
            lb_SDT.AutoSize = true;
            lb_SDT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_SDT.Location = new Point(12, 88);
            lb_SDT.Name = "lb_SDT";
            lb_SDT.Size = new Size(132, 28);
            lb_SDT.TabIndex = 113;
            lb_SDT.Text = "Số điện thoại:";
            // 
            // tb_SDT
            // 
            tb_SDT.Location = new Point(150, 88);
            tb_SDT.Name = "tb_SDT";
            tb_SDT.Size = new Size(247, 27);
            tb_SDT.TabIndex = 116;
            // 
            // lb_Email
            // 
            lb_Email.AutoSize = true;
            lb_Email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Email.Location = new Point(12, 121);
            lb_Email.Name = "lb_Email";
            lb_Email.Size = new Size(63, 28);
            lb_Email.TabIndex = 117;
            lb_Email.Text = "Email:";
            // 
            // lb_TieuDe
            // 
            lb_TieuDe.AutoSize = true;
            lb_TieuDe.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_TieuDe.ForeColor = SystemColors.ControlText;
            lb_TieuDe.Location = new Point(67, 9);
            lb_TieuDe.Name = "lb_TieuDe";
            lb_TieuDe.Size = new Size(455, 54);
            lb_TieuDe.TabIndex = 110;
            lb_TieuDe.Text = "Thông tin cần cập nhật";
            // 
            // lb_LyDoCapNhat
            // 
            lb_LyDoCapNhat.AutoSize = true;
            lb_LyDoCapNhat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_LyDoCapNhat.Location = new Point(12, 187);
            lb_LyDoCapNhat.Name = "lb_LyDoCapNhat";
            lb_LyDoCapNhat.Size = new Size(63, 28);
            lb_LyDoCapNhat.TabIndex = 145;
            lb_LyDoCapNhat.Text = "Lý do:";
            // 
            // rtb_LyDoCapNhat
            // 
            rtb_LyDoCapNhat.Location = new Point(150, 187);
            rtb_LyDoCapNhat.Name = "rtb_LyDoCapNhat";
            rtb_LyDoCapNhat.RightToLeft = RightToLeft.No;
            rtb_LyDoCapNhat.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtb_LyDoCapNhat.Size = new Size(304, 106);
            rtb_LyDoCapNhat.TabIndex = 147;
            rtb_LyDoCapNhat.Text = "";
            // 
            // frm_SinhVien_YeuCauCapNhat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 396);
            Controls.Add(rtb_LyDoCapNhat);
            Controls.Add(lb_LyDoCapNhat);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_NhapLai);
            Controls.Add(btn_XacNhan);
            Controls.Add(tb_DiaChi);
            Controls.Add(lb_DiaChi);
            Controls.Add(tb_Email);
            Controls.Add(lb_SDT);
            Controls.Add(tb_SDT);
            Controls.Add(lb_Email);
            Controls.Add(lb_TieuDe);
            Name = "frm_SinhVien_YeuCauCapNhat";
            Text = "Gửi yêu cầu cập nhật";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog file_AnhDaiDien;
        private Button btn_Thoat;
        private Button btn_NhapLai;
        private Button btn_XacNhan;
        public TextBox tb_DiaChi;
        private Label lb_DiaChi;
        public TextBox tb_Email;
        private Label lb_SDT;
        public TextBox tb_SDT;
        private Label lb_Email;
        private Label lb_TieuDe;
        private Label lb_LyDoCapNhat;
        private RichTextBox rtb_LyDoCapNhat;
    }
}