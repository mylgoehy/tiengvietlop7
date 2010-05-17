using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using DTO;

namespace DAO
{
    public class BaiHocVanHocDAO
    {
        public static BaiHocVanHocDTO KhoiTao(XmlElement Root)
        {
            BaiHocVanHocDTO BaiHocVanHoc = new BaiHocVanHocDTO();

            BaiHocVanHoc.SoThuTu = int.Parse(Root.GetAttribute("SoThuTu"));
            BaiHocVanHoc.LoaiBaiHocVanHoc = Root.GetAttribute("LoaiBaiHocVanHoc");

            int i = 0;
            foreach (XmlElement Node in Root.ChildNodes)
            {
                if (i == 0)
                    BaiHocVanHoc.VanBan = VanBanDAO.KhoiTao(Node);
                else
                    BaiHocVanHoc.DocHieu = DocHieuDAO.KhoiTao(Node);

                i++;
            }

            return BaiHocVanHoc;
        }
    }
}
