namespace GUI
{
    partial class GUILapDanhSachKhamBenh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNgayKham = new System.Windows.Forms.Label();
            this.dateTimePickerNgayKham = new System.Windows.Forms.DateTimePicker();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.dataGridViewChiTietDanhSach = new System.Windows.Forms.DataGridView();
            this.textBoxHoTen = new System.Windows.Forms.TextBox();
            this.richTextBoxDiaChi = new System.Windows.Forms.RichTextBox();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.labelGioiTinh = new System.Windows.Forms.Label();
            this.labelNamSinh = new System.Windows.Forms.Label();
            this.labelDiaChi = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBoxGioiTinh = new System.Windows.Forms.ComboBox();
            this.comboBoxNamSinh = new System.Windows.Forms.ComboBox();
            this.buttonLapDanhSachKhamBenh = new System.Windows.Forms.Button();
            this.ButtonLapPhieuKhamBenh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNgayKham
            // 
            this.labelNgayKham.AutoSize = true;
            this.labelNgayKham.Location = new System.Drawing.Point(40, 24);
            this.labelNgayKham.Name = "labelNgayKham";
            this.labelNgayKham.Size = new System.Drawing.Size(61, 13);
            this.labelNgayKham.TabIndex = 1;
            this.labelNgayKham.Text = "Ngày Nhập";
            // 
            // dateTimePickerNgayKham
            // 
            this.dateTimePickerNgayKham.Location = new System.Drawing.Point(134, 18);
            this.dateTimePickerNgayKham.Name = "dateTimePickerNgayKham";
            this.dateTimePickerNgayKham.Size = new System.Drawing.Size(258, 20);
            this.dateTimePickerNgayKham.TabIndex = 2;
            this.dateTimePickerNgayKham.ValueChanged += new System.EventHandler(this.dateTimePickerNgayKham_ValueChanged);
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(134, 46);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.ReadOnly = true;
            this.textBoxMax.Size = new System.Drawing.Size(43, 20);
            this.textBoxMax.TabIndex = 3;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(134, 72);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.ReadOnly = true;
            this.textBoxCount.Size = new System.Drawing.Size(43, 20);
            this.textBoxCount.TabIndex = 4;
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(40, 49);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(83, 13);
            this.labelMax.TabIndex = 7;
            this.labelMax.Text = "Số Bệnh Tối Đa";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(40, 75);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(77, 13);
            this.labelCount.TabIndex = 8;
            this.labelCount.Text = "Số Bệnh Nhân";
            // 
            // dataGridViewChiTietDanhSach
            // 
            this.dataGridViewChiTietDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiTietDanhSach.Location = new System.Drawing.Point(21, 267);
            this.dataGridViewChiTietDanhSach.Name = "dataGridViewChiTietDanhSach";
            this.dataGridViewChiTietDanhSach.Size = new System.Drawing.Size(313, 152);
            this.dataGridViewChiTietDanhSach.TabIndex = 11;
            this.dataGridViewChiTietDanhSach.SelectionChanged += new System.EventHandler(this.dataGridViewChiTietDanhSach_SelectionChanged);
            this.dataGridViewChiTietDanhSach.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewChiTietDanhSach_MouseDown);
            // 
            // textBoxHoTen
            // 
            this.textBoxHoTen.Location = new System.Drawing.Point(134, 98);
            this.textBoxHoTen.Name = "textBoxHoTen";
            this.textBoxHoTen.Size = new System.Drawing.Size(258, 20);
            this.textBoxHoTen.TabIndex = 13;
            // 
            // richTextBoxDiaChi
            // 
            this.richTextBoxDiaChi.Location = new System.Drawing.Point(134, 177);
            this.richTextBoxDiaChi.Name = "richTextBoxDiaChi";
            this.richTextBoxDiaChi.Size = new System.Drawing.Size(258, 47);
            this.richTextBoxDiaChi.TabIndex = 16;
            this.richTextBoxDiaChi.Text = "";
            // 
            // labelHoTen
            // 
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Location = new System.Drawing.Point(43, 101);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(43, 13);
            this.labelHoTen.TabIndex = 17;
            this.labelHoTen.Text = "Họ Tên";
            // 
            // labelGioiTinh
            // 
            this.labelGioiTinh.AutoSize = true;
            this.labelGioiTinh.Location = new System.Drawing.Point(43, 127);
            this.labelGioiTinh.Name = "labelGioiTinh";
            this.labelGioiTinh.Size = new System.Drawing.Size(51, 13);
            this.labelGioiTinh.TabIndex = 18;
            this.labelGioiTinh.Text = "Giới Tính";
            // 
            // labelNamSinh
            // 
            this.labelNamSinh.AutoSize = true;
            this.labelNamSinh.Location = new System.Drawing.Point(43, 153);
            this.labelNamSinh.Name = "labelNamSinh";
            this.labelNamSinh.Size = new System.Drawing.Size(53, 13);
            this.labelNamSinh.TabIndex = 19;
            this.labelNamSinh.Text = "Năm Sinh";
            // 
            // labelDiaChi
            // 
            this.labelDiaChi.AutoSize = true;
            this.labelDiaChi.Location = new System.Drawing.Point(43, 180);
            this.labelDiaChi.Name = "labelDiaChi";
            this.labelDiaChi.Size = new System.Drawing.Size(40, 13);
            this.labelDiaChi.TabIndex = 20;
            this.labelDiaChi.Text = "Địa chỉ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Xoá Bệnh Nhân";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(222, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "Cập Nhật";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBoxGioiTinh
            // 
            this.comboBoxGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGioiTinh.FormattingEnabled = true;
            this.comboBoxGioiTinh.Location = new System.Drawing.Point(134, 123);
            this.comboBoxGioiTinh.Name = "comboBoxGioiTinh";
            this.comboBoxGioiTinh.Size = new System.Drawing.Size(64, 21);
            this.comboBoxGioiTinh.TabIndex = 24;
            // 
            // comboBoxNamSinh
            // 
            this.comboBoxNamSinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNamSinh.FormattingEnabled = true;
            this.comboBoxNamSinh.Location = new System.Drawing.Point(134, 150);
            this.comboBoxNamSinh.Name = "comboBoxNamSinh";
            this.comboBoxNamSinh.Size = new System.Drawing.Size(64, 21);
            this.comboBoxNamSinh.TabIndex = 25;
            // 
            // buttonLapDanhSachKhamBenh
            // 
            this.buttonLapDanhSachKhamBenh.Location = new System.Drawing.Point(340, 380);
            this.buttonLapDanhSachKhamBenh.Name = "buttonLapDanhSachKhamBenh";
            this.buttonLapDanhSachKhamBenh.Size = new System.Drawing.Size(75, 39);
            this.buttonLapDanhSachKhamBenh.TabIndex = 26;
            this.buttonLapDanhSachKhamBenh.Text = "Chỉnh Sửa Danh Sách";
            this.buttonLapDanhSachKhamBenh.UseVisualStyleBackColor = true;
            this.buttonLapDanhSachKhamBenh.Click += new System.EventHandler(this.buttonLapDanhSachKhamBenh_Click);
            // 
            // ButtonLapPhieuKhamBenh
            // 
            this.ButtonLapPhieuKhamBenh.Location = new System.Drawing.Point(340, 267);
            this.ButtonLapPhieuKhamBenh.Name = "ButtonLapPhieuKhamBenh";
            this.ButtonLapPhieuKhamBenh.Size = new System.Drawing.Size(75, 107);
            this.ButtonLapPhieuKhamBenh.TabIndex = 27;
            this.ButtonLapPhieuKhamBenh.Text = "Lập Phiếu Khám Bệnh";
            this.ButtonLapPhieuKhamBenh.UseVisualStyleBackColor = true;
            this.ButtonLapPhieuKhamBenh.Click += new System.EventHandler(this.ButtonLapPhieuKhamBenh_Click);
            // 
            // GUILapDanhSachKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 431);
            this.Controls.Add(this.ButtonLapPhieuKhamBenh);
            this.Controls.Add(this.buttonLapDanhSachKhamBenh);
            this.Controls.Add(this.comboBoxNamSinh);
            this.Controls.Add(this.comboBoxGioiTinh);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.labelDiaChi);
            this.Controls.Add(this.labelNamSinh);
            this.Controls.Add(this.labelGioiTinh);
            this.Controls.Add(this.labelHoTen);
            this.Controls.Add(this.richTextBoxDiaChi);
            this.Controls.Add(this.textBoxHoTen);
            this.Controls.Add(this.dataGridViewChiTietDanhSach);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.dateTimePickerNgayKham);
            this.Controls.Add(this.labelNgayKham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GUILapDanhSachKhamBenh";
            this.Text = "Danh Sách Khám Bệnh";
            this.Load += new System.EventHandler(this.GUILapDanhSachKhamBenh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNgayKham;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayKham;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.DataGridView dataGridViewChiTietDanhSach;
        private System.Windows.Forms.TextBox textBoxHoTen;
        private System.Windows.Forms.RichTextBox richTextBoxDiaChi;
        private System.Windows.Forms.Label labelHoTen;
        private System.Windows.Forms.Label labelGioiTinh;
        private System.Windows.Forms.Label labelNamSinh;
        private System.Windows.Forms.Label labelDiaChi;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBoxGioiTinh;
        private System.Windows.Forms.ComboBox comboBoxNamSinh;
        private System.Windows.Forms.Button buttonLapDanhSachKhamBenh;
        private System.Windows.Forms.Button ButtonLapPhieuKhamBenh;
    }
}