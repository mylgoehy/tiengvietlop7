using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using DTO;

namespace DAO
{
    public class DoanVanDAO
    {
        public static DoanVanDTO KhoiTao(XmlElement Root)
        {
            DoanVanDTO DoanVan = new DoanVanDTO();

            DoanVan.NoiDung = Root.GetAttribute("NoiDung");

            return DoanVan;
        }
    }
}
