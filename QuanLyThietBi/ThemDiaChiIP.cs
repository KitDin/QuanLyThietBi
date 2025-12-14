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


        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
