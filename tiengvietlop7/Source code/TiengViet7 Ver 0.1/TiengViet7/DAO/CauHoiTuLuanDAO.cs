using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using DTO;

namespace DAO
{
    class CauHoiTuLuanDAO
    {
        public static CauHoiTuLuanDTO KhoiTao(XmlElement Root)
        {
            CauHoiTuLuanDTO CauHoiTuLuan = new CauHoiTuLuanDTO();

            CauHoiTuLuan.SoThuTu = int.Parse(Root.GetAttribute("SoThuTu"));
            CauHoiTuLuan.NoiDung = Root.GetAttribute("NoiDung");

            return CauHoiTuLuan;
        }
    }
}
