using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALLapHoaDonThanhToan
    {

        private DALConnectSQLite _connect = new DALConnectSQLite();

        public bool LayTenTuMa(string MaBenhNhan, ref string result)
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
                @"SELECT HoTen FROM BENHNHAN WHERE MaBenhNhan = '" + MaBenhNhan + "';",
                _connect.cnn);
            // Nạp dữ liệu
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Đưa vào DataGridView

            result = dt.Rows[dt.Rows.Count - 1]["HoTen"].ToString();

            // Trả bộ nhớ
            da.Dispose();
            dt.Dispose();

            _connect.lastError = string.Empty;
            return true;
        }
    }
}
