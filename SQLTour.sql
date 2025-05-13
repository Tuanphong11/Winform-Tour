-- 1. Tạo cơ sở dữ liệu
IF DB_ID(N'TourManagement') IS NULL
    CREATE DATABASE TourManagement;
GO

USE TourManagement;
GO

-- 2. Bảng lưu các loại tour
CREATE TABLE TourType (
    TourTypeID    INT IDENTITY(1,1) PRIMARY KEY,
    TypeName      NVARCHAR(50) NOT NULL  -- Cao cấp, Tiêu chuẩn, Tiết kiệm
);
GO

-- 3. Bảng phương thức vận chuyển
CREATE TABLE TransportationMethod (
    TransportID   INT IDENTITY(1,1) PRIMARY KEY,
    MethodName    NVARCHAR(50) NOT NULL  -- Xe, Máy bay
);
GO

-- 4. Bảng Tour chính
CREATE TABLE Tour (
    TourID               INT IDENTITY(1,1) PRIMARY KEY,
    TourName             NVARCHAR(200) NOT NULL,
    TourTypeID           INT NOT NULL FOREIGN KEY REFERENCES TourType(TourTypeID),
    TransportID          INT NOT NULL FOREIGN KEY REFERENCES TransportationMethod(TransportID),
    Price                DECIMAL(12,2) NOT NULL,      -- Giá trọn gói
    Description          NVARCHAR(MAX) NULL,
    StartDate            DATE NOT NULL,
    EndDate              DATE NOT NULL,
    CreatedAt            DATETIME   NOT NULL DEFAULT GETDATE()
);
GO

-- 5. Bảng Khách hàng
CREATE TABLE Customer (
    CustomerID           INT IDENTITY(1,1) PRIMARY KEY,
    FullName             NVARCHAR(200) NOT NULL,
    Phone                NVARCHAR(20)  NULL,
    Email                NVARCHAR(100) NULL,
    Address              NVARCHAR(300) NULL,
    CreatedAt            DATETIME      NOT NULL DEFAULT GETDATE()
);
GO

-- 6. Bảng Đơn đặt tour
CREATE TABLE Booking (
    BookingID            INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID           INT NOT NULL FOREIGN KEY REFERENCES Customer(CustomerID),
    TourID               INT NOT NULL FOREIGN KEY REFERENCES Tour(TourID),
    BookingDate          DATETIME NOT NULL DEFAULT GETDATE(),
    DepositAmount        DECIMAL(12,2) NOT NULL DEFAULT 0,
    TotalAmount          DECIMAL(12,2) NOT NULL,
    Status               NVARCHAR(50) NOT NULL  -- Ví dụ: Đã đặt cọc, Hoàn thành, Đã hủy
);
GO

-- 7. Bảng Lịch trình (Itinerary) cho mỗi Tour
CREATE TABLE Itinerary (
    ItineraryID          INT IDENTITY(1,1) PRIMARY KEY,
    TourID               INT NOT NULL FOREIGN KEY REFERENCES Tour(TourID),
    DayNumber            INT NOT NULL,               -- Ngày thứ bao nhiêu trong tour
    Title                NVARCHAR(200) NOT NULL,     -- Tiêu đề hoạt động
    Details              NVARCHAR(MAX) NULL          -- Mô tả chi tiết
);
GO

-- 8. Bảng Người dùng và phân quyền
CREATE TABLE [Role] (
    RoleID               INT IDENTITY(1,1) PRIMARY KEY,
    RoleName             NVARCHAR(50) NOT NULL      -- Admin, Nhân viên…
);
GO

CREATE TABLE [UserAccount] (
    UserID               INT IDENTITY(1,1) PRIMARY KEY,
    UserName             NVARCHAR(100) NOT NULL UNIQUE,
    PasswordHash         NVARCHAR(200) NOT NULL,
    FullName             NVARCHAR(200) NULL,
    RoleID               INT NOT NULL FOREIGN KEY REFERENCES [Role](RoleID),
    CreatedAt            DATETIME NOT NULL DEFAULT GETDATE()
);
GO
INSERT INTO [TourManagement].[dbo].[Role] ([RoleName])
VALUES 
    (N'admin'),
    (N'nhanvien');

INSERT INTO [TourManagement].[dbo].[UserAccount] 
    ([UserName], [PasswordHash], [FullName], [RoleID])
VALUES 
    (N'admin', N'admin', N'Quản trị viên ', 1),
    (N'nhanvien', N'nhanvien', N'Nhân viên', 2);
