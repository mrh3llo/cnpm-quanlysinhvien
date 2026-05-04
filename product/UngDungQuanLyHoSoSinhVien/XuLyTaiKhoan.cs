using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace UngDungQuanLyHoSoSinhVien
{
    internal class XuLyTaiKhoan
    {
        KetNoi KN = new KetNoi();
        DataTable BangTaiKhoan = new DataTable();

        public void HienThi_DS_TaiKhoan(DataGridView dgv)
        {
            string SQL_Query = "SELECT * FROM SinhVien";
            BangTaiKhoan = KN.GhiDuLieuVaoBang(SQL_Query);
            dgv.DataSource = BangTaiKhoan;
        }
    }
}
