using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI;

namespace GUI
{
    public partial class GUIMainForm : Form
    {
        public GUIMainForm()
        {
            InitializeComponent();
        }

        private void buttonDSBN_Click(object sender, EventArgs e)
        {
            GUILapDanhSachKhamBenh ldskb = new GUILapDanhSachKhamBenh (  );
            ldskb.Show();
        }

        private void buttonTCBN_Click(object sender, EventArgs e)
        {
            GUITraCuuBenhNhan tc = new GUITraCuuBenhNhan (  );
            tc.Show();
        }

        private void GUIMainForm_Load(object sender, EventArgs e)
        {
            comboBoxUser.Items.Add ( "Lễ Tân" );
            comboBoxUser.Items.Add("Thủ Quỹ");
            comboBoxUser.Items.Add("Ông Chủ");
            comboBoxUser.SelectedIndex = 0;
            buttonTDQD.Enabled = false;
            buttonXBC.Enabled = false;
        }

        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( comboBoxUser.SelectedIndex == 0 )
            {
                buttonDSBN.Enabled = true;
                buttonTCBN.Enabled = true;
                buttonTDQD.Enabled = false;
                buttonXBC.Enabled = false;
            }
            if (comboBoxUser.SelectedIndex == 1)
            {
                buttonDSBN.Enabled = true;
                buttonTCBN.Enabled = true;
                buttonTDQD.Enabled = false;
                buttonXBC.Enabled = true;
            }

            if (comboBoxUser.SelectedIndex == 2)
            {
                buttonDSBN.Enabled = true;
                buttonTCBN.Enabled = true;
                buttonTDQD.Enabled = true;
                buttonXBC.Enabled = true;
            }
        }

        private void buttonTDQD_Click(object sender, EventArgs e)
        {
            GUIThayDoiQuyDinh td = new GUIThayDoiQuyDinh (  );
            td.Show();
        }

        private void buttonXBC_Click(object sender, EventArgs e)
        {
            GUIXemBaoCao bc = new GUIXemBaoCao (  );
            bc.Show();
        }
    }
}
