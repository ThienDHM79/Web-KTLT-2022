using System;
using System.Collections.Generic;
using Web_KTLT_2022.Entities;
using System.IO;
using Newtonsoft.Json;
namespace Web_KTLT_2022.DA
{
    public class LuuTruDiem
    {
        public static void Luu (DIEM a)
        {
            StreamWriter file = new StreamWriter("F:\\4.CNTT-VB2 KHTN\\2.HK2-2021\\KTLT\\diemJSON.json");
            string json = JsonConvert.SerializeObject(a);
            file.WriteLine(json);
            file.Close();
        }
        public static void  Luu_File(DIEM a)
        {
            //code luu phan so xuong tep
            StreamWriter file = new StreamWriter("F:\\4.CNTT-VB2 KHTN\\2.HK2-2021\\KTLT\\diem.txt");
            file.Write($"({a.x};{a.y})");
            file.Close();
        }
        public static DIEM DocFile()
        {
            DIEM a;
            StreamReader file = new StreamReader("F:\\4.CNTT-VB2 KHTN\\2.HK2-2021\\KTLT\\diem.txt");
            string s = file.ReadLine();
            string[] m = s.Split(',');
            a.x = int.Parse(m[0]);
            a.y= int.Parse(m[1]);
            file.Close();
            return a;
        }
        public static DIEM Doc()
        {
            DIEM a;
            StreamReader file = new StreamReader("F:\\4.CNTT-VB2 KHTN\\2.HK2-2021\\KTLT\\diemJSON.json");
            string json = file.ReadToEnd();
            a = JsonConvert.DeserializeObject<DIEM>(json);
            file.Close ();
            return a;
        }
        public static DIEM KhoiTaoDiem(string s)
        {
            DIEM a;
            string[] m = s.Split(",");
            a.x = int.Parse(m[0]);
            a.y = int.Parse(m[1]);
            return a;
        }
    }
}
