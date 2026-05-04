using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UngDungQuanLyHoSoSinhVien.admin
{
    public partial class frm_admin_DanhSachTaiKhoan : Form
    {
        public frm_admin_DanhSachTaiKhoan()
        {
            InitializeComponent();

            XuLyTaiKhoan TK = new XuLyTaiKhoan();

            TK.HienThi_DS_TaiKhoan(dgv_DSSinhVien);
        }
    }
}
