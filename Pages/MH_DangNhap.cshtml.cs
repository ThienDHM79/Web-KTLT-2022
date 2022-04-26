using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_KTLT_2022.Entities;
using Web_KTLT_2022.Services;
using Microsoft.AspNetCore.Http;

namespace Web_KTLT_2022.Pages
{
    public class MH_DangNhapModel : PageModel
    {
        public string Chuoi;
        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Password { get; set; }

        public void OnGet()
        {

        }
        public void OnPost()
        {
            NguoiDung? user = XuLiNguoiDung.DangNhap(Username, Password);
            if (user != null)
            {
                HttpContext.Session.SetString("user", user.Value.Username);
                Response.Redirect("/AprMH_DanhSachSanPham");
            }
            else
            {
                Chuoi = "Dang nhap khong thanh cong";
            }
        }

    }
}
