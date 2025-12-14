using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QuanLyThietBi.Helpers.db
{
    internal class LookupDB
    {
        public List<Model.TrangThietBiModel> LookupThietBi(string keyword)
        {
            List<Model.TrangThietBiModel> list = new List<Model.TrangThietBiModel>();

            using (var conn = DBConnect.GetSQLConnector())
            {
                string sql = @"
                SELECT 
                    ttb.Ma_trang_thiet_bi,
                    ltb.Ten_loai_thiet_bi,
                    pb.Ten_phong_ban,
                    tt.Ten_trang_thai,
                    ttb.So_seri,
                    ttb.Brand,
                    ttb.Model,
                    ttb.Cau_hinh,
                    ttb.Loai_ket_noi,
                    ttb.Thoi_gian_mua
                FROM Trang_thiet_bi ttb
                JOIN Loai_thiet_bi ltb ON ttb.Ma_loai_thiet_bi = ltb.Ma_loai_thiet_bi
                JOIN Phong_ban pb ON ttb.Ma_phong_ban = pb.Ma_phong_ban
                JOIN Trang_thai_su_dung tt ON ttb.Ma_trang_thai = tt.Ma_trang_thai
                WHERE 
                    ttb.Ma_trang_thiet_bi LIKE @kw OR       
                    ttb.So_seri LIKE @kw OR
                    ttb.Brand LIKE @kw OR
                    ttb.Model LIKE @kw OR
                    ltb.Ten_loai_thiet_bi LIKE @kw OR
                    tt.Ten_trang_thai LIKE @kw OR
                    pb.Ten_phong_ban LIKE @kw";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                    using (var rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            list.Add(new Model.TrangThietBiModel
                            {
                                Ma_trang_thiet_bi = rd["Ma_trang_thiet_bi"].ToString(),
                                Ten_loai_thiet_bi = rd["Ten_loai_thiet_bi"].ToString(),
                                Ten_phong_ban = rd["Ten_phong_ban"].ToString(),
                                Ten_trang_thai = rd["Ten_trang_thai"].ToString(),
                                So_seri = rd["So_seri"].ToString(),
                                Brand = rd["Brand"].ToString(),
                                Model = rd["Model"].ToString(),
                                Cau_hinh = rd["Cau_hinh"].ToString(),
                                Loai_ket_noi = rd["Loai_ket_noi"].ToString(),
                                Thoi_gian_mua = rd["Thoi_gian_mua"] == DBNull.Value
                                                ? (DateTime?)null
                                                : Convert.ToDateTime(rd["Thoi_gian_mua"])
                            });
                        }
                    }
                }
            }

            return list;
        }


        public List<Model.TrangThietBiModel> LookupThietBi(
    string keyword,
    int maPhongBan,
    int maLoai,
    int maTrangThai)
        {
            List<Model.TrangThietBiModel> list = new List<Model.TrangThietBiModel>();

            using (var conn = DBConnect.GetSQLConnector())
            {
                string sql = @"
        SELECT 
            ttb.Ma_trang_thiet_bi,
            ltb.Ten_loai_thiet_bi,
            pb.Ten_phong_ban,
            tt.Ten_trang_thai,
            ttb.So_seri,
            ttb.Brand,
            ttb.Model,
            ttb.Cau_hinh,
            ttb.Loai_ket_noi,
            ttb.Thoi_gian_mua,

        ttb.Ma_trang_thiet_bi,
        ttb.Ten_trang_thiet_bi,
        ttb.Don_vi_tinh,

        ltb.Ten_loai_thiet_bi,
        pb.Ten_phong_ban,
        tt.Ten_trang_thai,

        ttb.So_seri,
        ttb.Brand,
        ttb.Model,
        ttb.Cau_hinh,
        ttb.Loai_ket_noi,

        ttb.Thoi_gian_mua,
        ttb.Thoi_gian_bao_tri,
        ttb.Hang_bao_hanh,
        ttb.Thoi_gian_dua_vao_su_dung,
        ttb.Thoi_gian_them,

        ttb.Don_gia,
        ttb.Ghi_chu,
        ttb.IP
        FROM Trang_thiet_bi ttb
        JOIN Loai_thiet_bi ltb ON ttb.Ma_loai_thiet_bi = ltb.Ma_loai_thiet_bi
        JOIN Phong_ban pb ON ttb.Ma_phong_ban = pb.Ma_phong_ban
        JOIN Trang_thai_su_dung tt ON ttb.Ma_trang_thai = tt.Ma_trang_thai
        WHERE
        (
            @kw IS NULL
            OR ttb.Ma_trang_thiet_bi LIKE @kw
            OR ttb.Ten_trang_thiet_bi LIKE @kw
            OR ttb.So_seri LIKE @kw
            OR ttb.Brand LIKE @kw
            OR ttb.Model LIKE @kw
            OR ltb.Ten_loai_thiet_bi LIKE @kw
            OR pb.Ten_phong_ban LIKE @kw
            OR tt.Ten_trang_thai LIKE @kw
        )
        AND (@pb = 0 OR ttb.Ma_phong_ban = @pb)
        AND (@loai = 0 OR ttb.Ma_loai_thiet_bi = @loai)
        AND (@tt = 0 OR ttb.Ma_trang_thai = @tt)
        ";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    if (string.IsNullOrWhiteSpace(keyword))
                        cmd.Parameters.AddWithValue("@kw", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                    cmd.Parameters.AddWithValue("@pb", maPhongBan);
                    cmd.Parameters.AddWithValue("@loai", maLoai);
                    cmd.Parameters.AddWithValue("@tt", maTrangThai);

                    using (var rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            list.Add(new Model.TrangThietBiModel
                            {
                                Ma_trang_thiet_bi = rd["Ma_trang_thiet_bi"].ToString(),
                                Ten_trang_thiet_bi = rd["Ten_trang_thiet_bi"].ToString(),
                                Ten_loai_thiet_bi = rd["Ten_loai_thiet_bi"].ToString(),
                                Ten_phong_ban = rd["Ten_phong_ban"].ToString(),
                                Ten_trang_thai = rd["Ten_trang_thai"].ToString(),
                                So_seri = rd["So_seri"].ToString(),
                                Brand = rd["Brand"].ToString(),
                                Model = rd["Model"].ToString(),
                                Cau_hinh = rd["Cau_hinh"].ToString(),
                                Loai_ket_noi = rd["Loai_ket_noi"].ToString(),
                                Don_vi_tinh = rd["Don_vi_tinh"].ToString(),
                                Ghi_chu = rd["Ghi_chu"].ToString(),

                                // Các trường DateTime
                                Thoi_gian_mua = rd["Thoi_gian_mua"] == DBNull.Value
                                    ? (DateTime?)null
                                    : Convert.ToDateTime(rd["Thoi_gian_mua"]),

                                Thoi_gian_bao_tri = rd["Thoi_gian_bao_tri"] == DBNull.Value
                                    ? (DateTime?)null
                                    : Convert.ToDateTime(rd["Thoi_gian_bao_tri"]),

                                Hang_bao_hanh = rd["Hang_bao_hanh"] == DBNull.Value
                                    ? (DateTime?)null
                                    : Convert.ToDateTime(rd["Hang_bao_hanh"]),

                                Thoi_gian_dua_vao_su_dung = rd["Thoi_gian_dua_vao_su_dung"] == DBNull.Value
                                    ? (DateTime?)null
                                    : Convert.ToDateTime(rd["Thoi_gian_dua_vao_su_dung"]),

                                Thoi_gian_them = rd["Thoi_gian_them"] == DBNull.Value
                                    ? (DateTime?)null
                                    : Convert.ToDateTime(rd["Thoi_gian_them"]),

                                // Đơn giá
                                Don_gia = rd["Don_gia"] == DBNull.Value
                                    ? (decimal?)null
                                    : Convert.ToDecimal(rd["Don_gia"]),

                                Dia_chi_IP = rd["IP"] == DBNull.Value ? string.Empty : rd["IP"]?.ToString()
                            });
                        }
                    }
                }
            }
            return list;
        }


        public List<Model.PhongBanModel> GetAllPhongBan()
        {
            List<Model.PhongBanModel> list = new List<Model.PhongBanModel>();
            using (var conn = DBConnect.GetSQLConnector())
            {
                string sql = "SELECT Ma_phong_ban, Ten_phong_ban FROM Phong_ban";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    using (var rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            list.Add(new Model.PhongBanModel
                            {
                                Ma_phong_ban = Convert.ToInt32(rd["Ma_phong_ban"]),
                                Ten_phong_ban = rd["Ten_phong_ban"].ToString()
                            });
                        }
                    }
                }
            }
            return list;
        }

        public List<Model.PhongBanModel> SearchPhongBan(string key)
        {
            List<Model.PhongBanModel> list = new List<Model.PhongBanModel>();
            using (var conn = DBConnect.GetSQLConnector())
            {
                string sql = "SELECT Ma_phong_ban, Ten_phong_ban FROM Phong_ban WHERE Ten_phong_ban LIKE @key";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@key", "%" + key + "%");
                    using (var rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            list.Add(new Model.PhongBanModel
                            {
                                Ma_phong_ban = Convert.ToInt32(rd["Ma_phong_ban"]),
                                Ten_phong_ban = rd["Ten_phong_ban"].ToString()
                            });
                        }
                    }
                }
            }
            return list;
        }



        public List<Model.LoaiThietBiModel> GetAllLoaiThietBi()
        {
            List<Model.LoaiThietBiModel> list = new List<Model.LoaiThietBiModel>();
            using (var conn = DBConnect.GetSQLConnector())
            {
                string sql = "SELECT Ma_loai_thiet_bi, Ten_loai_thiet_bi FROM Loai_thiet_bi";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    using (var rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            list.Add(new Model.LoaiThietBiModel
                            {
                                Ma_loai_thiet_bi = Convert.ToInt32(rd["Ma_loai_thiet_bi"]),
                                Ten_loai_thiet_bi = rd["Ten_loai_thiet_bi"].ToString()
                            });
                        }
                    }
                }
            }
            return list;
        }

        public List<Model.TrangThaiSuDungModel> GetAllTrangThaiSuDung()
        {
            List<Model.TrangThaiSuDungModel> list = new List<Model.TrangThaiSuDungModel>();
            using (var conn = DBConnect.GetSQLConnector())
            {
                string sql = "SELECT Ma_trang_thai, Ten_trang_thai FROM Trang_thai_su_dung";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    using (var rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            list.Add(new Model.TrangThaiSuDungModel
                            {
                                Ma_trang_thai = Convert.ToInt32(rd["Ma_trang_thai"]),
                                Ten_trang_thai = rd["Ten_trang_thai"].ToString()
                            });
                        }
                    }
                }
            }
            return list;
        }

    }
}
