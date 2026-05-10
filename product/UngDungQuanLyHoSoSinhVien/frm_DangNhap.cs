using System.Data;

namespace UngDungQuanLyHoSoSinhVien
{
    public partial class frm_DangNhap : Form
    {
        private string TenTaiKhoan;
        private string MatKhau;
        private byte VaiTro = 1;

        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            this.TenTaiKhoan = this.tb_TenTaiKhoan.Text;
            this.MatKhau = this.tb_MatKhau.Text;

            string SQL_Query = $"USE QuanLyHoSoSinhVien; SELECT * FROM TaiKhoanNguoiDung WHERE TenTaiKhoan = N'{TenTaiKhoan}';";
            
            // Lấy thông tin tài khoản và kiểm tra nếu có dữ liệu trả về
            DataRow TaiKhoan = new KetNoiCSDL().ThaoTac_DocMotDong_DuLieu(SQL_Query);

            if(TaiKhoan != null)
            {
                // Kiểm tra mật khẩu đăng nhập
                if(MatKhau == TaiKhoan.Field<string>("MatKhau"))
                {
                    MessageBox.Show("Đăng nhập thành công!", "Đăng nhập thành công");
                    this.VaiTro = TaiKhoan.Field<byte>("VaiTro");
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại mật khẩu!", "Đăng nhập thất bại");
                    this.VaiTro = 0;
                }
            }
            else
                MessageBox.Show("Vui lòng kiểm tra lại tên tài khoản! Hoặc tài khoản không tồn tại", "Đăng nhập thất bại");
        }

        private void btn_NhapLai_Click(object sender, EventArgs e)
        {
            this.tb_TenTaiKhoan.Clear();
            this.tb_MatKhau.Clear();
        }

        public byte layVaiTro()
        {
            return this.VaiTro;
        }

        public void datVaiTro(byte TrangThai)
        {
            this.VaiTro = TrangThai;
        }
    }
}
