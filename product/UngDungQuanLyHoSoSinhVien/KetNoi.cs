using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace UngDungQuanLyHoSoSinhVien
{
    public class KetNoi
    {
        public SqlConnection SQL_KetNoi;
        public SqlDataAdapter SQL_DocGhi;
        public SqlCommand SQL_Lenh;
        public DataSet BoDuLieu;

        public KetNoi()
        {
            string ChuoiKetNoi = @"Data Source=DESKTOP-9K7QG8P\SQLEXPRESS;Initial Catalog=QLHSSV;Integrated Security=True";
            SQL_KetNoi = new SqlConnection(ChuoiKetNoi);
        }

        public DataTable GhiDuLieuVaoBang(string SQL_Query)
        {
            SQL_KetNoi.Open();
            SQL_DocGhi = new SqlDataAdapter(SQL_Query, SQL_KetNoi);
            DataTable Bang = new DataTable();
            SQL_DocGhi.Fill(Bang);
            SQL_KetNoi.Close();
            return Bang;
        }

        public void ThaoTacDuLieu(string SQL_Query)
        {
            SQL_KetNoi.Open();
            SQL_Lenh = new SqlCommand(SQL_Query, SQL_KetNoi);
            SQL_Lenh.ExecuteNonQuery();
            SQL_KetNoi.Close();
        }
    }
}