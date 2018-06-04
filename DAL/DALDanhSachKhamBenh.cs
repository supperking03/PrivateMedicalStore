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
    public class DALDanhSachKhamBenh
    {
        private DALConnectSQLite _connect = new DALConnectSQLite (  );


        public bool DeleteChiTietPhieuKham(string MaChiTietDanhSach)
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
                "DELETE FROM CHITIETPHIEUKHAM WHERE MaChiTietDanhSach=@MaChiTietDanhSach;",
                _connect.cnn);

            // Ấn định tham số
            cmd.Parameters.Add(new SQLiteParameter("@MaChiTietDanhSach", MaChiTietDanhSach));

            // Thi hành
            cmd.ExecuteNonQuery();

            _connect.lastError = string.Empty;
            return true;
        }




        public bool LayMaChiTietDanhSach(string MaBenhNhan, ref string result)
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
                @"SELECT MaChiTietDanhSach FROM CHITIETDANHSACH WHERE MaBenhNhan = '" + MaBenhNhan + "';",
                _connect.cnn);

            // Nạp dữ liệu
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Đưa vào DataGridView

            result = dt.Rows[dt.Rows.Count - 1]["MaChiTietDanhSach"].ToString();




            // Trả bộ nhớ
            da.Dispose();
            dt.Dispose();

            _connect.lastError = string.Empty;
            return true;
        }


        public bool TimDanhSachTheoNgay(DateTime NgayKham, DataGridView dgv)
        {
            var date = NgayKham.ToString ( "yyyy-MM-dd");

            _connect.Connect("DoAnCNPM.db", "");
            // Kiểm tra trạng thái
            if (_connect.connected == false)
            {
                _connect.lastError = "Connection not established.";
                return false;
            }

            // Tạo bộ đọc dữ liệu
            SQLiteDataAdapter da = new SQLiteDataAdapter(
                @"select BENHNHAN.MaBenhNhan, HoTen, GioiTinh, NamSinh, DiaChi from BENHNHAN,CHITIETDANHSACH,DANHSACHKHAMBENH where (BENHNHAN.MaBenhNhan = CHITIETDANHSACH.MaBenhNhan) and (DANHSACHKHAMBENH.MaDanhSach = CHITIETDANHSACH.MaDanhSach) and (NgayKham >= date('" + date + @"')
            AND NgayKham < date('" + date + "', '+1 day'));",
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

        public bool AddDanhSach(string MaDanhSach, DateTime NgayKham)
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
                "INSERT INTO DANHSACHKHAMBENH VALUES (@MaDanhSach, @NgayKham);",
                _connect.cnn);

            // Ấn định tham số
            cmd.Parameters.Add(new SQLiteParameter("@MaDanhSach", MaDanhSach));
            cmd.Parameters.Add(new SQLiteParameter("@NgayKham", NgayKham.Date));


            // Thi hành
            cmd.ExecuteNonQuery();

            _connect.lastError = string.Empty;
            return true;
        }

        public bool AddChiTietDanhSach(string MaChiTietDanhSach, string MaDanhSach, string MaBenhNhan, string TrieuChung, string MaBenh, int TienKham, int TongTienThuoc, int TongTienHoaDon)
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
                "INSERT INTO CHITIETDANHSACH VALUES (@MaChiTietDanhSach, @MaDanhSach, @MaBenhNhan, @TrieuChung, @MaBenh, @TienKham, @TongTienThuoc, @TongTienHoaDon );",
                _connect.cnn);

            // Ấn định tham số
            cmd.Parameters.Add(new SQLiteParameter("@MaChiTietDanhSach", MaChiTietDanhSach));
            cmd.Parameters.Add(new SQLiteParameter("@MaDanhSach", MaDanhSach));
            cmd.Parameters.Add(new SQLiteParameter("@MaBenhNhan", MaBenhNhan));
            cmd.Parameters.Add(new SQLiteParameter("@TrieuChung", TrieuChung));
            cmd.Parameters.Add(new SQLiteParameter("@MaBenh", MaBenh));
            cmd.Parameters.Add(new SQLiteParameter("@TienKham", TienKham));
            cmd.Parameters.Add(new SQLiteParameter("@TongTienThuoc", TongTienThuoc));
            cmd.Parameters.Add(new SQLiteParameter("@TongTienHoaDon", TongTienHoaDon));


            // Thi hành
            cmd.ExecuteNonQuery();

            _connect.lastError = string.Empty;
            return true;
        }


        public bool UpdateBenhNhan(string MaBenhNhan, string HoTen, string GioiTinh, int NamSinh, string DiaChi)
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
                "UPDATE BENHNHAN SET HoTen=@HoTen, GioiTinh=@GioiTinh, NamSinh=@NamSinh, DiaChi=@DiaChi WHERE MaBenhNhan=@MaBenhNhan;",
                _connect.cnn);

            // Ấn định tham số
            cmd.Parameters.Add(new SQLiteParameter("@MaBenhNhan", MaBenhNhan));
            cmd.Parameters.Add(new SQLiteParameter("@HoTen", HoTen));
            cmd.Parameters.Add(new SQLiteParameter("@GioiTinh", GioiTinh));
            cmd.Parameters.Add(new SQLiteParameter("@NamSinh", NamSinh));
            cmd.Parameters.Add(new SQLiteParameter("@DiaChi", DiaChi));

            // Thi hành
            cmd.ExecuteNonQuery();

            _connect.lastError = string.Empty;
            return true;
        }

        public bool GetMax(ref int count)
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
            string lastId = dt.Rows[dt.Rows.Count - 1]["SoBenhNhanToiDaTrongNgay"].ToString();
            count = int.Parse(lastId);

            // Trả bộ nhớ
            da.Dispose();
            dt.Dispose();

            _connect.lastError = string.Empty;
            return true;
        }

        public bool DeleteChiTietDanhSach(string MaBenhNhan)
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
                "DELETE FROM CHITIETDANHSACH WHERE MaBenhNhan=@MaBenhNhan;",
                _connect.cnn);

            // Ấn định tham số
            cmd.Parameters.Add(new SQLiteParameter("@MaBenhNhan", MaBenhNhan));

            // Thi hành
            cmd.ExecuteNonQuery();

            _connect.lastError = string.Empty;
            return true;
        }

        public bool DeleteBenhNhan(string MaBenhNhan)
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
                "DELETE FROM BENHNHAN WHERE MaBenhNhan=@MaBenhNhan;",
                _connect.cnn);

            // Ấn định tham số
            cmd.Parameters.Add(new SQLiteParameter("@MaBenhNhan", MaBenhNhan));

            // Thi hành
            cmd.ExecuteNonQuery();

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
                "SELECT * FROM " + table +";",
                _connect.cnn);

            // Nạp dữ liệu
            DataTable dt = new DataTable();
            da.Fill(dt);
            string lastId = dt.Rows[dt.Rows.Count - 1][column].ToString (  );

            lastId = lastId.Replace ( code, "" );
            count = int.Parse ( lastId );

            // Trả bộ nhớ
            da.Dispose();
            dt.Dispose();

            _connect.lastError = string.Empty;
            return true;
        }

        public bool AddBenhNhan(string MaBenhNhan, string HoTen, string GioiTinh, int NamSinh, string DiaChi)
        {
            _connect.Connect ( "DoAnCNPM.db", "" );

            // Kiểm tra trạng thái
            if (_connect.connected == false)
            {
                _connect.lastError = "Connection not established.";
                return false;
                
            }

            // Tạo lệnh SQL
            SQLiteCommand cmd = new SQLiteCommand(
                "INSERT INTO BENHNHAN VALUES (@MaBenhNhan, @HoTen, @GioiTinh, @NamSinh, @DiaChi);",
                _connect.cnn);

            // Ấn định tham số
            cmd.Parameters.Add(new SQLiteParameter("@MaBenhNhan", MaBenhNhan));
            cmd.Parameters.Add(new SQLiteParameter("@HoTen", HoTen));
            cmd.Parameters.Add(new SQLiteParameter("@GioiTinh", GioiTinh));
            cmd.Parameters.Add(new SQLiteParameter("@NamSinh", NamSinh));
            cmd.Parameters.Add(new SQLiteParameter("@DiaChi", DiaChi));

            // Thi hành
            cmd.ExecuteNonQuery();

            _connect.lastError = string.Empty;
            return true;
        }

        public bool FillDGV(DataGridView dgv)
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
                "SELECT * FROM BENHNHAN;",
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
