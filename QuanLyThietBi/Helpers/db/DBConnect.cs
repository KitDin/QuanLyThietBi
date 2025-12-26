using System;
using Microsoft.Data.SqlClient;

namespace QuanLyThietBi.Helpers.db
{
    internal class DBConnect
    {
        private static readonly string connectionString = @"
                Server=172.16.17.132;
                Database=QuanLyThietBi;
                User ID=QuanLyUser;
                Password=QuanLy@123;
                TrustServerCertificate=True;
                Connect Timeout=30;
                MultipleActiveResultSets=True";

        private static readonly string localConnectionString = @"
                Server=localhost;
                Database=QuanLyThietBi;
                User ID=QuanLyUser;
                Password=MatKhau@123;
                TrustServerCertificate=True;
                Connect Timeout=30;
                MultipleActiveResultSets=True";

        public static string GetConnectionString()
        {
            return connectionString;
        }

        public static SqlConnection GetSQLConnector()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(localConnectionString);
                sqlConnection.Open();
                return sqlConnection;
            }
            catch (SqlException ex)
            {
                string errorMsg = "Lỗi kết nối database:\n\n";

                if (ex.Number == 53 || ex.Number == -1)
                {
                    errorMsg += "Không thể kết nối đến server 172.16.17.132\n\n" +
                               "Kiểm tra:\n" +
                               "- Máy server (172.16.17.132) có bật không?\n" +
                               "- SQL Server có chạy không?\n" +
                               "- Firewall có chặn port 1433 không?\n" +
                               "- Cùng mạng LAN không?";
                }
                else if (ex.Number == 18456)
                {
                    errorMsg += "Sai username hoặc password!\n\n" +
                               "Username: QuanLyUser\n" +
                               "Password: MatKhau@123\n\n" +
                               "Kiểm tra SQL Login đã tạo chưa?";
                }
                else if (ex.Number == 4060)
                {
                    errorMsg += "Database 'QuanLyThietBi' không tồn tại!\n\n" +
                               "Chạy Setup trên máy server để tạo database.";
                }
                else
                {
                    errorMsg += ex.Message;
                }

                throw new Exception(errorMsg);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi: {ex.Message}");
            }
        }
    }
}