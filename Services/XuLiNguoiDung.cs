using Web_KTLT_2022.Entities;
using Web_KTLT_2022.DA;
using System.Collections.Generic;
namespace Web_KTLT_2022.Services
{

    public class XuLiNguoiDung
    {
        public static bool DangKy(string username, string password, string fullname)
        {
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password)||
                string.IsNullOrWhiteSpace(fullname))
            {
                return false;
            }
            NguoiDung? user = LuuTruNguoiDung.TimNguoiDung(username);
            if(user != null)
            {
                return false;
            }
            else
            {
                NguoiDung newUser;
                newUser.FullName = fullname;
                newUser.Password = password;
                newUser.Username = username;
                return LuuTruNguoiDung.ThemNguoiDung(newUser);
            }
        }
        public static NguoiDung? DangNhap(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) ||
           string.IsNullOrWhiteSpace(password))
            {
                return null;
            }
            NguoiDung? user = LuuTruNguoiDung.TimNguoiDung(username);
            if (user != null && user.Value.Password == password)
            {
                return user;
            }
            return null;
        }

    }




}

    
    