using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class VanBanBus
    {
        public static VanBanDto LayVanBanTheoTieuDe(string filename, string tieude)
        {
            VanBanDto kq = DAO.VanBanDao.LayVanBanTheoTieuDe(filename, tieude);
            return kq;
        }

        public static string[] LayNoiDungVanBan(VanBanDto vb)
        {                     
            ArrayList danh_sach_noi_dung_doan_van = new ArrayList();
            foreach (DoanVanDto dv in vb.DanhSachDoanVan)
            {
                string nd = dv.NoiDung;
                danh_sach_noi_dung_doan_van.Add(nd);
            }
            string[] kq = (string[])danh_sach_noi_dung_doan_van.ToArray(typeof(string));
            return kq;
        }
    }
}
