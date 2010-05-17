using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
using System.Collections;

namespace BUS
{
    public class VanBanBUS
    {
        public static VanBanDTO LayVanBanTheoTieuDe(string BaiHoc_XML, string tieude)
        {
            VanBanDTO VanBan = VanBanDAO.LayVanBanTheoTieuDe(BaiHoc_XML, tieude);
            return VanBan;
        }

        public static string[] LayNoiDungVanBan(VanBanDTO VanBan)
        {
            ArrayList ListNoiDungDoanVan = new ArrayList();
            foreach (DoanVanDTO DoanVan in VanBan.ArrDoanVan)
            {
                ListNoiDungDoanVan.Add(DoanVan.NoiDung);
            }

            string[] NoiDungVanBan = (string[])ListNoiDungDoanVan.ToArray(typeof(string));
            return NoiDungVanBan;
        }
    }
}
