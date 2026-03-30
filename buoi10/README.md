# QuanLyBanHang

Ung dung quan ly ban hang duoc xay dung bang C# WinForms, su dung Entity Framework Core ket noi SQL Server.

## Cong nghe su dung

- .NET 8 (`net8.0-windows`)
- Windows Forms
- Entity Framework Core 8
- SQL Server
- Thu vien ben thu 3:
  - `Microsoft.EntityFrameworkCore`
  - `Microsoft.EntityFrameworkCore.SqlServer`
  - `Microsoft.EntityFrameworkCore.Tools`
  - `BCrypt.Net-Next`
  - `ClosedXML`

## Chuc nang hien co

- Quan ly loai san pham:
  - Them
  - Sua
  - Xoa
  - Xem danh sach
- Quan ly hang san xuat:
  - Them
  - Sua
  - Xoa
  - Xem danh sach

## Cau truc du an

```text
QuanLyBanHang.sln
QuanLyBanHang/
  Data/
    QLBHDbContext.cs
    LoaiSanPham.cs
    HangSanXuat.cs
    SanPham.cs
    NhanVien.cs
    KhachHang.cs
    HoaDon.cs
    HoaDon_ChiTiet.cs
  Forms/
    frmLoaiSanPham.cs
    frmHangSanXuat.cs
  Migrations/
    20260120072231_KhoiTaoCSDL.cs
  Utils/
    GenerateSlug.cs
  App.config
  Program.cs
```

## Co so du lieu

`QLBHDbContext` dang su dung chuoi ket noi `QLBHConnection` trong `App.config`.

Mac dinh:

```xml
<add name="QLBHConnection"
     connectionString="Server=.\SQLEXPRESS; Database=QLBH;User Id=sa;Password=sql2017; Integrated Security=True; MultipleActiveResultSets=True; TrustServerCertificate=True"
     providerName="System.Data.SqlClient"/>
```

Ban can cap nhat lai thong tin `Server`, `User Id`, `Password` cho phu hop may cua ban.

## Huong dan chay du an

1. Cai dat:
   - .NET SDK 8
   - SQL Server (co the dung SQLEXPRESS)
2. Tao CSDL:
   - Mo SQL Server va dam bao tai khoan ket noi hop le.
   - Neu can, cap nhat chuoi ket noi trong `QuanLyBanHang/App.config`.
3. Khoi phuc package va build:

```bash
dotnet restore
dotnet build QuanLyBanHang.sln
```

4. Chay ung dung:

```bash
dotnet run --project QuanLyBanHang/QuanLyBanHang.csproj
```

## Luu y

- Du an da co migration khoi tao (`KhoiTaoCSDL`) trong thu muc `Migrations`.
- `Program.cs` hien dang khoi chay `frmHoaDon`. Trong cau truc hien tai chua thay file form nay trong thu muc `Forms`, vi vay ban can:
  - Tao them `frmHoaDon`, hoac
  - Doi form khoi dong sang mot form dang co (vi du: `frmLoaiSanPham` hoac `frmHangSanXuat`).

## Dinh huong mo rong

- Bo sung man hinh quan ly san pham, khach hang, nhan vien, hoa don.
- Them phan quyen dang nhap va bam mat khau bang BCrypt.
- Bo sung xuat bao cao/danh sach sang Excel bang ClosedXML.
