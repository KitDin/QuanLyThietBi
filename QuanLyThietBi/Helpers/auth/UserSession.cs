using QuanLyThietBi.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyThietBi.Helpers.auth
{
    public static class UserSession
    {
        public static Model.UserLoginModel CurrentUser { get; private set; }

        public static void Set(UserLoginModel user)
        {
            CurrentUser = user;
        }

        public static void Clear()
        {
            CurrentUser = null;
        }


        public static bool IsAdmin =>
            CurrentUser?.Quyen == UserRole.Admin;
    }
}
