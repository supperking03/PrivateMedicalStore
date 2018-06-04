using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

using DAL;

using DTO;

namespace GUI
{
    public partial class GUILapPhieuKhamBenh : Form
    {
        public BLLLapPhieuKhamBenh BLL = new BLLLapPhieuKhamBenh (  );

        DateTime _NgayKham = new DateTime();
        private string _HoTen;


        public GUILapPhieuKhamBenh(DateTime NgayKham, string HoTen)
        {
            InitializeComponent();
            _NgayKham = NgayKham;
            _HoTen = HoTen;
        }

        DTOChiTietDanhSach ctds = new DTOChiTietDanhSach();
        private void button1_Click(object sender, EventArgs e)
        {
            if ( checkBoxSuDungThuoc.Checked == true )
            {
                try
                {
                    ctds.MaChiTietDanhSach = MaChiTietDanhSach;
                    ctds.MaBenhNhan = "BN000";
                    ctds.MaDanhSach = "DS000";
                    ctds.TrieuChung = richTextBoxTrieuChung.Text.ToString();
                    ctds.MaBenh = BLL.LayMaBenh(comboBoxDuDoanBenh.Text.ToString());
                    ctds.TienKham = BLL.LayTienKhamQuyDinh();
                    ctds.TongTienThuoc = BLL.LayTongTienThuoc(MaChiTietDanhSach);
                    ctds.TongTienHoaDon = BLL.LayTienKhamQuyDinh() + BLL.LayTongTienThuoc(MaChiTietDanhSach);
                    BLL.CapNhatChiTietDanhSach(ctds);
                }
                catch
                {
                    MessageBox.Show ( "Sử Dụng Thuốc mà không chọn thuốc ?" );
                    ctds.MaChiTietDanhSach = MaChiTietDanhSach;
                    ctds.MaBenhNhan = "BN000";
                    ctds.MaDanhSach = "DS000";
                    ctds.TrieuChung = richTextBoxTrieuChung.Text.ToString();
                    ctds.MaBenh = BLL.LayMaBenh(comboBoxDuDoanBenh.Text.ToString());
                    ctds.TienKham = BLL.LayTienKhamQuyDinh();
                    ctds.TongTienThuoc = 0;
                    ctds.TongTienHoaDon = BLL.LayTienKhamQuyDinh();
                    BLL.CapNhatChiTietDanhSach(ctds);
                }

            }
            else
            {
                ctds.MaChiTietDanhSach = MaChiTietDanhSach;
                ctds.MaBenhNhan = "BN000";
                ctds.MaDanhSach = "DS000";
                ctds.TrieuChung = richTextBoxTrieuChung.Text.ToString();
                ctds.MaBenh = BLL.LayMaBenh(comboBoxDuDoanBenh.Text.ToString());
                ctds.TienKham = BLL.LayTienKhamQuyDinh();
                ctds.TongTienThuoc = 0;
                ctds.TongTienHoaDon = BLL.LayTienKhamQuyDinh ( );
                BLL.CapNhatChiTietDanhSach(ctds);
            }




            Close (  );
        }

        private string MaChiTietDanhSach = "";
        DALDanhSachKhamBenh dskb = new DALDanhSachKhamBenh();

