using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using DTO;
using System.Collections;

namespace DAO
{
    public class VanBanDAO
    {
        public static VanBanDTO KhoiTao(XmlElement Root)
        {
            VanBanDTO VanBan = new VanBanDTO();

            VanBan.TieuDe = Root.GetAttribute("TieuDe");
            VanBan.PhuDe = Root.GetAttribute("PhuDe");
            VanBan.AmThanh = Root.GetAttribute("AmThanh");

            VanBan.ArrDoanVan = new ArrayList();

            foreach (XmlElement Node in Root.ChildNodes)
            {
                VanBan.ArrDoanVan.Add(DoanVanDAO.KhoiTao(Node)); 
            }
 
            return VanBan;
        }

        public static VanBanDTO LayVanBanTheoTieuDe(string BaiHoc_XML, string TieuDe)
        {
            VanBanDTO VanBan = new VanBanDTO();

            XmlDocument XmlD = new XmlDocument();
            XmlD.Load(BaiHoc_XML);

            XmlNodeList ListVanBan = XmlD.GetElementsByTagName("VANBAN");

            foreach (XmlElement VB in ListVanBan)
            {
                if (VB.GetAttribute("TieuDe") == TieuDe)
                {
                    VanBan = KhoiTao(VB);
                    break;
                }
            }

            return VanBan;
        }
    }
}
