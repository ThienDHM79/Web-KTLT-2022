using System;
using System.Collections.Generic;
using Web_KTLT_2022.Entities;
using System.IO;
namespace Web_KTLT_2022.DA
{
    public class LuuTruPhanSo
    {
        public static void  Luu(PHANSO a)
        {
            //code luu phan so xuong tep
            StreamWriter file = new StreamWriter("F:\\4.CNTT-VB2 KHTN\\2.HK2-2021\\KTLT\\phanso.txt");
            file.Write($"{a.TuSo}/{a.MauSo}");
            file.Close();
        }
    }
}
