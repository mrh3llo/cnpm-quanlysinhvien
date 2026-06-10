namespace UngDungQuanLyHoSoSinhVien
{
    partial class frm_NhapIP
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
            btn_XacNhan = new Button();
            tb_IP = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_XacNhan
            // 
            btn_XacNhan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_XacNhan.Location = new Point(100, 133);
            btn_XacNhan.Name = "btn_XacNhan";
            btn_XacNhan.Size = new Size(130, 50);
            btn_XacNhan.TabIndex = 0;
            btn_XacNhan.Text = "Xác nhận";
            btn_XacNhan.UseVisualStyleBackColor = true;
            btn_XacNhan.Click += btn_XacNhan_Click;
            // 
            // tb_IP
            // 
            tb_IP.Location = new Point(40, 100);
            tb_IP.Name = "tb_IP";
            tb_IP.Size = new Size(250, 27);
            tb_IP.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 9);
            label1.Name = "label1";
            label1.Size = new Size(244, 38);
            label1.TabIndex = 2;
            label1.Text = "NHẬP ĐỊA CHỈ IP";
            // 
            // frm_NhapIP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 303);
            Controls.Add(label1);
            Controls.Add(tb_IP);
            Controls.Add(btn_XacNhan);
            Name = "frm_NhapIP";
            Text = "Nhập địa chỉ IP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_XacNhan;
        private TextBox tb_IP;
        private Label label1;
    }
}