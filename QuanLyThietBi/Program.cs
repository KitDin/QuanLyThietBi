using QuanLyThietBi.Helpers.db;

namespace QuanLyThietBi
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string dbPath = @"\\192.168.1.100\thư mục nội bộ\KIETDINH\QuanLyThietBi.mdf";

            if (!File.Exists(dbPath))
            {
                DialogResult result = MessageBox.Show(
                    "Database chưa tồn tại!\n\n" +
                    "Bạn có phải là QUẢN TRỊ VIÊN và muốn tạo database mới không?\n\n" +
                    "⚠️ CHÚ Ý: Chỉ chạy Setup 1 LẦN DUY NHẤT trên máy chính!\n" +
                    "⚠️ Nếu bạn là USER thường, hãy chọn NO và liên hệ IT!",
                    "Setup Database",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DatabaseSetup.RunFullSetup();
                }
                else
                {
                    MessageBox.Show(
                        "Không tìm thấy database!\n\n" +
                        "Vui lòng liên hệ quản trị viên để setup database.",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}