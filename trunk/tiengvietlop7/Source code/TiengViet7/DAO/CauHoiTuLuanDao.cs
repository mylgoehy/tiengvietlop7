using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using DTO;
namespace DAO
{   
    public class CauHoiTuLuanDao
    {
        public static CauHoiTuLuanDto Khoi_tao(XmlElement Nut)
        {
            CauHoiTuLuanDto kq = new CauHoiTuLuanDto();
            kq.SoTT = int.Parse(Nut.GetAttribute("SoThuTu"));
            kq.NoiDung = Nut.GetAttribute("NoiDung");
            return kq;
        }

        
    }
}
