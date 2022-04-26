using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_KTLT_2022.Entities;
using Web_KTLT_2022.Services;

namespace Web_KTLT_2022.Pages
{
    public class MH_TinhKhoangCach2DiemModel : PageModel
    {
        public DIEM A, B;
        [BindProperty]
        public int Ax { get; set; }
        [BindProperty]
        public int Ay { get; set; }
        [BindProperty]
        public int Bx { get; set; }
        [BindProperty]
        public int By { get; set; }
        public string Chuoi { get; set; }
        public void OnGet()
        {
            A.x = 0;
            A.y = 1;
            B.x = 2;
            B.y = 3;
        }
        public void OnPost()
        {
            A.x = Ax;
            A.y = Ay;
            B.x = Bx;
            B.y = By;
            double kc = XuliDiem.TinhKhoangCach(A, B);
            Chuoi = $"khoang cach la {kc}";

        }
    }
}
