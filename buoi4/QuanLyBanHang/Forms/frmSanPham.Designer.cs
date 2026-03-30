namespace QuanLyBanHang.Forms
{
    partial class frmSanPham
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
            groupBox1 = new GroupBox();
            btnXuat = new Button();
            btnNhap = new Button();
            btnLuu = new Button();
            btnThoat = new Button();
            btnSua = new Button();
            btnTimKiem = new Button();
            btnXoa = new Button();
            btnHuyBo = new Button();
            btnThem = new Button();
            btnDoiAnh = new Button();
            picHinhAnh = new PictureBox();
            numDonGia = new NumericUpDown();
            numSoLuong = new NumericUpDown();
            cboHangSanXuat = new ComboBox();
            cboLoaiSanPham = new ComboBox();
            txtMoTa = new TextBox();
            txtTenSanPham = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Phanloai = new DataGridViewTextBoxColumn();
            Hangsanxuan = new DataGridViewTextBoxColumn();
            Tensanpham = new DataGridViewTextBoxColumn();
            Soluong = new DataGridViewTextBoxColumn();
            Dongia = new DataGridViewTextBoxColumn();
            Hinhanh = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnDoiAnh);
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(numDonGia);
            groupBox1.Controls.Add(numSoLuong);
            groupBox1.Controls.Add(cboHangSanXuat);
            groupBox1.Controls.Add(cboLoaiSanPham);
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(11, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(841, 217);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm ";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(702, 167);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(73, 29);
            btnXuat.TabIndex = 6;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(623, 167);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(73, 29);
            btnNhap.TabIndex = 6;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(307, 167);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(73, 29);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(465, 167);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(73, 29);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(149, 167);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(73, 29);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(544, 167);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(73, 29);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(228, 167);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(73, 29);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(386, 167);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(73, 29);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Hủy Bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(70, 167);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(73, 29);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Location = new Point(725, 20);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(73, 29);
            btnDoiAnh.TabIndex = 6;
            btnDoiAnh.Text = "Đổi Ảnh....";
            btnDoiAnh.UseVisualStyleBackColor = true;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Image = Properties.Resources.ip17;
            picHinhAnh.Location = new Point(577, 20);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(128, 122);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 5;
            picHinhAnh.TabStop = false;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(449, 50);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(88, 23);
            numDonGia.TabIndex = 4;
            numDonGia.ThousandsSeparator = true;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(449, 22);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(88, 23);
            numSoLuong.TabIndex = 4;
            numSoLuong.ThousandsSeparator = true;
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(161, 50);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(204, 23);
            cboHangSanXuat.TabIndex = 3;
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(161, 23);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(204, 23);
            cboLoaiSanPham.TabIndex = 3;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(161, 108);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(377, 23);
            txtMoTa.TabIndex = 2;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(161, 79);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(377, 23);
            txtTenSanPham.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 117);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 1;
            label4.Text = "Mô tả sản phẩm:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 88);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 1;
            label3.Text = "Tên sản phẩm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 58);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Hãng sản suất:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(392, 58);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 0;
            label6.Text = "Đơn giá:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(386, 31);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 0;
            label5.Text = "Số lượng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 31);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Phân loại:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(11, 234);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(841, 299);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sản phẩm";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Phanloai, Hangsanxuan, Tensanpham, Soluong, Dongia, Hinhanh });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 19);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(835, 277);
            dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Phanloai
            // 
            Phanloai.DataPropertyName = "PhanLoai";
            Phanloai.HeaderText = "Phân Loại";
            Phanloai.Name = "Phanloai";
            // 
            // Hangsanxuan
            // 
            Hangsanxuan.DataPropertyName = "HangSanXuat";
            Hangsanxuan.HeaderText = "Hãng sản xuất";
            Hangsanxuan.Name = "Hangsanxuan";
            // 
            // Tensanpham
            // 
            Tensanpham.DataPropertyName = "TenSanPham";
            Tensanpham.HeaderText = "Tên sản phẩm ";
            Tensanpham.Name = "Tensanpham";
            // 
            // Soluong
            // 
            Soluong.DataPropertyName = "SoLuong";
            Soluong.HeaderText = "Số lượng";
            Soluong.Name = "Soluong";
            // 
            // Dongia
            // 
            Dongia.DataPropertyName = "DonGia";
            Dongia.HeaderText = "Đơn giá";
            Dongia.Name = "Dongia";
            // 
            // Hinhanh
            // 
            Hinhanh.DataPropertyName = "HinhAnh";
            Hinhanh.HeaderText = "Hình ảnh";
            Hinhanh.Name = "Hinhanh";
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 545);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmSanPham";
            Text = "frmSanPham";
            Load += frmSanPham_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtMoTa;
        private TextBox txtTenSanPham;
        private Label label6;
        private Label label5;
        private Button btnDoiAnh;
        private PictureBox picHinhAnh;
        private NumericUpDown numDonGia;
        private NumericUpDown numSoLuong;
        private ComboBox cboHangSanXuat;
        private ComboBox cboLoaiSanPham;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnLuu;
        private Button btnThoat;
        private Button btnSua;
        private Button btnTimKiem;
        private Button btnXoa;
        private Button btnHuyBo;
        private Button btnThem;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Phanloai;
        private DataGridViewTextBoxColumn Hangsanxuan;
        private DataGridViewTextBoxColumn Tensanpham;
        private DataGridViewTextBoxColumn Soluong;
        private DataGridViewTextBoxColumn Dongia;
        private DataGridViewTextBoxColumn Hinhanh;
    }
}