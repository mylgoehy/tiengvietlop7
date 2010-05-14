using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class DoanVanBus
    {
        public static string LayNoiDungDoanVan(DoanVanDto dv)
        {
            string str = dv.NoiDung;
            return str;
        }
    }
}
