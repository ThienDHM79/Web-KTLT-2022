using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_KTLT_2022.Entities;
using Web_KTLT_2022.Services;

namespace Web_KTLT_2022.Pages
{
    public class AprMH_TaoSanPhamModel : PageModel
    {
        public string Chuoi;
        [BindProperty]
        public string masp { get; set; }
        [BindProperty]
        public string tensp { get; set; }
        [BindProperty]
        public int giasp { get; set; }
        //xuat danh sach ra screen. tao bien
        public SanPham s;

        public void OnGet()
        {
            Chuoi = String.Empty;
            

        }
        public void OnPost()
        {
            SanPham s;
            s.MaSanPham = masp;
            s.TenSanPham = tensp;
            s.Gia = giasp;
            bool kq = XuliSanPham.TaoSanPham(s);
            Chuoi = $"Ket qua la {kq}";
        }

    }
}
