namespace UngDungQuanLyHoSoSinhVien.SinhVien
{
    partial class frm_SinhVien_LichSuGuiYeuCauCapNhat
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
            dgv_LichSuYeuCauCapNhat = new DataGridView();
            lb_Tong_YCKhongDuyet = new Label();
            lb_Tong_YCDuyet = new Label();
            lb_Tong_YC = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_LichSuYeuCauCapNhat).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(117, 9);
            label1.Name = "label1";
            label1.Size = new Size(556, 54);
            label1.TabIndex = 0;
            label1.Text = "Lịch sử gửi yêu cầu cập nhật";
            // 
            // dgv_LichSuYeuCauCapNhat
            // 
            dgv_LichSuYeuCauCapNhat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_LichSuYeuCauCapNhat.Location = new Point(12, 193);
            dgv_LichSuYeuCauCapNhat.Name = "dgv_LichSuYeuCauCapNhat";
            dgv_LichSuYeuCauCapNhat.RowHeadersWidth = 51;
            dgv_LichSuYeuCauCapNhat.Size = new Size(776, 245);
            dgv_LichSuYeuCauCapNhat.TabIndex = 1;
            // 
            // lb_Tong_YCKhongDuyet
            // 
            lb_Tong_YCKhongDuyet.AutoSize = true;
            lb_Tong_YCKhongDuyet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Tong_YCKhongDuyet.Location = new Point(12, 134);
            lb_Tong_YCKhongDuyet.Name = "lb_Tong_YCKhongDuyet";
            lb_Tong_YCKhongDuyet.Size = new Size(269, 28);
            lb_Tong_YCKhongDuyet.TabIndex = 4;
            lb_Tong_YCKhongDuyet.Text = "Yêu cầu không được duyệt:";
            // 
            // lb_Tong_YCDuyet
            // 
            lb_Tong_YCDuyet.AutoSize = true;
            lb_Tong_YCDuyet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Tong_YCDuyet.Location = new Point(12, 106);
            lb_Tong_YCDuyet.Name = "lb_Tong_YCDuyet";
            lb_Tong_YCDuyet.Size = new Size(204, 28);
            lb_Tong_YCDuyet.TabIndex = 5;
            lb_Tong_YCDuyet.Text = "Yêu cầu được duyệt:";
            // 
            // lb_Tong_YC
            // 
            lb_Tong_YC.AutoSize = true;
            lb_Tong_YC.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Tong_YC.Location = new Point(12, 78);
            lb_Tong_YC.Name = "lb_Tong_YC";
            lb_Tong_YC.Size = new Size(144, 28);
            lb_Tong_YC.TabIndex = 6;
            lb_Tong_YC.Text = "Tổng yêu cầu:";
            // 
            // frm_LichSuGuiYeuCauCapNhat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lb_Tong_YC);
            Controls.Add(lb_Tong_YCDuyet);
            Controls.Add(lb_Tong_YCKhongDuyet);
            Controls.Add(dgv_LichSuYeuCauCapNhat);
            Controls.Add(label1);
            Name = "frm_LichSuGuiYeuCauCapNhat";
            Text = "Lịch sử gửi yêu cầu cập nhật";
            ((System.ComponentModel.ISupportInitialize)dgv_LichSuYeuCauCapNhat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgv_LichSuYeuCauCapNhat;
        private Label label2;
        private Label label3;
        private Label lb_Tong_YCKhongDuyet;
        private Label lb_Tong_YCDuyet;
        private Label lb_Tong_YC;
    }
}