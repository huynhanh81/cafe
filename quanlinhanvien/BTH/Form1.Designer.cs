namespace BTH
{
    partial class Form1
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
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDongy = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.chNam = new System.Windows.Forms.CheckBox();
            this.chNu = new System.Windows.Forms.CheckBox();
            this.cmbBophan = new System.Windows.Forms.ComboBox();
            this.cmbKhuvuc = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhân Viên";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(3, 25);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(733, 192);
            this.dgvNhanVien.TabIndex = 1;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số ĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số CMND";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Họ và tên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(397, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Thông Tin Nhân Viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 471);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Khu Vực";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(397, 435);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Bộ phận";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 232);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(127, 232);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(245, 232);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDongy
            // 
            this.btnDongy.Location = new System.Drawing.Point(474, 493);
            this.btnDongy.Name = "btnDongy";
            this.btnDongy.Size = new System.Drawing.Size(75, 23);
            this.btnDongy.TabIndex = 12;
            this.btnDongy.Text = "Đồng ý";
            this.btnDongy.UseVisualStyleBackColor = true;
            this.btnDongy.Click += new System.EventHandler(this.btnDongy_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(561, 493);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(75, 23);
            this.btnBoqua.TabIndex = 13;
            this.btnBoqua.Text = "Bỏ Qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(474, 301);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(162, 20);
            this.txthoten.TabIndex = 14;
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(474, 368);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(162, 20);
            this.txtDT.TabIndex = 15;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(474, 334);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(162, 20);
            this.txtCMND.TabIndex = 16;
            // 
            // chNam
            // 
            this.chNam.AutoSize = true;
            this.chNam.Location = new System.Drawing.Point(474, 398);
            this.chNam.Name = "chNam";
            this.chNam.Size = new System.Drawing.Size(48, 17);
            this.chNam.TabIndex = 17;
            this.chNam.Text = "Nam";
            this.chNam.UseVisualStyleBackColor = true;
            this.chNam.CheckedChanged += new System.EventHandler(this.chNam_CheckedChanged);
            // 
            // chNu
            // 
            this.chNu.AutoSize = true;
            this.chNu.Location = new System.Drawing.Point(556, 398);
            this.chNu.Name = "chNu";
            this.chNu.Size = new System.Drawing.Size(40, 17);
            this.chNu.TabIndex = 18;
            this.chNu.Text = "Nữ";
            this.chNu.UseVisualStyleBackColor = true;
            this.chNu.CheckedChanged += new System.EventHandler(this.chNu_CheckedChanged);
            // 
            // cmbBophan
            // 
            this.cmbBophan.FormattingEnabled = true;
            this.cmbBophan.Items.AddRange(new object[] {
            "Quản lý",
            "Phục vụ",
            "Tạp vụ"});
            this.cmbBophan.Location = new System.Drawing.Point(474, 427);
            this.cmbBophan.Name = "cmbBophan";
            this.cmbBophan.Size = new System.Drawing.Size(162, 21);
            this.cmbBophan.TabIndex = 19;
            // 
            // cmbKhuvuc
            // 
            this.cmbKhuvuc.FormattingEnabled = true;
            this.cmbKhuvuc.Items.AddRange(new object[] {
            "Tầng 1",
            "Tầng 2",
            "Tầng 3"});
            this.cmbKhuvuc.Location = new System.Drawing.Point(474, 463);
            this.cmbKhuvuc.Name = "cmbKhuvuc";
            this.cmbKhuvuc.Size = new System.Drawing.Size(162, 21);
            this.cmbKhuvuc.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(400, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Mã";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(474, 269);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(162, 20);
            this.txtMa.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 565);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbKhuvuc);
            this.Controls.Add(this.cmbBophan);
            this.Controls.Add(this.chNu);
            this.Controls.Add(this.chNam);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnDongy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDongy;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.CheckBox chNam;
        private System.Windows.Forms.CheckBox chNu;
        private System.Windows.Forms.ComboBox cmbBophan;
        private System.Windows.Forms.ComboBox cmbKhuvuc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMa;
    }
}

