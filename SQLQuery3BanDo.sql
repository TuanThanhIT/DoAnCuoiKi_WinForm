CREATE TABLE ĐăngBán
(
	Tên_mặt_hàng varchar(100),
	Loại_mặt_hàng varchar(100),
	Giá_bán float,
	Mô_tả_mặt_hàng varchar(500),
	Ngày_đăng_bán DateTime,
	Hình_ảnh_1 Image,
	Hình_ảnh_2 Image,
	Hình_ảnh_3 Image,
	Hình_ảnh_4 Image,
	Mã_Voucher varchar(10),
	Giảm_giá float,
	Số_lượng_Voucher int,
	Số_lượng int,
	Địa_điểm varchar(200),
	Phương_thức_giao_hàng varchar(500),
	Tình_trạng_mặt_hàng varchar(200)
);
select * from ĐăngBán