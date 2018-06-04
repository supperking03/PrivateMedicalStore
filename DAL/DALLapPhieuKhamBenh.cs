using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace DAL
{
    public class DALLapPhieuKhamBenh
    {
        private DALConnectSQLite _connect = new DALConnectSQLite();

        public bool TimDanhSachThuoc(string MaChiTietDanhSach, DataGridView dgv)
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
                @"select TenLoaiThuoc, TenDonVi, SoLuong, TenLoaiCachDung from LOAITHUOC,LOAIDONVI,LOAICACHDUNG,CHITIETPHIEUKHAM where MaChiTietDanhSach = '"+ MaChiTietDanhSach +"' and CHITIETPHIEUKHAM.MaLoaiThuoc = LOAITHUOC.MaLoaiThuoc and CHITIETPHIEUKHAM.MaLoaiDonVi = LOAIDONVI.MaLoaiDonVi and CHITIETPHIEUKHAM.MaLoaiCachDung = LOAICACHDUNG.MaLoaiCachDung;",
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


        public bool LayTongTienThuoc(ref int count, string MaChiTietDanhSach)
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
                @"select sum(TienThuoc) from CHITIETPHIEUKHAM where MaChiTietDanhSach = '"+ MaChiTietDanhSach +"'",
                _connect.cnn);

            // Nạp dữ liệu
            DataTable dt = new DataTable();
            da.Fill(dt);
            string lastId = dt.Rows[dt.Rows.Count - 1]["sum(TienThuoc)"].ToString();
            count = int.Parse(lastId);

            // Trả bộ nhớ
            da.Dispose();
            dt.Dispose();

            _connect.lastError = string.Empty;
            return true;
        }

        public bool CapNhatDacBiet(string MaChiTietDanhSach, string TrieuChung, int TongTienHoaDon)
        {
            _connect.Connect("DoAnCNPM.db", "");
            // Kiểm tra trạng thái
            if (_connect.connected == false)
            {
                _connect.lastError = "Connection not established.";
                return false;
            }

            // Tạo lệnh SQL
            SQLiteCommand cmd = new SQLiteCommand(
                "UPDATE CHITIETDANHSACH SET TrieuChung=@TrieuChung, TongTienHoaDon=@TongTienHoaDon WHERE MaChiTietDanhSach=@MaChiTietDanhSach;",
                _connect.cnn);

            // Ấn định tham số
            cmd.Parameters.Add(new SQLiteParameter("@TrieuChung", TrieuChung));
            cmd.Parameters.Add(new SQLiteParameter("@TongTienHoaDon", TongTienHoaDon));
            cmd.Parameters.Add(new SQLiteParameter("@MaChiTietDanhSach", MaChiTietDanhSach));

            // Thi hành
            cmd.ExecuteNonQuery();

            _connect.lastError = string.Empty;
            return true;
        }


        public bool CapNhatChiTietDanhSach(DTOChiTietDanhSach ctds)
        {
            _connect.Connect("DoAnCNPM.db", "");
            // Kiểm tra trạng thái
            if (_connect.connected == false)
            {
                _connect.lastError = "Connection not established.";
                return false;
            }

            // Tạo lệnh SQL
            SQLiteCommand cmd = new SQLiteCommand(
                "UPDATE CHITIETDANHSACH SET TrieuChung=@TrieuChung, MaBenh=@MaBenh, TienKham=@TienKham, TongTienThuoc=@TongTienThuoc, TongTienHoaDon=@TongTienHoaDon WHERE MaChiTietDanhSach=@MaChiTietDanhSach;",
                _connect.cnn);

            // Ấn định tham số
            cmd.Parameters.Add(new SQLiteParameter("@TrieuChung", ctds.TrieuChung));
            cmd.Parameters.Add(new SQLiteParameter("@MaBenh", ctds.MaBenh));
            cmd.Parameters.Add(new SQLiteParameter("@TienKham", ctds.TienKham));
            cmd.Parameters.Add(new SQLiteParameter("@TongTienThuoc", ctds.TongTienThuoc));
            cmd.Parameters.Add(new SQLiteParameter("@TongTienHoaDon", ctds.TongTienHoaDon));
            cmd.Parameters.Add(new SQLiteParameter("@MaChiTietDanhSach", ctds.MaChiTietDanhSach));
            // Thi hành
            cmd.ExecuteNonQuery();

            _connect.lastError = string.Empty;
            return true;
        }


        public bool LayTienKhamQuyDinh(ref int count)
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
                "SELECT * FROM THAMSO;",
                _connect.cnn);

            // Nạp dữ liệu
            DataTable dt = new DataTable();
            da.Fill(dt);
            string lastId = dt.Rows[dt.Rows.Count - 1]["TienKhamQuyDinh"].ToString();
            count = int.Parse(lastId);

            // Trả bộ nhớ
            da.Dispose();
            dt.Dispose();

            _connect.lastError = string.Empty;
            return true;
        }

        // lấy Mã cuối cùng
        public bool GetCount(ref int count, string table, string column, string code)
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
                "SELECT * FROM " + table + ";",
                _connect.cnn);

            // Nạp dữ liệu
            DataTable dt = new DataTable();
            da.Fill(dt);
            string lastId = dt.Rows[dt.Rows.Count - 1][column].ToString();

            lastId = lastId.Replace(code, "");
            count = int.Parse(lastId);

            // Trả bộ nhớ
            da.Dispose();
            dt.Dispose();

            _connect.lastError = string.Empty;
            return true;
        }

        public bool ThemChiTietPhieuKham(DTOChiTietPhieuKham ctpk)
        {
            // Kiểm tra trạng thái
            if (_connect.connected == false)
            {
                _connect.lastError = "Connection not established.";
                return false;
            }

            // Tạo lệnh SQL
            SQLiteCommand cmd = new SQLiteCommand(
                "INSERT INTO CHITIETPHIEUKHAM VALUES (@MaChiTietPhieuKham, @MaChiTietDanhSach, @MaLoaiThuoc, @MaLoaiDonVi, @MaLoaiCachDung, @SoLuong, @TienThuoc);",
                _connect.cnn);

            // Ấn định tham số
            cmd.Parameters.Add(new SQLiteParameter("@MaChiTietPhieuKham", ctpk.MaChiTietPhieuKham));
            cmd.Parameters.Add(new SQLiteParameter("@MaChiTietDanhSach", ctpk.MaChiTietDanhSach));
            cmd.Parameters.Add(new SQLiteParameter("@MaLoaiThuoc", ctpk.MaLoaiThuoc));
            cmd.Parameters.Add(new SQLiteParameter("@MaLoaiDonVi", ctpk.MaLoaiDonVi));
            cmd.Parameters.Add(new SQLiteParameter("@MaLoaiCachDung", ctpk.MaLoaiCachDung));
            cmd.Parameters.Add(new SQLiteParameter("@SoLuong", ctpk.SoLuong));
            cmd.Parameters.Add(new SQLiteParameter("@TienThuoc", ctpk.TienThuoc));

            // Thi hành
            cmd.ExecuteNonQuery();

            _connect.lastError = string.Empty;
            return true;
        }

        public bool LayDonGiaThuoc(string TenLoaiThuoc, ref int result)
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
                @"SELECT DonGiaThuoc FROM LOAITHUOC WHERE TenLoaiThuoc = '" + TenLoaiThuoc + "';",
                _connect.cnn);

            // Nạp dữ liệu
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Đưa vào DataGridView

            result = int.Parse(dt.Rows[dt.Rows.Count - 1]["DonGiaThuoc"].ToString());


            

            // Trả bộ nhớ
            da.Dispose();
            dt.Dispose();

            _connect.lastError = string.Empty;
            return true;
        }


        public bool LayMaLoaiCachDung(string TenLoaiCachDung, ref string result)
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
                @"SELECT MaLoaiCachDung FROM LOAICACHDUNG WHERE TenLoaiCachDung = '" + TenLoaiCachDung + "';",
                _connect.cnn);

            // Nạp dữ liệu
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Đưa vào DataGridView

            result = dt.Rows[dt.Rows.Count - 1]["MaLoaiCachDung"].ToString();




            // Trả bộ nhớ
            da.Dispose();
            dt.Dispose();

            _connect.lastError = string.Empty;
            return true;
        }

        public bool LayMaLoaiDonVi(string TenDonVi, ref string result)
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
                @"SELECT MaLoaiDonVi FROM LOAIDONVI WHERE TenDonVi = '" + TenDonVi + "';",
                _connect.cnn);

            // Nạp dữ liệu
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Đưa vào DataGridView

            result = dt.Rows[dt.Rows.Count - 1]["MaLoaiDonVi"].ToString();




            // Trả bộ nhớ
            da.Dispose();
            dt.Dispose();

            _connect.lastError = string.Empty;
            return true;
        }


        public bool LayMaLoaiThuoc(string TenLoaiThuoc, ref string result)
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
                @"SELECT MaLoaiThuoc FROM LOAITHUOC WHERE TenLoaiThuoc = '" + TenLoaiThuoc + "';",
                _connect.cnn);

            // Nạp dữ liệu
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Đưa vào DataGridView

            result = dt.Rows[dt.Rows.Count - 1]["MaLoaiThuoc"].ToString();




            // Trả bộ nhớ
            da.Dispose();
            dt.Dispose();

            _connect.lastError = string.Empty;
            return true;
        }

        public bool LayMaBenh(string TenBenh,ref string result)
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
                @"SELECT MaBenh FROM BENH WHERE TenBenh = '" + TenBenh + "';",
                _connect.cnn);

            // Nạp dữ liệu
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Đưa vào DataGridView

            result = dt.Rows[dt.Rows.Count - 1]["MaBenh"].ToString();




            // Trả bộ nhớ
            da.Dispose();
            dt.Dispose();

            _connect.lastError = string.Empty;
            return true;
        }


        public bool LayTenLoaiCachDung(List<string> TenLoaiCachDung)
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
                "SELECT TenLoaiCachDung FROM LOAICACHDUNG;",
                _connect.cnn);

            // Nạp dữ liệu
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Đưa vào DataGridView

            foreach (DataRow row in dt.Rows)
            {
                string file = row.Field<string>(0);
                TenLoaiCachDung.Add(file);
            }




            // Trả bộ nhớ
            da.Dispose();
            dt.Dispose();

            _connect.lastError = string.Empty;
            return true;
        }


        public bool LayTenLoaiBenh(List<string> TenLoaiBenh)
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
                "SELECT TenBenh FROM BENH;",
                _connect.cnn);

            // Nạp dữ liệu
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Đưa vào DataGridView

            foreach (DataRow row in dt.Rows)
            {
                string file = row.Field<string>(0);
                TenLoaiBenh.Add(file);
            }




            // Trả bộ nhớ
            da.Dispose();
            dt.Dispose();

            _connect.lastError = string.Empty;
            return true;
        }

        public bool LayTenLoaiDonVi(List<string> TenLoaiDonVi)
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
                "SELECT TenDonVi FROM LOAIDONVI;",
                _connect.cnn);

            // Nạp dữ liệu
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Đưa vào DataGridView

            foreach (DataRow row in dt.Rows)
            {
                string file = row.Field<string>(0);
                TenLoaiDonVi.Add(file);
            }




            // Trả bộ nhớ
            da.Dispose();
            dt.Dispose();

            _connect.lastError = string.Empty;
            return true;
        }


        public bool LayTenLoaiThuoc(List <string> TenLoaiThuoc)
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
                "SELECT TenLoaiThuoc FROM LOAITHUOC;",
                _connect.cnn);

            // Nạp dữ liệu
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Đưa vào DataGridView

            foreach (DataRow row in dt.Rows)
            {
                string file = row.Field<string>(0);
                TenLoaiThuoc.Add ( file );
            }




            // Trả bộ nhớ
            da.Dispose();
            dt.Dispose();

            _connect.lastError = string.Empty;
            return true;
        }
    }
}
