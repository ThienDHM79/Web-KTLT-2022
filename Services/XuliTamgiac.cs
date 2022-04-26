using Web_KTLT_2022.Entities;
using Web_KTLT_2022.DA;
namespace Web_KTLT_2022.Services
{

    public class XuliTamGiac
    {
        public static double TinhChuvi(TAMGIAC t)
        {
            double a, b, c;
            a = XuliDiem.TinhKhoangCach(t.A, t.B);
            b = XuliDiem.TinhKhoangCach(t.B, t.C);
            c = XuliDiem.TinhKhoangCach(t.C, t.A);
            return a + b + c;
        }
        public static bool KiemtraTamGiac(TAMGIAC t)
        {
            double a, b,c;
            a = XuliDiem.TinhKhoangCach(t.B, t.C);
            b = XuliDiem.TinhKhoangCach(t.C, t.A);
            c = XuliDiem.TinhKhoangCach(t.A, t.B);
            return a + b > c && b + c > a && a + c > b;
        }
        public static bool LuuTamGiac(TAMGIAC t)
        {
            if(KiemtraTamGiac(t) == false)
            {
                return false;
            }
            LuuTruTamGiac.Luu(t);
            return true;
        }
        public static TAMGIAC DocTamGiac()
        {
            TAMGIAC t;
            t = LuuTruTamGiac.Doc();
            return t;
        }
    }



}

    
    