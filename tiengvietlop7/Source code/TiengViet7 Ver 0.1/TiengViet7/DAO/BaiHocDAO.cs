using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Xml;
using DTO;


namespace DAO
{
    public class BaiHocDAO
    {
        public static BaiHocDTO KhoiTao(XmlElement Root)
        {
            BaiHocDTO BaiHoc = new BaiHocDTO();

            BaiHoc.SoThuTu = int.Parse(Root.GetAttribute("SoThuTu"));

            BaiHoc.ArrBaiHocVanHoc = new ArrayList();
            foreach (XmlElement Node in Root.ChildNodes)
            {
                BaiHoc.ArrBaiHocVanHoc.Add(BaiHocVanHocDAO.KhoiTao(Node));
            }

            return BaiHoc;
        }

        public static BaiHocDTO LayBaiHoc(string BaiHoc_XML)
        {
            BaiHocDTO BaiHoc = new BaiHocDTO();

            XmlDocument XmlD = new XmlDocument();
            XmlD.Load(BaiHoc_XML);

            XmlElement Root = XmlD.DocumentElement;

            BaiHoc = KhoiTao(Root);

            return BaiHoc;
        }
    }
}
