namespace UngDungQuanLyHoSoSinhVien.admin
{
    partial class frm_admin_QuanLy
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
            grb_QuanLy = new GroupBox();
            btn_XoaTaiKhoan = new Button();
            btn_SuaTaiKhoan = new Button();
            btn_TaoTaiKhoan = new Button();
            dgv_DSSinhVien = new DataGridView();
            grb_DSSinhVien = new GroupBox();
            btn_TaiLai = new Button();
            btn_DSTaiKhoan = new Button();
            btn_DangXuat = new Button();
            grb_TimKiem = new GroupBox();
            btn_TimKiemNangCao = new Button();
            tb_TimMSSV = new TextBox();
            btn_TimMSSV = new Button();
            lb_TimMSSV = new Label();
            grb_QuanLy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DSSinhVien).BeginInit();
            grb_DSSinhVien.SuspendLayout();
            grb_TimKiem.SuspendLayout();
            SuspendLayout();
            // 
            // lb_TieuDe
            // 
            lb_TieuDe.AutoSize = true;
            lb_TieuDe.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_TieuDe.Location = new Point(206, 9);
            lb_TieuDe.Name = "lb_TieuDe";
            lb_TieuDe.Size = new Size(354, 54);
            lb_TieuDe.TabIndex = 0;
            lb_TieuDe.Text = "Quản lý tài khoản";
            // 
            // grb_QuanLy
            // 
            grb_QuanLy.Controls.Add(btn_XoaTaiKhoan);
            grb_QuanLy.Controls.Add(btn_SuaTaiKhoan);
            grb_QuanLy.Controls.Add(btn_TaoTaiKhoan);
            grb_QuanLy.Location = new Point(12, 146);
            grb_QuanLy.Name = "grb_QuanLy";
            grb_QuanLy.Size = new Size(223, 174);
            grb_QuanLy.TabIndex = 1;
            grb_QuanLy.TabStop = false;
            grb_QuanLy.Text = "Chức năng quản lý";
            // 
            // btn_XoaTaiKhoan
            // 
            btn_XoaTaiKhoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_XoaTaiKhoan.Location = new Point(6, 122);
            btn_XoaTaiKhoan.Name = "btn_XoaTaiKhoan";
            btn_XoaTaiKhoan.Size = new Size(210, 42);
            btn_XoaTaiKhoan.TabIndex = 5;
            btn_XoaTaiKhoan.Text = "Xóa tài khoản";
            btn_XoaTaiKhoan.UseVisualStyleBackColor = true;
            btn_XoaTaiKhoan.Click += btn_XoaTaiKhoan_Click;
            // 
            // btn_SuaTaiKhoan
            // 
            btn_SuaTaiKhoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_SuaTaiKhoan.Location = new Point(6, 74);
            btn_SuaTaiKhoan.Name = "btn_SuaTaiKhoan";
            btn_SuaTaiKhoan.Size = new Size(210, 42);
            btn_SuaTaiKhoan.TabIndex = 4;
            btn_SuaTaiKhoan.Text = "Cập nhật tài khoản";
            btn_SuaTaiKhoan.UseVisualStyleBackColor = true;
            btn_SuaTaiKhoan.Click += btn_SuaTaiKhoan_Click;
            // 
            // btn_TaoTaiKhoan
            // 
            btn_TaoTaiKhoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_TaoTaiKhoan.Location = new Point(6, 26);
            btn_TaoTaiKhoan.Name = "btn_TaoTaiKhoan";
            btn_TaoTaiKhoan.Size = new Size(210, 42);
            btn_TaoTaiKhoan.TabIndex = 0;
            btn_TaoTaiKhoan.Text = "Thêm tài khoản";
            btn_TaoTaiKhoan.UseVisualStyleBackColor = true;
            btn_TaoTaiKhoan.Click += btn_TaoTaiKhoan_Click;
            // 
            // dgv_DSSinhVien
            // 
            dgv_DSSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DSSinhVien.Location = new Point(6, 26);
            dgv_DSSinhVien.Name = "dgv_DSSinhVien";
            dgv_DSSinhVien.RowHeadersWidth = 51;
            dgv_DSSinhVien.Size = new Size(535, 212);
            dgv_DSSinhVien.TabIndex = 2;
            dgv_DSSinhVien.CellDoubleClick += dgv_DSSinhVien_CellDoubleClick;
            // 
            // grb_DSSinhVien
            // 
            grb_DSSinhVien.Controls.Add(btn_TaiLai);
            grb_DSSinhVien.Controls.Add(btn_DSTaiKhoan);
            grb_DSSinhVien.Controls.Add(dgv_DSSinhVien);
            grb_DSSinhVien.Location = new Point(241, 146);
            grb_DSSinhVien.Name = "grb_DSSinhVien";
            grb_DSSinhVien.Size = new Size(547, 292);
            grb_DSSinhVien.TabIndex = 2;
            grb_DSSinhVien.TabStop = false;
            grb_DSSinhVien.Text = "Danh sách sinh viên";
            // 
            // btn_TaiLai
            // 
            btn_TaiLai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_TaiLai.Location = new Point(6, 244);
            btn_TaiLai.Name = "btn_TaiLai";
            btn_TaiLai.Size = new Size(91, 42);
            btn_TaiLai.TabIndex = 6;
            btn_TaiLai.Text = "Tải lại";
            btn_TaiLai.UseVisualStyleBackColor = true;
            btn_TaiLai.Click += btn_TaiLai_Click;
            // 
            // btn_DSTaiKhoan
            // 
            btn_DSTaiKhoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_DSTaiKhoan.Location = new Point(331, 244);
            btn_DSTaiKhoan.Name = "btn_DSTaiKhoan";
            btn_DSTaiKhoan.Size = new Size(210, 42);
            btn_DSTaiKhoan.TabIndex = 6;
            btn_DSTaiKhoan.Text = "Danh sách tài khoản";
            btn_DSTaiKhoan.UseVisualStyleBackColor = true;
            btn_DSTaiKhoan.Click += btn_DSTaiKhoan_Click;
            // 
            // btn_DangXuat
            // 
            btn_DangXuat.BackColor = Color.Red;
            btn_DangXuat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_DangXuat.ForeColor = SystemColors.Control;
            btn_DangXuat.Location = new Point(12, 392);
            btn_DangXuat.Name = "btn_DangXuat";
            btn_DangXuat.Size = new Size(223, 46);
            btn_DangXuat.TabIndex = 3;
            btn_DangXuat.Text = "Đăng xuất";
            btn_DangXuat.UseVisualStyleBackColor = false;
            btn_DangXuat.Click += btn_DangXuat_Click;
            // 
            // grb_TimKiem
            // 
            grb_TimKiem.Controls.Add(btn_TimKiemNangCao);
            grb_TimKiem.Controls.Add(tb_TimMSSV);
            grb_TimKiem.Controls.Add(btn_TimMSSV);
            grb_TimKiem.Controls.Add(lb_TimMSSV);
            grb_TimKiem.Location = new Point(12, 67);
            grb_TimKiem.Name = "grb_TimKiem";
            grb_TimKiem.Size = new Size(776, 73);
            grb_TimKiem.TabIndex = 3;
            grb_TimKiem.TabStop = false;
            grb_TimKiem.Text = "Chức năng tìm kiếm";
            // 
            // btn_TimKiemNangCao
            // 
            btn_TimKiemNangCao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_TimKiemNangCao.Location = new Point(560, 23);
            btn_TimKiemNangCao.Name = "btn_TimKiemNangCao";
            btn_TimKiemNangCao.Size = new Size(210, 41);
            btn_TimKiemNangCao.TabIndex = 6;
            btn_TimKiemNangCao.Text = "Tìm kiếm nâng cao";
            btn_TimKiemNangCao.UseVisualStyleBackColor = true;
            // 
            // tb_TimMSSV
            // 
            tb_TimMSSV.Location = new Point(117, 23);
            tb_TimMSSV.Name = "tb_TimMSSV";
            tb_TimMSSV.Size = new Size(236, 27);
            tb_TimMSSV.TabIndex = 6;
            // 
            // btn_TimMSSV
            // 
            btn_TimMSSV.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_TimMSSV.Location = new Point(359, 23);
            btn_TimMSSV.Name = "btn_TimMSSV";
            btn_TimMSSV.Size = new Size(77, 28);
            btn_TimMSSV.TabIndex = 5;
            btn_TimMSSV.Text = "Tìm";
            btn_TimMSSV.UseVisualStyleBackColor = true;
            btn_TimMSSV.Click += btn_TimMSSV_Click;
            // 
            // lb_TimMSSV
            // 
            lb_TimMSSV.AutoSize = true;
            lb_TimMSSV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_TimMSSV.Location = new Point(6, 23);
            lb_TimMSSV.Name = "lb_TimMSSV";
            lb_TimMSSV.Size = new Size(105, 28);
            lb_TimMSSV.TabIndex = 0;
            lb_TimMSSV.Text = "Tìm MSSV:";
            // 
            // frm_admin_QuanLy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_DangXuat);
            Controls.Add(grb_TimKiem);
            Controls.Add(grb_DSSinhVien);
            Controls.Add(grb_QuanLy);
            Controls.Add(lb_TieuDe);
            Name = "frm_admin_QuanLy";
            Text = "Quản lý tài khoản";
            Load += frm_admin_QuanLy_Load;
            grb_QuanLy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_DSSinhVien).EndInit();
            grb_DSSinhVien.ResumeLayout(false);
            grb_TimKiem.ResumeLayout(false);
            grb_TimKiem.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_TieuDe;
        private GroupBox grb_QuanLy;
        private Button btn_XoaTaiKhoan;
        private Button btn_SuaTaiKhoan;
        private Button btn_DangXuat;
        private Button btn_TaoTaiKhoan;
        private DataGridView dgv_DSSinhVien;
        private GroupBox grb_DSSinhVien;
        private GroupBox grb_TimKiem;
        private Label lb_TimMSSV;
        private TextBox tb_TimMSSV;
        private Button btn_TimMSSV;
        private Button btn_TimKiemNangCao;
        private Button btn_DSTaiKhoan;
        private Button btn_TaiLai;
    }
}