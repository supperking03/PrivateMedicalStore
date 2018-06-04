using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DAL;

namespace BLL
{
    public class BLLThayDoiQuyDinh
    {
        DALLapPhieuKhamBenh lpkb = new DALLapPhieuKhamBenh (  );
        DALDanhSachKhamBenh dskb = new DALDanhSachKhamBenh (  );
        DALThayDoiQuyDinh tdqd = new DALThayDoiQuyDinh (  );

        public void XoaTen ( string Ten, string table, string Column )
        {
            tdqd.XoaTen ( Ten, table,Column );
        }


        public void ThemLoaiThuoc(string TenLoaiThuoc, int DonGiaThuoc)
        {
            int count = 0;
            try
            {
                dskb.GetCount(ref count, "LOAITHUOC", "MaLoaiThuoc", "TH");
                count++;
            }
            catch
            { }
            string ID = "TH" + count.ToString("000");
            tdqd.ThemLoaiThuoc(TenLoaiThuoc, ID,DonGiaThuoc);
        }

        public void ThemLoaiCachDung(string TenLoaiCachDung)
        {
            int count = 0;
            try
            {
                dskb.GetCount(ref count, "LOAICACHDUNG", "MaLoaiCachDung", "CA");
                count++;
            }
            catch
            { }
            string ID = "CA" + count.ToString("000");
            tdqd.ThemLoaiCachDung(TenLoaiCachDung, ID);
        }

        public void ThemDonVi(string TenDonVi)
        {
            int count = 0;
            try
            {
                dskb.GetCount(ref count, "LOAIDONVI", "MaLoaiDonVi", "DV");
                count++;
            }
            catch
            { }
            string ID = "DV" + count.ToString("000");
            tdqd.ThemLoaiDonVi(TenDonVi, ID);
        }

        public void ThemLoaiBenh ( string TenBenh)
        {
            int count = 0;
            try
            {
                dskb.GetCount(ref count, "BENH", "MaBenh", "BE");
                count++;
            }
            catch
            { }
            string ID = "BE" + count.ToString("000");
            tdqd.ThemLoaiBenh ( TenBenh, ID );
        }

        public void UpdateSoBenhNhanToiDaTrongNgay ( int SoBenhNhanToiDaTrongNgay)
        {
            tdqd.UpDateBenhNhanToiDa ( SoBenhNhanToiDaTrongNgay );
        }

        public int GetMaxBenhNhan()
        {
            int max = 0;
            dskb.GetMax(ref max);
            return max;
        }

        public int LayDonGiaThuoc(string TenLoaiThuoc)
        {
            int result = 0;
            lpkb.LayDonGiaThuoc(TenLoaiThuoc, ref result);
            return result;
        }

        public void LayTenLoaiBenh ( ComboBox cbb)
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

        public void LayTenLoaiCachDung(ComboBox cbb)
        {
            List<string> temp = new List<string>();
            lpkb.LayTenLoaiCachDung(temp);

            BindingSource bs = new BindingSource();
            bs.DataSource = temp;
            cbb.DataSource = bs;
        }

        public void LayTenLoaiThuoc(ComboBox cbb)
        {
            List<string> temp = new List<string>();
            lpkb.LayTenLoaiThuoc(temp);

            BindingSource bs = new BindingSource();
            bs.DataSource = temp;
            cbb.DataSource = bs;
        }
    }
}
