CREATE TABLE ĐăngBán (
  Tên_mặt_hàng varchar(200),
  Loại_mặt_hàng varchar(200),
  Giá_bán float,
  Mô_tả_mặt_hàng varchar(1000),
  Ngày_đăng_bán Datetime,
  Hình_ảnh Image,
  Mã_Voucher varchar(50),
  Giảm_giá float,
  Số_lượng_Voucher int,
  Số_lượng int,
  Địa_điểm varchar(200),
  Phương_thức_giao_hàng varchar(500),
  Tình_trạng_mặt_hàng varchar(1000)
);
select * from ĐăngBán