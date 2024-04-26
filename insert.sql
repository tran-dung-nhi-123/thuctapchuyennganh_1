--tblmau
insert into tblmau
values ('#000', 'Mau den');
insert into tblmau
values ('#FFF', 'Mau trang');
insert into tblmau
values ('#FF0', 'Mau do');
insert into tblmau
values ('#00F', 'Mau xanh la');
insert into tblmau
values ('#0FF', 'Mau xanh da troi');
insert into tblmau
values ('#010', 'Mau hong');

--tbltheloai
insert into tbltheloai
values ('L1', 'Ao ngu');
insert into tbltheloai
values ('L2', 'Quan ngu');
insert into tbltheloai
values ('L3', 'Bo quan ao ngu coc tay');
insert into tbltheloai
values ('L4', 'Bo quan ao ngu dai tay');
insert into tbltheloai
values ('L5', 'Vay');

--tblsanpham
insert into tblsanpham values 
('SP01','Ao ngu hoa tiet trai tim','L1','S','#010','0','D:\\Tai lieu hoc tap\\Thực tập chuyên ngành\\BTL TTCN\\Ao ngu.jpg'),
('SP02','Quan ngu hoa tiet trai tim','L2','S','#010','0','D:\\Tai lieu hoc tap\\Thực tập chuyên ngành\\BTL TTCN\\Quan ngu.jpg'),
('SP03','Bo quan ao ngu coc tay mau hong xinh xan','L3','M','#010','0','D:\\Tai lieu hoc tap\\Thực tập chuyên ngành\\BTL TTCN\\Bo quan ao ngu coc tay.jpg'),
('SP04','Bo quan ao ngu coc tay den huyen bi','L3','M','#000','0','D:\\Tai lieu hoc tap\\Thực tập chuyên ngành\\BTL TTCN\\Bo quan ao ngu coc tay den.jpg'),
('SP05','Bo quan ao ngu dai tay soc ke sang chanh','L4','S','#000','0','D:\\Tai lieu hoc tap\\Thực tập chuyên ngành\\BTL TTCN\\Bo quan ao ngu dai tay.jpg'),
('SP06','Vay dai qua dau goi hong pastel','L5','S','#010','0','D:\\Tai lieu hoc tap\\Thực tập chuyên ngành\\BTL TTCN\\Vay.jpg');
delete from tblsanpham;

--tblnhacungcap
insert into tblnhacungcap
values
('NCC001', 'Quang Hai', 'Lao Cai', '0123456789'),
('NCC002', 'Le Quyen', 'Ba Dinh - Ha Noi', '0987654321'),
('NCC003', 'Nixihao', 'Quang Chau', '0369852147'),
('NCC004', 'Dung Nhi', 'Dong Da - Ha Noi', '0542136987'),
('NCC005', 'Mixie', 'Quang Chau', '0123456789');

--tblhoadonnhap
insert into tblhoadonnhap
values
('HDN0001','NV01','NCC001','2024-02-01','184000000'),
('HDN0002','NV01','NCC003','2024-02-25','52000000'),
('HDN0003','NV03','NCC002','2024-03-12','31000000'),
('HDN0004','NV01','NCC001','2024-02-13','68000000'),
('HDN0005','NV03','NCC005','2024-02-13','29000000');

--tblchitiethoadonnhap
insert into tblchitiethoadonnhap
values 
('HDN0001', 'SP01', '30','100000','0.01'), 
('HDN0001', 'SP06', '30','90000','0.01');

--tblhoadonban
insert into tblhoadonban
values
('HDB00001','NV02','2024-04-12','KH001','400000'),
('HDB00002','NV04','2024-04-12','KH002','360000'),
('HDB00003','NV05','2024-04-13','KH003','525000'),
('HDB00004','NV02','2024-04-14','KH004','335000'),
('HDB00005','NV04','2024-04-15','KH005','630000');
delete from tblhoadonban;

--tblkhachhang
insert into tblkhachhang
values ('KH001','Hong Ngoc','So 6 - My Xa - Nam Dinh','0912873465');
insert into tblkhachhang
values ('KH002','Ho Quynh Huong','Phu Trung - Khanh An - Yen Khanh - Ninh Binh','0965784312');
insert into tblkhachhang
values ('KH003','Bang Kieu','Quang Phu Cau - Ung Hoa - Ha Tay - Ha Noi','0912834756');
insert into tblkhachhang
values ('KH004','My Tam', 'Cau Giay - Ha Noi','0914238765');
insert into tblkhachhang
values ('KH005','Xuan Bac','Pho Vien - Co Nhue - Nam Tu Liem - Ha Noi','0986735421');

--tblcongviec
insert into tblcongviec
values ('CV01','Quan ly Kho','30000');
insert into tblcongviec
values ('CV02', 'Ban hang', '28000');
insert into tblcongviec
values ('CV03','Chu cua hang','0');

--tblnhanvien
INSERT INTO tblnhanvien
VALUES 
    ('NV01', 'Pham Van Manh','Nam', '2003-10-10','0987654321','162-Khương Dinh-ThanhXuan-Ha Noi','CV01'),
    ('NV02', 'Tran Thi Hoa', 'Nu', '1995-05-10', '0987654321', '456 Duong Thanh Xuan-Quan Thanh Xuan', 'CV02'),
    ('NV03', 'Le Hong Ngoc', 'Nu', '2000-09-20', '0123456789', '789 Duong Thanh Xuan-Quan Dong Da', 'CV01'),
    ('NV04', 'Pham Thi Duyen', 'Nu', '1992-03-15', '9876543210', '101 Duong Nguyen Trai-Quan Thanh Xuan', 'CV02'),
    ('NV05', 'Hoang Thi Hong', 'Nu', '1988-07-25', '0123456789', '222 Duong Khuong Trung-Quan Thanh Xuan', 'CV02');

--tblbangchamcong
insert into tblbangchamcong
values 
--('NV01','2024-04-18','2024-04-18 08:00:00','2024-04-18 17:05:05'),
('NV01','2024-04-19','2024-04-19 07:59:03','2024-04-19 16:05:00'),
('NV01','2024-04-22','2024-04-22 08:00:03','2024-04-22 16:45:00'),
('NV01','2024-04-17','2024-04-17 08:02:03','2024-04-17 17:00:00'),
('NV02','2024-04-18','2024-04-18 07:59:03','2024-04-18 16:05:00'),
('NV02','2024-04-19','2024-04-19 08:00:03','2024-04-19 16:55:00'),
('NV03','2024-04-18','2024-04-18 08:05:03','2024-04-18 17:00:00');

--tblbangluong
INSERT INTO tblbangluong
SELECT 
    NV.MaNV,
    CAST(DATEDIFF(SECOND, GioVaoLam, GioTanLam) AS FLOAT) / 3600 AS TongGioLam,
	HeSoLuong * CAST(DATEDIFF(SECOND, GioVaoLam, GioTanLam) AS FLOAT) / 3600 as TongTien from tblnhanvien NV join tblcongviec Cv on NV.macv = CV.macv join tblbangchamcong CC on NV.manv = CC.manv;
insert into tblbangluong
values ('NV01','0','0'),
('NV02','0','0'),
('NV03','0','0');

