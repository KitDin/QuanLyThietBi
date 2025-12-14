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

        private void quanLyThietBiButton_Click(object sender, EventArgs e)
        {
            panelDanhMucConQL.Visible = !panelDanhMucConQL.Visible;
        }

        private void btnThietBi_Click(object sender, EventArgs e)
        {
            LoadForm(new QuanLyThietBiForm());
        }

        private void btnThietBiCoCauHinh_Click(object sender, EventArgs e)
        {
            LoadForm(new QuanLyIPThietBi());
        }


    }


}
