using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThietBi
{
    public partial class ThemDiaChiIP : Form
    {

        Model.TrangThietBiDTOModel ttb = new Model.TrangThietBiDTOModel();
        Helpers.db.TrangThietBi trangThietBi = new Helpers.db.TrangThietBi();
        Helpers.db.PhongBan phongBan = new Helpers.db.PhongBan();
        string oldIpAddress = "";
        public ThemDiaChiIP(string mathietbi)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;

            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            ttb = trangThietBi.GetTrangThietBi(mathietbi);
            oldIpAddress = ttb.DiaChiIP;
            infoIp.Text = "Thêm địa chỉ IP cho thiết bị: " + ttb.TenTrangThietBi + " thuộc " + phongBan.GetById(ttb.MaPhongBan).Ten_phong_ban + ". ";
            this.AcceptButton = btnThem;
        }

        private void ThemDiaChiIP_Load(object sender, EventArgs e)
        {
            TextBox[] ips = { Ip1, Ip2, Ip3, Ip4 };

            foreach (var ip in ips)
            {
                ip.MaxLength = 3;
                ip.KeyPress += Ip_KeyPress;
                ip.TextChanged += Ip_TextChanged;
                ip.KeyDown += Ip_KeyDown;
            }
            FillOldIP(oldIpAddress);
        }


        private void Ip_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox current = sender as TextBox;

            if (char.IsControl(e.KeyChar))
                return;

            if (e.KeyChar == '.')
            {
                MoveNext(current);
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Ip_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox current = sender as TextBox;

            if (e.KeyCode == Keys.Back)
            {
                if (string.IsNullOrEmpty(current.Text))
                {
                    MovePrevious(current);
                    e.SuppressKeyPress = true;
                }
            }
        }


        private void Ip_TextChanged(object sender, EventArgs e)
        {
            TextBox current = sender as TextBox;

            if (string.IsNullOrEmpty(current.Text)) return;

            if (int.TryParse(current.Text, out int value))
            {
                if (value > 255)
                    current.Text = "255";
                else if (value < 1)
                    current.Text = "1";

                current.SelectionStart = current.Text.Length;

                if (current.Text.Length == 3)
                {
                    MoveNext(current);
                }
            }
        }

        private void MoveNext(TextBox current)
        {
            if (current == Ip1) Ip2.Focus();
            else if (current == Ip2) Ip3.Focus();
            else if (current == Ip3) Ip4.Focus();
        }

        private void MovePrevious(TextBox current)
        {
            if (current == Ip4) Ip3.Focus();
            else if (current == Ip3) Ip2.Focus();
            else if (current == Ip2) Ip1.Focus();
        }


        private bool IsValidIP(out string ip)
        {
            ip = "";

            TextBox[] ips = { Ip1, Ip2, Ip3, Ip4 };

            foreach (var box in ips)
            {
                if (string.IsNullOrWhiteSpace(box.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ 4 phần của địa chỉ IP!",
                        "Thiếu IP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    box.Focus();
                    return false;
                }

                if (!int.TryParse(box.Text, out int value) || value < 1 || value > 255)
                {
                    MessageBox.Show("Địa chỉ IP không hợp lệ (1 – 255)!",
                        "Sai IP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    box.Focus();
                    return false;
                }
            }

            ip = $"{Ip1.Text}.{Ip2.Text}.{Ip3.Text}.{Ip4.Text}";
            return true;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!IsValidIP(out string ip))
                return;

            if (!string.IsNullOrWhiteSpace(oldIpAddress) &&
                oldIpAddress.Equals(ip, StringComparison.OrdinalIgnoreCase))
            {
                this.DialogResult = DialogResult.OK;
                return;
            }

            var confirm = MessageBox.Show(
                $"Bạn có chắc muốn thay đổi địa chỉ IP:\n" +
                $"Cũ: {oldIpAddress}\nMới: {ip}",
                "Xác nhận thay đổi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm != DialogResult.Yes)
                return;

            ttb.DiaChiIP = ip;

            bool result = trangThietBi.UpdateDiaChiIP(ttb);

            if (result)
            {
                MessageBox.Show(
                    $"Thay đổi địa chỉ IP thành công!\nIP: {ip}",
                    "Thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(
                    "Không thể thay đổi địa chỉ IP!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void FillOldIP(string ip)
        {
            if (string.IsNullOrWhiteSpace(ip))
                return;

            string[] parts = ip.Split('.');

            if (parts.Length != 4)
                return;

            Ip1.Text = parts[0];
            Ip2.Text = parts[1];
            Ip3.Text = parts[2];
            Ip4.Text = parts[3];
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
