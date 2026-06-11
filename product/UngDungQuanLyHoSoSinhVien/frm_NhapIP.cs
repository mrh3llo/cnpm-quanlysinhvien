using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UngDungQuanLyHoSoSinhVien
{
    public partial class frm_NhapIP : Form
    {
        public string EnteredHost { get; private set; }

        public frm_NhapIP(string currentHost = "")
        {
            InitializeComponent();
            tb_IP.Text = currentHost;
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            string input = tb_IP.Text.Trim();
            if (KiemTra(input))
            {
                EnteredHost = input;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Địa chỉ IP/hostname không hợp lệ. Vui lòng kiểm tra lại.", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool KiemTra(string host)
        {
            if (string.IsNullOrWhiteSpace(host)) return false;

            // Kiểm tra IP v4 đơn giản
            var KiemTraIP = @"^((25[0-5]|2[0-4]\d|[01]?\d\d?)\.){3}(25[0-5]|2[0-4]\d|[01]?\d\d?)$";
            if (Regex.IsMatch(host, KiemTraIP)) return true;

            // Kiểm tra hostname hợp lệ (tên máy, domain)
            var KiemTraTenHost = @"^[a-zA-Z0-9\-\.]+$";
            return Regex.IsMatch(host, KiemTraTenHost);
        }
    }
}
