# 📌 Web Quản Lý Chi Tiêu - ASP.NET MVC

Dự án nhỏ dùng ASP.NET MVC để quản lý chi tiêu cá nhân.  
Người dùng có thể thêm các khoản chi tiêu (ngày, nội dung, số tiền) và xem danh sách các khoản đã nhập.

---

## 🚀 Yêu cầu hệ thống
- Visual Studio (2019/2022)
- .NET Framework 4.7.2 hoặc cao hơn
- (Tùy chọn) SQL Server Express nếu muốn lưu dữ liệu vào database

---

## 🛠 Cách chạy dự án
1. Clone hoặc copy project về máy.  
2. Mở file solution `.sln` bằng **Visual Studio**.  
3. Đặt project `WebQuanLyChiTieu` làm **Startup Project**.  
4. Bấm **Run (IIS Express)** để chạy.  
5. Mở trình duyệt tại:  

---

## ✨ Các chức năng
### 1. Danh sách chi tiêu
- URL: `/ChiTieu/Index`
- Hiển thị danh sách các khoản chi tiêu (Ngày, Nội dung, Số tiền).

### 2. Thêm chi tiêu
- URL: `/ChiTieu/Create`
- Form nhập:
- Ngày
- Nội dung
- Số tiền
- Sau khi bấm **Lưu**, dữ liệu sẽ được thêm vào danh sách.

---

## 📂 Cấu trúc chính
WebQuanLyChiTieu/
│-- Controllers/
│ └── ChiTieuController.cs
│
│-- Models/
│ └── ChiTieu.cs
│
│-- Views/
│ └── ChiTieu/
│ ├── Index.cshtml
│ └── Create.cshtml
││
│-- Global.asax
│-- Web.config
---

## 💾 Lưu dữ liệu
- Phiên bản demo đang sử dụng **Session** để lưu dữ liệu tạm (sẽ mất khi restart ứng dụng).
- Có thể nâng cấp sang **Entity Framework + SQL Server** để lưu dữ liệu thật trong database.

---

## 📌 Hướng phát triển tiếp theo
- Kết nối SQL Server để lưu dữ liệu lâu dài.  
- Thêm chức năng **Chỉnh sửa / Xóa chi tiêu**.  
- Thêm tính năng **Thống kê chi tiêu theo ngày, tháng, năm**.  
- Xuất báo cáo ra Excel / PDF.  

---

👨‍💻 Tác giả: Huỳnh Thanh Duy

