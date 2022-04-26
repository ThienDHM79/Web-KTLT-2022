using System;
using System.Collections.Generic;
using Web_KTLT_2022.Entities;
using System.IO;
using Newtonsoft.Json;
namespace Web_KTLT_2022.DA
{
    public class LuuTruNguoiDung
    {
        public static List<NguoiDung> DocDanhSachNguoiDung()
        {
            StreamReader reader = new StreamReader("F:\\4.CNTT-VB2 KHTN\\2.HK2-2021\\KTLT\\nguoidung.json");
            string jsonString = reader.ReadToEnd();
            reader.Close();
            List<NguoiDung> danhsachNguoiDung = JsonConvert.DeserializeObject<List<NguoiDung>>(jsonString);
            return danhsachNguoiDung;

        }
        public static bool LuuDanhSachNguoiDung(List<NguoiDung> dsnd)
        {
            StreamWriter writer = new StreamWriter("F:\\4.CNTT-VB2 KHTN\\2.HK2-2021\\KTLT\\nguoidung.json");

            string jsonString = JsonConvert.SerializeObject(dsnd);
            writer.Write(jsonString);
            writer.Close();

            return true;
        }
        public static NguoiDung? TimNguoiDung(string username)
        {
            List<NguoiDung> dsnd = DocDanhSachNguoiDung();
            for(int i = 0; i < dsnd.Count; i++)
            {
                if (dsnd[i].Username == username)
                { return dsnd[i]; }
                  
            }
            return null;
        }
        public static bool ThemNguoiDung(NguoiDung a)
        {
            List<NguoiDung> danhsachNguoiDung = DocDanhSachNguoiDung();
            danhsachNguoiDung.Add(a);
            LuuDanhSachNguoiDung(danhsachNguoiDung);
            return true;
        }
        
    }
}
