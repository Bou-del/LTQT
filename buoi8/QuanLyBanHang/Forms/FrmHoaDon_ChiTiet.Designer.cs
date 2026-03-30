namespace QuanLyBanHang.Forms
{
    partial class FrmHoaDon_ChiTiet
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            txtGhiChuHoaDon = new TextBox();
            cboKhachHang = new ComboBox();
            cboNhanVien = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            DonGiaBan = new DataGridViewTextBoxColumn();
            SoLuongBan = new DataGridViewTextBoxColumn();
            btnXoa = new Button();
            btnThoat = new Button();
            btnInHoaDon = new Button();
            btnLuuHoaDon = new Button();
            btnXacNhanBan = new Button();
            numSoLuongBan = new NumericUpDown();
            numDonGiaBan = new NumericUpDown();
            cboSanPham = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtGhiChuHoaDon);
            groupBox1.Controls.Add(cboKhachHang);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(10, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(813, 124);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // txtGhiChuHoaDon
            // 
            txtGhiChuHoaDon.Location = new Point(126, 71);
            txtGhiChuHoaDon.Name = "txtGhiChuHoaDon";
            txtGhiChuHoaDon.Size = new Size(450, 23);
            txtGhiChuHoaDon.TabIndex = 3;
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(494, 27);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(267, 23);
            cboKhachHang.TabIndex = 2;
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(126, 27);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(253, 23);
            cboNhanVien.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 74);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 0;
            label2.Text = "Ghi chú hóa đơn: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(415, 30);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 0;
            label3.Text = "Khách hàng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 30);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhân viên lập:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Controls.Add(btnInHoaDon);
            groupBox2.Controls.Add(btnLuuHoaDon);
            groupBox2.Controls.Add(btnXacNhanBan);
            groupBox2.Controls.Add(numSoLuongBan);
            groupBox2.Controls.Add(numDonGiaBan);
            groupBox2.Controls.Add(cboSanPham);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(10, 151);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(813, 382);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chi tiết hóa đơn";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, ThanhTien, TenSanPham, DonGiaBan, SoLuongBan });
            dataGridView1.Location = new Point(6, 85);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(790, 226);
            dataGridView1.TabIndex = 4;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle1;
            ThanhTien.HeaderText = "Thành Tiền";
            ThanhTien.Name = "ThanhTien";
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên Sản Phẩm";
            TenSanPham.Name = "TenSanPham";
            // 
            // DonGiaBan
            // 
            DonGiaBan.DataPropertyName = "DonGiaBan";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            DonGiaBan.DefaultCellStyle = dataGridViewCellStyle2;
            DonGiaBan.HeaderText = "Đơn Giá Bán";
            DonGiaBan.Name = "DonGiaBan";
            // 
            // SoLuongBan
            // 
            SoLuongBan.DataPropertyName = "SoLuongBan";
            SoLuongBan.HeaderText = "Số Lượng Bán";
            SoLuongBan.Name = "SoLuongBan";
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(676, 45);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(120, 34);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(512, 327);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(120, 34);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Location = new Point(330, 327);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(120, 34);
            btnInHoaDon.TabIndex = 3;
            btnInHoaDon.Text = "In hóa đơn...";
            btnInHoaDon.UseVisualStyleBackColor = true;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // btnLuuHoaDon
            // 
            btnLuuHoaDon.Location = new Point(146, 327);
            btnLuuHoaDon.Name = "btnLuuHoaDon";
            btnLuuHoaDon.Size = new Size(120, 34);
            btnLuuHoaDon.TabIndex = 3;
            btnLuuHoaDon.Text = "Lưu hóa đơn";
            btnLuuHoaDon.UseVisualStyleBackColor = true;
            btnLuuHoaDon.Click += btnLuuHoaDon_Click;
            // 
            // btnXacNhanBan
            // 
            btnXacNhanBan.Location = new Point(550, 45);
            btnXacNhanBan.Name = "btnXacNhanBan";
            btnXacNhanBan.Size = new Size(120, 34);
            btnXacNhanBan.TabIndex = 3;
            btnXacNhanBan.Text = "Xác nhận bán";
            btnXacNhanBan.UseVisualStyleBackColor = true;
            btnXacNhanBan.Click += btnXacNhanBan_Click;
            // 
            // numSoLuongBan
            // 
            numSoLuongBan.Location = new Point(367, 53);
            numSoLuongBan.Name = "numSoLuongBan";
            numSoLuongBan.Size = new Size(150, 23);
            numSoLuongBan.TabIndex = 2;
            // 
            // numDonGiaBan
            // 
            numDonGiaBan.Location = new Point(179, 54);
            numDonGiaBan.Name = "numDonGiaBan";
            numDonGiaBan.Size = new Size(150, 23);
            numDonGiaBan.TabIndex = 2;
            // 
            // cboSanPham
            // 
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(6, 53);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(137, 23);
            cboSanPham.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(386, 35);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 0;
            label6.Text = "Số lượng bán:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(192, 35);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 0;
            label5.Text = "Đơn giá bán:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 35);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 0;
            label4.Text = "Sản phẩm:";
            // 
            // FrmHoaDon_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 545);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmHoaDon_ChiTiet";
            Text = "FrmHoaDon_ChiTiet";
            Load += FrmHoaDon_ChiTiet_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private Label label1;
        private TextBox txtGhiChuHoaDon;
        private ComboBox cboKhachHang;
        private ComboBox cboNhanVien;
        private GroupBox groupBox2;
        private Label label4;
        private Button btnXoa;
        private Button btnXacNhanBan;
        private NumericUpDown numSoLuongBan;
        private NumericUpDown numDonGiaBan;
        private ComboBox cboSanPham;
        private Label label6;
        private Label label5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ThanhTien;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn DonGiaBan;
        private DataGridViewTextBoxColumn SoLuongBan;
        private Button btnThoat;
        private Button btnInHoaDon;
        private Button btnLuuHoaDon;
    }
}