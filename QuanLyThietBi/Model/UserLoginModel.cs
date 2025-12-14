using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyThietBi.Model
{
    public class UserLoginModel
    {
        public int MaNguoiDung { get; set; }
        public string Username { get; set; }
        public string HoTen { get; set; }
        public UserRole Quyen { get; set; }
    }
}
