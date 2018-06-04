using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace BLL
{

    public class BLLDanhSachKhamBenh
    {
      
        DALDanhSachKhamBenh dskb = new DALDanhSachKhamBenh (  );

        public string LayMaChiTietDanhSach(string MaBenhNhan)
        {
            string result = "";
            dskb.LayMaChiTietDanhSach(MaBenhNhan, ref result);
            return result;
        }


        public void TimDanhSachTheoNgay ( DateTime NgayKham, DataGridView dgv )
        {
            dskb.TimDanhSachTheoNgay ( NgayKham, dgv );
        }


        public void AddBenhNhan ( string HoTen, String GioiTinh, int NamSinh, String DiaChi)
        {

            int count = 0;
            try
            {
                dskb.GetCount(ref count,"BENHNHAN", "MaBenhNhan","BN");
                count++;
            }
            catch
            { }
            string IDBenhNhan = "BN" + count.ToString("000");
            dskb.AddBenhNhan ( IDBenhNhan, HoTen, GioiTinh, NamSinh, DiaChi );
        }

        public void DeleteBenhNhan ( string MaBenhNhan )
        {
            dskb.DeleteChiTietPhieuKham(LayMaChiTietDanhSach(MaBenhNhan));
            dskb.DeleteChiTietDanhSach(MaBenhNhan);
            dskb.DeleteBenhNhan ( MaBenhNhan );


        }

        public int GetMaxBenhNhan ()
        {
            int max = 0;
            dskb.GetMax ( ref max );
            return max;
        }

        public void FillDGV ( DataGridView dgv )
        {
            dskb.FillDGV ( dgv );
        }

        public void UpdateBenhNhan (string MaBenhNhan, string HoTen, string GioiTinh, int NamSinh, string DiaChi )
        {
            dskb.UpdateBenhNhan (MaBenhNhan, HoTen, GioiTinh,  NamSinh, DiaChi);
        }

        public void AddDanhSach ( string MaDanhSach, DateTime NgayKham)
        {
            dskb.AddDanhSach ( MaDanhSach, NgayKham );
        }



        public void AddDanhSach ( DateTime NgayKham )
        {
            int count = 0;
            try
            {
                dskb.GetCount(ref count, "DANHSACHKHAMBENh", "MaDanhSach", "DS");
                count++;
            }
            catch
            { }
            string IDDanhSach = "DS" + count.ToString("000");
            dskb.AddDanhSach(IDDanhSach, NgayKham);
        }

        public void AddChiTietDanhSach ()
        {
            int count1 = 0;
            try
            {
                dskb.GetCount(ref count1, "CHITIETDANHSACH", "MaChiTietDanhSach", "CD");
                count1++;
            }
            catch
            { }
            string ID = "CD" + count1.ToString("000");
            string IDBenhNhan = "BN" + count1.ToString("000");


            int count2 = 0;
            try
            {
                dskb.GetCount(ref count2, "DANHSACHKHAMBENH", "MaDanhSach", "DS");

            }
            catch
            { }
            string IDDanhSach = "DS" + count2.ToString("000");
            DALLapPhieuKhamBenh tienkham = new DALLapPhieuKhamBenh (  );
            int _tienkham = 0;
            tienkham.LayTienKhamQuyDinh ( ref _tienkham );

            dskb.AddChiTietDanhSach ( ID, IDDanhSach, IDBenhNhan,"","",_tienkham,0,0 );

        }

    }
}
