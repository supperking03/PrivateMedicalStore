using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLLLapHoaDonThanhToan
    {
        DALLapHoaDonThanhToan lhdtt = new DALLapHoaDonThanhToan (  );

        public string LayTenTuMa ( string MaBenhNhan )
        {
            string temp = "";
            lhdtt.LayTenTuMa ( MaBenhNhan, ref temp );
            return temp;
        }
    }
}
