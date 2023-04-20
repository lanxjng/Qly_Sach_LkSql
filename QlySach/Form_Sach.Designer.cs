namespace QlySach
{
    partial class Form_Sach
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtAnhBia = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtSoLgTon = new System.Windows.Forms.TextBox();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbbMaCD = new System.Windows.Forms.ComboBox();
            this.cbbMaNXB = new System.Windows.Forms.ComboBox();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnhBia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCapNhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã NXB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ảnh Bìa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mô Tả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giá Bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên Sách";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(421, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mã Chủ Đề";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(421, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số Lượng Tồn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(415, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ngày Cập Nhật";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(144, 20);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(100, 22);
            this.txtMaSach.TabIndex = 9;
            // 
            // txtAnhBia
            // 
            this.txtAnhBia.Location = new System.Drawing.Point(144, 212);
            this.txtAnhBia.Name = "txtAnhBia";
            this.txtAnhBia.Size = new System.Drawing.Size(100, 22);
            this.txtAnhBia.TabIndex = 10;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(144, 159);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(100, 22);
            this.txtMoTa.TabIndex = 11;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(144, 114);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(100, 22);
            this.txtGiaBan.TabIndex = 12;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(144, 65);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(100, 22);
            this.txtTenSach.TabIndex = 13;
            // 
            // txtSoLgTon
            // 
            this.txtSoLgTon.Location = new System.Drawing.Point(548, 89);
            this.txtSoLgTon.Name = "txtSoLgTon";
            this.txtSoLgTon.Size = new System.Drawing.Size(100, 22);
            this.txtSoLgTon.TabIndex = 15;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(588, 288);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(75, 23);
            this.btnQuayLai.TabIndex = 21;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(418, 288);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(247, 288);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(39, 288);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaSach,
            this.TenSach,
            this.GiaBan,
            this.MoTa,
            this.AnhBia,
            this.NgayCapNhat,
            this.SoLuongTon,
            this.MaNXB,
            this.MaCD});
            this.dataGridView1.Location = new System.Drawing.Point(12, 367);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(751, 150);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Chon_Sach);
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.Danh_STT);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(531, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // cbbMaCD
            // 
            this.cbbMaCD.FormattingEnabled = true;
            this.cbbMaCD.Location = new System.Drawing.Point(548, 137);
            this.cbbMaCD.Name = "cbbMaCD";
            this.cbbMaCD.Size = new System.Drawing.Size(121, 24);
            this.cbbMaCD.TabIndex = 24;
            // 
            // cbbMaNXB
            // 
            this.cbbMaNXB.FormattingEnabled = true;
            this.cbbMaNXB.Location = new System.Drawing.Point(548, 205);
            this.cbbMaNXB.Name = "cbbMaNXB";
            this.cbbMaNXB.Size = new System.Drawing.Size(121, 24);
            this.cbbMaNXB.TabIndex = 25;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.Name = "MaSach";
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.Name = "TenSach";
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá Bán";
            this.GiaBan.Name = "GiaBan";
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô Tả";
            this.MoTa.Name = "MoTa";
            // 
            // AnhBia
            // 
            this.AnhBia.DataPropertyName = "AnhBia";
            this.AnhBia.HeaderText = "Ảnh Bìa";
            this.AnhBia.Name = "AnhBia";
            // 
            // NgayCapNhat
            // 
            this.NgayCapNhat.DataPropertyName = "NgayCapNhat";
            this.NgayCapNhat.HeaderText = "Ngày Cập Nhật";
            this.NgayCapNhat.Name = "NgayCapNhat";
            // 
            // SoLuongTon
            // 
            this.SoLuongTon.DataPropertyName = "SoLuongTon";
            this.SoLuongTon.HeaderText = "Số Lượng Tồn";
            this.SoLuongTon.Name = "SoLuongTon";
            // 
            // MaNXB
            // 
            this.MaNXB.DataPropertyName = "MaNxb";
            this.MaNXB.HeaderText = "Mã NXB";
            this.MaNXB.Name = "MaNXB";
            // 
            // MaCD
            // 
            this.MaCD.DataPropertyName = "MaChuDe";
            this.MaCD.HeaderText = "Mã Chủ Đề";
            this.MaCD.Name = "MaCD";
            // 
            // Form_Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 554);
            this.Controls.Add(this.cbbMaNXB);
            this.Controls.Add(this.cbbMaCD);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSoLgTon);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtAnhBia);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Sach";
            this.Text = "Form_Sach";
            this.Load += new System.EventHandler(this.Form_Sach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtAnhBia;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtSoLgTon;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbbMaCD;
        private System.Windows.Forms.ComboBox cbbMaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnhBia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCapNhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCD;
    }
}