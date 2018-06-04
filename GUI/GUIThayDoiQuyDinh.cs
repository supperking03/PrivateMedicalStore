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
    public partial class GUIThayDoiQuyDinh : Form
    {
        BLLThayDoiQuyDinh BLL = new BLLThayDoiQuyDinh (  );
        public GUIThayDoiQuyDinh()
        {
            InitializeComponent();
        }

        private void GUIThayDoiQuyDinh_Load(object sender, EventArgs e)
        {
            comboBoxLoaiThayDoi.Items.AddRange ( new []{"Loại Bệnh", "Loại Thuốc", "Loại Đơn Vị", "Loại Cách Dùng"} );
            comboBoxLoaiThayDoi.SelectedIndex = 0;
            textBoxDonGia.Enabled = false;

            textBoxBenhNhanToiDa.Text = BLL.GetMaxBenhNhan ( ).ToString ( );

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxLoaiThayDoi.SelectedIndex == 1 )
            {
                textBoxDonGia.Enabled = true;
                BLL.LayTenLoaiThuoc ( comboBoxTenLoai );
            }
            else if (comboBoxLoaiThayDoi.SelectedIndex == 0)
            {
                textBoxDonGia.Enabled = false;
                BLL.LayTenLoaiBenh ( comboBoxTenLoai );

            }
            else if (comboBoxLoaiThayDoi.SelectedIndex == 2)
            {
                textBoxDonGia.Enabled = false;
                BLL.LayTenLoaiDonVi ( comboBoxTenLoai );
            }
            else if (comboBoxLoaiThayDoi.SelectedIndex == 3)
            {
                textBoxDonGia.Enabled = false;
                BLL.LayTenLoaiCachDung ( comboBoxTenLoai );
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLoaiThayDoi.SelectedIndex == 1)
            {
                textBoxDonGia.Text = BLL.LayDonGiaThuoc ( comboBoxTenLoai.Text.ToString ( ) ).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL.UpdateSoBenhNhanToiDaTrongNgay ( int.Parse(textBoxBenhNhanToiDa.Text.ToString()) );
            MessageBox.Show ( "OK!" );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBoxLoaiThayDoi.SelectedIndex == 0)
            {
                BLL.ThemLoaiBenh ( comboBoxTenLoai.Text.ToString() );
                BLL.LayTenLoaiBenh(comboBoxTenLoai);
                MessageBox.Show("OK!");
            }
            if (comboBoxLoaiThayDoi.SelectedIndex == 1)
            {
                BLL.ThemLoaiThuoc(comboBoxTenLoai.Text.ToString(),int.Parse ( textBoxDonGia.Text.ToString() ));
                BLL.LayTenLoaiThuoc(comboBoxTenLoai);
                MessageBox.Show("OK!");
            }
            if (comboBoxLoaiThayDoi.SelectedIndex == 2)
            {
                BLL.ThemDonVi(comboBoxTenLoai.Text.ToString());
                BLL.LayTenLoaiDonVi(comboBoxTenLoai);
                MessageBox.Show("OK!");
            }
            if (comboBoxLoaiThayDoi.SelectedIndex == 3)
            {
                BLL.ThemLoaiCachDung(comboBoxTenLoai.Text.ToString());
                BLL.LayTenLoaiCachDung(comboBoxTenLoai);
                MessageBox.Show("OK!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBoxLoaiThayDoi.SelectedIndex == 0)
            {
                BLL.XoaTen(comboBoxTenLoai.Text.ToString(),"BENH","TenBenh");
                BLL.LayTenLoaiBenh(comboBoxTenLoai);
                MessageBox.Show("OK!");
            }
            if (comboBoxLoaiThayDoi.SelectedIndex == 1)
            {
                BLL.XoaTen(comboBoxTenLoai.Text.ToString(),"LOAITHUOC","TenLoaiThuoc");
                BLL.LayTenLoaiThuoc(comboBoxTenLoai);
                MessageBox.Show("OK!");
            }
            if (comboBoxLoaiThayDoi.SelectedIndex == 2)
            {
                BLL.XoaTen(comboBoxTenLoai.Text.ToString(), "LOAIDONVI","TenDonVi");
                BLL.LayTenLoaiDonVi(comboBoxTenLoai);
                MessageBox.Show("OK!");
            }
            if (comboBoxLoaiThayDoi.SelectedIndex == 3)
            {
                BLL.XoaTen(comboBoxTenLoai.Text.ToString(),"LOAICACHDUNG", "TenLoaiCachDung");
                BLL.LayTenLoaiCachDung(comboBoxTenLoai);
                MessageBox.Show("OK!");
            }
        }
    }
}
