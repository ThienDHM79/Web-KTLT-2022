using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_KTLT_2022.Entities;
using Web_KTLT_2022.Services;

namespace Web_KTLT_2022.Pages
{
    public class MH_CongPhansoModel : PageModel
    {
        public PHANSO A { get; set; }
        public PHANSO B { get; set; }
        public string Chuoi { get; set; }

        [BindProperty]
        public int mauA { get; set; }
        [BindProperty]
        public int tuA { get; set; }

        [BindProperty]
        public int mauB { get; set; }
        [BindProperty]
        public int tuB { get; set; }

        public void OnGet()
        {
            Chuoi = string.Empty;
        }
        public void OnPost()
        {
            PHANSO A = new PHANSO();
            A.TuSo = tuA;
            A.MauSo = mauA;
            PHANSO B = new PHANSO(); 
            B.TuSo = tuB;
            B.MauSo = mauB;
            PHANSO s = XuliPhanSo.Tong2PhanSo(A, B);
            Chuoi = $"{s.TuSo}/{s.MauSo}";

        }
    }
}
