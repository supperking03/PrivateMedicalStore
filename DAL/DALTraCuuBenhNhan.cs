using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALTraCuuBenhNhan
    {
        private DALConnectSQLite _connect = new DALConnectSQLite();

        public bool LayTenThuoc(List<string> TenThuoc)
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
                "  SELECT TenLoaiThuoc from LOAITHUOC;",
                _connect.cnn);

            // Nạp dữ liệu
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Đưa vào DataGridView

            foreach (DataRow row in dt.Rows)
            {
                string file = row.Field<string>(0);
                TenThuoc.Add(file);
            }




            // Trả bộ nhớ
            da.Dispose();
            dt.Dispose();

            _connect.lastError = string.Empty;
            return true;
        }

        public bool LayTrieuChung(List<string> TrieuChung)
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
                "  SELECT DISTINCT TrieuChung from CHITIETDANHSACH;",
                _connect.cnn);

            // Nạp dữ liệu
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Đưa vào DataGridView

            foreach (DataRow row in dt.Rows)
            {
                string file = row.Field<string>(0);
                TrieuChung.Add(file);
            }




            // Trả bộ nhớ
            da.Dispose();
            dt.Dispose();

            _connect.lastError = string.Empty;
            return true;
        }


        public bool LayLoaiBenh(List<string> TenBenh)
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
                TenBenh.Add(file);
            }




            // Trả bộ nhớ
            da.Dispose();
            dt.Dispose();

            _connect.lastError = string.Empty;
            return true;
        }


        public bool LayMaBenhNhan(List<string> MaBenhNhan)
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
                "SELECT MaBenhNhan FROM BENHNHAN;",
                _connect.cnn);

            // Nạp dữ liệu
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Đưa vào DataGridView

            foreach (DataRow row in dt.Rows)
            {
                string file = row.Field<string>(0);
                MaBenhNhan.Add(file);
            }




            // Trả bộ nhớ
            da.Dispose();
            dt.Dispose();

            _connect.lastError = string.Empty;
            return true;
        }


        public bool LayTenBenhNhan(List<string> HoTen)
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
                "SELECT HoTen FROM BENHNHAN;",
                _connect.cnn);

            // Nạp dữ liệu
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Đưa vào DataGridView

            foreach (DataRow row in dt.Rows)
            {
                string file = row.Field<string>(0);
                HoTen.Add(file);
            }




            // Trả bộ nhớ
            da.Dispose();
            dt.Dispose();

            _connect.lastError = string.Empty;
            return true;
        }

        public bool TraCuuBenhNhan(System.Windows.Forms.DataGridView dgv, string Query)
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
                Query,
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
