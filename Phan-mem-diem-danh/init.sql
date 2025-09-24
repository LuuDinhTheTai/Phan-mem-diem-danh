CREATE DATABASE PMDDDB;
GO

USE PMDDDB;
GO

-- B?ng account
CREATE TABLE account (
    id INT IDENTITY(1,1) PRIMARY KEY,
    MSV NVARCHAR(50) UNIQUE,
    first_name NVARCHAR(50) NOT NULL,
    last_name NVARCHAR(50) NOT NULL,
    birth DATE,
    password NVARCHAR(255) NOT NULL
);

-- B?ng role
CREATE TABLE role (
    id INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(50) NOT NULL
);

-- B?ng account_role (nhi?u-nhi?u gi?a account và role)
CREATE TABLE account_role (
    account_id INT NOT NULL,
    role_id INT NOT NULL,
    PRIMARY KEY (account_id, role_id),
    FOREIGN KEY (account_id) REFERENCES account(id) ON DELETE CASCADE,
    FOREIGN KEY (role_id) REFERENCES role(id) ON DELETE CASCADE
);

-- B?ng class
CREATE TABLE class (
    id INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    subject NVARCHAR(100),
    department NVARCHAR(100),
    start_date DATE NOT NULL DEFAULT GETDATE(),
    end_date DATE NULL
);

-- Ràng bu?c ngày k?t thúc >= ngày b?t ??u
ALTER TABLE class
ADD CONSTRAINT CK_Class_Date CHECK (end_date IS NULL OR end_date >= start_date);

-- B?ng account_class (nhi?u-nhi?u gi?a account và class, có thêm role)
CREATE TABLE account_class (
    account_id INT NOT NULL,
    class_id INT NOT NULL,
    role NVARCHAR(50), -- ví d?: 'student', 'teacher'
    PRIMARY KEY (account_id, class_id),
    FOREIGN KEY (account_id) REFERENCES account(id) ON DELETE CASCADE,
    FOREIGN KEY (class_id) REFERENCES class(id) ON DELETE CASCADE
);

-- B?ng attendance (?i?m danh)
CREATE TABLE attendance (
    id INT IDENTITY(1,1) PRIMARY KEY,
    account_id INT NOT NULL,
    class_id INT NOT NULL,
    date DATE NOT NULL,
    status BIT NOT NULL, -- 1: có m?t, 0: v?ng
    FOREIGN KEY (account_id) REFERENCES account(id) ON DELETE CASCADE,
    FOREIGN KEY (class_id) REFERENCES class(id) ON DELETE CASCADE
);

----------------------------------------------------
-- D? LI?U M?U
----------------------------------------------------

-- account
INSERT INTO account (MSV, first_name, last_name, birth, password) VALUES
('SV001', 'An', 'Nguyen', '2002-01-15', '123456'),
('SV002', 'Binh', 'Tran', '2002-03-12', '123456'),
('SV003', 'Chi', 'Le', '2002-05-20', '123456'),
('SV004', 'Dung', 'Pham', '2002-07-01', '123456'),
('SV005', 'Hanh', 'Vu', '2002-09-22', '123456'),
('SV006', 'Khanh', 'Hoang', '2002-11-11', '123456'),
('SV007', 'Linh', 'Nguyen', '2002-12-25', '123456'),
('SV008', 'Minh', 'Do', '2002-04-09', '123456'),
('SV009', 'Nga', 'Pham', '2002-08-18', '123456'),
('SV010', 'Quang', 'Le', '2002-10-30', '123456');

-- role
INSERT INTO role (name) VALUES
('Admin'),
('Teacher'),
('Student'),
('Monitor'),
('Assistant'),
('Dean'),
('Manager'),
('Supervisor'),
('Tutor'),
('Guest');

-- account_role
INSERT INTO account_role (account_id, role_id) VALUES
(1, 3),
(2, 3),
(3, 3),
(4, 3),
(5, 3),
(6, 3),
(7, 3),
(8, 3),
(9, 3),
(10, 2);

-- class
INSERT INTO class (name, subject, department, start_date, end_date) VALUES
('Lop CNTT1', 'Lap trinh C#', 'CNTT', '2023-09-01', '2023-12-31'),
('Lop CNTT2', 'Co so du lieu', 'CNTT', '2023-09-01', '2023-12-31'),
('Lop CNTT3', 'He dieu hanh', 'CNTT', '2023-09-01', '2023-12-31'),
('Lop CNTT4', 'Mang may tinh', 'CNTT', '2023-09-01', '2023-12-31'),
('Lop CNTT5', 'Tri tue nhan tao', 'CNTT', '2023-09-01', '2023-12-31'),
('Lop CNTT6', 'Phan mem nhung', 'CNTT', '2023-09-01', '2023-12-31'),
('Lop CNTT7', 'Lap trinh Web', 'CNTT', '2023-09-01', '2023-12-31'),
('Lop CNTT8', 'Java nang cao', 'CNTT', '2023-09-01', '2023-12-31'),
('Lop CNTT9', 'Python co ban', 'CNTT', '2023-09-01', '2023-12-31'),
('Lop CNTT10', 'Phan tich thiet ke HTTT', 'CNTT', '2023-09-01', '2023-12-31');

-- account_class
INSERT INTO account_class (account_id, class_id, role) VALUES
(1, 1, 'Student'),
(2, 1, 'Student'),
(3, 1, 'Student'),
(4, 2, 'Student'),
(5, 2, 'Student'),
(6, 3, 'Student'),
(7, 3, 'Student'),
(8, 4, 'Student'),
(9, 4, 'Student'),
(10, 1, 'Teacher');

-- attendance
INSERT INTO attendance (account_id, class_id, date, status) VALUES
(1, 1, '2023-09-10', 1),
(2, 1, '2023-09-10', 1),
(3, 1, '2023-09-10', 0),
(10, 1, '2023-09-10', 1),
(4, 2, '2023-09-10', 1),
(5, 2, '2023-09-10', 0),
(6, 3, '2023-09-10', 1),
(7, 3, '2023-09-10', 1),
(8, 4, '2023-09-10', 1),
(9, 4, '2023-09-10', 0);
