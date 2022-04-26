using System;
using System.Collections.Generic;
using Web_KTLT_2022.Entities;
using System.IO;
namespace Web_KTLT_2022.DA
{
    public class LuuTruDaGiac
    {
        
        public static DAGIAC Doc()
        {
            DAGIAC t = new DAGIAC();
            StreamReader file = new StreamReader("F:\\4.CNTT-VB2 KHTN\\2.HK2-2021\\KTLT\\dagiac.txt");
            string s = file.ReadLine();
            int n = int.Parse(s);
            t.DanhSachDinh = new DIEM[n];
            for (int i = 0; i < n; i++)
            {
                s = file.ReadLine();
                t.DanhSachDinh[i] = LuuTruDiem.KhoiTaoDiem(s);
            }

            file.Close();
            return t;
        }

        public static bool LuuDaGiac(DAGIAC d)
        {
            StreamWriter writer = new StreamWriter("F:\\4.CNTT-VB2 KHTN\\2.HK2-2021\\KTLT\\dagiac.txt");
            writer.WriteLine(d.DanhSachDinh.Length);
            for (int i = 0; i < d.DanhSachDinh.Length; i++)
            {
                writer.WriteLine($"{d.DanhSachDinh[i].x},{d.DanhSachDinh[i].y}");
            }
            writer.Close();
            return true;
        }
    }
}
