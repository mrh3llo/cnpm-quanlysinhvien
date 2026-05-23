namespace UngDungQuanLyHoSoSinhVien.GiangVien
{
    partial class frm_GiangVien_DS_SinhVien
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
            grb_TimMSSV = new GroupBox();
            btn_TimMSSV = new Button();
            tb_TimMSSV = new TextBox();
            grb_ChucNang = new GroupBox();
            btn_TaiLai = new Button();
            btn_XuatDanhSach = new Button();
            btn_ChiTietTT = new Button();
            dgv_DSSinhVien = new DataGridView();
            lb_TieuDe = new Label();
            btn_DangXuat = new Button();
            label1 = new Label();
            cmb_LopGiangDay = new ComboBox();
            grb_TimMSSV.SuspendLayout();
            grb_ChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DSSinhVien).BeginInit();
            SuspendLayout();
            // 
            // grb_TimMSSV
            // 
            grb_TimMSSV.Controls.Add(btn_TimMSSV);
            grb_TimMSSV.Controls.Add(tb_TimMSSV);
            grb_TimMSSV.Location = new Point(438, 68);
            grb_TimMSSV.Name = "grb_TimMSSV";
            grb_TimMSSV.Size = new Size(350, 121);
            grb_TimMSSV.TabIndex = 8;
            grb_TimMSSV.TabStop = false;
            grb_TimMSSV.Text = "Tìm MSSV:";
            // 
            // btn_TimMSSV
            // 
            btn_TimMSSV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_TimMSSV.Location = new Point(250, 26);
            btn_TimMSSV.Name = "btn_TimMSSV";
            btn_TimMSSV.Size = new Size(94, 44);
            btn_TimMSSV.TabIndex = 3;
            btn_TimMSSV.Text = "Tìm";
            btn_TimMSSV.UseVisualStyleBackColor = true;
            btn_TimMSSV.Click += btn_TimMSSV_Click;
            // 
            // tb_TimMSSV
            // 
            tb_TimMSSV.Location = new Point(6, 26);
            tb_TimMSSV.Name = "tb_TimMSSV";
            tb_TimMSSV.Size = new Size(238, 27);
            tb_TimMSSV.TabIndex = 2;
            // 
            // grb_ChucNang
            // 
            grb_ChucNang.Controls.Add(btn_TaiLai);
            grb_ChucNang.Controls.Add(btn_XuatDanhSach);
            grb_ChucNang.Controls.Add(btn_ChiTietTT);
            grb_ChucNang.Location = new Point(12, 68);
            grb_ChucNang.Name = "grb_ChucNang";
            grb_ChucNang.Size = new Size(420, 121);
            grb_ChucNang.TabIndex = 7;
            grb_ChucNang.TabStop = false;
            grb_ChucNang.Text = "Chức năng:";
            // 
            // btn_TaiLai
            // 
            btn_TaiLai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_TaiLai.Location = new Point(6, 76);
            btn_TaiLai.Name = "btn_TaiLai";
            btn_TaiLai.Size = new Size(91, 42);
            btn_TaiLai.TabIndex = 10;
            btn_TaiLai.Text = "Tải lại";
            btn_TaiLai.UseVisualStyleBackColor = true;
            btn_TaiLai.Click += btn_TaiLai_Click;
            // 
            // btn_XuatDanhSach
            // 
            btn_XuatDanhSach.BackColor = SystemColors.Control;
            btn_XuatDanhSach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_XuatDanhSach.ForeColor = SystemColors.ControlText;
            btn_XuatDanhSach.Location = new Point(215, 26);
            btn_XuatDanhSach.Name = "btn_XuatDanhSach";
            btn_XuatDanhSach.Size = new Size(199, 44);
            btn_XuatDanhSach.TabIndex = 5;
            btn_XuatDanhSach.Text = "Xuất danh sách";
            btn_XuatDanhSach.UseVisualStyleBackColor = false;
            btn_XuatDanhSach.Click += btn_XuatDanhSach_Click;
            // 
            // btn_ChiTietTT
            // 
            btn_ChiTietTT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ChiTietTT.Location = new Point(6, 26);
            btn_ChiTietTT.Name = "btn_ChiTietTT";
            btn_ChiTietTT.Size = new Size(199, 44);
            btn_ChiTietTT.TabIndex = 0;
            btn_ChiTietTT.Text = "Chi tiết thông tin";
            btn_ChiTietTT.UseVisualStyleBackColor = true;
            btn_ChiTietTT.Click += btn_ChiTietTT_Click;
            // 
            // dgv_DSSinhVien
            // 
            dgv_DSSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DSSinhVien.Location = new Point(12, 239);
            dgv_DSSinhVien.Name = "dgv_DSSinhVien";
            dgv_DSSinhVien.RowHeadersWidth = 51;
            dgv_DSSinhVien.Size = new Size(776, 201);
            dgv_DSSinhVien.TabIndex = 6;
            dgv_DSSinhVien.CellContentDoubleClick += dgv_DSSinhVien_CellContentDoubleClick;
            // 
            // lb_TieuDe
            // 
            lb_TieuDe.AutoSize = true;
            lb_TieuDe.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_TieuDe.Location = new Point(194, 11);
            lb_TieuDe.Name = "lb_TieuDe";
            lb_TieuDe.Size = new Size(404, 54);
            lb_TieuDe.TabIndex = 5;
            lb_TieuDe.Text = "Danh sách Sinh Viên";
            // 
            // btn_DangXuat
            // 
            btn_DangXuat.BackColor = Color.Red;
            btn_DangXuat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_DangXuat.ForeColor = SystemColors.Control;
            btn_DangXuat.Location = new Point(12, 447);
            btn_DangXuat.Name = "btn_DangXuat";
            btn_DangXuat.Size = new Size(223, 46);
            btn_DangXuat.TabIndex = 9;
            btn_DangXuat.Text = "Đăng xuất";
            btn_DangXuat.UseVisualStyleBackColor = false;
            btn_DangXuat.Click += btn_DangXuat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 201);
            label1.Name = "label1";
            label1.Size = new Size(151, 28);
            label1.TabIndex = 10;
            label1.Text = "Lớp giảng dạy:";
            // 
            // cmb_LopGiangDay
            // 
            cmb_LopGiangDay.FormattingEnabled = true;
            cmb_LopGiangDay.Location = new Point(169, 201);
            cmb_LopGiangDay.Name = "cmb_LopGiangDay";
            cmb_LopGiangDay.Size = new Size(151, 28);
            cmb_LopGiangDay.TabIndex = 11;
            cmb_LopGiangDay.SelectedIndexChanged += cmb_LopGiangDay_SelectedIndexChanged;
            // 
            // frm_GiangVien_DS_SinhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 505);
            Controls.Add(cmb_LopGiangDay);
            Controls.Add(label1);
            Controls.Add(btn_DangXuat);
            Controls.Add(grb_TimMSSV);
            Controls.Add(grb_ChucNang);
            Controls.Add(dgv_DSSinhVien);
            Controls.Add(lb_TieuDe);
            Name = "frm_GiangVien_DS_SinhVien";
            Text = "Danh sách Sinh viên";
            grb_TimMSSV.ResumeLayout(false);
            grb_TimMSSV.PerformLayout();
            grb_ChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_DSSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grb_TimMSSV;
        private Button btn_TimMSSV;
        private TextBox tb_TimMSSV;
        private GroupBox grb_ChucNang;
        private Button btn_XuatDanhSach;
        private Button btn_ChiTietTT;
        private DataGridView dgv_DSSinhVien;
        private Label lb_TieuDe;
        private Button btn_DangXuat;
        private Button btn_TaiLai;
        private Label label1;
        private ComboBox cmb_LopGiangDay;
    }
}