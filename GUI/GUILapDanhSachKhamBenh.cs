using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
using DTO;

namespace GUI
{
    public partial class GUILapDanhSachKhamBenh : Form
    {

        BLLDanhSachKhamBenh BLL = new BLLDanhSachKhamBenh ( );

        public GUILapDanhSachKhamBenh ( )
        {
            InitializeComponent ( );
        }

        private void button2_Click ( object sender, EventArgs e )
        {
            if ( buttonLapDanhSachKhamBenh.Enabled == true )
            {
                MessageBox.Show ( "Để thêm bệnh nhân, yêu cầu tạo mới danh sách !" );
            }
            else
            {
                if ((textBoxHoTen.Text != "") &&
                    (richTextBoxDiaChi.Text != ""))
                {
                    if (dataGridViewChiTietDanhSach.RowCount <= BLL.GetMaxBenhNhan())
                    {
                        BLL.AddBenhNhan(textBoxHoTen.Text.ToString(), comboBoxGioiTinh.Text.ToString(),
                            int.Parse(comboBoxNamSinh.Text.ToString()), richTextBoxDiaChi.Text.ToString());
                        // add chi tiet danh sách
                        BLL.AddChiTietDanhSach();

                        BLL.TimDanhSachTheoNgay(dateTimePickerNgayKham.Value, dataGridViewChiTietDanhSach);
                        textBoxCount.Text = (dataGridViewChiTietDanhSach.RowCount - 1).ToString();


                    }
                    else
                    {
                        MessageBox.Show("So Benh Nhanh dat muc gioi han !");
                    }
                }
                else
                {
                    MessageBox.Show("Nhap thieu thong tin, vui long kiem tra lai ");
                }
            }
 

        }

        private void GUILapDanhSachKhamBenh_Load ( object sender, EventArgs e )
        {

            textBoxMax.Text = BLL.GetMaxBenhNhan ( ).ToString ( );
            BLL.TimDanhSachTheoNgay ( dateTimePickerNgayKham.Value, dataGridViewChiTietDanhSach );
            comboBoxGioiTinh.Items.AddRange ( new [ ]
            {
                "Nam",
                "Nữ"
            } );
            for ( int i = 1900; i <= DateTime.Now.Year; i++ )
            {
                comboBoxNamSinh.Items.Add ( i );
            }

            comboBoxNamSinh.SelectedIndex = 0;
            comboBoxGioiTinh.SelectedIndex = 0;

            textBoxCount.Text = (dataGridViewChiTietDanhSach.RowCount-1).ToString();// count
        }

        private void dataGridViewChiTietDanhSach_MouseDown ( object sender, MouseEventArgs e )
        {

        }

        private string _selectedMaBenhNhan = "";
        private string _selectedHoTen = "";
        private string _selectedGioiTinh = "";
        private string _selectedNamSinh= "";
        private string _selectedDiaChi = "";
        private void dataGridViewChiTietDanhSach_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewChiTietDanhSach.SelectedRows)
            {
                _selectedMaBenhNhan = row.Cells[0].Value.ToString();
                _selectedHoTen = row.Cells[1].Value.ToString();
                _selectedGioiTinh = row.Cells[2].Value.ToString();
                _selectedNamSinh = row.Cells[3].Value.ToString();
                _selectedDiaChi = row.Cells[4].Value.ToString();
                //...
            }

            textBoxHoTen.Text = _selectedHoTen;
            comboBoxGioiTinh.Text = _selectedGioiTinh;
            comboBoxNamSinh.Text = _selectedNamSinh;
            richTextBoxDiaChi.Text = _selectedDiaChi;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BLL.DeleteBenhNhan ( _selectedMaBenhNhan );
            BLL.TimDanhSachTheoNgay(dateTimePickerNgayKham.Value,dataGridViewChiTietDanhSach);
            textBoxCount.Text = (dataGridViewChiTietDanhSach.RowCount-1).ToString ( );
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BLL.UpdateBenhNhan ( _selectedMaBenhNhan, textBoxHoTen.Text.ToString(), comboBoxGioiTinh.Text.ToString(), int.Parse (comboBoxNamSinh.Text.ToString()), richTextBoxDiaChi.Text.ToString());
            BLL.TimDanhSachTheoNgay(dateTimePickerNgayKham.Value, dataGridViewChiTietDanhSach);
            textBoxHoTen.Text = "";
            richTextBoxDiaChi.Text = "";
        }

        private void buttonLapDanhSachKhamBenh_Click(object sender, EventArgs e)
        {
            if ( buttonLapDanhSachKhamBenh.Enabled == true )
            {
                buttonLapDanhSachKhamBenh.Enabled = false;
            }
            BLL.AddDanhSach (dateTimePickerNgayKham.Value );

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            BLL.TimDanhSachTheoNgay ( dateTimePickerNgayKham.Value, dataGridViewChiTietDanhSach );
        }

        private void dateTimePickerNgayKham_ValueChanged(object sender, EventArgs e)
        {
            BLL.TimDanhSachTheoNgay ( dateTimePickerNgayKham.Value, dataGridViewChiTietDanhSach );
            buttonLapDanhSachKhamBenh.Enabled = true;
            textBoxCount.Text = (dataGridViewChiTietDanhSach.RowCount - 1).ToString();// count
        }

        private void ButtonLapPhieuKhamBenh_Click(object sender, EventArgs e)
        {
            if (buttonLapDanhSachKhamBenh.Enabled == true)
            {
                MessageBox.Show("Để thêm bệnh nhân, yêu cầu tạo mới danh sách !");
            }
            else
            {
                if ((textBoxHoTen.Text != "") &&
                    (richTextBoxDiaChi.Text != ""))
                {
                    if (dataGridViewChiTietDanhSach.RowCount <= BLL.GetMaxBenhNhan())
                    {
                        BLL.AddBenhNhan(textBoxHoTen.Text.ToString(), comboBoxGioiTinh.Text.ToString(),
                            int.Parse(comboBoxNamSinh.Text.ToString()), richTextBoxDiaChi.Text.ToString());
                        BLL.AddChiTietDanhSach (  );



                        GUILapPhieuKhamBenh PhieuKhamBenh = new GUILapPhieuKhamBenh(dateTimePickerNgayKham.Value,textBoxHoTen.Text.ToString());
                        //var dialogResult = PhieuKhamBenh.ShowDialog();
                        //MessageBox.Show("Oops!");
                        PhieuKhamBenh.Show();
                        BLL.TimDanhSachTheoNgay(dateTimePickerNgayKham.Value, dataGridViewChiTietDanhSach);
                        textBoxCount.Text = (dataGridViewChiTietDanhSach.RowCount - 1).ToString();








                    }
                    else
                    {
                        MessageBox.Show("So Benh Nhanh dat muc gioi han !");
                    }
                }
                else
                {
                    MessageBox.Show("Nhap thieu thong tin, vui long kiem tra lai ");
                }
            }
        }

        private void buttonTraCuu_Click(object sender, EventArgs e)
        {
            GUITraCuuBenhNhan tcbn = new GUITraCuuBenhNhan (  );
            tcbn.Show();
        }
    }
}
