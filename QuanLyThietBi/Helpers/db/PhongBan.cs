using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyThietBi.Helpers.db
{
    public class PhongBan
    {
        public Model.PhongBanModel GetById(string maPhongBan)
        {
            Model.PhongBanModel phongBan = null;
            string sql = @"Select * from Phong_ban where ma_phong_ban=@MaPhongBan";
            using (SqlConnection conn = DBConnect.GetSQLConnector())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaPhongBan", maPhongBan);
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        phongBan = new Model.PhongBanModel()
                        {
                            Ma_phong_ban = rd.GetInt32(rd.GetOrdinal("ma_phong_ban")),
                            Ten_phong_ban = rd.GetString(rd.GetOrdinal("ten_phong_ban"))
                        };
                    }
                }
            }


            return phongBan;
        }

        public List<Model.PhongBanModel> GetSoLuong()
        {
            List<Model.PhongBanModel> list = new List<Model.PhongBanModel>();
            string sql = @"SELECT 
                                pb.Ten_phong_ban,
                                COUNT(ttb.Ma_trang_thiet_bi) AS SoLuongThietBi
                            FROM Trang_thiet_bi ttb
                            RIGHT JOIN Phong_ban pb ON ttb.Ma_phong_ban = pb.Ma_phong_ban
                            GROUP BY pb.Ten_phong_ban
                            ORDER BY SoLuongThietBi DESC";
            using (SqlConnection conn = DBConnect.GetSQLConnector())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        var phongBan = new Model.PhongBanModel()
                        {
                            Ten_phong_ban = rd.GetString(rd.GetOrdinal("ten_phong_ban")),
                            So_luong = rd.GetInt32(rd.GetOrdinal("SoLuongThietBi"))
                        };
                        list.Add(phongBan);
                    }
                }
            }
            return list;
        }
    }
}
