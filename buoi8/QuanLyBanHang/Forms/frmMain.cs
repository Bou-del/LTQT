using QuanLyBanHang.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace QuanLyBanHang.Forms
{
    public partial class frmMain : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        frmLoaiSanPham loaisanpham = null;
        frmHangSanXuat hangsanxuat = null;
        frmSanPham sanpham = null;
        frmKhachHang khachhang = null;
        frmNhanVien nhanvien = null;
        frmHoaDon hoadon = null;
        frmDangNhap dangnhap = null;
        string HovaTenNhanVien = "";
        public frmMain()
        {
            InitializeComponent();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ChuaDangNhap();
            DangNhap();

        }

        private void mnuLoaiSanPham_Click(object sender, EventArgs e)
        {
            if (loaisanpham == null || loaisanpham.IsDisposed)
            {
                loaisanpham = new frmLoaiSanPham();
                loaisanpham.MdiParent = this;
                loaisanpham.Show();
            }
            else
            {
                loaisanpham.Activate();
            }
        }

        private void mnuHangSanXuat_Click(object sender, EventArgs e)
        {
            if (hangsanxuat == null || hangsanxuat.IsDisposed)
            {
                hangsanxuat = new frmHangSanXuat();
                hangsanxuat.MdiParent = this;
                hangsanxuat.Show();
            }
            else
            {
                hangsanxuat.Activate();
            }
        }

        private void mnuSanPham_Click(object sender, EventArgs e)
        {
            if (sanpham == null || sanpham.IsDisposed)
            {
                sanpham = new frmSanPham();
                sanpham.MdiParent = this;
                sanpham.Show();
            }
            else
            {
                sanpham.Activate();
            }
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            if (khachhang == null || khachhang.IsDisposed)
            {
                khachhang = new frmKhachHang();
                khachhang.MdiParent = this;
                khachhang.Show();
            }
            else
            {

                khachhang.Activate();
            }

        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            if (nhanvien == null || nhanvien.IsDisposed)
            {
                nhanvien = new frmNhanVien();
                nhanvien.MdiParent = this;
                nhanvien.Show();
            }
            else
            {
                nhanvien.Activate();
            }
        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            if (hoadon == null || hoadon.IsDisposed)
            {
                hoadon = new frmHoaDon();
                hoadon.MdiParent = this;
                hoadon.Show();
            }
            else
            { hoadon.Activate(); }
        }

        private void lblLienKet_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "explorer.exe";
            info.Arguments = "https://fit.agu.edu.vn";
            Process.Start(info);
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }
        private void DangNhap()
        {
        LamLai:
            if (dangnhap == null || dangnhap.IsDisposed)
                dangnhap = new frmDangNhap();

            if (dangnhap.ShowDialog() == DialogResult.OK)
            {
                string tenDangNhap = dangnhap.txtTenDangNhap.Text;
                string matKhau = dangnhap.txtMatKhau.Text;

                if (tenDangNhap.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangnhap.txtTenDangNhap.Focus();
                    goto LamLai;
                }
                else if (matKhau.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangnhap.txtMatKhau.Focus();
                    goto LamLai;
                }
                else
                {
                    var nhanVien = context.NhanVien.Where(r => r.TenDangNhap == tenDangNhap).SingleOrDefault();

                    if (nhanVien == null)
                    {
                        MessageBox.Show("Tên đăng nhập không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dangnhap.txtTenDangNhap.Focus();
                        goto LamLai;
                    }
                    else
                    {
                        if (BCrypt.Net.BCrypt.Verify(matKhau, nhanVien.MatKhau))
                        {
                            HovaTenNhanVien = nhanVien.HoVaTen;

                            if (nhanVien.QuyenHan == true)
                                QuyenQuanLy();
                            else if (nhanVien.QuyenHan == false)
                                QuyenNhanVien();
                            else
                                ChuaDangNhap();
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dangnhap.txtMatKhau.Focus();
                            goto LamLai;
                        }
                    }
                }
            }
        }

        //Chuc nang voi cac quyen
        public void ChuaDangNhap()
        {
            //sang dang nhap
            mnuDangNhap.Enabled = true;

            //Mo tat ca
            mnuDangXuat.Enabled = false;
            mnuDoiMatKhau.Enabled = false;

            mnuLoaiSanPham.Enabled = false;
            mnuHangSanXuat.Enabled = false;
            mnuSanPham.Enabled = false;
            mnuKhachHang.Enabled = false;
            mnuNhanVien.Enabled = false;
            mnuHoaDon.Enabled = false;

            mnuThongKeSanPham.Enabled = false;
            mnuThongKeDoanhThu.Enabled = false;

            //Hien thi thong tin trang thai
            lblTrangThai.Text = "Chua dang nhap";
        }

        public void QuyenQuanLy()
        {
            //Mo dang nhap
            mnuDangNhap.Enabled = true;

            //Mo cac chuc nang quan ly khong duoc phep
            //Sang dang xuat va cac chuc nang quan ly duoc phep 
            mnuDangXuat.Enabled = true;
            mnuDoiMatKhau.Enabled = true;

            mnuLoaiSanPham.Enabled = true;
            mnuHangSanXuat.Enabled = true;
            mnuSanPham.Enabled = true;
            mnuKhachHang.Enabled = true;
            mnuNhanVien.Enabled = true;
            mnuHoaDon.Enabled = true;

            mnuThongKeSanPham.Enabled = true;
            mnuThongKeDoanhThu.Enabled = true;

            //Hien thi thong tin tren trang thai
            lblTrangThai.Text = "Quan ly: " + HovaTenNhanVien;
        }

        public void QuyenNhanVien()
        {
            // Mờ đăng nhập 
            mnuDangNhap.Enabled = false;

            // Mờ các chức năng nhân viên không được phép 
            mnuLoaiSanPham.Enabled = false;
            mnuHangSanXuat.Enabled = false;
            mnuSanPham.Enabled = false;
            mnuNhanVien.Enabled = false;

            // Sáng đăng xuất và các chức năng nhân viên được phép 
            mnuDangXuat.Enabled = true;
            mnuDoiMatKhau.Enabled = true;

            mnuKhachHang.Enabled = true;
            mnuHoaDon.Enabled = true;

            mnuThongKeSanPham.Enabled = true;
            mnuThongKeDoanhThu.Enabled = true;

            // Hiển thị thông tin trên thanh trạng thái 
            lblTrangThai.Text = "Nhân viên: " + HovaTenNhanVien;
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }
            ChuaDangNhap();
        }
    }
}
