using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using DTO;

namespace DAO
{
    public class BaiHocVanHocDao
    {
        public static BaiHocVanHocDto Khoi_Tao(XmlElement nut)
        {
            BaiHocVanHocDto kq = new BaiHocVanHocDto();
            kq.SoThuTu = int.Parse(nut.GetAttribute("SoThuTu"));
            kq.LoaiBaiHocVanHoc = nut.GetAttribute("LoaiBaiHocVanHoc");
            int i = 0;
            
            foreach (XmlElement nut_con in nut.ChildNodes)
            {
                if (i == 0)
                    kq.VanBan = VanBanDao.Khoi_Tao(nut_con);

                if (i == 1)
                    kq.DocHieu = DocHieuDao.Khoi_Tao(nut_con);

                i++;
            }

            return kq;
        }
    }
}
