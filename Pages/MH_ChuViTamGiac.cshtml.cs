using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_KTLT_2022.Services;
using Web_KTLT_2022.Entities;

namespace Web_KTLT_2022.Pages
{
    public class MH_ChuViTamGiacModel : PageModel
    {
        public TAMGIAC t;
        [BindProperty]
        public int Ax { get; set; }
        [BindProperty]
        public int Ay { get; set; }
        [BindProperty]
        public int Bx { get; set; }
        [BindProperty]
        public int By { get; set; }
        [BindProperty]
        public int Cx { get; set; }
        [BindProperty]
        public int Cy { get; set; }
        public string Chuoi;
        public void OnGet()
        {
            t.A.x = 0;
            t.A.y = 0;
            t.B.x = 1;
            t.B.y = 1;
            t.C.x = 2;
            t.C.y = 2;
        }
        public void OnPost()
        {
            t.A.x = Ax;
            t.A.y = Ay;
            t.B.x = Bx;
            t.B.y = By;
            t.C.x= Cx;
            t.C.y= Cy;
            double chuvi = XuliTamGiac.TinhChuvi(t);
            Chuoi = $"chu vi la {chuvi}";
        }
    }
}
