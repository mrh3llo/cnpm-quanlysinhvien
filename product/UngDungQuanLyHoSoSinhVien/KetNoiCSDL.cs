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
        public SqlConnection SQL_KetNoi;
        public SqlDataAdapter SQL_DocGhi;
        public SqlCommand SQL_Lenh;
        public DataSet BoDuLieu;

        public KetNoiCSDL()
        {
            // Kiểm tra chuỗi kết nối trước khi sử dụng
            // string ChuoiKetNoi = @"Data Source=DESKTOP-R2H1EQQ;Initial Catalog=QuanLyHoSoSinhVien;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True;";
            string ChuoiKetNoiDocker = @"Server=172.240.6.67,1401;Database=QuanLyHoSoSinhVien;User Id=sa;Password=Ql_Hssv123;Encrypt=False;TrustServerCertificate=False;";
            SQL_KetNoi = new SqlConnection(ChuoiKetNoiDocker);
        }

        public DataTable GhiDuLieuVaoBang(string SQL_TruyVan)
        {
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