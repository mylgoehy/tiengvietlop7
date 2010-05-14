using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Xml;
using DTO;

namespace DAO
{
    public class BaiTapDao
    {
        public static BaiTapDto Khoi_Tao(XmlElement nut)
        {
            BaiTapDto kq = new BaiTapDto();
            kq.SoTT = int.Parse(nut.GetAttribute("SoThuTu"));
            kq.DanhSachCauHoiTuLuan = new ArrayList();
            foreach (XmlElement nut_con in nut.ChildNodes)
            {
                CauHoiTuLuanDto chtl = CauHoiTuLuanDao.Khoi_tao(nut_con);
                kq.DanhSachCauHoiTuLuan.Add(chtl);
            }

            return kq;
        }

        public static BaiTapDto[] LayBaiTapTheoTieuDeVanBan(string filename, string tieude)
        {
            ArrayList myList = new ArrayList();
            BaiTapDto[] danh_sach_bai_tap;
            XmlDocument tai_lieu = LT_XML.Doc(filename);
            XmlNodeList danh_sach_van_ban = tai_lieu.GetElementsByTagName("VANBAN");

            foreach (XmlElement vb in danh_sach_van_ban)
            {
                if (vb.GetAttribute("TieuDe") == tieude)
                {
                    XmlNode nut_dh = vb.NextSibling;
                    foreach (XmlElement nut_bt in nut_dh.ChildNodes)
                    {
                        BaiTapDto bt = Khoi_Tao(nut_bt);
                        myList.Add(bt);
                    }
                    break;
                }
            }

            danh_sach_bai_tap = (BaiTapDto[])myList.ToArray(typeof(BaiTapDto));
            return danh_sach_bai_tap;
        }
    }
}
