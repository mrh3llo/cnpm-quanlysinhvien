namespace UngDungQuanLyHoSoSinhVien.CanBo
{
    partial class frm_CanBo_DanhSachTaiKhoan
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
            grb_ChucNang = new GroupBox();
            btn_CapNhatTT = new Button();
            btn_XoaTaiKhoan = new Button();
            btn_ChiTietTT = new Button();
            dgv_DSSinhVien = new DataGridView();
            lb_TieuDe = new Label();
            btn_TimMSSV = new Button();
            tb_TimMSSV = new TextBox();
            btn_Thoat = new Button();
            grb_TimMSSV = new GroupBox();
            grb_ChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DSSinhVien).BeginInit();
            grb_TimMSSV.SuspendLayout();
            SuspendLayout();
            // 
            // grb_ChucNang
            // 
            grb_ChucNang.Controls.Add(btn_CapNhatTT);
            grb_ChucNang.Controls.Add(btn_XoaTaiKhoan);
            grb_ChucNang.Controls.Add(btn_ChiTietTT);
            grb_ChucNang.Location = new Point(12, 56);
            grb_ChucNang.Name = "grb_ChucNang";
            grb_ChucNang.Size = new Size(420, 121);
            grb_ChucNang.TabIndex = 74;
            grb_ChucNang.TabStop = false;
            grb_ChucNang.Text = "Chức năng:";
            // 
            // btn_CapNhatTT
            // 
            btn_CapNhatTT.BackColor = SystemColors.Control;
            btn_CapNhatTT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_CapNhatTT.ForeColor = SystemColors.ControlText;
            btn_CapNhatTT.Location = new Point(215, 71);
            btn_CapNhatTT.Name = "btn_CapNhatTT";
            btn_CapNhatTT.Size = new Size(199, 44);
            btn_CapNhatTT.TabIndex = 5;
            btn_CapNhatTT.Text = "Cập nhật thông tin";
            btn_CapNhatTT.UseVisualStyleBackColor = false;
            btn_CapNhatTT.Click += btn_CapNhatTT_Click;
            // 
            // btn_XoaTaiKhoan
            // 
            btn_XoaTaiKhoan.BackColor = Color.Red;
            btn_XoaTaiKhoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_XoaTaiKhoan.ForeColor = SystemColors.ButtonHighlight;
            btn_XoaTaiKhoan.Location = new Point(6, 71);
            btn_XoaTaiKhoan.Name = "btn_XoaTaiKhoan";
            btn_XoaTaiKhoan.Size = new Size(199, 44);
            btn_XoaTaiKhoan.TabIndex = 1;
            btn_XoaTaiKhoan.Text = "Xóa tài khoản";
            btn_XoaTaiKhoan.UseVisualStyleBackColor = false;
            btn_XoaTaiKhoan.Click += btn_XoaTaiKhoan_Click;
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
            dgv_DSSinhVien.Location = new Point(12, 183);
            dgv_DSSinhVien.Name = "dgv_DSSinhVien";
            dgv_DSSinhVien.RowHeadersWidth = 51;
            dgv_DSSinhVien.Size = new Size(776, 245);
            dgv_DSSinhVien.TabIndex = 73;
            dgv_DSSinhVien.CellContentDoubleClick += dgv_DSSinhVien_CellContentDoubleClick;
            // 
            // lb_TieuDe
            // 
            lb_TieuDe.AutoSize = true;
            lb_TieuDe.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_TieuDe.Location = new Point(194, -1);
            lb_TieuDe.Name = "lb_TieuDe";
            lb_TieuDe.Size = new Size(404, 54);
            lb_TieuDe.TabIndex = 72;
            lb_TieuDe.Text = "Danh sách tài khoản";
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
            // btn_Thoat
            // 
            btn_Thoat.BackColor = Color.Red;
            btn_Thoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Thoat.ForeColor = Color.White;
            btn_Thoat.Location = new Point(656, 434);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(132, 52);
            btn_Thoat.TabIndex = 76;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = false;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // grb_TimMSSV
            // 
            grb_TimMSSV.Controls.Add(btn_TimMSSV);
            grb_TimMSSV.Controls.Add(tb_TimMSSV);
            grb_TimMSSV.Location = new Point(438, 56);
            grb_TimMSSV.Name = "grb_TimMSSV";
            grb_TimMSSV.Size = new Size(350, 121);
            grb_TimMSSV.TabIndex = 75;
            grb_TimMSSV.TabStop = false;
            grb_TimMSSV.Text = "Tìm MSSV:";
            // 
            // frm_CanBo_DanhSachTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 493);
            Controls.Add(grb_ChucNang);
            Controls.Add(dgv_DSSinhVien);
            Controls.Add(lb_TieuDe);
            Controls.Add(btn_Thoat);
            Controls.Add(grb_TimMSSV);
            Name = "frm_CanBo_DanhSachTaiKhoan";
            Text = "Danh sách tài khoản";
            grb_ChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_DSSinhVien).EndInit();
            grb_TimMSSV.ResumeLayout(false);
            grb_TimMSSV.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grb_ChucNang;
        private Button btn_CapNhatTT;
        private Button btn_XoaTaiKhoan;
        private Button btn_ChiTietTT;
        private DataGridView dgv_DSSinhVien;
        private Label lb_TieuDe;
        private Button btn_TimMSSV;
        private TextBox tb_TimMSSV;
        private Button btn_Thoat;
        private GroupBox grb_TimMSSV;
    }
}