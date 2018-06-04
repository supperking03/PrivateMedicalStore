using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DAL;

namespace BLL
{
    public class BLLTraCuuBenhNhan
    {
        DALTraCuuBenhNhan tcbn = new DALTraCuuBenhNhan (  );


        public void LayTenThuoc(ComboBox cbb)
        {
            List<string> temp = new List<string>();
            tcbn.LayTenThuoc(temp);

            BindingSource bs = new BindingSource();
            bs.DataSource = temp;
            cbb.DataSource = bs;
        }


        public void LayTrieuChung(ComboBox cbb)
        {
            List<string> temp = new List<string>();
            tcbn.LayTrieuChung(temp);

            BindingSource bs = new BindingSource();
            bs.DataSource = temp;
            cbb.DataSource = bs;
        }



        public void LayTenBenh(ComboBox cbb)
        {
            List<string> temp = new List<string>();
            tcbn.LayLoaiBenh(temp);

            BindingSource bs = new BindingSource();
            bs.DataSource = temp;
            cbb.DataSource = bs;
        }

        public void LayMaBenhNhan(ComboBox cbb)
        {
            List<string> temp = new List<string>();
            tcbn.LayMaBenhNhan(temp);

            BindingSource bs = new BindingSource();
            bs.DataSource = temp;
            cbb.DataSource = bs;
        }


        public void LayTenBenhNhan(ComboBox cbb)
        {
            List<string> temp = new List<string>();
            tcbn.LayTenBenhNhan(temp);

            BindingSource bs = new BindingSource();
            bs.DataSource = temp;
            cbb.DataSource = bs;
        }

        public void TraCuuBenhNhan ( DataGridView dgv, string Query )
        {
            tcbn.TraCuuBenhNhan ( dgv, Query );
        }
    
    }
}
