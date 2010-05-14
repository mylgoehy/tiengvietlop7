using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Xml;
using DTO;

namespace DAO
{
    public class DocHieuDao
    {
        public static DocHieuDto Khoi_Tao(XmlElement nut)
        {
            DocHieuDto kq = new DocHieuDto();
            kq.DanhSachBaiTap = new ArrayList();

            foreach(XmlElement nut_con in nut.ChildNodes)
            {
                kq.DanhSachBaiTap.Add(BaiTapDao.Khoi_Tao(nut_con));
            }

            return kq;
        }
    }
}
