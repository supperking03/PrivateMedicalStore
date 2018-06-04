using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class GUILapHoaDonThanhToan : Form
    {
        DTOChiTietDanhSach ctds = new DTOChiTietDanhSach();
        BLLLapHoaDonThanhToan lhdtt = new BLLLapHoaDonThanhToan (  );
        DateTime NgayKham = new DateTime();
        string HoTen = "";

        public GUILapHoaDonThanhToan(DTOChiTietDanhSach _ctds, DateTime _NgayKham, string _HoTen)
        {
            InitializeComponent();
            ctds = _ctds;
            NgayKham = _NgayKham;
            HoTen = _HoTen;
        }

        private void GUILapHoaDonThanhToan_Load(object sender, EventArgs e)
        {
            labelHoTen.Text = HoTen;
            labelNgayKham.Text = NgayKham.ToShortDateString ( );
            labelTienKham.Text = ctds.TienKham.ToString ( );
            labelTienThuoc.Text = ctds.TongTienThuoc.ToString ( );
            labelTongTien.Text = ( int.Parse ( ctds.TienKham.ToString ( ) ) +
                                   int.Parse ( ctds.TongTienThuoc.ToString ( ) ) ).ToString ( );
        }
    }
}
