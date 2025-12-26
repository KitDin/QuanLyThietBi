using Microsoft.Data.SqlClient;
using QuanLyThietBi.Helpers;
using QuanLyThietBi.Helpers.auth;
using System.Drawing.Drawing2D;

namespace QuanLyThietBi
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.ResumeLayout(false);
            this.AcceptButton = loginButton;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void login_click(object sender, EventArgs e)
        //{
        //    string email = textBox1.Text;
        //    string password = textBox2.Text;
        //    //if (Helpers.Validate.IsEmpty(email) || Helpers.Validate.IsEmpty(password))
        //    //{
        //    //    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
        //    //    return;
        //    //}

        //    try
        //    {
        //        var user = Helpers.db.Login.CheckLogin("admin", "123456");
        //        UserSession.Set(user);

        //        if (user != null)
        //        {
        //            home homeForm = new home();
        //            homeForm.FormClosed += (s, args) =>
        //            {
        //                Application.Exit();
        //            };

        //            homeForm.Show();
        //            this.Hide();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi: 111 " + ex.Message);
        //        return;
        //    }

        //}

        private void cancel_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            //if (Helpers.Validate.IsEmpty(email) || Helpers.Validate.IsEmpty(password))
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
            //    return;
            //}

            try
            {
                //var user = Helpers.db.Login.CheckLogin(email, password);
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
    }
}
