using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  BLL;

namespace GUI
{
    public partial class GUIXemBaoCao : Form
    {
        BLLXemBaoCao BLL = new BLLXemBaoCao (  );
        public GUIXemBaoCao()
        {
            InitializeComponent();
        }

        private void GUIXemBaoCao_Load(object sender, EventArgs e)
        {
            comboBoxLoaiBaoCao.Items.AddRange ( new []{"Báo Cáo Doanh Thu", "Báo Cáo Thuốc"} );
            comboBoxLoaiBaoCao.SelectedIndex = 0;
        }

        private void buttonXem_Click(object sender, EventArgs e)
        {
            if ( textBoxThang.Text != "" )
            {
                if (comboBoxLoaiBaoCao.SelectedIndex == 0)
                {

                    labelTong.Visible = true;
                    BLL.XemBaoCaoDoanhThu(dataGridViewBaoCao, int.Parse(textBoxThang.Text.ToString()));

                    float sum = 0f;

                    for (int i = 0; i < dataGridViewBaoCao.Rows.Count - 1; i++)
                    {
                        sum += Convert.ToInt32(dataGridViewBaoCao.Rows[i].Cells[2].Value);
                    }
                    labelTong.Text = sum.ToString(CultureInfo.InvariantCulture);
                    for (int i = 0; i < dataGridViewBaoCao.RowCount - 1; i++)
                    {
                        dataGridViewBaoCao[3, i].Value = (Convert.ToInt32(dataGridViewBaoCao.Rows[i].Cells[2].Value) / sum).ToString("0.00");

                    }

                }
                else
                {
                    labelTong.Visible = false;
                    BLL.XemBaoCaoThuoc(dataGridViewBaoCao, int.Parse(textBoxThang.Text.ToString()));
                }
            }
            else
            {
                MessageBox.Show ( "Chua nhap du lieu !" );
            }
           
        }
    }
}
