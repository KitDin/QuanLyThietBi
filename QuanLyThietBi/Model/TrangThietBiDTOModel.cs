using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyThietBi.Model
{
    public class TrangThietBiDTOModel
    {
        public string MaThietBi { get; set; }
        public string DonViTinh { get; set; }
        public string MaPhongBan { get; set; }
        public string MaLoaiThietBi { get; set; }
        public string MaTrangThai { get; set; }

        public string Seri { get; set; }
        public string Model { get; set; }
        public string Hang { get; set; }
        public string CauHinh { get; set; }
        public string LoaiKetNoi { get; set; }
        public DateTime? NgaySuDung { get; set; }
        public DateTime? NgayBaoHanh { get; set; }
        public DateTime? NgayBaoTri { get; set; }
        public DateTime? NgayMua { get; set; }
        public decimal Gia { get; set; }
        public string DiaChiIP { get; set; }
        public string GhiChu { get; set; }

        public string TenTrangThietBi { get; set; }

        public override string ToString()
        {
            return $@"
Ma thiết bị       : {MaThietBi}
Đơn vị tính       : {DonViTinh}
Mã phòng ban      : {MaPhongBan}
Mã loại thiết bị  : {MaLoaiThietBi}
Mã trạng thái     : {MaTrangThai}
Số seri           : {Seri}
Model             : {Model}
Hãng              : {Hang}
Cấu hình          : {CauHinh}
Loại kết nối      : {LoaiKetNoi}
Ngày sử dụng      : {NgaySuDung?.ToString("dd/MM/yyyy") ?? "N/A"}
Ngày bảo hành     : {NgayBaoHanh?.ToString("dd/MM/yyyy") ?? "N/A"}
Ngày bảo trì      : {NgayBaoTri?.ToString("dd/MM/yyyy") ?? "N/A"}
Ngày mua          : {NgayMua?.ToString("dd/MM/yyyy") ?? "N/A"}
Đơn giá           : {Gia}
Địa chỉ IP        : {DiaChiIP}
Ghi chú           : {GhiChu}
".Trim();
        }
    }
}
