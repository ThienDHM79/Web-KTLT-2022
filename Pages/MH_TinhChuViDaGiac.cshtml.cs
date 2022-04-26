using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_KTLT_2022.Entities;
using Web_KTLT_2022.Services;

namespace Web_KTLT_2022.Pages
{
    public class MH_TinhChuViDaGiacModel : PageModel
    {
        [BindProperty]
        public string ChuoiDaGiac { get; set; }
        public string Chuoi;
        //khai bao da giac de xuat ra screen
        public DAGIAC d;
        public void OnGet()
        {
            ChuoiDaGiac = "(4,5)|(1,6)|(3,7)|(4,1)";
            //de da giac ko null , stop error 
            d = XuliDaGiac.KhoiTao(ChuoiDaGiac);
            Chuoi = string.Empty;
        }
        public void OnPost()
        {
            //khai bao da giac. khi ko can len screen
            //DAGIAC d;
            d = XuliDaGiac.KhoiTao(ChuoiDaGiac);
            double chuvi = XuliDaGiac.TinhChuVi(d);
            Chuoi = $"Chu vi la {chuvi}";
        }
    }
}