        private void GUILapPhieuKhamBenh_Load(object sender, EventArgs e)
        {
            checkBoxSuDungThuoc.Checked = false;
            if ( checkBoxSuDungThuoc.Checked == false )
            {
                Size = new Size(585, 195); //585, 443
            }

            ctds.TienKham = BLL.LayTienKhamQuyDinh();       
          

            BLL.TimDanhSachThuoc(MaChiTietDanhSach, dataGridViewDanhSachThuoc);
            // lấy chi mã chi tiết danh sách
            int count1 = 0;
            try
            {
                dskb.GetCount(ref count1, "CHITIETDANHSACH", "MaChiTietDanhSach", "CD");
            }
            catch
            { }
            MaChiTietDanhSach = "CD" + count1.ToString("000");

            textBoxHoTen.Text = _HoTen;
            dateTimePickerNgayKham.Value = _NgayKham;
            BLL.LayTenLoaiThuoc ( comboBoxTenThuoc );
            BLL.LayTenLoaiCachDung ( comboBoxCachDung );
            BLL.LayTenLoaiBenh ( comboBoxDuDoanBenh );
            BLL.LayTenLoaiDonVi ( comboBoxDonVi );
            for(int i = 1;i <= 20; i++)
            {
                comboBoxSoLuong.Items.Add ( i );
            }

            comboBoxSoLuong.SelectedIndex = 0;


            //// cap nhat lại ctds
            //ctds.MaChiTietDanhSach = MaChiTietDanhSach;
            //ctds.MaBenhNhan = "BN000";
            //ctds.MaDanhSach = "DS000";
            //ctds.TrieuChung = richTextBoxTrieuChung.Text.ToString();
            //ctds.MaBenh = BLL.LayMaBenh(comboBoxDuDoanBenh.Text.ToString());
            //ctds.TienKham = BLL.LayTienKhamQuyDinh();
            //ctds.TongTienThuoc = BLL.LayTongTienThuoc(MaChiTietDanhSach);
            //ctds.TongTienHoaDon = BLL.LayTienKhamQuyDinh() + BLL.LayTongTienThuoc(MaChiTietDanhSach);
            //BLL.CapNhatChiTietDanhSach(ctds);
        }

        private void buttonThemThuoc_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(BLL.LayMaBenh ( comboBoxDuDoanBenh.Text.ToString ( ) ));
            //MessageBox.Show(BLL.LayMaLoaiThuoc(comboBoxTenThuoc.Text.ToString()));
            //MessageBox.Show(BLL.LayMaLoaiDonVi(comboBoxDonVi.Text.ToString()));
            //MessageBox.Show(BLL.LayMaLoaiCachDung(comboBoxCachDung.Text.ToString()));
            //MessageBox.Show ( BLL.LayDonGiaThuoc ( comboBoxTenThuoc.Text.ToString ( ) ).ToString ( ) );

            DTO.DTOChiTietPhieuKham ctkp = new DTOChiTietPhieuKham (  );

            ctkp.MaChiTietDanhSach = MaChiTietDanhSach;
            ctkp.MaLoaiCachDung = BLL.LayMaLoaiCachDung ( comboBoxCachDung.Text.ToString ( ) );
            ctkp.MaLoaiDonVi = BLL.LayMaLoaiDonVi ( comboBoxDonVi.Text.ToString ( ) );
            ctkp.MaLoaiThuoc = BLL.LayMaLoaiThuoc(comboBoxTenThuoc.Text.ToString());
            ctkp.SoLuong = int.Parse(comboBoxSoLuong.Text.ToString ( ));
            ctkp.TienThuoc = int.Parse ( BLL.LayDonGiaThuoc ( comboBoxTenThuoc.Text.ToString ( ) ).ToString ( ) ) *
                             int.Parse ( comboBoxSoLuong.Text.ToString ( ) );


            BLL.ThemChiTietPhieuKham ( ctkp );
            BLL.TimDanhSachThuoc ( MaChiTietDanhSach, dataGridViewDanhSachThuoc );


            // cap nhat lại
            ctds.MaChiTietDanhSach = MaChiTietDanhSach;
            ctds.MaBenhNhan = "BN000";
            ctds.MaDanhSach = "DS000";
            ctds.TrieuChung = richTextBoxTrieuChung.Text.ToString();
            ctds.MaBenh = BLL.LayMaBenh(comboBoxDuDoanBenh.Text.ToString());
            ctds.TienKham = BLL.LayTienKhamQuyDinh();
            ctds.TongTienThuoc = BLL.LayTongTienThuoc(MaChiTietDanhSach);
            ctds.TongTienHoaDon = BLL.LayTienKhamQuyDinh() + BLL.LayTongTienThuoc(MaChiTietDanhSach);
            BLL.CapNhatChiTietDanhSach(ctds);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GUILapHoaDonThanhToan lhdtt = new GUILapHoaDonThanhToan ( ctds, _NgayKham, _HoTen );
            lhdtt.Show();
        }

        private void checkBoxSuDungThuoc_CheckedChanged(object sender, EventArgs e)
        {
            if ( checkBoxSuDungThuoc.Checked == true )
            {
                Size = new Size(585, 445);
            }
            else
            {
                Size = new Size(585, 195);
            }
        }
    }
}
