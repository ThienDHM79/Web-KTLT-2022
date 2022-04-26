using System;
using System.Collections.Generic;
using Web_KTLT_2022.Entities;
using System.IO;
using Newtonsoft.Json;
namespace Web_KTLT_2022.DA
{
    public class LuuTruTamGiac
    {
        public static void  LuuFile(TAMGIAC t)
        {
            //code luu phan so xuong tep
            StreamWriter file = new StreamWriter("F:\\4.CNTT-VB2 KHTN\\2.HK2-2021\\KTLT\\tamgiac.txt");
            file.WriteLine($"({t.A.x};{t.A.y})");
            file.WriteLine($"({t.B.x};{t.B.y})");
            file.WriteLine($"({t.C.x};{t.C.y})");
            file.Close();
        }
        public static void Luu(TAMGIAC t)
        {
            StreamWriter file = new StreamWriter("F:\\4.CNTT-VB2 KHTN\\2.HK2-2021\\KTLT\\tamgiac.json");
            string json = JsonConvert.SerializeObject(t);
            file.WriteLine(json);
            file.Close();
        }
        public static TAMGIAC Doc()
        {
            TAMGIAC t;
            StreamReader file = new StreamReader("F:\\4.CNTT-VB2 KHTN\\2.HK2-2021\\KTLT\\tamgiac.txt");
            string s = file.ReadLine();
            t.A = LuuTruDiem.KhoiTaoDiem(s);
            s = file.ReadLine();
            t.B = LuuTruDiem.KhoiTaoDiem(s);
            s = file.ReadLine();
            t.C = LuuTruDiem.KhoiTaoDiem(s);

            file.Close();
            return t;
        }

        
    }
}
