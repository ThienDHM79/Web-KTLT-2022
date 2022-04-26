using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web_KTLT_2022.Pages
{
    public class MH_TestModel : PageModel
    {
        public string Chuoi { get; set; }
        public int A { get; set; }
        [BindProperty]
        public int x { get; set; }
        public void OnGet()
        {
            Chuoi = "Chao cac ban";
            A = 100;
        }
        public void OnPost()
        {
            A = x * 50;
        }

    }
}
