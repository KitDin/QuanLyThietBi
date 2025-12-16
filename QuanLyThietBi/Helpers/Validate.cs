using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace QuanLyThietBi.Helpers
{
    public static class Validate
    {
        public static bool IsEmpty(string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static bool IsNumber(string value)
        {
            return int.TryParse(value, out _);
        }

        public static bool IsEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        public static bool MinLength(string value, int min)
        {
            return value != null && value.Length >= min;
        }

        public static bool IsPositiveNumber(string value)
        {
            if (decimal.TryParse(value, out decimal result))
                return result > 0;

            return false;
        }

        public static bool IsValidIPv4(string ip)
        {
            if (IPAddress.TryParse(ip, out IPAddress address))
            {
                // Chỉ cho IPv4
                return address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork;
            }
            return false;
        }
        public static bool HasSpecialChar(string input)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(
                input,
                @"[^\p{L}\p{N}\s\-.]"
            );
        }




        public static bool ValidateTextBox(TextBox tb, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                MessageBox.Show($"{fieldName} không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb.Focus();
                return false;
            }

            if (HasSpecialChar(tb.Text))
            {
                MessageBox.Show($"{fieldName} không được chứa ký tự đặc biệt!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb.Focus();
                return false;
            }

            return true;
        }

        public static bool ValidateComboBox(ComboBox cb, string fieldName)
        {
            if (cb.SelectedIndex == -1)
            {
                MessageBox.Show($"Vui lòng chọn {fieldName}!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb.Focus();
                return false;
            }

            return true;
        }
        public static bool ValidateNumber(TextBox tb, string fieldName)
        {
            if (!decimal.TryParse(tb.Text, out _))
            {
                MessageBox.Show($"{fieldName} phải là số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb.Focus();
                return false;
            }
            return true;
        }


    }
}
