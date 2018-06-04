namespace GUI
{
    partial class GUIMainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDSBN = new System.Windows.Forms.Button();
            this.buttonTCBN = new System.Windows.Forms.Button();
            this.buttonTDQD = new System.Windows.Forms.Button();
            this.buttonXBC = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phòng Mạch Tư";
            // 
            // buttonDSBN
            // 
            this.buttonDSBN.Location = new System.Drawing.Point(12, 59);
            this.buttonDSBN.Name = "buttonDSBN";
            this.buttonDSBN.Size = new System.Drawing.Size(130, 102);
            this.buttonDSBN.TabIndex = 1;
            this.buttonDSBN.Text = "Danh Sách Khám Bệnh";
            this.buttonDSBN.UseVisualStyleBackColor = true;
            this.buttonDSBN.Click += new System.EventHandler(this.buttonDSBN_Click);
            // 
            // buttonTCBN
            // 
            this.buttonTCBN.Location = new System.Drawing.Point(148, 59);
            this.buttonTCBN.Name = "buttonTCBN";
            this.buttonTCBN.Size = new System.Drawing.Size(134, 102);
            this.buttonTCBN.TabIndex = 2;
            this.buttonTCBN.Text = "Tra Cứu Bệnh Nhân";
            this.buttonTCBN.UseVisualStyleBackColor = true;
            this.buttonTCBN.Click += new System.EventHandler(this.buttonTCBN_Click);
            // 
            // buttonTDQD
            // 
            this.buttonTDQD.Location = new System.Drawing.Point(12, 177);
            this.buttonTDQD.Name = "buttonTDQD";
            this.buttonTDQD.Size = new System.Drawing.Size(130, 102);
            this.buttonTDQD.TabIndex = 3;
            this.buttonTDQD.Text = "Thay Đổi Quy Định";
            this.buttonTDQD.UseVisualStyleBackColor = true;
            this.buttonTDQD.Click += new System.EventHandler(this.buttonTDQD_Click);
            // 
            // buttonXBC
            // 
            this.buttonXBC.Location = new System.Drawing.Point(148, 177);
            this.buttonXBC.Name = "buttonXBC";
            this.buttonXBC.Size = new System.Drawing.Size(134, 102);
            this.buttonXBC.TabIndex = 4;
            this.buttonXBC.Text = "Xem Báo Cáo";
            this.buttonXBC.UseVisualStyleBackColor = true;
            this.buttonXBC.Click += new System.EventHandler(this.buttonXBC_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Người dùng";
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(111, 32);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(135, 21);
            this.comboBoxUser.TabIndex = 25;
            this.comboBoxUser.SelectedIndexChanged += new System.EventHandler(this.comboBoxUser_SelectedIndexChanged);
            // 
            // GUIMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 290);
            this.Controls.Add(this.comboBoxUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonXBC);
            this.Controls.Add(this.buttonTDQD);
            this.Controls.Add(this.buttonTCBN);
            this.Controls.Add(this.buttonDSBN);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GUIMainForm";
            this.Text = "Màn Hình Chính";
            this.Load += new System.EventHandler(this.GUIMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDSBN;
        private System.Windows.Forms.Button buttonTCBN;
        private System.Windows.Forms.Button buttonTDQD;
        private System.Windows.Forms.Button buttonXBC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxUser;
    }
}