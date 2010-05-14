using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using DTO;

namespace DAO
{
    public class DoanVanDao
    {
        public static DoanVanDto Khoi_Tao(XmlElement nut)
        {
            DoanVanDto kq = new DoanVanDto();            
            kq.NoiDung = nut.GetAttribute("NoiDung");
            return kq;       
        }
    }
}
