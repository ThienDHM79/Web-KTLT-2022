using Web_KTLT_2022.Entities;
using Web_KTLT_2022.DA;
namespace Web_KTLT_2022.Services
{
    public class XuliPhanSo
    {
        public static PHANSO NhapPhanSo(int tuso, int mauso)
        {
            Console.WriteLine("nhap phan so");
            PHANSO a;
            a.TuSo = tuso;
            a.MauSo = mauso;
            return a;
        }
        public static PHANSO Tong2PhanSo(PHANSO a, PHANSO b)
        {
            PHANSO kq;
            kq.TuSo = a.TuSo * b.MauSo + b.TuSo * a.MauSo;
            kq.MauSo = a.MauSo * b.MauSo;
            return kq;
        }
        public static bool LuuPhanSo(PHANSO a)
        {
            if(a.MauSo == 0)
            {
                return false;
            }
            LuuTruPhanSo.Luu(a);
            return true;
        }
    }
}

    
    