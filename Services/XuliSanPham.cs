 using Web_KTLT_2022.Entities;
using Web_KTLT_2022.DA;
using System.Collections.Generic;
namespace Web_KTLT_2022.Services
{

    public class XuliSanPham
    {
        public static bool TaoSanPham(SanPham s)
        {
            //kiem tra tinh hop le cua san pham
            if (string.IsNullOrWhiteSpace(s.MaSanPham)|| string.IsNullOrWhiteSpace(s.TenSanPham) || s.Gia <= 0 ) 
            { return false; }

            //luu san pham
            return LuuTruSanPham.LuuSanPham(s);
        }
        public static List<SanPham> TimKiem(string tukhoa)
        {
            if (tukhoa == null) tukhoa = String.Empty;
            List<SanPham> dssp = LuuTruSanPham.DocDanhSachSanPham();
            //tao list rong truoc de add
            List<SanPham> kq = new List<SanPham>();
            foreach(SanPham sp in dssp)
            {
                if (sp.TenSanPham.Contains(tukhoa))
                {
                    kq.Add(sp);
                }
            }
            return kq;
        }
        public static SanPham? DocSanPham (string Id)
        {
            if(string.IsNullOrEmpty(Id)) return null;
            List<SanPham> dssp = LuuTruSanPham.DocDanhSachSanPham();
            foreach(SanPham sp in dssp)
            {
                if (sp.MaSanPham == Id)
                    return sp;
            }
            return null;
        }
        public static bool SuaSanPham(string id, string ten, int gia)
        {
            if (string.IsNullOrWhiteSpace(ten)|| string.IsNullOrWhiteSpace(id) )
            {
                return false;
            }
            //must nam o tang data access layer
            List<SanPham> dssp = LuuTruSanPham.DocDanhSachSanPham();
            for(int i = 0; i<dssp.Count; i++)
            {
                if (dssp[i].MaSanPham == id)
                {
                    SanPham spmoi;
                    spmoi.MaSanPham = id;
                    spmoi.TenSanPham = ten;
                    spmoi.Gia = gia;
                    //dssp[i] = spmoi;
                    //delete dssp[i] = sp
                    return LuuTruSanPham.SuaSanPham(spmoi);

                    //delete luu danh sach, return true

                    //LuuTruSanPham.LuuDanhSachSanPham(dssp);
                    //return true;

                }
            }
            
            return false;
        }
        public static bool XoaSanPham(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return false;
            }
            return LuuTruSanPham.XoaSanPham(id);
        }
    }




}

    
    