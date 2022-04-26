using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_KTLT_2022.Entities;
using Web_KTLT_2022.Services;
using System.Collections.Generic;

namespace Web_KTLT_2022.Pages
{
    public class AprMH_DanhSachSanPhamModel : PageModel
    {
        //set data type list cho ds
        public List<SanPham> dsSanPham;
        [BindProperty]
        public string TuKhoa { get; set; }
        public void OnGet()
        {
            //show het -> tu khoa = string.empty
            //tao ds rong truoc
            dsSanPham = new List<SanPham>();
            dsSanPham = XuliSanPham.TimKiem(string.Empty);
        }
        public void OnPost()
        {
           dsSanPham = XuliSanPham.TimKiem(TuKhoa);
        }

    }
}
