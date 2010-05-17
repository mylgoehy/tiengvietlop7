using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using DTO;
using System.Collections;

namespace DAO
{
    public class DocHieuDAO
    {
        public static DocHieuDTO KhoiTao(XmlElement Root)
        {
            DocHieuDTO DocHieu = new DocHieuDTO();

            DocHieu.ArrBaiTap = new ArrayList();
            foreach (XmlElement Node in Root.ChildNodes)
            {
                DocHieu.ArrBaiTap.Add(BaiTapDAO.KhoiTao(Node));
            }

            return DocHieu;
        }
    }
}
