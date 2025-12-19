using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace QuanLyThietBi.Helpers.db
{
    //internal class DBConnect
    //{
    //    private static readonly string connectionString = @"Server=localhost;Database=QuanLyThietBi;Trusted_Connection=True;TrustServerCertificate=True;";
    //    public static string GetConnectionString()
    //    {
    //        return connectionString;
    //    }

    //    public static SqlConnection GetSQLConnector()
    //    {

    //        try
    //        {
    //            SqlConnection sqlConnection = new SqlConnection(connectionString);
    //            sqlConnection.Open();
    //            return sqlConnection;
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new Exception("Lỗi kết nối cơ sở dữ liệu: Có thể database đang gặp lỗi, Vui lòng kết nối lại " );
    //        }
    //    }

    //}
    internal class DBConnect
    {
        // ĐỔI TỪ localhost SANG đường dẫn file .mdf trên share
        private static readonly string dbPath = @"\\192.168.1.100\thư mục nội bộ\KIETDINH\QuanLyThietBi.mdf";

        private static readonly string connectionString = $@"
            Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename={dbPath};
            Integrated Security=True;
            Connect Timeout=30;
            MultipleActiveResultSets=True;
            TrustServerCertificate=True";

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
                throw new Exception($"Lỗi kết nối database:\n{ex.Message}\n\nKiểm tra:\n- Đã cài SQL Server LocalDB?\n- Có truy cập được {dbPath}?");
            }
        }
    }

}