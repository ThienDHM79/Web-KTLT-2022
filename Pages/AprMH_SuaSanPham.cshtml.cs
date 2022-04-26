using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_KTLT_2022.Entities;
using Web_KTLT_2022.Services;
using System.Collections.Generic;

namespace Web_KTLT_2022.Pages
{
    public class AprMH_SuaSanPhamModel : PageModel
    {
        public SanPham SanPham;
        //de lay id tu MH Danh sach
        public bool coSanPham;
        [BindProperty(SupportsGet =true)]
        public string Id { get; set; }
        public string Chuoi;

        [BindProperty]
        public string tensp { get; set; }
        [BindProperty]
        public int giasp { get; set; }
        public void OnGet()
        {
            SanPham? sp = XuliSanPham.DocSanPham(Id);
            if (sp != null)
            {
                //de lay cac field cua object sp
                SanPham = sp.Value;
            }
                
            else
            {
                Chuoi = "Khong tim thay san pham";
            }
            coSanPham = ( sp != null );
        }
        public void OnPost()
        {
            bool kq = XuliSanPham.SuaSanPham(Id, tensp, giasp);
            Chuoi = $"ket qua la {kq}";
            Response.Redirect("/AprMH_DanhSachSanPham");
        }

    }
}
