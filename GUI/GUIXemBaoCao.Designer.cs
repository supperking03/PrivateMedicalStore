namespace GUI
{
    partial class GUIXemBaoCao
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
            this.textBoxThang = new System.Windows.Forms.TextBox();
            this.dataGridViewBaoCao = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonXem = new System.Windows.Forms.Button();
            this.comboBoxLoaiBaoCao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxThang
            // 
            this.textBoxThang.Location = new System.Drawing.Point(183, 95);
            this.textBoxThang.Name = "textBoxThang";
            this.textBoxThang.Size = new System.Drawing.Size(100, 20);
            this.textBoxThang.TabIndex = 0;
            // 
            // dataGridViewBaoCao
            // 
            this.dataGridViewBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBaoCao.Location = new System.Drawing.Point(13, 161);
            this.dataGridViewBaoCao.Name = "dataGridViewBaoCao";
            this.dataGridViewBaoCao.Size = new System.Drawing.Size(443, 228);
            this.dataGridViewBaoCao.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Báo Cáo Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tháng";
            // 
            // buttonXem
            // 
            this.buttonXem.Location = new System.Drawing.Point(289, 94);
            this.buttonXem.Name = "buttonXem";
            this.buttonXem.Size = new System.Drawing.Size(76, 20);
            this.buttonXem.TabIndex = 4;
            this.buttonXem.Text = "XEM";
            this.buttonXem.UseVisualStyleBackColor = true;
            this.buttonXem.Click += new System.EventHandler(this.buttonXem_Click);
            // 
            // comboBoxLoaiBaoCao
            // 
            this.comboBoxLoaiBaoCao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLoaiBaoCao.FormattingEnabled = true;
            this.comboBoxLoaiBaoCao.Location = new System.Drawing.Point(183, 45);
            this.comboBoxLoaiBaoCao.Name = "comboBoxLoaiBaoCao";
            this.comboBoxLoaiBaoCao.Size = new System.Drawing.Size(100, 21);
            this.comboBoxLoaiBaoCao.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Loại Báo Cáo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tổng:";
            // 
            // labelTong
            // 
            this.labelTong.AutoSize = true;
            this.labelTong.Location = new System.Drawing.Point(373, 145);
            this.labelTong.Name = "labelTong";
            this.labelTong.Size = new System.Drawing.Size(35, 13);
            this.labelTong.TabIndex = 8;
            this.labelTong.Text = "label5";
            // 
            // GUIXemBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 391);
            this.Controls.Add(this.labelTong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxLoaiBaoCao);
            this.Controls.Add(this.buttonXem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewBaoCao);
            this.Controls.Add(this.textBoxThang);
            this.Name = "GUIXemBaoCao";
            this.Text = "GUIXemBaoCao";
            this.Load += new System.EventHandler(this.GUIXemBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaoCao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxThang;
        private System.Windows.Forms.DataGridView dataGridViewBaoCao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonXem;
        private System.Windows.Forms.ComboBox comboBoxLoaiBaoCao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTong;
    }
}