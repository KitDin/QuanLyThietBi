using Microsoft.Data.SqlClient;
using QuanLyThietBi.Helpers;
using QuanLyThietBi.Helpers.auth;

namespace QuanLyThietBi
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            tableLayoutPanel1.Left =
                (panel1.ClientSize.Width - tableLayoutPanel1.Width) / 2;

            tableLayoutPanel1.Top =
                (panel1.ClientSize.Height - tableLayoutPanel1.Height) / 2;

        }

        private void login_click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;
            //if (Helpers.Validate.IsEmpty(email) || Helpers.Validate.IsEmpty(password))
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
            //    return;
            //}

            try
            {
                var user = Helpers.db.Login.CheckLogin("admin", "123456");
                UserSession.Set(user);

                if (user != null)
                {
                    home homeForm = new home();
                    homeForm.FormClosed += (s, args) =>
                    {
                        Application.Exit();
                    };

                    homeForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: 111 " + ex.Message);
                return;
            }

        }

        private void cancel_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
