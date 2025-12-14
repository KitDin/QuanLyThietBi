using Microsoft.Data.SqlClient;
using QuanLyThietBi.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QuanLyThietBi.Helpers.db
{
    internal class TrangThietBi
    {

        public List<TrangThietBiModel> GetAll()
        {
            List<TrangThietBiModel> list = new List<TrangThietBiModel>();

            string sql = @"
    SELECT 
        t.Ma_trang_thiet_bi,
        t.Ten_trang_thiet_bi,
        t.Don_vi_tinh,

        l.Ten_loai_thiet_bi,
        p.Ten_phong_ban,
        tt.Ten_trang_thai,

        t.So_seri,
        t.Brand,
        t.Model,
        t.Cau_hinh,
        t.Loai_ket_noi,

        t.Thoi_gian_mua,
        t.Thoi_gian_bao_tri,
        t.Hang_bao_hanh,
        t.Thoi_gian_dua_vao_su_dung,
        t.Thoi_gian_them,

        t.Don_gia,
        t.Ghi_chu
    FROM Trang_thiet_bi t
    JOIN Loai_thiet_bi l ON t.Ma_loai_thiet_bi = l.Ma_loai_thiet_bi
    JOIN Phong_ban p ON t.Ma_phong_ban = p.Ma_phong_ban
    JOIN Trang_thai_su_dung tt ON t.Ma_trang_thai = tt.Ma_trang_thai
    ORDER BY t.Thoi_gian_them DESC";

            using (SqlConnection conn = DBConnect.GetSQLConnector())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            using (SqlDataReader rd = cmd.ExecuteReader())
            {
                while (rd.Read())
                {
                    TrangThietBiModel tb = new TrangThietBiModel
                    {
                        Ma_trang_thiet_bi = rd.IsDBNull(0) ? "" : rd.GetString(0),
                        Ten_trang_thiet_bi = rd.IsDBNull(1) ? "" : rd.GetString(1),
                        Don_vi_tinh = rd.IsDBNull(2) ? "" : rd.GetString(2),

                        Ten_loai_thiet_bi = rd.IsDBNull(3) ? "" : rd.GetString(3),
                        Ten_phong_ban = rd.IsDBNull(4) ? "" : rd.GetString(4),
                        Ten_trang_thai = rd.IsDBNull(5) ? "" : rd.GetString(5),

                        So_seri = rd.IsDBNull(6) ? "" : rd.GetString(6),
                        Brand = rd.IsDBNull(7) ? "" : rd.GetString(7),
                        Model = rd.IsDBNull(8) ? "" : rd.GetString(8),
                        Cau_hinh = rd.IsDBNull(9) ? "" : rd.GetString(9),
                        Loai_ket_noi = rd.IsDBNull(10) ? "" : rd.GetString(10),

                        Thoi_gian_mua = rd.IsDBNull(11) ? (DateTime?)null : rd.GetDateTime(11),
                        Thoi_gian_bao_tri = rd.IsDBNull(12) ? (DateTime?)null : rd.GetDateTime(12),
                        Hang_bao_hanh = rd.IsDBNull(13) ? (DateTime?)null : rd.GetDateTime(13),
                        Thoi_gian_dua_vao_su_dung = rd.IsDBNull(14) ? (DateTime?)null : rd.GetDateTime(14),
                        Thoi_gian_them = rd.IsDBNull(15) ? (DateTime?)null : rd.GetDateTime(15),

                        Don_gia = rd.IsDBNull(16) ? (decimal?)null : rd.GetDecimal(16),
                        Ghi_chu = rd.IsDBNull(17) ? "" : rd.GetString(17)
                    };


                    list.Add(tb);
                }
            }

            return list;
        }

        public string GenerateNextMaThietBi(string tenLoai)
        {
            if (string.IsNullOrWhiteSpace(tenLoai)) return "";

            string[] parts = tenLoai.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string prefix = "";
            foreach (var part in parts)
                prefix += part.Substring(0, 1).ToUpper();


            using (var conn = DBConnect.GetSQLConnector())
            {
                string sql = @"
            SELECT Ma_trang_thiet_bi 
            FROM Trang_thiet_bi
            WHERE Ma_trang_thiet_bi LIKE @prefix + '%'
        ";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@prefix", prefix);

                    List<int> numbers = new List<int>();
                    using (var rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            string ma = rd["Ma_trang_thiet_bi"].ToString();

                            if (ma.Contains("-"))
                            {
                                string numStr = ma.Split('-')[1];
                                if (int.TryParse(numStr, out int num))
                                    numbers.Add(num);
                            }
                        }
                    }

                    int nextNum = (numbers.Count == 0) ? 1 : (numbers.Max() + 1);

                    return $"{prefix}-{nextNum}";
                }
            }
        }

        public bool AddNewThietBi(Model.TrangThietBiDTOModel tbDTO)
        {
            string sql = @"
    INSERT INTO Trang_thiet_bi
    (
        Ma_trang_thiet_bi,
        Ten_trang_thiet_bi,
        Ma_loai_thiet_bi,
        Ma_phong_ban,
        Ma_trang_thai,
        Don_vi_tinh,
        So_seri,
        Brand,
        Model,
        Cau_hinh,
        Loai_ket_noi,
        Thoi_gian_mua,
        Thoi_gian_bao_tri,
        Hang_bao_hanh,
        Thoi_gian_dua_vao_su_dung,
        Don_gia,
        Ghi_chu,
        IP
    )
    VALUES
    (
        @MaTrangThietBi,
        @TenTrangThietBi,
        @MaLoaiThietBi,
        @MaPhongBan,
        @MaTrangThai,
        @DonViTinh,
        @SoSeri,
        @Brand,
        @Model,
        @CauHinh,
        @LoaiKetNoi,
        @ThoiGianMua,
        @ThoiGianBaoTri,
        @HangBaoHanh,
        @ThoiGianDuaVaoSuDung,
        @DonGia,
        @GhiChu,
        @IP
    );";

            using (SqlConnection conn = DBConnect.GetSQLConnector())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaTrangThietBi", tbDTO.MaThietBi ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@TenTrangThietBi", tbDTO.TenTrangThietBi ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@MaLoaiThietBi", tbDTO.MaLoaiThietBi);
                cmd.Parameters.AddWithValue("@MaPhongBan", tbDTO.MaPhongBan);
                cmd.Parameters.AddWithValue("@MaTrangThai", tbDTO.MaTrangThai);
                cmd.Parameters.AddWithValue("@DonViTinh", tbDTO.DonViTinh ?? (object)DBNull.Value);

                cmd.Parameters.AddWithValue("@SoSeri", tbDTO.Seri ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Brand", tbDTO.Hang ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Model", tbDTO.Model ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@CauHinh", tbDTO.CauHinh ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@LoaiKetNoi", tbDTO.LoaiKetNoi ?? (object)DBNull.Value);

                cmd.Parameters.AddWithValue("@ThoiGianMua", tbDTO.NgayMua);
                cmd.Parameters.AddWithValue("@ThoiGianBaoTri", tbDTO.NgayBaoTri);

                cmd.Parameters.AddWithValue("@HangBaoHanh", tbDTO.NgayBaoHanh);

                cmd.Parameters.AddWithValue("@ThoiGianDuaVaoSuDung", tbDTO.NgaySuDung);

                if (tbDTO.Gia != null)
                    cmd.Parameters.AddWithValue("@DonGia", tbDTO.Gia);
                else
                    cmd.Parameters.AddWithValue("@DonGia", DBNull.Value);

                cmd.Parameters.AddWithValue("@GhiChu", tbDTO.GhiChu ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@IP", tbDTO.DiaChiIP ?? (object)DBNull.Value);

                if (conn.State != ConnectionState.Open) conn.Open();

                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }





        public TrangThietBiDTOModel GetTrangThietBi(string maTrangThietBi)
        {
            TrangThietBiDTOModel ttb = null;

            string sql = @"
        SELECT 
            Ma_trang_thiet_bi,
            So_seri,
            Ma_trang_thai,
            Ma_loai_thiet_bi,
            Ma_phong_ban,
            Brand,
            Don_vi_tinh,
            Model,
            Cau_hinh,
            Loai_ket_noi,
            Thoi_gian_mua,
            Ghi_chu,
            Thoi_gian_bao_tri,
            Thoi_gian_dua_vao_su_dung,
            Hang_bao_hanh,
            Don_gia,
            IP,
            Ten_trang_thiet_bi
        FROM Trang_thiet_bi 
        WHERE Ma_trang_thiet_bi = @MaThietBi;
    ";

            using (SqlConnection conn = DBConnect.GetSQLConnector())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaThietBi", maTrangThietBi);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ttb = new TrangThietBiDTOModel
                        {
                            MaThietBi = reader["Ma_trang_thiet_bi"].ToString(),
                            Seri = reader["So_seri"] as string,
                            MaTrangThai = reader["Ma_trang_thai"].ToString(),
                            MaLoaiThietBi = reader["Ma_loai_thiet_bi"].ToString(),
                            MaPhongBan = reader["Ma_phong_ban"].ToString(),
                            Hang = reader["Brand"] as string,
                            DonViTinh = reader["Don_vi_tinh"] as string,
                            Model = reader["Model"] as string,
                            CauHinh = reader["Cau_hinh"] as string,
                            LoaiKetNoi = reader["Loai_ket_noi"] as string,

                            NgayMua = reader["Thoi_gian_mua"] == DBNull.Value ? (DateTime?)null : (DateTime?)reader["Thoi_gian_mua"],
                            NgayBaoTri = reader["Thoi_gian_bao_tri"] == DBNull.Value ? (DateTime?)null : (DateTime?)reader["Thoi_gian_bao_tri"],
                            NgaySuDung = reader["Thoi_gian_dua_vao_su_dung"] == DBNull.Value ? (DateTime?)null : (DateTime?)reader["Thoi_gian_dua_vao_su_dung"],
                            NgayBaoHanh = reader["Hang_bao_hanh"] == DBNull.Value ? (DateTime?)null : (DateTime?)reader["Hang_bao_hanh"],

                            Gia = reader["Don_gia"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["Don_gia"]),
                            DiaChiIP = reader["IP"] as string,
                            GhiChu = reader["Ghi_chu"] as string,
                            TenTrangThietBi = reader["Ten_trang_thiet_bi"] as string
                        };
                    }
                }
            }

            return ttb;
        }

        public bool UpdateThietBi(Model.TrangThietBiDTOModel tbDTO)
        {
            string sql = @"
            update Trang_thiet_bi 
            Set 
                So_seri = @Seri,
                Ten_trang_thiet_bi = @TenTrangThietBi,
                Ma_trang_thai = @MaTrangThai,
                Ma_loai_thiet_bi = @MaLoaiThietBi,
                Ma_phong_ban = @MaPhongBan,
                Brand = @Hang,
                Don_vi_tinh = @DonViTinh,
                Model = @Model,
                Cau_hinh = @CauHinh,
                Loai_ket_noi = @LoaiKetNoi,
                Thoi_gian_mua = @ThoiGianMua,
                Ghi_chu = @GhiChu,
                Thoi_gian_bao_tri = @ThoiGianBaoTri,
                Thoi_gian_dua_vao_su_dung = @ThoiGianSuDung,
                Hang_bao_hanh = @HanBaoHanh,
                Don_gia = @Gia
            where Ma_trang_thiet_bi = @MaThietBi;";

            using (SqlConnection conn = DBConnect.GetSQLConnector())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaThietBi", tbDTO.MaThietBi);

                cmd.Parameters.AddWithValue("@Seri", tbDTO.Seri ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@TenTrangThietBi", tbDTO.TenTrangThietBi ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@MaTrangThai", tbDTO.MaTrangThai);
                cmd.Parameters.AddWithValue("@MaLoaiThietBi", tbDTO.MaLoaiThietBi);
                cmd.Parameters.AddWithValue("@MaPhongBan", tbDTO.MaPhongBan);
                cmd.Parameters.AddWithValue("@Hang", tbDTO.Hang ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@DonViTinh", tbDTO.DonViTinh ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Model", tbDTO.Model ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@CauHinh", tbDTO.CauHinh ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@LoaiKetNoi", tbDTO.LoaiKetNoi ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@ThoiGianMua", tbDTO.NgayMua ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@GhiChu", tbDTO.GhiChu ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@ThoiGianBaoTri", tbDTO.NgayBaoTri ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@ThoiGianSuDung", tbDTO.NgaySuDung ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@HanBaoHanh", tbDTO.NgayBaoHanh ?? (object)DBNull.Value);
                if (tbDTO.Gia != null)
                {
                    cmd.Parameters.AddWithValue("@Gia", tbDTO.Gia);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Gia", DBNull.Value);
                }

                if (conn.State != ConnectionState.Open) conn.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }

        public bool Delete(string maThietBi)
        {
            string sql = @"DELETE FROM Trang_thiet_bi WHERE Ma_trang_thiet_bi = @MaThietBi;";
            using (SqlConnection conn = DBConnect.GetSQLConnector())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaThietBi", maThietBi);
                if (conn.State != ConnectionState.Open) conn.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }


        public List<Model.TrangThietBi_IPModel> GetAllTrangThietBi_IPModel()
        {
            List<Model.TrangThietBi_IPModel> list = new List<Model.TrangThietBi_IPModel>();
            string sql = @" SELECT 
            t.Ma_trang_thiet_bi,
            l.Ten_loai_thiet_bi,
            p.Ten_phong_ban,
            tt.Ten_trang_thai,
            t.IP,
            t.Ten_trang_thiet_bi
        FROM Trang_thiet_bi t
        JOIN Loai_thiet_bi l ON t.Ma_loai_thiet_bi = l.Ma_loai_thiet_bi
        JOIN Phong_ban p ON t.Ma_phong_ban = p.Ma_phong_ban
        JOIN Trang_thai_su_dung tt ON t.Ma_trang_thai = tt.Ma_trang_thai
        ORDER BY t.Thoi_gian_them DESC";

            using (SqlConnection conn = DBConnect.GetSQLConnector())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            Model.TrangThietBi_IPModel tb = new Model.TrangThietBi_IPModel
                            {
                                Ma_trang_thiet_bi = rd.GetString(0),
                                Ten_loai_thiet_bi = rd.GetString(1),
                                Ten_phong_ban = rd.GetString(2),
                                Ten_trang_thai = rd.GetString(3),
                                Dia_chi_IP = rd.IsDBNull(4) ? "" : rd.GetString(4),
                                Ten_trang_thiet_bi = rd.IsDBNull(5) ? "" : rd.GetString(5)
                            };
                            list.Add(tb);
                        }
                    }
                }
            }
            return list;
        }
    }
}
