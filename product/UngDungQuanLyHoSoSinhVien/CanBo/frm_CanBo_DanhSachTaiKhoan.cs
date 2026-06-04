using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using ClosedXML.Excel;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using PdfSharp.Fonts;
using PdfSharp.Pdf;
using UngDungQuanLyHoSoSinhVien.admin;

namespace UngDungQuanLyHoSoSinhVien.CanBo
{
    public partial class frm_CanBo_DanhSachTaiKhoan : Form
    {
        private byte VaiTro;

        public frm_CanBo_DanhSachTaiKhoan(byte VaiTro)
        {
            InitializeComponent();
            this.VaiTro = VaiTro;

            if (this.VaiTro == 2)
            {
                XuLyTaiKhoanSinhVien TK_SinhVien = new XuLyTaiKhoanSinhVien();
                TK_SinhVien.HienThi_DS_SinhVien(dgv_DSSinhVien);
            }
            else
            {
                this.Enabled = false;

                MessageBox.Show("Bạn không có quyền truy cập vào trang quản lý tài khoản! Vui lòng đăng nhập bằng tài khoản quản trị viên để sử dụng chức năng này.", "Quyền truy cập bị từ chối");
                this.Close();
            }
        }

        private void btn_TimMSSV_Click(object sender, EventArgs e)
        {
            XuLyTaiKhoanSinhVien TK_SinhVien = new XuLyTaiKhoanSinhVien();
            TK_SinhVien.TimMaSV(tb_TimMSSV.Text.ToString());
        }

        private void btn_ChiTietTT_Click(object sender, EventArgs e)
        {
            int dong = dgv_DSSinhVien.CurrentCell.RowIndex;

            XuLyTaiKhoanSinhVien TK_SinhVien = new XuLyTaiKhoanSinhVien();
            if (dong >= 0 && dong < dgv_DSSinhVien.Rows.Count)
            {
                DataRow TTSV = ((DataRowView)dgv_DSSinhVien.Rows[dong].DataBoundItem).Row;
                TK_SinhVien.HienThiChiTiet_TT_SinhVien(TTSV);
            }
        }

        private void btn_CapNhatTT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DỮ LIỆU CỦA QUÊ QUÁN XÃ PHƯỜNG CHỈ CÓ CHO 5 TỈNH ĐẦU TIÊN!!!", "NHẮC NHỎ KHI DEMO", MessageBoxButtons.OK);

            int dong = dgv_DSSinhVien.CurrentCell.RowIndex;

            frm_CanBo_DienThongTin frm_DienTT = new frm_CanBo_DienThongTin(this.VaiTro);
            frm_DienTT.datTrangThai(1);

