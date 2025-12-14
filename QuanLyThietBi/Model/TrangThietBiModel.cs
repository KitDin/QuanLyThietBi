using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyThietBi.Model
{
    internal class TrangThietBiModel
    {
        public string Ma_trang_thiet_bi { get; set; }
        public string Ten_trang_thiet_bi { get; set; }
        public string Don_vi_tinh { get; set; }

        // ===== Thông tin join hiển thị =====
        public string Ten_loai_thiet_bi { get; set; }
        public string Ten_phong_ban { get; set; }
        public string Ten_trang_thai { get; set; }

        // ===== Thông tin thiết bị =====
        public string So_seri { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Cau_hinh { get; set; }
        public string Loai_ket_noi { get; set; }

        // ===== Thời gian =====
        public DateTime? Thoi_gian_mua { get; set; }
        public DateTime? Thoi_gian_bao_tri { get; set; }
        public DateTime? Hang_bao_hanh { get; set; }
        public DateTime? Thoi_gian_dua_vao_su_dung { get; set; }
        public DateTime? Thoi_gian_them { get; set; }

        // ===== Tài chính =====
        public decimal? Don_gia { get; set; }

        // ===== Khác =====
        public string Ghi_chu { get; set; }
        public string Dia_chi_IP { get; set; }
    }
}
