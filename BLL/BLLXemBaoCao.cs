using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DAL;

namespace BLL
{
    public class BLLXemBaoCao
    {
        DALXemBaoCao xbc = new DALXemBaoCao (  );

        public void XemBaoCaoThuoc(DataGridView dgv, int Thang)
        {
            xbc.XemBaoCaoThuoc(dgv, Thang);
        }

        public void XemBaoCaoDoanhThu ( DataGridView dgv, int Thang )
        {
            xbc.XemBaoCaoDoanhThu ( dgv, Thang );
        }
    }
}
