using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class DALConnectSQLite
    {
        // biến lưu giữ kết nối
        public SQLiteConnection cnn;
        // biến trạng thái kết nối
        public bool connected;
        // biến thông điệp lỗi gần nhất
        public string lastError;

        public DALConnectSQLite()
        {
            this.cnn = null;
            this.connected = false;
            this.lastError = string.Empty;
        }

        // Thuộc tính cho biết trạng thái kết nối
        public bool Connected
        {
            get { return this.connected; }
        }

        // Thuộc tính cho biết thông điệp lỗi gần nhất
        public string LastError
        {
            get { return this.lastError; }
        }

        public bool Connect(string database, string password)
        {
            // Nếu đã kết nối rồi thì sẽ gây lỗi
            if (this.connected)
            {
                this.lastError = "Connection already established.";
                return false;
            }

            // Khởi tạo kết nối
            this.cnn = new SQLiteConnection(string.Concat("Data Source=", database));

            // Nếu có cho mật mã thì ấn định luôn
            if (password != null)
                this.cnn.SetPassword(password);

            try
            {
                // Mở CSDL
                this.cnn.Open();
            }
            catch (SQLiteException ex)
            {
                // thường có 2 trường hợp lỗi ở đây:
                // 1. Tập tin CSDL không truy cập được.
                // 2. Mật mã không đúng.
                this.lastError = ex.Message;
                return false;
            }

            // Đã kết nối
            this.connected = true;

            // Không có lỗi
            this.lastError = string.Empty;

            return true;
        }

        public bool Disconnect()
        {
            // Nếu chưa kết nối thì cũng xem là lỗi
            if (this.connected == false)
            {
                this.lastError = "Connection not established.";
                return false;
            }

            // Đóng CSDL
            this.cnn.Close();
            // Trả bộ nhớ
            this.cnn.Dispose();
            this.cnn = null;

            this.connected = false;

            this.lastError = string.Empty;
            return true;
        }

        public void Dispose()
        {
            this.Disconnect();
        }
    }
}
