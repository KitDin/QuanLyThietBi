using QuanLyThietBi.Helpers.auth;
using QuanLyThietBi.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThietBi
{
    public partial class home : Form
    {
        private Button currentActiveButton = null;
        private Button currentSubButton = null;



        public home()
        {
            InitializeComponent();
            timeCurrent.Text = DateTime.Now.ToString("yyyy");
            username2.Text = UserSession.CurrentUser?.HoTen ?? string.Empty;
        }
        private void LoadForm(Form form)
        {
            panelContent.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelContent.Controls.Add(form);
            form.Show();
        }

        private void ActiveButton(Button btn)
        {
            if (currentActiveButton != null)
            {
                // reset button cũ
                currentActiveButton.BackColor = Color.Transparent;
                currentActiveButton.ForeColor = Color.White;
            }

            // set button mới
            currentActiveButton = btn;
            btn.BackColor = Color.FromArgb(0, 122, 204); // xanh nổi bật
            btn.ForeColor = Color.White;
        }
        private void ResetSubButton(Button btn)
        {
            btn.BackColor = Color.Transparent;
            btn.ForeColor = Color.Black;
        }
        private void ActiveSubButton(Button btn)
        {
            if (currentSubButton != null)
            {
                ResetSubButton(currentSubButton);
            }

            currentSubButton = btn;
            btn.BackColor = Color.FromArgb(241, 243, 224); // xanh
            btn.ForeColor = Color.Black;
        }


        private void quanLyThietBiButton_Click(object sender, EventArgs e)
        {
            ActiveButton(quanLyThietBiButton);
            panelDanhMucConQL.Visible = !panelDanhMucConQL.Visible;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ActiveButton(btnThongKe);
            LoadForm(new ThongKeForm());
        }

        private void btnThietBi_Click(object sender, EventArgs e)
        {
            ActiveSubButton(btnThietBi);
            LoadForm(new QuanLyThietBiForm());
        }

        private void btnThietBiCoCauHinh_Click(object sender, EventArgs e)
        {
            ActiveSubButton(btnThietBiCoCauHinh);
            LoadForm(new QuanLyIPThietBi());
        }

        private void btnQuanLyDanhMuc_Click(object sender, EventArgs e)
        {
            ActiveButton(btnQuanLyDanhMuc);
        }

    }


}
