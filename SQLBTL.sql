							
--Câu 1. Số lượng trong bảng DM hàng hoá được tự động cập nhật khi nhập hàng và bán hàng

alter trigger SOLUONGHH on [dbo].ChiTietHDB for insert, update as
	begin
		declare @mahh nvarchar(10), @sl int
		select @mahh = DMHangHoa.MaHH, @sl = inserted.SoLuong /2 
		from inserted join [dbo].[DMHangHoa] on inserted.MaHH = DMHangHoa.MaHH
		update DMHangHoa set Soluong = Soluong - @sl where MaHH = @mahh
	end
go

alter trigger SLNhap on [dbo].ChiTietHDN for insert, update as
	begin
		declare @mahh nvarchar(10), @sl int
		select @mahh = DMHangHoa.MaHH, @sl = inserted.SoLuong / 2
		from inserted join [dbo].[DMHangHoa] on inserted.MaHH = DMHangHoa.MaHH
		update DMHangHoa set Soluong = Soluong + @sl where MaHH = @mahh
	end
go

create trigger THANHTIENBAN on ChiTietHDB for insert, update as
begin
	declare @mahh nvarchar(10), @gia int, @sl int
	select @mahh = inserted.HDB, @gia = GiaBan, @sl = inserted.SoLuong
	from inserted join [dbo].[DMHangHoa] on inserted.MaHH = DMHangHoa.MaHH
	update ChiTietHDB set ThanhTien = (@gia * @sl) where HDB = @mahh
	update HDBan set TongTien = (@gia * @sl) where HDB = @mahh
	end
go

create trigger THANHTIENNhap on ChiTietHDN for insert, update as
begin
	declare @mahh nvarchar(10), @gia int, @sl int
	select @mahh = inserted.HDN, @gia = DonGia, @sl = SoLuong
	from inserted 
	update ChiTietHDN set ThanhTien = @gia * @sl where HDN = @mahh
	update HDNhap set TongTien = @gia * @sl where HDN = @mahh
	end
go

select * from ChiTietHDB
select * from DMHangHoa
select * from ChiTietHDN 
go
--Câu 2. Giá nhập trong bảng DM hàng hoá được tự động cập nhật khi nhập hàng	

create trigger GIANHAP on ChiTietHDN for insert, update as
begin
	declare @mahh nvarchar(10), @gia int
	select @mahh = inserted.MaHH, @gia = GiaNhap from inserted join DMHangHoa on inserted.MaHH = DMHangHoa.MaHH
	update [dbo].[DMHangHoa] set GiaNhap = @gia where MaHH = @mahh
end
go

--Câu 3. Giá bán trong bảng DM hàng hoá được tự động cập nhật = 110% Giá nhập		

create trigger UpdateGia on [dbo].[DMHangHoa] for insert, update as
	begin
		declare @mahh nvarchar(10), @gia int
		select @mahh = MaHH, @gia = GiaNhap from inserted
		update [dbo].[DMHangHoa] set GiaBan = @gia * 1.1 where MaHH = @mahh
	end
go
--Câu 4. Tìm kiếm sản phẩm theo: loại, độ rượu và nước sx	

select MaHH, TenHH,GiaBan, Soluong 
from DMHangHoa join DoRuou on DMHangHoa.MaDo = DoRuou.MaDo
			   join Loai on DMHangHoa.Maloai = Loai.Maloai
			   join NuocSX on DMHangHoa.MaNSX = NuocSX.MaNSX
where MaHH is not null and Tenloai = N'Rượu Vang'
go
select * from HDNhap

--Câu 5. Tìm kiếm các HĐ nhập theo: mã hàng, ncc, ngày nhập							

select HDNhap.HDN, MaNV, NgayNhap, NhaCungCap.MaNCC, TongTien 
from HDNhap join ChiTietHDN on HDNhap.HDN = ChiTietHDN.HDN
					 join DMHangHoa on ChiTietHDN.MaHH = DMHangHoa.MaHH
					 join NhaCungCap on NhaCungCap.MaNCC = HDNhap.MaNCC
where HDNhap.HDN is not null and ChiTietHDN.MaHH = '' and TenNCC = '' and NgayNhap = '' 
go
--6. Báo cáo danh sách 3 sản phẩm được mua nhiều nhất từ một khách hàng chọn trước.							

alter function TOP3SP(@makh nvarchar(10)) returns table as return
select Top 3 TenHH as N'Tên Hàng Hóa', sum(ChiTietHDB.SoLuong) as N'Số Lượng'
from dbo.DMHangHoa join ChiTietHDB on DMHangHoa.MaHH = ChiTietHDB.MaHH 
				   join HDBan on ChiTietHDB.HDB = HDBan.HDB
				   join KhachHang on KhachHang.MaKH = HDBan.MaKH
where KhachHang.MaKH = @makh
group by TenHH
order by sum(ChiTietHDB.SoLuong) desc
go

create function TOPSP(@makh nvarchar(10)) returns table as return
select Top 3 TenHH as N'Tên Hàng Hóa', sum(ChiTietHDB.SoLuong) as N'Số Lượng'
from dbo.DMHangHoa join ChiTietHDB on DMHangHoa.MaHH = ChiTietHDB.MaHH 
				   join HDBan on ChiTietHDB.HDB = HDBan.HDB
				   join KhachHang on KhachHang.MaKH = HDBan.MaKH
group by TenHH
order by sum(ChiTietHDB.SoLuong) desc
go

select * from HDBan
select * from ChiTietHDB
Select * from TOPSP
select * from TOP3SP('KH05')
go

--7. Báo cáo danh sách hoá đơn và tổng tiền nhập hàng từ một NCC chọn trước.							

select HDN, TongTien from HDNhap where MaNCC = 'NCC01'
group by HDN, TongTien

--Câu 8. Báo cáo doanh thu của cửa hàng theo năm chọn trước.		

select * from HDBan
select * from ChiTietHDB

Select YEAR(NgayBan) as N'Năm' ,sum(TongTien) as 'Doanh Thu' from HDBan 
group by YEAR(NgayBan)

Select MONTH(NgayBan) as N'Tháng', sum(TongTien) as N'Doanh Thu' from HDBan
where YEAR(NgayBan) = '2019'
group by MONTH(NgayBan)


Select sum(TongTien) as '2018' from HDBan 
where YEAR(NgayBan) = '2018'
go


--Câu 9. Báo cáo ds các hoá đơn bán của một mặt hàng được chọn trước	

select HDB, ChiTietHDB.SoLuong, ThanhTien from DMHangHoa join ChiTietHDB on DMHangHoa.MaHH = ChiTietHDB.MaHH
where DMHangHoa.MaHH = 'HH01'
go


