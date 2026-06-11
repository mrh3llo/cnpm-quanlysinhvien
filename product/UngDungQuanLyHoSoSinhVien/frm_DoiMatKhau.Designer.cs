namespace UngDungQuanLyHoSoSinhVien
{
    partial class frm_DoiMatKhau
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
            tb_MatKhauCu = new TextBox();
            btn_XacNhan = new Button();
            label2 = new Label();
            label3 = new Label();
            tb_MatKhauMoi = new TextBox();
            label4 = new Label();
            tb_XacNhanMatKhau = new TextBox();
            btn_NhapLai = new Button();
            btn_HienThiMatKhau = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(134, 9);
            label1.Name = "label1";
            label1.Size = new Size(226, 38);
            label1.TabIndex = 5;
            label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // tb_MatKhauCu
            // 
            tb_MatKhauCu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_MatKhauCu.Location = new Point(220, 77);
            tb_MatKhauCu.Name = "tb_MatKhauCu";
            tb_MatKhauCu.Size = new Size(250, 34);
            tb_MatKhauCu.TabIndex = 4;
            // 
            // btn_XacNhan
            // 
            btn_XacNhan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_XacNhan.Location = new Point(12, 257);
            btn_XacNhan.Name = "btn_XacNhan";
            btn_XacNhan.Size = new Size(130, 50);
            btn_XacNhan.TabIndex = 3;
            btn_XacNhan.Text = "Xác nhận";
            btn_XacNhan.UseVisualStyleBackColor = true;
            btn_XacNhan.Click += btn_XacNhan_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(135, 28);
            label2.TabIndex = 6;
            label2.Text = "Mật khẩu cũ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 123);
            label3.Name = "label3";
            label3.Size = new Size(150, 28);
            label3.TabIndex = 8;
            label3.Text = "Mật khẩu mới:";
            // 
            // tb_MatKhauMoi
            // 
            tb_MatKhauMoi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_MatKhauMoi.Location = new Point(220, 117);
            tb_MatKhauMoi.Name = "tb_MatKhauMoi";
            tb_MatKhauMoi.Size = new Size(250, 34);
            tb_MatKhauMoi.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 163);
            label4.Name = "label4";
            label4.Size = new Size(199, 28);
            label4.TabIndex = 10;
            label4.Text = "Xác nhận mật khẩu:";
            // 
            // tb_XacNhanMatKhau
            // 
            tb_XacNhanMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_XacNhanMatKhau.Location = new Point(220, 157);
            tb_XacNhanMatKhau.Name = "tb_XacNhanMatKhau";
            tb_XacNhanMatKhau.Size = new Size(250, 34);
            tb_XacNhanMatKhau.TabIndex = 9;
            // 
            // btn_NhapLai
            // 
            btn_NhapLai.BackColor = SystemColors.ControlLight;
            btn_NhapLai.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_NhapLai.Location = new Point(157, 257);
            btn_NhapLai.Name = "btn_NhapLai";
            btn_NhapLai.Size = new Size(130, 50);
            btn_NhapLai.TabIndex = 11;
            btn_NhapLai.Text = "Nhập lại";
            btn_NhapLai.UseVisualStyleBackColor = false;
            btn_NhapLai.Click += btn_NhapLai_Click;
            // 
            // btn_HienThiMatKhau
            // 
            btn_HienThiMatKhau.Location = new Point(353, 197);
            btn_HienThiMatKhau.Name = "btn_HienThiMatKhau";
            btn_HienThiMatKhau.Size = new Size(117, 29);
            btn_HienThiMatKhau.TabIndex = 12;
            btn_HienThiMatKhau.Text = "Hiện mật khẩu";
            btn_HienThiMatKhau.UseVisualStyleBackColor = true;
            btn_HienThiMatKhau.Click += btn_HienThiMatKhau_Click;
            // 
            // frm_DoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 353);
            Controls.Add(btn_HienThiMatKhau);
            Controls.Add(btn_NhapLai);
            Controls.Add(label4);
            Controls.Add(tb_XacNhanMatKhau);
            Controls.Add(label3);
            Controls.Add(tb_MatKhauMoi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_MatKhauCu);
            Controls.Add(btn_XacNhan);
            Name = "frm_DoiMatKhau";
            Text = "Đổi mật khẩu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_MatKhauCu;
        private Button btn_XacNhan;
        private Label label2;
        private Label label3;
        private TextBox tb_MatKhauMoi;
        private Label label4;
        private TextBox tb_XacNhanMatKhau;
        private Button btn_NhapLai;
        private Button btn_HienThiMatKhau;
    }
}