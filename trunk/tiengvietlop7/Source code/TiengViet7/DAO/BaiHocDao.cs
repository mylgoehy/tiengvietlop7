using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Xml;
using DTO;

namespace DAO
{
    public class BaiHocDao
    {
        public static BaiHocDto Khoi_Tao(XmlElement nut)
        {
            BaiHocDto kq = new BaiHocDto();
            kq.SoThuTu = int.Parse(nut.GetAttribute("SoThuTu"));
            kq.DanhSachBaiVanHoc = new ArrayList();
            foreach (XmlElement nut_con in nut.ChildNodes)
            {
                kq.DanhSachBaiVanHoc.Add(BaiHocVanHocDao.Khoi_Tao(nut_con));
            }
            return kq;
        }

        public static BaiHocDto LayBaiDoc(string ten_file)
        {
            BaiHocDto kq = new BaiHocDto();
            XmlDocument tai_lieu = LT_XML.Doc(ten_file);
            XmlElement Goc = tai_lieu.DocumentElement;
            kq = Khoi_Tao(Goc);
            return kq;
        }
    }
}
