using System;
using System.Collections.Generic;
using Web_KTLT_2022.Entities;
using System.IO;
using Newtonsoft.Json;
namespace Web_KTLT_2022.DA
{
    public class LuuTruSanPham
    {
        public static bool LuuSanPham(SanPham s)
        {
            List<SanPham> dsSanPham = DocDanhSachSanPham();
            //fix ds.add ko nhan SanPham s -> file json nhap [] va save
            dsSanPham.Add(s);
            LuuDanhSachSanPham(dsSanPham);
            return true;

        }
        public static List<SanPham> DocDanhSachSanPham()
        {
            StreamReader reader = new StreamReader("F:\\4.CNTT-VB2 KHTN\\2.HK2-2021\\KTLT\\sanpham.json");
            string jsonString = reader.ReadToEnd();
            reader.Close();

            List<SanPham> dsSanPham = JsonConvert.DeserializeObject <List<SanPham>>(jsonString);
            return dsSanPham;
        }
        public static bool LuuDanhSachSanPham(List<SanPham> dsSP)
        {
            StreamWriter writer = new StreamWriter("F:\\4.CNTT-VB2 KHTN\\2.HK2-2021\\KTLT\\sanpham.json");

            string jsonString = JsonConvert.SerializeObject(dsSP);
            writer.Write(jsonString);
            writer.Close();

            return true;
        }
        public static bool SuaSanPham(SanPham sp)
        {
            List<SanPham> dssp = LuuTruSanPham.DocDanhSachSanPham();
            for(int i = 0; i < dssp.Count; i++)
            {
                if(dssp[i].MaSanPham==sp.MaSanPham)
                {
                    dssp[i] = sp;
                    LuuTruSanPham.LuuDanhSachSanPham(dssp);
                    return true;
                }
            }
            return false;
        }
        public static bool XoaSanPham(string id)
        {
            List<SanPham> dssp = LuuTruSanPham.DocDanhSachSanPham();
            for (int i = 0; i < dssp.Count; i++)
            {
                if (dssp[i].MaSanPham == id)
                {
                    dssp.RemoveAt(i);
                    LuuTruSanPham.LuuDanhSachSanPham(dssp);
                    return true;
                }
            }
            return false;
        }
    }
}
