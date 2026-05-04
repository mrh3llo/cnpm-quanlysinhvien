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
            btn_CapNhatTT = new Button();
            btn_ChiTietTT = new Button();
            dgv_DSSinhVien = new DataGridView();
            lb_TieuDe = new Label();
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
            grb_ChucNang.Controls.Add(btn_CapNhatTT);
            grb_ChucNang.Controls.Add(btn_ChiTietTT);
            grb_ChucNang.Location = new Point(12, 68);
            grb_ChucNang.Name = "grb_ChucNang";
            grb_ChucNang.Size = new Size(420, 121);
            grb_ChucNang.TabIndex = 7;
            grb_ChucNang.TabStop = false;
            grb_ChucNang.Text = "Chức năng:";
            // 
            // btn_CapNhatTT
            // 
            btn_CapNhatTT.BackColor = SystemColors.Control;
            btn_CapNhatTT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_CapNhatTT.ForeColor = SystemColors.ControlText;
            btn_CapNhatTT.Location = new Point(215, 26);
            btn_CapNhatTT.Name = "btn_CapNhatTT";
            btn_CapNhatTT.Size = new Size(199, 44);
            btn_CapNhatTT.TabIndex = 5;
            btn_CapNhatTT.Text = "Cập nhật thông tin";
            btn_CapNhatTT.UseVisualStyleBackColor = false;
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
            // 
            // dgv_DSSinhVien
            // 
            dgv_DSSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DSSinhVien.Location = new Point(12, 195);
            dgv_DSSinhVien.Name = "dgv_DSSinhVien";
            dgv_DSSinhVien.RowHeadersWidth = 51;
            dgv_DSSinhVien.Size = new Size(776, 245);
            dgv_DSSinhVien.TabIndex = 6;
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
            // frm_GiangVien_DS_SinhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
        private Button btn_CapNhatTT;
        private Button btn_ChiTietTT;
        private DataGridView dgv_DSSinhVien;
        private Label lb_TieuDe;
    }
}