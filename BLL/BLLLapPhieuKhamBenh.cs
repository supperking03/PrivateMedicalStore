using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

using DAL;

namespace BLL
{
    public class BLLLapPhieuKhamBenh
    {
        DALLapPhieuKhamBenh  lpkb = new DALLapPhieuKhamBenh (  );

        public void TimDanhSachThuoc ( string MaChiTietDanhSach, DataGridView dgv )
        {
            lpkb.TimDanhSachThuoc ( MaChiTietDanhSach, dgv );
        }

        public int LayTongTienThuoc ( string MaChiTietDanhSach )
        {
            int max = 0;
            lpkb.LayTongTienThuoc(ref max,MaChiTietDanhSach);
            return max;
        }


        public void CapNhatChiTietDanhSach ( DTOChiTietDanhSach ctds )
        {
            lpkb.CapNhatChiTietDanhSach ( ctds );
        }

        public void CapNhatDacBiet(string MaChiTietDanhSach, string TrieuChung, int TongTienHoaDon)
        {
            lpkb.CapNhatDacBiet(MaChiTietDanhSach,TrieuChung,TongTienHoaDon);
        }

        public int LayTienKhamQuyDinh()
        {
            int max = 0;
            lpkb.LayTienKhamQuyDinh(ref max);
            return max;
        }


        public void ThemChiTietPhieuKham(DTOChiTietPhieuKham ctpk)
        {
            int count1 = 0;
            try
            {
                lpkb.GetCount(ref count1, "CHITIETPHIEUKHAM", "MaChiTietPhieuKham", "CP");
                count1++;

            }
            catch
            { }
            string ID = "CP" + count1.ToString("000");
            ctpk.MaChiTietPhieuKham = ID;
            lpkb.ThemChiTietPhieuKham ( ctpk );
        }

        public int LayDonGiaThuoc(string TenLoaiThuoc)
        {
            int result = 0;
            lpkb.LayDonGiaThuoc(TenLoaiThuoc, ref result);
            return result;
        }

        public string LayMaLoaiCachDung(string TenLoaiCachDung)
        {
            string result = "";
            lpkb.LayMaLoaiCachDung(TenLoaiCachDung, ref result);
            return result;
        }


        public string LayMaLoaiDonVi(string TenDonVi)
        {
            string result = "";
            lpkb.LayMaLoaiDonVi(TenDonVi, ref result);
            return result;
        }

        public string LayMaLoaiThuoc(string TenLoaiThuoc)
        {
            string result = "";
            lpkb.LayMaLoaiThuoc(TenLoaiThuoc, ref result);
            return result;
        }


        public string LayMaBenh ( string TenBenh)
        {
            string result = "";
            lpkb.LayMaBenh ( TenBenh,ref result );
            return result;
        }

        public void LayTenLoaiCachDung(ComboBox cbb)
        {
            List<string> temp = new List<string>();
            lpkb.LayTenLoaiCachDung(temp);

            BindingSource bs = new BindingSource();
            bs.DataSource = temp;
            cbb.DataSource = bs;
        }

        public void LayTenLoaiBenh(ComboBox cbb)
        {
            List<string> temp = new List<string>();
            lpkb.LayTenLoaiBenh(temp);

            BindingSource bs = new BindingSource();
            bs.DataSource = temp;
            cbb.DataSource = bs;
        }

        public void LayTenLoaiDonVi(ComboBox cbb)
        {
            List<string> temp = new List<string>();
            lpkb.LayTenLoaiDonVi(temp);

            BindingSource bs = new BindingSource();
            bs.DataSource = temp;
            cbb.DataSource = bs;
        }

        public  void LayTenLoaiThuoc ( ComboBox cbb )
        {
            List <string> temp = new List < string > ();
            lpkb.LayTenLoaiThuoc ( temp );

            BindingSource bs = new BindingSource();
            bs.DataSource = temp;
            cbb.DataSource = bs;
        }
    }
}
