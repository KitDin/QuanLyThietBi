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
    }
}
