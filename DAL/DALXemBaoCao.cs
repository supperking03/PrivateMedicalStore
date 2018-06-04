using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DALXemBaoCao
    {
        private DALConnectSQLite _connect = new DALConnectSQLite();

        public bool XemBaoCaoThuoc(DataGridView dgv, int Thang)
        {
            _connect.Connect("DoAnCNPM.db", "");
            // Kiểm tra trạng thái
            if (_connect.connected == false)
            {
                _connect.lastError = "Connection not established.";
                return false;
            }

            // Tạo bộ đọc dữ liệu
            SQLiteDataAdapter da = new SQLiteDataAdapter(
                "select LOAITHUOC.TenLoaiThuoc, LOAIDONVI.TenDonVi, SoLuong, count(CHITIETPHIEUKHAM.MaLoaiThuoc) as SoLanDung from CHITIETPHIEUKHAM,CHITIETDANHSACH,DANHSACHKHAMBENH,LOAITHUOC,LOAIDONVI where  CHITIETPHIEUKHAM.MaChiTietDanhSach = CHITIETDANHSACH.MaChiTietDanhSach and CHITIETDANHSACH.MaDanhSach = DANHSACHKHAMBENH.MaDanhSach and LOAITHUOC.MaLoaiThuoc = CHITIETPHIEUKHAM.MaLoaiThuoc and LOAIDONVI.MaLoaiDonVi = CHITIETPHIEUKHAM.MaLoaiDonVi and CAST(strftime('%m', DANHSACHKHAMBENH.NgayKham) as INTEGER) = "+ Thang +";",
                _connect.cnn);

            // Nạp dữ liệu
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Đưa vào DataGridView
            dgv.DataSource = dt;


            // Trả bộ nhớ
            da.Dispose();
            dt.Dispose();

            _connect.lastError = string.Empty;
            return true;
        }

        public bool XemBaoCaoDoanhThu(DataGridView dgv, int Thang)
        {
            _connect.Connect("DoAnCNPM.db", "");
            // Kiểm tra trạng thái
            if (_connect.connected == false)
            {
                _connect.lastError = "Connection not established.";
                return false;
            }

            // Tạo bộ đọc dữ liệu
            SQLiteDataAdapter da = new SQLiteDataAdapter(
                "select NgayKham, count(MaBenhNhan) as SoBenhNhan,sum(TongTienHoaDon) as DoanhThu, '0' as Tile from CHITIETDANHSACH,DANHSACHKHAMBENH where CHITIETDANHSACH.MaDanhSach = DANHSACHKHAMBENH.MaDanhSach and CAST(strftime('%m', DANHSACHKHAMBENH.NgayKham) as INTEGER) = "+ Thang +" group by NgayKham;",
                _connect.cnn);

            // Nạp dữ liệu
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Đưa vào DataGridView
            dgv.DataSource = dt;


            // Trả bộ nhớ
            da.Dispose();
            dt.Dispose();

            _connect.lastError = string.Empty;
            return true;
        }
    }
}
