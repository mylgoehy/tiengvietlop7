using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Xml;
using DTO;

namespace DAO
{
    public class VanBanDao
    {
        public static VanBanDto Khoi_Tao(XmlElement nut)
        {
            VanBanDto kq = new VanBanDto();
            kq.TieuDe = nut.GetAttribute("TieuDe");
            kq.PhuDe = nut.GetAttribute("PhuDe");
            kq.AmThanh = nut.GetAttribute("AmThanh");
            kq.DanhSachDoanVan = new ArrayList();
            
            foreach (XmlElement nut_con in nut.ChildNodes)
            {
                kq.DanhSachDoanVan.Add(DoanVanDao.Khoi_Tao(nut_con));            
            }

            return kq;
        }

        public static VanBanDto LayVanBanTheoTieuDe(string filename, string tieude)
        {
            VanBanDto kq = new VanBanDto();                       
            XmlDocument tai_lieu = LT_XML.Doc(filename);
            XmlNodeList danh_sach_van_ban = tai_lieu.GetElementsByTagName("VANBAN");
            
            foreach (XmlElement vb in danh_sach_van_ban)
            {                 
                if (vb.GetAttribute("TieuDe") == tieude)
                {
                    kq = Khoi_Tao(vb);
                    break;
                }
            }            
            
            return kq;
        }
    }
}
