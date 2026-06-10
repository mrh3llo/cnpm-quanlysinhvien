using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace UngDungQuanLyHoSoSinhVien
{
    public class KetNoiCSDL
    {
        private string IP => Properties.Settings.Default.DbHost ?? string.Empty;
        private const int SqlPort = 1401;

        public SqlConnection SQL_KetNoi;
        public SqlDataAdapter SQL_DocGhi;
        public SqlCommand SQL_Lenh;
        public DataSet BoDuLieu;

        public KetNoiCSDL()
        {
            KetNoiLai();
        }

        private string KhoiTaoChuoiKetNoi()
        {
            // Không lưu password vào settings; giữ nguyên mật khẩu cứng trong code như trước (nếu cần thay đổi, cân nhắc bảo mật)
            return $@"Server={IP},{SqlPort};Database=QuanLyHoSoSinhVien;User Id=sa;Password=Ql_Hssv123;Encrypt=False;TrustServerCertificate=False;";
        }

        private void KetNoiLai()
        {
            string ChuoiKetNoi = KhoiTaoChuoiKetNoi();
            SQL_KetNoi = new SqlConnection(ChuoiKetNoi);
        }

        private bool DamBaoKetNoi()
        {
            // Nếu IP rỗng, yêu cầu nhập
            if (string.IsNullOrWhiteSpace(IP))
            {
                if (!NhapLaiDiaChiIP()) return false;
            }

            // Tạo lại connection string mỗi lần (nếu IP thay đổi)
            KetNoiLai();

            try
            {
                SQL_KetNoi.Open();
                SQL_KetNoi.Close();
                return true;
            }
            catch (SqlException)
            {
                // Thử hiển thị form nhập IP để người dùng sửa
                bool ok = NhapLaiDiaChiIP();
                if (ok)
                {
                    KetNoiLai();
                    try
                    {
                        SQL_KetNoi.Open();
                        SQL_KetNoi.Close();
                        return true;
                    }
                    catch (Exception)
                    {
                        // Nếu vẫn lỗi, trả false (không show lỗi chi tiết theo yêu cầu)
                        return false;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool NhapLaiDiaChiIP()
        {
            using (frm_NhapIP frm_IP = new frm_NhapIP(IP))
            {
                DialogResult HienThiLoi = frm_IP.ShowDialog();
                if (HienThiLoi == DialogResult.OK)
                {
                    string Host_Moi = frm_IP.EnteredHost;
                    // Thử kết nối tạm thời với host mới
                    string KiemTraChuoiKetNoi = $@"Server={Host_Moi},{SqlPort};Database=master;User Id=sa;Password=Ql_Hssv123;Encrypt=False;TrustServerCertificate=False;Connection Timeout=5;";
                    using (var KetmTraKetNoi = new SqlConnection(KiemTraChuoiKetNoi))
                    {
                        try
                        {
                            KetmTraKetNoi.Open();
                            KetmTraKetNoi.Close();

                            // Nếu thành công, lưu setting và return true
                            Properties.Settings.Default.DbHost = Host_Moi;
                            Properties.Settings.Default.Save();
                            return true;
                        }
                        catch
                        {
                            MessageBox.Show("Không thể kết nối tới địa chỉ vừa nhập. Vui lòng kiểm tra và thử lại.", "Kết nối thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                }
                else
                {
                    // Người dùng hủy
                    return false;
                }
            }
        }

        public DataTable GhiDuLieuVaoBang(string SQL_TruyVan)
        {
            if (!DamBaoKetNoi()) return null;

            try
            {
                SQL_KetNoi.Open();

                SQL_DocGhi = new SqlDataAdapter(SQL_TruyVan, SQL_KetNoi);
                DataTable Bang = new DataTable();
                SQL_DocGhi.Fill(Bang);
                SQL_KetNoi.Close();
                return Bang;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc dữ liệu: " + ex.Message, "Lỗi");
                return new DataTable();
            }
        }

        public void ThaoTac_Ghi_DuLieu(string SQL_TruyVan)
        {
            if (!DamBaoKetNoi()) return;

            try
            {
                SQL_KetNoi.Open();

                SQL_Lenh = new SqlCommand(SQL_TruyVan, SQL_KetNoi);
                SQL_Lenh.ExecuteNonQuery();
                SQL_KetNoi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc dữ liệu: " + ex.Message, "Lỗi");
            }
        }

        public DataRow ThaoTac_DocMotDong_DuLieu(string SQL_TruyVan)
        {
            if (!DamBaoKetNoi()) return null;

            DataTable Bang = new DataTable();

            try
            {
                SQL_KetNoi.Open();

                SqlCommand SQL_Lenh = new SqlCommand(SQL_TruyVan, SQL_KetNoi);
                SqlDataAdapter SQL_DocGhi = new SqlDataAdapter(SQL_Lenh);

                SQL_DocGhi.Fill(Bang);

                SQL_KetNoi.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc dữ liệu: " + ex.Message, "Lỗi");
            }

            return Bang.Rows.Count > 0 ? Bang.Rows[0] : null;
        }
    }
}