using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_KTLT_2022.Entities;
using Web_KTLT_2022.Services;

namespace Web_KTLT_2022.Pages
{
    public class MH_DangKyModel : PageModel
    {
        public string Chuoi;
        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Password { get; set; }
        [BindProperty]
        public string FullName { get; set; }

        public void OnGet()
        {

        }
        public void OnPost()
        {
            bool kq = XuLiNguoiDung.DangKy(Username, Password, FullName);
            Chuoi = $"Ket qua la {kq}";
            if (kq == true)
            {
                Response.Redirect("/AprMH_DanhSachSanPham");
            }
        }

    }
}
