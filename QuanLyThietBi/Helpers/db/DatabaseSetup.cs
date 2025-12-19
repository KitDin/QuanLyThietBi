using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace QuanLyThietBi.Helpers.db
{
    public class DatabaseSetup
    {
        // Đường dẫn database tạm trên máy local
        private static string localDbPath = @"C:\Temp\QuanLyThietBi.mdf";
        private static string localLogPath = @"C:\Temp\QuanLyThietBi_log.ldf";

        // Đường dẫn đích trên server share
        private static string shareDbPath = @"\\192.168.1.100\thư mục nội bộ\KIETDINH\QuanLyThietBi.mdf";
        private static string shareLogPath = @"\\192.168.1.100\thư mục nội bộ\KIETDINH\QuanLyThietBi_log.ldf";

        // Connection string master
        private static string masterConnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30";

        /// <summary>
        /// Bước 1: Tạo database file
        /// </summary>
        public static bool CreateDatabaseFile()
        {
            try
            {
                // Tạo thư mục C:\Temp nếu chưa có
                if (!Directory.Exists(@"C:\Temp"))
                    Directory.CreateDirectory(@"C:\Temp");

                // Xóa database cũ nếu có
                if (File.Exists(localDbPath))
                {
                    DetachDatabase();
                    File.Delete(localDbPath);
                    if (File.Exists(localLogPath))
                        File.Delete(localLogPath);
                }

                using (SqlConnection conn = new SqlConnection(masterConnStr))
                {
                    conn.Open();

                    string createDbQuery = $@"
                        CREATE DATABASE QuanLyThietBi
                        ON PRIMARY (
                            NAME = QuanLyThietBi_Data,
                            FILENAME = '{localDbPath}',
                            SIZE = 10MB,
                            MAXSIZE = 500MB,
                            FILEGROWTH = 10MB
                        )
                        LOG ON (
                            NAME = QuanLyThietBi_Log,
                            FILENAME = '{localLogPath}',
                            SIZE = 5MB,
                            MAXSIZE = 100MB,
                            FILEGROWTH = 5MB
                        )";

                    using (SqlCommand cmd = new SqlCommand(createDbQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tạo database:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Bước 2: Tạo bảng và dữ liệu
        /// </summary>
        public static bool CreateTables()
        {
            string connStr = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={localDbPath};Integrated Security=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(connStr, conn))
                    {
                        // Tạo bảng Phong_ban
                        cmd.CommandText = @"
                            CREATE TABLE Phong_ban (
                                Ma_phong_ban INT IDENTITY(1,1) PRIMARY KEY,
                                Ten_phong_ban NVARCHAR(100) NOT NULL
                            )";
                        cmd.ExecuteNonQuery();

                        // Tạo bảng Quyen
                        cmd.CommandText = @"
                            CREATE TABLE Quyen (
                                Ma_quyen INT IDENTITY(1,1) PRIMARY KEY,
                                Ten_quyen NVARCHAR(50) NOT NULL
                            )";
                        cmd.ExecuteNonQuery();

                        // Tạo bảng Nguoi_dung
                        cmd.CommandText = @"
                            CREATE TABLE Nguoi_dung (
                                Ma_nguoi_dung INT IDENTITY(1,1) PRIMARY KEY,
                                Ho_ten NVARCHAR(100) NOT NULL,
                                Ma_phong_ban INT NOT NULL,
                                Username NVARCHAR(50) UNIQUE NOT NULL,
                                Password NVARCHAR(255) NOT NULL,
                                CONSTRAINT FK_NguoiDung_PhongBan
                                FOREIGN KEY (Ma_phong_ban)
                                REFERENCES Phong_ban(Ma_phong_ban)
                            )";
                        cmd.ExecuteNonQuery();

                        // Tạo bảng Phong_ban_Quyen
                        cmd.CommandText = @"
                            CREATE TABLE Phong_ban_Quyen (
                                Ma_thuc_the INT IDENTITY(1,1) PRIMARY KEY,
                                Ma_quyen INT NOT NULL,
                                Ma_nguoi_dung INT NOT NULL,
                                CONSTRAINT FK_PBQ_Quyen
                                FOREIGN KEY (Ma_quyen)
                                REFERENCES Quyen(Ma_quyen),
                                CONSTRAINT FK_PBQ_NguoiDung
                                FOREIGN KEY (Ma_nguoi_dung)
                                REFERENCES Nguoi_dung(Ma_nguoi_dung)
                            )";
                        cmd.ExecuteNonQuery();

                        // Tạo bảng Loai_thiet_bi
                        cmd.CommandText = @"
                            CREATE TABLE Loai_thiet_bi (
                                Ma_loai_thiet_bi INT IDENTITY(1,1) PRIMARY KEY,
                                Ten_loai_thiet_bi NVARCHAR(100) NOT NULL,
                                Mo_ta_loai_thiet_bi NVARCHAR(255)
                            )";
                        cmd.ExecuteNonQuery();

                        // Tạo bảng Trang_thai_su_dung
                        cmd.CommandText = @"
                            CREATE TABLE Trang_thai_su_dung (
                                Ma_trang_thai INT IDENTITY(1,1) PRIMARY KEY,
                                Ten_trang_thai NVARCHAR(50) NOT NULL
                            )";
                        cmd.ExecuteNonQuery();

                        // Tạo bảng Trang_thiet_bi
                        cmd.CommandText = @"
                            CREATE TABLE Trang_thiet_bi (
                                Ma_trang_thiet_bi NVARCHAR(10) PRIMARY KEY,
                                Ten_trang_thiet_bi NVARCHAR(255),
                                Ma_loai_thiet_bi INT NOT NULL,
                                Ma_phong_ban INT NOT NULL,
                                Ma_trang_thai INT NOT NULL,
                                Don_vi_tinh NVARCHAR(10) NOT NULL,
                                So_seri NVARCHAR(100),
                                Brand NVARCHAR(100),
                                Model NVARCHAR(100),
                                Cau_hinh NVARCHAR(255),
                                Loai_ket_noi NVARCHAR(100),
                                Thoi_gian_mua DATE,
                                Thoi_gian_bao_tri DATE,
                                Hang_bao_hanh DATE,
                                Thoi_gian_dua_vao_su_dung DATE,
                                Thoi_gian_them DATETIME DEFAULT GETDATE(),
                                Don_gia MONEY,
                                Ghi_chu NVARCHAR(255),
                                IP NVARCHAR(255),
                                CONSTRAINT FK_TTB_Loai
                                FOREIGN KEY (Ma_loai_thiet_bi)
                                REFERENCES Loai_thiet_bi(Ma_loai_thiet_bi),
                                CONSTRAINT FK_TTB_PhongBan
                                FOREIGN KEY (Ma_phong_ban)
                                REFERENCES Phong_ban(Ma_phong_ban),
                                CONSTRAINT FK_TTB_TrangThai
                                FOREIGN KEY (Ma_trang_thai)
                                REFERENCES Trang_thai_su_dung(Ma_trang_thai)
                            )";
                        cmd.ExecuteNonQuery();

                        // Tạo bảng Lich_su_trang_thiet_bi
                        cmd.CommandText = @"
                            CREATE TABLE Lich_su_trang_thiet_bi (
                                Ma_lich_su INT IDENTITY(1,1) PRIMARY KEY,
                                Ma_trang_thiet_bi NVARCHAR(10) NOT NULL,  
                                Ma_nguoi_dung INT NOT NULL,     
                                Ma_phong_ban INT NOT NULL,        
                                Ma_trang_thai INT NOT NULL,      
                                Hanh_dong NVARCHAR(100) NOT NULL, 
                                Ghi_chu NVARCHAR(255),           
                                Thoi_gian DATETIME DEFAULT GETDATE(),
                                CONSTRAINT FK_LS_TTB
                                FOREIGN KEY (Ma_trang_thiet_bi)
                                REFERENCES Trang_thiet_bi(Ma_trang_thiet_bi),
                                CONSTRAINT FK_LS_NguoiDung
                                FOREIGN KEY (Ma_nguoi_dung)
                                REFERENCES Nguoi_dung(Ma_nguoi_dung),
                                CONSTRAINT FK_LS_PhongBan
                                FOREIGN KEY (Ma_phong_ban)
                                REFERENCES Phong_ban(Ma_phong_ban),
                                CONSTRAINT FK_LS_TrangThai
                                FOREIGN KEY (Ma_trang_thai)
                                REFERENCES Trang_thai_su_dung(Ma_trang_thai)
                            )";
                        cmd.ExecuteNonQuery();

                        // Thêm dữ liệu mẫu
                        InsertSampleData(cmd);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tạo bảng:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Thêm dữ liệu mẫu
        /// </summary>
        private static void InsertSampleData(SqlCommand cmd)
        {
            // Thêm phòng ban mẫu
            cmd.CommandText = @"
                INSERT INTO Phong_ban (Ten_phong_ban) VALUES 
                (N'Phòng IT'),
                (N'Phòng Kế toán'),
                (N'Phòng Nhân sự'),
                (N'Phòng Kinh doanh')";
            cmd.ExecuteNonQuery();

            // Thêm quyền mẫu
            cmd.CommandText = @"
                INSERT INTO Quyen (Ten_quyen) VALUES 
                (N'Admin'),
                (N'Quản lý'),
                (N'Nhân viên')";
            cmd.ExecuteNonQuery();

            // Thêm user admin
            cmd.CommandText = @"
                INSERT INTO Nguoi_dung (Ho_ten, Ma_phong_ban, Username, Password) 
                VALUES (N'Quản trị viên', 1, 'admin', 'admin123')";
            cmd.ExecuteNonQuery();

            // Gán quyền admin
            cmd.CommandText = @"
                INSERT INTO Phong_ban_Quyen (Ma_quyen, Ma_nguoi_dung) 
                VALUES (1, 1)";
            cmd.ExecuteNonQuery();

            // Thêm loại thiết bị mẫu
            cmd.CommandText = @"
                INSERT INTO Loai_thiet_bi (Ten_loai_thiet_bi, Mo_ta_loai_thiet_bi) VALUES 
                (N'Máy tính', N'Máy tính để bàn và laptop'),
                (N'Máy in', N'Máy in các loại'),
                (N'Màn hình', N'Màn hình máy tính'),
                (N'Phụ kiện', N'Bàn phím, chuột, tai nghe...')";
            cmd.ExecuteNonQuery();

            // Thêm trạng thái mẫu
            cmd.CommandText = @"
                INSERT INTO Trang_thai_su_dung (Ten_trang_thai) VALUES 
                (N'Đang sử dụng'),
                (N'Hỏng'),
                (N'Bảo trì'),
                (N'Chờ thanh lý')";
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Bước 3: Detach database
        /// </summary>
        public static bool DetachDatabase()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(masterConnStr))
                {
                    conn.Open();

                    string detachQuery = @"
                        IF EXISTS (SELECT name FROM sys.databases WHERE name = 'QuanLyThietBi')
                        BEGIN
                            ALTER DATABASE QuanLyThietBi SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                            EXEC sp_detach_db 'QuanLyThietBi', 'true';
                        END";

                    using (SqlCommand cmd = new SqlCommand(detachQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi detach:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Bước 4: Copy lên server share
        /// </summary>
        public static bool CopyToShare()
        {
            try
            {
                string shareDir = Path.GetDirectoryName(shareDbPath);

                // Kiểm tra thư mục share
                if (!Directory.Exists(shareDir))
                {
                    MessageBox.Show($"Không tìm thấy thư mục:\n{shareDir}\n\nVui lòng kiểm tra đường dẫn!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Copy file .mdf
                File.Copy(localDbPath, shareDbPath, true);

                // Copy file .ldf
                if (File.Exists(localLogPath))
                    File.Copy(localLogPath, shareLogPath, true);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi copy file:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Chạy toàn bộ setup
        /// </summary>
        public static void RunFullSetup()
        {
            if (MessageBox.Show(
                "Bạn muốn tạo database mới?\n\n" +
                "Lưu ý: Dữ liệu cũ (nếu có) sẽ bị xóa!",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            // Bước 1
            if (!CreateDatabaseFile())
            {
                MessageBox.Show("Setup thất bại ở bước 1!", "Lỗi");
                return;
            }
            MessageBox.Show("✓ Bước 1: Đã tạo database file", "Thông báo");

            // Bước 2
            if (!CreateTables())
            {
                MessageBox.Show("Setup thất bại ở bước 2!", "Lỗi");
                return;
            }
            MessageBox.Show("✓ Bước 2: Đã tạo bảng và dữ liệu mẫu", "Thông báo");

            // Bước 3
            if (!DetachDatabase())
            {
                MessageBox.Show("Setup thất bại ở bước 3!", "Lỗi");
                return;
            }
            MessageBox.Show("✓ Bước 3: Đã detach database", "Thông báo");

            // Bước 4
            if (!CopyToShare())
            {
                MessageBox.Show("Setup thất bại ở bước 4!", "Lỗi");
                return;
            }

            MessageBox.Show(
                "✓✓✓ SETUP HOÀN TẤT! ✓✓✓\n\n" +
                $"Database đã được tạo tại:\n{shareDbPath}\n\n" +
                "Thông tin đăng nhập:\n" +
                "Username: admin\n" +
                "Password: admin123",
                "Thành công",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}