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

namespace GUI
{
    public partial class GUITraCuuBenhNhan : Form
    {

        public BLLTraCuuBenhNhan BLL = new BLLTraCuuBenhNhan (  );
        public GUITraCuuBenhNhan()
        {
            InitializeComponent();
        }


     

        private void GUITraCuuBenhNhan_Load(object sender, EventArgs e)
        {
          

            dateTimePickerNgayKham.Enabled = false;
            comboBoxTenThuoc.Enabled = false;
            comboBoxHoTen.Enabled = false;
            comboBoxLoaiBenh.Enabled = false;
            comboBoxGioiTinh.Enabled = false;
            comboBoxTrieuChung.Enabled = false;
            comboBoxMaBenhNhan.Enabled = false;

            checkBoxNgayKham.Checked = false;
            checkBoxGioiTinh.Checked = false;
            checkBoxMaBenhNhan.Checked = false;
            checkBoxHoTen.Checked = false;
            checkBoxLoaiBenh.Checked = false;
            checkBoxTrieuChung.Checked = false;
            checkBoxTenThuoc.Checked = false;


            BLL.LayTenBenhNhan ( comboBoxHoTen );
            BLL.LayMaBenhNhan ( comboBoxMaBenhNhan );
            BLL.LayTenThuoc ( comboBoxTenThuoc );
            BLL.LayTenBenh ( comboBoxLoaiBenh );
            BLL.LayTrieuChung ( comboBoxTrieuChung );

            comboBoxGioiTinh.Items.Add ( "Nam" );
            comboBoxGioiTinh.Items.Add("Nữ");
            comboBoxGioiTinh.SelectedIndex = 0;

        }

        private void checkBoxNgayKham_CheckedChanged(object sender, EventArgs e)
        {
            if ( checkBoxNgayKham.Checked == true )
            {
                dateTimePickerNgayKham.Enabled = true;
            }
            else
            {
                dateTimePickerNgayKham.Enabled = false;
            }

        }

        private void buttonTraCuu_Click(object sender, EventArgs e)
        {
            string query =
                "select distinct HoTen, NgayKham, TenBenh, TrieuChung from CHITIETDANHSACH,BENH,BENHNHAN,DANHSACHKHAMBENH where CHITIETDANHSACH.MaDanhSach = DANHSACHKHAMBENH.MaDanhSach and CHITIETDANHSACH.MaBenh = BENH.MaBenh and CHITIETDANHSACH.MaBenhNhan = BENHNHAN.MaBenhNhan ";
            if ( comboBoxMaBenhNhan.Enabled == true)
            {
                query += "and BENHNHAN.MaBenhNhan ='" + comboBoxMaBenhNhan.Text.ToString ( ) + "' ";

            }

            if (comboBoxHoTen.Enabled == true)
            {
                query += "and BENHNHAN.HoTen ='" + comboBoxHoTen.Text.ToString() + "' ";
            }

            if (comboBoxLoaiBenh.Enabled == true)
            {
                query += "and BENH.TenBenh ='" + comboBoxLoaiBenh.Text.ToString() + "' ";
            }

            if (comboBoxTenThuoc.Enabled == true)
            {
                query += "and LOAITHUOC.TenLoaiThuoc ='" + comboBoxTenThuoc.Text.ToString() + "' ";
            }

            if (comboBoxTrieuChung.Enabled == true)
            {
                query += "and CHITIETDANHSACH.TrieuChung ='" + comboBoxTrieuChung.Text.ToString() + "' ";
            }

            if (comboBoxGioiTinh.Enabled == true)
            {
                query += "and BENHNHAN.GioiTinh ='" + comboBoxGioiTinh.Text.ToString() + "' ";
            }

            if (dateTimePickerNgayKham.Enabled == true)
            {
                var date = dateTimePickerNgayKham.Value.ToString("yyyy-MM-dd");
                query += "and (DANHSACHKHAMBENH.NgayKham >= date('" + date + @"')
            AND NgayKham < date('" + date + "', '+1 day')) ";
            }

            BLL.TraCuuBenhNhan ( dataGridView1, query );
        }

        private void checkBoxMaBenhNhan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMaBenhNhan.Checked == true)
            {
                comboBoxMaBenhNhan.Enabled = true;
            }
            else
            {
                comboBoxMaBenhNhan.Enabled = false;
            }
        }

        private void checkBoxHoTen_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHoTen.Checked == true)
            {
                comboBoxHoTen.Enabled = true;
            }
            else
            {
                comboBoxHoTen.Enabled = false;
            }
        }

        private void checkBoxLoaiBenh_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLoaiBenh.Checked == true)
            {
                comboBoxLoaiBenh.Enabled = true;
            }
            else
            {
                comboBoxLoaiBenh.Enabled = false;
            }
        }

        private void checkBoxTrieuChung_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTrieuChung.Checked == true)
            {
                comboBoxTrieuChung.Enabled = true;
            }
            else
            {
                comboBoxTrieuChung.Enabled = false;
            }
        }

        private void checkBoxTenThuoc_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTenThuoc.Checked == true)
            {
                comboBoxTenThuoc.Enabled = true;
            }
            else
            {
                comboBoxTenThuoc.Enabled = false;
            }
        }

        private void checkBoxGioiTinh_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGioiTinh.Checked == true)
            {
                comboBoxGioiTinh.Enabled = true;
            }
            else
            {
                comboBoxGioiTinh.Enabled = false;
            }
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            string query =
                "select HoTen, NgayKham, TenBenh, TrieuChung from CHITIETDANHSACH,BENH,BENHNHAN,DANHSACHKHAMBENH where CHITIETDANHSACH.MaDanhSach = DANHSACHKHAMBENH.MaDanhSach and CHITIETDANHSACH.MaBenh = BENH.MaBenh and CHITIETDANHSACH.MaBenhNhan = BENHNHAN.MaBenhNhan ";
            BLL.TraCuuBenhNhan(dataGridView1, query);
        }
    }
}
