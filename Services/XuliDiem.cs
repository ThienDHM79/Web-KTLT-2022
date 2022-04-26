using Web_KTLT_2022.Entities;
using Web_KTLT_2022.DA;
namespace Web_KTLT_2022.Services
{

    public class XuliDiem
    {
        public static double TinhKhoangCach(DIEM a, DIEM b)
        {
           double kc = Math.Sqrt( (a.x- b.x)*(a.x-b.x) + (a.y- b.y)*(a.y-b.y));
            return kc;
        }
        public static bool LuuDiem(DIEM a)
        {
            LuuTruDiem.Luu(a);
            return true;
        }
        public static DIEM DocDiem()
        {
            return LuuTruDiem.Doc();

        }
        public static DIEM KhoiTao(string chuoi)
        {
            DIEM a = new DIEM();    
            chuoi = chuoi.Substring(1, chuoi.Length - 2);
            string[] mDiem = chuoi.Split(",");
            a.x = int.Parse(mDiem[0]);
            a.y = int.Parse(mDiem[1]);
            return a;
        }
    }
    
}

    
    