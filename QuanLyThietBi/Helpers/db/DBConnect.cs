using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace QuanLyThietBi.Helpers.db
{
    internal class DBConnect
    {
        private static readonly string connectionString = @"Server=localhost;Database=QuanLyThietBi;Trusted_Connection=True;TrustServerCertificate=True;";
        public static string GetConnectionString()
        {
            return connectionString;
        }

        public static SqlConnection GetSQLConnector()
        {

            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                return sqlConnection;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi kết nối cơ sở dữ liệu: Có thể database đang gặp lỗi, Vui lòng kết nối lại " );
            }
        }
    
    }
}