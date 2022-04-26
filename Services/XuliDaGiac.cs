using Web_KTLT_2022.Entities;
using Web_KTLT_2022.DA;
namespace Web_KTLT_2022.Services
{

    public class XuliDaGiac
    {
        public static DAGIAC Doc()
        {
            DAGIAC t;
            t = LuuTruDaGiac.Doc();
            return t;
        }
        public static DAGIAC KhoiTao(string chuoiDinh)
        {
            DAGIAC t;
            //chuoi Dinh= "(4,5)|(1,6)|(3,7)|(4,1)"
            string[] m = chuoiDinh.Split("|", StringSplitOptions.RemoveEmptyEntries);
            t.DanhSachDinh = new DIEM[m.Length];
            for (int i = 0; i < m.Length; i++)
            {
                t.DanhSachDinh[i] = XuliDiem.KhoiTao(m[i]);
            }
            return t;
        }

        public static bool LuuDaGiac(DAGIAC d)
        {
            if (d.DanhSachDinh.Length <=2)
                return false;
            return LuuTruDaGiac.LuuDaGiac(d);
        }
        public static double TinhChuVi(DAGIAC d)
        {
            double chuvi = 0;
            for(int i = 0; i < d.DanhSachDinh.Length-1; i++)
            {
                chuvi += XuliDiem.TinhKhoangCach(d.DanhSachDinh[i], d.DanhSachDinh[i + 1]);
            }
            chuvi += XuliDiem.TinhKhoangCach(d.DanhSachDinh[0], d.DanhSachDinh[d.DanhSachDinh.Length - 1]);
            return chuvi;
        }
    }
    



}

    
    