namespace GUI
{
    partial class GUITraCuuBenhNhan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonTraCuu = new System.Windows.Forms.Button();
            this.dateTimePickerNgayKham = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxNgayKham = new System.Windows.Forms.CheckBox();
            this.comboBoxMaBenhNhan = new System.Windows.Forms.ComboBox();
            this.comboBoxHoTen = new System.Windows.Forms.ComboBox();
            this.comboBoxLoaiBenh = new System.Windows.Forms.ComboBox();
            this.comboBoxTrieuChung = new System.Windows.Forms.ComboBox();
            this.comboBoxTenThuoc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxGioiTinh = new System.Windows.Forms.ComboBox();
            this.checkBoxMaBenhNhan = new System.Windows.Forms.CheckBox();
            this.checkBoxHoTen = new System.Windows.Forms.CheckBox();
            this.checkBoxLoaiBenh = new System.Windows.Forms.CheckBox();
            this.checkBoxTrieuChung = new System.Windows.Forms.CheckBox();
            this.checkBoxTenThuoc = new System.Windows.Forms.CheckBox();
            this.checkBoxGioiTinh = new System.Windows.Forms.CheckBox();
            this.buttonAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(329, 225);
            this.dataGridView1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã Bệnh Nhân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Họ Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Loại Bệnh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Triệu Chứng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tên Thuốc";
            // 
            // buttonTraCuu
            // 
            this.buttonTraCuu.Location = new System.Drawing.Point(281, 36);
            this.buttonTraCuu.Name = "buttonTraCuu";
            this.buttonTraCuu.Size = new System.Drawing.Size(74, 72);
            this.buttonTraCuu.TabIndex = 15;
            this.buttonTraCuu.Text = "Tra Cứu Bệnh Nhân";
            this.buttonTraCuu.UseVisualStyleBackColor = true;
            this.buttonTraCuu.Click += new System.EventHandler(this.buttonTraCuu_Click);
            // 
            // dateTimePickerNgayKham
            // 
            this.dateTimePickerNgayKham.Location = new System.Drawing.Point(117, 10);
            this.dateTimePickerNgayKham.Name = "dateTimePickerNgayKham";
            this.dateTimePickerNgayKham.Size = new System.Drawing.Size(217, 20);
            this.dateTimePickerNgayKham.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ngày Khám";
            // 
            // checkBoxNgayKham
            // 
            this.checkBoxNgayKham.AutoSize = true;
            this.checkBoxNgayKham.Location = new System.Drawing.Point(340, 12);
            this.checkBoxNgayKham.Name = "checkBoxNgayKham";
            this.checkBoxNgayKham.Size = new System.Drawing.Size(15, 14);
            this.checkBoxNgayKham.TabIndex = 18;
            this.checkBoxNgayKham.UseVisualStyleBackColor = true;
            this.checkBoxNgayKham.CheckedChanged += new System.EventHandler(this.checkBoxNgayKham_CheckedChanged);
            // 
            // comboBoxMaBenhNhan
            // 
            this.comboBoxMaBenhNhan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxMaBenhNhan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxMaBenhNhan.FormattingEnabled = true;
            this.comboBoxMaBenhNhan.Location = new System.Drawing.Point(118, 35);
            this.comboBoxMaBenhNhan.Name = "comboBoxMaBenhNhan";
            this.comboBoxMaBenhNhan.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMaBenhNhan.TabIndex = 19;
            // 
            // comboBoxHoTen
            // 
            this.comboBoxHoTen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxHoTen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxHoTen.FormattingEnabled = true;
            this.comboBoxHoTen.Location = new System.Drawing.Point(118, 62);
            this.comboBoxHoTen.Name = "comboBoxHoTen";
            this.comboBoxHoTen.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHoTen.TabIndex = 20;
            // 
            // comboBoxLoaiBenh
            // 
            this.comboBoxLoaiBenh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxLoaiBenh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxLoaiBenh.FormattingEnabled = true;
            this.comboBoxLoaiBenh.Location = new System.Drawing.Point(118, 87);
            this.comboBoxLoaiBenh.Name = "comboBoxLoaiBenh";
            this.comboBoxLoaiBenh.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLoaiBenh.TabIndex = 21;
            // 
            // comboBoxTrieuChung
            // 
            this.comboBoxTrieuChung.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxTrieuChung.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTrieuChung.FormattingEnabled = true;
            this.comboBoxTrieuChung.Location = new System.Drawing.Point(118, 113);
            this.comboBoxTrieuChung.Name = "comboBoxTrieuChung";
            this.comboBoxTrieuChung.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTrieuChung.TabIndex = 22;
            // 
            // comboBoxTenThuoc
            // 
            this.comboBoxTenThuoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxTenThuoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTenThuoc.FormattingEnabled = true;
            this.comboBoxTenThuoc.Location = new System.Drawing.Point(118, 139);
            this.comboBoxTenThuoc.Name = "comboBoxTenThuoc";
            this.comboBoxTenThuoc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTenThuoc.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Giới Tính";
            // 
            // comboBoxGioiTinh
            // 
            this.comboBoxGioiTinh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxGioiTinh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxGioiTinh.FormattingEnabled = true;
            this.comboBoxGioiTinh.Location = new System.Drawing.Point(118, 169);
            this.comboBoxGioiTinh.Name = "comboBoxGioiTinh";
            this.comboBoxGioiTinh.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGioiTinh.TabIndex = 24;
            // 
            // checkBoxMaBenhNhan
            // 
            this.checkBoxMaBenhNhan.AutoSize = true;
            this.checkBoxMaBenhNhan.Location = new System.Drawing.Point(256, 36);
            this.checkBoxMaBenhNhan.Name = "checkBoxMaBenhNhan";
            this.checkBoxMaBenhNhan.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMaBenhNhan.TabIndex = 25;
            this.checkBoxMaBenhNhan.UseVisualStyleBackColor = true;
            this.checkBoxMaBenhNhan.CheckedChanged += new System.EventHandler(this.checkBoxMaBenhNhan_CheckedChanged);
            // 
            // checkBoxHoTen
            // 
            this.checkBoxHoTen.AutoSize = true;
            this.checkBoxHoTen.Location = new System.Drawing.Point(256, 65);
            this.checkBoxHoTen.Name = "checkBoxHoTen";
            this.checkBoxHoTen.Size = new System.Drawing.Size(15, 14);
            this.checkBoxHoTen.TabIndex = 26;
            this.checkBoxHoTen.UseVisualStyleBackColor = true;
            this.checkBoxHoTen.CheckedChanged += new System.EventHandler(this.checkBoxHoTen_CheckedChanged);
            // 
            // checkBoxLoaiBenh
            // 
            this.checkBoxLoaiBenh.AutoSize = true;
            this.checkBoxLoaiBenh.Location = new System.Drawing.Point(256, 91);
            this.checkBoxLoaiBenh.Name = "checkBoxLoaiBenh";
            this.checkBoxLoaiBenh.Size = new System.Drawing.Size(15, 14);
            this.checkBoxLoaiBenh.TabIndex = 27;
            this.checkBoxLoaiBenh.UseVisualStyleBackColor = true;
            this.checkBoxLoaiBenh.CheckedChanged += new System.EventHandler(this.checkBoxLoaiBenh_CheckedChanged);
            // 
            // checkBoxTrieuChung
            // 
            this.checkBoxTrieuChung.AutoSize = true;
            this.checkBoxTrieuChung.Location = new System.Drawing.Point(256, 117);
            this.checkBoxTrieuChung.Name = "checkBoxTrieuChung";
            this.checkBoxTrieuChung.Size = new System.Drawing.Size(15, 14);
            this.checkBoxTrieuChung.TabIndex = 28;
            this.checkBoxTrieuChung.UseVisualStyleBackColor = true;
            this.checkBoxTrieuChung.CheckedChanged += new System.EventHandler(this.checkBoxTrieuChung_CheckedChanged);
            // 
            // checkBoxTenThuoc
            // 
            this.checkBoxTenThuoc.AutoSize = true;
            this.checkBoxTenThuoc.Location = new System.Drawing.Point(256, 143);
            this.checkBoxTenThuoc.Name = "checkBoxTenThuoc";
            this.checkBoxTenThuoc.Size = new System.Drawing.Size(15, 14);
            this.checkBoxTenThuoc.TabIndex = 29;
            this.checkBoxTenThuoc.UseVisualStyleBackColor = true;
            this.checkBoxTenThuoc.CheckedChanged += new System.EventHandler(this.checkBoxTenThuoc_CheckedChanged);
            // 
            // checkBoxGioiTinh
            // 
            this.checkBoxGioiTinh.AutoSize = true;
            this.checkBoxGioiTinh.Location = new System.Drawing.Point(256, 172);
            this.checkBoxGioiTinh.Name = "checkBoxGioiTinh";
            this.checkBoxGioiTinh.Size = new System.Drawing.Size(15, 14);
            this.checkBoxGioiTinh.TabIndex = 30;
            this.checkBoxGioiTinh.UseVisualStyleBackColor = true;
            this.checkBoxGioiTinh.CheckedChanged += new System.EventHandler(this.checkBoxGioiTinh_CheckedChanged);
            // 
            // buttonAll
            // 
            this.buttonAll.Location = new System.Drawing.Point(281, 113);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(74, 77);
            this.buttonAll.TabIndex = 31;
            this.buttonAll.Text = "Xem Tất Cả Bệnh Nhân";
            this.buttonAll.UseVisualStyleBackColor = true;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // GUITraCuuBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 455);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.checkBoxGioiTinh);
            this.Controls.Add(this.checkBoxTenThuoc);
            this.Controls.Add(this.checkBoxTrieuChung);
            this.Controls.Add(this.checkBoxLoaiBenh);
            this.Controls.Add(this.checkBoxHoTen);
            this.Controls.Add(this.checkBoxMaBenhNhan);
            this.Controls.Add(this.comboBoxGioiTinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxTenThuoc);
            this.Controls.Add(this.comboBoxTrieuChung);
            this.Controls.Add(this.comboBoxLoaiBenh);
            this.Controls.Add(this.comboBoxHoTen);
            this.Controls.Add(this.comboBoxMaBenhNhan);
            this.Controls.Add(this.checkBoxNgayKham);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePickerNgayKham);
            this.Controls.Add(this.buttonTraCuu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GUITraCuuBenhNhan";
            this.Text = "GUITraCuuBenhNhan";
            this.Load += new System.EventHandler(this.GUITraCuuBenhNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonTraCuu;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayKham;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxNgayKham;
        private System.Windows.Forms.ComboBox comboBoxMaBenhNhan;
        private System.Windows.Forms.ComboBox comboBoxHoTen;
        private System.Windows.Forms.ComboBox comboBoxLoaiBenh;
        private System.Windows.Forms.ComboBox comboBoxTrieuChung;
        private System.Windows.Forms.ComboBox comboBoxTenThuoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxGioiTinh;
        private System.Windows.Forms.CheckBox checkBoxMaBenhNhan;
        private System.Windows.Forms.CheckBox checkBoxHoTen;
        private System.Windows.Forms.CheckBox checkBoxLoaiBenh;
        private System.Windows.Forms.CheckBox checkBoxTrieuChung;
        private System.Windows.Forms.CheckBox checkBoxTenThuoc;
        private System.Windows.Forms.CheckBox checkBoxGioiTinh;
        private System.Windows.Forms.Button buttonAll;
    }
}