            if (dong >= 0 && dong < dgv_DSSinhVien.Rows.Count)
            {
                DataRow TTSV = ((DataRowView)dgv_DSSinhVien.Rows[dong].DataBoundItem).Row;

                frm_DienTT.datMaSV(TTSV["MaSV"].ToString());

                frm_DienTT.tb_HoTen.Text = TTSV["HoTen"].ToString();
                frm_DienTT.cmb_GioiTinh.SelectedItem = TTSV["GioiTinh"].ToString();
                frm_DienTT.date_NgaySinh.Value = DateTime.Parse(TTSV["NgaySinh"].ToString());
                frm_DienTT.tb_SDT.Text = TTSV["SDT"].ToString();
                frm_DienTT.tb_Email.Text = TTSV["Email"].ToString();
                frm_DienTT.tb_DiaChi.Text = TTSV["DiaChiThuongTru"].ToString();

                frm_DienTT.cmb_DanToc.SelectedText = TTSV["DanToc"].ToString();
                frm_DienTT.cmb_TonGiao.SelectedText = TTSV["TonGiao"].ToString();
                frm_DienTT.cmb_NoiSinh.SelectedText = TTSV["NoiSinh"].ToString();
                frm_DienTT.cmb_QQ_TinhThanh.SelectedText = TTSV["QQ_TinhThanh"].ToString();
                frm_DienTT.cmb_QQ_XaPhuong.SelectedText = TTSV["QQ_XaPhuong"].ToString();

                frm_DienTT.tb_SoCCCD.Text = TTSV["SoCCCD"].ToString();
                frm_DienTT.cmb_KhoaTruong.SelectedText = TTSV["Khoa_Truong"].ToString();
                frm_DienTT.cmb_Nganh.SelectedText = TTSV["Nganh"].ToString();
                frm_DienTT.cmb_Lop.SelectedText = TTSV["Lop"].ToString();
                frm_DienTT.tb_NienKhoa.Text = TTSV["NienKhoa"].ToString();
                frm_DienTT.cmb_TrangThai.SelectedText = TTSV["TrangThai"].ToString();

                frm_DienTT.ShowDialog();
            }
            else
                MessageBox.Show("Không tìm thấy thông tin chi tiết của sinh viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgv_DSSinhVien_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            XuLyTaiKhoanSinhVien TK_SinhVien = new XuLyTaiKhoanSinhVien();
            if (e.RowIndex >= 0 && e.RowIndex < dgv_DSSinhVien.Rows.Count)
            {
                DataRow TTSV = ((DataRowView)dgv_DSSinhVien.Rows[e.RowIndex].DataBoundItem).Row;
                TK_SinhVien.TimMaSV(TTSV["MaSV"].ToString());
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_XuatDanhSach_Click(object sender, EventArgs e)
        {
            if (dgv_DSSinhVien.Rows.Count == 0 || dgv_DSSinhVien.Columns.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable Bang = LayDuLieuTuBang(dgv_DSSinhVien);

            MessageBox.Show("Đang chuẩn bị cho quá trình xuất dữ liệu!", "Thông báo", MessageBoxButtons.OK);

            using (SaveFileDialog LuuTepTin = new SaveFileDialog())
            {
                LuuTepTin.Title = "Lưu danh sách sinh viên";
                LuuTepTin.FileName = "DanhSachSinhVien";
                LuuTepTin.Filter = "Excel Workbook (*.xlsx)|*.xlsx|PDF File (*.pdf)|*.pdf";
                LuuTepTin.DefaultExt = "xlsx";
                LuuTepTin.AddExtension = true;
                if (LuuTepTin.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    string ext = Path.GetExtension(LuuTepTin.FileName).ToLowerInvariant();

                    if (ext == ".xlsx")
                    {
                        XuatExcel(Bang, LuuTepTin.FileName);
                        MessageBox.Show("Xuất Excel thành công.", "Hoàn tất",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (ext == ".pdf")
                    {
                        XuatPDF(Bang, LuuTepTin.FileName);
                        MessageBox.Show("Xuất PDF thành công.", "Hoàn tất",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng lưu với đuôi .xlsx hoặc .pdf.", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất file: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private DataTable LayDuLieuTuBang(DataGridView dgv)
        {
            DataTable Bang = new DataTable();

            // Chỉ lấy cột đang hiển thị
            foreach (DataGridViewColumn Cot in dgv.Columns)
            {
                if (!Cot.Visible) continue;
                Bang.Columns.Add(Cot.HeaderText, typeof(object));
            }

            foreach (DataGridViewRow Hang in dgv.Rows)
            {
                if (Hang.IsNewRow) continue;

                DataRow BangGhi = Bang.NewRow();
                int i = 0;

                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    if (!col.Visible) continue;
                    BangGhi[i++] = Hang.Cells[col.Index].Value ?? DBNull.Value;
                }

                Bang.Rows.Add(BangGhi);
            }

            return Bang;
        }

        private void XuatExcel(DataTable Bang, string DuongDanTepTin)
        {
            // Sắp xếp A-Z theo cột tên nếu tìm thấy
            string TenCot = TimCotDungNhat(Bang, "HoTen");
            if (!string.IsNullOrWhiteSpace(TenCot))
            {
                DataView HienThiDuLieu = Bang.DefaultView;
                HienThiDuLieu.Sort = $"[{TenCot}] ASC";
                Bang = HienThiDuLieu.ToTable();
            }

            using (XLWorkbook WordBook = new XLWorkbook())
            {
                IXLWorksheet WordSheet = WordBook.Worksheets.Add("Danh sách sinh viên");

                // Tiêu đề cột
                for (int Cot = 0; Cot < Bang.Columns.Count; Cot++)
                {
                    var O_DuLieu = WordSheet.Cell(1, Cot + 1);
                    O_DuLieu.Value = Bang.Columns[Cot].ColumnName;
                    O_DuLieu.Style.Font.Bold = true;
                    O_DuLieu.Style.Font.FontName = "Times New Roman";
                    O_DuLieu.Style.Font.FontSize = 13;
                    O_DuLieu.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    O_DuLieu.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    O_DuLieu.Style.Alignment.WrapText = true;
                    O_DuLieu.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                }

                // Dữ liệu
                for (int Hang = 0; Hang < Bang.Rows.Count; Hang++)
                {
                    for (int Cot = 0; Cot < Bang.Columns.Count; Cot++)
                    {
                        var O_DuLieu = WordSheet.Cell(Hang + 2, Cot + 1);
                        object value = Bang.Rows[Hang][Cot];

                        if (value == DBNull.Value || value == null)
                        {
                            O_DuLieu.Value = "";
                        }
                        else if (value is DateTime dtValue)
                        {
                            O_DuLieu.Value = dtValue;
                            O_DuLieu.Style.DateFormat.Format = "dd/MM/yyyy";
                        }
                        else
                        {
                            string text = value.ToString();

                            if (ChuanHoaThoiGian(text, out DateTime parsedDate) && LaCotThoiGian(Bang.Columns[Cot].ColumnName))
                            {
                                O_DuLieu.Value = parsedDate;
                                O_DuLieu.Style.DateFormat.Format = "dd/MM/yyyy";
                            }
                            else
                            {
                                O_DuLieu.Value = text;
                            }
                        }

                        O_DuLieu.Style.Font.FontName = "Times New Roman";
                        O_DuLieu.Style.Font.FontSize = 13;
                        O_DuLieu.Style.Alignment.WrapText = true;
                        O_DuLieu.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    }
                }

                // Đóng băng hàng tiêu đề
                WordSheet.SheetView.FreezeRows(1);

                // Tự điều chỉnh độ rộng cột
                WordSheet.Columns().AdjustToContents();
                WordSheet.Rows().AdjustToContents();
                // Tạo bảng cho dễ nhìn
                var usedRange = WordSheet.RangeUsed();
                if (usedRange != null)
                {
                    usedRange.Style.Font.FontName = "Times New Roman";
                    usedRange.Style.Font.FontSize = 13;
                    usedRange.Style.Alignment.WrapText = true;
                }

                WordBook.SaveAs(DuongDanTepTin);
            }
        }

        private void XuatPDF(DataTable Bang, string DuongDanTepTin)
        {
            GlobalFontSettings.FontResolver = new FontResolver();

            // Sắp xếp A-Z theo cột tên nếu có
            string CotTen = TimCotDungNhat(Bang, "HoTen");
            if (!string.IsNullOrWhiteSpace(CotTen))
            {
                DataView HienThiDuLieu = Bang.DefaultView;
                HienThiDuLieu.Sort = $"[{CotTen}] ASC";
                Bang = HienThiDuLieu.ToTable();
            }

            Document TaiLieu = new Document();
            TaiLieu.Info.Title = "Danh sách sinh viên";

            // Font mặc định
            Style KieuMacDinh = TaiLieu.Styles["Normal"];
            KieuMacDinh.Font.Name = "Times";
            KieuMacDinh.Font.Size = 13;

            Section sec = TaiLieu.AddSection();

            sec.PageSetup = TaiLieu.DefaultPageSetup.Clone();

            sec.PageSetup.PageFormat = PageFormat.A4;
            sec.PageSetup.Orientation = MigraDoc.DocumentObjectModel.Orientation.Landscape;

            // Ép kích thước A4 ngang
            sec.PageSetup.PageWidth = Unit.FromCentimeter(29.7);
            sec.PageSetup.PageHeight = Unit.FromCentimeter(21);

            sec.PageSetup.TopMargin = Unit.FromCentimeter(1.5);
            sec.PageSetup.BottomMargin = Unit.FromCentimeter(1.5);
            sec.PageSetup.LeftMargin = Unit.FromCentimeter(1.5);
            sec.PageSetup.RightMargin = Unit.FromCentimeter(1.5);

            // Header
            Paragraph DauTrang = sec.Headers.Primary.AddParagraph();
            DauTrang.Format.Font.Name = "Times New Roman";
            DauTrang.Format.Font.Size = 10;
            DauTrang.Format.Alignment = ParagraphAlignment.Left;
            DauTrang.AddFormattedText("Trường Kỹ thuật Công nghệ - Khoa Công nghệ Thông tin", TextFormat.Bold);
            DauTrang.AddLineBreak();
            DauTrang.AddText("Ngày xuất: " + DateTime.Now.ToString("dd/MM/yyyy"));

            // Footer
            Paragraph ChanTrang = sec.Footers.Primary.AddParagraph();
            ChanTrang.Format.Font.Name = "Times New Roman";
            ChanTrang.Format.Font.Size = 10;
            ChanTrang.Format.Alignment = ParagraphAlignment.Center;
            ChanTrang.AddText("Trang ");
            ChanTrang.AddPageField();
            ChanTrang.AddText(" / ");
            ChanTrang.AddNumPagesField();

            // Tiêu đề
            Paragraph TieuDe = sec.AddParagraph("Danh sách sinh viên");
            TieuDe.Format.Font.Name = "Times New Roman";
            TieuDe.Format.Font.Size = 16;
            TieuDe.Format.Font.Bold = true;
            TieuDe.Format.Alignment = ParagraphAlignment.Center;
            TieuDe.Format.SpaceAfter = Unit.FromCentimeter(0.4);

            // Tổng hợp
            string CotNganh = TimCotDungNhat(Bang, "Nganh");
            Paragraph TongQuan = sec.AddParagraph();
            TongQuan.Format.Font.Name = "Times New Roman";
            TongQuan.Format.Font.Size = 13;
            TongQuan.AddText($"Số SV: {Bang.Rows.Count}");
            if (!string.IsNullOrWhiteSpace(CotNganh))
            {
                TongQuan.AddLineBreak();
                TongQuan.AddText("Ngành: " + TaoTongQuanNganhHoc(Bang, CotNganh));
            }

            TongQuan.Format.SpaceAfter = Unit.FromCentimeter(0.5);

            // Bảng
            Table BangDS = sec.AddTable(); // Kiểu dữ liệu của MigraDoc
            BangDS.Borders.Width = 0.5;
            BangDS.LeftPadding = Unit.FromMillimeter(2);
            BangDS.RightPadding = Unit.FromMillimeter(2);
            BangDS.TopPadding = Unit.FromMillimeter(1.5);
            BangDS.BottomPadding = Unit.FromMillimeter(1.5);
            BangDS.Format.Font.Name = "Times New Roman";
            BangDS.Format.Font.Size = 13;

            int usableWidthMm = 265; // A4 ngang trừ lề
            double[] widths = TinhDoRongCot(Bang, usableWidthMm);

            for (int Cot = 0; Cot < Bang.Columns.Count; Cot++)
                BangDS.AddColumn(Unit.FromMillimeter(widths[Cot]));
            // Header row
            Row HangTieuDe = BangDS.AddRow();
            HangTieuDe.HeadingFormat = true;
            HangTieuDe.Shading.Color = Colors.LightGray;
            HangTieuDe.Format.Font.Bold = true;
            HangTieuDe.Format.Font.Size = 13;
            HangTieuDe.VerticalAlignment = VerticalAlignment.Center;

            for (int Cot = 0; Cot < Bang.Columns.Count; Cot++)
            {
                Paragraph DoanVanBan = HangTieuDe.Cells[Cot].AddParagraph(Bang.Columns[Cot].ColumnName);
                DoanVanBan.Format.Alignment = ParagraphAlignment.Center;
                DoanVanBan.Format.Font.Name = "Times New Roman";
                DoanVanBan.Format.Font.Size = 13;
                HangTieuDe.Cells[Cot].VerticalAlignment = VerticalAlignment.Center;
            }

            // Dòng dữ liệu
            foreach (DataRow HangDuLieu in Bang.Rows)
            {
                Row Hang = BangDS.AddRow();
                Hang.VerticalAlignment = VerticalAlignment.Top;
                Hang.TopPadding = Unit.FromMillimeter(1.5);
                Hang.BottomPadding = Unit.FromMillimeter(1.5);

                for (int c = 0; c < Bang.Columns.Count; c++)
                {
                    string text = ChuanHoaGiaTri(HangDuLieu[c]);
                    var p = Hang.Cells[c].AddParagraph(text);
                    p.Format.Font.Name = "Times New Roman";
                    p.Format.Font.Size = 13;
                    p.Format.Alignment = ParagraphAlignment.Left;
                    Hang.Cells[c].VerticalAlignment = VerticalAlignment.Top;
                }
            }

            var renderer = new PdfDocumentRenderer(unicode: true)
            {
                Document = TaiLieu
            };

            renderer.RenderDocument();
            renderer.PdfDocument.Save(DuongDanTepTin);
        }

        private string ChuanHoaGiaTri(object GiaTri)
        {
            if (GiaTri == null || GiaTri == DBNull.Value) return string.Empty;

            if (GiaTri is DateTime dt)
                return dt.ToString("dd/MM/yyyy");

            string Chuoi = GiaTri.ToString().Trim();

            if (ChuanHoaThoiGian(Chuoi, out DateTime parsed))
                return parsed.ToString("dd/MM/yyyy");

            return Chuoi;
        }

        private bool ChuanHoaThoiGian(string ThoiGian, out DateTime KetQua)
        {
            KetQua = default;

            if (string.IsNullOrWhiteSpace(ThoiGian))
                return false;

            string[] formats = new[]
            {
                "dd/MM/yyyy", "d/M/yyyy",
                "dd-MM-yyyy", "d-M-yyyy",
                "yyyy-MM-dd",
                "MM/dd/yyyy", "M/d/yyyy"
            };

            return DateTime.TryParseExact(
                ThoiGian.Trim(),
                formats,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out KetQua);
        }

        private bool LaCotThoiGian(string TenCot)
        {
            string ChuanHoa = NormalizeText(TenCot);
            return ChuanHoa.Contains("ngay") || ChuanHoa.Contains("date");
        }

        private string TimCotDungNhat(DataTable Bang, params string[] TuKhoa)
        {
            foreach (DataColumn CotDuLieu in Bang.Columns)
            {
                string ChuanHoaCot = NormalizeText(CotDuLieu.ColumnName);
                foreach (string CacTuKhoa in TuKhoa)
                {
                    if (ChuanHoaCot.Contains(NormalizeText(CacTuKhoa)))
                        return CotDuLieu.ColumnName;
                }
            }
            return null;
        }

        private string TaoTongQuanNganhHoc(DataTable Bang, string CotNganhHoc)
        {
            IEnumerable<string> Nhom = Bang.AsEnumerable()
                           .GroupBy(HangDuLieu => (HangDuLieu[CotNganhHoc] == null || HangDuLieu[CotNganhHoc] == DBNull.Value)
                               ? string.Empty
                               : HangDuLieu[CotNganhHoc].ToString().Trim())
                           .Select(g =>
                           {
                               string TuKhoa = string.IsNullOrWhiteSpace(g.Key) ? "Không rõ" : g.Key;
                               return $"{TuKhoa}: {g.Count()}";
                           });

            return string.Join("; ", Nhom);
        }

        private double[] TinhDoRongCot(DataTable Bang, double DoRongCm)
        {
            int DemSoCot = Bang.Columns.Count;
            double[] DoRong = new double[DemSoCot];

            for (int Cot = 0; Cot < DemSoCot; Cot++)
            {
                int DoDaiToiDa = Bang.Columns[Cot].ColumnName?.Length ?? 5;
                int MauDem = Math.Min(Bang.Rows.Count, 30); // Mẫu đếm

                for (int Hang = 0; Hang < MauDem; Hang++)
                {
                    string text = ChuanHoaGiaTri(Bang.Rows[Hang][Cot]);
                    if (text.Length > DoDaiToiDa) DoDaiToiDa = text.Length;
                }

                // Giới hạn để không một cột nuốt hết bảng
                DoRong[Cot] = Math.Max(6, Math.Min(DoDaiToiDa * 0.55, 18));
            }

            double Tong = DoRong.Sum();
            if (Tong <= 0)
            {
                return Enumerable.Repeat(DoRongCm / DemSoCot, DemSoCot).ToArray();
            }

            return DoRong.Select(ChieuRong => DoRongCm * ChieuRong / Tong).ToArray();
        }

        private string NormalizeText(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            string formD = input.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();

            foreach (char c in formD)
            {
                UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(c);
                if (uc != UnicodeCategory.NonSpacingMark)
                    sb.Append(char.ToLowerInvariant(c));
            }

            return sb.ToString().Replace(" ", string.Empty);
        }
    }
}
