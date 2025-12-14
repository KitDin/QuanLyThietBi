using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using QuanLyThietBi.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyThietBi.Helpers.db
{
    internal class Login
    {

        public static UserLoginModel CheckLogin(string username, string password)
        {
            try
            {
                using (SqlConnection conn = DBConnect.GetSQLConnector())
                {
                    string query = @"
                SELECT 
                    nd.Ma_nguoi_dung,
                    nd.Ho_ten,
                    nd.Username,
                    q.Ma_quyen
                FROM Nguoi_dung nd
                JOIN Phong_ban_Quyen pbq ON nd.Ma_nguoi_dung = pbq.Ma_nguoi_dung
                JOIN Quyen q ON pbq.Ma_quyen = q.Ma_quyen
                WHERE nd.Username = @username
                  AND nd.Password = @password;
            ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new UserLoginModel
                                {
                                    MaNguoiDung = reader.GetInt32(0),
                                    HoTen = reader.GetString(1),
                                    Username = reader.GetString(2),
                                    Quyen = (UserRole)reader.GetInt32(3)
                                };
                            }
                        }
                    }
                }

                throw new Exception("Tên đăng nhập hoặc mật khẩu không đúng.");
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi đăng nhập: " + ex.Message);
            }
        }

    }
}
