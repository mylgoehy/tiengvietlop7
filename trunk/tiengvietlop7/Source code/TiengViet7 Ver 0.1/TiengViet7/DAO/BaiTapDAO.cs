using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using DTO;
using System.Collections;

namespace DAO
{
    public class BaiTapDAO
    {
        public static BaiTapDTO KhoiTao(XmlElement Root)
        {
            BaiTapDTO BaiTap = new BaiTapDTO();

            BaiTap.SoThuTu = int.Parse(Root.GetAttribute("SoThuTu"));

            BaiTap.ArrCauHoi = new ArrayList();

            foreach (XmlElement Node in Root.ChildNodes)
            {
                BaiTap.ArrCauHoi.Add(CauHoiTuLuanDAO.KhoiTao(Node));
            }

            return BaiTap;
        }

        public static BaiTapDTO[] LayBaiTapTheoTieuDeVanBan(string BaiHoc_XML, string tieude)
        {
            BaiTapDTO[] DanhSachBaiTap;

            XmlDocument XmlD = new XmlDocument();
            XmlD.Load(BaiHoc_XML);

            XmlNodeList danh_sach_van_ban = XmlD.GetElementsByTagName("VANBAN");

            ArrayList ListBaiTap = new ArrayList();

            foreach (XmlElement vb in danh_sach_van_ban)
            {
                if (vb.GetAttribute("TieuDe") == tieude)
                {
                    XmlNode nut_dh = vb.NextSibling;
                    foreach (XmlElement nut_bt in nut_dh.ChildNodes)
                    {
                        BaiTapDTO BaiTap = KhoiTao(nut_bt);
                        ListBaiTap.Add(BaiTap);
                    }
                    break;
                }
            }

            DanhSachBaiTap = (BaiTapDTO[])ListBaiTap.ToArray(typeof(BaiTapDTO));
            return DanhSachBaiTap;
        }
    }
}
