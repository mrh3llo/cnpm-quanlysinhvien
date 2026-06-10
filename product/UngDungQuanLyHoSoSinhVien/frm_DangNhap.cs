using System.Data;
using UngDungQuanLyHoSoSinhVien.admin;

namespace UngDungQuanLyHoSoSinhVien
{
    public partial class frm_DangNhap : Form
    {
        private string TenTaiKhoan;
        private string MatKhau;
        private byte VaiTro;

        public frm_DangNhap()
        {
            InitializeComponent();
            this.VaiTro = 0; // Vai trò mặc định là 0 (chưa xác định)
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            this.TenTaiKhoan = this.tb_TenTaiKhoan.Text;
            this.MatKhau = this.tb_MatKhau.Text;

            string SQL_Query = $"SELECT * FROM TaiKhoanNguoiDung WHERE TenTaiKhoan = N'{TenTaiKhoan}';";

            // Lấy thông tin tài khoản và kiểm tra nếu có dữ liệu trả về
            DataRow TaiKhoan = new KetNoiCSDL().ThaoTac_DocMotDong_DuLieu(SQL_Query);

            try
            {
                this.VaiTro = byte.Parse(TaiKhoan.Field<byte>("VaiTro").ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xác định vai trò: " + ex.Message, "Lỗi");
                return;
                this.VaiTro = 0; // Đặt lại vai trò về 0 nếu có lỗi
            }

            try
            {
                if (TaiKhoan != null)
                {
                    // Kiểm tra mật khẩu đăng nhập
                    if (MatKhau == TaiKhoan.Field<string>("MatKhau"))
                    {
                        MessageBox.Show("Đăng nhập thành công!", "Đăng nhập thành công");
                        this.Hide();

                        switch (this.VaiTro)
                        {
                            case 1:
                                admin.frm_admin_QuanLy frm_admin = new admin.frm_admin_QuanLy(this.VaiTro);
                                frm_admin.Show();
                                break;

                            case 2:
                                CanBo.frm_CanBo_QuanLy frm_CanBo = new CanBo.frm_CanBo_QuanLy(this.VaiTro);
                                frm_CanBo.Show();
                                break;

                            case 3:
                                GiangVien.frm_GiangVien_DS_SinhVien frm_GiangVien = new GiangVien.frm_GiangVien_DS_SinhVien(this.VaiTro);
                                frm_GiangVien.ShowDialog();
                                break;

                            case 4:
                                SinhVien.frm_SinhVien_ThongTinCaNhan frm_TTSV = new SinhVien.frm_SinhVien_ThongTinCaNhan(this.VaiTro, tb_TenTaiKhoan.Text.ToString());
                                frm_TTSV.ShowDialog();
                                break;
                        }

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
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL! " + ex.Message, "Lỗi");
                this.VaiTro = 0; // Đặt lại vai trò về 0 nếu có lỗi
            }
        }

        private void btn_NhapLai_Click(object sender, EventArgs e)
        {
            this.tb_TenTaiKhoan.Clear();
            this.tb_MatKhau.Clear();
        }
    }
}
