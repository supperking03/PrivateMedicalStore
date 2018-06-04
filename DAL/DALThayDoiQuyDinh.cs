using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DAL
{
    public class DALThayDoiQuyDinh
    {
        private DALConnectSQLite _connect = new DALConnectSQLite();

        public bool XoaTen(string Ten, string Table, string Column)
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
                "DELETE FROM "+ Table +" WHERE "+ Column +"= @Ten;",
                _connect.cnn);

            // Ấn định tham số
            cmd.Parameters.Add(new SQLiteParameter("@Ten", Ten));

            // Thi hành
            cmd.ExecuteNonQuery();

            _connect.lastError = string.Empty;
            return true;
        }

        public bool ThemLoaiThuoc(string TenLoaiThuoc, string MaLoaiThuoc, int DonGiaThuoc)
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
                "INSERT INTO LOAITHUOC VALUES (@MaLoaiThuoc, @TenLoaiThuoc, @DonGiaThuoc);",
                _connect.cnn);

            // Ấn định tham số
            cmd.Parameters.Add(new SQLiteParameter("@MaLoaiThuoc", MaLoaiThuoc));
            cmd.Parameters.Add(new SQLiteParameter("@TenLoaiThuoc", TenLoaiThuoc));
            cmd.Parameters.Add(new SQLiteParameter("@DonGiaThuoc", DonGiaThuoc));

            // Thi hành
            cmd.ExecuteNonQuery();

            _connect.lastError = string.Empty;
            return true;
        }

        public bool ThemLoaiCachDung(string TenLoaiCachDung, string MaLoaiCachDung)
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
                "INSERT INTO LOAICACHDUNG VALUES (@MaLoaiCachDung, @TenLoaiCachDung);",
                _connect.cnn);

            // Ấn định tham số
            cmd.Parameters.Add(new SQLiteParameter("@MaLoaiCachDung", MaLoaiCachDung));
            cmd.Parameters.Add(new SQLiteParameter("@TenLoaiCachDung", TenLoaiCachDung));


            // Thi hành
            cmd.ExecuteNonQuery();

            _connect.lastError = string.Empty;
            return true;
        }

        public bool ThemLoaiDonVi(string TenDonVi, string MaLoaiDonVi)
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
                "INSERT INTO LOAIDONVI VALUES (@MaLoaiDonVi, @TenDonVi);",
                _connect.cnn);

            // Ấn định tham số
            cmd.Parameters.Add(new SQLiteParameter("@MaLoaiDonVi", MaLoaiDonVi));
            cmd.Parameters.Add(new SQLiteParameter("@TenDonVi", TenDonVi));


            // Thi hành
            cmd.ExecuteNonQuery();

            _connect.lastError = string.Empty;
            return true;
        }

        public bool ThemLoaiBenh(string TenBenh, string MaBenh)
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
                "INSERT INTO BENH VALUES (@MaBenh, @TenBenh);",
                _connect.cnn);

            // Ấn định tham số
            cmd.Parameters.Add(new SQLiteParameter("@MaBenh", MaBenh));
            cmd.Parameters.Add(new SQLiteParameter("@TenBenh", TenBenh));


            // Thi hành
            cmd.ExecuteNonQuery();

            _connect.lastError = string.Empty;
            return true;
        }

        public bool UpDateBenhNhanToiDa(int SoBenhNhanToiDaTrongNgay)
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
                "UPDATE THAMSO SET SoBenhNhanToiDaTrongNgay=@SoBenhNhanToiDaTrongNgay;",
                _connect.cnn);

            // Ấn định tham số
            cmd.Parameters.Add(new SQLiteParameter("@SoBenhNhanToiDaTrongNgay", SoBenhNhanToiDaTrongNgay));

            // Thi hành
            cmd.ExecuteNonQuery();

            _connect.lastError = string.Empty;
            return true;
        }
    }
}
