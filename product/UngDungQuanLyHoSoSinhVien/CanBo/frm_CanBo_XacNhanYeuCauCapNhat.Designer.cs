namespace UngDungQuanLyHoSoSinhVien.GiangVien
{
    partial class frm_CanBo_XacNhanYeuCauCapNhat
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
            grb_DSYeuCauCapNhat = new GroupBox();
            dgv_DSYeuCauCapNhat = new DataGridView();
            label1 = new Label();
            grb_TT_SinhVien = new GroupBox();
            lb_HT_Lop = new Label();
            lb_HT_HoTen = new Label();
            lb_HT_MSSV = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            grb_TT_CapNhat = new GroupBox();
            rtb_HT_LyDoCapNhat = new RichTextBox();
            label5 = new Label();
            btn_KhongDuyetYeuCau = new Button();
            btn_DuyetYeuCau = new Button();
            lb_HT_DiaChi_Moi = new Label();
            lb_HT_DiaChi_Cu = new Label();
            lb_HT_Email_Moi = new Label();
            lb_HT_Email_Cu = new Label();
            lb_HT_SDT_Moi = new Label();
            lb_HT_SDT_Cu = new Label();
            label10 = new Label();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            grb_DSYeuCauCapNhat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DSYeuCauCapNhat).BeginInit();
            grb_TT_SinhVien.SuspendLayout();
            grb_TT_CapNhat.SuspendLayout();
            SuspendLayout();
            // 
            // grb_DSYeuCauCapNhat
            // 
            grb_DSYeuCauCapNhat.Controls.Add(dgv_DSYeuCauCapNhat);
            grb_DSYeuCauCapNhat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grb_DSYeuCauCapNhat.Location = new Point(12, 85);
            grb_DSYeuCauCapNhat.Name = "grb_DSYeuCauCapNhat";
            grb_DSYeuCauCapNhat.Size = new Size(655, 444);
            grb_DSYeuCauCapNhat.TabIndex = 0;
            grb_DSYeuCauCapNhat.TabStop = false;
            grb_DSYeuCauCapNhat.Text = "Các yêu cầu:";
            // 
            // dgv_DSYeuCauCapNhat
            // 
            dgv_DSYeuCauCapNhat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DSYeuCauCapNhat.Location = new Point(6, 33);
            dgv_DSYeuCauCapNhat.Name = "dgv_DSYeuCauCapNhat";
            dgv_DSYeuCauCapNhat.RowHeadersWidth = 51;
            dgv_DSYeuCauCapNhat.Size = new Size(643, 405);
            dgv_DSYeuCauCapNhat.TabIndex = 0;
            dgv_DSYeuCauCapNhat.CellContentClick += dgv_DSYeuCauCapNhat_CellContentClick;
            dgv_DSYeuCauCapNhat.CellContentDoubleClick += dgv_DSYeuCauCapNhat_CellContentDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(92, 9);
            label1.Name = "label1";
            label1.Size = new Size(524, 54);
            label1.TabIndex = 1;
            label1.Text = "Xác nhận yêu cầu cập nhật";
            // 
            // grb_TT_SinhVien
            // 
            grb_TT_SinhVien.Controls.Add(lb_HT_Lop);
            grb_TT_SinhVien.Controls.Add(lb_HT_HoTen);
            grb_TT_SinhVien.Controls.Add(lb_HT_MSSV);
            grb_TT_SinhVien.Controls.Add(label4);
            grb_TT_SinhVien.Controls.Add(label3);
            grb_TT_SinhVien.Controls.Add(label2);
            grb_TT_SinhVien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grb_TT_SinhVien.Location = new Point(673, 12);
            grb_TT_SinhVien.Name = "grb_TT_SinhVien";
            grb_TT_SinhVien.Size = new Size(497, 126);
            grb_TT_SinhVien.TabIndex = 2;
            grb_TT_SinhVien.TabStop = false;
            grb_TT_SinhVien.Text = "Thông tin sinh viên:";
            grb_TT_SinhVien.Visible = false;
            // 
            // lb_HT_Lop
            // 
            lb_HT_Lop.AutoSize = true;
            lb_HT_Lop.Location = new Point(107, 89);
            lb_HT_Lop.Name = "lb_HT_Lop";
            lb_HT_Lop.Size = new Size(24, 28);
            lb_HT_Lop.TabIndex = 5;
            lb_HT_Lop.Text = "...";
            // 
            // lb_HT_HoTen
            // 
            lb_HT_HoTen.AutoSize = true;
            lb_HT_HoTen.Location = new Point(107, 61);
            lb_HT_HoTen.Name = "lb_HT_HoTen";
            lb_HT_HoTen.Size = new Size(24, 28);
            lb_HT_HoTen.TabIndex = 4;
            lb_HT_HoTen.Text = "...";
            // 
            // lb_HT_MSSV
            // 
            lb_HT_MSSV.AutoSize = true;
            lb_HT_MSSV.Location = new Point(107, 33);
            lb_HT_MSSV.Name = "lb_HT_MSSV";
            lb_HT_MSSV.Size = new Size(24, 28);
            lb_HT_MSSV.TabIndex = 3;
            lb_HT_MSSV.Text = "...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 89);
            label4.Name = "label4";
            label4.Size = new Size(52, 28);
            label4.TabIndex = 2;
            label4.Text = "Lớp:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 61);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 1;
            label3.Text = "Họ tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 33);
            label2.Name = "label2";
            label2.Size = new Size(71, 28);
            label2.TabIndex = 0;
            label2.Text = "MSSV:";
            // 
            // grb_TT_CapNhat
            // 
            grb_TT_CapNhat.Controls.Add(rtb_HT_LyDoCapNhat);
            grb_TT_CapNhat.Controls.Add(label5);
            grb_TT_CapNhat.Controls.Add(btn_KhongDuyetYeuCau);
            grb_TT_CapNhat.Controls.Add(btn_DuyetYeuCau);
            grb_TT_CapNhat.Controls.Add(lb_HT_DiaChi_Moi);
            grb_TT_CapNhat.Controls.Add(lb_HT_DiaChi_Cu);
            grb_TT_CapNhat.Controls.Add(lb_HT_Email_Moi);
            grb_TT_CapNhat.Controls.Add(lb_HT_Email_Cu);
            grb_TT_CapNhat.Controls.Add(lb_HT_SDT_Moi);
            grb_TT_CapNhat.Controls.Add(lb_HT_SDT_Cu);
            grb_TT_CapNhat.Controls.Add(label10);
            grb_TT_CapNhat.Controls.Add(label11);
            grb_TT_CapNhat.Controls.Add(label9);
            grb_TT_CapNhat.Controls.Add(label8);
            grb_TT_CapNhat.Controls.Add(label7);
            grb_TT_CapNhat.Controls.Add(label6);
            grb_TT_CapNhat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grb_TT_CapNhat.Location = new Point(673, 144);
            grb_TT_CapNhat.Name = "grb_TT_CapNhat";
            grb_TT_CapNhat.Size = new Size(497, 385);
            grb_TT_CapNhat.TabIndex = 4;
            grb_TT_CapNhat.TabStop = false;
            grb_TT_CapNhat.Text = "Thông tin cập nhật:";
            grb_TT_CapNhat.Visible = false;
            // 
            // rtb_HT_LyDoCapNhat
            // 
            rtb_HT_LyDoCapNhat.Location = new Point(93, 243);
            rtb_HT_LyDoCapNhat.Name = "rtb_HT_LyDoCapNhat";
            rtb_HT_LyDoCapNhat.Size = new Size(398, 90);
            rtb_HT_LyDoCapNhat.TabIndex = 18;
            rtb_HT_LyDoCapNhat.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 243);
            label5.Name = "label5";
            label5.Size = new Size(67, 28);
            label5.TabIndex = 17;
            label5.Text = "Lý do:";
            // 
            // btn_KhongDuyetYeuCau
            // 
            btn_KhongDuyetYeuCau.BackColor = Color.Red;
            btn_KhongDuyetYeuCau.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_KhongDuyetYeuCau.ForeColor = SystemColors.Control;
            btn_KhongDuyetYeuCau.Location = new Point(120, 339);
            btn_KhongDuyetYeuCau.Name = "btn_KhongDuyetYeuCau";
            btn_KhongDuyetYeuCau.Size = new Size(145, 40);
            btn_KhongDuyetYeuCau.TabIndex = 16;
            btn_KhongDuyetYeuCau.Text = "Không duyệt";
            btn_KhongDuyetYeuCau.UseVisualStyleBackColor = false;
            btn_KhongDuyetYeuCau.Click += btn_KhongDuyetYeuCau_Click;
            // 
            // btn_DuyetYeuCau
            // 
            btn_DuyetYeuCau.Location = new Point(20, 339);
            btn_DuyetYeuCau.Name = "btn_DuyetYeuCau";
            btn_DuyetYeuCau.Size = new Size(94, 40);
            btn_DuyetYeuCau.TabIndex = 15;
            btn_DuyetYeuCau.Text = "Duyệt";
            btn_DuyetYeuCau.UseVisualStyleBackColor = true;
            btn_DuyetYeuCau.Click += btn_DuyetYeuCau_Click;
            // 
            // lb_HT_DiaChi_Moi
            // 
            lb_HT_DiaChi_Moi.AutoSize = true;
            lb_HT_DiaChi_Moi.Location = new Point(171, 201);
            lb_HT_DiaChi_Moi.Name = "lb_HT_DiaChi_Moi";
            lb_HT_DiaChi_Moi.Size = new Size(24, 28);
            lb_HT_DiaChi_Moi.TabIndex = 14;
            lb_HT_DiaChi_Moi.Text = "...";
            // 
            // lb_HT_DiaChi_Cu
            // 
            lb_HT_DiaChi_Cu.AutoSize = true;
            lb_HT_DiaChi_Cu.Location = new Point(171, 173);
            lb_HT_DiaChi_Cu.Name = "lb_HT_DiaChi_Cu";
            lb_HT_DiaChi_Cu.Size = new Size(24, 28);
            lb_HT_DiaChi_Cu.TabIndex = 13;
            lb_HT_DiaChi_Cu.Text = "...";
            // 
            // lb_HT_Email_Moi
            // 
            lb_HT_Email_Moi.AutoSize = true;
            lb_HT_Email_Moi.Location = new Point(171, 136);
            lb_HT_Email_Moi.Name = "lb_HT_Email_Moi";
            lb_HT_Email_Moi.Size = new Size(24, 28);
            lb_HT_Email_Moi.TabIndex = 12;
            lb_HT_Email_Moi.Text = "...";
            // 
            // lb_HT_Email_Cu
            // 
            lb_HT_Email_Cu.AutoSize = true;
            lb_HT_Email_Cu.Location = new Point(171, 108);
            lb_HT_Email_Cu.Name = "lb_HT_Email_Cu";
            lb_HT_Email_Cu.Size = new Size(24, 28);
            lb_HT_Email_Cu.TabIndex = 11;
            lb_HT_Email_Cu.Text = "...";
            // 
            // lb_HT_SDT_Moi
            // 
            lb_HT_SDT_Moi.AutoSize = true;
            lb_HT_SDT_Moi.Location = new Point(227, 71);
            lb_HT_SDT_Moi.Name = "lb_HT_SDT_Moi";
            lb_HT_SDT_Moi.Size = new Size(24, 28);
            lb_HT_SDT_Moi.TabIndex = 10;
            lb_HT_SDT_Moi.Text = "...";
            // 
            // lb_HT_SDT_Cu
            // 
            lb_HT_SDT_Cu.AutoSize = true;
            lb_HT_SDT_Cu.Location = new Point(227, 43);
            lb_HT_SDT_Cu.Name = "lb_HT_SDT_Cu";
            lb_HT_SDT_Cu.Size = new Size(24, 28);
            lb_HT_SDT_Cu.TabIndex = 9;
            lb_HT_SDT_Cu.Text = "...";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(20, 173);
            label10.Name = "label10";
            label10.Size = new Size(127, 28);
            label10.TabIndex = 8;
            label10.Text = "Địa chỉ (Cũ):";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(20, 201);
            label11.Name = "label11";
            label11.Size = new Size(141, 28);
            label11.TabIndex = 7;
            label11.Text = "Địa chỉ (Mới):";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(20, 108);
            label9.Name = "label9";
            label9.Size = new Size(113, 28);
            label9.TabIndex = 6;
            label9.Text = "Email (Cũ):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(20, 136);
            label8.Name = "label8";
            label8.Size = new Size(127, 28);
            label8.TabIndex = 5;
            label8.Text = "Email (Mới):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(20, 71);
            label7.Name = "label7";
            label7.Size = new Size(201, 28);
            label7.TabIndex = 4;
            label7.Text = "Số điện thoại (Mới):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(20, 43);
            label6.Name = "label6";
            label6.Size = new Size(187, 28);
            label6.TabIndex = 3;
            label6.Text = "Số điện thoại (Cũ):";
            // 
            // frm_CanBo_XacNhanYeuCauCapNhat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 543);
            Controls.Add(grb_TT_CapNhat);
            Controls.Add(grb_TT_SinhVien);
            Controls.Add(label1);
            Controls.Add(grb_DSYeuCauCapNhat);
            Name = "frm_CanBo_XacNhanYeuCauCapNhat";
            Text = "Yêu cầu cập nhật";
            grb_DSYeuCauCapNhat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_DSYeuCauCapNhat).EndInit();
            grb_TT_SinhVien.ResumeLayout(false);
            grb_TT_SinhVien.PerformLayout();
            grb_TT_CapNhat.ResumeLayout(false);
            grb_TT_CapNhat.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grb_DSYeuCauCapNhat;
        private Label label1;
        private DataGridView dgv_DSYeuCauCapNhat;
        private GroupBox grb_TT_SinhVien;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox grb_TT_CapNhat;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label10;
        private Label label11;
        private Label lb_HT_Lop;
        private Label lb_HT_HoTen;
        private Label lb_HT_MSSV;
        private Label lb_HT_DiaChi_Moi;
        private Label lb_HT_DiaChi_Cu;
        private Label lb_HT_Email_Moi;
        private Label lb_HT_Email_Cu;
        private Label lb_HT_SDT_Moi;
        private Label lb_HT_SDT_Cu;
        private Button btn_KhongDuyetYeuCau;
        private Button btn_DuyetYeuCau;
        private Label label5;
        private RichTextBox rtb_HT_LyDoCapNhat;
    }
}